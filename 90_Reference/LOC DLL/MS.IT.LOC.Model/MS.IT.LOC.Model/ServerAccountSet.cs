using System;
using System.Collections;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000016 RID: 22
	public class ServerAccountSet : CollectionBase
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000459C File Offset: 0x0000359C
		public void Add(string serverName, string serverPort, SourceServerType serverType, string userAccount, string userPassword)
		{
			ServerAccount serverAccount = null;
			foreach (object obj in base.InnerList)
			{
				ServerAccount serverAccount2 = (ServerAccount)obj;
				if (serverType == serverAccount2.ServerType && serverName == serverAccount2.ServerName && serverPort == serverAccount2.ServerPort)
				{
					serverAccount = serverAccount2;
					break;
				}
			}
			if (serverAccount == null)
			{
				serverAccount = new ServerAccount();
				base.InnerList.Add(serverAccount);
			}
			serverAccount.ServerName = serverName;
			serverAccount.ServerPort = serverPort;
			serverAccount.ServerType = serverType;
			serverAccount.UserAccount = userAccount;
			serverAccount.UserPassword = userPassword;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000467C File Offset: 0x0000367C
		public ServerAccount Get(string serverName, string serverPort, SourceServerType serverType)
		{
			ServerAccount result = null;
			foreach (object obj in base.InnerList)
			{
				ServerAccount serverAccount = (ServerAccount)obj;
				if (serverType == serverAccount.ServerType && serverName == serverAccount.ServerName && serverPort == serverAccount.ServerPort)
				{
					result = serverAccount;
					break;
				}
			}
			return result;
		}
	}
}
