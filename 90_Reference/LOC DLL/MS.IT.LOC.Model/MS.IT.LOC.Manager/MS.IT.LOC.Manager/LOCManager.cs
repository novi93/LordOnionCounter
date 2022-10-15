using System;
using MS.IT.LOC.CounterEngine;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.Manager
{
	// Token: 0x02000002 RID: 2
	public class LOCManager
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		// (remove) Token: 0x06000002 RID: 2 RVA: 0x000020E9 File Offset: 0x000010E9
		public event SourceControlEventHandler OnDownload;

		// Token: 0x06000003 RID: 3 RVA: 0x00002102 File Offset: 0x00001102
		private void SourceControlGenEventHandler(object source, SourceControlEventArgs args)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002105 File Offset: 0x00001105
		public LOCManager()
		{
			this.OnDownload = new SourceControlEventHandler(this.SourceControlGenEventHandler);
			this.m_SourceControlManager.OnDownload += this.m_SourceControlManager_OnDownload;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002148 File Offset: 0x00001148
		public void LoadCounterData(ref CounterItemSet counterItemSet)
		{
			foreach (object obj in counterItemSet)
			{
				CounterItem counterItem = (CounterItem)obj;
				CodeCounter codeCounter = new CodeCounter();
				codeCounter.RootDirectory = LOCConstants.TempPath + "\\" + counterItem.Name;
				codeCounter.ProcessSourceTree();
				LineCounterDataSet lineCounterDataSet = new LineCounterDataSet();
				LineCounter[] lineCounters = codeCounter.LineCounters;
				foreach (LineCounter lineCounter in lineCounters)
				{
					lineCounterDataSet.Add(new LineCounterData
					{
						AddedLine = (long)lineCounter.LogicalLines.TotalCount,
						Name = lineCounter.Name
					});
				}
				counterItem.CounterDataSet = lineCounterDataSet;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000224C File Offset: 0x0000124C
		private void m_SourceControlManager_OnDownload(object o, SourceControlEventArgs a)
		{
			this.OnDownload(o, a);
		}

		// Token: 0x04000002 RID: 2
		private SourceControlManager m_SourceControlManager = new SourceControlManager();
	}
}
