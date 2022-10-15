using System;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000018 RID: 24
	public class CounterCountDetail
	{
		// Token: 0x060000DF RID: 223 RVA: 0x000047FC File Offset: 0x000037FC
		public CounterCountDetail()
		{
			this._CounterItemID = "";
			this._Language = "";
			this._Added = 0L;
			this._Modified = 0L;
			this._New = 0L;
			this._Deleted = 0L;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004850 File Offset: 0x00003850
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00004868 File Offset: 0x00003868
		public string CounterItemID
		{
			get
			{
				return this._CounterItemID;
			}
			set
			{
				this._CounterItemID = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00004874 File Offset: 0x00003874
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000488C File Offset: 0x0000388C
		public string Language
		{
			get
			{
				return this._Language;
			}
			set
			{
				this._Language = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004898 File Offset: 0x00003898
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000048B0 File Offset: 0x000038B0
		public long Added
		{
			get
			{
				return this._Added;
			}
			set
			{
				this._Added = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000048BC File Offset: 0x000038BC
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000048D4 File Offset: 0x000038D4
		public long Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				this._Modified = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000048E0 File Offset: 0x000038E0
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000048F8 File Offset: 0x000038F8
		public long Base
		{
			get
			{
				return this._Base;
			}
			set
			{
				this._Base = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00004904 File Offset: 0x00003904
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000491C File Offset: 0x0000391C
		public long Deleted
		{
			get
			{
				return this._Deleted;
			}
			set
			{
				this._Deleted = value;
			}
		}

		// Token: 0x04000077 RID: 119
		private string _CounterItemID;

		// Token: 0x04000078 RID: 120
		private string _Language;

		// Token: 0x04000079 RID: 121
		private long _Added;

		// Token: 0x0400007A RID: 122
		private long _Modified;

		// Token: 0x0400007B RID: 123
		private long _New;

		// Token: 0x0400007C RID: 124
		private long _Deleted;

		// Token: 0x0400007D RID: 125
		private long _Base = 0L;
	}
}
