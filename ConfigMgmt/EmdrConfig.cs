using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;
using EMDRGatherer.ConfigMgmt;
using EMDRGatherer.Util;

namespace EMDRGatherer
{    
    class EmdrConfig 
    {
        [XmlIgnore]
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
                    XmlSerializer xserial = new XmlSerializer(Attr.GetType());

                    Attr = (ConfigAttributes)xserial.Deserialize(rdr);

                    rdr.Close();

                    return ConfigState.ConfigLoaded;

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
                string filename = futl.getConfigFilePath();

                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xserial = new XmlSerializer(Attr.GetType());
                xserial.Serialize(fs, Attr);

                fs.Flush();
                fs.Close();

                return ConfigState.ConfigSaved;
                
            }            
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        
    }

    public enum ConfigState
    {
        ConfigLoaded = 0x01,
        ConfigBlank = 0x02,
        ConfigNotLoaded = 0x04,
        ConfigNotFound = 0x08,
        ConfigSaved = 0x16
    }
   
}
