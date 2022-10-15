using System;

namespace MS.IT.LOC.Manager
{
	// Token: 0x02000003 RID: 3
	public class SourceControlEventArgs : EventArgs
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000225D File Offset: 0x0000125D
		public SourceControlEventArgs(string eventDescription)
		{
			this.m_EventDescription = eventDescription;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000227C File Offset: 0x0000127C
		public override string ToString()
		{
			return this.m_EventDescription;
		}

		// Token: 0x04000003 RID: 3
		public static readonly SourceControlEventArgs Connecting = new SourceControlEventArgs("Connecting");

		// Token: 0x04000004 RID: 4
		public static readonly SourceControlEventArgs Connected = new SourceControlEventArgs("Connected");

		// Token: 0x04000005 RID: 5
		public static readonly SourceControlEventArgs NotConnected = new SourceControlEventArgs("Not Connected");

		// Token: 0x04000006 RID: 6
		public static readonly SourceControlEventArgs UnableToConnect = new SourceControlEventArgs("Unable to connect");

		// Token: 0x04000007 RID: 7
		public static readonly SourceControlEventArgs Getting = new SourceControlEventArgs("Getting Item");

		// Token: 0x04000008 RID: 8
		public static readonly SourceControlEventArgs Got = new SourceControlEventArgs("Got Items");

		// Token: 0x04000009 RID: 9
		public static readonly SourceControlEventArgs Downloading = new SourceControlEventArgs("Downloading");

		// Token: 0x0400000A RID: 10
		public static readonly SourceControlEventArgs Downloaded = new SourceControlEventArgs("Downloaded");

		// Token: 0x0400000B RID: 11
		public static readonly SourceControlEventArgs NotDownloaded = new SourceControlEventArgs("Unable to download");

		// Token: 0x0400000C RID: 12
		public string m_EventDescription = "";
	}
}
