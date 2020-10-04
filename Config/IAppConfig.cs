namespace AfvCompanion.Config
{
    interface IAppConfig
    {
        //Define variables here
        PTMConfiguration PTMConfiguration { get; set; }
        string PTMApplication { get; set; }
        public string AutoDeafenApplication { get; set; }
        public string AutoDeafenApplication1 { get; set; }
        public string AutoDeafenApplication2 { get; set; }
        public string AutoDeafenApplication3 { get; set; }
        public string AutoDeafenApplication4 { get; set; }
        public string AutoDeafenApplication5 { get; set; }

        void SaveConfig();
        void LoadConfig(string path);
        void LoadConfig();
        string AppPath { get; set; }
    }
}
