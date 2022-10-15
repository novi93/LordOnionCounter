using System;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x02000002 RID: 2
	public class CountInfo
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		public CountInfo()
		{
			this.count = 0;
			this.IsCountOnDiff = false;
		}

		// Token: 0x04000001 RID: 1
		public int count;

		// Token: 0x04000002 RID: 2
		public bool IsCountOnDiff;
	}
}
