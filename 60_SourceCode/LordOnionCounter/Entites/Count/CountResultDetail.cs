namespace LOC.Entites.Count
{
    /// <summary>
    /// Count result from Json file
    /// </summary>
    /// <remarks>DON'T RENAME PROPERTY. It mapping with Json result</remarks>
    public class CountResultDetail
    {
        public string name { get; set; }
        public int code { get; set; }
        public int blank { get; set; }
        public int nFiles { get; set; }
        public int comment { get; set; }
        public string Id { get; internal set; }
    }

}
