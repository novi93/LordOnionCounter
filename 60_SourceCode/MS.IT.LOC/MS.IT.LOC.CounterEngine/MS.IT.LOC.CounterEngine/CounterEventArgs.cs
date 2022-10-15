using System;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x02000005 RID: 5
	public class CounterEventArgs : EventArgs
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000023A4 File Offset: 0x000013A4
		public CounterEventArgs(string name)
		{
			this.fileName = name;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000023C4 File Offset: 0x000013C4
		public string FileName
		{
			get
			{
				return this.fileName;
			}
		}

		// Token: 0x04000007 RID: 7
		private string fileName = "";
	}
}
