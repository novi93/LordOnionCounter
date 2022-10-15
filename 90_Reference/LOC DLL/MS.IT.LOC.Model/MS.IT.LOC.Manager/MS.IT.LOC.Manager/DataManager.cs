using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.Manager
{
	// Token: 0x02000007 RID: 7
	public class DataManager
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00004001 File Offset: 0x00003001
		public DataManager(ExecutionMode eMode)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000400C File Offset: 0x0000300C
		private int MoveDb2UserDir()
		{
			FileInfo fileInfo = new FileInfo(AppConfigurationManager.AppDbFilePath);
			FileInfo fileInfo2 = new FileInfo(AppConfigurationManager.UserDbFilePath);
			if (!fileInfo.Exists)
			{
				throw new Exception("The database file has been not exist!");
			}
			if (fileInfo2.Exists && fileInfo2.LastWriteTime < fileInfo.LastWriteTime)
			{
				fileInfo2.Attributes = FileAttributes.Normal;
				fileInfo2.Delete();
				fileInfo2.Refresh();
			}
			if (!fileInfo2.Exists)
			{
				Directory.CreateDirectory(AppConfigurationManager.UserDbPath);
				fileInfo.CopyTo(AppConfigurationManager.UserDbFilePath, true);
				fileInfo2.Refresh();
				if (fileInfo2.Exists)
				{
					fileInfo2.Attributes = FileAttributes.Normal;
				}
			}
			return 1;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000040D0 File Offset: 0x000030D0
		private IDbConnection getConnection()
		{
			IDbConnection result;
			if (AppConfigurationManager.IsLocal)
			{
				result = new OleDbConnection(AppConfigurationManager.ConnectionString);
			}
			else
			{
				result = new SqlConnection(AppConfigurationManager.ConnectionString);
			}
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004108 File Offset: 0x00003108
		private IDbCommand getCommand()
		{
			IDbCommand result;
			if (AppConfigurationManager.IsLocal)
			{
				result = new OleDbCommand();
			}
			else
			{
				result = new SqlCommand();
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004138 File Offset: 0x00003138
		private IDbCommand getCommand(string cmdText)
		{
			IDbCommand result;
			if (AppConfigurationManager.IsLocal)
			{
				result = new OleDbCommand(cmdText);
			}
			else
			{
				result = new SqlCommand(cmdText);
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004168 File Offset: 0x00003168
		private IDbDataAdapter getDataAdapter()
		{
			IDbDataAdapter result;
			if (AppConfigurationManager.IsLocal)
			{
				result = new OleDbDataAdapter();
			}
			else
			{
				result = new SqlDataAdapter();
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004198 File Offset: 0x00003198
		public CountStandardItem LoadCountStandardItem(bool bIsLocal)
		{
			CountStandardItem countStandardItem = null;
			string commandText = "Select [CountStandardID],[SourceLocation],[IsLocal],[IsUsing],[DestineLocation] from CountStandard where [IsLocal]=" + bIsLocal.ToString() + " ";
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			connection.Open();
			IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
			if (dataReader.Read())
			{
				countStandardItem = new CountStandardItem();
				countStandardItem.SourceLocation = dataReader["SourceLocation"].ToString();
				countStandardItem.DestineLocation = dataReader["DestineLocation"].ToString();
				countStandardItem.IsLocal = bool.Parse(dataReader["IsLocal"].ToString());
				countStandardItem.IsUsing = bool.Parse(dataReader["IsUsing"].ToString());
			}
			dataReader.Close();
			dataReader.Dispose();
			return countStandardItem;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004288 File Offset: 0x00003288
		public void SaveCountStandard(CountStandardItem countStandItem)
		{
			if (countStandItem != null)
			{
				IDbConnection connection = this.getConnection();
				connection.Open();
				string cmdText;
				IDbCommand command;
				if (countStandItem.IsUsing)
				{
					cmdText = "Update [CountStandard] set [IsUsing]=False Where [IsUsing]=True";
					command = this.getCommand(cmdText);
					command.Connection = connection;
					command.ExecuteNonQuery();
				}
				cmdText = "Delete from [CountStandard] where [IsLocal]=" + countStandItem.IsLocal.ToString();
				command = this.getCommand(cmdText);
				command.Connection = connection;
				command.ExecuteNonQuery();
				cmdText = string.Concat(new string[]
				{
					"Insert into CountStandard ([SourceLocation],[IsLocal],[IsUsing],[DestineLocation]) values ('",
					countStandItem.SourceLocation,
					"', ",
					countStandItem.IsLocal.ToString(),
					" , ",
					countStandItem.IsUsing.ToString(),
					" ,'",
					countStandItem.DestineLocation,
					"')"
				});
				command = this.getCommand(cmdText);
				command.Connection = connection;
				command.ExecuteNonQuery();
				connection.Close();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000043A4 File Offset: 0x000033A4
		public void SaveCounterItemSet(CounterItemSet itemSet)
		{
			ArrayList arrayList = new ArrayList();
			string text = "";
			IDbConnection connection = this.getConnection();
			string text2 = string.Empty;
			foreach (object obj in itemSet)
			{
				CounterItem counterItem = (CounterItem)obj;
				text = counterItem.CounterItemID;
				string text3 = "";
				text2 = string.Concat(new string[]
				{
					"@Standard-Report:",
					counterItem.StandardReport.ToString(),
					"!@M-Report:",
					counterItem.MReport.ToString(),
					"!@PSP-Metrics:",
					counterItem.PspMetrics.ToString(),
					"!"
				});
				if (counterItem.IsNew)
				{
					text3 = string.Concat(new object[]
					{
						"Insert into CounterItem (CounterItemID,Name,ItemType,StartDate,EndDate,BaseVersion,DiffVersion,BaseItem,DiffItem,ToBeCount,ServerName,ServerPort,ServerType,Reserved) values ('",
						text,
						"','",
						counterItem.Name,
						"',",
						(int)counterItem.Type,
						",",
						(counterItem.StartDate == DateTime.MinValue) ? "Null" : ((AppConfigurationManager.IsLocal ? "#" : "'") + counterItem.StartDate.ToString() + (AppConfigurationManager.IsLocal ? "#" : "'")),
						",",
						(counterItem.EndDate == DateTime.MinValue) ? "Null" : ((AppConfigurationManager.IsLocal ? "#" : "'") + counterItem.EndDate.ToString() + (AppConfigurationManager.IsLocal ? "#" : "'")),
						",'",
						counterItem.BaseVersion,
						"','",
						counterItem.DiffVersion,
						"','",
						counterItem.BaseItem,
						"','",
						counterItem.DiffItem,
						"',",
						counterItem.ToBeCount ? (AppConfigurationManager.IsLocal ? "True" : "1") : (AppConfigurationManager.IsLocal ? "False" : "0"),
						",'",
						counterItem.ServerName,
						"','",
						counterItem.ServerPort,
						"',",
						((int)counterItem.ServerType).ToString(),
						",'",
						text2,
						"')"
					});
				}
				else if (counterItem.IsDirty)
				{
					text3 = string.Concat(new object[]
					{
						"Update CounterItem Set Name='",
						counterItem.Name,
						"',ItemType=",
						(int)counterItem.Type,
						", StartDate=",
						(counterItem.StartDate == DateTime.MinValue) ? "Null" : ((AppConfigurationManager.IsLocal ? "#" : "'") + counterItem.StartDate.ToString() + (AppConfigurationManager.IsLocal ? "#" : "'")),
						", EndDate=",
						(counterItem.EndDate == DateTime.MinValue) ? "Null" : ((AppConfigurationManager.IsLocal ? "#" : "'") + counterItem.EndDate.ToString() + (AppConfigurationManager.IsLocal ? "#" : "'")),
						", ToBeCount = ",
						counterItem.ToBeCount ? (AppConfigurationManager.IsLocal ? "True" : "1") : (AppConfigurationManager.IsLocal ? "False" : "0"),
						",BaseVersion = '",
						counterItem.BaseVersion,
						"',DiffVersion = '",
						counterItem.DiffVersion,
						"',BaseItem = '",
						counterItem.BaseItem,
						"',DiffItem = '",
						counterItem.DiffItem,
						"', ServerName = '",
						counterItem.ServerName,
						"', ServerPort = '",
						counterItem.ServerPort,
						"', ServerType = ",
						((int)counterItem.ServerType).ToString(),
						", Reserved='",
						text2,
						"' Where CounterItemID='",
						text,
						"'"
					});
				}
				if (text3 != "")
				{
					IDbCommand command = this.getCommand(text3);
					arrayList.Add(command);
				}
				if (counterItem.IsDirty)
				{
					text3 = "Delete from Element Where CounterItemID='" + text + "'";
					IDbCommand command = this.getCommand(text3);
					arrayList.Add(command);
					foreach (object obj2 in counterItem.IncludeElementSet)
					{
						Element element = (Element)obj2;
						string elementID = element.ElementID;
						text3 = string.Concat(new string[]
						{
							"Insert into Element (ElementID,Include,ElementType,ServerPath,CounterItemID) values ('",
							elementID,
							"',",
							AppConfigurationManager.IsLocal ? "True" : "1",
							",",
							(element.ElementType == SCItemType.FILE) ? "0" : "1",
							",'",
							element.ServerPath,
							"','",
							text,
							"')"
						});
						if (text3 != "")
						{
							command = this.getCommand(text3);
							arrayList.Add(command);
						}
					}
					foreach (object obj3 in counterItem.ExcludeElementSet)
					{
						Element element = (Element)obj3;
						string elementID = element.ElementID;
						text3 = string.Concat(new string[]
						{
							"Insert into Element (ElementID,Include,ElementType,ServerPath,CounterItemID) values ('",
							elementID,
							"',",
							AppConfigurationManager.IsLocal ? "False" : "0",
							",",
							(element.ElementType == SCItemType.FILE) ? "0" : "1",
							",'",
							element.ServerPath,
							"','",
							text,
							"')"
						});
						command = this.getCommand(text3);
						arrayList.Add(command);
					}
					text3 = "Delete from CounterCategory where CounterItemID='" + text + "'";
					command = this.getCommand(text3);
					arrayList.Add(command);
					foreach (object obj4 in counterItem.CategoryList)
					{
						Category category = (Category)obj4;
						text3 = string.Concat(new string[]
						{
							"Insert Into CounterCategory (CategoryID,CounterItemID) Values('",
							category.CategoryID,
							"','",
							text,
							"')"
						});
						command = this.getCommand(text3);
						arrayList.Add(command);
					}
				}
			}
			connection.Open();
			IDbTransaction dbTransaction = connection.BeginTransaction();
			try
			{
				foreach (object obj5 in arrayList)
				{
					IDbCommand dbCommand = (IDbCommand)obj5;
					dbCommand.Connection = connection;
					dbCommand.Transaction = dbTransaction;
					dbCommand.ExecuteNonQuery();
				}
				dbTransaction.Commit();
			}
			catch (Exception ex)
			{
				dbTransaction.Rollback();
			}
			connection.Close();
			foreach (object obj6 in itemSet)
			{
				CounterItem counterItem2 = (CounterItem)obj6;
				counterItem2.Saved = true;
				foreach (object obj7 in counterItem2.ExcludeElementSet)
				{
					Element element = (Element)obj7;
					element.Saved = true;
				}
				foreach (object obj8 in counterItem2.IncludeElementSet)
				{
					Element element = (Element)obj8;
					element.Saved = true;
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004EAC File Offset: 0x00003EAC
		public CounterItemSet LoadCounterItemSet()
		{
			CounterItemSet counterItemSet = new CounterItemSet();
			Hashtable hashtable = new Hashtable();
			Hashtable hashtable2 = new Hashtable();
			Hashtable hashtable3 = new Hashtable();
			CategorySet categorySet = new CategorySet();
			Element element = new Element();
			Category category = new Category();
			string commandText = "Select CounterItemID,Name,ItemType,StartDate,EndDate,BaseVersion,DiffVersion,BaseItem,DiffItem,ToBeCount,ServerName,ServerPort,ServerType,Reserved from CounterItem";
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			connection.Open();
			DataSet dataSet = new DataSet();
			IDbDataAdapter dataAdapter = this.getDataAdapter();
			dataAdapter.SelectCommand = command;
			dataAdapter.Fill(dataSet);
			foreach (object obj in dataSet.Tables[0].Rows)
			{
				DataRow dataRow = (DataRow)obj;
				hashtable2 = new Hashtable();
				hashtable3 = new Hashtable();
				hashtable = new Hashtable();
				commandText = "Select ElementID,Include,ElementType,ServerPath,CounterItemID from Element where CounterItemID = '" + dataRow["CounterItemID"].ToString() + "'";
				command = this.getCommand();
				command.CommandText = commandText;
				command.Connection = connection;
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
				}
				IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
				ElementSet elementSet = new ElementSet();
				ElementSet elementSet2 = new ElementSet();
				while (dataReader.Read())
				{
					hashtable2 = new Hashtable();
					element = new Element();
					hashtable2.Add("ElementID", dataReader["ElementID"]);
					hashtable2.Add("Include", dataReader["Include"]);
					hashtable2.Add("ElementType", dataReader["ElementType"]);
					hashtable2.Add("ServerPath", dataReader["ServerPath"]);
					hashtable2.Add("CounterItemID", dataReader["CounterItemID"]);
					element.LoadObject(hashtable2);
					if ((bool)dataReader["Include"])
					{
						elementSet.Add(element);
					}
					else
					{
						elementSet2.Add(element);
					}
				}
				dataReader.Close();
				categorySet = new CategorySet();
				commandText = "Select [Category].[CategoryID],[Category].[CategoryName],[Category].[GroupID],[Group].[GroupName] from ( [Category] Inner Join [CounterCategory] On [Category].[CategoryID] = [CounterCategory].[CategoryID]) Inner Join [Group] On [Category].[GroupID] = [Group].[GroupID] where [CounterCategory].[CounterItemID] = '" + dataRow["CounterItemID"].ToString() + "'";
				command = this.getCommand();
				command.CommandText = commandText;
				command.Connection = connection;
				dataReader.Close();
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
				}
				dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
				while (dataReader.Read())
				{
					hashtable3 = new Hashtable();
					hashtable3.Add("CategoryID", dataReader["CategoryID"]);
					hashtable3.Add("CategoryName", dataReader["CategoryName"]);
					Hashtable hashtable4 = new Hashtable();
					hashtable4.Add("GroupID", dataReader["GroupID"]);
					hashtable4.Add("GroupName", dataReader["GroupName"]);
					GroupItem groupItem = new GroupItem();
					groupItem.LoadObject(hashtable4);
					hashtable3.Add("Group", groupItem);
					category = new Category();
					category.LoadObject(hashtable3);
					categorySet.Add(category);
				}
				hashtable.Add("CounterItemID", dataRow["CounterItemID"]);
				hashtable.Add("Name", dataRow["Name"]);
				hashtable.Add("ItemType", dataRow["ItemType"]);
				hashtable.Add("StartDate", (dataRow["StartDate"] == DBNull.Value) ? DateTime.MinValue : dataRow["StartDate"]);
				hashtable.Add("EndDate", (dataRow["EndDate"] == DBNull.Value) ? DateTime.MinValue : dataRow["EndDate"]);
				hashtable.Add("BaseVersion", dataRow["BaseVersion"]);
				hashtable.Add("DiffVersion", dataRow["DiffVersion"]);
				hashtable.Add("BaseItem", dataRow["BaseItem"]);
				hashtable.Add("DiffItem", dataRow["DiffItem"]);
				hashtable.Add("ToBeCount", dataRow["ToBeCount"]);
				hashtable.Add("ServerName", dataRow["ServerName"]);
				hashtable.Add("ServerPort", dataRow["ServerPort"]);
				hashtable.Add("ServerType", dataRow["ServerType"]);
				Regex regex = new Regex("@PSP-Metrics:((\\w)*)!");
				if (regex.IsMatch(dataRow["Reserved"].ToString()))
				{
					int num = dataRow["Reserved"].ToString().IndexOf("PSP-Metrics:") + 12;
					int num2 = dataRow["Reserved"].ToString().IndexOf('!', num);
					hashtable.Add("PspMetrics", dataRow["Reserved"].ToString().Substring(num, num2 - num));
				}
				else
				{
					hashtable.Add("PspMetrics", "False");
				}
				regex = new Regex("@Standard-Report:((\\w)*)!");
				if (regex.IsMatch(dataRow["Reserved"].ToString()))
				{
					int num = dataRow["Reserved"].ToString().IndexOf("Standard-Report:") + 16;
					int num2 = dataRow["Reserved"].ToString().IndexOf('!', num);
					hashtable.Add("StandardReport", dataRow["Reserved"].ToString().Substring(num, num2 - num));
				}
				else
				{
					hashtable.Add("StandardReport", "True");
				}
				regex = new Regex("@M-Report:((\\w)*)!");
				if (regex.IsMatch(dataRow["Reserved"].ToString()))
				{
					int num = dataRow["Reserved"].ToString().IndexOf("M-Report:") + 9;
					int num2 = dataRow["Reserved"].ToString().IndexOf('!', num);
					hashtable.Add("MReport", dataRow["Reserved"].ToString().Substring(num, num2 - num));
				}
				else
				{
					hashtable.Add("MReport", "False");
				}
				hashtable.Add("CategoryList", categorySet);
				hashtable.Add("IncludeElementSet", elementSet);
				hashtable.Add("ExcludeElementSet", elementSet2);
				CounterItem counterItem = new CounterItem();
				counterItem.LoadObject(hashtable);
				counterItemSet.Add(counterItem);
				dataReader.Close();
			}
			connection.Close();
			return counterItemSet;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005640 File Offset: 0x00004640
		public Hashtable GetAllServerOrPort(string guid, string type)
		{
			string arg = "";
			if (guid != null)
			{
				if (!(guid == "VSTF"))
				{
					if (!(guid == "SD"))
					{
						if (!(guid == "VSS"))
						{
							if (guid == "FS")
							{
								arg = AppConfigurationManager.guid_FS;
							}
						}
						else
						{
							arg = AppConfigurationManager.guid_VSS;
						}
					}
					else
					{
						arg = AppConfigurationManager.guid_SD;
					}
				}
				else
				{
					arg = AppConfigurationManager.guid_VSTF;
				}
			}
			int num = 0;
			Hashtable hashtable = new Hashtable();
			string commandText = string.Format("Select SettingValue from PersonalSetting where personalSettingID='{0}' and SettingName='{1}' Order By SettingValue DESC", arg, type);
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			connection.Open();
			IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
			while (dataReader.Read())
			{
				hashtable.Add(num, dataReader[0]);
				num++;
			}
			dataReader.Close();
			dataReader.Dispose();
			connection.Close();
			return hashtable;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005750 File Offset: 0x00004750
		public string AddServerOrPort(string guid, string type, string value)
		{
			string result = "";
			string arg = "";
			if (guid != null)
			{
				if (!(guid == "VSTF"))
				{
					if (!(guid == "SD"))
					{
						if (!(guid == "VSS"))
						{
							if (guid == "FS")
							{
								arg = AppConfigurationManager.guid_FS;
							}
						}
						else
						{
							arg = AppConfigurationManager.guid_VSS;
						}
					}
					else
					{
						arg = AppConfigurationManager.guid_SD;
					}
				}
				else
				{
					arg = AppConfigurationManager.guid_VSTF;
				}
			}
			Hashtable hashtable = new Hashtable();
			string commandText = string.Format("Insert into PersonalSetting(personalSettingID,SettingName,SettingValue) values('{0}','{1}','{2}')", arg, type, value);
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				result = ex.ToString();
				connection.Close();
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005858 File Offset: 0x00004858
		public CategorySet GetAllCategory()
		{
			CategorySet categorySet = new CategorySet();
			string commandText = "Select CategoryID,CategoryName,[Group].GroupID,[Group].GroupName from Category Inner Join [Group] on Category.GroupID = [Group].GroupID";
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			connection.Open();
			IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
			while (dataReader.Read())
			{
				GroupItem groupItem = new GroupItem();
				Hashtable hashtable = new Hashtable();
				Hashtable hashtable2 = new Hashtable();
				hashtable.Add("GroupID", dataReader["GroupID"]);
				hashtable.Add("GroupName", dataReader["GroupName"]);
				groupItem.LoadObject(hashtable);
				hashtable.Add("CategoryID", dataReader["CategoryID"]);
				hashtable.Add("CategoryName", dataReader["CategoryName"]);
				hashtable.Add("Group", groupItem);
				Category category = new Category();
				category.LoadObject(hashtable);
				categorySet.Add(category);
			}
			dataReader.Close();
			dataReader.Dispose();
			return categorySet;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005980 File Offset: 0x00004980
		public GroupItemSet GetAllGroups()
		{
			GroupItemSet groupItemSet = new GroupItemSet();
			string cmdText = "Select GroupID,GroupName from [Group]";
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand(cmdText);
			command.Connection = connection;
			connection.Open();
			IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
			while (dataReader.Read())
			{
				Hashtable hashtable = new Hashtable();
				hashtable.Add("GroupID", dataReader["GroupID"]);
				hashtable.Add("GroupName", dataReader["GroupName"]);
				GroupItem groupItem = new GroupItem();
				groupItem.LoadObject(hashtable);
				groupItemSet.Add(groupItem);
			}
			dataReader.Close();
			dataReader.Dispose();
			return groupItemSet;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005A44 File Offset: 0x00004A44
		public bool RemoveCounterItem(CounterItem objCI)
		{
			bool result = false;
			ArrayList arrayList = new ArrayList();
			IDbConnection connection = this.getConnection();
			string cmdText = "Delete from Element where CounterItemID='" + objCI.CounterItemID + "'";
			IDbCommand command = this.getCommand(cmdText);
			arrayList.Add(command);
			cmdText = "Delete from CounterCategory where CounterItemID='" + objCI.CounterItemID + "'";
			command = this.getCommand(cmdText);
			arrayList.Add(command);
			cmdText = "Delete from CounterItem where CounterItemID='" + objCI.CounterItemID + "'";
			command = this.getCommand(cmdText);
			arrayList.Add(command);
			cmdText = "Delete from Raj where CounterItemID='" + objCI.CounterItemID + "'";
			command = this.getCommand(cmdText);
			arrayList.Add(command);
			connection.Open();
			IDbTransaction dbTransaction = connection.BeginTransaction();
			try
			{
				foreach (object obj in arrayList)
				{
					IDbCommand dbCommand = (IDbCommand)obj;
					dbCommand.Connection = connection;
					dbCommand.Transaction = dbTransaction;
					dbCommand.ExecuteNonQuery();
				}
				dbTransaction.Commit();
				result = true;
			}
			catch (Exception ex)
			{
				dbTransaction.Rollback();
				result = false;
			}
			connection.Close();
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005BC0 File Offset: 0x00004BC0
		public bool SaveCounterCountDetail(CounterCountDetailSet objCounterDetails)
		{
			bool result = false;
			ArrayList arrayList = new ArrayList();
			IDbConnection connection = this.getConnection();
			foreach (object obj in objCounterDetails)
			{
				CounterCountDetail counterCountDetail = (CounterCountDetail)obj;
				string cmdText = string.Concat(new string[]
				{
					"Select * from CounterCountDetail Where CounterItemID='",
					counterCountDetail.CounterItemID,
					"' and [Language] ='",
					counterCountDetail.Language,
					"'"
				});
				IDbCommand command = this.getCommand(cmdText);
				command.Connection = connection;
				connection.Open();
				IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
				if (dataReader.Read())
				{
					cmdText = string.Concat(new object[]
					{
						"Update CounterCountDetail Set Added=",
						counterCountDetail.Added.ToString(),
						",Modified=",
						counterCountDetail.Modified.ToString(),
						",Deleted=",
						counterCountDetail.Deleted,
						",Base=",
						counterCountDetail.Base.ToString(),
						" Where CounterItemID='",
						counterCountDetail.CounterItemID,
						"' and [Language]='",
						counterCountDetail.Language,
						"'"
					});
				}
				else
				{
					cmdText = string.Concat(new object[]
					{
						"Insert Into CounterCountDetail (CounterItemID,[Language],[Base],Added,Modified,Deleted) Values ('",
						counterCountDetail.CounterItemID,
						"','",
						counterCountDetail.Language,
						"',",
						counterCountDetail.Base.ToString(),
						",",
						counterCountDetail.Added.ToString(),
						",",
						counterCountDetail.Modified.ToString(),
						",",
						counterCountDetail.Deleted,
						")"
					});
				}
				connection.Close();
				dataReader.Close();
				command = this.getCommand(cmdText);
				arrayList.Add(command);
			}
			connection.Open();
			IDbTransaction dbTransaction = connection.BeginTransaction();
			try
			{
				foreach (object obj2 in arrayList)
				{
					IDbCommand dbCommand = (IDbCommand)obj2;
					dbCommand.Connection = connection;
					dbCommand.Transaction = dbTransaction;
					dbCommand.ExecuteNonQuery();
				}
				dbTransaction.Commit();
				result = true;
			}
			catch (Exception ex)
			{
				dbTransaction.Rollback();
				result = false;
			}
			connection.Close();
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005F30 File Offset: 0x00004F30
		public bool RemoveCategory(Category objCategory, out string sMessage)
		{
			bool flag = false;
			sMessage = "";
			IDbConnection connection = this.getConnection();
			string text = "Select GroupID from Category Where CategoryID = '" + objCategory.CategoryID + "'";
			IDbCommand command = this.getCommand(text);
			command.Connection = connection;
			connection.Open();
			string str = command.ExecuteScalar().ToString();
			text = "Select Count(*) from Category Where GroupID = '" + str + "'";
			command = this.getCommand(text);
			command.Connection = connection;
			int num = (int)command.ExecuteScalar();
			bool result;
			if (num < 2)
			{
				connection.Close();
				sMessage = "At least one category is needed in the group!";
				result = flag;
			}
			else
			{
				text = "Select Count(CounterItemID) from CounterCategory Where CategoryID = '" + objCategory.CategoryID + "'";
				command = this.getCommand(text);
				command.Connection = connection;
				num = (int)command.ExecuteScalar();
				if (num > 0)
				{
					text = "";
					flag = false;
					sMessage = "Can not delete. Reference exists in Counter Item";
				}
				else
				{
					text = "Delete from Category where CategoryID='" + objCategory.CategoryID + "'";
					command = this.getCommand(text);
				}
				if (!string.IsNullOrEmpty(text))
				{
					command.Connection = connection;
					command.ExecuteNonQuery();
					flag = true;
				}
				connection.Close();
				result = flag;
			}
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000608C File Offset: 0x0000508C
		public bool SaveCategorySet(CategorySet objCategories)
		{
			bool result = false;
			ArrayList arrayList = new ArrayList();
			IDbConnection connection = this.getConnection();
			foreach (object obj in objCategories)
			{
				Category category = (Category)obj;
				string text = "";
				if (category.IsNew)
				{
					text = string.Concat(new string[]
					{
						"Insert Into Category (CategoryID,CategoryName,GroupID) Values ('",
						category.CategoryID,
						"','",
						category.CategoryName,
						"','",
						category.Group.GroupID,
						"')"
					});
				}
				else if (category.IsDirty)
				{
					text = string.Concat(new string[]
					{
						"Update Category Set CategoryName = '",
						category.CategoryName,
						"',GroupID='",
						category.Group.GroupID,
						"' Where CategoryID = '",
						category.CategoryID,
						"'"
					});
				}
				if (!string.IsNullOrEmpty(text))
				{
					IDbCommand command = this.getCommand(text);
					arrayList.Add(command);
				}
			}
			connection.Open();
			IDbTransaction dbTransaction = connection.BeginTransaction();
			try
			{
				foreach (object obj2 in arrayList)
				{
					IDbCommand dbCommand = (IDbCommand)obj2;
					dbCommand.Connection = connection;
					dbCommand.Transaction = dbTransaction;
					dbCommand.ExecuteNonQuery();
				}
				dbTransaction.Commit();
				result = true;
			}
			catch (Exception ex)
			{
				dbTransaction.Rollback();
				result = false;
			}
			connection.Close();
			foreach (object obj3 in objCategories)
			{
				Category category = (Category)obj3;
				category.Saved = true;
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006358 File Offset: 0x00005358
		public bool InsertResult(CounterItem item, long csharpNum, long cplusNum, long sqlNum, long vbnetNum, long webFilesNum, long xmlFilesNum)
		{
			bool result = true;
			string commandText = string.Format("Insert into Raj([CounterItemID],[Name],[ReleaseName],[ApplicationName],[MethodlogyName],[C#],[C++],[SQL],[VB NET],[Web files],[Xml files]) values('{0}','{1}','{2}','{3}','{4}',{5},{6},{7},{8},{9},{10})", new object[]
			{
				item.CounterItemID,
				item.Name,
				item.CategoryList[0].CategoryName,
				item.CategoryList[1].CategoryName,
				item.CategoryList[2].CategoryName,
				csharpNum,
				cplusNum,
				sqlNum,
				vbnetNum,
				webFilesNum,
				xmlFilesNum
			});
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				result = false;
				connection.Close();
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006474 File Offset: 0x00005474
		public bool UpdateResult(CounterItem item, long csharpNum, long cplusNum, long sqlNum, long vbnetNum, long webFilesNum, long xmlFilesNum)
		{
			bool result = true;
			string commandText = string.Format("Update Raj set [Name]='{0}',[ReleaseName]='{1}',[ApplicationName]='{2}',[MethodlogyName]='{3}',[C#]={4},[C++]={5},[SQL]={6},[VB NET]={7},[Web files]={8},[Xml files]={9} where [CounterItemID]='{10}'", new object[]
			{
				item.Name,
				item.CategoryList[0].CategoryName,
				item.CategoryList[1].CategoryName,
				item.CategoryList[2].CategoryName,
				csharpNum,
				cplusNum,
				sqlNum,
				vbnetNum,
				webFilesNum,
				xmlFilesNum,
				item.CounterItemID
			});
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				result = false;
				connection.Close();
			}
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006590 File Offset: 0x00005590
		public bool TaskInDataBase(string counterItemID)
		{
			string commandText = string.Format("select * from Raj where [CounterItemID]='{0}'", counterItemID);
			IDbConnection connection = this.getConnection();
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			connection.Open();
			IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
			bool result;
			if (dataReader.Read())
			{
				dataReader.Close();
				dataReader.Dispose();
				result = true;
			}
			else
			{
				dataReader.Close();
				dataReader.Dispose();
				result = false;
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006618 File Offset: 0x00005618
		public string GetDbFileVersion()
		{
			string commandText = "Select [PersonalSettingID],[SettingName],[SettingValue],[Backup] from [PersonalSetting] where [PersonalSettingID]='8e89e2a4-1574-4738-a220-15bacff21d38'";
			IDbConnection connection = this.getConnection();
			string result = "";
			IDbCommand command = this.getCommand();
			command.CommandText = commandText;
			command.Connection = connection;
			connection.Open();
			try
			{
				IDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
				if (dataReader.Read())
				{
					result = dataReader["SettingValue"].ToString();
				}
				dataReader.Close();
				dataReader.Dispose();
			}
			finally
			{
				connection.Close();
				connection.Dispose();
			}
			return result;
		}
	}
}
