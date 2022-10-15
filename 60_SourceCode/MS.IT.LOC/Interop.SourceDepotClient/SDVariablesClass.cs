using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000016 RID: 22
	[Guid("C429CE0C-DA87-4B89-AB58-222255F4118D")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComImport]
	public class SDVariablesClass : ISDVariables, SDVariables, IEnumerable
	{
		// TODO 
		//// Token: 0x06000089 RID: 137
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//internal extern SDVariablesClass();

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600008A RID: 138
		[DispId(300)]
		public virtual extern SDVariable Variable { [DispId(300)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600008B RID: 139
		[DispId(301)]
		public virtual extern SDVariable VariableX { [DispId(301)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600008C RID: 140
		[DispId(302)]
		public virtual extern SDVariable VariableXY { [DispId(302)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600008D RID: 141
		[DispId(303)]
		public virtual extern int Count { [DispId(303)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005B RID: 91
		[DispId(0)]
		public virtual extern SDVariable this[[In] int lIndex]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600008F RID: 143
		[DispId(304)]
		public virtual extern SDSpecData SpecData { [DispId(304)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000090 RID: 144
		[TypeLibFunc(1)]
		[DispId(-4)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		public virtual extern IEnumerator GetEnumerator();
	}
}
