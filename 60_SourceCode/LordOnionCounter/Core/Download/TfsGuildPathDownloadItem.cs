using Microsoft.TeamFoundation.VersionControl.Client;
using System;

namespace LOC.Core.Download
{
    /// <summary>
    /// download all item in one folder (New or old). file name will be GUID.extendsion
    /// </summary>
    public class TfsGuildPathDownloadItem : IDownloadItem

    {
        public Change BaseItem { get; set; }
        public Change MaxItem { get; set; }
        public bool IsNew { get; set; }
        public Guid Id { get; set; }
    }
}
