using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;
using EMDRGatherer.ConfigMgmt;
using EMDRGatherer.Util;

namespace EMDRGatherer
{    
    public class EmdrConfig 
    {
        private const string cfgFileName = "emdrconfig.xml";
       
        private const string Appname = "EMDRGatherer";
        
        public ConfigAttributes Attr {get; set;}
        public ConfigState CfgState { get; set; }

        public EmdrConfig()
        {
            CfgState = ConfigState.ConfigNotLoaded;
            Attr = new ConfigAttributes();

            CfgState = DeSerialize(); 
        }

        public void CleanUp()
        {
            Serialize();
        }

        public ConfigState WriteConfig()
        {
            return Serialize();
        }

        private ConfigState DeSerialize( )
        {
            FileUtil futl = new FileUtil();

            if (futl.isConfigDirectoryExists())
            {
                try
                {
                    string filename = futl.getConfigFilePath();

                    StreamReader rdr = new StreamReader(filename);

                    if (!rdr.EndOfStream)
                    {
                        XmlSerializer xserial = new XmlSerializer(Attr.GetType());
                        Attr = (ConfigAttributes)xserial.Deserialize(rdr);
                        rdr.Close();
                    }
                    else
                    {
                        rdr.Close();
                        return ConfigState.ConfigNotFound;
                    }

                    if (checkConfig())
                    {
                        Attr.isConfiged = true;
                        return ConfigState.ConfigLoaded;
                    }
                    else
                    {
                        Attr.isConfiged = false;
                        return ConfigState.ConfigInvalid;
                    }
                    

                }
                catch (Exception ex)
                {
                    if (ex is FileNotFoundException)
                    {
                        return ConfigState.ConfigNotFound;
                    }
                    throw ex;
                }
            }
            else
                return ConfigState.ConfigNotLoaded;
        }

        private ConfigState Serialize()
        {
            FileUtil futl = new FileUtil();

            if (!futl.isConfigDirectoryExists())
            {
                futl.createConfigDirectory();
            }

            try
            {
                if(checkConfig())
                {
                    string filename = futl.getConfigFilePath();

                    FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    XmlSerializer xserial = new XmlSerializer(Attr.GetType());
                    xserial.Serialize(fs, Attr);

                    fs.Flush();
                    fs.Close();                

                    return ConfigState.ConfigSaved;
                }
                else
                {
                    return ConfigState.ConfigInvalid;
                }
            }            
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public bool checkConfig()
        {
            try
            {
                Uri uri = new Uri(Attr.EMDRServer);

                if (!uri.IsWellFormedOriginalString())
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            try
            {
                var conn = new SqlConnectionStringBuilder(Attr.DataSource);
            }
            catch (Exception)
            {
                return false;
            }

            if (Attr.QueueDiskBufferSize < 0 || Attr.QueueDiskBufferSize > 1000000 ||
                    Attr.QueueHighWaterMark < 0 || Attr.QueueHighWaterMark > 1000000 ||
                    Attr.TrimHistDays < 0 || Attr.TrimHistDays > 1000000 ||
                    Attr.TrimOrdersDays < 0 || Attr.TrimOrdersDays > 1000000)
            {
                return false;
            }

            return true;
        }

        
    }

    public enum ConfigState
    {
        ConfigLoaded = 0x01,
        ConfigBlank = 0x02,
        ConfigNotLoaded = 0x04,
        ConfigNotFound = 0x08,
        ConfigSaved = 0x16,
        ConfigInvalid = 0x32
    }
   
}
