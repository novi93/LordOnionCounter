using LOC.Core.Helper;
using LOC.Entites.Count;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace LOC.Core.Counter
{
    public class CountByClocCli : ICount
    {

        public void Config()
        {
            // nothing
        }

        public CountResult RunCount(CountResquest Request)
        {
            try
            {
                var uniqueName = string.Concat(DateTime.Now.ToString("yyyyMMddHHmmss"), Guid.NewGuid());
                var resultFile = Path.Combine(Path.GetTempPath(), @"LOC", uniqueName + ".json");
                var ClocCli = ConfigurationManager.AppSettings["ClocCli"];
                var arg = string.Format(ClocCli, Request.BaseFolder, Request.NewFolder, resultFile);

                Process process = new Process();
                process.StartInfo.FileName = "CMD.exe";
                process.StartInfo.Arguments = arg;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                if (File.Exists(resultFile))
                {
                    return OnDone(resultFile);
                }
                else
                {
                    throw new Exception("CLOC raise unknowError");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private CountResult OnDone(string result)
        {
            return ReadResult(result);
        }

        private CountResult ReadResult(string result)
        {
            var rs = JsonHelper.JsonSerialization.ReadFromJsonFile<Newtonsoft.Json.Linq.JObject>(result,Encoding.Default);
            if (rs != null)
            {
                var header = rs["header"].ToObject<CountResultHeader>();

                var added = rs.SelectToken("added").Select(m => m.First)
                                                    .ToList()
                                                    .Select(x =>
                                                    {
                                                        var item = x.ToObject<CountResultDetail>();
                                                        item.name = Path.GetFullPath(x.Parent.ToObject<JProperty>().Name);
                                                        item.Id = Path.GetFileNameWithoutExtension(item.name);
                                                        return item;
                                                    });
                var same = rs.SelectToken("same").Select(m => m.First)
                                                    .ToList()
                                                    .Select(x =>
                                                    {
                                                        var item = x.ToObject<CountResultDetail>();
                                                        item.name = Path.GetFullPath(x.Parent.ToObject<JProperty>().Name);
                                                        item.Id = Path.GetFileNameWithoutExtension(item.name);
                                                        return item;
                                                    });
                var modified = rs.SelectToken("modified").Select(m => m.First)
                                                    .ToList()
                                                    .Select(x =>
                                                    {
                                                        var item = x.ToObject<CountResultDetail>();
                                                        item.name = Path.GetFullPath(x.Parent.ToObject<JProperty>().Name);
                                                        item.Id = Path.GetFileNameWithoutExtension(item.name);
                                                        return item;
                                                    });
                var removed = rs.SelectToken("removed").Select(m => m.First)
                                                    .ToList()
                                                    .Select(x =>
                                                    {
                                                        var item = x.ToObject<CountResultDetail>();
                                                        item.name = Path.GetFullPath(x.Parent.ToObject<JProperty>().Name);
                                                        item.Id = Path.GetFileNameWithoutExtension(item.name);
                                                        return item;
                                                    });

                var sumary = rs.SelectToken("SUM").Select(m => m.First)
                                                    .ToList()
                                                    .Select(x =>
                                                    {
                                                        var item = x.ToObject<CountResultDetail>();
                                                        item.name = x.Parent.ToObject<JProperty>().Name;
                                                        item.Id = Path.GetFileNameWithoutExtension(item.name);
                                                        return item;
                                                    }).ToList();

                var grant = sumary.Sum(x => x.code);
                var churned = sumary.Sum(x => (x.name == "added" || x.name == "modified") ? x.code : 0);
                var work = sumary.Sum(x => (x.name == "added" || x.name == "modified" || x.name == "removed") ? x.code : 0);

                sumary.Add(new CountResultDetail { name = "Added + Modified", code = churned });
                sumary.Add(new CountResultDetail { name = "Added + Modified+Removed", code = work });
                sumary.Add(new CountResultDetail { name = "Total LOC", code = grant });

                return new CountResult
                {
                    Header = header,
                    Same = same,
                    Added = added,
                    Modified = modified,
                    Removed = removed,
                    Sumary = sumary
                };
            }
            else
            {
                return null;
            }
        }

        void ICount.RunCount(string BaseFolderPath, string newFolderPath)
        {
            throw new NotImplementedException();
        }
    }
}
