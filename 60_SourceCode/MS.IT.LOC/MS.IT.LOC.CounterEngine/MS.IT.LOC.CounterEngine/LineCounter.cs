using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x0200000F RID: 15
	public class LineCounter
	{
		// Token: 0x06000091 RID: 145 RVA: 0x000041D8 File Offset: 0x000031D8
		public LineCounter(XmlNode node)
		{
			this.name = node.Attributes["name"].Value;
			this.LoadFileExtensions(node);
			this.LoadCodeAreas(node);
			this.LoadPspMetricAreas(node);
			this.CreateCounterData();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000042C4 File Offset: 0x000032C4
		private void LoadPspMetricAreas(XmlNode node)
		{
			XmlNodeList xmlNodeList = node.SelectNodes("pspMetricArea");
			this.pspMetricAeras = new PspMetricAera[xmlNodeList.Count];
			int num = 0;
			foreach (object obj in xmlNodeList)
			{
				XmlNode node2 = (XmlNode)obj;
				PspMetricAera pspMetricAera = new PspMetricAera(node2);
				this.pspMetricAeras[num] = pspMetricAera;
				num++;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000435C File Offset: 0x0000335C
		private void LoadFileExtensions(XmlNode node)
		{
			XmlNodeList xmlNodeList = node.SelectNodes("fileExtension");
			StringBuilder stringBuilder = new StringBuilder(25);
			stringBuilder.Append(".+\\.(");
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				stringBuilder.AppendFormat("({0})|", xmlNode.InnerText);
			}
			stringBuilder.Length--;
			stringBuilder.Append(")$");
			string pattern = stringBuilder.ToString();
			this.extensionExpression = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004424 File Offset: 0x00003424
		public bool CanCountFile(string filename)
		{
			return this.extensionExpression.IsMatch(filename);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004444 File Offset: 0x00003444
		private void LoadCodeAreas(XmlNode node)
		{
			XmlNodeList xmlNodeList = node.SelectNodes("codeArea");
			this.codeAreas = new CodeArea[xmlNodeList.Count];
			int num = 0;
			foreach (object obj in xmlNodeList)
			{
				XmlNode node2 = (XmlNode)obj;
				CodeArea codeArea = new CodeArea(node2);
				this.codeAreas[num++] = codeArea;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000044DC File Offset: 0x000034DC
		private void CreateCounterData()
		{
			string text = string.Format("{0}: total lines", this.Name);
			this.totalLines = new CounterData(text);
			text = string.Format("{0}: lines of code", this.Name);
			this.linesOfCode = new CounterData(text);
			text = string.Format("{0}: added lines of code", this.Name);
			this.addedLines = new CounterData(text);
			text = string.Format("{0}: modifiled lines of code", this.Name);
			this.modifiedLines = new CounterData(text);
			text = string.Format("{0}: deleted of code", this.Name);
			this.deleteLines = new CounterData(text);
			this.counterData = new CounterData[this.codeAreas.Length];
			for (int i = 0; i < this.codeAreas.Length; i++)
			{
				text = string.Format("{0}: {1}", this.Name, this.codeAreas[i].Name);
				this.counterData[i] = new CounterData(text);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000045D4 File Offset: 0x000035D4
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000045EC File Offset: 0x000035EC
		public string CurrentFile
		{
			get
			{
				return this.currentFile;
			}
			set
			{
				if (this.inMultiLineArea)
				{
					this.inMultiLineArea = false;
				}
				if (this.diffInMultiLineArea)
				{
					this.diffInMultiLineArea = false;
				}
				this.currentFile = value;
				foreach (CounterData counterData in this.counterData)
				{
					counterData.CurrentFile = this.currentFile;
				}
				this.totalLines.CurrentFile = this.currentFile;
				this.totalLines.CurrentDiffFile = this.IsCountOnDiff;
				this.linesOfCode.CurrentFile = this.currentFile;
				this.linesOfCode.CurrentDiffFile = this.IsCountOnDiff;
				this.addedLines.CurrentFile = this.currentFile;
				this.addedLines.CurrentDiffFile = this.IsCountOnDiff;
				this.modifiedLines.CurrentFile = this.currentFile;
				this.modifiedLines.CurrentDiffFile = this.IsCountOnDiff;
				this.deleteLines.CurrentFile = this.currentFile;
				this.deleteLines.CurrentDiffFile = this.IsCountOnDiff;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000470C File Offset: 0x0000370C
		public LineCounter()
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000047C0 File Offset: 0x000037C0
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000047D8 File Offset: 0x000037D8
		public string[] FileExtensions
		{
			get
			{
				return (string[])this.fileExtensions.ToArray(typeof(string[]));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004814 File Offset: 0x00003814
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00004804 File Offset: 0x00003804
		public string DiffFileName
		{
			get
			{
				return this.objDiffHandler.FileName;
			}
			set
			{
				this.objDiffHandler = new DiffHandler(value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004834 File Offset: 0x00003834
		private bool IsCountOnDiff
		{
			get
			{
				return !string.IsNullOrEmpty(this.objDiffHandler.FileName);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000485C File Offset: 0x0000385C
		public virtual void ProcessLine(string line)
		{
			this.totalLines.IncrementCounter();
			if (this.IsCountOnDiff)
			{
				this.ProcessDiffLines(line);
			}
			else
			{
				this.ProcessLatestLines(line);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000489C File Offset: 0x0000389C
		public void ProcesspspMetricCounterData(ref PspMetricCounterData myPspMetricCounterData)
		{
			if (myPspMetricCounterData.PspExistType == 0)
			{
				myPspMetricCounterData.addedLine = myPspMetricCounterData.totalLine;
				myPspMetricCounterData.baseLine = 0;
				myPspMetricCounterData.deleteLine = 0;
				myPspMetricCounterData.modifyLine = 0;
			}
			if (myPspMetricCounterData.PspExistType == 2 || myPspMetricCounterData.PspExistType == 1 || myPspMetricCounterData.PspExistType == 5)
			{
				myPspMetricCounterData.baseLine = myPspMetricCounterData.totalLine;
			}
			if (myPspMetricCounterData.PspExistType == 3)
			{
				myPspMetricCounterData.baseLine = myPspMetricCounterData.totalLine;
				myPspMetricCounterData.deleteLine = myPspMetricCounterData.totalLine;
				myPspMetricCounterData.modifyLine = 0;
				myPspMetricCounterData.addedLine = 0;
			}
			if (myPspMetricCounterData.startPositionFlat == 1 && myPspMetricCounterData.startLine != 0 && myPspMetricCounterData.startLineNew != 0)
			{
				myPspMetricCounterData.addedLine += myPspMetricCounterData.startLine - myPspMetricCounterData.startLineNew;
			}
			if (myPspMetricCounterData.startPositionFlat == 2 && myPspMetricCounterData.startLine != 0 && myPspMetricCounterData.startLineNew != 0)
			{
				myPspMetricCounterData.deleteLine += myPspMetricCounterData.startLineNew - myPspMetricCounterData.startLine;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000049EC File Offset: 0x000039EC
		private void ProcessLatestLines(string line)
		{
			for (int i = 0; i < this.pspMetricAeras.Length; i++)
			{
				int onCounting = this.pspMetricAeras[i].onCounting;
				if (this.pspMetricAeras[i].toCount && this.pspMetricAeras[i].isAPspMetricStartFlag(line))
				{
					if (onCounting < this.pspMetricAeras[i].onCounting)
					{
						for (int j = 0; j < this.pspMetricAeras.Length; j++)
						{
							if (this.pspMetricAeras[j].pspMetricCounterData.startLine > 0 && this.pspMetricAeras[j].pspMetricCounterData.endLine == 0 && i != j && this.pspMetricAeras[j].onCounting > 0)
							{
								this.pspMetricAeras[j].onCounting++;
							}
						}
						this.pspMetricAeras[i].pspMetricCounterData.startLine = this.linesOfCode.TotalCount;
						this.pspMetricAeras[i].pspMetricCounterData.totalLine = this.linesOfCode.TotalCount;
						if (this.IsCountOnDiff && this.pspMetricAeras[i].pspMetricCounterData.addedLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.deleteLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.modifyLine == 0)
						{
							this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.addedLines.CurrentValue;
							this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue;
							this.pspMetricAeras[i].pspMetricCounterData.modifyLine = this.modifiedLines.CurrentValue;
						}
					}
					else
					{
						this.pspMetricAeras[i].pspMetricCounterData.startLine = this.linesOfCode.TotalCount;
						this.pspMetricAeras[i].pspMetricCounterData.totalLine = this.linesOfCode.TotalCount;
						if (this.IsCountOnDiff && this.pspMetricAeras[i].pspMetricCounterData.addedLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.deleteLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.modifyLine == 0)
						{
							this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.addedLines.CurrentValue;
							this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue;
							this.pspMetricAeras[i].pspMetricCounterData.modifyLine = this.modifiedLines.CurrentValue;
						}
						this.pspMetricAeras[i].pspMetricCounterData.startPositionFlat = 1;
					}
				}
			}
			for (int i = 0; i < this.pspMetricAeras.Length; i++)
			{
				if (this.pspMetricAeras[i].toCount && this.pspMetricAeras[i].isAPspMetricEndFlag(line) && this.pspMetricAeras[i].pspMetricCounterData.endLine >= 0)
				{
					if (this.pspMetricAeras[i].pspMetricCounterData.meetEnd)
					{
						this.pspMetricAeras[i].pspMetricCounterData.deleteLine += this.linesOfCode.TotalCount - this.pspMetricAeras[i].pspMetricCounterData.endLine;
						break;
					}
					this.pspMetricAeras[i].pspMetricCounterData.totalLine = this.linesOfCode.TotalCount - this.pspMetricAeras[i].pspMetricCounterData.totalLine;
					if (this.pspMetricAeras[i].pspMetricCounterData.endLine == 0)
					{
						if (this.IsCountOnDiff)
						{
							this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.addedLines.CurrentValue - this.pspMetricAeras[i].pspMetricCounterData.addedLine;
							this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue - this.pspMetricAeras[i].pspMetricCounterData.deleteLine;
							this.pspMetricAeras[i].pspMetricCounterData.modifyLine = this.modifiedLines.CurrentValue - this.pspMetricAeras[i].pspMetricCounterData.modifyLine;
						}
					}
					this.pspMetricAeras[i].pspMetricCounterData.endLine = this.totalLines.TotalCount;
					int index = ((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Count - 1;
					if (((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Count > 0 && this.pspMetricAeras[i].pspMetricCounterData.PspExistType == 0 && ((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].PspExistType == 5)
					{
						((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].baseLine += this.pspMetricAeras[i].pspMetricCounterData.totalLine;
						((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].deleteLine += this.pspMetricAeras[i].pspMetricCounterData.totalLine;
					}
					if (((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Count > 0 && this.pspMetricAeras[i].pspMetricCounterData.PspExistType == 3 && ((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].PspExistType == 6)
					{
						((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].addedLine += this.pspMetricAeras[i].pspMetricCounterData.totalLine + this.pspMetricAeras[i].pspMetricCounterData.addedLine - this.pspMetricAeras[i].pspMetricCounterData.deleteLine;
					}
					this.ProcesspspMetricCounterData(ref this.pspMetricAeras[i].pspMetricCounterData);
					this.pspMetricAeras[i].pspMetricCounterData.PspMetricTypeName = this.pspMetricAeras[i].name;
					for (int j = 0; j < this.pspMetricAeras.Length; j++)
					{
						if (this.pspMetricAeras[j].pspMetricCounterData.startLine > 0 && this.pspMetricAeras[j].pspMetricCounterData.endLine == 0 && i != j && this.pspMetricAeras[j].onCounting == this.pspMetricAeras[i].onCounting + 1)
						{
							this.pspMetricAeras[j].pspMetricCounterData.itemCount++;
							this.pspMetricAeras[i].pspMetricCounterData.parentString = this.pspMetricAeras[j].pspMetricCounterData.Name;
							break;
						}
					}
					if (!this.IsCountOnDiff)
					{
						string text = this.currentFile.Substring(0, this.currentFile.LastIndexOf("\\"));
						text = text.Substring(0, text.LastIndexOf("\\"));
						text = text + "\\Diff" + this.currentFile.Substring(text.Length);
						if (File.Exists(text))
						{
							this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.pspMetricAeras[i].pspMetricCounterData.baseLine;
							this.pspMetricAeras[i].pspMetricCounterData.baseLine = 0;
						}
					}
					this.pspMetricAeras[i].pspMetricCounterData.meetEnd = true;
					((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Add(this.pspMetricAeras[i].pspMetricCounterData);
					for (int j = 0; j < this.pspMetricAeras.Length; j++)
					{
						if (this.pspMetricAeras[j].onCounting > 0)
						{
							this.pspMetricAeras[j].onCounting--;
						}
					}
				}
			}
			this.isCodeLine = true;
			if (this.inMultiLineArea)
			{
				this.counterData[this.multiLineArea].IncrementCounter();
				this.isCodeLine = this.codeAreas[this.multiLineArea].CountsAsCode;
				if (this.codeAreas[this.multiLineArea].MatchesEnd(line.Trim()))
				{
					this.inMultiLineArea = false;
				}
			}
			else
			{
				for (int i = 0; i < this.codeAreas.Length; i++)
				{
					if (this.codeAreas[i].MultiLine)
					{
						if (this.codeAreas[i].MatchesStart(line))
						{
							this.inMultiLineArea = true;
							this.multiLineArea = i;
							this.counterData[i].IncrementCounter();
							this.isCodeLine = this.codeAreas[i].CountsAsCode;
							if (this.codeAreas[i].MatchesEnd(line))
							{
								this.inMultiLineArea = false;
							}
							break;
						}
					}
					else if (this.codeAreas[i].Matches(line))
					{
						this.counterData[i].IncrementCounter();
						this.isCodeLine = this.codeAreas[i].CountsAsCode;
						break;
					}
				}
			}
			if (this.isCodeLine)
			{
				this.linesOfCode.IncrementCounter();
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005444 File Offset: 0x00004444
		private void ProcessDiffLines(string sLine)
		{
			ArrayList arrayList = new ArrayList();
			FileChangeType fileChangeType = FileChangeType.NoChange;
			bool flag = true;
			int num = 0;
			ArrayList arrayList2 = new ArrayList();
			arrayList = this.objDiffHandler.GetLinesAt(this.totalLines.CurrentValue, out fileChangeType, out arrayList2);
			num = arrayList2.Count;
			bool flag2 = this.inMultiLineArea;
			int num2 = this.multiLineArea;
			this.ProcessLatestLines(sLine);
			if (arrayList.Count != 0 || arrayList2.Count != 0 || fileChangeType == FileChangeType.NoChange)
			{
				int num3 = -1;
				int num4 = 0;
				foreach (object obj in arrayList2)
				{
					string text = (string)obj;
					num4++;
					num3++;
					for (int i = 0; i < this.pspMetricAeras.Length; i++)
					{
						int onCounting = this.pspMetricAeras[i].onCounting;
						if (this.pspMetricAeras[i].toCount && this.pspMetricAeras[i].isAPspMetricStartFlag(text))
						{
							if (onCounting < this.pspMetricAeras[i].onCounting)
							{
								for (int j = 0; j < this.pspMetricAeras.Length; j++)
								{
									if (this.pspMetricAeras[j].pspMetricCounterData.startLine >= 0 && this.pspMetricAeras[j].pspMetricCounterData.endLine == 0 && i != j && this.pspMetricAeras[j].onCounting > 0)
									{
										this.pspMetricAeras[j].onCounting++;
									}
								}
							}
							this.pspMetricAeras[i].pspMetricCounterData.PspExistType += 2;
							this.pspMetricAeras[i].pspMetricCounterData.totalLineNew = this.linesOfCode.TotalCount;
							break;
						}
					}
					for (int i = 0; i < this.pspMetricAeras.Length; i++)
					{
						if (this.pspMetricAeras[i].toCount && this.pspMetricAeras[i].isAPspMetricEndFlag(text))
						{
							if (this.pspMetricAeras[i].pspMetricCounterData.PspExistType != 3)
							{
								this.pspMetricAeras[i].pspMetricCounterData.PspExistType = 6;
							}
							break;
						}
					}
				}
				int num5 = -1;
				if (fileChangeType == FileChangeType.NoChange)
				{
					this.isDiffCodeLine = true;
					if (this.diffInMultiLineArea)
					{
						this.isDiffCodeLine = this.codeAreas[this.diffMultiLineArea].CountsAsCode;
						if (this.codeAreas[this.diffMultiLineArea].MatchesEnd(sLine))
						{
							this.diffInMultiLineArea = false;
						}
					}
					else
					{
						for (int i = 0; i < this.codeAreas.Length; i++)
						{
							if (this.codeAreas[i].MultiLine)
							{
								if (this.codeAreas[i].MatchesStart(sLine))
								{
									this.diffInMultiLineArea = true;
									this.diffMultiLineArea = i;
									this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
									if (this.codeAreas[i].MatchesEnd(sLine))
									{
										this.diffInMultiLineArea = false;
									}
									break;
								}
							}
							else if (this.codeAreas[i].Matches(sLine))
							{
								this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
								break;
							}
						}
					}
				}
				if (arrayList.Count > 0)
				{
					int num6 = 0;
					if (fileChangeType == FileChangeType.Added)
					{
						this.isDiffCodeLine = true;
						if (this.diffInMultiLineArea)
						{
							this.isDiffCodeLine = this.codeAreas[this.diffMultiLineArea].CountsAsCode;
							if (this.codeAreas[this.diffMultiLineArea].MatchesEnd(sLine))
							{
								this.diffInMultiLineArea = false;
							}
						}
						else
						{
							for (int i = 0; i < this.codeAreas.Length; i++)
							{
								if (this.codeAreas[i].MultiLine)
								{
									if (this.codeAreas[i].MatchesStart(sLine))
									{
										this.diffInMultiLineArea = true;
										this.diffMultiLineArea = i;
										this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
										if (this.codeAreas[i].MatchesEnd(sLine))
										{
											this.diffInMultiLineArea = false;
										}
										break;
									}
								}
								else if (this.codeAreas[i].Matches(sLine))
								{
									this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
									break;
								}
							}
						}
						if (this.isDiffCodeLine && !this.isCodeLine)
						{
							this.addedLines.IncrementCounter();
						}
						else if (!this.isDiffCodeLine && this.isCodeLine)
						{
							this.deleteLines.IncrementCounter();
						}
					}
					foreach (object obj2 in arrayList)
					{
						string text = (string)obj2;
						this.isDiffCodeLine = true;
						int i;
						if (!this.diffInMultiLineArea && this.inMultiLineArea)
						{
							for (i = 0; i < this.codeAreas.Length; i++)
							{
								if (this.codeAreas[i].MultiLine)
								{
									if (this.codeAreas[i].MatchesStart(text))
									{
										this.diffInMultiLineArea = true;
										this.diffMultiLineArea = i;
										this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
										if (this.codeAreas[i].MatchesEnd(text))
										{
											this.diffInMultiLineArea = false;
										}
										break;
									}
								}
								else if (this.codeAreas[i].Matches(text))
								{
									this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
									break;
								}
							}
						}
						else if (this.diffInMultiLineArea || this.inMultiLineArea)
						{
							this.isDiffCodeLine = this.codeAreas[this.inMultiLineArea ? this.multiLineArea : this.diffMultiLineArea].CountsAsCode;
							if (this.codeAreas[this.inMultiLineArea ? this.multiLineArea : this.diffMultiLineArea].MatchesEnd(text.Trim()))
							{
								this.diffInMultiLineArea = false;
							}
						}
						else
						{
							for (i = 0; i < this.codeAreas.Length; i++)
							{
								if (this.codeAreas[i].MultiLine)
								{
									if (this.codeAreas[i].MatchesStart(text))
									{
										this.diffInMultiLineArea = true;
										this.diffMultiLineArea = i;
										this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
										if (this.codeAreas[i].MatchesEnd(text))
										{
											this.diffInMultiLineArea = false;
										}
										break;
									}
								}
								else if (this.codeAreas[i].Matches(text))
								{
									this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
									break;
								}
							}
						}
						if (fileChangeType == FileChangeType.Modified)
						{
							if (this.isDiffCodeLine && flag)
							{
								if (this.isCodeLine)
								{
									this.modifiedLines.IncrementCounter();
								}
								else
								{
									this.addedLines.IncrementCounter();
								}
								flag = false;
							}
							else if (this.isDiffCodeLine && !flag)
							{
								this.addedLines.IncrementCounter();
							}
						}
						else if (fileChangeType == FileChangeType.Added)
						{
							if (this.isDiffCodeLine)
							{
								this.addedLines.IncrementCounter();
							}
						}
						else if (fileChangeType == FileChangeType.Deleted)
						{
							if (this.isDiffCodeLine)
							{
								this.deleteLines.IncrementCounter();
							}
						}
						if (this.isDiffCodeLine)
						{
							num6++;
						}
						num5++;
						i = 0;
						while (i < this.pspMetricAeras.Length)
						{
							int endLine = this.pspMetricAeras[i].pspMetricCounterData.endLine;
							int onCounting = this.pspMetricAeras[i].onCounting;
							if (this.pspMetricAeras[i].toCount && this.pspMetricAeras[i].isAPspMetricStartFlag(text))
							{
								this.pspMetricAeras[i].isAPspMetricStartFlag(text, 1);
								if (onCounting < this.pspMetricAeras[i].onCounting)
								{
									for (int j = 0; j < this.pspMetricAeras.Length; j++)
									{
										if (this.pspMetricAeras[j].pspMetricCounterData.startLine >= 0 && this.pspMetricAeras[j].pspMetricCounterData.endLine == 0 && i != j && this.pspMetricAeras[j].onCounting > 0)
										{
											this.pspMetricAeras[j].onCounting++;
										}
									}
									this.pspMetricAeras[i].pspMetricCounterData.startLineNew = this.linesOfCode.TotalCount;
									this.pspMetricAeras[i].pspMetricCounterData.totalLineNew = this.linesOfCode.TotalCount;
									this.pspMetricAeras[i].pspMetricCounterData.totalLine = this.linesOfCode.TotalCount;
									if (this.IsCountOnDiff && this.pspMetricAeras[i].pspMetricCounterData.addedLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.deleteLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.modifyLine == 0)
									{
										this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.addedLines.CurrentValue;
										this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue;
										this.pspMetricAeras[i].pspMetricCounterData.modifyLine = this.modifiedLines.CurrentValue;
									}
								}
								else
								{
									this.pspMetricAeras[i].pspMetricCounterData.startLineNew = this.linesOfCode.TotalCount;
									this.pspMetricAeras[i].pspMetricCounterData.totalLineNew = this.linesOfCode.TotalCount;
									this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.addedLines.CurrentValue;
									this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue;
									this.pspMetricAeras[i].pspMetricCounterData.modifyLine = this.modifiedLines.CurrentValue;
									this.pspMetricAeras[i].pspMetricCounterData.startPositionFlat = 2;
								}
								this.pspMetricAeras[i].pspMetricCounterData.PspExistType--;
								if (endLine != 0)
								{
									this.pspMetricAeras[i].pspMetricCounterData.startLine = this.linesOfCode.TotalCount;
									if (this.pspMetricAeras[i].pspMetricCounterData.addedLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.deleteLine == 0 && this.pspMetricAeras[i].pspMetricCounterData.modifyLine == 0)
									{
										this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.addedLines.CurrentValue;
										if (num5 < num3)
										{
											this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue + num3 - num5;
										}
										else
										{
											this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue;
										}
										this.pspMetricAeras[i].pspMetricCounterData.modifyLine = this.modifiedLines.CurrentValue;
									}
								}
								break;
							}
							if (this.pspMetricAeras[i].toCount && this.pspMetricAeras[i].isAPspMetricEndFlag(text) && this.pspMetricAeras[i].pspMetricCounterData.endLine >= 0)
							{
								this.pspMetricAeras[i].pspMetricCounterData.totalLineNew = this.linesOfCode.TotalCount - this.pspMetricAeras[i].pspMetricCounterData.totalLineNew;
								if (this.pspMetricAeras[i].pspMetricCounterData.meetEnd)
								{
									this.pspMetricAeras[i].pspMetricCounterData.addedLine += this.linesOfCode.TotalCount - this.pspMetricAeras[i].pspMetricCounterData.endLine;
									break;
								}
								this.pspMetricAeras[i].pspMetricCounterData.endLine = this.linesOfCode.TotalCount;
								this.pspMetricAeras[i].pspMetricCounterData.totalLine = this.linesOfCode.TotalCount - this.pspMetricAeras[i].pspMetricCounterData.totalLine;
								this.pspMetricAeras[i].pspMetricCounterData.addedLine = this.addedLines.CurrentValue - this.pspMetricAeras[i].pspMetricCounterData.addedLine;
								this.pspMetricAeras[i].pspMetricCounterData.deleteLine = this.deleteLines.CurrentValue - this.pspMetricAeras[i].pspMetricCounterData.deleteLine;
								this.pspMetricAeras[i].pspMetricCounterData.modifyLine = this.modifiedLines.CurrentValue - this.pspMetricAeras[i].pspMetricCounterData.modifyLine;
								int index = ((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Count - 1;
								if (((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Count > 0 && this.pspMetricAeras[i].pspMetricCounterData.PspExistType == 0 && ((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].PspExistType == 5)
								{
									((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].baseLine += this.pspMetricAeras[i].pspMetricCounterData.totalLine;
									((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].deleteLine += this.pspMetricAeras[i].pspMetricCounterData.totalLine;
								}
								if (((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Count > 0 && this.pspMetricAeras[i].pspMetricCounterData.PspExistType == 3 && ((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].PspExistType == 6)
								{
									((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet[index].addedLine += this.pspMetricAeras[i].pspMetricCounterData.totalLine + this.pspMetricAeras[i].pspMetricCounterData.addedLine - this.pspMetricAeras[i].pspMetricCounterData.deleteLine;
								}
								this.ProcesspspMetricCounterData(ref this.pspMetricAeras[i].pspMetricCounterData);
								this.pspMetricAeras[i].pspMetricCounterData.PspMetricTypeName = this.pspMetricAeras[i].name;
								this.pspMetricAeras[i].pspMetricCounterData.PspExistType = 5;
								for (int j = 0; j < this.pspMetricAeras.Length; j++)
								{
									if (this.pspMetricAeras[j].pspMetricCounterData.startLine > 0 && this.pspMetricAeras[j].pspMetricCounterData.endLine == 0 && i != j && this.pspMetricAeras[j].onCounting == this.pspMetricAeras[i].onCounting + 1)
									{
										this.pspMetricAeras[j].pspMetricCounterData.itemCount++;
										this.pspMetricAeras[i].pspMetricCounterData.parentString = this.pspMetricAeras[j].pspMetricCounterData.Name;
										break;
									}
								}
								this.pspMetricAeras[i].pspMetricCounterData.meetEnd = true;
								((PspMetricFileData)this.PspMetricFileHash[this.CurrentFile]).pspMetricCounterDataSet.Add(this.pspMetricAeras[i].pspMetricCounterData);
								for (int j = 0; j < this.pspMetricAeras.Length; j++)
								{
									if (this.pspMetricAeras[j].onCounting > 0)
									{
										this.pspMetricAeras[j].onCounting--;
									}
								}
								break;
							}
							else
							{
								i++;
							}
						}
					}
					if (num > 0)
					{
						if (fileChangeType == FileChangeType.Modified)
						{
							bool flag3 = this.inMultiLineArea;
							int num7 = this.multiLineArea;
							this.inMultiLineArea = flag2;
							this.multiLineArea = num2;
							int num8 = this.ProcessBaseModifiedLinesCount(arrayList2);
							this.inMultiLineArea = flag3;
							this.multiLineArea = num7;
							if (num8 - num6 > 0)
							{
								this.deleteLines.IncrementCounter(num8 - num6);
								num = 0;
							}
							if (num8 > 0)
							{
								int num9 = this.isCodeLine ? (num8 - 1) : num8;
								if (num8 > num6)
								{
									num9 = (this.isCodeLine ? (num6 - 1) : num6);
								}
								if (num9 > 0)
								{
									this.addedLines.IncrementCounter(-num9);
									this.modifiedLines.IncrementCounter(num9);
								}
							}
						}
					}
				}
				else if (arrayList.Count <= 0 && arrayList2.Count > 0)
				{
					bool flag3 = this.inMultiLineArea;
					int num7 = this.multiLineArea;
					this.inMultiLineArea = flag2;
					this.multiLineArea = num2;
					int num8 = this.ProcessBaseModifiedLinesCount(arrayList2);
					this.inMultiLineArea = flag3;
					this.multiLineArea = num7;
					this.deleteLines.IncrementCounter(num8);
				}
				else if (this.diffInMultiLineArea && this.isCodeLine)
				{
					this.deleteLines.IncrementCounter();
				}
				else if (!this.diffInMultiLineArea && this.inMultiLineArea)
				{
					this.isDiffCodeLine = true;
					for (int i = 0; i < this.codeAreas.Length; i++)
					{
						if (this.codeAreas[i].MultiLine)
						{
							if (this.codeAreas[i].MatchesStart(sLine))
							{
								this.diffInMultiLineArea = true;
								this.diffMultiLineArea = i;
								this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
								if (this.codeAreas[i].MatchesEnd(sLine))
								{
									this.diffInMultiLineArea = false;
								}
								break;
							}
						}
						else if (this.codeAreas[i].Matches(sLine))
						{
							this.isDiffCodeLine = this.codeAreas[i].CountsAsCode;
							break;
						}
					}
					if (this.isDiffCodeLine)
					{
						this.addedLines.IncrementCounter();
					}
				}
				else if (this.isCodeLine && !this.isDiffCodeLine)
				{
					this.deleteLines.IncrementCounter();
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000069FC File Offset: 0x000059FC
		private int ProcessBaseModifiedLinesCount(ArrayList lines)
		{
			int num = 0;
			bool flag = this.inMultiLineArea;
			int num2 = this.multiLineArea;
			foreach (object obj in lines)
			{
				string text = (string)obj;
				bool flag2 = true;
				if (flag)
				{
					flag2 = this.codeAreas[num2].CountsAsCode;
					if (this.codeAreas[num2].MatchesEnd(text.Trim()))
					{
						flag = false;
					}
				}
				else
				{
					for (int i = 0; i < this.codeAreas.Length; i++)
					{
						if (this.codeAreas[i].MultiLine)
						{
							if (this.codeAreas[i].MatchesStart(text))
							{
								flag = true;
								num2 = i;
								flag2 = this.codeAreas[i].CountsAsCode;
								if (this.codeAreas[i].MatchesEnd(text))
								{
									flag = false;
								}
								break;
							}
						}
						else if (this.codeAreas[i].Matches(text))
						{
							flag2 = this.codeAreas[i].CountsAsCode;
							break;
						}
					}
				}
				if (flag2)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006B9C File Offset: 0x00005B9C
		public CounterData[] GetCounterData()
		{
			CounterData[] array = new CounterData[this.counterData.Length + 5];
			array[0] = this.totalLines;
			array[1] = this.linesOfCode;
			array[2] = this.addedLines;
			array[3] = this.deleteLines;
			array[4] = this.modifiedLines;
			Array.Copy(this.counterData, 0, array, 5, this.counterData.Length);
			return array;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00006C04 File Offset: 0x00005C04
		public CounterData PhysicalLines
		{
			get
			{
				return this.totalLines;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00006C1C File Offset: 0x00005C1C
		public CounterData LogicalLines
		{
			get
			{
				return this.linesOfCode;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00006C34 File Offset: 0x00005C34
		public CounterData AddedLines
		{
			get
			{
				return this.addedLines;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00006C4C File Offset: 0x00005C4C
		public CounterData DeletedLines
		{
			get
			{
				return this.deleteLines;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00006C64 File Offset: 0x00005C64
		public CounterData ModifiedLines
		{
			get
			{
				return this.modifiedLines;
			}
		}

		// Token: 0x0400004B RID: 75
		private Regex extensionExpression;

		// Token: 0x0400004C RID: 76
		private Hashtable files = new Hashtable();

		// Token: 0x0400004D RID: 77
		public Hashtable PspMetricFileHash = new Hashtable();

		// Token: 0x0400004E RID: 78
		private string currentFile = string.Empty;

		// Token: 0x0400004F RID: 79
		public CodeArea[] codeAreas = new CodeArea[0];

		// Token: 0x04000050 RID: 80
		public CounterData[] counterData = new CounterData[0];

		// Token: 0x04000051 RID: 81
		public PspMetricAera[] pspMetricAeras = new PspMetricAera[0];

		// Token: 0x04000052 RID: 82
		private string name = "All lines";

		// Token: 0x04000053 RID: 83
		private ArrayList fileExtensions = new ArrayList();

		// Token: 0x04000054 RID: 84
		private ArrayList diffLines = new ArrayList();

		// Token: 0x04000055 RID: 85
		private DiffHandler objDiffHandler = new DiffHandler();

		// Token: 0x04000056 RID: 86
		private CounterData totalLines;

		// Token: 0x04000057 RID: 87
		private CounterData linesOfCode;

		// Token: 0x04000058 RID: 88
		private CounterData addedLines;

		// Token: 0x04000059 RID: 89
		private CounterData modifiedLines;

		// Token: 0x0400005A RID: 90
		private CounterData deleteLines;

		// Token: 0x0400005B RID: 91
		private bool diffInMultiLineArea = false;

		// Token: 0x0400005C RID: 92
		private int diffMultiLineArea = -1;

		// Token: 0x0400005D RID: 93
		private bool isCodeLine = true;

		// Token: 0x0400005E RID: 94
		private bool isDiffCodeLine = true;

		// Token: 0x0400005F RID: 95
		private bool inMultiLineArea = false;

		// Token: 0x04000060 RID: 96
		private int multiLineArea = -1;
	}
}
