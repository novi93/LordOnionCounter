using System;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000006 RID: 6
	internal class testapp
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000030BC File Offset: 0x000020BC
		public int test()
		{
			return testapp.i + 20;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000030D8 File Offset: 0x000020D8
		public static int test1()
		{
			return testapp.i + 10;
		}

		// Token: 0x0400001A RID: 26
		private static int i = 10;

		// Token: 0x0400001B RID: 27
		private int j = 20;
	}
}
