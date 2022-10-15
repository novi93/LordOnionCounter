using System;

namespace SourceDepotClient
{
	// Token: 0x02000009 RID: 9
	public enum SDCB_CALLBACKTYPE
	{
		// Token: 0x04000006 RID: 6
		SDCB_ALL,
		// Token: 0x04000007 RID: 7
		SDCB_TEXT,
		// Token: 0x04000008 RID: 8
		SDCB_BINARY,
		// Token: 0x04000009 RID: 9
		SDCB_INFO = 4,
		// Token: 0x0400000A RID: 10
		SDCB_WARNING = 8,
		// Token: 0x0400000B RID: 11
		SDCB_ERROR = 16,
		// Token: 0x0400000C RID: 12
		SDCB_STRUCTURED = 32
	}
}
