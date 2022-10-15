using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000018 RID: 24
	[Guid("B1502CDF-C5CD-43E6-9814-BAB634E61B8C")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComImport]
	public class SDSpecDataClass : ISDSpecData, SDSpecData
	{
		// Token: 0x06000091 RID: 145
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern SDSpecDataClass();

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000092 RID: 146
		[DispId(200)]
		public virtual extern SDVariables Schema { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000093 RID: 147
		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ParseSpec([MarshalAs(UnmanagedType.BStr)] [In] string bstrSpec);

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000094 RID: 148
		[DispId(202)]
		public virtual extern string FormattedSpec { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700005F RID: 95
		[DispId(0)]
		public virtual extern object this[[MarshalAs(UnmanagedType.BStr)] [In] string bstrName]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[param: MarshalAs(UnmanagedType.Struct)]
			[param: In]
			set;
		}
	}
}
