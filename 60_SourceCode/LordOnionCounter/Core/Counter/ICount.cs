
namespace LOC.Core.Counter
{
    public interface ICount
    {
        void Config();

        void RunCount(string BaseFolderPath, string NewFolderPath);
    }
}
