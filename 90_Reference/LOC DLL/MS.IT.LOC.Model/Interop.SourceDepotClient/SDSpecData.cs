using System;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000019 RID: 25
	[Guid("539AF630-DFD7-48C4-AB0A-7464D3FA284B")]
	[CoClass(typeof(SDSpecDataClass))]
	[ComImport]
	public interface SDSpecData : ISDSpecData
	{
	}
}
