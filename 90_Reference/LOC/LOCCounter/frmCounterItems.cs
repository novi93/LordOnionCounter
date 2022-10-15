using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;
using MS.IT.LOC.UI.CounterDataDataSetTableAdapters;

namespace MS.IT.LOC.UI
{
    // Token: 0x0200000B RID: 11
    public partial class frmCounterItems : Form
    {
        // Token: 0x06000040 RID: 64 RVA: 0x00006908 File Offset: 0x00005908
        public frmCounterItems()
        {
            this.InitializeComponent();
            this.lvwColumnSorter = new ListViewColumnSorter();
            this.lvwColumnSorter.SortColumn = 1;
            this.lvwColumnSorter.Order = SortOrder.Ascending;
            this.lvwCounterItems.ListViewItemSorter = this.lvwColumnSorter;
            frmCounterItems.m_SourceControlManager.m_IsConnected = false;
        }

        // Token: 0x06000041 RID: 65 RVA: 0x0000697C File Offset: 0x0000597C
        private void loadCategories()
        {
            this.objCategorySet = frmCounterItems.m_ConfigManager.GetAllCategory(ExecutionMode.StandAlone);
            CategorySet filteredCategorySet = this.objCategorySet.GetFilteredCategorySet(this.objGroupSet[0].GroupID);
            this.cboQuarter.Items.Clear();
            this.cboQuarter.Items.Add("<All>");
            foreach (object obj in filteredCategorySet)
            {
                Category item = (Category)obj;
                this.cboQuarter.Items.Add(item);
            }
            this.cboApplication.Items.Clear();
            this.cboApplication.Items.Add("<All>");
            filteredCategorySet = this.objCategorySet.GetFilteredCategorySet(this.objGroupSet[1].GroupID);
            foreach (object obj2 in filteredCategorySet)
            {
                Category item = (Category)obj2;
                this.cboApplication.Items.Add(item);
            }
            this.cboMethodology.Items.Clear();
            this.cboMethodology.Items.Add("<All>");
            filteredCategorySet = this.objCategorySet.GetFilteredCategorySet(this.objGroupSet[2].GroupID);
            foreach (object obj3 in filteredCategorySet)
            {
                Category item = (Category)obj3;
                this.cboMethodology.Items.Add(item);
            }
            this.cboQuarter.SelectedIndex = 0;
            this.cboApplication.SelectedIndex = 0;
            this.cboMethodology.SelectedIndex = 0;
            this.findWidthForDropDown(this.cboQuarter);
            this.findWidthForDropDown(this.cboApplication);
            this.findWidthForDropDown(this.cboMethodology);
        }

