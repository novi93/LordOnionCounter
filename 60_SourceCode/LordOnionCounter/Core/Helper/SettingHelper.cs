using LOC.Entites;
using System.Configuration;
using System.IO;
using System.Linq;
using static LOC.Core.Helper.JsonHelper;

namespace LOC.Core.Helper
{
    public static class SettingHelper
    {
        public static string SettingFile = @"Settings.json";
        private static readonly string Encode = @"utf-8";

        public static Settings Settings { get; set; } = new Settings();

        public static void LoadSetting()
        {
            SettingFile = ConfigurationManager.AppSettings["SettingFile"];

            if (File.Exists(SettingFile))
            {
                Settings = JsonSerialization.ReadFromJsonFile<Settings>(SettingFile, Encode);

                Global.Logger.WriteLine("Read end: " + SettingFile);
            }
            else
            {
                Settings = new Settings();
                Global.Logger.WriteLine(SettingFile + " Not Found");
                JsonSerialization.WriteToJsonFile<Settings>(SettingFile, Settings);
            }
        }
        public static decimal GetSamePercent(string path)
        {
            var percents = Settings.FilePercent.FirstOrDefault(x => path.ToUpper().EndsWith(x.Ext.ToUpper()));
            if (percents != null)
            {
                return percents.SamePercent;
            }
            else
            {
                return 0;
            }
        }
        public static decimal GetCountPercent(string path)
        {

            var percents = Settings.FilePercent.FirstOrDefault(x => path.ToUpper().EndsWith(x.Ext.ToUpper()));
            if (percents != null)
            {
                if (!Settings.IsCountDesigner)
                {
                    // file is designer and don't check to count
                    return 0;
                }
                else
                {
                    // file is designer and check to count
                    return Settings.GetPercentCountDesigner;
                }
            }
            else
            {
                // file isn't designer
                return 100;
            }
        }
    }
}
