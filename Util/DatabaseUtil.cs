using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EMDRGatherer.Util
{
    class DatabaseUtil
    {

        public DatabaseUtil(EmdrConfig config)
        {

        }

        public SqlStatus checkDBConn(EmdrConfig config)
        {
            using (SqlConnection conn = new SqlConnection(config.Attr.DataSource))
            {

                string sql = @"SELECT [name] FROM sys.tables WHERE [type] = 'U' AND [name] = @TblName";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@TblName", SqlDbType.NVarChar);

                try
                {
                    conn.Open();

                    cmd.Parameters[0].Value = "emdrHistoryData";
                    string histTbl = (string)cmd.ExecuteScalar();

                    cmd.Parameters[0].Value = "emdrOrderData";
                    string ordTbl = (string)cmd.ExecuteScalar();

                    if (histTbl == "emdrHistoryData" && ordTbl == "emdrOrderData")
                    {
                        return SqlStatus.SqlConnGood;
                    }
                    else
                    {
                        return SqlStatus.SqlConnTablesMissing;
                    }

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public enum SqlStatus
        {
            SqlConnGood = 0x01,
            SqlConnFailed = 0x02,
            SqlConnDBNotExist = 0x04,
            SqlConnTablesMissing = 0x08

        }


    }
}
