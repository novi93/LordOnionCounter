using System;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.Manager
{
	// Token: 0x0200000B RID: 11
	public class ConfigManager
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00007390 File Offset: 0x00006390
		public void SaveCounterItemSet(CounterItemSet itemSet, ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			dataManager.SaveCounterItemSet(itemSet);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000073B0 File Offset: 0x000063B0
		public CounterItemSet LoadCounterItemSet(ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			return dataManager.LoadCounterItemSet();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000073D4 File Offset: 0x000063D4
		public CategorySet GetAllCategory(ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			return dataManager.GetAllCategory();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000073F4 File Offset: 0x000063F4
		public GroupItemSet GetAllGroups(ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			return dataManager.GetAllGroups();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007414 File Offset: 0x00006414
		public bool RemoveCounterItem(CounterItem objCI, ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			return dataManager.RemoveCounterItem(objCI);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007434 File Offset: 0x00006434
		public bool SaveCounterCountDetail(CounterCountDetailSet objCounterDetails, ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			return dataManager.SaveCounterCountDetail(objCounterDetails);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007454 File Offset: 0x00006454
		public bool RemoveCategory(Category objCategory, out string sMessage, ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			return dataManager.RemoveCategory(objCategory, out sMessage);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007478 File Offset: 0x00006478
		public bool SaveCategories(CategorySet objCategories, ExecutionMode eMode)
		{
			DataManager dataManager = new DataManager(eMode);
			return dataManager.SaveCategorySet(objCategories);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007498 File Offset: 0x00006498
		public bool InsertResult(CounterItem item, long csharpNum, long cplusNum, long sqlNum, long vbnetNum, long webFilesNum, long xmlFilesNum)
		{
			DataManager dataManager = new DataManager(ExecutionMode.StandAlone);
			return dataManager.InsertResult(item, csharpNum, cplusNum, sqlNum, vbnetNum, webFilesNum, xmlFilesNum);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000074C4 File Offset: 0x000064C4
		public bool UpdateResult(CounterItem item, long csharpNum, long cplusNum, long sqlNum, long vbnetNum, long webFilesNum, long xmlFilesNum)
		{
			DataManager dataManager = new DataManager(ExecutionMode.StandAlone);
			return dataManager.UpdateResult(item, csharpNum, cplusNum, sqlNum, vbnetNum, webFilesNum, xmlFilesNum);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000074F0 File Offset: 0x000064F0
		public bool CheckTaskIn(string counterItemID)
		{
			DataManager dataManager = new DataManager(ExecutionMode.StandAlone);
			return dataManager.TaskInDataBase(counterItemID);
		}
	}
}
