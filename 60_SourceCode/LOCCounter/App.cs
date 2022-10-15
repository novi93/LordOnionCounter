using System;
using System.Threading;
using System.Windows.Forms;
using MS.IT.LOC.Manager;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000005 RID: 5
	internal static class App
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002F18 File Offset: 0x00001F18
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			App.objmutex = new Mutex(true, "Microsoft Line Of Code Counter", out App.isNew);
			if (App.isNew)
			{
				AppConfigurationManager.AppMode = ExecutionMode.StandAlone;
				if (App.InitialApplicationConfig(ExecutionMode.StandAlone) >= 0)
				{
					Application.Run(new frmCounterItems());
				}
			}
			else
			{
				MessageBox.Show("Application is already running.", "Microsoft Line Of Code Counter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002F90 File Offset: 0x00001F90
		public static int InitialApplicationConfig(ExecutionMode eMode)
		{
			if (AppConfigurationManager.UserDbExist(eMode))
			{
				if (AppConfigurationManager.VerifyDbVersion(eMode) != 0)
				{
					if (MessageBox.Show("The version of your database file is not consistent with the application. \nLocation:" + AppConfigurationManager.UserDbFilePath + "\nClick Yes to replace it by the default database file!", "LOC Counter", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
					{
						return -1;
					}
					if (AppConfigurationManager.MoveDb2UserDir() < 0)
					{
						MessageBox.Show("Failed when copying the database file to your document directory", "LOC Counter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return -1;
					}
				}
			}
			else if (AppConfigurationManager.MoveDb2UserDir() < 0)
			{
				MessageBox.Show("Failed when copying the database file to your document directory", "LOC Counter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return -1;
			}
			AppConfigurationManager.LoadStandardConfig(eMode);
			if (!AppConfigurationManager.UpdateCurrentStandard())
			{
				MessageBox.Show("The current setting count standard file can't be sync! We are trying to use the default standard file!", "LOC Counter");
				if (!AppConfigurationManager.SetDefaultStandard(eMode))
				{
					MessageBox.Show("Can't load default standard file successfully!", "LOC Counter");
				}
			}
			else if (AppConfigurationManager.CurrentCountStandard == null)
			{
				if (!AppConfigurationManager.SetDefaultStandard(eMode))
				{
					MessageBox.Show("Can't load default standard file successfully!", "LOC Counter");
				}
			}
			return 1;
		}

		// Token: 0x04000018 RID: 24
		private static bool isNew;

		// Token: 0x04000019 RID: 25
		private static Mutex objmutex;
	}
}
