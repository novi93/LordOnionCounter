using System;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000015 RID: 21
	[Guid("2B34362F-CEB2-4A47-BB10-7E4598668ADD")]
	[CoClass(typeof(SDCommandOutputClass))]
	[ComImport]
	public interface SDCommandOutput : ISDCommandOutput
	{
	}
}
