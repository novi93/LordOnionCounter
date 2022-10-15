using System;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000011 RID: 17
	[Guid("ED85D4B2-F3F4-46FB-9CA8-21EBC564F959")]
	[CoClass(typeof(SDResultsClass))]
	[ComImport]
	public interface SDResults : ISDResults
	{
	}
}
