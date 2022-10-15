using System;
using System.Windows.Forms;

namespace LOC.Core.Logger
{
    public class UILogger : ILogger
    {
        public UILogger(Control TxtLog)
        {
            this.TxtLog = TxtLog;
        }

        public Control TxtLog { set; get; }

        public void Write(string content)
        {
            TxtLog.Text += content;
        }
        public void WriteLine(string content)
        {
            Write(DateTime.Now + " : " + content);
            TxtLog.Text += Environment.NewLine;
        }

        public void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(format, args));
        }
        public void Clear()
        {
            TxtLog.Text = string.Empty;
        }
    }
}
