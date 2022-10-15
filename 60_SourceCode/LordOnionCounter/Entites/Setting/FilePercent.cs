namespace LOC.Entites.Setting
{
    public class FilePercent
    {
        public string Ext { get; set; }
        public decimal CountPercent { get; set; } = 100; // 0~100%
        public decimal SamePercent { get; set; } = 0; // 0~100%

    }
}
