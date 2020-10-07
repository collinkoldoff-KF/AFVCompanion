namespace AfvCompanion.Config
{
    interface IAppConfig
    {
        //Define variables here
        PTMConfiguration PTMConfiguration { get; set; }
        string PTMApplication { get; set; }
        string AutoDeafenApplication { get; set; }
        string AutoDeafenApplication1 { get; set; }
        string AutoDeafenApplication2 { get; set; }
        string AutoDeafenApplication3 { get; set; }
        string AutoDeafenApplication4 { get; set; }
        string AutoDeafenApplication5 { get; set; }
        float AppVolume { get; set; }
        bool PTMAutoRun { get; set; }
        bool AutoDeafenAutoRun { get; set; }


        void SaveConfig();
        void LoadConfig(string path);
        void LoadConfig();
        string AppPath { get; set; }
    }
}
