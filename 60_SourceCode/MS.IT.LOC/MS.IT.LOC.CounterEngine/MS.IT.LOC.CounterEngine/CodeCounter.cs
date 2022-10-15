using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x02000007 RID: 7
	public class CodeCounter
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000017 RID: 23 RVA: 0x000023DC File Offset: 0x000013DC
		// (remove) Token: 0x06000018 RID: 24 RVA: 0x000023F5 File Offset: 0x000013F5
		public event CounterEventHandler OnCounting;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000019 RID: 25 RVA: 0x0000240E File Offset: 0x0000140E
		// (remove) Token: 0x0600001A RID: 26 RVA: 0x00002427 File Offset: 0x00001427
		public event CounterEventHandler OnCounted;

		// Token: 0x0600001B RID: 27 RVA: 0x00002440 File Offset: 0x00001440
		public CodeCounter() : this(AppDomain.CurrentDomain.BaseDirectory + "LineCounters.xml")
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002460 File Offset: 0x00001460
		public CodeCounter(string countingStandardsFilePath)
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(countingStandardsFilePath);
				this.LoadLineCounters(xmlDocument.SelectNodes("/lineCounters/lineCounter"));
				this.OnCounted = new CounterEventHandler(this.codeCounter_OnCounted);
				this.OnCounting = new CounterEventHandler(this.codeCounter_OnCounted);
			}
			catch
			{
				throw new LOCCountStandardErrorFormat();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002500 File Offset: 0x00001500
		private void codeCounter_OnCounted(object sender, CounterEventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002503 File Offset: 0x00001503
		private void codeCounter_OnCounting(object sender, CounterEventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002508 File Offset: 0x00001508
		private void LoadLineCounters(XmlNodeList counterNodes)
		{
			this.lineCounters = new LineCounter[counterNodes.Count];
			int num = 0;
			foreach (object obj in counterNodes)
			{
				XmlNode node = (XmlNode)obj;
				this.lineCounters[num++] = new LineCounter(node);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000258C File Offset: 0x0000158C
		public string[] Errors
		{
			get
			{
				return (string[])this.errors.ToArray(typeof(string));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000025B8 File Offset: 0x000015B8
		public bool HasErrors
		{
			get
			{
				return this.errors.Count > 0;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000025D8 File Offset: 0x000015D8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000025F0 File Offset: 0x000015F0
		public string RootDirectory
		{
			get
			{
				return this.rootDirectory;
			}
			set
			{
				this.rootDirectory = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000025FC File Offset: 0x000015FC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002614 File Offset: 0x00001614
		public bool CountSubdirectories
		{
			get
			{
				return this.recursiveCount;
			}
			set
			{
				this.recursiveCount = true;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002620 File Offset: 0x00001620
		public LineCounter[] LineCounters
		{
			get
			{
				return this.lineCounters;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002638 File Offset: 0x00001638
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002650 File Offset: 0x00001650
		public string DiffRootDirectory
		{
			get
			{
				return this.diffRootDirectory;
			}
			set
			{
				this.diffRootDirectory = value;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000265C File Offset: 0x0000165C
		public CounterData[] GetCounterData()
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(new CounterData("Total files", this.fileCount));
			arrayList.Add(new CounterData("Total directories", this.directoryCount));
			foreach (LineCounter lineCounter in this.lineCounters)
			{
				arrayList.AddRange(lineCounter.GetCounterData());
			}
			return (CounterData[])arrayList.ToArray(typeof(CounterData));
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026EB File Offset: 0x000016EB
		public void ProcessSourceTree()
		{
			this.ProcessSourceDirectory(this.rootDirectory, this.recursiveCount);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002704 File Offset: 0x00001704
		private void ProcessSourceFile(string filename)
		{
			this.fileCount++;
			try
			{
				Queue queue = new Queue();
				bool[] array = new bool[this.lineCounters.Length];
				foreach (LineCounter lineCounter in this.lineCounters)
				{
					// TODO  NOVI : i dont know why delcare this. so, i  CommentOut it  :))
					//LineCounter lineCounter;
					if (lineCounter.CanCountFile(filename))
					{
						lineCounter.CurrentFile = filename;
						if (File.Exists(this.diffRootDirectory + filename.Substring(filename.LastIndexOf("\\")) + ".diff"))
						{
							lineCounter.DiffFileName = this.diffRootDirectory + filename.Substring(filename.LastIndexOf("\\")) + ".diff";
						}
						else
						{
							lineCounter.DiffFileName = "";
						}
						queue.Enqueue(lineCounter);
					}
				}
				if (queue.Count > 0)
				{
					using (StreamReader streamReader = File.OpenText(filename))
					{
						for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
						{
							foreach (object obj in queue)
							{
								LineCounter lineCounter = (LineCounter)obj;
								if (!lineCounter.PspMetricFileHash.ContainsKey(lineCounter.CurrentFile))
								{
									PspMetricFileData value = new PspMetricFileData(lineCounter.CurrentFile);
									lineCounter.PspMetricFileHash.Add(lineCounter.CurrentFile, value);
									for (int j = 0; j < lineCounter.pspMetricAeras.Length; j++)
									{
										lineCounter.pspMetricAeras[j].onCounting = 0;
										lineCounter.pspMetricAeras[j].pspMetricCounterData = new PspMetricCounterData(-1);
									}
								}
								lineCounter.ProcessLine(text);
							}
						}
					}
				}
			}
			catch (IOException ex)
			{
				string value2 = string.Format("Failed to process {0}, {1}", filename, ex.Message);
				this.errors.Add(value2);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002998 File Offset: 0x00001998
		private void ProcessSourceDirectory(string dir, bool recurseSubDirectories)
		{
			Debug.Assert(Directory.Exists(dir), "invalid source code directory");
			if (!Directory.Exists(dir))
			{
				throw new DirectoryNotFoundException(dir);
			}
			this.directoryCount++;
			string[] files = Directory.GetFiles(dir);
			foreach (string text in files)
			{
				this.OnCounting(this, new CounterEventArgs(text));
				this.ProcessSourceFile(text);
				this.OnCounted(this, new CounterEventArgs(text));
			}
			if (recurseSubDirectories)
			{
				string[] directories = Directory.GetDirectories(dir);
				foreach (string dir2 in directories)
				{
					this.ProcessSourceDirectory(dir2, recurseSubDirectories);
				}
			}
		}

		// Token: 0x0400000A RID: 10
		private ArrayList errors = new ArrayList();

		// Token: 0x0400000B RID: 11
		private string rootDirectory;

		// Token: 0x0400000C RID: 12
		private bool recursiveCount = true;

		// Token: 0x0400000D RID: 13
		private LineCounter[] lineCounters = null;

		// Token: 0x0400000E RID: 14
		private int fileCount = 0;

		// Token: 0x0400000F RID: 15
		private int directoryCount = 0;

		// Token: 0x04000010 RID: 16
		private string diffRootDirectory;
	}
}
