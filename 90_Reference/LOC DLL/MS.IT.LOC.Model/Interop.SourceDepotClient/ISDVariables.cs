using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x0200000A RID: 10
	[Guid("95DB0BE4-C34E-4650-81D2-6F461C33C03D")]
	[TypeLibType(4160)]
	[ComImport]
	public interface ISDVariables : IEnumerable
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000055 RID: 85
		[DispId(300)]
		SDVariable Variable { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000056 RID: 86
		[DispId(301)]
		SDVariable VariableX { [DispId(301)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000057 RID: 87
		[DispId(302)]
		SDVariable VariableXY { [DispId(302)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000058 RID: 88
		[DispId(303)]
		int Count { [DispId(303)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003C RID: 60
		[DispId(0)]
		SDVariable this[[In] int lIndex]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600005A RID: 90
		[DispId(304)]
		SDSpecData SpecData { [DispId(304)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600005B RID: 91
		[DispId(-4)]
		[TypeLibFunc(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		IEnumerator GetEnumerator();
	}
}
