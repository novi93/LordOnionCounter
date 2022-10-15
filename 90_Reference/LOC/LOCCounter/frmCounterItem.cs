using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000026 RID: 38
	public partial class frmCounterItem : Form
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0001B4B4 File Offset: 0x0001A4B4
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0001B4CC File Offset: 0x0001A4CC
		public CounterItem CurrentCounterItem
		{
			get
			{
				return this._CounterItem;
			}
			set
			{
				this._CounterItem = value;
				if (this._CounterItem != null)
				{
					this.UpdatingTaskName = this._CounterItem.Name;
				}
				else
				{
					this.UpdatingTaskName = "";
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0001B50C File Offset: 0x0001A50C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0001B524 File Offset: 0x0001A524
		public CategorySet Categories
		{
			get
			{
				return this.objCategorySet;
			}
			set
			{
				this.objCategorySet = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0001B530 File Offset: 0x0001A530
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0001B548 File Offset: 0x0001A548
		public GroupItemSet Groups
		{
			get
			{
				return this.objGroupSet;
			}
			set
			{
				this.objGroupSet = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0001B554 File Offset: 0x0001A554
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0001B578 File Offset: 0x0001A578
		public string CounterItemName
		{
			get
			{
				return this.txtCounterItem.Text.Trim();
			}
			set
			{
				if (this._mode == frmCounterItem.FormMode.UdateMode)
				{
					this.txtCounterItem.Text = value;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0001B5A8 File Offset: 0x0001A5A8
		public CIType CounterItemType
		{
			get
			{
				CIType result;
				if (this.rbtnDateRange.Checked)
				{
					result = CIType.DATE_RANGE;
				}
				else if (this.rbtnItemFolder.Checked)
				{
					result = CIType.ITEM_FOLDER;
				}
				else if (this.rbtnLabelChangeSet.Checked)
				{
					result = CIType.LABEL_CHANGESET;
				}
				else
				{
					result = CIType.LATEST;
				}
				return result;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0001B604 File Offset: 0x0001A604
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0001B63C File Offset: 0x0001A63C
		public DateTime FromDate
		{
			get
			{
				DateTime result;
				if (this.CounterItemType == CIType.DATE_RANGE)
				{
					result = this.dtpFromDate.Value;
				}
				else
				{
					result = DateTime.MinValue;
				}
				return result;
			}
			set
			{
				if (this._mode == frmCounterItem.FormMode.UdateMode)
				{
					this.dtpFromDate.Value = ((value == DateTime.MinValue) ? this.dtpFromDate.MinDate : value);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001B684 File Offset: 0x0001A684
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0001B6BC File Offset: 0x0001A6BC
		public DateTime ToDate
		{
			get
			{
				DateTime result;
				if (this.CounterItemType == CIType.DATE_RANGE)
				{
					result = this.dtpToDate.Value;
				}
				else
				{
					result = DateTime.MinValue;
				}
				return result;
			}
			set
			{
				if (this._mode == frmCounterItem.FormMode.UdateMode)
				{
					this.dtpToDate.Value = ((value == DateTime.MinValue) ? this.dtpToDate.MinDate : value);
				}
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001B704 File Offset: 0x0001A704
		public frmCounterItem(frmCounterItem.FormMode fMode, CounterItemSet CISet)
		{
			this._mode = fMode;
			this.InitializeComponent();
			if (this._mode == frmCounterItem.FormMode.AddMode)
			{
				this.Text = "New Counter Task";
			}
			else
			{
				this.Text = "Update Counter Task";
			}
			this.parentCISet = CISet;
			this.objCategorySet = new CategorySet();
			this.txtCounterItem.Focus();
			this.regNumber = new Regex("^[0-9]+$", RegexOptions.None);
			this.regVSTFServerName = new Regex("^[a-zA-Z-_0-9]+([.]+[a-zA-Z-_0-9]+)*$", RegexOptions.None);
			this.regSDServerName = new Regex("^[a-zA-Z-_0-9]+([.]+[a-zA-Z-_0-9]+)*$", RegexOptions.None);
			this.regLetterStartNormal = new Regex("^\\w+[a-zA-Z-_\0-9]*$", RegexOptions.None);
			this.regSdLabel = new Regex("^[a-zA-Z-$!:;?+= ()\\[\\]{}~_0-9]+$", RegexOptions.None);
			this.regFolder = new Regex("[\\*\\?\\\"<>|]+", RegexOptions.None);
			this.regNotVSTFLabel = new Regex("[\"/:<>\\|*\\?@]+", RegexOptions.None);
			this.LoadServerPort();
			this.txtWorkItem.Enabled = false;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001B834 File Offset: 0x0001A834
		private void LoadInit()
		{
			if (this._mode == frmCounterItem.FormMode.UdateMode)
			{
				this.sSaveInit[0] = this.CurrentCounterItem.ServerType.ToString();
				this.sSaveInit[1] = this.CurrentCounterItem.ServerName;
				this.sSaveInit[2] = this.CurrentCounterItem.ServerPort;
				if (this.rdoVSTF.Checked)
				{
					if (this.sSaveInit[0] == "VSTF")
					{
						this.combServerName.Text = this.sSaveInit[1];
						this.combPort.Text = this.sSaveInit[2];
					}
				}
				else if (this.rdoSD.Checked)
				{
					if (this.sSaveInit[0] == "SD")
					{
						this.combServerName.Text = this.sSaveInit[1];
						this.combPort.Text = this.sSaveInit[2];
					}
				}
				else if (this.rdoVSS.Checked)
				{
					if (this.sSaveInit[0] == "VSS")
					{
					}
				}
				else if (this.rdoFileSys.Checked)
				{
					if (this.sSaveInit[0] == "FILESYS")
					{
					}
				}
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001B9C0 File Offset: 0x0001A9C0
		private void LoadServerPort()
		{
			this.combServerName.Items.Clear();
			this.combPort.Items.Clear();
			this.cmbVSSDBPath.Items.Clear();
			this.comLatest.Items.Clear();
			this.cmbFSBase.Items.Clear();
			this.cmbFSDiff.Items.Clear();
			if (this.rdoVSTF.Checked)
			{
				this.sGuid = "VSTF";
			}
			else if (this.rdoSD.Checked)
			{
				this.sGuid = "SD";
			}
			else if (this.rdoVSS.Checked)
			{
				this.sGuid = "VSS";
			}
			else if (this.rdoFileSys.Checked)
			{
				this.sGuid = "FS";
			}
			this.haServerName = AppConfigurationManager.GetAllServerOrPort(this.sGuid, "Server");
			foreach (object obj in this.haServerName)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				this.combServerName.Items.Add(dictionaryEntry.Value.ToString().Trim());
			}
			this.haPort = AppConfigurationManager.GetAllServerOrPort(this.sGuid, "Port");
			foreach (object obj2 in this.haPort)
			{
				DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj2;
				this.combPort.Items.Add(dictionaryEntry2.Value.ToString().Trim());
			}
			this.haVSSDBPath = AppConfigurationManager.GetAllServerOrPort(this.sGuid, "VSSPath");
			foreach (object obj3 in this.haVSSDBPath)
			{
				DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj3;
				this.cmbVSSDBPath.Items.Add(dictionaryEntry2.Value.ToString().Trim());
			}
			this.haLatest = AppConfigurationManager.GetAllServerOrPort(this.sGuid, "Latest");
			foreach (object obj4 in this.haLatest)
			{
				DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj4;
				this.comLatest.Items.Add(dictionaryEntry2.Value.ToString().Trim());
			}
			this.haFSBase = AppConfigurationManager.GetAllServerOrPort(this.sGuid, "FSBase");
			foreach (object obj5 in this.haFSBase)
			{
				DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj5;
				this.cmbFSBase.Items.Add(dictionaryEntry2.Value.ToString().Trim());
			}
			this.haFSDiff = AppConfigurationManager.GetAllServerOrPort(this.sGuid, "FSDiff");
			foreach (object obj6 in this.haFSDiff)
			{
				DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj6;
				this.cmbFSDiff.Items.Add(dictionaryEntry2.Value.ToString().Trim());
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001BDEC File Offset: 0x0001ADEC
		private void plotCategories()
		{
			int num = 5;
			int num2 = 22;
			int num3 = 157;
			int num4 = 75;
			foreach (object obj in this.objGroupSet)
			{
				GroupItem groupItem = (GroupItem)obj;
				Label label = new Label();
				label.Name = "lbl" + groupItem;
				ComboBox comboBox = new ComboBox();
				label.Text = groupItem.GroupName + " *";
				label.AutoSize = true;
				CategorySet filteredCategorySet = this.objCategorySet.GetFilteredCategorySet(groupItem.GroupID);
				comboBox.Name = "cbo" + groupItem.GroupName;
				comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
				foreach (object obj2 in filteredCategorySet)
				{
					Category category = (Category)obj2;
					comboBox.Items.Add(category);
					if (this._mode == frmCounterItem.FormMode.UdateMode)
					{
						if (this._CounterItem.CategoryList.Contains(category))
						{
							comboBox.SelectedItem = category;
						}
					}
				}
				if (this._mode == frmCounterItem.FormMode.AddMode)
				{
					comboBox.SelectedItem = filteredCategorySet[0];
				}
				label.Location = new Point(num, num2);
				label.Size = new Size(62, 13);
				comboBox.Location = new Point(num + num4, num2 - 4);
				comboBox.Size = new Size(85, 21);
				this.gbxReportCategory.Controls.Add(label);
				this.gbxReportCategory.Controls.Add(comboBox);
				num += num3;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001C024 File Offset: 0x0001B024
		private bool areMandatoryFieldsAvailable()
		{
			bool result = true;
			if (string.IsNullOrEmpty(this.txtCounterItem.Text))
			{
				result = false;
				this.lblCounterItem.ForeColor = Color.Red;
			}
			else
			{
				this.lblCounterItem.ForeColor = Color.FromName("Control Text");
			}
			foreach (object obj in this.objGroupSet)
			{
				GroupItem groupItem = (GroupItem)obj;
				Control control = this.gbxReportCategory.Controls["cbo" + groupItem.GroupName];
				if (((ComboBox)control).SelectedIndex < 0)
				{
					result = false;
					control = this.gbxReportCategory.Controls["lbl" + groupItem.GroupName];
					((Label)control).ForeColor = Color.Red;
				}
				else
				{
					control = this.gbxReportCategory.Controls["lbl" + groupItem.GroupName];
					((Label)control).ForeColor = Color.FromName("Control Text");
				}
			}
			return result;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001C18C File Offset: 0x0001B18C
		private void checkMode()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001C190 File Offset: 0x0001B190
		private void rbtnDateRange_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbtnDateRange.Checked)
			{
				this.SynCountType(CIType.DATE_RANGE);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001C1B8 File Offset: 0x0001B1B8
		private void rbtnLatest_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbtnLatest.Checked)
			{
				this.SynCountType(CIType.LATEST);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001C1E0 File Offset: 0x0001B1E0
		private void rbtnLabelChangeSet_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbtnLabelChangeSet.Checked)
			{
				this.SynCountType(CIType.LABEL_CHANGESET);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001C208 File Offset: 0x0001B208
		private void rbtnItemFolder_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbtnItemFolder.Checked)
			{
				this.SynCountType(CIType.ITEM_FOLDER);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001C230 File Offset: 0x0001B230
		private void SynCountType(CIType ciType)
		{
			this.txtBase.Text = string.Empty;
			this.txtDiff.Text = string.Empty;
			this.comLatest.Text = string.Empty;
			this.cmbFSBase.Text = string.Empty;
			this.cmbFSDiff.Text = string.Empty;
			this.btnLatest.Enabled = false;
			this.comLatest.Enabled = false;
			if (!this.rbtnDateRange.Checked)
			{
				this.dtpFromDate.Value = DateTime.Now.AddDays(-1.0);
				this.dtpToDate.Value = DateTime.Now;
			}
			this.dtpFromDate.Enabled = false;
			this.dtpToDate.Enabled = false;
			this.txtBase.Enabled = false;
			this.ckbPrevious.Enabled = false;
			this.txtDiff.Enabled = false;
			this.cmbFSBase.Enabled = false;
			this.btnBase.Enabled = false;
			this.cmbFSDiff.Enabled = false;
			this.btnDiff.Enabled = false;
			if (this.rbtnLatest.Checked)
			{
				if (this.rdoFileSys.Checked)
				{
					this.btnLatest.Enabled = true;
				}
				this.comLatest.Enabled = true;
				this.txtWorkItem.Enabled = false;
				this.chkboxMReport.Enabled = false;
			}
			else if (this.rbtnLatestworkitem.Checked)
			{
				this.txtWorkItem.Enabled = true;
				this.chkboxMReport.Enabled = false;
			}
			else if (this.rbtnDateRange.Checked)
			{
				this.dtpFromDate.Enabled = true;
				this.dtpToDate.Enabled = true;
				this.txtWorkItem.Enabled = false;
				this.chkboxMReport.Enabled = true;
			}
			else if (this.rbtnDiffSet.Checked)
			{
				this.ckbPrevious.Enabled = true;
				if (!this.ckbPrevious.Checked)
				{
					this.txtBase.Enabled = true;
				}
				this.txtDiff.Enabled = true;
				this.txtWorkItem.Enabled = false;
				this.chkboxMReport.Enabled = true;
			}
			else if (this.rbtnItemFolder.Checked)
			{
				this.cmbFSBase.Enabled = true;
				this.btnBase.Enabled = true;
				this.cmbFSDiff.Enabled = true;
				this.btnDiff.Enabled = true;
				this.txtWorkItem.Enabled = false;
				this.chkboxMReport.Enabled = false;
			}
			this._CounterItemType = ciType;
			if (this.rdoVSS.Checked)
			{
				this.comLatest.Enabled = false;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001C53C File Offset: 0x0001B53C
		private bool CheckTaskNameDuplicated()
		{
			bool result = false;
			if (this._mode == frmCounterItem.FormMode.AddMode)
			{
				foreach (object obj in this.parentCISet)
				{
					CounterItem counterItem = (CounterItem)obj;
					if (counterItem.Name == this.CounterItemName)
					{
						result = true;
						break;
					}
				}
			}
			if (this._mode == frmCounterItem.FormMode.UdateMode)
			{
				if (this.UpdatingTaskName != this.CounterItemName)
				{
					foreach (object obj2 in this.parentCISet)
					{
						CounterItem counterItem = (CounterItem)obj2;
						if (counterItem.Name == this.CounterItemName)
						{
							result = true;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001C678 File Offset: 0x0001B678
		private bool CheckTaskNameBlank()
		{
			return this.CounterItemName.Trim() == "";
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001C6AC File Offset: 0x0001B6AC
		private bool CheckDiffAndBaseLength()
		{
			return this.txtBase.Text.Length > 64 || this.txtDiff.Text.Length > 64;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0001C6F8 File Offset: 0x0001B6F8
		private bool CheckEscapeChar()
		{
			string pattern = "[^a-zA-Z0-9_' '-]";
			Regex regex = new Regex(pattern);
			Match match = regex.Match(this.CounterItemName);
			return match.Success;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0001C73C File Offset: 0x0001B73C
		private bool CheckWorkItemID()
		{
			string text = string.Empty;
			if (this.rbtnLatestworkitem.Checked)
			{
				if (this.txtWorkItem.Text.ToString() == string.Empty)
				{
					text = "The WorkItem can't be empty!";
					MessageBox.Show(text);
					return false;
				}
				if (!this.regNumber.IsMatch(this.txtWorkItem.Text))
				{
					text = "The WorkItem should only contain 0-9 characters!";
					this.txtWorkItem.Text = string.Empty;
					this.txtWorkItem.Focus();
					MessageBox.Show(text);
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0001C7E8 File Offset: 0x0001B7E8
		private bool CheckServerConfig()
		{
			bool result = false;
			string text = "";
			this.combServerName.Text = this.combServerName.Text.Trim();
			this.combPort.Text = this.combPort.Text.Trim();
			Application.DoEvents();
			string text2 = this.combPort.Text;
			string text3 = this.combServerName.Text;
			switch (this.vssType)
			{
			case SourceServerType.VSTF:
				if (text3 == "")
				{
					text = "The server name can't be null!";
				}
				else if (text2 == "")
				{
					text = "The server port can't be null!";
				}
				else if (!this.regVSTFServerName.IsMatch(text3))
				{
					text = "The server name should only contain a-z A-Z - _ 0-9 or . characters (Such as vstfServer or vstfServer.domain.corp.com)!";
				}
				else if (!this.regNumber.IsMatch(text2))
				{
					text = "The server port should only contain 0-9 characters!";
				}
				if (this.rbtnLatest.Checked)
				{
					if (this.comLatest.Text.Trim() != "")
					{
						if (this.regNotVSTFLabel.IsMatch(this.comLatest.Text.Trim()))
						{
							text = "The Latest Changeset/Label should be a changeset number or a label string which can not contain any of the following characters: \"/:<>\\|*?@ !";
						}
					}
				}
				else if (this.rbtnDiffSet.Checked)
				{
					if (!this.ckbPrevious.Checked)
					{
						if (this.txtBase.Text.Trim() == "")
						{
							text = "The Base Changeset/Label can't be null!";
							break;
						}
						if (this.regNotVSTFLabel.IsMatch(this.txtBase.Text.Trim()))
						{
							text = "The Base Changeset/Label should be a changeset number or a label string which can not contain any of the following characters: \"/:<>\\|*?@ !";
							break;
						}
					}
					if (this.txtDiff.Text.Trim() == "")
					{
						text = "The Diff Changeset/Label can't be null!";
					}
					else if (this.regNotVSTFLabel.IsMatch(this.txtDiff.Text.Trim()))
					{
						text = "The Diff Changeset/Label should be a changeset number or a label string which can not contain any of the following characters: \"/:<>\\|*?@ !";
					}
					else if ((this.regNumber.IsMatch(this.txtBase.Text.Trim()) && !this.regNumber.IsMatch(this.txtDiff.Text.Trim())) || (this.txtBase.Text.Trim() != "" && !this.regNumber.IsMatch(this.txtBase.Text.Trim()) && this.regNumber.IsMatch(this.txtDiff.Text.Trim())))
					{
						text = "You can only diff between two labels or between two changeset!";
					}
				}
				break;
			case SourceServerType.VSS:
				if (this.cmbVSSDBPath.Text.Trim() == "")
				{
					text = "The VSS Database Path can't be null!";
				}
				else if (!File.Exists(this.cmbVSSDBPath.Text))
				{
					text = "The VSS Database Path doesn't exist!";
				}
				if (this.rbtnLatest.Checked)
				{
					if (this.comLatest.Text.Trim() != "")
					{
						if (!File.Exists(this.comLatest.Text))
						{
							text = "The Label path doesn't exist!";
						}
					}
				}
				else if (this.rbtnDiffSet.Checked)
				{
					if (!this.ckbPrevious.Checked)
					{
						if (this.txtBase.Text.Trim() == "")
						{
							text = "The Base can't be null!";
						}
						else if (!this.regLetterStartNormal.IsMatch(this.txtBase.Text))
						{
							text = "The Base should only contain a-z A-Z - _ or 0-9 characters!";
						}
					}
					if (this.txtDiff.Text.Trim() == "")
					{
						text = "The Diff can't be null!";
					}
					this.txtDiff.MaxLength = 254;
					if (!this.regLetterStartNormal.IsMatch(this.txtDiff.Text))
					{
						text = "The Diff name should only contain a-z A-Z - _ or 0-9 characters!";
					}
				}
				break;
			case SourceServerType.SD:
				if (text3 == "")
				{
					text = "The server name can't be null!";
				}
				else if (text2 == "")
				{
					text = "The server port can't be null!";
				}
				else if (!this.regSDServerName.IsMatch(text3))
				{
					text = "The server name should only contain a-z A-Z - _ 0-9 or . characters (Such as SDServer or SDServer.domain.corp.com)!";
				}
				else if (!this.regNumber.IsMatch(text2))
				{
					text = "The server port should only contain 0-9 characters!";
				}
				if (this.rbtnLatest.Checked)
				{
					if (this.comLatest.Text.Trim() != "")
					{
						if (!this.regSdLabel.IsMatch(this.comLatest.Text))
						{
							text = "The ChangeID should only contain a-z A-Z -$-!-?-+-=-:-;-[-]-{-}- _ -)-( or 0-9 characters!";
						}
					}
				}
				else if (this.rbtnDiffSet.Checked)
				{
					if (!this.ckbPrevious.Checked)
					{
						if (this.txtBase.Text.Trim() == "")
						{
							text = "The Base can't be null!";
							break;
						}
						if (!this.regSdLabel.IsMatch(this.txtBase.Text))
						{
							text = "The Base should only contain a-z A-Z -$-!-?-+-=-:-;-[-]-{-}- _ -)-( or 0-9 characters!";
						}
					}
					if (this.txtDiff.Text.Trim() == "")
					{
						text = "The Diff can't be null!";
					}
					else if (!this.regSdLabel.IsMatch(this.txtDiff.Text))
					{
						text = "The Diff name should only contain a-z A-Z -$-!-?-+-=-:-;-[-]-{-}- _ -)-( or 0-9 characters!";
					}
				}
				break;
			case SourceServerType.FILESYS:
				result = false;
				if (this.rbtnLatest.Checked)
				{
					if (this.comLatest.Text.Trim() == "")
					{
						text = "The Folder can't be null!";
					}
					else if (!Directory.Exists(this.comLatest.Text))
					{
						text = "The latest folder doesn't exist!";
					}
				}
				else if (this.rbtnItemFolder.Checked)
				{
					if (this.cmbFSBase.Text.Trim() == "" || this.cmbFSDiff.Text.Trim() == "")
					{
						text = "Base Folder or Diff Folder can't be null!";
					}
					else if (!Directory.Exists(this.cmbFSBase.Text))
					{
						text = "The Base Folder doesn't exist!";
					}
					else if (!Directory.Exists(this.cmbFSDiff.Text))
					{
						text = "The Diff Folder doesn't exist!";
					}
				}
				break;
			}
			if (text != "")
			{
				MessageBox.Show(text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0001CF68 File Offset: 0x0001BF68
		private void btnOk_Click(object sender, EventArgs e)
		{
			this.comLatest.Text = this.comLatest.Text.Trim();
			if (this.CheckServerConfig())
			{
				if (this.CheckWorkItemID())
				{
					if (this.CheckEscapeChar())
					{
						MessageBox.Show("The task's name can only contain 'a-zA-Z0-9_-'and blank!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (this.CheckTaskNameBlank())
					{
						MessageBox.Show("The task's name can not be blank!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (this.CheckTaskNameDuplicated())
					{
						MessageBox.Show("The task's name is duplicated with others'!Please change another name!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (this.rbtnDateRange.Checked && this.dtpFromDate.Value >= this.dtpToDate.Value)
					{
						MessageBox.Show("End Date should be greater than Start Date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						CIType counterItemType = this._CounterItemType;
						if (counterItemType != CIType.LATEST)
						{
							switch (counterItemType)
							{
							case CIType.BASEDTO_LABEL_CHANGESET:
								if (this.ckbPrevious.Checked)
								{
									this._CounterItemType = CIType.DIFF_PREVIOUS;
								}
								break;
							case CIType.LATEST_SET:
								if (this.comLatest.Text.Trim() == "" && this.vssType != SourceServerType.FILESYS)
								{
									this._CounterItemType = CIType.LATEST;
								}
								break;
							}
						}
						else if (this.comLatest.Text.Trim() != "" && this.vssType != SourceServerType.FILESYS)
						{
							this._CounterItemType = CIType.LATEST_SET;
						}
						try
						{
							if (this.areMandatoryFieldsAvailable())
							{
								if (this._mode == frmCounterItem.FormMode.AddMode)
								{
									this._CounterItem = new CounterItem();
								}
								else
								{
									if (this._CounterItem.ServerType != this.vssType)
									{
										this._CounterItem.DownLoadItems.Clear();
										this._CounterItem.IncludeElementSet.Clear();
										this._CounterItem.ExcludeElementSet.Clear();
									}
									else if (this._CounterItem.ServerName != this.combServerName.Text && this.vssType == SourceServerType.VSTF)
									{
										this._CounterItem.DownLoadItems.Clear();
										this._CounterItem.IncludeElementSet.Clear();
										this._CounterItem.ExcludeElementSet.Clear();
									}
									else if (this._CounterItem.ServerName != this.combServerName.Text && this.vssType == SourceServerType.SD)
									{
										this._CounterItem.DownLoadItems.Clear();
										this._CounterItem.IncludeElementSet.Clear();
										this._CounterItem.ExcludeElementSet.Clear();
									}
									else if (this._CounterItem.ServerName != this.cmbVSSDBPath.Text && this.vssType == SourceServerType.VSS)
									{
										this._CounterItem.DownLoadItems.Clear();
										this._CounterItem.IncludeElementSet.Clear();
										this._CounterItem.ExcludeElementSet.Clear();
									}
									else if (this.vssType == SourceServerType.FILESYS && ((this._CounterItemType == CIType.LATEST && this._CounterItem.ServerName != this.comLatest.Text) || (this._CounterItemType == CIType.ITEM_FOLDER && (this._CounterItem.ServerName != this.cmbFSBase.Text || this._CounterItem.DiffItem != this.cmbFSDiff.Text))))
									{
										this._CounterItem.DownLoadItems.Clear();
										this._CounterItem.IncludeElementSet.Clear();
										this._CounterItem.ExcludeElementSet.Clear();
									}
									else if (this._CounterItem.Type != this._CounterItemType || (this._CounterItemType != CIType.LATEST && this._CounterItemType != CIType.DATE_RANGE && this._CounterItemType != CIType.ITEM_FOLDER))
									{
										if (this._CounterItem.Type != this._CounterItemType)
										{
											if ((this._CounterItem.Type != CIType.LATEST && this._CounterItem.Type != CIType.DATE_RANGE) || (this._CounterItemType != CIType.LATEST && this._CounterItemType != CIType.DATE_RANGE))
											{
												this._CounterItem.DownLoadItems.Clear();
												this._CounterItem.IncludeElementSet.Clear();
												this._CounterItem.ExcludeElementSet.Clear();
											}
										}
										else
										{
											bool flag = true;
											switch (this._CounterItemType)
											{
											}
											if (flag)
											{
												this._CounterItem.DownLoadItems.Clear();
												this._CounterItem.IncludeElementSet.Clear();
												this._CounterItem.ExcludeElementSet.Clear();
											}
										}
									}
									this._CounterItem.BaseItem = "";
									this._CounterItem.DiffItem = "";
									this._CounterItem.BaseVersion = "";
									this._CounterItem.DiffVersion = "";
									this._CounterItem.StartDate = DateTime.MinValue;
									this._CounterItem.EndDate = DateTime.MinValue;
								}
								CategorySet categorySet = new CategorySet();
								this._CounterItem.Type = this._CounterItemType;
								if (this._CounterItemType == CIType.LATEST)
								{
									if (this.vssType == SourceServerType.FILESYS)
									{
										this._CounterItem.ServerName = this.comLatest.Text;
									}
								}
								else if (this._CounterItemType == CIType.DATE_RANGE)
								{
									this._CounterItem.EndDate = this.ToDate;
									this._CounterItem.StartDate = this.FromDate;
								}
								else if (this._CounterItemType == CIType.LABEL_CHANGESET)
								{
									this._CounterItem.BaseVersion = this.txtBaseVersion.Text;
									this._CounterItem.DiffVersion = this.txtDiffVersion.Text;
								}
								else if (this._CounterItemType == CIType.ITEM_FOLDER)
								{
									this._CounterItem.ServerName = this.cmbFSBase.Text;
									this._CounterItem.DiffItem = this.cmbFSDiff.Text;
								}
								else if (this._CounterItemType == CIType.BASEDTO_LABEL_CHANGESET)
								{
									this._CounterItem.BaseVersion = this.txtBase.Text;
									this._CounterItem.DiffVersion = this.txtDiff.Text;
								}
								else if (this._CounterItemType == CIType.LATEST_SET)
								{
									this._CounterItem.BaseVersion = this.comLatest.Text.Trim();
									this._CounterItem.DiffVersion = "";
								}
								else if (this._CounterItemType == CIType.DIFF_PREVIOUS)
								{
									this._CounterItem.BaseVersion = "";
									this._CounterItem.DiffVersion = this.txtDiff.Text.Trim();
								}
								if (this._CounterItemType == CIType.LATEST_WORKITEM)
								{
									this._CounterItem.BaseItem = this.txtWorkItem.Text.ToString();
								}
								this._CounterItem.Name = this.CounterItemName;
								foreach (object obj in this.objGroupSet)
								{
									GroupItem groupItem = (GroupItem)obj;
									Control[] array = base.Controls.Find("cbo" + groupItem.GroupName, true);
									if (array.Length > 0)
									{
										ComboBox comboBox = (ComboBox)array[0];
										categorySet.Add((Category)comboBox.SelectedItem);
									}
								}
								switch (this.vssType)
								{
								case SourceServerType.VSS:
									this._CounterItem.ServerName = this.cmbVSSDBPath.Text;
									goto IL_947;
								case SourceServerType.FILESYS:
									goto IL_947;
								}
								this._CounterItem.ServerName = this.combServerName.Text;
								this._CounterItem.ServerPort = this.combPort.Text;
								IL_947:
								this._CounterItem.ServerType = this.vssType;
								this._CounterItem.StandardReport = this.chkboxStandarReport.Checked;
								if (this.chkboxMReport.Enabled)
								{
									this._CounterItem.MReport = this.chkboxMReport.Checked;
								}
								else
								{
									this._CounterItem.MReport = false;
								}
								this._CounterItem.PspMetrics = this.chkboxPspMetrics.Checked;
								this._CounterItem.CategoryList = categorySet;
								this.IsFormOk = true;
								base.Hide();
								bool flag2 = false;
								foreach (object obj2 in this.haServerName)
								{
									if (((DictionaryEntry)obj2).Value.ToString().Trim() == this.combServerName.Text.Trim())
									{
										flag2 = true;
										break;
									}
								}
								if (!flag2)
								{
									AppConfigurationManager.AddServerOrPort(this.sGuid, "Server", this.combServerName.Text.Trim());
								}
								bool flag3 = false;
								foreach (object obj3 in this.haPort)
								{
									if (((DictionaryEntry)obj3).Value.ToString().Trim() == this.combPort.Text.Trim())
									{
										flag3 = true;
										break;
									}
								}
								if (!flag3)
								{
									AppConfigurationManager.AddServerOrPort(this.sGuid, "Port", this.combPort.Text.Trim());
								}
								bool flag4 = false;
								foreach (object obj4 in this.haVSSDBPath)
								{
									if (((DictionaryEntry)obj4).Value.ToString().Trim() == this.cmbVSSDBPath.Text.Trim())
									{
										flag4 = true;
										break;
									}
								}
								if (!flag4)
								{
									AppConfigurationManager.AddServerOrPort(this.sGuid, "VSSPath", this.cmbVSSDBPath.Text.Trim());
								}
								flag3 = false;
								foreach (object obj5 in this.haLatest)
								{
									if (((DictionaryEntry)obj5).Value.ToString().Trim() == this.comLatest.Text.Trim())
									{
										flag3 = true;
										break;
									}
								}
								if (!flag3)
								{
									AppConfigurationManager.AddServerOrPort(this.sGuid, "Latest", this.comLatest.Text.Trim());
								}
								flag3 = false;
								foreach (object obj6 in this.haFSBase)
								{
									if (((DictionaryEntry)obj6).Value.ToString().Trim() == this.cmbFSBase.Text.Trim())
									{
										flag3 = true;
										break;
									}
								}
								if (!flag3)
								{
									AppConfigurationManager.AddServerOrPort(this.sGuid, "FSBase", this.cmbFSBase.Text.Trim());
								}
								flag3 = false;
								foreach (object obj7 in this.haFSDiff)
								{
									if (((DictionaryEntry)obj7).Value.ToString().Trim() == this.cmbFSDiff.Text.Trim())
									{
										flag3 = true;
										break;
									}
								}
								if (!flag3)
								{
									AppConfigurationManager.AddServerOrPort(this.sGuid, "FSDiff", this.cmbFSDiff.Text.Trim());
								}
							}
							else
							{
								MessageBox.Show("Mandatory fileds are not filled.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001DE70 File Offset: 0x0001CE70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.IsFormOk = false;
			base.Hide();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0001DE84 File Offset: 0x0001CE84
		private void frmCounterItem_Load(object sender, EventArgs e)
		{
			this.dtpFromDate.Value = DateTime.Now.Date.AddDays(-1.0);
			this.dtpToDate.Value = DateTime.Now.Date;
			this.rbtnLatest.Checked = false;
			if (this._mode == frmCounterItem.FormMode.UdateMode)
			{
				if (this._CounterItem != null)
				{
					this.CounterItemName = this._CounterItem.Name;
					this._CounterItemType = this._CounterItem.Type;
					this.chkboxPspMetrics.Checked = this._CounterItem.PspMetrics;
					this.chkboxStandarReport.Checked = this._CounterItem.StandardReport;
					this.chkboxMReport.Checked = this._CounterItem.MReport;
					switch (this._CounterItem.ServerType)
					{
					case SourceServerType.VSTF:
						this.combServerName.Text = this._CounterItem.ServerName;
						this.combPort.Text = this._CounterItem.ServerPort;
						this.rdoVSTF.Checked = true;
						break;
					case SourceServerType.VSS:
						this.rdoVSS.Checked = true;
						if (!this.cmbVSSDBPath.Items.Contains(this._CounterItem.ServerName))
						{
							int selectedIndex = this.cmbVSSDBPath.Items.Add(this._CounterItem.ServerName);
							this.cmbVSSDBPath.SelectedIndex = selectedIndex;
						}
						else
						{
							this.cmbVSSDBPath.SelectedIndex = this.cmbVSSDBPath.Items.IndexOf(this._CounterItem.ServerName);
						}
						break;
					case SourceServerType.SD:
						this.combServerName.Text = this._CounterItem.ServerName;
						this.combPort.Text = this._CounterItem.ServerPort;
						this.rdoSD.Checked = true;
						break;
					case SourceServerType.FILESYS:
						this.rdoFileSys.Checked = true;
						break;
					}
					switch (this._CounterItem.Type)
					{
					case CIType.DATE_RANGE:
						this.FromDate = this._CounterItem.StartDate;
						this.ToDate = this._CounterItem.EndDate;
						this.rbtnDateRange.Checked = true;
						break;
					case CIType.LATEST:
						if (this._CounterItem.ServerType == SourceServerType.FILESYS)
						{
							this.comLatest.Text = this._CounterItem.ServerName;
						}
						this.rbtnLatest.Checked = true;
						break;
					case CIType.LABEL_CHANGESET:
						this.txtBaseVersion.Text = this._CounterItem.BaseVersion;
						this.txtDiffVersion.Text = this._CounterItem.DiffVersion;
						this.rbtnLabelChangeSet.Checked = true;
						break;
					case CIType.ITEM_FOLDER:
						this.rbtnItemFolder.Checked = true;
						if (!this.cmbFSBase.Items.Contains(this._CounterItem.ServerName))
						{
							int selectedIndex = this.cmbFSBase.Items.Add(this._CounterItem.ServerName);
							this.cmbFSBase.SelectedIndex = selectedIndex;
						}
						else
						{
							this.cmbFSBase.SelectedIndex = this.cmbFSBase.Items.IndexOf(this._CounterItem.ServerName);
						}
						if (!this.cmbFSDiff.Items.Contains(this._CounterItem.DiffItem.ToString()))
						{
							int selectedIndex = this.cmbFSDiff.Items.Add(this._CounterItem.DiffItem.ToString());
							this.cmbFSDiff.SelectedIndex = selectedIndex;
						}
						else
						{
							this.cmbFSDiff.SelectedIndex = this.cmbFSDiff.Items.IndexOf(this._CounterItem.DiffItem.ToString());
						}
						break;
					case CIType.BASEDTO_LABEL_CHANGESET:
						this.rbtnDiffSet.Checked = true;
						this.txtBase.Text = this._CounterItem.BaseVersion;
						this.txtDiff.Text = this._CounterItem.DiffVersion;
						break;
					case CIType.DIFF_PREVIOUS:
						this.rbtnDiffSet.Checked = true;
						this.ckbPrevious.Checked = true;
						this.txtDiff.Text = this._CounterItem.DiffVersion;
						break;
					case CIType.LATEST_SET:
						this.rbtnLatest.Checked = true;
						this.comLatest.Text = this._CounterItem.BaseVersion;
						break;
					case CIType.LATEST_WORKITEM:
						this.rbtnLatestworkitem.Checked = true;
						this.txtWorkItem.Text = this._CounterItem.BaseItem;
						break;
					default:
						this.rbtnLatest.Checked = true;
						break;
					}
					base.Update();
				}
			}
			else
			{
				this.rbtnLatest.Checked = true;
			}
			this.plotCategories();
			this.checkMode();
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0001E39B File Offset: 0x0001D39B
		private void rbtnBasicOnScreenReport_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0001E3A0 File Offset: 0x0001D3A0
		private void TypeChange()
		{
			if (this.rdoVSTF.Checked)
			{
				this.combServerName.Enabled = true;
				this.combPort.Enabled = true;
				this.cmbVSSDBPath.Enabled = false;
				this.btnVSSDBPath.Enabled = false;
				this.lbLatest.Text = "Changeset";
				this.btnLatest.Enabled = false;
				this.comLatest.Enabled = true;
				this.rbtnDateRange.Enabled = true;
				this.rbtnDiffSet.Enabled = true;
				this.rbtnDiffSet.Text = "Diff-Changeset";
				this.rbtnItemFolder.Enabled = false;
				this.comLatest.MaxLength = 64;
				this.txtBase.MaxLength = 64;
				this.txtDiff.MaxLength = 64;
				this.comLatest.Text = string.Empty;
				this.rbtnDiffSet.Text = "Diff Changeset / Label";
				this.rbtnLatestworkitem.Enabled = true;
				this.synDiffServerType(SourceServerType.VSTF);
			}
			else if (this.rdoSD.Checked)
			{
				this.combServerName.Enabled = true;
				this.combPort.Enabled = true;
				this.cmbVSSDBPath.Enabled = false;
				this.btnVSSDBPath.Enabled = false;
				this.lbLatest.Text = "ChangeID";
				this.btnLatest.Enabled = false;
				this.comLatest.Enabled = true;
				this.rbtnDateRange.Enabled = true;
				this.rbtnDiffSet.Enabled = true;
				this.rbtnDiffSet.Text = "Diff-ChangeID";
				this.rbtnItemFolder.Enabled = false;
				this.comLatest.MaxLength = 254;
				this.txtBase.MaxLength = 254;
				this.txtDiff.MaxLength = 254;
				this.comLatest.Text = string.Empty;
				this.rbtnDiffSet.Text = "Diff Change ID / Label";
				this.txtWorkItem.Enabled = false;
				this.rbtnLatestworkitem.Enabled = false;
				this.synDiffServerType(SourceServerType.SD);
			}
			else if (this.rdoVSS.Checked)
			{
				this.combServerName.Enabled = false;
				this.combPort.Enabled = false;
				this.cmbVSSDBPath.Enabled = true;
				this.btnVSSDBPath.Enabled = true;
				this.lbLatest.Text = "Label";
				this.btnLatest.Enabled = false;
				this.comLatest.Enabled = true;
				this.rbtnDateRange.Enabled = true;
				this.rbtnDiffSet.Enabled = false;
				this.rbtnDiffSet.Text = "Diff-Label";
				this.rbtnItemFolder.Enabled = false;
				this.comLatest.MaxLength = 254;
				this.txtBase.MaxLength = 254;
				this.txtDiff.MaxLength = 254;
				this.comLatest.Text = string.Empty;
				this.txtWorkItem.Enabled = false;
				this.rbtnLatestworkitem.Enabled = false;
				this.synDiffServerType(SourceServerType.VSS);
			}
			else if (this.rdoFileSys.Checked)
			{
				this.combServerName.Enabled = false;
				this.combPort.Enabled = false;
				this.cmbVSSDBPath.Enabled = false;
				this.btnVSSDBPath.Enabled = false;
				this.lbLatest.Text = "Folder";
				this.btnLatest.Enabled = true;
				this.comLatest.Enabled = true;
				this.rbtnDateRange.Enabled = false;
				this.rbtnDiffSet.Enabled = false;
				this.rbtnDiffSet.Text = "Diff-Changeset";
				this.rbtnItemFolder.Enabled = true;
				this.comLatest.Text = string.Empty;
				this.txtWorkItem.Enabled = false;
				this.rbtnLatestworkitem.Enabled = false;
				this.synDiffServerType(SourceServerType.FILESYS);
			}
			this.LoadServerPort();
			this.LoadInit();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001E7F4 File Offset: 0x0001D7F4
		private void rdoVSS_CheckedChanged(object sender, EventArgs e)
		{
			this.TypeChange();
			if (this.rdoVSS.Checked)
			{
				this.comLatest.Enabled = false;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0001E82A File Offset: 0x0001D82A
		private void rdoSD_CheckedChanged(object sender, EventArgs e)
		{
			this.TypeChange();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0001E834 File Offset: 0x0001D834
		private void rdoFileSys_CheckedChanged(object sender, EventArgs e)
		{
			this.TypeChange();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001E83E File Offset: 0x0001D83E
		private void rdoVSTF_CheckedChanged(object sender, EventArgs e)
		{
			this.TypeChange();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001E848 File Offset: 0x0001D848
		private void synDiffServerType(SourceServerType vssType)
		{
			switch (vssType)
			{
			case SourceServerType.VSTF:
				if (this._mode == frmCounterItem.FormMode.AddMode)
				{
					this.combServerName.Text = "";
					this.combPort.Text = "";
					this.comLatest.Text = "";
					this.txtBase.Text = "";
					this.txtDiff.Text = "";
				}
				else
				{
					this.combPort.Text = this._CounterItem.ServerPort;
				}
				break;
			case SourceServerType.VSS:
				vssType = SourceServerType.VSS;
				this.rbtnBaseChangeSet.Text = "Based on Label";
				if (this._mode == frmCounterItem.FormMode.AddMode)
				{
					this.cmbVSSDBPath.Text = "";
				}
				break;
			case SourceServerType.SD:
				if (this._mode == frmCounterItem.FormMode.AddMode)
				{
					this.combServerName.Text = "";
					this.combPort.Text = "2905";
					this.comLatest.Text = "";
					this.txtBase.Text = "";
					this.txtDiff.Text = "";
				}
				else
				{
					this.combPort.Text = this._CounterItem.ServerPort;
				}
				break;
			case SourceServerType.FILESYS:
				if (this._mode == frmCounterItem.FormMode.AddMode)
				{
					this.comLatest.Text = "";
				}
				break;
			}
			this.rbtnLatest.Checked = true;
			this.rbtnLatest.Update();
			this.vssType = vssType;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0001EA08 File Offset: 0x0001DA08
		private void combPort_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001EA0C File Offset: 0x0001DA0C
		private void btnBrowseFs_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Select a folder ";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.combServerName.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001EA50 File Offset: 0x0001DA50
		private void btnBrowseDiff_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Select a folder ";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtDiffItem.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001EA94 File Offset: 0x0001DA94
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (this.vssType == SourceServerType.VSS)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (!this.cmbVSSDBPath.Items.Contains(openFileDialog.FileName))
					{
						int selectedIndex = this.cmbVSSDBPath.Items.Add(openFileDialog.FileName);
						this.cmbVSSDBPath.SelectedIndex = selectedIndex;
					}
					else
					{
						this.cmbVSSDBPath.SelectedIndex = this.cmbVSSDBPath.Items.IndexOf(openFileDialog.FileName);
					}
				}
			}
			else if (this.vssType == SourceServerType.FILESYS)
			{
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				folderBrowserDialog.Description = "Select a folder ";
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					this.cmbVSSDBPath.Text = folderBrowserDialog.SelectedPath;
				}
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0001EB7F File Offset: 0x0001DB7F
		private void rbtnBaseChangeSet_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0001EB82 File Offset: 0x0001DB82
		private void rbtnDiffSet_CheckedChanged(object sender, EventArgs e)
		{
			this.SynCountType(CIType.BASEDTO_LABEL_CHANGESET);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001EB90 File Offset: 0x0001DB90
		private void ckbBase_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ckbPrevious.Checked)
			{
				this.txtBase.Enabled = false;
			}
			else
			{
				this.txtBase.Enabled = true;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001EBD0 File Offset: 0x0001DBD0
		private void btnLatest_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Select a folder ";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string name = ((Button)sender).Name;
				if (name != null)
				{
					if (!(name == "btnLatest"))
					{
						if (!(name == "btnBase"))
						{
							if (name == "btnDiff")
							{
								this.cmbFSDiff.Text = folderBrowserDialog.SelectedPath;
							}
						}
						else
						{
							this.cmbFSBase.Text = folderBrowserDialog.SelectedPath;
						}
					}
					else
					{
						this.comLatest.Text = folderBrowserDialog.SelectedPath;
					}
				}
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001EC78 File Offset: 0x0001DC78
		private void cmbFSBase_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001EC7B File Offset: 0x0001DC7B
		private void rbtnLatestworkitem_CheckedChanged(object sender, EventArgs e)
		{
			this.SynCountType(CIType.LATEST_WORKITEM);
		}

		// Token: 0x04000190 RID: 400
		private string[] sSaveInit = new string[3];

		// Token: 0x04000191 RID: 401
		private string sGuid;

		// Token: 0x04000192 RID: 402
		private Hashtable haServerName;

		// Token: 0x04000193 RID: 403
		private Hashtable haPort;

		// Token: 0x04000194 RID: 404
		private Hashtable haVSSDBPath;

		// Token: 0x04000195 RID: 405
		private Hashtable haLatest;

		// Token: 0x04000196 RID: 406
		private Hashtable haFSBase;

		// Token: 0x04000197 RID: 407
		private Hashtable haFSDiff;

		// Token: 0x04000198 RID: 408
		public static ConfigManager m_ConfigManager = new ConfigManager();

		// Token: 0x04000199 RID: 409
		private CategorySet objCategorySet;

		// Token: 0x0400019A RID: 410
		private GroupItemSet objGroupSet;

		// Token: 0x0400019B RID: 411
		private CounterItem _CounterItem;

		// Token: 0x0400019C RID: 412
		public bool IsFormOk = false;

		// Token: 0x0400019D RID: 413
		private frmCounterItem.FormMode _mode;

		// Token: 0x0400019E RID: 414
		private CounterItemSet parentCISet;

		// Token: 0x0400019F RID: 415
		private string UpdatingTaskName = "";

		// Token: 0x040001A0 RID: 416
		private Regex regNumber;

		// Token: 0x040001A1 RID: 417
		private Regex regVSTFServerName;

		// Token: 0x040001A2 RID: 418
		private Regex regSdLabel;

		// Token: 0x040001A3 RID: 419
		private Regex regSDServerName;

		// Token: 0x040001A4 RID: 420
		private Regex regLetterStartNormal;

		// Token: 0x040001A5 RID: 421
		private Regex regFolder;

		// Token: 0x040001A6 RID: 422
		private Regex regNotVSTFLabel;

		// Token: 0x040001A7 RID: 423
		private CIType _CounterItemType = CIType.LATEST;

		// Token: 0x040001A8 RID: 424
		private SourceServerType vssType = SourceServerType.VSTF;

		// Token: 0x02000027 RID: 39
		public enum FormMode
		{
			// Token: 0x040001ED RID: 493
			AddMode,
			// Token: 0x040001EE RID: 494
			UdateMode
		}
	}
}
