using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace MS.IT.LOC.UI.Properties
{
	// Token: 0x02000029 RID: 41
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00021F5C File Offset: 0x00020F5C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040001F0 RID: 496
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
