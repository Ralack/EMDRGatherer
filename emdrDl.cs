using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Std_Library.DataLayer;
using System.Web.Script.Serialization;
using ZMQ;
using System.IO;
using System.IO.Compression;
using System.Data.Entity;
using System.Data.SqlClient;
using EveAI.Live.EMDR;
using System.Diagnostics;
using System.ComponentModel;



namespace EMDRGatherer
{


    class emdrDl
    {
        const int ROWMAXCNT = 10;
        const int MILLISECMAX = 5000; // 5 second wait
        const int TRIMWAIT = 60000;


        public void getMarketData(object sender, DoWorkEventArgs e)
        {
            //int recCnt = 0;
            bwWorkerArgs inArgs = (bwWorkerArgs)e.Argument;
            Int64 histcnt = 0;
            Int64 ordcnt = 0;

                        
            using (var context = new Context())
            {
                using (var sub = context.Socket(SocketType.SUB))
                {
                    List<EMDRData> emdr = new List<EMDRData>();

                    BackgroundWorker worker = sender as BackgroundWorker;
                                        
                    //Connect to the first publicly available relay.                  
                    sub.Connect(inArgs.EMDRServer);
                    
                    // Disable filtering.
                    sub.SetSockOpt(SocketOpt.SUBSCRIBE, Encoding.UTF8.GetBytes(""));

                    while (worker.CancellationPending == false)
                    {
                        try
                        {

                            // Receive compressed raw market data.
                            var receivedData = sub.Recv();

                            // The following code lines remove the need of 'zlib' usage;
                            // 'zlib' actually uses the same algorith as 'DeflateStream'.
                            // To make the data compatible for 'DeflateStream', we only have to remove
                            // the four last bytes which are the adler32 checksum and
                            // the two first bytes which are the 'zlib' header.
                            byte[] decompressed;
                            byte[] choppedRawData = new byte[(receivedData.Length - 4)];
                            Array.Copy(receivedData, choppedRawData, choppedRawData.Length);
                            choppedRawData = choppedRawData.Skip(2).ToArray();

                            // Decompress the raw market data.
                            using (MemoryStream inStream = new MemoryStream(choppedRawData))
                            using (MemoryStream outStream = new MemoryStream())
                            {
                                DeflateStream outZStream = new DeflateStream(inStream, CompressionMode.Decompress);
                                outZStream.CopyTo(outStream);
                                decompressed = outStream.ToArray();
                            }

                            // Transform data into JSON strings.
                            string marketJson = Encoding.UTF8.GetString(decompressed);

                            // Un-serialize the JSON data to a dictionary.
                            var serializer = new JavaScriptSerializer();

                            //emdr[recCnt] = new EMDRData(serializer.Deserialize<Dictionary<string, object>>(marketJson));
                            EMDRData eData = new EMDRData(serializer.Deserialize<Dictionary<string, object>>(marketJson));
                            //recCnt++;

                            loadMessages(eData, inArgs);

                            foreach (Rowset rs in eData.Rowsets)
                            {
                                histcnt += rs.HistoryRows.Count;
                                ordcnt += rs.OrderRows.Count;
                            }

                            worker.ReportProgress(1, new bwResponse(histcnt, ordcnt));
                                                       
                        }
                        catch (ZMQ.Exception ex)
                        {
                            throw ex;
                        }
                    }
                    e.Cancel = true;
                }
            }
        }

        private void loadMessages(EMDRData edata, bwWorkerArgs bwinargs)
        {   
            emdrDSTableAdapters.emdrHistoryDataTableAdapter hisTblAdptr= new emdrDSTableAdapters.emdrHistoryDataTableAdapter();
            emdrDSTableAdapters.emdrOrderDataTableAdapter ordTblAdptr = new emdrDSTableAdapters.emdrOrderDataTableAdapter();

            hisTblAdptr.Connection.ConnectionString = bwinargs.ConnStr;
            ordTblAdptr.Connection.ConnectionString = bwinargs.ConnStr;
            
            foreach (Rowset rs in edata.Rowsets)
            {
                if (bwinargs.CaptureHistory)
                {
                    foreach (History hs in rs.HistoryRows)
                    {
                        hisTblAdptr.insEmdrHistoryData((int)rs.RegionID, rs.TypeID, hs.Date, hs.DateLocalTime,
                            hs.Orders, hs.Quantity, hs.High, hs.Low, hs.Average);
                    }
                }

                if (bwinargs.CaptureOrders)
                {
                    foreach (Order or in rs.OrderRows)
                    {
                        if (bwinargs.MergeDupes)
                        {
                            //We are merging duplicates (i.e. keeping newest record only)
                            ordTblAdptr.mergeEMDROrderData((int)rs.RegionID, rs.TypeID,
                                rs.GeneratedAt, rs.GeneratedAtLocalTime,
                                or.IssueDate, or.IssueDateLocalTime, (int)or.SolarSystemID,
                                or.StationID, or.OrderID, or.Range, or.VolEntered, or.VolRemaining, or.MinVolume, or.Price,
                                or.Duration, BitConverter.GetBytes(or.Bid)[0]);
                        }
                        else
                        {
                            //Capturing everything, something else is dealing with the multiple rows per orderid
                            ordTblAdptr.Insert((int)rs.RegionID, rs.TypeID,
                                rs.GeneratedAt, rs.GeneratedAtLocalTime,
                                or.IssueDate, or.IssueDateLocalTime, (int)or.SolarSystemID,
                                or.StationID, or.OrderID, or.Range, or.VolEntered, or.VolRemaining, or.MinVolume, or.Price,
                                or.Duration, BitConverter.GetBytes(or.Bid)[0]);

                        }
                    }
                }
            }

            return;
        }


        public void trimOrderData(object sender, DoWorkEventArgs e)
        {
            emdrDSTableAdapters.emdrOrderDataTableAdapter ordTblAdptr = new emdrDSTableAdapters.emdrOrderDataTableAdapter();

            BackgroundWorker worker = sender as BackgroundWorker;

            Stopwatch stw = new Stopwatch();
            stw.Start();

            while (worker.CancellationPending == false)
            {
                try
                {
                    if (stw.ElapsedMilliseconds == TRIMWAIT)
                    {
                        ordTblAdptr.trimOrderData();
                        stw.Restart();
                    }
                }
                catch (ZMQ.Exception ex)
                {
                    throw ex;
                }
            }
            e.Cancel = true;
        }
    }

    public class bwWorkerArgs
    {    
        public string EMDRServer { get; set; }
        public string ConnStr { get; set; }
        public bool MergeDupes { get; set; }   
        public bool CaptureHistory { get; set; }
        public bool CaptureOrders { get; set; }

        public bwWorkerArgs(string eserver, string connstr, bool mergedupes, bool capturehistory, bool captureorders)
        {
            EMDRServer = eserver;
            ConnStr = connstr;
            MergeDupes = mergedupes;           
            CaptureHistory = capturehistory;
            CaptureOrders = captureorders;
        }
    }

    public class bwResponse
    {       
        public Int64 HistCnt { get; set; }
        public Int64 OrdCnt { get; set; }
     
        public bwResponse(Int64 hcnt, Int64 ocnt)
        {            
            HistCnt = hcnt;
            OrdCnt = ocnt;            
        }
    }

    
}
