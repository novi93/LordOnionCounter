using System;

namespace CLOC_Couter
{
	// Token: 0x0200000A RID: 10
	public class CompareFile
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002C98 File Offset: 0x00000E98
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002CA2 File Offset: 0x00000EA2
		public string Filename { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002CAB File Offset: 0x00000EAB
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002CB5 File Offset: 0x00000EB5
		public string Base { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002CBE File Offset: 0x00000EBE
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public string Create_Edit { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002CD1 File Offset: 0x00000ED1
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002CDB File Offset: 0x00000EDB
		public string Removed { get; set; }
	}
}
