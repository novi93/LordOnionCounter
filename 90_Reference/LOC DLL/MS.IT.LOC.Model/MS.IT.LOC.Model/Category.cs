using System;
using System.Collections;
using System.ComponentModel;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000015 RID: 21
	public class Category
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000043D4 File Offset: 0x000033D4
		public Category()
		{
			this._CategoryID = Guid.NewGuid().ToString();
			this._CategoryName = "";
			this._IsNew = true;
			this._IsDirty = true;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00004434 File Offset: 0x00003434
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000444C File Offset: 0x0000344C
		[ReadOnly(true)]
		[Browsable(true)]
		public string CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				this._CategoryID = value;
				this._IsDirty = true;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004460 File Offset: 0x00003460
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00004478 File Offset: 0x00003478
		[ReadOnly(true)]
		[Browsable(true)]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				this._CategoryName = value;
				this._IsDirty = true;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000448C File Offset: 0x0000348C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000044A4 File Offset: 0x000034A4
		[Browsable(true)]
		[ReadOnly(true)]
		public GroupItem Group
		{
			get
			{
				return this._Group;
			}
			set
			{
				this._Group = value;
				this._IsDirty = true;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000044B8 File Offset: 0x000034B8
		[Browsable(false)]
		public bool IsDirty
		{
			get
			{
				return this._IsDirty;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000044D0 File Offset: 0x000034D0
		[Browsable(false)]
		public bool IsNew
		{
			get
			{
				return this._IsNew;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000044E8 File Offset: 0x000034E8
		public void LoadObject(Hashtable objList)
		{
			this._CategoryID = (string)objList["CategoryID"];
			this._CategoryName = (string)objList["CategoryName"];
			this._Group = (GroupItem)objList["Group"];
			this._IsDirty = false;
			this._IsNew = false;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00004548 File Offset: 0x00003548
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00004560 File Offset: 0x00003560
		[Browsable(false)]
		public bool Saved
		{
			get
			{
				return this._Saved;
			}
			set
			{
				this._Saved = value;
				this._IsDirty = false;
				this._IsNew = false;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004578 File Offset: 0x00003578
		public override string ToString()
		{
			return this._CategoryName;
		}

		// Token: 0x04000071 RID: 113
		private string _CategoryID;

		// Token: 0x04000072 RID: 114
		private string _CategoryName;

		// Token: 0x04000073 RID: 115
		private GroupItem _Group;

		// Token: 0x04000074 RID: 116
		private bool _IsDirty = false;

		// Token: 0x04000075 RID: 117
		private bool _IsNew = false;

		// Token: 0x04000076 RID: 118
		private bool _Saved = true;
	}
}
