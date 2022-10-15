using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000010 RID: 16
	[Guid("06298A20-F202-4FC4-9B51-C1D3A6D412E3")]
	[DefaultMember("AllOutput")]
	[ClassInterface(0)]
	[ComImport]
	public class SDResultsClass : ISDResults, SDResults
	{
		// Token: 0x06000073 RID: 115
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern SDResultsClass();

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000074 RID: 116
		[DispId(600)]
		public virtual extern bool IsFinished { [DispId(600)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000075 RID: 117
		[DispId(601)]
		public virtual extern uint DataTypesAvailable { [DispId(601)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000076 RID: 118
		[DispId(0)]
		[IndexerName("AllOutput")]
		public virtual extern SDCommandOutputs AllOutput { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000077 RID: 119
		[DispId(602)]
		public virtual extern SDCommandOutputs TextOutput { [DispId(602)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000078 RID: 120
		[DispId(604)]
		public virtual extern SDCommandOutputs BinaryOutput { [DispId(604)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000079 RID: 121
		[DispId(605)]
		public virtual extern SDCommandOutputs InfoOutput { [DispId(605)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600007A RID: 122
		[DispId(606)]
		public virtual extern SDCommandOutputs WarningOutput { [DispId(606)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600007B RID: 123
		[DispId(607)]
		public virtual extern SDCommandOutputs ErrorOutput { [DispId(607)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600007C RID: 124
		[DispId(608)]
		public virtual extern SDCommandOutputs StructuredOutput { [DispId(608)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600007D RID: 125
		[DispId(609)]
		public virtual extern SDCommandOutputs Output { [DispId(609)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600007E RID: 126
		[DispId(610)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void WaitUntilFinished();
	}
}
