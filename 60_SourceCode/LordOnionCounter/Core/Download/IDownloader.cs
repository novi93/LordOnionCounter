using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOC.Core.Download
{
    public interface IDownloader<TItem> where TItem : IDownloadItem
    {
        int Download(IEnumerable<TItem> lst, string oldFolder, string newFolder);
        Task<bool> DownloadAsync(IEnumerable<TItem> lst, string oldFolder, string newFolder);
    }
}
