using System;
using System.Collections;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.SourceControl
{
	// Token: 0x02000002 RID: 2
	public interface ISourceControlProvider
	{
		// Token: 0x06000001 RID: 1
		bool Login(string serverName, string serverPort, string loginId, string password);

		// Token: 0x06000002 RID: 2
		SCItemSet GetChildItem(SCItem parent, bool recursive);

		// Token: 0x06000003 RID: 3
		bool Download(string serverPath, string localFile);

		// Token: 0x06000004 RID: 4
		bool DownloadDiff(string serverPath, string localFile, object startVersionSpec, object endVersionSpec);

		// Token: 0x06000005 RID: 5
		bool Download(string serverPath, string localFile, object versionSpec);

		// Token: 0x06000006 RID: 6
		object GetVersionSpec(DateTime date, bool latest);

		// Token: 0x06000007 RID: 7
		ArrayList GetFirstAndLastVersionSpec(string serverPath, DateTime startDate, DateTime endDate);

		// Token: 0x06000008 RID: 8
		ArrayList GetFirstAndLastVersionSpec(string serverPath, string baseSet, string lastSet);

		// Token: 0x06000009 RID: 9
		ArrayList GetFirstAndLastVersionSpec(string serverPath, int setType, string versionSet);

		// Token: 0x0600000A RID: 10
		SCItemSet GetChildItemInSet(SCItem parent, bool recursive, int setType, string[] versions);

		// Token: 0x0600000B RID: 11
		MRepotItem GetItemChurnCount(string serverPath, string baseVersion, string diffVersion, DateTime startDate, DateTime endDate);
	}
}
