using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
    // Token: 0x0200001A RID: 26
    [ClassInterface(ClassInterfaceType.None)]
    [DefaultMember("Value")]
    [Guid("A110162B-72C9-4DC4-BECC-B3E1D553DCD3")]
    [ComImport]
    public class SDVariableClass : ISDVariable, SDVariable
    {
        // Token: 0x06000097 RID: 151
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern SDVariableClass();

        // Token: 0x17000060 RID: 96
        // (get) Token: 0x06000098 RID: 152
        [DispId(0)]
        [IndexerName("Value")]
        public virtual extern string Value { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        // Token: 0x17000061 RID: 97
        // (get) Token: 0x06000099 RID: 153
        [DispId(100)]
        public virtual extern string Name { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

        // Token: 0x17000062 RID: 98
        // (get) Token: 0x0600009A RID: 154
        [DispId(101)]
        public virtual extern int Length { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

        // Token: 0x17000063 RID: 99
        // (get) Token: 0x0600009B RID: 155
        [DispId(102)]
        public virtual extern object SourceValue { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

        // Token: 0x17000064 RID: 100
        // (get) Token: 0x0600009C RID: 156
        [DispId(103)]
        public virtual extern bool IsUnicode { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
    }
}
