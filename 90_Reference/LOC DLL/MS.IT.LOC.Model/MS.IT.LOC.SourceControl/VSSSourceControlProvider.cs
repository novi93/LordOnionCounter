using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.VersionControl.Common;
using Microsoft.VisualStudio.SourceSafe.Interop;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.SourceControl
{
	// Token: 0x02000003 RID: 3
	public class VSSSourceControlProvider : ISourceControlProvider
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000020D0 File Offset: 0x000010D0
		public bool Login(string ServerName, string serverPort, string LoginId, string Password)
		{
			if (LoginId == null || LoginId == string.Empty)
			{
				LoginId = Environment.UserName;
			}
			bool result;
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(ServerName, LoginId, Password);
				vssdatabase.Close();
				VSSSourceControlProvider.m_IsConnected = true;
				VSSSourceControlProvider.DataFile = ServerName;
				VSSSourceControlProvider.User = LoginId;
				VSSSourceControlProvider.Passwords = Password;
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000214C File Offset: 0x0000114C
		public SCItemSet GetChildItem(SCItem parent, bool recursive)
		{
			SCItemSet result;
			if (VSSSourceControlProvider.m_IsConnected)
			{
				if (parent == null)
				{
					result = this.GetTeamProjects();
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

		// Token: 0x0600000E RID: 14 RVA: 0x00002190 File Offset: 0x00001190
		public bool Download(string serverPath, string localFile)
		{
			bool result;
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
				VSSItem vssitem = vssdatabase.get_VSSItem(serverPath, false);
				vssitem.Get(ref localFile, 0);
				Helper.CreateUnicodeFile(localFile);
				FileInfo fileInfo = new FileInfo(localFile);
				if (fileInfo.Exists)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				vssdatabase.Close();
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002220 File Offset: 0x00001220
		public bool DownloadDiff(string serverPath, string localFile, object startVersionSpec, object endVersionSpec)
		{
			DiffOptions diffOptions = new DiffOptions();
			diffOptions.UseThirdPartyTool = false;
			diffOptions.OutputType = 4;
			MemoryStream stream = new MemoryStream();
			diffOptions.SourceEncoding = new UnicodeEncoding();
			diffOptions.TargetEncoding = new UnicodeEncoding();
			diffOptions.StreamWriter = new StreamWriter(stream, new UnicodeEncoding());
			Monitor.Enter(this.m_objSingleThread);
			diffOptions.StreamWriter.AutoFlush = true;
			try
			{
				DiffSegment diffSegment = Difference.DiffFiles(serverPath, Encoding.Unicode.CodePage, serverPath + "1", Encoding.Unicode.CodePage, diffOptions);
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
					StreamReader streamReader2 = new StreamReader(serverPath + "1", Encoding.Unicode);
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
			catch (Exception ex)
			{
				FileInfo fileInfo = new FileInfo(localFile);
				if (fileInfo.Exists)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				return false;
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			return true;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002918 File Offset: 0x00001918
		public bool Download(string serverPath, string localFile, object versionSpec)
		{
			bool result;
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
				VSSItem vssitem = vssdatabase.get_VSSItem(serverPath, false);
				VSSItem vssitem2 = vssitem.get_Version(int.Parse(versionSpec.ToString()));
				vssitem2.Get(ref localFile, 0);
				Helper.CreateUnicodeFile(localFile);
				FileInfo fileInfo = new FileInfo(localFile);
				if (fileInfo.Exists)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				vssdatabase.Close();
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000029C0 File Offset: 0x000019C0
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, string baseSet, string lastSet)
		{
			ArrayList arrayList = new ArrayList();
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
				VSSItem vssitem = vssdatabase.get_VSSItem(serverPath, false);
				VSSItem vssitem2 = vssitem.get_Version(baseSet.ToString());
				vssdatabase.Close();
				arrayList.Add(baseSet);
			}
			catch (Exception ex)
			{
				arrayList.Add("");
			}
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
				VSSItem vssitem = vssdatabase.get_VSSItem(serverPath, false);
				VSSItem vssitem2 = vssitem.get_Version(lastSet.ToString());
				vssdatabase.Close();
				arrayList.Add(lastSet);
			}
			catch (Exception ex)
			{
				arrayList.Add("");
			}
			return arrayList;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002AA8 File Offset: 0x00001AA8
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, DateTime startDate, DateTime endDate)
		{
			ArrayList arrayList = new ArrayList();
			DateTime dateTime = endDate.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
			string text = "C";
			string text2 = "C";
			if (dateTime > endDate.AddDays(1.0))
			{
				dateTime = endDate;
			}
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
				VSSItem vssitem = vssdatabase.get_VSSItem(serverPath, false);
				foreach (object obj in vssitem.get_Versions(0))
				{
					IVSSVersion ivssversion = (IVSSVersion)obj;
					DateTime date = ivssversion.Date;
					if (!(date > dateTime) && !(ivssversion.Label.ToString() != ""))
					{
						if (date >= startDate && text2 == "C")
						{
							text2 = ivssversion.VersionNumber.ToString().Trim();
						}
						if (date < startDate)
						{
							text = ivssversion.VersionNumber.ToString().Trim();
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			if (text == "C")
			{
				arrayList.Add("");
			}
			else
			{
				arrayList.Add(text);
			}
			if (text2 == "C")
			{
				arrayList.Add("");
			}
			else
			{
				arrayList.Add(text2);
			}
			return arrayList;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002CD8 File Offset: 0x00001CD8
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, int setType, string versionSet)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002CEC File Offset: 0x00001CEC
		public object GetVersionSpec(DateTime date, bool latest)
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002D00 File Offset: 0x00001D00
		private SCItemSet GetTeamProjects()
		{
			SCItemSet result;
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
				VSSItem vssitem = vssdatabase.get_VSSItem("$/", false);
				IVSSItems ivssitems = vssitem.get_Items(false);
				SCItemSet scitemSet = new SCItemSet();
				foreach (object obj in ivssitems)
				{
					VSSItem vssitem2 = (VSSItem)obj;
					SCItem scitem = new SCItem();
					scitem.Path = vssitem2.Spec;
					scitem.Name = vssitem2.Name;
					if (vssitem2.Type == 1)
					{
						scitem.ScType = SCItemType.FILE;
					}
					else
					{
						scitem.ScType = SCItemType.FOLDER;
					}
					scitemSet.Add(scitem);
				}
				vssdatabase.Close();
				result = scitemSet;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002E18 File Offset: 0x00001E18
		private SCItemSet GetChildItems(SCItem parent, bool recursive)
		{
			SCItemSet result;
			try
			{
				VSSDatabase vssdatabase = new VSSDatabaseClass();
				vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
				VSSItem vssitem = vssdatabase.get_VSSItem(parent.Path, false);
				IVSSItems ivssitems = vssitem.get_Items(false);
				if (ivssitems.Count < 1)
				{
					result = null;
				}
				else
				{
					SCItemSet scitemSet = new SCItemSet();
					foreach (object obj in ivssitems)
					{
						VSSItem vssitem2 = (VSSItem)obj;
						SCItem scitem = new SCItem();
						scitem.Path = vssitem2.Spec;
						scitem.Name = vssitem2.Name;
						if (vssitem2.Type == 1)
						{
							scitem.ScType = SCItemType.FILE;
						}
						else
						{
							scitem.ScType = SCItemType.FOLDER;
						}
						scitemSet.Add(scitem);
					}
					vssdatabase.Close();
					result = scitemSet;
				}
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002F4C File Offset: 0x00001F4C
		public SCItemSet GetChildItemInSet(SCItem parent, bool recursive, int setType, string[] versions)
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002F60 File Offset: 0x00001F60
		public MRepotItem GetItemChurnCount(string serverPath, string baseVersion, string diffVersion, DateTime startDate, DateTime endDate)
		{
			MRepotItem mrepotItem = new MRepotItem();
			string text = "";
			string text2 = "";
			MRepotItem result;
			if (baseVersion == string.Empty && diffVersion == string.Empty)
			{
				result = mrepotItem;
			}
			else
			{
				try
				{
					if (long.Parse(baseVersion) > long.Parse(diffVersion))
					{
						text = diffVersion;
						text2 = baseVersion;
					}
					else
					{
						text = baseVersion;
						text2 = diffVersion;
					}
				}
				catch
				{
					text = baseVersion;
					text2 = diffVersion;
				}
				if (text != string.Empty && text2 == string.Empty)
				{
					result = mrepotItem;
				}
				else
				{
					bool flag = false;
					bool flag2 = false;
					int num = 0;
					IVSSVersion ivssversion = null;
					IVSSVersion ivssversion2 = null;
					IVSSVersion ivssversion3 = null;
					try
					{
						VSSDatabase vssdatabase = new VSSDatabaseClass();
						vssdatabase.Open(VSSSourceControlProvider.DataFile, VSSSourceControlProvider.User, VSSSourceControlProvider.Passwords);
						VSSItem vssitem = vssdatabase.get_VSSItem(serverPath, false);
						foreach (object obj in vssitem.get_Versions(0))
						{
							IVSSVersion ivssversion4 = (IVSSVersion)obj;
							if (!(ivssversion4.Label != ""))
							{
								if (flag)
								{
									num++;
								}
								if (ivssversion4.VersionNumber.ToString() == text2)
								{
									flag = true;
									ivssversion = ivssversion4;
									ivssversion3 = ivssversion4;
								}
								else
								{
									if (ivssversion4.VersionNumber.ToString() == text)
									{
										flag2 = true;
										ivssversion2 = ivssversion4;
										break;
									}
									if (flag)
									{
										ivssversion3 = ivssversion4;
									}
								}
							}
						}
						vssdatabase.Close();
						if (flag2)
						{
							mrepotItem.ChurnCount = num;
							mrepotItem.ChurnStartDate = ivssversion2.Date;
							mrepotItem.ChurnEndDate = ivssversion.Date;
							if (mrepotItem.ChurnStartDate < startDate)
							{
								mrepotItem.ChurnStartDate = ivssversion3.Date;
							}
						}
						else if (flag)
						{
							if (ivssversion3 != null && startDate != DateTime.MinValue)
							{
								mrepotItem.ChurnCount = num + 1;
								mrepotItem.ChurnStartDate = ivssversion3.Date;
								if (mrepotItem.ChurnStartDate < startDate)
								{
									mrepotItem.ChurnCount = 1;
									mrepotItem.ChurnStartDate = ivssversion.Date;
								}
							}
							else
							{
								mrepotItem.ChurnCount = 1;
								mrepotItem.ChurnStartDate = ivssversion.Date;
							}
							mrepotItem.ChurnEndDate = ivssversion.Date;
						}
					}
					catch
					{
					}
					result = mrepotItem;
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public static string DataFile = "";

		// Token: 0x04000002 RID: 2
		public static string User = "";

		// Token: 0x04000003 RID: 3
		public static string Passwords = "";

		// Token: 0x04000004 RID: 4
		private object m_objSingleThread = new object();

		// Token: 0x04000005 RID: 5
		private static bool m_IsConnected = false;
	}
}
