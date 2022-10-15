using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using CLOC_Couter.My.Resources;
using Microsoft.VisualBasic;

namespace CLOC_Couter
{
	// Token: 0x02000009 RID: 9
	public class CountLOC
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002A0C File Offset: 0x00000C0C
		public static object TotalLOC(List<string> ListFile)
		{
			float num = 0f;
			string text = "";
			string text2 = Path.GetTempPath() + "CLOC";
			bool flag = !Directory.Exists(text2);
			if (flag)
			{
				Directory.CreateDirectory(text2);
			}
			string text3 = text2 + "\\cloc.exe";
			using (FileStream fileStream = new FileStream(text3, FileMode.Create))
			{
				fileStream.Write(Resources.cloc, 0, Resources.cloc.Length);
			}
			string path = "FileCounter" + DateAndTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
			string text4 = Path.GetTempPath() + "LOCCounter" + DateAndTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
			object result;
			try
			{
				text = Path.Combine(Path.GetTempPath(), path);
				CountLOC.AddDataToFile(ref text, ListFile);
				CountLOC.strCmdLine = string.Concat(new string[]
				{
					CountLOC.strCmdLine,
					text3,
					" --list-file=\"",
					text,
					"\" --unicode --skip-win-hidden --skip-uniqueness --by-file --csv --out=\"",
					text4,
					"\""
				});
				Process process = new Process();
				process.StartInfo.FileName = "CMD.exe";
				process.StartInfo.Arguments = CountLOC.strCmdLine;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
				string path2 = text4;
				bool flag2 = File.Exists(path2);
				if (flag2)
				{
					num = (float)new frmResultCountFile
					{
						path = path2,
						dataCountFile = ""
					}.ResultCountLOC;
					File.Delete(text);
					File.Delete(path2);
					result = num;
				}
				else
				{
					result = num;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002C14 File Offset: 0x00000E14
		public void ShowFormCounterLOC()
		{
			frmCounterLOC frmCounterLOC = new frmCounterLOC();
			frmCounterLOC.Show();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002C30 File Offset: 0x00000E30
		private static void AddDataToFile(ref string filename, List<string> ListFile)
		{
			try
			{
				List<string> list = new List<string>();
				list.AddRange(ListFile);
				File.WriteAllLines(filename, list.ToArray(), Encoding.GetEncoding("shift-jis"));
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04000016 RID: 22
		private static string strCmdLine = "/c ";
	}
}
