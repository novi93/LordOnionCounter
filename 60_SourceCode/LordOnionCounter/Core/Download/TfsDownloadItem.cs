using Microsoft.TeamFoundation.VersionControl.Client;

namespace LOC.Core.Download
{
    public class TfsDownloadItem : IDownloadItem

    {
        public Change BaseItem { get; set; }
        public Change MaxItem { get; set; }
        public bool IsNew { get; set; }
    }
}
