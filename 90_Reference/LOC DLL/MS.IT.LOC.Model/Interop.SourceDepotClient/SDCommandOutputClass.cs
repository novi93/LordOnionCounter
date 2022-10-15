using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000014 RID: 20
	[ClassInterface(0)]
	[Guid("7B99D0DA-F2BD-4B7A-B221-6691BE720BCB")]
	[ComImport]
	public class SDCommandOutputClass : ISDCommandOutput, SDCommandOutput
	{
		// Token: 0x06000083 RID: 131
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern SDCommandOutputClass();

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000084 RID: 132
		[DispId(400)]
		public virtual extern SDCB_CALLBACKTYPE Type { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000085 RID: 133
		[DispId(401)]
		public virtual extern int Length { [DispId(401)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000086 RID: 134
		[DispId(402)]
		public virtual extern string Message { [DispId(402)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000087 RID: 135
		[DispId(403)]
		public virtual extern object Data { [DispId(403)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000088 RID: 136
		[DispId(404)]
		public virtual extern SDVariables Variables { [DispId(404)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
