using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.VersionControl.Common;
using MS.IT.LOC.Model;
using SourceDepotClient;

namespace MS.IT.LOC.SourceControl
{
	// Token: 0x02000005 RID: 5
	public class SDSourceControlProvider : ISourceControlProvider
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003400 File Offset: 0x00002400
		public bool Login(string ServerName, string serverPort, string LoginId, string Password)
		{
			if (serverPort.Trim() != "")
			{
				SDSourceControlProvider.SERVER_NAME = ServerName + ":" + serverPort;
			}
			else
			{
				SDSourceControlProvider.SERVER_NAME = ServerName + ":2905";
			}
			bool result;
			lock (this.m_objSingleThread)
			{
				try
				{
					this.sdConn = new SDConnectionClass();
					this.sdConn.DefineHost = Environment.MachineName;
					this.sdConn.DefinePort = SDSourceControlProvider.SERVER_NAME;
					this.sdResult = this.sdConn.Run(" files -d //depot/*", false, true);
					this.sdResult.WaitUntilFinished();
					SDCommandOutputs errorOutput = this.sdResult.ErrorOutput;
					foreach (object obj in errorOutput)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
						string text = sdcommandOutput.Message.ToString();
					}
					if (errorOutput.Count == 0)
					{
						SDSourceControlProvider.m_IsConnected = true;
						result = true;
					}
					else
					{
						result = false;
					}
				}
				catch (Exception ex)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000356C File Offset: 0x0000256C
		public SCItemSet GetChildItem(SCItem parent, bool recursive)
		{
			SCItemSet result;
			if (SDSourceControlProvider.m_IsConnected)
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

		// Token: 0x06000021 RID: 33 RVA: 0x000035B0 File Offset: 0x000025B0
		public bool Download(string serverPath, string localFile)
		{
			bool result;
			try
			{
				Monitor.Enter(this.m_objSingleThread);
				this.sdResult = this.sdConn.Run(" files -d  \"" + serverPath + "\"", false, true);
				this.sdResult.WaitUntilFinished();
				string text = serverPath;
				foreach (object obj in this.sdResult.AllOutput)
				{
					SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
					text = sdcommandOutput.Message.ToString();
					text = text.Substring(0, text.IndexOf(" - "));
				}
				this.sdResult = this.sdConn.Run(string.Concat(new string[]
				{
					"print -o  \"",
					localFile,
					"\" \"",
					text,
					"\""
				}), true, true);
				this.sdResult.WaitUntilFinished();
				SDCommandOutputs errorOutput = this.sdResult.ErrorOutput;
				if (errorOutput.Count != 0)
				{
					result = false;
				}
				else
				{
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
			}
			catch (Exception ex)
			{
				result = false;
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003768 File Offset: 0x00002768
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
				catch (Exception ex)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003DFC File Offset: 0x00002DFC
		public bool Download(string serverPath, string localFile, object versionSpec)
		{
			bool result;
			try
			{
				Monitor.Enter(this.m_objSingleThread);
				this.sdResult = this.sdConn.Run(string.Concat(new string[]
				{
					"print -o  \"",
					localFile,
					"\" \"",
					serverPath,
					versionSpec.ToString(),
					"\""
				}), false, true);
				this.sdResult.WaitUntilFinished();
				SDCommandOutputs errorOutput = this.sdResult.ErrorOutput;
				if (errorOutput.Count != 0)
				{
					result = false;
				}
				else
				{
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
			}
			catch (Exception ex)
			{
				result = true;
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003EE0 File Offset: 0x00002EE0
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, string baseSet, string lastSet)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add("");
			arrayList.Add("");
			string text = "C";
			string text2 = "C";
			string text3 = "[^0-9]";
			Regex regex = new Regex(text3);
			Match match = regex.Match(baseSet.ToString());
			try
			{
				Monitor.Enter(this.m_objSingleThread);
				if (match.Success)
				{
					this.sdResult = this.sdConn.Run("files -d @\"" + baseSet + "\"", false, true);
				}
				else
				{
					this.sdResult = this.sdConn.Run(" describe -s " + baseSet, false, true);
				}
				this.sdResult.WaitUntilFinished();
				foreach (object obj in this.sdResult.InfoOutput)
				{
					SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
					text3 = sdcommandOutput.Message.ToString();
					if (text3.Contains("Invalid changelist/client/label/date"))
					{
						break;
					}
					try
					{
						string text4;
						if (match.Success)
						{
							text4 = text3.Substring(0, text3.IndexOf(" - "));
						}
						else
						{
							text4 = text3;
						}
						if (text4.Contains(serverPath + "#"))
						{
							if (match.Success)
							{
								text = text4.Substring(serverPath.Length, text3.IndexOf(" - ") - serverPath.Length);
							}
							else
							{
								text = text4.Substring(text4.LastIndexOf("#"), text4.LastIndexOf(" ") - text4.LastIndexOf("#"));
							}
						}
					}
					catch
					{
					}
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			try
			{
				Monitor.Enter(this.m_objSingleThread);
				match = regex.Match(lastSet.ToString());
				if (match.Success)
				{
					this.sdResult = this.sdConn.Run("files -d @\"" + lastSet + "\"", false, true);
				}
				else
				{
					this.sdResult = this.sdConn.Run(" describe -s " + lastSet, false, true);
				}
				this.sdResult.WaitUntilFinished();
				foreach (object obj2 in this.sdResult.InfoOutput)
				{
					SDCommandOutput sdcommandOutput = (SDCommandOutput)obj2;
					text3 = sdcommandOutput.Message.ToString();
					if (text3.Contains("Invalid changelist/client/label/date"))
					{
						break;
					}
					try
					{
						string text4;
						if (match.Success)
						{
							text4 = text3.Substring(0, text3.IndexOf(" - "));
						}
						else
						{
							text4 = text3;
						}
						if (text4.Contains(serverPath + "#"))
						{
							if (match.Success)
							{
								text2 = text4.Substring(serverPath.Length, text3.IndexOf(" - ") - serverPath.Length);
							}
							else
							{
								text2 = text4.Substring(text4.LastIndexOf("#"), text4.LastIndexOf(" ") - text4.LastIndexOf("#"));
							}
						}
					}
					catch
					{
					}
				}
			}
			catch (Exception ex2)
			{
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			arrayList.Clear();
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

		// Token: 0x06000025 RID: 37 RVA: 0x000043DC File Offset: 0x000033DC
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, DateTime startDate, DateTime endDate)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add("");
			arrayList.Add("");
			string text = "C";
			string text2 = "C";
			DateTime t = DateTime.Parse(endDate.ToString().Substring(0, endDate.ToString().IndexOf(" ")) + " 23:59:59");
			try
			{
				Monitor.Enter(this.m_objSingleThread);
				this.sdResult = this.sdConn.Run("filelog \"" + serverPath + "\"", false, true);
				this.sdResult.WaitUntilFinished();
				foreach (object obj in this.sdResult.InfoOutput)
				{
					SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
					string text3 = sdcommandOutput.Message.ToString();
					if (text3.Contains("no such file(s)"))
					{
						return arrayList;
					}
					try
					{
						if (text3.Contains("on") && text3.Contains("by"))
						{
							string s = text3.Substring(text3.IndexOf("on") + 3, text3.IndexOf("by") - text3.IndexOf("on") - 4);
							if (DateTime.Parse(s) < t && DateTime.Parse(s) > startDate && text2 == "C")
							{
								text3 = text3.Substring(0, text3.IndexOf(" "));
								text2 = text3;
							}
							else if (DateTime.Parse(s) < startDate)
							{
								text3 = text3.Substring(0, text3.IndexOf(" "));
								text = text3;
								break;
							}
						}
					}
					catch
					{
					}
				}
				if (this.sdResult.ErrorOutput.Count > 0)
				{
					return arrayList;
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			arrayList.Clear();
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

		// Token: 0x06000026 RID: 38 RVA: 0x00004710 File Offset: 0x00003710
		public ArrayList GetFirstAndLastVersionSpec(string serverPath, int setType, string versionSet)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add("");
			arrayList.Add("");
			string text = "C";
			string text2 = "C";
			string text3 = "[^0-9]";
			Regex regex = new Regex(text3);
			Match match = regex.Match(versionSet.ToString());
			try
			{
				try
				{
					Monitor.Enter(this.m_objSingleThread);
					if (match.Success)
					{
						this.sdResult = this.sdConn.Run("files -d @\"" + versionSet + "\"", false, true);
					}
					else
					{
						this.sdResult = this.sdConn.Run("describe -s " + versionSet, false, true);
					}
					this.sdResult.WaitUntilFinished();
					foreach (object obj in this.sdResult.InfoOutput)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
						text3 = sdcommandOutput.Message.ToString();
						if (text3.Contains("Invalid changelist/client/label/date"))
						{
							return arrayList;
						}
						try
						{
							string text4;
							if (match.Success)
							{
								text4 = text3.Substring(0, text3.IndexOf(" - "));
							}
							else
							{
								text4 = text3;
							}
							if (text4.Contains(serverPath + "#"))
							{
								if (match.Success)
								{
									text2 = text4.Substring(serverPath.Length, text3.IndexOf(" - ") - serverPath.Length);
								}
								else
								{
									text2 = text4.Substring(text4.LastIndexOf("#"), text4.LastIndexOf(" ") - text4.LastIndexOf("#"));
								}
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
					return arrayList;
				}
				finally
				{
					Monitor.Exit(this.m_objSingleThread);
				}
				try
				{
					Monitor.Enter(this.m_objSingleThread);
					this.sdResult = this.sdConn.Run("filelog \"" + serverPath + "\"", false, true);
					this.sdResult.WaitUntilFinished();
					int num = 0;
					foreach (object obj2 in this.sdResult.InfoOutput)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj2;
						text3 = sdcommandOutput.Message.ToString();
						if (text3.Contains("no such file(s)") || text3.Contains(" - no permission to"))
						{
							break;
						}
						try
						{
							if (num > 0 && !text3.Contains(" delete ") && text3.Contains(" change "))
							{
								text = text3.Substring(0, text3.IndexOf(" change "));
								break;
							}
							if (text3.Contains(text2 + " "))
							{
								num++;
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				finally
				{
					Monitor.Exit(this.m_objSingleThread);
				}
			}
			catch (Exception ex)
			{
			}
			arrayList.Clear();
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

		// Token: 0x06000027 RID: 39 RVA: 0x00004BC4 File Offset: 0x00003BC4
		public object GetVersionSpec(DateTime date, bool latest)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004BD8 File Offset: 0x00003BD8
		private SCItemSet GetTeamProjects()
		{
			SCItemSet result;
			try
			{
				Monitor.Enter(this.m_objSingleThread);
				SDCommandOutputs infoOutput = this.sdResult.InfoOutput;
				ArrayList arrayList = new ArrayList();
				ArrayList arrayList2 = new ArrayList();
				string str = "";
				try
				{
					foreach (object obj in infoOutput)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
						string text = sdcommandOutput.Message.ToString();
						if (text.Contains("no such file(s)") || text.Contains(" - no permission to"))
						{
							break;
						}
						try
						{
							if (text.Contains("//depot"))
							{
								text = text.Substring(text.IndexOf("//depot") + 8);
								str = "//depot/";
							}
							else if (text.Contains("//Depot"))
							{
								text = text.Substring(text.IndexOf("//Depot") + 8);
								str = "//Depot/";
							}
							text = text.Substring(0, text.IndexOf(" - "));
							text = text.Substring(0, text.LastIndexOf("#"));
							if (!arrayList2.Contains(text))
							{
								arrayList2.Add(text);
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				finally
				{
					Monitor.Exit(this.m_objSingleThread);
				}
				try
				{
					Monitor.Enter(this.m_objSingleThread);
					string text2 = " dirs //depot/* ";
					SDResults sdresults = this.sdConn.Run(text2, false, true);
					sdresults.WaitUntilFinished();
					SDCommandOutputs allOutput = sdresults.AllOutput;
					if (sdresults.ErrorOutput.Count != 0)
					{
						SDSourceControlProvider.m_IsConnected = false;
						return null;
					}
					foreach (object obj2 in allOutput)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj2;
						string text = sdcommandOutput.Message.ToString();
						if (text.Contains("no such file(s)"))
						{
							break;
						}
						try
						{
							if (text.Contains("//depot"))
							{
								text = text.Substring(text.IndexOf("//depot") + 8);
								str = "//depot/";
							}
							else if (text.Contains("//Depot"))
							{
								text = text.Substring(text.IndexOf("//Depot") + 8);
								str = "//Depot/";
							}
							if (!arrayList.Contains(text))
							{
								arrayList.Add(text);
							}
						}
						catch
						{
						}
					}
				}
				catch (Exception ex)
				{
				}
				finally
				{
					Monitor.Exit(this.m_objSingleThread);
				}
				arrayList2.Sort();
				arrayList.Sort();
				SCItemSet scitemSet = new SCItemSet();
				for (int i = 0; i < arrayList.Count; i++)
				{
					scitemSet.Add(new SCItem
					{
						Path = str + arrayList[i].ToString(),
						Name = arrayList[i].ToString(),
						ScType = SCItemType.FOLDER
					});
				}
				for (int i = 0; i < arrayList2.Count; i++)
				{
					scitemSet.Add(new SCItem
					{
						Path = str + arrayList2[i].ToString(),
						Name = arrayList2[i].ToString(),
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

		// Token: 0x06000029 RID: 41 RVA: 0x000050A0 File Offset: 0x000040A0
		private SCItemSet GetChildItems(SCItem parent, bool recursive)
		{
			SCItemSet result;
			try
			{
				ArrayList arrayList = new ArrayList();
				ArrayList arrayList2 = new ArrayList();
				try
				{
					Monitor.Enter(this.m_objSingleThread);
					SDResults sdresults = this.sdConn.Run(" files -d \"" + parent.Path + "/*\"", false, true);
					sdresults.WaitUntilFinished();
					if (sdresults.ErrorOutput.Count != 0)
					{
						SDSourceControlProvider.m_IsConnected = false;
						return null;
					}
					SDCommandOutputs infoOutput = sdresults.InfoOutput;
					foreach (object obj in infoOutput)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
						string text = sdcommandOutput.Message.ToString();
						if (text.Contains("no such file(s)") || text.Contains(" - no permission to"))
						{
							break;
						}
						try
						{
							text = text.Substring(0, text.IndexOf(" - "));
							text = text.Substring(0, text.LastIndexOf("#"));
							text = text.Substring(parent.Path.Length + 1);
							if (!arrayList2.Contains(text))
							{
								arrayList2.Add(text);
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				finally
				{
					Monitor.Exit(this.m_objSingleThread);
				}
				try
				{
					Monitor.Enter(this.m_objSingleThread);
					SDResults sdresults2 = this.sdConn.Run(" dirs \"" + parent.Path + "/*\"", false, true);
					sdresults2.WaitUntilFinished();
					if (sdresults2.ErrorOutput.Count != 0)
					{
						SDSourceControlProvider.m_IsConnected = false;
						return null;
					}
					SDCommandOutputs infoOutput2 = sdresults2.InfoOutput;
					foreach (object obj2 in infoOutput2)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj2;
						string text = sdcommandOutput.Message.ToString();
						if (text.Contains("no such file(s)"))
						{
							break;
						}
						try
						{
							text = text.Substring(parent.Path.Length + 1);
							if (!arrayList.Contains(text))
							{
								arrayList.Add(text);
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				finally
				{
					Monitor.Exit(this.m_objSingleThread);
				}
				arrayList2.Sort();
				arrayList.Sort();
				SCItemSet scitemSet = new SCItemSet();
				for (int i = 0; i < arrayList.Count; i++)
				{
					scitemSet.Add(new SCItem
					{
						Path = parent.Path + "/" + arrayList[i].ToString(),
						Name = arrayList[i].ToString(),
						ScType = SCItemType.FOLDER
					});
				}
				for (int i = 0; i < arrayList2.Count; i++)
				{
					scitemSet.Add(new SCItem
					{
						Path = parent.Path + "/" + arrayList2[i].ToString(),
						Name = arrayList2[i].ToString(),
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

		// Token: 0x0600002A RID: 42 RVA: 0x00005518 File Offset: 0x00004518
		public bool InitFilesInChangeset()
		{
			if (SDSourceControlProvider.m_FilesInChangeset.Count > 0)
			{
				SDSourceControlProvider.m_FilesInChangeset.Clear();
			}
			try
			{
				string text = "[^0-9]";
				Regex regex = new Regex(text);
				Match match = regex.Match(SDSourceControlProvider.m_BaseChangeset.ToString());
				Monitor.Enter(this.m_objSingleThread);
				if (SDSourceControlProvider.m_BaseChangeset.Length > 0 && match.Success)
				{
					this.sdResult = this.sdConn.Run("files -d @\"" + SDSourceControlProvider.m_BaseChangeset + "\"", false, true);
					this.sdResult.WaitUntilFinished();
					SDCommandOutputs sdcommandOutputs = this.sdResult.InfoOutput;
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					foreach (object obj in sdcommandOutputs)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
						text = sdcommandOutput.Message.ToString();
						if (text.Contains("Invalid changelist/client/label/date") || text.Contains("no such file(s)"))
						{
							break;
						}
						try
						{
							text = text.Substring(0, text.IndexOf(" - "));
							if (!SDSourceControlProvider.m_FilesInChangeset.Contains(text))
							{
								SDSourceControlProvider.m_FilesInChangeset.Add(text);
							}
						}
						catch
						{
						}
					}
				}
				if (SDSourceControlProvider.m_BaseChangeset.Length > 0 && !match.Success)
				{
					this.sdResult = this.sdConn.Run("describe -s " + SDSourceControlProvider.m_BaseChangeset, false, true);
					this.sdResult.WaitUntilFinished();
					SDCommandOutputs sdcommandOutputs = this.sdResult.InfoOutput;
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					foreach (object obj2 in sdcommandOutputs)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj2;
						text = sdcommandOutput.Message.ToString();
						if (text.Contains("Invalid changelist/client/label/date") || text.Contains("no such file(s)"))
						{
							break;
						}
						try
						{
							if (text.Contains("#"))
							{
								string text2 = text.Substring(text.LastIndexOf(" "));
								if (!text2.Contains("delete"))
								{
									text = text.Substring(0, text.LastIndexOf(" "));
									if (!SDSourceControlProvider.m_FilesInChangeset.Contains(text))
									{
										SDSourceControlProvider.m_FilesInChangeset.Add(text);
									}
								}
							}
						}
						catch
						{
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			try
			{
				string text = "[^0-9]";
				Regex regex = new Regex(text);
				Match match = regex.Match(SDSourceControlProvider.m_DiffChangeset.ToString());
				Monitor.Enter(this.m_objSingleThread);
				if (SDSourceControlProvider.m_DiffChangeset.Length > 0 && match.Success)
				{
					this.sdResult = this.sdConn.Run("files -d @\"" + SDSourceControlProvider.m_DiffChangeset + "\"", false, true);
					this.sdResult.WaitUntilFinished();
					SDCommandOutputs sdcommandOutputs = this.sdResult.AllOutput;
					foreach (object obj3 in sdcommandOutputs)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj3;
						text = sdcommandOutput.Message.ToString();
						if (text.Contains("Invalid changelist/client/label/date") || text.Contains("no such file(s)"))
						{
							break;
						}
						try
						{
							text = text.Substring(0, text.IndexOf(" - "));
							if (!SDSourceControlProvider.m_FilesInChangeset.Contains(text))
							{
								SDSourceControlProvider.m_FilesInChangeset.Add(text);
							}
						}
						catch
						{
						}
					}
				}
				if (SDSourceControlProvider.m_DiffChangeset.Length > 0 && !match.Success)
				{
					this.sdResult = this.sdConn.Run("describe -s " + SDSourceControlProvider.m_DiffChangeset, false, true);
					this.sdResult.WaitUntilFinished();
					SDCommandOutputs sdcommandOutputs = this.sdResult.InfoOutput;
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					foreach (object obj4 in sdcommandOutputs)
					{
						SDCommandOutput sdcommandOutput = (SDCommandOutput)obj4;
						text = sdcommandOutput.Message.ToString();
						if (text.Contains("Invalid changelist/client/label/date") || text.Contains("no such file(s)"))
						{
							break;
						}
						if (text.Contains("#"))
						{
							try
							{
								string text2 = text.Substring(text.LastIndexOf(" "));
								if (!text2.Contains("delete"))
								{
									text = text.Substring(0, text.LastIndexOf(" "));
									if (!SDSourceControlProvider.m_FilesInChangeset.Contains(text))
									{
										SDSourceControlProvider.m_FilesInChangeset.Add(text);
									}
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
				return false;
			}
			finally
			{
				Monitor.Exit(this.m_objSingleThread);
			}
			return true;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005C28 File Offset: 0x00004C28
		public SCItemSet GetItemsInPath(string parentPath)
		{
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			for (int i = 0; i < SDSourceControlProvider.m_FilesInChangeset.Count; i++)
			{
				string text = SDSourceControlProvider.m_FilesInChangeset[i].ToString();
				if (text.Contains(parentPath + "/"))
				{
					try
					{
						text = text.Substring(parentPath.Length + 1);
						if (text.Contains("/"))
						{
							text = text.Substring(0, text.IndexOf("/"));
							if (!arrayList.Contains(text))
							{
								arrayList.Add(text);
							}
						}
						else
						{
							text = text.Substring(0, text.LastIndexOf("#"));
							if (!arrayList2.Contains(text))
							{
								arrayList2.Add(text);
							}
						}
					}
					catch
					{
					}
				}
			}
			arrayList2.Sort();
			arrayList.Sort();
			SCItemSet scitemSet = new SCItemSet();
			for (int i = 0; i < arrayList.Count; i++)
			{
				scitemSet.Add(new SCItem
				{
					Path = parentPath + "/" + arrayList[i].ToString(),
					Name = arrayList[i].ToString(),
					ScType = SCItemType.FOLDER
				});
			}
			for (int i = 0; i < arrayList2.Count; i++)
			{
				scitemSet.Add(new SCItem
				{
					Path = parentPath + "/" + arrayList2[i].ToString(),
					Name = arrayList2[i].ToString(),
					ScType = SCItemType.FILE
				});
			}
			return scitemSet;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005E28 File Offset: 0x00004E28
		public SCItemSet GetAllFilesInPath(string parentPath)
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < SDSourceControlProvider.m_FilesInChangeset.Count; i++)
			{
				try
				{
					string text = SDSourceControlProvider.m_FilesInChangeset[i].ToString();
					text = text.Substring(parentPath.Length + 1);
					text = text.Substring(0, text.IndexOf(" - "));
					text = text.Substring(0, text.LastIndexOf("#"));
					if (!arrayList.Contains(text))
					{
						arrayList.Add(text);
					}
				}
				catch
				{
				}
			}
			arrayList.Sort();
			SCItemSet scitemSet = new SCItemSet();
			for (int i = 0; i < arrayList.Count; i++)
			{
				scitemSet.Add(new SCItem
				{
					Path = parentPath + "/" + arrayList[i].ToString(),
					Name = arrayList[i].ToString(),
					ScType = SCItemType.FILE
				});
			}
			return scitemSet;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005F50 File Offset: 0x00004F50
		public SCItemSet GetTeamProjectsInSet(string baseChangeset, string diffChangeset)
		{
			if (SDSourceControlProvider.m_BaseChangeset != baseChangeset || SDSourceControlProvider.m_DiffChangeset != diffChangeset)
			{
				SDSourceControlProvider.m_BaseChangeset = baseChangeset;
				SDSourceControlProvider.m_DiffChangeset = diffChangeset;
				this.InitFilesInChangeset();
			}
			SCItemSet result;
			if (SDSourceControlProvider.m_FilesInChangeset.Count < 1)
			{
				result = null;
			}
			else
			{
				result = this.GetItemsInPath("//depot");
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005FBC File Offset: 0x00004FBC
		public SCItemSet GetChildItemsInSet(SCItem parent, bool recursive, string baseChangeset, string diffChangeset)
		{
			if (SDSourceControlProvider.m_BaseChangeset != baseChangeset || SDSourceControlProvider.m_DiffChangeset != diffChangeset)
			{
				SDSourceControlProvider.m_BaseChangeset = baseChangeset;
				SDSourceControlProvider.m_DiffChangeset = diffChangeset;
				this.InitFilesInChangeset();
			}
			SCItemSet result;
			if (SDSourceControlProvider.m_FilesInChangeset.Count < 1)
			{
				result = null;
			}
			else
			{
				try
				{
					if (recursive)
					{
						result = this.GetAllFilesInPath(parent.Path);
					}
					else
					{
						result = this.GetItemsInPath(parent.Path);
					}
				}
				catch
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000605C File Offset: 0x0000505C
		public SCItemSet GetChildItemInSet(SCItem parent, bool recursive, int setType, string[] versions)
		{
			string baseChangeset = "";
			string diffChangeset = "";
			if (versions.Length > 0)
			{
				baseChangeset = versions[0];
			}
			if (versions.Length > 1)
			{
				diffChangeset = versions[1];
			}
			SCItemSet result;
			if (parent == null)
			{
				result = this.GetTeamProjectsInSet(baseChangeset, diffChangeset);
			}
			else
			{
				result = this.GetChildItemsInSet(parent, recursive, baseChangeset, diffChangeset);
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000060C4 File Offset: 0x000050C4
		public MRepotItem GetItemChurnCount(string serverPath, string baseVersion, string diffVersion, DateTime startDate, DateTime endDate)
		{
			MRepotItem mrepotItem = new MRepotItem();
			if (baseVersion.IndexOf('#') == 0)
			{
				baseVersion = baseVersion.Substring(1);
			}
			if (diffVersion.IndexOf('#') == 0)
			{
				diffVersion = diffVersion.Substring(1);
			}
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
					string text3 = string.Empty;
					string text4 = string.Empty;
					string text5 = string.Empty;
					try
					{
						Monitor.Enter(this.m_objSingleThread);
						this.sdResult = this.sdConn.Run("filelog \"" + serverPath + "\"", false, true);
						this.sdResult.WaitUntilFinished();
						foreach (object obj in this.sdResult.AllOutput)
						{
							SDCommandOutput sdcommandOutput = (SDCommandOutput)obj;
							string text6 = sdcommandOutput.Message.ToString();
							if (text6.Contains("on") && text6.Contains("by"))
							{
								if (flag)
								{
									num++;
								}
								if (!flag && text6.IndexOf("#" + text2 + " ") == 0)
								{
									flag = true;
									text4 = text6;
									text5 = text6;
								}
								else
								{
									if (text6.IndexOf("#" + text + " ") == 0)
									{
										flag2 = true;
										text3 = text6;
										break;
									}
									if (flag)
									{
										text5 = text6;
									}
								}
							}
						}
						if (this.sdResult.ErrorOutput.Count > 0)
						{
							flag2 = false;
						}
						if (flag2)
						{
							mrepotItem.ChurnCount = num;
							mrepotItem.ChurnStartDate = DateTime.Parse(text3.Substring(text3.IndexOf("on") + 3, text3.IndexOf("by") - text3.IndexOf("on") - 4));
							mrepotItem.ChurnEndDate = DateTime.Parse(text4.Substring(text4.IndexOf("on") + 3, text4.IndexOf("by") - text4.IndexOf("on") - 4));
							if (mrepotItem.ChurnStartDate < startDate)
							{
								mrepotItem.ChurnStartDate = DateTime.Parse(text5.Substring(text5.IndexOf("on") + 3, text5.IndexOf("by") - text5.IndexOf("on") - 4));
							}
						}
						else if (flag)
						{
							if (text5 != string.Empty && startDate != DateTime.MinValue)
							{
								mrepotItem.ChurnCount = num + 1;
								mrepotItem.ChurnStartDate = DateTime.Parse(text5.Substring(text5.IndexOf("on") + 3, text5.IndexOf("by") - text5.IndexOf("on") - 4));
								if (mrepotItem.ChurnStartDate < startDate)
								{
									mrepotItem.ChurnCount = 1;
									mrepotItem.ChurnStartDate = DateTime.Parse(text4.Substring(text4.IndexOf("on") + 3, text4.IndexOf("by") - text4.IndexOf("on") - 4));
								}
							}
							else
							{
								mrepotItem.ChurnCount = 1;
								mrepotItem.ChurnStartDate = DateTime.Parse(text4.Substring(text4.IndexOf("on") + 3, text4.IndexOf("by") - text4.IndexOf("on") - 4));
							}
							mrepotItem.ChurnEndDate = DateTime.Parse(text4.Substring(text4.IndexOf("on") + 3, text4.IndexOf("by") - text4.IndexOf("on") - 4));
						}
					}
					catch
					{
					}
					finally
					{
						Monitor.Exit(this.m_objSingleThread);
					}
					result = mrepotItem;
				}
			}
			return result;
		}

		// Token: 0x04000006 RID: 6
		public static string SERVER_NAME = "BGIT-SDOEMLOC";

		// Token: 0x04000007 RID: 7
		public SDConnectionClass sdConn;

		// Token: 0x04000008 RID: 8
		public SDResults sdResult;

		// Token: 0x04000009 RID: 9
		private static bool m_IsConnected = false;

		// Token: 0x0400000A RID: 10
		private static string m_BaseChangeset = "";

		// Token: 0x0400000B RID: 11
		private static string m_DiffChangeset = "";

		// Token: 0x0400000C RID: 12
		private static ArrayList m_FilesInChangeset = new ArrayList();

		// Token: 0x0400000D RID: 13
		private object m_objSingleThread = new object();
	}
}
