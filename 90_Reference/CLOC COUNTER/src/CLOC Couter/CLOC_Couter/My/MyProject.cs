using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace CLOC_Couter.My
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000210C File Offset: 0x0000030C
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002128 File Offset: 0x00000328
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002144 File Offset: 0x00000344
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000217C File Offset: 0x0000037C
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x0200001D RID: 29
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x06000185 RID: 389 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06000186 RID: 390 RVA: 0x0000D200 File Offset: 0x0000B400
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000187 RID: 391 RVA: 0x0000D217 File Offset: 0x0000B417
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x06000188 RID: 392 RVA: 0x0000D224 File Offset: 0x0000B424
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000189 RID: 393 RVA: 0x0000D244 File Offset: 0x0000B444
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600018A RID: 394 RVA: 0x0000D25C File Offset: 0x0000B45C
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x0600018B RID: 395 RVA: 0x0000D278 File Offset: 0x0000B478
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600018C RID: 396 RVA: 0x0000D290 File Offset: 0x0000B490
			// (set) Token: 0x06000192 RID: 402 RVA: 0x0000D332 File Offset: 0x0000B532
			public frmCounterLOC frmCounterLOC
			{
				[DebuggerHidden]
				get
				{
					this.m_frmCounterLOC = MyProject.MyForms.Create__Instance__<frmCounterLOC>(this.m_frmCounterLOC);
					return this.m_frmCounterLOC;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmCounterLOC)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmCounterLOC>(ref this.m_frmCounterLOC);
					}
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x0600018D RID: 397 RVA: 0x0000D2AB File Offset: 0x0000B4AB
			// (set) Token: 0x06000193 RID: 403 RVA: 0x0000D35E File Offset: 0x0000B55E
			public frmProcess frmProcess
			{
				[DebuggerHidden]
				get
				{
					this.m_frmProcess = MyProject.MyForms.Create__Instance__<frmProcess>(this.m_frmProcess);
					return this.m_frmProcess;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmProcess)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmProcess>(ref this.m_frmProcess);
					}
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600018E RID: 398 RVA: 0x0000D2C6 File Offset: 0x0000B4C6
			// (set) Token: 0x06000194 RID: 404 RVA: 0x0000D38A File Offset: 0x0000B58A
			public frmResultCountFile frmResultCountFile
			{
				[DebuggerHidden]
				get
				{
					this.m_frmResultCountFile = MyProject.MyForms.Create__Instance__<frmResultCountFile>(this.m_frmResultCountFile);
					return this.m_frmResultCountFile;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmResultCountFile)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmResultCountFile>(ref this.m_frmResultCountFile);
					}
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x0600018F RID: 399 RVA: 0x0000D2E1 File Offset: 0x0000B4E1
			// (set) Token: 0x06000195 RID: 405 RVA: 0x0000D3B6 File Offset: 0x0000B5B6
			public frmResultDiff frmResultDiff
			{
				[DebuggerHidden]
				get
				{
					this.m_frmResultDiff = MyProject.MyForms.Create__Instance__<frmResultDiff>(this.m_frmResultDiff);
					return this.m_frmResultDiff;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmResultDiff)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmResultDiff>(ref this.m_frmResultDiff);
					}
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000190 RID: 400 RVA: 0x0000D2FC File Offset: 0x0000B4FC
			// (set) Token: 0x06000196 RID: 406 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
			public frmSelectFileorFolder frmSelectFileorFolder
			{
				[DebuggerHidden]
				get
				{
					this.m_frmSelectFileorFolder = MyProject.MyForms.Create__Instance__<frmSelectFileorFolder>(this.m_frmSelectFileorFolder);
					return this.m_frmSelectFileorFolder;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmSelectFileorFolder)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmSelectFileorFolder>(ref this.m_frmSelectFileorFolder);
					}
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000191 RID: 401 RVA: 0x0000D317 File Offset: 0x0000B517
			// (set) Token: 0x06000197 RID: 407 RVA: 0x0000D40E File Offset: 0x0000B60E
			public frmSelectFileRepository frmSelectFileRepository
			{
				[DebuggerHidden]
				get
				{
					this.m_frmSelectFileRepository = MyProject.MyForms.Create__Instance__<frmSelectFileRepository>(this.m_frmSelectFileRepository);
					return this.m_frmSelectFileRepository;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmSelectFileRepository)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmSelectFileRepository>(ref this.m_frmSelectFileRepository);
					}
				}
			}

			// Token: 0x04000097 RID: 151
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04000098 RID: 152
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmCounterLOC m_frmCounterLOC;

			// Token: 0x04000099 RID: 153
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmProcess m_frmProcess;

			// Token: 0x0400009A RID: 154
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmResultCountFile m_frmResultCountFile;

			// Token: 0x0400009B RID: 155
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmResultDiff m_frmResultDiff;

			// Token: 0x0400009C RID: 156
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmSelectFileorFolder m_frmSelectFileorFolder;

			// Token: 0x0400009D RID: 157
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmSelectFileRepository m_frmSelectFileRepository;
		}

		// Token: 0x0200001E RID: 30
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x06000198 RID: 408 RVA: 0x0000D43C File Offset: 0x0000B63C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000199 RID: 409 RVA: 0x0000D45C File Offset: 0x0000B65C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600019A RID: 410 RVA: 0x0000D474 File Offset: 0x0000B674
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600019B RID: 411 RVA: 0x0000D490 File Offset: 0x0000B690
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600019C RID: 412 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x0600019D RID: 413 RVA: 0x0000D4D1 File Offset: 0x0000B6D1
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x0600019E RID: 414 RVA: 0x0000D217 File Offset: 0x0000B417
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x0200001F RID: 31
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600019F RID: 415 RVA: 0x0000D4DC File Offset: 0x0000B6DC
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x0000D217 File Offset: 0x0000B417
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400009E RID: 158
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
