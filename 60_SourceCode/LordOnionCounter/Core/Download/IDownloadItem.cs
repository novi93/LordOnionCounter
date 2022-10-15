using Microsoft.TeamFoundation.VersionControl.Client;

namespace LOC.Core.Download
{
    public interface IDownloadItem
    {
        Change BaseItem { get; set; }
        Change MaxItem { get; set; }
        bool IsNew { get; set; }
    }
}
