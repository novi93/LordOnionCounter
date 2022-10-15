using System;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x0200000E RID: 14
	[Guid("8A3F9EDF-2346-4E8A-B725-A66C2E124DE8")]
	[CoClass(typeof(SDUtilitiesClass))]
	[ComImport]
	public interface SDUtilities : ISDUtilities
	{
	}
}
