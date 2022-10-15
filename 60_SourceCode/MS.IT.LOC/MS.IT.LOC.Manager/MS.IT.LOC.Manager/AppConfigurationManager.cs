using System;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.Manager
{
	// Token: 0x02000009 RID: 9
	public class AppConfigurationManager
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000066C8 File Offset: 0x000056C8
		public static CountStandardItem CurrentCountStandard
		{
			get
			{
				CountStandardItem result;
				if (AppConfigurationManager.LocalCountStandard != null && AppConfigurationManager.LocalCountStandard.IsUsing)
				{
					result = AppConfigurationManager.LocalCountStandard;
				}
				else if (AppConfigurationManager.RemoteCountStandard != null && AppConfigurationManager.RemoteCountStandard.IsUsing)
				{
					result = AppConfigurationManager.RemoteCountStandard;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006724 File Offset: 0x00005724
		public static bool SaveStandardConfig(bool bIsLocal, ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			try
			{
				if (bIsLocal)
				{
					dataManager.SaveCountStandard(AppConfigurationManager.LocalCountStandard);
				}
				else
				{
					dataManager.SaveCountStandard(AppConfigurationManager.RemoteCountStandard);
				}
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000677C File Offset: 0x0000577C
		public static bool LoadStandardConfig(ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			try
			{
				AppConfigurationManager.LocalCountStandard = dataManager.LoadCountStandardItem(true);
				AppConfigurationManager.RemoteCountStandard = dataManager.LoadCountStandardItem(false);
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000067CC File Offset: 0x000057CC
		public static bool SetDefaultStandard(ExecutionMode eMode)
		{
			string text = AppConfigurationManager.AppDbPath + "\\LineCounters.xml";
			FileInfo fileInfo = new FileInfo(text);
			bool result;
			if (!fileInfo.Exists)
			{
				result = false;
			}
			else
			{
				string text2 = AppConfigurationManager.UserDbPath + "\\filestandard.xml";
				FileInfo fileInfo2 = new FileInfo(text2);
				if (fileInfo2.Exists)
				{
					fileInfo2.Attributes = FileAttributes.Normal;
				}
				fileInfo2 = fileInfo.CopyTo(text2, true);
				if (fileInfo2.Exists)
				{
					fileInfo2.Attributes = FileAttributes.Normal;
					if (AppConfigurationManager.LocalCountStandard == null)
					{
						AppConfigurationManager.LocalCountStandard = new CountStandardItem();
					}
					if (AppConfigurationManager.RemoteCountStandard != null)
					{
						AppConfigurationManager.RemoteCountStandard.IsUsing = false;
					}
					AppConfigurationManager.LocalCountStandard.SourceLocation = text;
					AppConfigurationManager.LocalCountStandard.DestineLocation = text2;
					AppConfigurationManager.LocalCountStandard.IsLocal = true;
					AppConfigurationManager.LocalCountStandard.IsUsing = true;
					AppConfigurationManager.SaveStandardConfig(true, ExecutionMode.StandAlone);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000068D8 File Offset: 0x000058D8
		public static bool UpdateCurrentStandard()
		{
			try
			{
				if (AppConfigurationManager.LocalCountStandard != null && AppConfigurationManager.LocalCountStandard.IsUsing)
				{
					FileInfo fileInfo = new FileInfo(AppConfigurationManager.LocalCountStandard.SourceLocation);
					FileInfo fileInfo2 = new FileInfo(AppConfigurationManager.LocalCountStandard.DestineLocation);
					if (!fileInfo.Exists)
					{
						return false;
					}
					if (fileInfo2.Exists)
					{
						fileInfo2.Attributes = FileAttributes.Normal;
					}
					try
					{
						fileInfo2 = fileInfo.CopyTo(AppConfigurationManager.LocalCountStandard.DestineLocation, true);
					}
					catch (Exception)
					{
						return false;
					}
					if (!fileInfo2.Exists)
					{
						return false;
					}
				}
				else
				{
					if (AppConfigurationManager.RemoteCountStandard == null || !AppConfigurationManager.RemoteCountStandard.IsUsing)
					{
						return true;
					}
					FileInfo fileInfo2 = new FileInfo(AppConfigurationManager.RemoteCountStandard.DestineLocation);
					if (fileInfo2.Exists)
					{
						fileInfo2.Attributes = FileAttributes.Normal;
					}
					WebClient webClient = new WebClient();
					try
					{
						webClient.UseDefaultCredentials = true;
						webClient.DownloadFile(AppConfigurationManager.RemoteCountStandard.SourceLocation, AppConfigurationManager.RemoteCountStandard.DestineLocation);
					}
					catch (Exception)
					{
						return false;
					}
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00006A7C File Offset: 0x00005A7C
		public static string guid_VSTF
		{
			get
			{
				return "c3fd2c58-94f5-401d-ad10-39d822a72404";
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006A94 File Offset: 0x00005A94
		public static string guid_SD
		{
			get
			{
				return "673a9581-9930-4477-bac4-fa7ad618afe6";
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00006AAC File Offset: 0x00005AAC
		public static string guid_VSS
		{
			get
			{
				return "9a9846e3-8f81-4b60-b729-2014dd9e0b32";
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00006AC4 File Offset: 0x00005AC4
		public static string guid_FS
		{
			get
			{
				return "100f3b95-0d90-4931-a015-0f954d5be7f7";
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00006ADC File Offset: 0x00005ADC
		public static string UserName
		{
			get
			{
				string userName;
				if (AppConfigurationManager._userName != null)
				{
					userName = AppConfigurationManager._userName;
				}
				else
				{
					AppConfigurationManager._userName = Environment.UserDomainName + "\\" + Environment.UserName;
					userName = AppConfigurationManager._userName;
				}
				return userName;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00006B20 File Offset: 0x00005B20
		public static string AppDirName
		{
			get
			{
				if (AppConfigurationManager._AppDirName == null)
				{
					AppConfigurationManager._AppDirName = AppConfigurationManager.SetAppDirName();
				}
				return AppConfigurationManager._AppDirName;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006B50 File Offset: 0x00005B50
		public static string SetAppDirName()
		{
			string text = AppConfigurationManager.AppDbPath;
			string directoryName = Path.GetDirectoryName(text);
			while (text.LastIndexOf('\\') == text.Length - 1)
			{
				text = directoryName;
				directoryName = Path.GetDirectoryName(text);
			}
			return text.Substring(directoryName.Length + 1, text.Length - directoryName.Length - 1);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006BB8 File Offset: 0x00005BB8
		public static string UserDbPath
		{
			get
			{
				string userDbPath;
				if (AppConfigurationManager._userDbPath != null)
				{
					userDbPath = AppConfigurationManager._userDbPath;
				}
				else
				{
					if (AppConfigurationManager.AppMode == ExecutionMode.Notknown)
					{
						throw new Exception("Need to set the running mode at first. Call developer!");
					}
					if (AppConfigurationManager._activeConfig == null)
					{
						AppConfigurationManager.SetActiveConfiguration();
					}
					if (AppConfigurationManager.AppMode == ExecutionMode.StandAlone)
					{
						AppConfigurationManager._userDbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString() + "\\LOC Counter";
					}
					else
					{
						AppConfigurationManager._userDbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString() + "\\LOC Counter VS Package";
					}
					userDbPath = AppConfigurationManager._userDbPath;
				}
				return userDbPath;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00006C58 File Offset: 0x00005C58
		public static string UserDbFilePath
		{
			get
			{
				if (AppConfigurationManager._activeConfig == null)
				{
					AppConfigurationManager.SetActiveConfiguration();
				}
				return AppConfigurationManager.UserDbPath + "\\" + AppConfigurationManager._activeConfig.AppSettings.Settings["DbFileName"].Value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00006CAC File Offset: 0x00005CAC
		public static string AppDbPath
		{
			get
			{
				string appDbPath;
				if (AppConfigurationManager._appDbPath != null)
				{
					appDbPath = AppConfigurationManager._appDbPath;
				}
				else
				{
					if (AppConfigurationManager._activeConfig == null)
					{
						AppConfigurationManager.SetActiveConfiguration();
					}
					AppConfigurationManager._appDbPath = Path.GetDirectoryName(AppConfigurationManager._activeConfig.FilePath);
					if (AppConfigurationManager._appDbPath.LastIndexOf('\\') == AppConfigurationManager._appDbPath.Length - 1)
					{
						AppConfigurationManager._appDbPath = AppConfigurationManager._appDbPath.Substring(0, AppConfigurationManager._appDbPath.Length - 1);
					}
					appDbPath = AppConfigurationManager._appDbPath;
				}
				return appDbPath;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00006D40 File Offset: 0x00005D40
		public static string AppDbFilePath
		{
			get
			{
				return AppConfigurationManager.AppDbPath + "\\" + AppConfigurationManager._activeConfig.AppSettings.Settings["DbFileName"].Value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006D80 File Offset: 0x00005D80
		public static string ConnectionString
		{
			get
			{
				if (AppConfigurationManager._activeConfig == null)
				{
					AppConfigurationManager.SetActiveConfiguration();
				}
				string result;
				if (AppConfigurationManager.IsLocal)
				{
					string newValue = AppConfigurationManager.UserDbPath + '\\';
					string text = AppConfigurationManager._activeConfig.AppSettings.Settings["ConnectionString"].Value;
					text = text.Replace("$path$", newValue);
					result = text;
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder(100);
					stringBuilder.Append("Server");
					stringBuilder.Append('=');
					stringBuilder.Append(AppConfigurationManager._activeConfig.AppSettings.Settings["Server"].Value);
					stringBuilder.Append(';');
					stringBuilder.Append("Database");
					stringBuilder.Append('=');
					stringBuilder.Append(AppConfigurationManager._activeConfig.AppSettings.Settings["Database"].Value);
					stringBuilder.Append(';');
					stringBuilder.Append("Integrated Security");
					stringBuilder.Append("= true;");
					result = stringBuilder.ToString();
				}
				return result;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00006EAC File Offset: 0x00005EAC
		public static string Mode
		{
			get
			{
				if (AppConfigurationManager._activeConfig == null)
				{
					AppConfigurationManager.SetActiveConfiguration();
				}
				return AppConfigurationManager._activeConfig.AppSettings.Settings["Mode"].Value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00006EF4 File Offset: 0x00005EF4
		public static string Server
		{
			get
			{
				if (AppConfigurationManager._activeConfig == null)
				{
					AppConfigurationManager.SetActiveConfiguration();
				}
				return AppConfigurationManager._activeConfig.AppSettings.Settings["Server"].Value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00006F3C File Offset: 0x00005F3C
		public static string Database
		{
			get
			{
				if (AppConfigurationManager._activeConfig == null)
				{
					AppConfigurationManager.SetActiveConfiguration();
				}
				return AppConfigurationManager._activeConfig.AppSettings.Settings["Database"].Value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00006F84 File Offset: 0x00005F84
		public static string CountingStandardsPath
		{
			get
			{
				if (AppConfigurationManager._activeConfig == null)
				{
					AppConfigurationManager.SetActiveConfiguration();
				}
				KeyValueConfigurationElement keyValueConfigurationElement = AppConfigurationManager._activeConfig.AppSettings.Settings["CountingStandardsPath"];
				if (keyValueConfigurationElement != null)
				{
					string value = keyValueConfigurationElement.Value;
					if (!string.IsNullOrEmpty(value))
					{
						return value;
					}
				}
				return AppConfigurationManager.GetDefaultCountingStandardsPath();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00006FEC File Offset: 0x00005FEC
		public static string UserGuidePath
		{
			get
			{
				return string.Format("{0}\\LOC Counter User Guide.doc", Path.GetDirectoryName(AppConfigurationManager._activeConfig.FilePath));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00007018 File Offset: 0x00006018
		public static bool IsLocal
		{
			get
			{
				return AppConfigurationManager.Mode.ToUpper().Trim() == "LOCAL";
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007044 File Offset: 0x00006044
		public static Hashtable GetAllServerOrPort(string sGuid, string type)
		{
			DataManager dataManager = new DataManager(ExecutionMode.StandAlone);
			return dataManager.GetAllServerOrPort(sGuid, type);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007068 File Offset: 0x00006068
		public static void AddServerOrPort(string guid, string type, string value)
		{
			DataManager dataManager = new DataManager(ExecutionMode.StandAlone);
			dataManager.AddServerOrPort(guid, type, value);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007088 File Offset: 0x00006088
		public static bool SetActiveConfiguration(string configFilePath)
		{
			AppConfigurationManager._activeConfig = ConfigurationManager.OpenExeConfiguration(configFilePath);
			return AppConfigurationManager._activeConfig != null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000070B0 File Offset: 0x000060B0
		public static void SaveConfigValues(string sModeValue, string sServerName, string sDatabaseName)
		{
			AppConfigurationManager._activeConfig.AppSettings.Settings.Remove("Mode");
			if ("LOCAL" == sModeValue.Trim().ToUpper())
			{
				AppConfigurationManager._activeConfig.AppSettings.Settings.Add("Mode", "LOCAL");
			}
			else
			{
				AppConfigurationManager._activeConfig.AppSettings.Settings.Add("Mode", "SHARED");
				AppConfigurationManager._activeConfig.AppSettings.Settings.Remove("Server");
				AppConfigurationManager._activeConfig.AppSettings.Settings.Remove("Database");
				AppConfigurationManager._activeConfig.AppSettings.Settings.Add("Server", sServerName);
				AppConfigurationManager._activeConfig.AppSettings.Settings.Add("Database", sDatabaseName);
			}
			AppConfigurationManager._activeConfig.Save(ConfigurationSaveMode.Modified);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000071B4 File Offset: 0x000061B4
		private static bool SetActiveConfiguration()
		{
			AppConfigurationManager._activeConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			return AppConfigurationManager._activeConfig != null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000071DC File Offset: 0x000061DC
		private static string GetDefaultCountingStandardsPath()
		{
			StringBuilder stringBuilder = new StringBuilder(100);
			stringBuilder.Append(AppConfigurationManager._userDbPath);
			stringBuilder.Append('\\');
			stringBuilder.Append("LineCounters.xml");
			return stringBuilder.ToString();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007220 File Offset: 0x00006220
		public static bool UserDbExist(ExecutionMode eMode)
		{
			FileInfo fileInfo = new FileInfo(AppConfigurationManager.UserDbFilePath);
			return fileInfo.Exists;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007250 File Offset: 0x00006250
		public static int MoveDb2UserDir()
		{
			FileInfo fileInfo = new FileInfo(AppConfigurationManager.AppDbFilePath);
			FileInfo fileInfo2 = new FileInfo(AppConfigurationManager.UserDbFilePath);
			if (!fileInfo.Exists)
			{
				throw new Exception("The default database file does not exist! Try to install the application again!");
			}
			if (fileInfo2.Exists)
			{
				fileInfo2.Attributes = FileAttributes.Normal;
				fileInfo2.Delete();
				fileInfo2.Refresh();
			}
			Directory.CreateDirectory(AppConfigurationManager.UserDbPath);
			fileInfo.CopyTo(AppConfigurationManager.UserDbFilePath, true);
			fileInfo2.Refresh();
			int result;
			if (fileInfo2.Exists)
			{
				fileInfo2.Attributes = FileAttributes.Normal;
				result = 1;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000072F8 File Offset: 0x000062F8
		public static int VerifyDbVersion(ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			int result;
			try
			{
				string dbFileVersion = dataManager.GetDbFileVersion();
				if (string.Compare(dbFileVersion, "2.0.0.0") != 0)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception)
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x04000028 RID: 40
		private const string REPLACEVALUE = "$path$";

		// Token: 0x04000029 RID: 41
		private const int DEFAULT_SB_LENGTH = 100;

		// Token: 0x0400002A RID: 42
		private const string DEFAULT_COUNTING_STANDARDS_FILENAME = "LineCounters.xml";

		// Token: 0x0400002B RID: 43
		private const string USER_GUIDE_FORMAT_STRING = "{0}\\LOC Counter User Guide.doc";

		// Token: 0x0400002C RID: 44
		private const string VSTF = "c3fd2c58-94f5-401d-ad10-39d822a72404";

		// Token: 0x0400002D RID: 45
		private const string SD = "673a9581-9930-4477-bac4-fa7ad618afe6";

		// Token: 0x0400002E RID: 46
		private const string VSS = "9a9846e3-8f81-4b60-b729-2014dd9e0b32";

		// Token: 0x0400002F RID: 47
		private const string FS = "100f3b95-0d90-4931-a015-0f954d5be7f7";

		// Token: 0x04000030 RID: 48
		public const string SERVER_KEY = "Server";

		// Token: 0x04000031 RID: 49
		public const string DB_KEY = "Database";

		// Token: 0x04000032 RID: 50
		public const string MODE_KEY = "Mode";

		// Token: 0x04000033 RID: 51
		public const string COUNTING_STANDARDS_PATH_KEY = "CountingStandardsPath";

		// Token: 0x04000034 RID: 52
		public const string CONNECTIONSTRING_KEY = "ConnectionString";

		// Token: 0x04000035 RID: 53
		public const string INTEGRATED_SECURITY_KEY = "Integrated Security";

		// Token: 0x04000036 RID: 54
		public const string LOCALVALUE = "LOCAL";

		// Token: 0x04000037 RID: 55
		public const string SHAREDVALUE = "SHARED";

		// Token: 0x04000038 RID: 56
		public const string DB_FILE_NAME_KEY = "DbFileName";

		// Token: 0x04000039 RID: 57
		private static Configuration _activeConfig = null;

		// Token: 0x0400003A RID: 58
		public static ExecutionMode AppMode = ExecutionMode.Notknown;

		// Token: 0x0400003B RID: 59
		public static CountStandardItem LocalCountStandard = null;

		// Token: 0x0400003C RID: 60
		public static CountStandardItem RemoteCountStandard = null;

		// Token: 0x0400003D RID: 61
		private static string _userName = null;

		// Token: 0x0400003E RID: 62
		private static string _AppDirName = null;

		// Token: 0x0400003F RID: 63
		private static string _userDbPath = null;

		// Token: 0x04000040 RID: 64
		private static string _appDbPath = null;
	}
}
