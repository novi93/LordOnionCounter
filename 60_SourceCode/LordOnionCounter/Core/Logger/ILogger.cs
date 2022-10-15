namespace LOC.Core.Logger
{
    public interface ILogger
    {
        void WriteLine(string content);

        void WriteLine(string format, params object[] args);

        void Write(string content);

        void Clear();
    }
}
