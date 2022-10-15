using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SharpSvn;

namespace CLOC_Couter
{
	// Token: 0x02000008 RID: 8
	[StandardModule]
	internal sealed class Common
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000023C0 File Offset: 0x000005C0
		public static void ExportToExcel(DataGridView dt, string fullpathName)
		{
			checked
			{
				try
				{
					Cursor.Current = Cursors.WaitCursor;
					Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
					application.Application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Type.Missing));
					application.Columns.ColumnWidth = 10;
					int count = dt.Columns.Count;
					for (int i = 1; i <= count; i++)
					{
						application.Cells[1, i] = dt.Columns[i - 1].HeaderText;
					}
					int num = dt.Rows.Count - 1;
					for (int j = 0; j <= num; j++)
					{
						int num2 = dt.Columns.Count - 1;
						for (int k = 0; k <= num2; k++)
						{
							bool flag = dt.Rows[j].Cells[k].Value != null;
							if (flag)
							{
								application.Cells[j + 2, k + 1] = dt.Rows[j].Cells[k].Value.ToString();
							}
						}
					}
					application.ActiveWorkbook.SaveCopyAs(fullpathName);
					application.ActiveWorkbook.Saved = true;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000256C File Offset: 0x0000076C
		public static void ProcessCommandline(string strCommand)
		{
			frmProcess frmProcess = new frmProcess();
			Process process = new Process();
			process.StartInfo.FileName = "CMD.exe";
			process.StartInfo.Arguments = strCommand;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			frmProcess.Show();
			process.WaitForExit();
			frmProcess.Hide();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025D0 File Offset: 0x000007D0
		public static bool CheckRevision(SvnClient client, string target, string revision)
		{
			Collection<SvnLogEventArgs> collection;
			client.GetLog(new Uri(target), ref collection);
			try
			{
				foreach (SvnLogEventArgs svnLogEventArgs in collection)
				{
					bool flag = Operators.CompareString(svnLogEventArgs.Revision.ToString(), revision, false) == 0;
					if (flag)
					{
						return true;
					}
				}
			}
			finally
			{
				IEnumerator<SvnLogEventArgs> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return false;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002650 File Offset: 0x00000850
		public static void DownloadSVNToLocal(string forlder, List<string> filename, string fileContainListfile)
		{
			List<string> list = new List<string>();
			bool flag = !Directory.Exists(forlder);
			if (flag)
			{
				Directory.CreateDirectory(forlder);
			}
			checked
			{
				try
				{
					foreach (string text in filename)
					{
						SvnUriTarget svnUriTarget = new SvnUriTarget(text, SvnRevision.Head);
						FileStream fileStream = File.Create(forlder + "\\" + text.Substring(Strings.InStrRev(text, "\\", -1, CompareMethod.Binary), text.Length - Strings.InStrRev(text, "\\", -1, CompareMethod.Binary)));
						Common.client.Write(svnUriTarget, fileStream);
						fileStream.Close();
						list.Add(forlder + "\\" + text.Substring(Strings.InStrRev(text, "\\", -1, CompareMethod.Binary), text.Length - Strings.InStrRev(text, "\\", -1, CompareMethod.Binary)));
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				File.WriteAllLines(fileContainListfile, list.ToArray(), Encoding.GetEncoding("shift-jis"));
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000276C File Offset: 0x0000096C
		public static void DownloadSVNDiffToLocal(string sUri, string saveFolder, long revisionOld, long revisionNew, List<string> lstfiledownload)
		{
			List<string> list = new List<string>();
			bool flag = lstfiledownload.Count == 0;
			if (flag)
			{
				Common.client.Export(new SvnUriTarget(new Uri(sUri), revisionOld), saveFolder + "\\" + revisionOld.ToString());
				bool flag2 = revisionNew == -1L;
				if (flag2)
				{
					Common.client.Export(new SvnUriTarget(new Uri(sUri), SvnRevision.Head), saveFolder + "\\Head");
				}
				else
				{
					Common.client.Export(new SvnUriTarget(new Uri(sUri), revisionNew), saveFolder + "\\" + revisionNew.ToString());
				}
			}
			else
			{
				try
				{
					foreach (string text in lstfiledownload)
					{
						SvnUriTarget svnUriTarget = new SvnUriTarget(text, revisionOld);
						FileStream fileStream = File.Create(Conversions.ToString(Conversions.ToDouble(saveFolder + "\\") + (double)revisionOld + Conversions.ToDouble("\\") + Conversions.ToDouble(text.Substring(Strings.InStrRev(text, "\\", -1, CompareMethod.Binary), checked(text.Length - Strings.InStrRev(text, "\\", -1, CompareMethod.Binary))))));
						Common.client.Write(svnUriTarget, fileStream);
						fileStream.Close();
						SvnUriTarget svnUriTarget2 = new SvnUriTarget(text, revisionNew);
						FileStream fileStream2 = File.Create(Conversions.ToString(Conversions.ToDouble(saveFolder + "\\") + (double)revisionOld + Conversions.ToDouble("\\") + Conversions.ToDouble(text.Substring(Strings.InStrRev(text, "\\", -1, CompareMethod.Binary), checked(text.Length - Strings.InStrRev(text, "\\", -1, CompareMethod.Binary))))));
						Common.client.Write(svnUriTarget2, fileStream2);
						fileStream2.Close();
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002978 File Offset: 0x00000B78
		public static void DeleteDirectory(string FolderRoot)
		{
			string[] directories = Directory.GetDirectories(FolderRoot);
			foreach (string path in directories)
			{
				Directory.Delete(path, true);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000029B0 File Offset: 0x00000BB0
		public static bool CheckRepos(string url)
		{
			bool result;
			try
			{
				Uri repositoryRoot = Common.client.GetRepositoryRoot(new Uri(url));
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0400000B RID: 11
		public const string msgDiffFolder = "Thư mục mới chưa được nhập.";

		// Token: 0x0400000C RID: 12
		public const string msgBaseFolder = "Thư mục cũ chưa được nhập.";

		// Token: 0x0400000D RID: 13
		public const string msgDiffNoFolder = "Thư mục mới không phải là thư mục.";

		// Token: 0x0400000E RID: 14
		public const string msgRepository = "Chưa nhập Repository SVN.";

		// Token: 0x0400000F RID: 15
		public const string msgReposRoot = "Repository SVN không tồn tại, hãy nhập lại.";

		// Token: 0x04000010 RID: 16
		public const string msgFileNoSupport = "Tập tin đang chọn chưa được hỗ trợ để tính LOC";

		// Token: 0x04000011 RID: 17
		public const string msgSelectFile = "Chưa chọn thư mục hoặc tập tin cần tính";

		// Token: 0x04000012 RID: 18
		public const string msgRevision = "Phiên bản không tồn tại, hãy nhập lại! ";

		// Token: 0x04000013 RID: 19
		public const string msgBaseRevision = "Phiên bản cũ chưa được nhập! ";

		// Token: 0x04000014 RID: 20
		public const string msgDiffRevision = "Phiên bản mới chưa được nhập! ";

		// Token: 0x04000015 RID: 21
		public static SvnClient client = new SvnClient();
	}
}
