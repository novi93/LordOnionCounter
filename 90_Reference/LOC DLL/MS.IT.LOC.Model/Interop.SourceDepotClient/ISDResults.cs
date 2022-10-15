using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000006 RID: 6
	[DefaultMember("AllOutput")]
	[Guid("ED85D4B2-F3F4-46FB-9CA8-21EBC564F959")]
	[TypeLibType(4160)]
	[ComImport]
	public interface ISDResults
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000042 RID: 66
		[DispId(600)]
		bool IsFinished { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000043 RID: 67
		[DispId(601)]
		uint DataTypesAvailable { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000044 RID: 68
		[DispId(0)]
		[IndexerName("AllOutput")]
		SDCommandOutputs AllOutput { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000045 RID: 69
		[DispId(602)]
		SDCommandOutputs TextOutput { [DispId(602)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000046 RID: 70
		[DispId(604)]
		SDCommandOutputs BinaryOutput { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000047 RID: 71
		[DispId(605)]
		SDCommandOutputs InfoOutput { [DispId(605)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000048 RID: 72
		[DispId(606)]
		SDCommandOutputs WarningOutput { [DispId(606)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000049 RID: 73
		[DispId(607)]
		SDCommandOutputs ErrorOutput { [DispId(607)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600004A RID: 74
		[DispId(608)]
		SDCommandOutputs StructuredOutput { [DispId(608)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600004B RID: 75
		[DispId(609)]
		SDCommandOutputs Output { [DispId(609)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600004C RID: 76
		[DispId(610)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void WaitUntilFinished();
	}
}
