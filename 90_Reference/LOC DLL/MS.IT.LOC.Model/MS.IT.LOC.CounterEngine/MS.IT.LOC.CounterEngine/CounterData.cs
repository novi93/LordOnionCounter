using System;
using System.Collections;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x02000003 RID: 3
	public class CounterData
	{
		// Token: 0x06000002 RID: 2 RVA: 0x000020E9 File Offset: 0x000010E9
		internal CounterData(string name) : this(name, 0)
		{
			this.counterName = name;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020FD File Offset: 0x000010FD
		internal CounterData(string name, int initialCount)
		{
			this.counterValue = new CountInfo();
			this.counterName = name;
			this.counterValue.count = initialCount;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000213C File Offset: 0x0000113C
		public string Name
		{
			get
			{
				return this.counterName;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002154 File Offset: 0x00001154
		public int CurrentValue
		{
			get
			{
				return ((CountInfo)this.fileCounters[this.currentFile]).count;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002184 File Offset: 0x00001184
		public int TotalCount
		{
			get
			{
				int num = 0;
				foreach (object obj in this.fileCounters.Values)
				{
					CountInfo countInfo = (CountInfo)obj;
					num += countInfo.count;
				}
				return num;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002200 File Offset: 0x00001200
		public int GetCountForFile(string filename)
		{
			return (int)this.fileCounters[this.currentFile];
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002228 File Offset: 0x00001228
		public string[] GetFilenames()
		{
			ICollection keys = this.fileCounters.Keys;
			string[] array = new string[keys.Count];
			keys.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000225C File Offset: 0x0000125C
		public Hashtable GetFileCounts()
		{
			return this.fileCounters.Clone() as Hashtable;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002280 File Offset: 0x00001280
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002298 File Offset: 0x00001298
		internal string CurrentFile
		{
			get
			{
				return this.currentFile;
			}
			set
			{
				this.currentFile = value;
				if (!this.fileCounters.ContainsKey(this.currentFile))
				{
					this.fileCounters[this.currentFile] = new CountInfo();
					((CountInfo)this.fileCounters[this.currentFile]).count = this.counterValue.count;
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002304 File Offset: 0x00001304
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002331 File Offset: 0x00001331
		internal bool CurrentDiffFile
		{
			get
			{
				return ((CountInfo)this.fileCounters[this.currentFile]).IsCountOnDiff;
			}
			set
			{
				((CountInfo)this.fileCounters[this.currentFile]).IsCountOnDiff = value;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002350 File Offset: 0x00001350
		internal void IncrementCounter()
		{
			((CountInfo)this.fileCounters[this.currentFile]).count++;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002376 File Offset: 0x00001376
		internal void IncrementCounter(int amount)
		{
			((CountInfo)this.fileCounters[this.currentFile]).count += amount;
		}

		// Token: 0x04000003 RID: 3
		private string counterName;

		// Token: 0x04000004 RID: 4
		private CountInfo counterValue;

		// Token: 0x04000005 RID: 5
		private Hashtable fileCounters = new Hashtable();

		// Token: 0x04000006 RID: 6
		private string currentFile = string.Empty;
	}
}
