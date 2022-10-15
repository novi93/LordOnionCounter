using System;

namespace MS.IT.LOC.SourceControl
{
	// Token: 0x02000006 RID: 6
	public class MRepotItem
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000664C File Offset: 0x0000564C
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00006664 File Offset: 0x00005664
		public DateTime ChurnStartDate
		{
			get
			{
				return this._ChurnStartDate;
			}
			set
			{
				this._ChurnStartDate = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00006670 File Offset: 0x00005670
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00006688 File Offset: 0x00005688
		public DateTime ChurnEndDate
		{
			get
			{
				return this._ChurnEndDate;
			}
			set
			{
				this._ChurnEndDate = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00006694 File Offset: 0x00005694
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000066AC File Offset: 0x000056AC
		public int ChurnCount
		{
			get
			{
				return this._ChurnCount;
			}
			set
			{
				this._ChurnCount = value;
			}
		}

		// Token: 0x0400000E RID: 14
		private DateTime _ChurnStartDate = DateTime.MinValue;

		// Token: 0x0400000F RID: 15
		private DateTime _ChurnEndDate = DateTime.MinValue;

		// Token: 0x04000010 RID: 16
		private int _ChurnCount = 0;
	}
}
