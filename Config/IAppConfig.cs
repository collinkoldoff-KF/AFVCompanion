using System;
using System.Collections.Generic;
using System.Text;

namespace AfvCompanion.Config
{
    interface IAppConfig
    {
        //Define variables here
        PTMConfiguration PTMConfiguration { get; set; }
        string PTMApplication { get; set; }

        void SaveConfig();
        void LoadConfig(string path);
        void LoadConfig();
        string AppPath { get; set; }
    }
}
