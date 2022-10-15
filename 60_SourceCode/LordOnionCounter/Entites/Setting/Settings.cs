using LOC.Entites.Setting;
using System.Collections.Generic;

namespace LOC.Entites
{
    public class Settings
    {
        public List<string> TargetExtension = new List<string>();
        public List<string> IgnoreName = new List<string>();
        public List<FilePercent> FilePercent = new List<FilePercent>();
        public bool IsCountDesigner { get; set; } = false;
        public string PercentCountDesigner { get; set; } = "35";

        public decimal GetPercentCountDesigner
        {
            get { 
                if (decimal.TryParse(PercentCountDesigner, out decimal outValue))
                {
                    return outValue;
                }
                return 0; 
            }
        }

    }
}
