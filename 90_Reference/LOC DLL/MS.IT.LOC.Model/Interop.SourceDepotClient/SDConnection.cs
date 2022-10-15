using System;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000003 RID: 3
	[CoClass(typeof(SDConnectionClass))]
	[Guid("BD4E7E4C-5B10-4293-93C1-426A44D816BB")]
	[ComImport]
	public interface SDConnection : ISDConnection
	{
	}
}
