using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MS.IT.LOC.SaSetupActions
{
	// Token: 0x02000002 RID: 2
	[RunInstaller(true)]
	public class LOCEnvSetupAction : Installer
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002087 File Offset: 0x00001087
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002098 File Offset: 0x00001098
		public void RecordInstallLog(string message, string content)
		{
			try
			{
				string path = Path.GetTempPath() + "LocCounter.log";
				FileStream fileStream = new FileStream(path, FileMode.Append);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				fileStream.Seek(0L, SeekOrigin.End);
				streamWriter.WriteLine("Time: " + DateTime.Now.ToString());
				streamWriter.WriteLine("Message: " + message);
				streamWriter.WriteLine("Content: " + content);
				streamWriter.WriteLine("");
				streamWriter.Flush();
				streamWriter.Close();
				streamWriter.Dispose();
				fileStream.Close();
				fileStream.Dispose();
			}
			catch
			{
				throw new InstallException("There's a exception occurred when trying to write the log file!");
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002168 File Offset: 0x00001168
		public LOCEnvSetupAction()
		{
			this.RecordInstallLog("Start to Install", "");
			this.InitializeComponent();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002194 File Offset: 0x00001194
		public override void Install(IDictionary stateSaver)
		{
			Exception ex = null;
			Trace.WriteLine("System Installed");
			try
			{
				base.Install(stateSaver);
				this.DoReset();
				this.RegisterSDApi();
				this.RegisterVSSApi();
			}
			catch (Exception ex2)
			{
				this.RecordInstallLog(ex2.Message, ex2.StackTrace);
				ex = new Exception(ex2.Message);
			}
			if (ex != null)
			{
				throw new InstallException(ex.Message);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000221C File Offset: 0x0000121C
		public override void Uninstall(IDictionary savedState)
		{
			base.Uninstall(savedState);
			this.DoReset();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002230 File Offset: 0x00001230
		private void RegisterVSSApi()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			this.CopyFile2Sys(directoryName + "\\ssapi.dll", folderPath + "\\ssapi.dll");
			if (!Directory.Exists(folderPath + "\\1033"))
			{
				Directory.CreateDirectory(folderPath + "\\1033");
			}
			this.CopyFile2Sys(directoryName + "\\ssui.dll", folderPath + "\\1033\\ssui.dll");
			new Process
			{
				StartInfo = 
				{
					FileName = folderPath + "\\regsvr32.exe",
					Arguments = "/s \"" + folderPath + "\\ssapi.dll\"",
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = false
				}
			}.Start();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002320 File Offset: 0x00001320
		private bool CopyFile2Sys(string fileSource, string fileDest)
		{
			FileInfo fileInfo = new FileInfo(fileSource);
			FileInfo fileInfo2 = new FileInfo(fileDest);
			if (fileInfo2.Exists)
			{
				fileInfo2.Attributes = FileAttributes.Normal;
				fileInfo2.Delete();
			}
			fileInfo2.Refresh();
			if (!fileInfo2.Exists)
			{
				fileInfo.CopyTo(fileDest, false);
			}
			return true;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002380 File Offset: 0x00001380
		private void RegisterSDApi()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			this.CopyFile2Sys(directoryName + "\\sdapi.dll", folderPath + "\\sdapi.dll");
			new Process
			{
				StartInfo = 
				{
					FileName = folderPath + "\\regsvr32.exe",
					Arguments = "/s \"" + folderPath + "\\sdapi.dll\"",
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = false
				}
			}.Start();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000242C File Offset: 0x0000142C
		private void DoReset()
		{
			if (LOCEnvSetupAction.LOCIsRunning())
			{
				throw new InstallException("The installation cannot finish because LOC Counter is running.  Please close LOC Counter and re-run the installation.");
			}
			LOCEnvSetupAction.LOCSetup();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000245C File Offset: 0x0000145C
		private static bool LOCIsRunning()
		{
			foreach (Process process in Process.GetProcesses())
			{
				if (process != null)
				{
					try
					{
						foreach (object obj in process.Modules)
						{
							ProcessModule processModule = (ProcessModule)obj;
							if (processModule != null && processModule.FileName != null)
							{
								if (string.Compare(Path.GetFileName(processModule.FileName), "LOCCounter.exe", StringComparison.InvariantCultureIgnoreCase) == 0)
								{
									return true;
								}
							}
						}
					}
					catch (Win32Exception)
					{
					}
				}
			}
			return false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000255C File Offset: 0x0000155C
		private static void LOCSetup()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002560 File Offset: 0x00001560
		private static bool DeleteAllLocDir()
		{
			bool result = true;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString();
			int num = text.LastIndexOf('\\');
			int startIndex = text.LastIndexOf('\\', num - 1);
			string text2 = text.Remove(startIndex);
			string text3 = text.Substring(num + 1, text.Length - num - 1);
			string[] directories = Directory.GetDirectories(text2);
			foreach (string text4 in directories)
			{
				try
				{
					string path = string.Concat(new string[]
					{
						text2,
						"\\",
						text4.Substring(text4.LastIndexOf('\\') + 1),
						"\\",
						text3,
						"\\LOC Counter"
					});
					if (Directory.Exists(path))
					{
						Directory.Delete(path, true);
					}
				}
				catch
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private const string LOC_RUNNING_ERROR_MSG = "The installation cannot finish because LOC Counter is running.  Please close LOC Counter and re-run the installation.";

		// Token: 0x04000002 RID: 2
		private const string LOC_EXE_NAME = "LOCCounter.exe";

		// Token: 0x04000003 RID: 3
		private const string LOC_LOG_FILE = "LocCounter.log";

		// Token: 0x04000004 RID: 4
		private IContainer components = null;
	}
}
