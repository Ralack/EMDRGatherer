using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMDRGatherer.Util
{
    class FileUtil
    {
        private const string ConfigFileName = @"\\Config.xml";
        private const string AppDataFolder = @"\\EMDR Gatherer";

        public string AppDataPath { get; private set; }
        public string ConfigFileFullpath { get; private set; }

        public FileUtil()
        {
            AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + AppDataFolder;
            ConfigFileFullpath = AppDataPath + ConfigFileName;
        }

        public string getConfigFilePath()
        {
            try
            {
                if (!Directory.Exists(AppDataPath))
                {
                    return ConfigFileFullpath;
                }
                else
                {
                    Directory.CreateDirectory(AppDataPath);
                    return ConfigFileFullpath;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool isConfigDirectoryExists()
        {
            return Directory.Exists(AppDataPath);
        }

        public bool createConfigDirectory()
        {
            try
            {
                if (!isConfigDirectoryExists())
                {
                    Directory.CreateDirectory(AppDataPath);
                    
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
