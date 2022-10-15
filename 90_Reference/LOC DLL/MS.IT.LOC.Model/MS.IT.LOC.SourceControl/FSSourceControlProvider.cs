using System;
using System.Collections;
using System.IO;
using System.Text;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.VersionControl.Common;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.SourceControl
{
	// Token: 0x0200000A RID: 10
	public class FSSourceControlProvider : ISourceControlProvider
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00009274 File Offset: 0x00008274
		public bool Login(string serverName, string serverPort, string loginId, string password)
		{
			bool result;
			if (Directory.Exists(serverName))
			{
				if (serverName.Substring(serverName.Length - 1) != "\\")
				{
					FSSourceControlProvider.SERVER_NAME = serverName + "\\";
				}
				else
				{
					FSSourceControlProvider.SERVER_NAME = serverName;
				}
				FSSourceControlProvider.m_IsConnected = true;
				result = true;
			}
			else
			{
				FSSourceControlProvider.m_IsConnected = false;
				result = false;
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000092E0 File Offset: 0x000082E0
		public SCItemSet GetChildItem(SCItem parent, bool recursive)
		{
			SCItemSet result;
			if (FSSourceControlProvider.m_IsConnected)
			{
				if (parent == null)
				{
					result = this.GetFirstFolders();
				}
				else
				{
					result = this.GetChildItems(parent, recursive);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00009324 File Offset: 0x00008324
		public bool Download(string serverPath, string localFile)
		{
			bool result;
			try
			{
				string sourceFileName;
				if (FSSourceControlProvider.SERVER_NAME.Substring(FSSourceControlProvider.SERVER_NAME.Length - 1) == "\\")
				{
					sourceFileName = FSSourceControlProvider.SERVER_NAME.Substring(0, FSSourceControlProvider.SERVER_NAME.Length - 1) + serverPath.Substring(1).Replace('/', '\\');
				}
				else
				{
					sourceFileName = FSSourceControlProvider.SERVER_NAME + serverPath.Substring(1).Replace('/', '\\');
				}
				File.Copy(sourceFileName, localFile);
				Helper.CreateUnicodeFile(localFile);
				if (File.Exists(localFile))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				result = false;
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000093F4 File Offset: 0x000083F4
		public bool DownloadDiff(string serverPath, string localFile, object startVersionSpec, object endVersionSpec)
		{
			DiffOptions diffOptions = new DiffOptions();
			diffOptions.UseThirdPartyTool = false;
			diffOptions.OutputType = 4;
			diffOptions.SourceEncoding = new UnicodeEncoding();
			diffOptions.TargetEncoding = new UnicodeEncoding();
			lock (this.m_objSingleThread)
			{
				try
				{
					DiffSegment diffSegment = Difference.DiffFiles(serverPath, Encoding.Unicode.CodePage, localFile, Encoding.Unicode.CodePage, diffOptions);
					DiffSegment diffSegment2 = diffSegment;
					DiffSegment diffSegment3 = null;
					DiffSegment diffSegment4 = null;
					int num = 0;
					int num2 = 0;
					while (diffSegment2 != null)
					{
						DiffSegment next = diffSegment2.Next;
						if (next != null)
						{
							DiffSegment diffSegment5 = new DiffSegment();
							diffSegment5.Type = 1;
							diffSegment5.OriginalStart = diffSegment2.OriginalStart + diffSegment2.OriginalLength;
							diffSegment5.ModifiedStart = diffSegment2.ModifiedStart + diffSegment2.ModifiedLength;
							diffSegment5.OriginalLength = next.OriginalStart - diffSegment5.OriginalStart;
							diffSegment5.ModifiedLength = next.ModifiedStart - diffSegment5.ModifiedStart;
							diffSegment5.OriginalStartOffset = diffSegment2.OriginalStartOffset + diffSegment2.OriginalByteLength;
							diffSegment5.ModifiedStartOffset = diffSegment2.ModifiedStartOffset + diffSegment2.ModifiedByteLength;
							diffSegment5.OriginalByteLength = next.OriginalStartOffset - diffSegment5.OriginalStartOffset;
							diffSegment5.ModifiedByteLength = next.ModifiedStartOffset - diffSegment5.ModifiedStartOffset;
							if (diffSegment5.OriginalByteLength == 0L && diffSegment5.ModifiedByteLength == 0L)
							{
								diffSegment2 = next;
								continue;
							}
							if (diffSegment3 == null)
							{
								diffSegment3 = diffSegment5;
								diffSegment4 = diffSegment5;
							}
							else
							{
								diffSegment4.Next = diffSegment5;
								diffSegment4 = diffSegment5;
							}
						}
						diffSegment2 = next;
					}
					DiffSegment diffSegment6 = diffSegment3;
					StreamWriter streamWriter = new StreamWriter(localFile + ".diff", false, Encoding.Unicode);
					streamWriter.WriteLine("Compare Result");
					streamWriter.WriteLine("===================================================================");
					int num3 = -1;
					DiffSegment diffSegment7 = null;
					DiffSegment diffSegment8 = diffSegment6;
					while (diffSegment6 != null)
					{
						if (diffSegment6.OriginalStart == num3)
						{
							diffSegment7.OriginalLength += diffSegment6.OriginalLength;
							diffSegment7.OriginalByteLength += diffSegment6.OriginalByteLength;
							diffSegment7.ModifiedLength += diffSegment6.ModifiedLength;
							diffSegment7.ModifiedByteLength += diffSegment6.ModifiedByteLength;
							diffSegment7.LatestLength += diffSegment6.LatestLength;
							diffSegment7.LatestByteLength += diffSegment6.LatestByteLength;
							diffSegment6 = diffSegment6.Next;
							diffSegment7.Next = diffSegment6;
						}
						else
						{
							num3 = diffSegment6.OriginalStart;
							diffSegment7 = diffSegment6;
							diffSegment6 = diffSegment6.Next;
						}
					}
					for (diffSegment6 = diffSegment8; diffSegment6 != null; diffSegment6 = diffSegment6.Next)
					{
						if (diffSegment6.OriginalLength > 0)
						{
							streamWriter.Write((diffSegment6.OriginalStart + 1).ToString());
						}
						else
						{
							streamWriter.Write(diffSegment6.OriginalStart.ToString());
						}
						if (diffSegment6.OriginalLength > 1)
						{
							streamWriter.Write(",");
							streamWriter.Write((diffSegment6.OriginalStart + diffSegment6.OriginalLength).ToString());
						}
						if (diffSegment6.OriginalLength == 0)
						{
							streamWriter.Write("a");
							num += diffSegment6.ModifiedLength;
						}
						else if (diffSegment6.ModifiedLength == 0)
						{
							streamWriter.Write("d");
							num2 += diffSegment6.OriginalLength;
						}
						else
						{
							streamWriter.Write("c");
						}
						if (diffSegment6.ModifiedLength > 0)
						{
							streamWriter.Write((diffSegment6.ModifiedStart + 1).ToString());
						}
						else
						{
							streamWriter.Write(diffSegment6.ModifiedStart.ToString());
						}
						if (diffSegment6.ModifiedLength > 1)
						{
							streamWriter.Write(",");
							streamWriter.Write((diffSegment6.ModifiedStart + diffSegment6.ModifiedLength).ToString());
						}
						streamWriter.WriteLine();
						StreamReader streamReader = new StreamReader(serverPath, Encoding.Unicode);
						streamReader.BaseStream.Seek(diffSegment6.OriginalStartOffset, SeekOrigin.Begin);
						for (int i = 0; i < diffSegment6.OriginalLength; i++)
						{
							streamWriter.WriteLine("< " + streamReader.ReadLine());
						}
						if (streamReader.ReadLine() == null)
						{
							streamWriter.WriteLine("\\ No newline at end of file");
						}
						streamReader.Close();
						streamReader.Dispose();
						if (diffSegment6.ModifiedLength > 0 && diffSegment6.OriginalLength > 0)
						{
							streamWriter.WriteLine("---");
						}
						StreamReader streamReader2 = new StreamReader(localFile, Encoding.Unicode);
						streamReader2.BaseStream.Seek(diffSegment6.ModifiedStartOffset, SeekOrigin.Begin);
						for (int i = 0; i < diffSegment6.ModifiedLength; i++)
						{
							streamWriter.WriteLine("> " + streamReader2.ReadLine());
						}
						if (streamReader2.ReadLine() == null)
						{
							streamWriter.WriteLine("\\ No newline at end of file");
						}
						streamReader2.Close();
						streamReader2.Dispose();
					}
					if (diffSegment3 != null && diffSegment3.Next == null)
					{
						int num4 = diffSegment3.ModifiedLength;
					}
					else if (diffSegment3 != null)
					{
						int num4 = diffSegment3.ModifiedStart;
					}
					streamWriter.WriteLine("===================================================================");
					streamWriter.Close();
					streamWriter.Dispose();
				}
				catch
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00009A84 File Offset: 0x00008A84
		public bool Download(string serverPath, string localFile, object versionSpec)
		{
			bool result;
			try
			{
				string text = versionSpec.ToString();
				string sourceFileName;
				if (text.Substring(text.Length - 1) == "\\")
				{
					sourceFileName = text.Substring(0, text.Length - 1) + serverPath.Replace('/', '\\');
				}
				else
				{
					sourceFileName = text + serverPath.Replace('/', '\\');
				}
				File.Copy(sourceFileName, localFile);
				Helper.CreateUnicodeFile(localFile);
				if (File.Exists(localFile))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00009B30 File Offset: 0x00008B30
		public object GetVersionSpec(DateTime date, bool latest)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009B48 File Offset: 0x00008B48
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, DateTime startDate, DateTime endDate)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00009B60 File Offset: 0x00008B60
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, string baseSet, string lastSet)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00009B78 File Offset: 0x00008B78
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, int setType, string versionSet)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00009B90 File Offset: 0x00008B90
		private SCItemSet GetFirstFolders()
		{
			SCItemSet result;
			try
			{
				string[] directories = Directory.GetDirectories(FSSourceControlProvider.SERVER_NAME);
				string[] files = Directory.GetFiles(FSSourceControlProvider.SERVER_NAME);
				SCItemSet scitemSet = new SCItemSet();
				for (int i = 0; i < directories.Length; i++)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + directories[i].Substring(FSSourceControlProvider.SERVER_NAME.Length),
						Name = Helper.GetFSName(directories[i]),
						ScType = SCItemType.FOLDER
					});
				}
				for (int i = 0; i < files.Length; i++)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + files[i].Substring(FSSourceControlProvider.SERVER_NAME.Length),
						Name = Helper.GetFSName(files[i]),
						ScType = SCItemType.FILE
					});
				}
				result = scitemSet;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00009CA0 File Offset: 0x00008CA0
		private SCItemSet GetItemsIn2Folder(string folder1, string folder2)
		{
			SCItemSet scitemSet = new SCItemSet();
			if (folder1.Substring(folder1.Length - 1) != "\\")
			{
				folder1 += "\\";
			}
			if (folder2.Substring(folder2.Length - 1) != "\\")
			{
				folder2 += "\\";
			}
			string[] array;
			string[] array2;
			try
			{
				array = Directory.GetDirectories(folder1);
				array2 = Directory.GetFiles(folder1);
			}
			catch
			{
				array = new string[0];
				array2 = new string[0];
			}
			string[] array3;
			string[] array4;
			try
			{
				array3 = Directory.GetDirectories(folder2);
				array4 = Directory.GetFiles(folder2);
			}
			catch
			{
				array3 = new string[0];
				array4 = new string[0];
			}
			string strA = string.Empty;
			string strB = string.Empty;
			int i = 0;
			int j = 0;
			while (i < array.Length && j < array3.Length)
			{
				strA = Helper.GetFSName(array[i]);
				strB = Helper.GetFSName(array3[j]);
				int num = string.Compare(strA, strB, true);
				if (num < 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array[i]),
						ScType = SCItemType.FOLDER
					});
					i++;
				}
				else if (num > 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array3[j].Substring(this.m_DiffFolder.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array3[j]),
						ScType = SCItemType.FOLDER
					});
					j++;
				}
				else
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array[i]),
						ScType = SCItemType.FOLDER
					});
					i++;
					j++;
				}
			}
			while (i < array.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array[i]),
					ScType = SCItemType.FOLDER
				});
				i++;
			}
			while (j < array3.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array3[j].Substring(this.m_DiffFolder.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array3[j]),
					ScType = SCItemType.FOLDER
				});
				j++;
			}
			i = 0;
			j = 0;
			while (i < array2.Length && j < array4.Length)
			{
				strA = Helper.GetFSName(array2[i]);
				strB = Helper.GetFSName(array4[j]);
				int num = string.Compare(strA, strB, true);
				if (num < 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array2[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array2[i]),
						ScType = SCItemType.FILE
					});
					i++;
				}
				else if (num > 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array4[j].Substring(this.m_DiffFolder.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array4[j]),
						ScType = SCItemType.FILE
					});
					j++;
				}
				else
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array2[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array2[i]),
						ScType = SCItemType.FILE
					});
					i++;
					j++;
				}
			}
			while (i < array2.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array2[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array2[i]),
					ScType = SCItemType.FILE
				});
				i++;
			}
			while (j < array4.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array4[j].Substring(this.m_DiffFolder.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array4[j]),
					ScType = SCItemType.FILE
				});
				j++;
			}
			SCItemSet result;
			if (scitemSet.Count > 0)
			{
				result = scitemSet;
			}
			else
			{
				scitemSet.Clear();
				result = null;
			}
			return result;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000A29C File Offset: 0x0000929C
		private SCItemSet GetFirstFoldersInSet(string diffFolder)
		{
			SCItemSet scitemSet = new SCItemSet();
			string[] array;
			string[] array2;
			try
			{
				array = Directory.GetDirectories(FSSourceControlProvider.SERVER_NAME);
				array2 = Directory.GetFiles(FSSourceControlProvider.SERVER_NAME);
			}
			catch
			{
				array = new string[0];
				array2 = new string[0];
			}
			string[] array3;
			string[] array4;
			try
			{
				array3 = Directory.GetDirectories(diffFolder);
				array4 = Directory.GetFiles(diffFolder);
			}
			catch
			{
				array3 = new string[0];
				array4 = new string[0];
			}
			string strA = string.Empty;
			string strB = string.Empty;
			int i = 0;
			int j = 0;
			while (i < array.Length && j < array3.Length)
			{
				strA = Helper.GetFSName(array[i]);
				strB = Helper.GetFSName(array3[j]);
				int num = string.Compare(strA, strB, true);
				if (num < 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array[i]),
						ScType = SCItemType.FOLDER
					});
					i++;
				}
				else if (num > 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array3[j].Substring(diffFolder.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array3[j]),
						ScType = SCItemType.FOLDER
					});
					j++;
				}
				else
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array[i]),
						ScType = SCItemType.FOLDER
					});
					i++;
					j++;
				}
			}
			while (i < array.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array[i]),
					ScType = SCItemType.FOLDER
				});
				i++;
			}
			while (j < array3.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array3[j].Substring(diffFolder.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array3[j]),
					ScType = SCItemType.FOLDER
				});
				j++;
			}
			i = 0;
			j = 0;
			while (i < array2.Length && j < array4.Length)
			{
				strA = Helper.GetFSName(array2[i]);
				strB = Helper.GetFSName(array4[j]);
				int num = string.Compare(strA, strB, true);
				if (num < 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array2[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array2[i]),
						ScType = SCItemType.FILE
					});
					i++;
				}
				else if (num > 0)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array4[j].Substring(diffFolder.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array4[j]),
						ScType = SCItemType.FILE
					});
					j++;
				}
				else
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + array2[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(array2[i]),
						ScType = SCItemType.FILE
					});
					i++;
					j++;
				}
			}
			while (i < array2.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array2[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array2[i]),
					ScType = SCItemType.FILE
				});
				i++;
			}
			while (j < array4.Length)
			{
				scitemSet.Add(new SCItem
				{
					Path = "./" + array4[j].Substring(diffFolder.Length).Replace('\\', '/'),
					Name = Helper.GetFSName(array4[j]),
					ScType = SCItemType.FILE
				});
				j++;
			}
			SCItemSet result;
			if (scitemSet.Count > 0)
			{
				result = scitemSet;
			}
			else
			{
				scitemSet.Clear();
				result = null;
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000A830 File Offset: 0x00009830
		private SCItemSet GetChildItems(SCItem parent, bool recursive)
		{
			SCItemSet result;
			try
			{
				string path;
				if (FSSourceControlProvider.SERVER_NAME.Substring(FSSourceControlProvider.SERVER_NAME.Length - 1) == "\\")
				{
					path = FSSourceControlProvider.SERVER_NAME.Substring(0, FSSourceControlProvider.SERVER_NAME.Length - 1) + parent.Path.Replace('/', '\\').Substring(1);
				}
				else
				{
					path = FSSourceControlProvider.SERVER_NAME + parent.Path.Replace('/', '\\').Substring(1);
				}
				string[] directories = Directory.GetDirectories(path);
				string[] files = Directory.GetFiles(path);
				SCItemSet scitemSet = new SCItemSet();
				for (int i = 0; i < directories.Length; i++)
				{
					SCItem scitem = new SCItem();
					scitem.Path = "./" + directories[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/');
					scitem.Name = Helper.GetFSName(directories[i]);
					scitem.ScType = SCItemType.FOLDER;
					scitemSet.Add(scitem);
					if (recursive)
					{
						SCItemSet childItems = this.GetChildItems(scitem, recursive);
						if (childItems != null)
						{
							foreach (object obj in childItems)
							{
								SCItem scItem = (SCItem)obj;
								scitemSet.Add(scItem);
							}
						}
					}
				}
				for (int i = 0; i < files.Length; i++)
				{
					scitemSet.Add(new SCItem
					{
						Path = "./" + files[i].Substring(FSSourceControlProvider.SERVER_NAME.Length).Replace('\\', '/'),
						Name = Helper.GetFSName(files[i]),
						ScType = SCItemType.FILE
					});
				}
				result = scitemSet;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000AA7C File Offset: 0x00009A7C
		private SCItemSet GetChildItemsInSet(SCItem parent, bool recursive, string diffFolder)
		{
			if (diffFolder.Substring(diffFolder.Length - 1) != "\\")
			{
				this.m_DiffFolder = diffFolder + "\\";
			}
			else
			{
				this.m_DiffFolder = diffFolder;
			}
			string folder;
			if (FSSourceControlProvider.SERVER_NAME.Substring(FSSourceControlProvider.SERVER_NAME.Length - 1) == "\\")
			{
				folder = FSSourceControlProvider.SERVER_NAME.Substring(0, FSSourceControlProvider.SERVER_NAME.Length - 1) + parent.Path.Replace('/', '\\').Substring(1);
			}
			else
			{
				folder = FSSourceControlProvider.SERVER_NAME + parent.Path.Replace('/', '\\').Substring(1);
			}
			string folder2;
			if (diffFolder.Substring(diffFolder.Length - 1) == "\\")
			{
				folder2 = diffFolder.Substring(0, diffFolder.Length - 1) + parent.Path.Replace('/', '\\').Substring(1);
			}
			else
			{
				folder2 = diffFolder + parent.Path.Replace('/', '\\').Substring(1);
			}
			return this.GetItemsIn2Folder(folder, folder2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000ABC0 File Offset: 0x00009BC0
		public SCItemSet GetChildItemInSet(SCItem parent, bool recursive, int setType, string[] versions)
		{
			SCItemSet result;
			if (versions.Length < 1 || versions[0] == "")
			{
				result = this.GetChildItem(parent, recursive);
			}
			else
			{
				if (versions.Length > 1)
				{
					throw new Exception("Not support so many folders yet.");
				}
				if (recursive)
				{
					throw new Exception("Not support, diff folders recursively.");
				}
				string text = versions[0];
				if (text.Length > 0 && text.Substring(text.Length - 1) != "\\")
				{
					text += "\\";
				}
				if (FSSourceControlProvider.m_IsConnected)
				{
					if (parent == null)
					{
						result = this.GetFirstFoldersInSet(text);
					}
					else
					{
						result = this.GetChildItemsInSet(parent, recursive, text);
					}
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000ACA0 File Offset: 0x00009CA0
		public MRepotItem GetItemChurnCount(string serverPath, string baseVersion, string diffVersion, DateTime startDate, DateTime endDate)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x0400002B RID: 43
		public static string SERVER_NAME = "";

		// Token: 0x0400002C RID: 44
		private static bool m_IsConnected = false;

		// Token: 0x0400002D RID: 45
		private string m_DiffFolder = "";

		// Token: 0x0400002E RID: 46
		private object m_objSingleThread = new object();
	}
}
