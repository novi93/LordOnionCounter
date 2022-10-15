using System;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000019 RID: 25
	public class ServerAccount
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00004930 File Offset: 0x00003930
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00004926 File Offset: 0x00003926
		public string ServerName
		{
			get
			{
				return this._ServerName;
			}
			set
			{
				this._ServerName = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00004954 File Offset: 0x00003954
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00004948 File Offset: 0x00003948
		public string ServerPort
		{
			get
			{
				return this._ServerPort;
			}
			set
			{
				this._ServerPort = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00004978 File Offset: 0x00003978
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000496C File Offset: 0x0000396C
		public SourceServerType ServerType
		{
			get
			{
				return this._ServerType;
			}
			set
			{
				this._ServerType = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000499C File Offset: 0x0000399C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00004990 File Offset: 0x00003990
		public string UserAccount
		{
			get
			{
				return this._UserAccount;
			}
			set
			{
				this._UserAccount = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000049C0 File Offset: 0x000039C0
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000049B4 File Offset: 0x000039B4
		public string UserPassword
		{
			get
			{
				return this._UserPasswd;
			}
			set
			{
				this._UserPasswd = value;
			}
		}

		// Token: 0x0400007E RID: 126
		private string _ServerName = string.Empty;

		// Token: 0x0400007F RID: 127
		private string _ServerPort = string.Empty;

		// Token: 0x04000080 RID: 128
		private SourceServerType _ServerType = SourceServerType.Base;

		// Token: 0x04000081 RID: 129
		private string _UserAccount = string.Empty;

		// Token: 0x04000082 RID: 130
		private string _UserPasswd = string.Empty;
	}
}
