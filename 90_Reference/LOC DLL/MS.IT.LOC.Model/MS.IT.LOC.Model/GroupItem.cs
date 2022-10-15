using System;
using System.Collections;
using System.ComponentModel;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000008 RID: 8
	public class GroupItem
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002FA4 File Offset: 0x00001FA4
		public GroupItem()
		{
			this._GroupID = Guid.NewGuid().ToString();
			this._GroupName = "";
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002FE0 File Offset: 0x00001FE0
		[ReadOnly(true)]
		[Browsable(true)]
		public string GroupID
		{
			get
			{
				return this._GroupID;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002FF8 File Offset: 0x00001FF8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00003010 File Offset: 0x00002010
		[ReadOnly(true)]
		[Browsable(true)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				this._GroupName = value;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000301A File Offset: 0x0000201A
		public void LoadObject(Hashtable objList)
		{
			this._GroupID = (string)objList["GroupID"];
			this._GroupName = (string)objList["GroupName"];
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000304C File Offset: 0x0000204C
		public override string ToString()
		{
			return this._GroupName;
		}

		// Token: 0x04000040 RID: 64
		private string _GroupID;

		// Token: 0x04000041 RID: 65
		private string _GroupName;
	}
}
