using System;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000017 RID: 23
	[CoClass(typeof(SDVariablesClass))]
	[Guid("95DB0BE4-C34E-4650-81D2-6F461C33C03D")]
	[ComImport]
	public interface SDVariables : ISDVariables
	{
	}
}
