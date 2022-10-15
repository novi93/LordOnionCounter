using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000012 RID: 18
	[ClassInterface(0)]
	[Guid("968F2975-C759-4D2F-84F5-51D3DA7B75F7")]
	[ComImport]
	public class SDCommandOutputsClass : ISDCommandOutputs, SDCommandOutputs, IEnumerable
	{
		// Token: 0x0600007F RID: 127
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern SDCommandOutputsClass();

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000080 RID: 128
		[DispId(500)]
		public virtual extern int Count { [DispId(500)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000051 RID: 81
		[DispId(0)]
		public virtual extern SDCommandOutput this[[In] int nIndex]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x06000082 RID: 130
		[DispId(-4)]
		[TypeLibFunc(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		public virtual extern IEnumerator GetEnumerator();
	}
}
