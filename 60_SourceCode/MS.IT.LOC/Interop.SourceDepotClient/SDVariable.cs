using System;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x0200001B RID: 27
	[Guid("175F36F5-E3AB-4C85-93EA-2488E9228E41")]
	[CoClass(typeof(SDVariableClass))]
	[ComImport]
	public interface SDVariable : ISDVariable
	{
	}
}