        // Token: 0x06000042 RID: 66 RVA: 0x00006BD0 File Offset: 0x00005BD0
        private bool CheckForModified()
        {
            bool flag = false;
            foreach (object obj in this.CISet)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.IsDirty)
                {
                    flag = true;
                }
                foreach (object obj2 in counterItem.ExcludeElementSet)
                {
                    Element element = (Element)obj2;
                    if (element.IsDirty)
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (object obj3 in counterItem.IncludeElementSet)
                {
                    Element element = (Element)obj3;
                    if (element.IsDirty)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (flag)
            {
                this.Text = ((this.Text.Substring(this.Text.Length - 1, 1) == "*") ? this.Text : (this.Text + " *"));
            }
            else
            {
                this.Text = ((this.Text.Substring(this.Text.Length - 1, 1) == "*") ? this.Text.Substring(0, this.Text.Length - 2) : this.Text);
            }
            if (this.lvwCounterItems.Items.Count <= 0 || this.lvwCounterItems.SelectedItems.Count <= 0)
            {
                this.propertyGrid1.SelectedObject = null;
            }
            return flag;
        }

        // Token: 0x06000043 RID: 67 RVA: 0x00006E44 File Offset: 0x00005E44
        private string GetServerTypeName(SourceServerType vssType)
        {
            string result;
            switch (vssType)
            {
                case SourceServerType.VSTF:
                    result = "VSTF";
                    break;
                case SourceServerType.VSS:
                    result = "VSS";
                    break;
                case SourceServerType.SD:
                    result = "SD";
                    break;
                case SourceServerType.FILESYS:
                    result = "FS";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }

        // Token: 0x06000044 RID: 68 RVA: 0x00006E98 File Offset: 0x00005E98
        private void loadCounterItems(CounterItemSet objCISet)
        {
            this.lvwCounterItems.Items.Clear();
            if (objCISet != null)
            {
                foreach (object obj in objCISet)
                {
                    CounterItem counterItem = (CounterItem)obj;
                    string serverTypeName = this.GetServerTypeName(counterItem.ServerType);
                    string text = string.Empty;
                    switch (counterItem.Type)
                    {
                        case CIType.DATE_RANGE:
                            text = "Date Range";
                            break;
                        case CIType.LATEST:
                            text = "Latest";
                            break;
                        case CIType.LABEL_CHANGESET:
                            text = "Label/Changeset";
                            break;
                        case CIType.ITEM_FOLDER:
                            text = "Item/Folder";
                            break;
                        case CIType.BASEDTO_LABEL_CHANGESET:
                            text = "Label/Changeset";
                            break;
                        case CIType.DIFF_PREVIOUS:
                            text = "Previous";
                            break;
                        case CIType.LATEST_SET:
                            text = "Latest Set";
                            break;
                        case CIType.LATEST_WORKITEM:
                            text = "Latest WorkItem";
                            break;
                        default:
                            text = "Not known";
                            break;
                    }
                    ListViewItem listViewItem = new ListViewItem(new string[]
                    {
                        "",
                        counterItem.Name,
                        text,
                        counterItem.Configured,
                        counterItem.ServerName,
                        serverTypeName
                    });
                    if (counterItem.ToBeCount)
                    {
                        listViewItem.Checked = true;
                    }
                    else
                    {
                        listViewItem.Checked = false;
                    }
                    this.lvwCounterItems.Items.Add(listViewItem);
                    listViewItem.Tag = counterItem.CounterItemID;
                }
            }
        }

        // Token: 0x06000045 RID: 69 RVA: 0x00007040 File Offset: 0x00006040
        private void deleteCounterItem()
        {
            if (this.lvwCounterItems.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Do you really want to remove the counter item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    CounterItem counterItem = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()];
                    bool flag = counterItem.IsNew || frmCounterItems.m_ConfigManager.RemoveCounterItem(counterItem, ExecutionMode.StandAlone);
                    if (flag)
                    {
                        this.CISet.Remove(counterItem);
                        int index = this.lvwCounterItems.SelectedItems[0].Index;
                        this.lvwCounterItems.SelectedItems[0].Remove();
                        if (index > 1)
                        {
                            this.lvwCounterItems.Items[index - 1].Selected = true;
                        }
                        this.CheckForModified();
                        if (this.lvwCounterItems.Items.Count > 0)
                        {
                            this.lvwCounterItems.Items[0].Selected = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to remove..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            else
            {
                this.showSelectMesssage();
            }
        }

        // Token: 0x06000046 RID: 70 RVA: 0x000071A4 File Offset: 0x000061A4
        private void addCounterItem()
        {
            this.objCounterForm = new frmCounterItem(frmCounterItem.FormMode.AddMode, this.CISet);
            this.objCounterForm.Groups = this.objGroupSet;
            this.objCounterForm.Categories = this.objCategorySet;
            this.objCounterForm.ShowDialog();
            if (this.objCounterForm.IsFormOk)
            {
                string text;
                switch (this.objCounterForm.CurrentCounterItem.Type)
                {
                    case CIType.DATE_RANGE:
                        text = "Date Range";
                        break;
                    case CIType.LATEST:
                        text = "Latest";
                        break;
                    case CIType.LABEL_CHANGESET:
                        text = "Label/Changeset";
                        break;
                    case CIType.ITEM_FOLDER:
                        text = "Item/Folder";
                        break;
                    case CIType.BASEDTO_LABEL_CHANGESET:
                        text = "Label/Changeset";
                        break;
                    case CIType.DIFF_PREVIOUS:
                        text = "Previous";
                        break;
                    case CIType.LATEST_SET:
                        text = "Latest Set";
                        break;
                    case CIType.LATEST_WORKITEM:
                        text = "Latest WorkItem";
                        break;
                    default:
                        text = "Not known";
                        break;
                }
                this.CISet.Add(this.objCounterForm.CurrentCounterItem);
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    "",
                    this.objCounterForm.CurrentCounterItem.Name,
                    text,
                    this.objCounterForm.CurrentCounterItem.Configured,
                    this.objCounterForm.CurrentCounterItem.ServerName,
                    this.GetServerTypeName(this.objCounterForm.CurrentCounterItem.ServerType)
                });
                if (this.objCounterForm.CurrentCounterItem.ToBeCount)
                {
                    listViewItem.Checked = true;
                }
                else
                {
                    listViewItem.Checked = false;
                }
                listViewItem.Tag = this.objCounterForm.CurrentCounterItem.CounterItemID;
                this.lvwCounterItems.Items.Add(listViewItem);
                listViewItem.Selected = true;
                this.FilterTasksList();
            }
            this.objCounterForm.Dispose();
            this.CheckForModified();
            this.SelectTask(this.objCounterForm.CurrentCounterItem);
        }

        // Token: 0x06000047 RID: 71 RVA: 0x000073A8 File Offset: 0x000063A8
        private void updateCounterItem()
        {
            if (this.lvwCounterItems.SelectedItems.Count > 0)
            {
                CounterItem currentCounterItem = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()];
                this.objCounterForm = new frmCounterItem(frmCounterItem.FormMode.UdateMode, this.CISet);
                this.objCounterForm.CurrentCounterItem = currentCounterItem;
                this.objCounterForm.Groups = this.objGroupSet;
                this.objCounterForm.Categories = this.objCategorySet;
                this.objCounterForm.ShowDialog();
                if (this.objCounterForm.IsFormOk)
                {
                    string text;
                    switch (this.objCounterForm.CurrentCounterItem.Type)
                    {
                        case CIType.DATE_RANGE:
                            text = "Date Range";
                            break;
                        case CIType.LATEST:
                            text = "Latest";
                            break;
                        case CIType.LABEL_CHANGESET:
                            text = "Label/Changeset";
                            break;
                        case CIType.ITEM_FOLDER:
                            text = "Item/Folder";
                            break;
                        case CIType.BASEDTO_LABEL_CHANGESET:
                            text = "Label/Changeset";
                            break;
                        case CIType.DIFF_PREVIOUS:
                            text = "Previous";
                            break;
                        case CIType.LATEST_SET:
                            text = "Latest Set";
                            break;
                        case CIType.LATEST_WORKITEM:
                            text = "Latest WorkItem";
                            break;
                        default:
                            text = "Not known";
                            break;
                    }
                    this.lvwCounterItems.SelectedItems[0].SubItems[1].Text = this.objCounterForm.CounterItemName;
                    this.lvwCounterItems.SelectedItems[0].SubItems[2].Text = text;
                    this.lvwCounterItems.SelectedItems[0].SubItems[3].Text = this.objCounterForm.CurrentCounterItem.Configured;
                    this.lvwCounterItems.SelectedItems[0].SubItems[4].Text = this.objCounterForm.CurrentCounterItem.ServerName;
                    this.lvwCounterItems.SelectedItems[0].SubItems[5].Text = this.GetServerTypeName(this.objCounterForm.CurrentCounterItem.ServerType);
                    this.FilterTasksList();
                }
                this.objCounterForm.Dispose();
                this.CheckForModified();
                this.SelectTask(this.objCounterForm.CurrentCounterItem);
            }
            else
            {
                this.showSelectMesssage();
            }
        }

        // Token: 0x06000048 RID: 72 RVA: 0x0000760C File Offset: 0x0000660C
        private void SelectTask(CounterItem ci)
        {
            if (ci != null)
            {
                for (int i = 0; i < this.lvwCounterItems.Items.Count; i++)
                {
                    if (this.lvwCounterItems.Items[i].SubItems[1].Text == ci.Name)
                    {
                        this.lvwCounterItems.Items[i].Selected = true;
                        break;
                    }
                }
                if (this.lvwCounterItems.Items.Count > 0 && (this.lvwCounterItems.SelectedItems == null || this.lvwCounterItems.SelectedItems.Count == 0))
                {
                    this.lvwCounterItems.Items[0].Selected = true;
                }
            }
        }

        // Token: 0x06000049 RID: 73 RVA: 0x000076F4 File Offset: 0x000066F4
        private void configureCounterItem()
        {
            if (this.lvwCounterItems.SelectedItems.Count > 0)
            {
                CounterItem counterItem = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()];
                ServerAccount serverAccount = frmCounterItems.serverAccountSet.Get(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType);
                bool flag;
                if (serverAccount == null)
                {
                    flag = frmCounterItems.m_SourceControlManager.LoginWithoutEvent(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, "", "");
                }
                else
                {
                    flag = frmCounterItems.m_SourceControlManager.LoginWithoutEvent(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, serverAccount.UserAccount, serverAccount.UserPassword);
                }
                if (!flag)
                {
                    frmUserLogin frmUserLogin = new frmUserLogin();
                    frmUserLogin.ShowDialog();
                    while (frmUserLogin.IsFormOk)
                    {
                        flag = frmCounterItems.m_SourceControlManager.LoginWithoutEvent(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, frmUserLogin.UserName, frmUserLogin.Password);
                        if (flag)
                        {
                            frmCounterItems.serverAccountSet.Add(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, frmUserLogin.UserName, frmUserLogin.Password);
                            break;
                        }
                        MessageBox.Show("Can't connect to the server", "LOC Counter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        frmUserLogin.ShowDialog();
                    }
                }
                if (flag)
                {
                    frmConfigure frmConfigure = (frmConfigure)frmCounterItems.m_SCIForms[this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()]];
                    if (frmConfigure == null)
                    {
                        this.objConfigure = new frmConfigure(this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()]);
                        frmCounterItems.m_SCIForms.Add(this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()], this.objConfigure);
                        this.objConfigure.ShowDialog();
                        frmCounterItems.connectFlag = frmCounterItems.m_SourceControlManager.m_IsConnected;
                        if (frmCounterItems.connectFlag)
                        {
                            frmCounterItems.serverUser = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerUser;
                            frmCounterItems.serverPassword = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerPassword;
                        }
                    }
                    else
                    {
                        frmConfigure.InitTree();
                        frmConfigure.ShowDialog();
                        frmCounterItems.connectFlag = frmCounterItems.m_SourceControlManager.m_IsConnected;
                        if (frmCounterItems.connectFlag)
                        {
                            frmCounterItems.serverUser = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerUser;
                            frmCounterItems.serverPassword = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerPassword;
                        }
                    }
                    this.lvwCounterItems.SelectedItems[0].SubItems[3].Text = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].Configured;
                    this.lvwCounterItems.SelectedItems[0].SubItems[4].Text = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerName;
                    switch (this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerType)
                    {
                        case SourceServerType.VSTF:
                            this.lvwCounterItems.SelectedItems[0].SubItems[5].Text = "VSTF";
                            break;
                        case SourceServerType.VSS:
                            this.lvwCounterItems.SelectedItems[0].SubItems[5].Text = "VSS";
                            break;
                        case SourceServerType.SD:
                            this.lvwCounterItems.SelectedItems[0].SubItems[5].Text = "SD";
                            break;
                        case SourceServerType.FILESYS:
                            this.lvwCounterItems.SelectedItems[0].SubItems[5].Text = "FS";
                            break;
                        default:
                            this.lvwCounterItems.SelectedItems[0].SubItems[5].Text = "";
                            break;
                    }
                    this.CheckForModified();
                    this.syncListView();
                }
            }
            else
            {
                this.showSelectMesssage();
            }
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00007C24 File Offset: 0x00006C24
        private void setAccountAndPassword()
        {
            frmUserLogin frmUserLogin = new frmUserLogin();
            if (this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerType == SourceServerType.VSS)
            {
                frmUserLogin.ShowDialog();
                if (frmUserLogin.IsFormOk)
                {
                    this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerUser = frmUserLogin.UserName;
                    this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerPassword = frmUserLogin.Password;
                }
                else
                {
                    this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerUser = "";
                    this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()].ServerPassword = "";
                }
            }
        }

        // Token: 0x0600004B RID: 75 RVA: 0x00007D53 File Offset: 0x00006D53
        private void showSelectMesssage()
        {
            MessageBox.Show("Please select any counter task", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Token: 0x0600004C RID: 76 RVA: 0x00007D6C File Offset: 0x00006D6C
        private bool canFormClose()
        {
            bool result = false;
            if (this.CheckForModified())
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the changes?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    frmCounterItems.m_ConfigManager.SaveCounterItemSet(this.CISet, ExecutionMode.StandAlone);
                    this.CheckForModified();
                    result = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    result = true;
                }
            }
            else
            {
                result = true;
            }
            return result;
        }

        // Token: 0x0600004D RID: 77 RVA: 0x00007DE4 File Offset: 0x00006DE4
        private void syncListView()
        {
            foreach (object obj in this.lvwCounterItems.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                CounterItem counterItem = this.CISet[listViewItem.Tag.ToString()];
                if (counterItem != null)
                {
                    string text;
                    switch (counterItem.Type)
                    {
                        case CIType.DATE_RANGE:
                            text = "Date Range";
                            break;
                        case CIType.LATEST:
                            text = "Latest";
                            break;
                        case CIType.LABEL_CHANGESET:
                            text = "Label/Changeset";
                            break;
                        case CIType.ITEM_FOLDER:
                            text = "Item/Folder";
                            break;
                        case CIType.BASEDTO_LABEL_CHANGESET:
                            text = "Label/Changeset";
                            break;
                        case CIType.DIFF_PREVIOUS:
                            text = "Previous";
                            break;
                        case CIType.LATEST_SET:
                            text = "Latest Set";
                            break;
                        case CIType.LATEST_WORKITEM:
                            text = "Latest WorkItem";
                            break;
                        default:
                            text = "Not known";
                            break;
                    }
                    listViewItem.SubItems[1].Text = counterItem.Name;
                    listViewItem.SubItems[2].Text = text;
                    listViewItem.SubItems[3].Text = counterItem.Configured;
                    listViewItem.Checked = counterItem.ToBeCount;
                }
            }
        }

        // Token: 0x0600004E RID: 78 RVA: 0x00007F58 File Offset: 0x00006F58
        internal void checkMode()
        {
            if (AppConfigurationManager.IsLocal)
            {
                this.kLOCByApplicationToolStripMenuItem.Enabled = true;
                this.kLOCByQuarterByApplicationToolStripMenuItem.Enabled = false;
                this.kLOCReportToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.kLOCByApplicationToolStripMenuItem.Enabled = true;
                this.kLOCByQuarterByApplicationToolStripMenuItem.Enabled = true;
                this.kLOCReportToolStripMenuItem.Enabled = true;
            }
        }

        // Token: 0x0600004F RID: 79 RVA: 0x00007FC8 File Offset: 0x00006FC8
        private int getFileSystemTypeNumber()
        {
            int num = 0;
            foreach (object obj in this.lvwCounterItems.CheckedItems)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                CounterItem counterItem = this.CISet[listViewItem.Tag.ToString()];
                if (counterItem != null)
                {
                    if (counterItem.ServerType == SourceServerType.FILESYS)
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        // Token: 0x06000050 RID: 80 RVA: 0x0000807C File Offset: 0x0000707C
        private bool isEnabledItemWithSameSource()
        {
            bool flag = true;
            string a = "";
            SourceServerType sourceServerType = SourceServerType.Base;
            bool flag2 = true;
            int fileSystemTypeNumber = this.getFileSystemTypeNumber();
            bool result;
            if (fileSystemTypeNumber < 2)
            {
                foreach (object obj in this.lvwCounterItems.CheckedItems)
                {
                    ListViewItem listViewItem = (ListViewItem)obj;
                    CounterItem counterItem = this.CISet[listViewItem.Tag.ToString()];
                    if (counterItem != null)
                    {
                        if (flag2)
                        {
                            a = counterItem.ServerName;
                            sourceServerType = counterItem.ServerType;
                            flag2 = false;
                        }
                        else if (a != counterItem.ServerName || sourceServerType != counterItem.ServerType)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (a == "")
                {
                    flag = false;
                }
                result = flag;
            }
            else
            {
                foreach (object obj2 in this.lvwCounterItems.CheckedItems)
                {
                    ListViewItem listViewItem = (ListViewItem)obj2;
                    CounterItem counterItem = this.CISet[listViewItem.Tag.ToString()];
                    if (counterItem != null)
                    {
                        if (flag2)
                        {
                            sourceServerType = counterItem.ServerType;
                            flag2 = false;
                        }
                        else if (sourceServerType != counterItem.ServerType)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                result = flag;
            }
            return result;
        }

        // Token: 0x06000051 RID: 81 RVA: 0x00008258 File Offset: 0x00007258
        private bool isConfiguredItemPresent()
        {
            bool result = false;
            foreach (object obj in this.lvwCounterItems.CheckedItems)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                CounterItem counterItem = this.CISet[listViewItem.Tag.ToString()];
                if (counterItem != null)
                {
                    if (counterItem.ExcludeElementSet.Count > 0 || counterItem.IncludeElementSet.Count > 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        // Token: 0x06000052 RID: 82 RVA: 0x00008320 File Offset: 0x00007320
        private bool isAllConfigured()
        {
            bool result = true;
            foreach (object obj in this.lvwCounterItems.CheckedItems)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                CounterItem counterItem = this.CISet[listViewItem.Tag.ToString()];
                if (counterItem != null)
                {
                    if (counterItem.Configured != "Yes")
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        // Token: 0x06000053 RID: 83 RVA: 0x000083D8 File Offset: 0x000073D8
        private bool canRunCounterEngine()
        {
            bool result;
            if (this.lvwCounterItems.CheckedItems.Count <= 0)
            {
                MessageBox.Show("No task is enabled to run the counter", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                result = false;
            }
            else if (!this.isConfiguredItemPresent())
            {
                MessageBox.Show("No enabled task is configured to run the counter", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                result = false;
            }
            else if (!this.isEnabledItemWithSameSource())
            {
                MessageBox.Show("All enabled tasks should be with the same source control server", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                result = false;
            }
            else if (!this.isAllConfigured())
            {
                MessageBox.Show("All enabled tasks should be configured", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                result = false;
            }
            else if (AppConfigurationManager.CurrentCountStandard == null)
            {
                MessageBox.Show("No usable countstandard file", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                result = false;
            }
            else
            {
                if (this.CheckForModified())
                {
                    frmCounterItems.m_ConfigManager.SaveCounterItemSet(this.CISet, ExecutionMode.StandAlone);
                    this.CheckForModified();
                }
                result = true;
            }
            return result;
        }

        // Token: 0x06000054 RID: 84 RVA: 0x000084DA File Offset: 0x000074DA
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addCounterItem();
        }

        // Token: 0x06000055 RID: 85 RVA: 0x000084E4 File Offset: 0x000074E4
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateCounterItem();
        }

        // Token: 0x06000056 RID: 86 RVA: 0x000084EE File Offset: 0x000074EE
        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x06000057 RID: 87 RVA: 0x000084F8 File Offset: 0x000074F8
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.deleteCounterItem();
        }

        // Token: 0x06000058 RID: 88 RVA: 0x00008502 File Offset: 0x00007502
        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.configureCounterItem();
        }

        // Token: 0x06000059 RID: 89 RVA: 0x0000850C File Offset: 0x0000750C
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmCounterItems.m_ConfigManager.SaveCounterItemSet(this.CISet, ExecutionMode.StandAlone);
            this.CheckForModified();
        }

        // Token: 0x0600005A RID: 90 RVA: 0x00008528 File Offset: 0x00007528
        private void frmCounterItems_Load(object sender, EventArgs e)
        {
            try
            {
                this.CISet = frmCounterItems.m_ConfigManager.LoadCounterItemSet(ExecutionMode.StandAlone);
                this.objGroupSet = frmCounterItems.m_ConfigManager.GetAllGroups(ExecutionMode.StandAlone);
            }
            catch
            {
                MessageBox.Show("An Exception exists during accessing to user's database! There must be some errors with the database file. Please delete the \"LOC Counter\" folder under your Documents directory manually. And, then try to execute the application again.", "LOC Counter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                base.Close();
                return;
            }
            this.loadCounterItems(this.CISet);
            this.loadCategories();
            this.checkMode();
            this.lvwCounterItems.Sort();
        }

        // Token: 0x0600005B RID: 91 RVA: 0x000085B4 File Offset: 0x000075B4
        private void btnCount_Click(object sender, EventArgs e)
        {
            AppConfigurationManager.SetDefaultStandard(ExecutionMode.StandAlone);
            if (this.canRunCounterEngine())
            {
                int fileSystemTypeNumber = this.getFileSystemTypeNumber();
                string a = "";
                int num = 0;
                int num2 = 0;
                string a2 = "";
                CounterItem counterItem = null;
                foreach (object obj in this.CISet.FilteredItems)
                {
                    CounterItem counterItem2 = (CounterItem)obj;
                    if (counterItem2.ToBeCount)
                    {
                        counterItem = counterItem2;
                        num++;
                        if (a == counterItem2.ServerName && a2 == counterItem2.ServerPort)
                        {
                            num2++;
                        }
                        a = counterItem2.ServerName;
                        SourceServerType serverType = counterItem2.ServerType;
                        if (counterItem2.ServerType == SourceServerType.FILESYS)
                        {
                            if (!Directory.Exists(counterItem2.ServerName))
                            {
                                MessageBox.Show("The path in the  type of FILESYS doesn't exist!");
                                return;
                            }
                        }
                        a2 = counterItem2.ServerPort;
                    }
                }
                if (num != num2 + 1)
                {
                    if (fileSystemTypeNumber < 2)
                    {
                        MessageBox.Show("The sever of the tasks to be counted should have the same name and port!");
                        return;
                    }
                }
                if (counterItem == null)
                {
                    MessageBox.Show("Can't get the task to be run");
                }
                else
                {
                    ServerAccount serverAccount = frmCounterItems.serverAccountSet.Get(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType);
                    bool flag;
                    if (serverAccount == null)
                    {
                        flag = frmCounterItems.m_SourceControlManager.LoginWithoutEvent(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, "", "");
                    }
                    else
                    {
                        flag = frmCounterItems.m_SourceControlManager.LoginWithoutEvent(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, serverAccount.UserAccount, serverAccount.UserPassword);
                    }
                    if (!flag)
                    {
                        frmUserLogin frmUserLogin = new frmUserLogin();
                        frmUserLogin.ShowDialog();
                        while (frmUserLogin.IsFormOk)
                        {
                            flag = frmCounterItems.m_SourceControlManager.LoginWithoutEvent(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, frmUserLogin.UserName, frmUserLogin.Password);
                            if (flag)
                            {
                                frmCounterItems.serverAccountSet.Add(counterItem.ServerName, counterItem.ServerPort, counterItem.ServerType, frmUserLogin.UserName, frmUserLogin.Password);
                                break;
                            }
                            MessageBox.Show("Can't connect to the server", "LOC Counter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            frmUserLogin.ShowDialog();
                        }
                    }
                    if (flag)
                    {
                        frmCounter frmCounter = new frmCounter(this.CISet.FilteredItems);
                        frmCounter.ShowDialog();
                        frmCounterItems.connectFlag = frmCounterItems.m_SourceControlManager.m_IsConnected;
                        if (frmCounter.countThread != null && frmCounter.countThread.IsAlive)
                        {
                            frmCounter.countThread.Abort();
                        }
                        if (frmCounter.closingThread != null && frmCounter.closingThread.IsAlive)
                        {
                            frmCounter.closingThread.Abort();
                        }
                        this.CheckForModified();
                        this.syncListView();
                    }
                }
            }
        }

        // Token: 0x0600005C RID: 92 RVA: 0x00008940 File Offset: 0x00007940
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.ShowDialog();
        }

        // Token: 0x0600005D RID: 93 RVA: 0x0000895C File Offset: 0x0000795C
        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.ShowDialog();
            if (frmCategory.CategoryUpdated)
            {
                this.loadCategories();
                this.syncListView();
            }
        }

        // Token: 0x0600005E RID: 94 RVA: 0x00008994 File Offset: 0x00007994
        private void lvwCounterItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.lvwCounterItems.SelectedItems.Count > 0)
            {
                CounterItem selectedObject = this.CISet[this.lvwCounterItems.SelectedItems[0].Tag.ToString()];
                this.propertyGrid1.SelectedObject = selectedObject;
            }
        }

        // Token: 0x0600005F RID: 95 RVA: 0x000089F2 File Offset: 0x000079F2
        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.CheckForModified();
            this.syncListView();
        }

        // Token: 0x06000060 RID: 96 RVA: 0x00008A04 File Offset: 0x00007A04
        private void FilterTasksList()
        {
            this.CISet.CategoryFilters.Clear();
            if (this.cboQuarter.Text != "<All>")
            {
                this.CISet.CategoryFilters.Add(this.cboQuarter.SelectedItem);
            }
            if (this.cboApplication.Text != "<All>")
            {
                this.CISet.CategoryFilters.Add(this.cboApplication.SelectedItem);
            }
            if (this.cboMethodology.Text != "<All>")
            {
                this.CISet.CategoryFilters.Add(this.cboMethodology.SelectedItem);
            }
            this.loadCounterItems(this.CISet.FilteredItems);
        }

        // Token: 0x06000061 RID: 97 RVA: 0x00008AE4 File Offset: 0x00007AE4
        private void cbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.CISet.CategoryFilters.Clear();
            if (this.cboQuarter.Text != "<All>")
            {
                this.CISet.CategoryFilters.Add(this.cboQuarter.SelectedItem);
            }
            if (this.cboApplication.Text != "<All>")
            {
                this.CISet.CategoryFilters.Add(this.cboApplication.SelectedItem);
            }
            if (this.cboMethodology.Text != "<All>")
            {
                this.CISet.CategoryFilters.Add(this.cboMethodology.SelectedItem);
            }
            this.loadCounterItems(this.CISet.FilteredItems);
        }

        // Token: 0x06000062 RID: 98 RVA: 0x00008BC3 File Offset: 0x00007BC3
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.deleteCounterItem();
        }

        // Token: 0x06000063 RID: 99 RVA: 0x00008BD0 File Offset: 0x00007BD0
        private void lvwCounterItems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Tag != null)
            {
                CounterItem counterItem = this.CISet[e.Item.Tag.ToString()];
                if (e.Item.Checked)
                {
                    if (!counterItem.ToBeCount)
                    {
                        counterItem.ToBeCount = true;
                    }
                }
                else if (counterItem.ToBeCount)
                {
                    counterItem.ToBeCount = false;
                }
                this.CheckForModified();
            }
        }

        // Token: 0x06000064 RID: 100 RVA: 0x00008C58 File Offset: 0x00007C58
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.addCounterItem();
        }

        // Token: 0x06000065 RID: 101 RVA: 0x00008C62 File Offset: 0x00007C62
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.updateCounterItem();
        }

        // Token: 0x06000066 RID: 102 RVA: 0x00008C6C File Offset: 0x00007C6C
        private void btnConfigure_Click(object sender, EventArgs e)
        {
            this.configureCounterItem();
        }

        // Token: 0x06000067 RID: 103 RVA: 0x00008C78 File Offset: 0x00007C78
        private void btnViewConfiguration_Click(object sender, EventArgs e)
        {
            frmShowCodingStandard frmShowCodingStandard = new frmShowCodingStandard();
            frmShowCodingStandard.ShowDialog();
        }

        // Token: 0x06000068 RID: 104 RVA: 0x00008C94 File Offset: 0x00007C94
        private void frmCounterItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.canFormClose())
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        // Token: 0x06000069 RID: 105 RVA: 0x00008CC8 File Offset: 0x00007CC8
        private void kLOCReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Test_ADDData_AX();
            new frmReportViewer
            {
                WindowState = FormWindowState.Maximized,
                ReportType = "KLOC Report",
                DataSource = this.CDS
            }.ShowDialog();
        }

        // Token: 0x0600006A RID: 106 RVA: 0x00008D0C File Offset: 0x00007D0C
        private void Test_ADDData_AX()
        {
            this.CDS = new CounterDataDataSet();
            this.CDS.TotalLOC.AddTotalLOCRow("AX", 2, 5, 2, 3, 2, 7);
            this.CDS.TotalLOC.AddTotalLOCRow("ZHZ", 2, 3, 2, 2, 7, 2);
            this.CDS.TotalLOC.AddTotalLOCRow("YJ", 2, 2, 2, 4, 2, 2);
            this.CDS.TotalLOC.AddTotalLOCRow("YF", 5, 2, 3, 3, 2, 2);
            this.CDS.ReportQuery1.AddReportQuery1Row("Hello", 1, 3, 2, 9, 4, 5);
            this.CDS.ReportQuery1.AddReportQuery1Row("Hell", 1, 5, 2, 3, 4, 5);
            this.CDS.ReportQuery1.AddReportQuery1Row("Hel", 1, 7, 2, 2, 2, 5);
            this.CDS.ReportQuery1.AddReportQuery1Row("He", 1, 3, 2, 3, 4, 6);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("12", "21", 1, 3, 2, 9, 4, 5);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("21", "21", 1, 5, 2, 3, 4, 5);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("12", "21", 1, 7, 2, 2, 2, 5);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("2", "12", 1, 3, 2, 3, 4, 6);
        }

        // Token: 0x0600006B RID: 107 RVA: 0x00008E8C File Offset: 0x00007E8C
        private void Test_NewData_AX()
        {
            this.CDS = new CounterDataDataSet();
            this.CDS.TotalLOC.AddTotalLOCRow("AX", 2, 5, 2, 3, 2, 7);
            this.CDS.TotalLOC.AddTotalLOCRow("ZHZ", 2, 3, 2, 2, 7, 2);
            this.CDS.TotalLOC.AddTotalLOCRow("YJ", 2, 2, 2, 4, 2, 2);
            this.CDS.TotalLOC.AddTotalLOCRow("YF", 5, 2, 3, 3, 2, 2);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("12", "21", 1, 3, 2, 9, 4, 5);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("21", "21", 1, 5, 2, 3, 4, 5);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("12", "21", 1, 7, 2, 2, 2, 5);
            this.CDS.ByQtrByApplication.AddByQtrByApplicationRow("2", "12", 1, 3, 2, 3, 4, 6);
        }

        // Token: 0x0600006C RID: 108 RVA: 0x00008F9C File Offset: 0x00007F9C
        private void kLOCByApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Test_NewData_AX();
            new frmReportViewer
            {
                WindowState = FormWindowState.Maximized,
                ReportType = "KLOC by Application",
                DataSource = this.CDS
            }.ShowDialog();
        }

        // Token: 0x0600006D RID: 109 RVA: 0x00008FE0 File Offset: 0x00007FE0
        private void kLOCByQuarterByApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReportViewer
            {
                WindowState = FormWindowState.Maximized,
                ReportType = "KLOC by Quarter by Application"
            }.ShowDialog();
        }

        // Token: 0x0600006E RID: 110 RVA: 0x00009010 File Offset: 0x00008010
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMode frmMode = new frmMode();
            frmMode.ShowDialog();
        }

        // Token: 0x0600006F RID: 111 RVA: 0x0000902C File Offset: 0x0000802C
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        // Token: 0x06000070 RID: 112 RVA: 0x00009048 File Offset: 0x00008048
        private void findWidthForDropDown(ComboBox comboBox)
        {
            bool flag = comboBox.DataSource != null && comboBox.DisplayMember != null && comboBox.DisplayMember != "";
            int num = comboBox.DropDownWidth;
            using (Graphics graphics = comboBox.CreateGraphics())
            {
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    string text;
                    if (flag)
                    {
                        text = (string)((DataRowView)comboBox.Items[i])[comboBox.DisplayMember];
                    }
                    else
                    {
                        text = comboBox.Items[i].ToString();
                    }
                    int num2 = (int)graphics.MeasureString(text, comboBox.Font).Width;
                    if (num2 > num)
                    {
                        num = num2;
                    }
                }
            }
            comboBox.DropDownWidth = num;
        }

        // Token: 0x06000071 RID: 113 RVA: 0x0000914C File Offset: 0x0000814C
        private void lvwCounterItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == this.lvwColumnSorter.SortColumn)
            {
                if (this.lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    this.lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    this.lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                this.lvwColumnSorter.SortColumn = e.Column;
                this.lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.lvwCounterItems.Sort();
        }

        // Token: 0x06000072 RID: 114 RVA: 0x000091DC File Offset: 0x000081DC
        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("LOC Counter User Guide.doc");
            }
            catch
            {
                MessageBox.Show("The help document can't be opened successfully! Make sure that you have installed Microsoft Office at first and the \"LOC Counter User Guide.doc\" is not destroyed.", "LOC Counter", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        // Token: 0x06000073 RID: 115 RVA: 0x00009224 File Offset: 0x00008224
        private void cboMethodology_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x04000076 RID: 118
        public CounterItemSet CISet = new CounterItemSet();

        // Token: 0x04000077 RID: 119
        private CategorySet objCategorySet;

        // Token: 0x04000078 RID: 120
        private GroupItemSet objGroupSet;

        // Token: 0x04000079 RID: 121
        private CounterDataDataSet CDS;

        // Token: 0x0400007A RID: 122
        private static bool connectFlag = false;

        // Token: 0x0400007B RID: 123
        private frmCounterItem objCounterForm;

        // Token: 0x0400007C RID: 124
        public static string serverUser = string.Empty;

        // Token: 0x0400007D RID: 125
        public static string serverPassword = string.Empty;

        // Token: 0x0400007E RID: 126
        private frmConfigure objConfigure;

        // Token: 0x0400007F RID: 127
        public static SourceControlManager m_SourceControlManager = new SourceControlManager();

        // Token: 0x04000080 RID: 128
        public static ConfigManager m_ConfigManager = new ConfigManager();

        // Token: 0x04000081 RID: 129
        public static LOCManager m_LOCManager = new LOCManager();

        // Token: 0x04000082 RID: 130
        public static Hashtable m_SCIForms = new Hashtable();

        // Token: 0x04000083 RID: 131
        private ListViewColumnSorter lvwColumnSorter;

        // Token: 0x04000084 RID: 132
        public static ServerAccountSet serverAccountSet = new ServerAccountSet();
    }
}
