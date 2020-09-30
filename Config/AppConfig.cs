using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Diagnostics;

namespace AfvCompanion.Config
{
    class AppConfig : IAppConfig
    {
        [JsonIgnore]
        private static string mPath = "";

        [JsonIgnore]
        public string AppPath { get; set; }

        //Define separate variables
        public PTMConfiguration PTMConfiguration { get; set; }
        public string PTMApplication { get; set; }

        public AppConfig()
        {
            PTMConfiguration = new PTMConfiguration();
        }

        public void LoadConfig(string path)
        {
            try
            {
                JsonConvert.PopulateObject(File.ReadAllText(path), this);
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            finally
            {
                mPath = path;
            }
        }

        public void LoadConfig()
        {
            JsonConvert.PopulateObject(File.ReadAllText(mPath), this);
        }

        public void SaveConfig()
        {
            File.WriteAllText(mPath, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
