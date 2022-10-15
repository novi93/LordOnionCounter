using System;

namespace MS.IT.LOC.Model
{
	// Token: 0x0200000C RID: 12
	public class BasedToLabelAndChangeset
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003690 File Offset: 0x00002690
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000036A8 File Offset: 0x000026A8
		public string BaseVersion
		{
			get
			{
				return this._BaseVersion;
			}
			set
			{
				this._BaseVersion = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000036B4 File Offset: 0x000026B4
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000036CC File Offset: 0x000026CC
		public string DiffVersion
		{
			get
			{
				return this._DiffVersion;
			}
			set
			{
				this._DiffVersion = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000036D8 File Offset: 0x000026D8
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000036F0 File Offset: 0x000026F0
		public CIType currentCIType
		{
			get
			{
				return this._currentCIType;
			}
			set
			{
				this._currentCIType = value;
			}
		}

		// Token: 0x0400004F RID: 79
		private string _BaseVersion;

		// Token: 0x04000050 RID: 80
		private string _DiffVersion;

		// Token: 0x04000051 RID: 81
		private CIType _currentCIType;
	}
}
