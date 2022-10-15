using System;
using System.IO;
using System.Text;

namespace MS.IT.LOC.SourceControl
{
	// Token: 0x02000004 RID: 4
	internal class Helper
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000032C4 File Offset: 0x000022C4
		public static string GetName(string serverItem)
		{
			string[] array = serverItem.Split(new char[]
			{
				'/'
			});
			string result;
			if (array.Length > 1)
			{
				result = array[array.Length - 1];
			}
			else
			{
				result = serverItem;
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003304 File Offset: 0x00002304
		public static string GetFSName(string serverItem)
		{
			string[] array = serverItem.Split(new char[]
			{
				'\\'
			});
			string result;
			if (array.Length > 1)
			{
				result = array[array.Length - 1];
			}
			else
			{
				result = serverItem;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003344 File Offset: 0x00002344
		public static void CreateUnicodeFile(string localFile)
		{
			string text = localFile + ".uni";
			StreamReader streamReader = new StreamReader(localFile, Encoding.Default);
			StreamWriter streamWriter = new StreamWriter(text, false, Encoding.Unicode);
			string value;
			while ((value = streamReader.ReadLine()) != null)
			{
				streamWriter.WriteLine(value);
			}
			streamWriter.Flush();
			streamWriter.Close();
			streamReader.Close();
			streamWriter.Dispose();
			streamReader.Dispose();
			FileInfo fileInfo = new FileInfo(localFile);
			if (fileInfo.Exists)
			{
				fileInfo.Attributes = FileAttributes.Normal;
				fileInfo.Delete();
			}
			File.Move(text, localFile);
		}
	}
}
