using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000007 RID: 7
	[TypeLibType(4160)]
	[Guid("188BC6BC-65F7-46A1-87EC-15C3F89DCB45")]
	[ComImport]
	public interface ISDCommandOutputs : IEnumerable
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600004D RID: 77
		[DispId(500)]
		int Count { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000032 RID: 50
		[DispId(0)]
		SDCommandOutput this[[In] int nIndex]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x0600004F RID: 79
		[DispId(-4)]
		[TypeLibFunc(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		IEnumerator GetEnumerator();
	}
}
