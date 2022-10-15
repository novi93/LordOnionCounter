using System;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000002 RID: 2
	public class LineCounterData
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020E8 File Offset: 0x000010E8
		public long AddedLine
		{
			get
			{
				return this._AddedLine;
			}
			set
			{
				this._AddedLine = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020F4 File Offset: 0x000010F4
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000210C File Offset: 0x0000110C
		public long ModifiedLine
		{
			get
			{
				return this._ModifiedLine;
			}
			set
			{
				this._ModifiedLine = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002118 File Offset: 0x00001118
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002130 File Offset: 0x00001130
		public long DeletedLine
		{
			get
			{
				return this._DeletedLine;
			}
			set
			{
				this._DeletedLine = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000213C File Offset: 0x0000113C
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002154 File Offset: 0x00001154
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00001160
		public long TotalLines
		{
			get
			{
				return this._AddedLine + this._ModifiedLine;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002180 File Offset: 0x00001180
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002198 File Offset: 0x00001198
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021A4 File Offset: 0x000011A4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000021BC File Offset: 0x000011BC
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

		// Token: 0x04000001 RID: 1
		private long _AddedLine = 0L;

		// Token: 0x04000002 RID: 2
		private long _ModifiedLine = 0L;

		// Token: 0x04000003 RID: 3
		private long _DeletedLine = 0L;

		// Token: 0x04000004 RID: 4
		private long _Base = 0L;

		// Token: 0x04000005 RID: 5
		private string _Name = "";

		// Token: 0x04000006 RID: 6
		private string _Language = "";
	}
}
