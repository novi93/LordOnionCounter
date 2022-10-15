using LOC.Core.Extension;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LOC.Core.Download
{
    /// <summary>
    /// download base/new file from TFS. not shorten Path
    /// </summary>
    class TfsDownloader : IDownloader<TfsDownloadItem>

    {
        public int Download(IEnumerable<TfsDownloadItem> lst, string oldFolder, string newFolder)
        {
            var lstOuput = lst;
            var cntTotal = lstOuput.Count();
            int cntCurrent = 0;

            if (!Directory.Exists(oldFolder))
            {
                Directory.CreateDirectory(oldFolder);
            }
            if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
            }

            foreach (var item in lstOuput)
            {
                cntCurrent++;
                var fullPath = item.MaxItem?.Item.ServerItem;
                var filename = fullPath.Substring(2);  // remove ($/) 
                Global.Logger.WriteLine(string.Format("({0}\\{1})Downloading... {2}", cntCurrent, cntTotal, filename));
                item.MaxItem.Item.DownloadFile(Path.Combine(newFolder, filename).GetShortPathName());
                if (!item.IsNew && item.BaseItem != null)
                {
                    item.BaseItem.Item.DownloadFile(Path.Combine(oldFolder, filename).GetShortPathName());
                }
            }
            return cntCurrent;
        }

        public async Task<bool> DownloadAsync(IEnumerable<TfsDownloadItem> lst, string oldFolder, string newFolder)
        {

            if (!Directory.Exists(oldFolder))
            {
                Directory.CreateDirectory(oldFolder);
            }
            if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
            }

            var TaskList = lst.Select(item =>
                       DownloadAsync(item, oldFolder, newFolder)).ToList();
            var rs = await Task.WhenAll(TaskList);

            return true;
        }

        private async Task<bool> DownloadAsync(IDownloadItem item, string baseFolder, string newFolder)
        {
            var fullPath = item.MaxItem?.Item.ServerItem;
            var filename = fullPath.Substring(2);  // remove ($/) 
            Global.Logger.WriteLine(string.Format("Downloading... {0}", filename));
            item.MaxItem.Item.DownloadFile(Path.Combine(newFolder, filename).GetShortPathName());
            if (!item.IsNew && item.BaseItem != null)
            {
                item.BaseItem.Item.DownloadFile(Path.Combine(baseFolder, filename).GetShortPathName());
            }
            return true;
        }

    }
}
