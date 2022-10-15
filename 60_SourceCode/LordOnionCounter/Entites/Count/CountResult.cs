using System.Collections.Generic;

namespace LOC.Entites.Count
{
    public class CountResult
    {
        public CountResultHeader Header { get; set; }
        public IEnumerable<CountResultDetail> Same { get; set; }
        public IEnumerable<CountResultDetail> Added { get; set; }
        public IEnumerable<CountResultDetail> Modified { get; set; }
        public IEnumerable<CountResultDetail> Removed { get; set; }
        public IEnumerable<CountResultDetail> Sumary { get; set; }
    }

}
