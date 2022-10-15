using System;

namespace MS.IT.LOC.Model
{
	// Token: 0x0200000B RID: 11
	public class SCItem
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000034B4 File Offset: 0x000024B4
		public SCItem()
		{
			this._ID = Guid.NewGuid().ToString();
			this._SCDownloadType = DownloadType.Latest;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003508 File Offset: 0x00002508
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00003520 File Offset: 0x00002520
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				this._Path = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000352C File Offset: 0x0000252C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00003544 File Offset: 0x00002544
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003550 File Offset: 0x00002550
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00003568 File Offset: 0x00002568
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003574 File Offset: 0x00002574
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000358C File Offset: 0x0000258C
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003598 File Offset: 0x00002598
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000035B0 File Offset: 0x000025B0
		public SCItemType ScType
		{
			get
			{
				return this._ScType;
			}
			set
			{
				this._ScType = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000035BC File Offset: 0x000025BC
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000035D4 File Offset: 0x000025D4
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000035E0 File Offset: 0x000025E0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000035F8 File Offset: 0x000025F8
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003604 File Offset: 0x00002604
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000361C File Offset: 0x0000261C
		public DownloadType SCDownloadType
		{
			get
			{
				return this._SCDownloadType;
			}
			set
			{
				this._SCDownloadType = value;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003628 File Offset: 0x00002628
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Name : ",
				this._Name,
				" Path : ",
				this._Path,
				" Type : ",
				this._ScType.ToString()
			});
		}

		// Token: 0x04000047 RID: 71
		private string _Path;

		// Token: 0x04000048 RID: 72
		private SCItemType _ScType;

		// Token: 0x04000049 RID: 73
		private string _Name;

		// Token: 0x0400004A RID: 74
		private DateTime _ChurnStartDate = DateTime.MinValue;

		// Token: 0x0400004B RID: 75
		private DateTime _ChurnEndDate = DateTime.MinValue;

		// Token: 0x0400004C RID: 76
		private int _ChurnCount = 0;

		// Token: 0x0400004D RID: 77
		private string _ID;

		// Token: 0x0400004E RID: 78
		private DownloadType _SCDownloadType;
	}
}
