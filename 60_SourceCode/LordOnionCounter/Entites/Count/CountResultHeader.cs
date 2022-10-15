namespace LOC.Entites.Count
{
    /// <summary>
    /// Count result from Json file
    /// </summary>
    /// <remarks>DON'T RENAME PROPERTY. It mapping with Json result</remarks>
    public class CountResultHeader
    {
        public string cloc_url { get; set; }
        public string cloc_version { get; set; }
        public float elapsed_seconds { get; set; }
        public int n_files { get; set; }
        public int n_lines { get; set; }
        public int files_per_second { get; set; }
        public float lines_per_second { get; set; }
        public string report_file { get; set; }
    }
}
