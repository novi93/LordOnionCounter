using System;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000004 RID: 4
	public class LOCConstants
	{
		// Token: 0x04000027 RID: 39
		public const string DATE_RANGE = "DateRange";

		// Token: 0x04000028 RID: 40
		public const string LATEST = "Latest";

		// Token: 0x04000029 RID: 41
		public const string FILE = "File";

		// Token: 0x0400002A RID: 42
		public const string FOLDER = "Folder";

		// Token: 0x0400002B RID: 43
		public const string RequiredDbVersion = "2.0.0.0";

		// Token: 0x0400002C RID: 44
		public const string DbVersionGuid = "8e89e2a4-1574-4738-a220-15bacff21d38";

		// Token: 0x0400002D RID: 45
		public static string TempPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString() + "\\temp";
	}
}
