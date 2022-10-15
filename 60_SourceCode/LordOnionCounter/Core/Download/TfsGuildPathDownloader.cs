using LOC.Core.Extension;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace LOC.Core.Download
{
    /// <summary>
    /// download all item in one folder (New or old). file name will be GUID.extendsion
    /// </summary>
    class TfsGuildPathDownloader : IDownloader<TfsGuildPathDownloadItem>

    {
        public int Download(IEnumerable<TfsGuildPathDownloadItem> lst, string oldFolder, string newFolder)
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
                var filename = $"{item.Id}{Path.GetExtension(fullPath)}";
                Global.Logger.WriteLine(string.Format("({0}\\{1})Downloading... {2}", cntCurrent, cntTotal, fullPath));
                item.MaxItem.Item.DownloadFile(Path.Combine(newFolder, filename));
                if (!item.IsNew && item.BaseItem != null)
                {
                    item.BaseItem.Item.DownloadFile(Path.Combine(oldFolder, filename));
                }
            }
            return cntCurrent;
        }

        public async Task<bool> DownloadAsync(IEnumerable<TfsGuildPathDownloadItem> lst, string oldFolder, string newFolder)
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

        private async Task<bool> DownloadAsync(TfsGuildPathDownloadItem item, string baseFolder, string newFolder)
        {
            var fullPath = item.MaxItem?.Item.ServerItem;
            var filename = $"{item.Id}{Path.GetExtension(fullPath)}";
            Global.Logger.WriteLine(string.Format("Downloading... {0}", fullPath));
            item.MaxItem.Item.DownloadFile(Path.Combine(newFolder, filename).GetShortPathName());
            if (!item.IsNew && item.BaseItem != null)
            {
                item.BaseItem.Item.DownloadFile(Path.Combine(baseFolder, filename).GetShortPathName());
            }
            return true;
        }
    }
}
