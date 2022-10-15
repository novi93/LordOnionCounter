namespace MS.IT.LOC.UI
{
	// Token: 0x02000026 RID: 38
	public partial class frmCounterItem : global::System.Windows.Forms.Form
	{
		// Token: 0x06000237 RID: 567 RVA: 0x0001EC88 File Offset: 0x0001DC88
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001ECC0 File Offset: 0x0001DCC0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmCounterItem));
			this.btnOk = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.lblCounterItem = new global::System.Windows.Forms.Label();
			this.txtCounterItem = new global::System.Windows.Forms.TextBox();
			this.gbxCounterType = new global::System.Windows.Forms.GroupBox();
			this.rbtnLatestworkitem = new global::System.Windows.Forms.RadioButton();
			this.txtWorkItem = new global::System.Windows.Forms.TextBox();
			this.lblworkItem = new global::System.Windows.Forms.Label();
			this.ckbPrevious = new global::System.Windows.Forms.CheckBox();
			this.cmbFSDiff = new global::System.Windows.Forms.ComboBox();
			this.txtDiff = new global::System.Windows.Forms.TextBox();
			this.cmbFSBase = new global::System.Windows.Forms.ComboBox();
			this.txtBase = new global::System.Windows.Forms.TextBox();
			this.comLatest = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.btnDiff = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btnBase = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.rbtnDiffSet = new global::System.Windows.Forms.RadioButton();
			this.btnLatest = new global::System.Windows.Forms.Button();
			this.lbLatest = new global::System.Windows.Forms.Label();
			this.rbtnItemFolder = new global::System.Windows.Forms.RadioButton();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblFromDate = new global::System.Windows.Forms.Label();
			this.dtpToDate = new global::System.Windows.Forms.DateTimePicker();
			this.dtpFromDate = new global::System.Windows.Forms.DateTimePicker();
			this.rbtnDateRange = new global::System.Windows.Forms.RadioButton();
			this.rbtnLatest = new global::System.Windows.Forms.RadioButton();
			this.textDiffBox = new global::System.Windows.Forms.TextBox();
			this.DiffLabelChangeSet = new global::System.Windows.Forms.Label();
			this.textBeseBox = new global::System.Windows.Forms.TextBox();
			this.BaseLabelChangeSet = new global::System.Windows.Forms.Label();
			this.rbtnBaseChangeSet = new global::System.Windows.Forms.RadioButton();
			this.btnBrowseDiff = new global::System.Windows.Forms.Button();
			this.txtDiffItem = new global::System.Windows.Forms.TextBox();
			this.lblDiffItem = new global::System.Windows.Forms.Label();
			this.txtDiffVersion = new global::System.Windows.Forms.TextBox();
			this.lblDiffVersion = new global::System.Windows.Forms.Label();
			this.txtBaseVersion = new global::System.Windows.Forms.TextBox();
			this.lblBaseVersion = new global::System.Windows.Forms.Label();
			this.rbtnLabelChangeSet = new global::System.Windows.Forms.RadioButton();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.lblType = new global::System.Windows.Forms.Label();
			this.lblMessage = new global::System.Windows.Forms.Label();
			this.lblSource = new global::System.Windows.Forms.Label();
			this.gbxSource = new global::System.Windows.Forms.GroupBox();
			this.cmbVSSDBPath = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnVSSDBPath = new global::System.Windows.Forms.Button();
			this.combPort = new global::System.Windows.Forms.ComboBox();
			this.combServerName = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelServerName = new global::System.Windows.Forms.Label();
			this.rdoFileSys = new global::System.Windows.Forms.RadioButton();
			this.rdoVSS = new global::System.Windows.Forms.RadioButton();
			this.rdoSD = new global::System.Windows.Forms.RadioButton();
			this.rdoVSTF = new global::System.Windows.Forms.RadioButton();
			this.lblReportCategory = new global::System.Windows.Forms.Label();
			this.gbxReportCategory = new global::System.Windows.Forms.GroupBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkboxMReport = new global::System.Windows.Forms.CheckBox();
			this.chkboxStandarReport = new global::System.Windows.Forms.CheckBox();
			this.chkboxPspMetrics = new global::System.Windows.Forms.CheckBox();
			this.lblMReport = new global::System.Windows.Forms.Label();
			this.gbxCounterType.SuspendLayout();
			this.gbxSource.SuspendLayout();
			this.gbxReportCategory.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.btnOk.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new global::System.Drawing.Point(217, 607);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(87, 23);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new global::System.Drawing.Point(362, 607);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(87, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.lblCounterItem.AutoSize = true;
			this.lblCounterItem.Location = new global::System.Drawing.Point(8, 16);
			this.lblCounterItem.Name = "lblCounterItem";
			this.lblCounterItem.Size = new global::System.Drawing.Size(69, 13);
			this.lblCounterItem.TabIndex = 2;
			this.lblCounterItem.Text = "Task Name *";
			this.txtCounterItem.Location = new global::System.Drawing.Point(116, 12);
			this.txtCounterItem.MaxLength = 100;
			this.txtCounterItem.Name = "txtCounterItem";
			this.txtCounterItem.Size = new global::System.Drawing.Size(438, 20);
			this.txtCounterItem.TabIndex = 0;
			this.gbxCounterType.Controls.Add(this.rbtnLatestworkitem);
			this.gbxCounterType.Controls.Add(this.txtWorkItem);
			this.gbxCounterType.Controls.Add(this.lblworkItem);
			this.gbxCounterType.Controls.Add(this.ckbPrevious);
			this.gbxCounterType.Controls.Add(this.cmbFSDiff);
			this.gbxCounterType.Controls.Add(this.txtDiff);
			this.gbxCounterType.Controls.Add(this.cmbFSBase);
			this.gbxCounterType.Controls.Add(this.txtBase);
			this.gbxCounterType.Controls.Add(this.comLatest);
			this.gbxCounterType.Controls.Add(this.label6);
			this.gbxCounterType.Controls.Add(this.btnDiff);
			this.gbxCounterType.Controls.Add(this.label5);
			this.gbxCounterType.Controls.Add(this.btnBase);
			this.gbxCounterType.Controls.Add(this.label8);
			this.gbxCounterType.Controls.Add(this.label7);
			this.gbxCounterType.Controls.Add(this.rbtnDiffSet);
			this.gbxCounterType.Controls.Add(this.btnLatest);
			this.gbxCounterType.Controls.Add(this.lbLatest);
			this.gbxCounterType.Controls.Add(this.rbtnItemFolder);
			this.gbxCounterType.Controls.Add(this.label1);
			this.gbxCounterType.Controls.Add(this.lblFromDate);
			this.gbxCounterType.Controls.Add(this.dtpToDate);
			this.gbxCounterType.Controls.Add(this.dtpFromDate);
			this.gbxCounterType.Controls.Add(this.rbtnDateRange);
			this.gbxCounterType.Controls.Add(this.rbtnLatest);
			this.gbxCounterType.Location = new global::System.Drawing.Point(116, 165);
			this.gbxCounterType.Name = "gbxCounterType";
			this.gbxCounterType.Size = new global::System.Drawing.Size(488, 297);
			this.gbxCounterType.TabIndex = 2;
			this.gbxCounterType.TabStop = false;
			this.rbtnLatestworkitem.AutoSize = true;
			this.rbtnLatestworkitem.Location = new global::System.Drawing.Point(8, 41);
			this.rbtnLatestworkitem.Name = "rbtnLatestworkitem";
			this.rbtnLatestworkitem.Size = new global::System.Drawing.Size(54, 17);
			this.rbtnLatestworkitem.TabIndex = 33;
			this.rbtnLatestworkitem.Text = "Latest";
			this.rbtnLatestworkitem.UseVisualStyleBackColor = true;
			this.rbtnLatestworkitem.CheckedChanged += new global::System.EventHandler(this.rbtnLatestworkitem_CheckedChanged);
			this.txtWorkItem.Location = new global::System.Drawing.Point(136, 42);
			this.txtWorkItem.Name = "txtWorkItem";
			this.txtWorkItem.Size = new global::System.Drawing.Size(100, 20);
			this.txtWorkItem.TabIndex = 32;
			this.lblworkItem.AutoSize = true;
			this.lblworkItem.Location = new global::System.Drawing.Point(72, 43);
			this.lblworkItem.Name = "lblworkItem";
			this.lblworkItem.Size = new global::System.Drawing.Size(55, 13);
			this.lblworkItem.TabIndex = 31;
			this.lblworkItem.Text = "Work item";
			this.ckbPrevious.AutoSize = true;
			this.ckbPrevious.Enabled = false;
			this.ckbPrevious.Location = new global::System.Drawing.Point(281, 144);
			this.ckbPrevious.Name = "ckbPrevious";
			this.ckbPrevious.Size = new global::System.Drawing.Size(67, 17);
			this.ckbPrevious.TabIndex = 11;
			this.ckbPrevious.Text = "Previous";
			this.ckbPrevious.UseVisualStyleBackColor = true;
			this.ckbPrevious.CheckedChanged += new global::System.EventHandler(this.ckbBase_CheckedChanged);
			this.cmbFSDiff.Enabled = false;
			this.cmbFSDiff.FormattingEnabled = true;
			this.cmbFSDiff.Location = new global::System.Drawing.Point(136, 264);
			this.cmbFSDiff.Name = "cmbFSDiff";
			this.cmbFSDiff.Size = new global::System.Drawing.Size(302, 21);
			this.cmbFSDiff.TabIndex = 12;
			this.txtDiff.Enabled = false;
			this.txtDiff.Location = new global::System.Drawing.Point(136, 176);
			this.txtDiff.Name = "txtDiff";
			this.txtDiff.Size = new global::System.Drawing.Size(100, 20);
			this.txtDiff.TabIndex = 10;
			this.cmbFSBase.Enabled = false;
			this.cmbFSBase.FormattingEnabled = true;
			this.cmbFSBase.Location = new global::System.Drawing.Point(136, 230);
			this.cmbFSBase.Name = "cmbFSBase";
			this.cmbFSBase.Size = new global::System.Drawing.Size(302, 21);
			this.cmbFSBase.TabIndex = 12;
			this.cmbFSBase.SelectedIndexChanged += new global::System.EventHandler(this.cmbFSBase_SelectedIndexChanged);
			this.txtBase.Enabled = false;
			this.txtBase.Location = new global::System.Drawing.Point(136, 144);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new global::System.Drawing.Size(100, 20);
			this.txtBase.TabIndex = 9;
			this.comLatest.FormattingEnabled = true;
			this.comLatest.Location = new global::System.Drawing.Point(136, 12);
			this.comLatest.Name = "comLatest";
			this.comLatest.Size = new global::System.Drawing.Size(302, 21);
			this.comLatest.TabIndex = 12;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(106, 176);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(23, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Diff";
			this.btnDiff.Enabled = false;
			this.btnDiff.Location = new global::System.Drawing.Point(447, 264);
			this.btnDiff.Name = "btnDiff";
			this.btnDiff.Size = new global::System.Drawing.Size(31, 19);
			this.btnDiff.TabIndex = 30;
			this.btnDiff.Text = "...";
			this.btnDiff.UseVisualStyleBackColor = true;
			this.btnDiff.Click += new global::System.EventHandler(this.btnLatest_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(98, 148);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(31, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Base";
			this.btnBase.Enabled = false;
			this.btnBase.Location = new global::System.Drawing.Point(447, 232);
			this.btnBase.Name = "btnBase";
			this.btnBase.Size = new global::System.Drawing.Size(31, 19);
			this.btnBase.TabIndex = 27;
			this.btnBase.Text = "...";
			this.btnBase.UseVisualStyleBackColor = true;
			this.btnBase.Click += new global::System.EventHandler(this.btnLatest_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(74, 267);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(55, 13);
			this.label8.TabIndex = 28;
			this.label8.Text = "Diff Folder";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(66, 233);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(63, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "Base Folder";
			this.rbtnDiffSet.AutoSize = true;
			this.rbtnDiffSet.Location = new global::System.Drawing.Point(8, 114);
			this.rbtnDiffSet.Name = "rbtnDiffSet";
			this.rbtnDiffSet.Size = new global::System.Drawing.Size(135, 17);
			this.rbtnDiffSet.TabIndex = 23;
			this.rbtnDiffSet.TabStop = true;
			this.rbtnDiffSet.Text = "Diff Changeset / Label ";
			this.rbtnDiffSet.UseVisualStyleBackColor = true;
			this.rbtnDiffSet.CheckedChanged += new global::System.EventHandler(this.rbtnDiffSet_CheckedChanged);
			this.btnLatest.Enabled = false;
			this.btnLatest.Location = new global::System.Drawing.Point(447, 14);
			this.btnLatest.Name = "btnLatest";
			this.btnLatest.Size = new global::System.Drawing.Size(31, 19);
			this.btnLatest.TabIndex = 22;
			this.btnLatest.Text = "...";
			this.btnLatest.UseVisualStyleBackColor = true;
			this.btnLatest.Click += new global::System.EventHandler(this.btnLatest_Click);
			this.lbLatest.AutoSize = true;
			this.lbLatest.Location = new global::System.Drawing.Point(70, 18);
			this.lbLatest.Name = "lbLatest";
			this.lbLatest.Size = new global::System.Drawing.Size(58, 13);
			this.lbLatest.TabIndex = 20;
			this.lbLatest.Text = "Changeset";
			this.rbtnItemFolder.AutoSize = true;
			this.rbtnItemFolder.Enabled = false;
			this.rbtnItemFolder.Location = new global::System.Drawing.Point(8, 203);
			this.rbtnItemFolder.Name = "rbtnItemFolder";
			this.rbtnItemFolder.Size = new global::System.Drawing.Size(103, 17);
			this.rbtnItemFolder.TabIndex = 11;
			this.rbtnItemFolder.Text = "Diff - File System";
			this.rbtnItemFolder.UseVisualStyleBackColor = true;
			this.rbtnItemFolder.CheckedChanged += new global::System.EventHandler(this.rbtnItemFolder_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(277, 88);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "End Date ";
			this.lblFromDate.AutoSize = true;
			this.lblFromDate.Location = new global::System.Drawing.Point(72, 88);
			this.lblFromDate.Name = "lblFromDate";
			this.lblFromDate.Size = new global::System.Drawing.Size(58, 13);
			this.lblFromDate.TabIndex = 2;
			this.lblFromDate.Text = "Start Date ";
			this.dtpToDate.CustomFormat = "MM/dd/yyyy ";
			this.dtpToDate.Enabled = false;
			this.dtpToDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpToDate.Location = new global::System.Drawing.Point(338, 84);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new global::System.Drawing.Size(100, 20);
			this.dtpToDate.TabIndex = 5;
			this.dtpFromDate.CustomFormat = "MM/dd/yyyy ";
			this.dtpFromDate.Enabled = false;
			this.dtpFromDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFromDate.Location = new global::System.Drawing.Point(136, 84);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new global::System.Drawing.Size(100, 20);
			this.dtpFromDate.TabIndex = 3;
			this.dtpFromDate.Value = new global::System.DateTime(2007, 3, 15, 0, 0, 0, 0);
			this.rbtnDateRange.AutoSize = true;
			this.rbtnDateRange.Location = new global::System.Drawing.Point(6, 68);
			this.rbtnDateRange.Name = "rbtnDateRange";
			this.rbtnDateRange.Size = new global::System.Drawing.Size(78, 17);
			this.rbtnDateRange.TabIndex = 1;
			this.rbtnDateRange.Text = "Diff - Dates";
			this.rbtnDateRange.UseVisualStyleBackColor = true;
			this.rbtnDateRange.CheckedChanged += new global::System.EventHandler(this.rbtnDateRange_CheckedChanged);
			this.rbtnLatest.AutoSize = true;
			this.rbtnLatest.Checked = true;
			this.rbtnLatest.Location = new global::System.Drawing.Point(8, 16);
			this.rbtnLatest.Name = "rbtnLatest";
			this.rbtnLatest.Size = new global::System.Drawing.Size(54, 17);
			this.rbtnLatest.TabIndex = 0;
			this.rbtnLatest.TabStop = true;
			this.rbtnLatest.Text = "Latest";
			this.rbtnLatest.UseVisualStyleBackColor = true;
			this.rbtnLatest.CheckedChanged += new global::System.EventHandler(this.rbtnLatest_CheckedChanged);
			this.textDiffBox.Enabled = false;
			this.textDiffBox.Location = new global::System.Drawing.Point(393, 42);
			this.textDiffBox.Name = "textDiffBox";
			this.textDiffBox.Size = new global::System.Drawing.Size(88, 20);
			this.textDiffBox.TabIndex = 19;
			this.textDiffBox.Visible = false;
			this.DiffLabelChangeSet.AutoSize = true;
			this.DiffLabelChangeSet.Location = new global::System.Drawing.Point(321, 49);
			this.DiffLabelChangeSet.Name = "DiffLabelChangeSet";
			this.DiffLabelChangeSet.Size = new global::System.Drawing.Size(61, 13);
			this.DiffLabelChangeSet.TabIndex = 18;
			this.DiffLabelChangeSet.Text = "Diff Version";
			this.DiffLabelChangeSet.Visible = false;
			this.textBeseBox.AcceptsReturn = true;
			this.textBeseBox.Enabled = false;
			this.textBeseBox.Location = new global::System.Drawing.Point(215, 42);
			this.textBeseBox.Name = "textBeseBox";
			this.textBeseBox.Size = new global::System.Drawing.Size(88, 20);
			this.textBeseBox.TabIndex = 17;
			this.textBeseBox.Visible = false;
			this.BaseLabelChangeSet.AutoSize = true;
			this.BaseLabelChangeSet.Location = new global::System.Drawing.Point(137, 49);
			this.BaseLabelChangeSet.Name = "BaseLabelChangeSet";
			this.BaseLabelChangeSet.Size = new global::System.Drawing.Size(69, 13);
			this.BaseLabelChangeSet.TabIndex = 16;
			this.BaseLabelChangeSet.Text = "Base Version";
			this.BaseLabelChangeSet.Visible = false;
			this.rbtnBaseChangeSet.AutoSize = true;
			this.rbtnBaseChangeSet.Location = new global::System.Drawing.Point(6, 45);
			this.rbtnBaseChangeSet.Name = "rbtnBaseChangeSet";
			this.rbtnBaseChangeSet.Size = new global::System.Drawing.Size(123, 17);
			this.rbtnBaseChangeSet.TabIndex = 15;
			this.rbtnBaseChangeSet.Text = "Based on changeset";
			this.rbtnBaseChangeSet.UseVisualStyleBackColor = true;
			this.rbtnBaseChangeSet.Visible = false;
			this.rbtnBaseChangeSet.CheckedChanged += new global::System.EventHandler(this.rbtnBaseChangeSet_CheckedChanged);
			this.btnBrowseDiff.Enabled = false;
			this.btnBrowseDiff.Location = new global::System.Drawing.Point(465, -10);
			this.btnBrowseDiff.Name = "btnBrowseDiff";
			this.btnBrowseDiff.Size = new global::System.Drawing.Size(34, 20);
			this.btnBrowseDiff.TabIndex = 14;
			this.btnBrowseDiff.Text = "...";
			this.btnBrowseDiff.UseVisualStyleBackColor = true;
			this.btnBrowseDiff.Visible = false;
			this.btnBrowseDiff.Click += new global::System.EventHandler(this.btnBrowseDiff_Click);
			this.txtDiffItem.Enabled = false;
			this.txtDiffItem.Location = new global::System.Drawing.Point(356, -10);
			this.txtDiffItem.Name = "txtDiffItem";
			this.txtDiffItem.Size = new global::System.Drawing.Size(88, 20);
			this.txtDiffItem.TabIndex = 13;
			this.txtDiffItem.Visible = false;
			this.lblDiffItem.AutoSize = true;
			this.lblDiffItem.Location = new global::System.Drawing.Point(278, -7);
			this.lblDiffItem.Name = "lblDiffItem";
			this.lblDiffItem.Size = new global::System.Drawing.Size(23, 13);
			this.lblDiffItem.TabIndex = 12;
			this.lblDiffItem.Text = "Diff";
			this.lblDiffItem.Visible = false;
			this.txtDiffVersion.Enabled = false;
			this.txtDiffVersion.Location = new global::System.Drawing.Point(393, 16);
			this.txtDiffVersion.Name = "txtDiffVersion";
			this.txtDiffVersion.Size = new global::System.Drawing.Size(88, 20);
			this.txtDiffVersion.TabIndex = 10;
			this.txtDiffVersion.Visible = false;
			this.lblDiffVersion.AutoSize = true;
			this.lblDiffVersion.Location = new global::System.Drawing.Point(321, 23);
			this.lblDiffVersion.Name = "lblDiffVersion";
			this.lblDiffVersion.Size = new global::System.Drawing.Size(61, 13);
			this.lblDiffVersion.TabIndex = 9;
			this.lblDiffVersion.Text = "Diff Version";
			this.lblDiffVersion.Visible = false;
			this.txtBaseVersion.Enabled = false;
			this.txtBaseVersion.Location = new global::System.Drawing.Point(215, 16);
			this.txtBaseVersion.Name = "txtBaseVersion";
			this.txtBaseVersion.Size = new global::System.Drawing.Size(88, 20);
			this.txtBaseVersion.TabIndex = 8;
			this.txtBaseVersion.Visible = false;
			this.lblBaseVersion.AutoSize = true;
			this.lblBaseVersion.Location = new global::System.Drawing.Point(137, 19);
			this.lblBaseVersion.Name = "lblBaseVersion";
			this.lblBaseVersion.Size = new global::System.Drawing.Size(69, 13);
			this.lblBaseVersion.TabIndex = 7;
			this.lblBaseVersion.Text = "Base Version";
			this.lblBaseVersion.Visible = false;
			this.rbtnLabelChangeSet.AutoSize = true;
			this.rbtnLabelChangeSet.Location = new global::System.Drawing.Point(6, 19);
			this.rbtnLabelChangeSet.Name = "rbtnLabelChangeSet";
			this.rbtnLabelChangeSet.Size = new global::System.Drawing.Size(107, 17);
			this.rbtnLabelChangeSet.TabIndex = 6;
			this.rbtnLabelChangeSet.Text = "Label/Changeset";
			this.rbtnLabelChangeSet.UseVisualStyleBackColor = true;
			this.rbtnLabelChangeSet.Visible = false;
			this.rbtnLabelChangeSet.CheckedChanged += new global::System.EventHandler(this.rbtnLabelChangeSet_CheckedChanged);
			this.lblType.AutoSize = true;
			this.lblType.Location = new global::System.Drawing.Point(12, 221);
			this.lblType.Name = "lblType";
			this.lblType.Size = new global::System.Drawing.Size(62, 13);
			this.lblType.TabIndex = 6;
			this.lblType.Text = "Count Type";
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblMessage.Location = new global::System.Drawing.Point(8, 607);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new global::System.Drawing.Size(133, 13);
			this.lblMessage.TabIndex = 8;
			this.lblMessage.Text = "* Fields are mandatory";
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new global::System.Drawing.Point(8, 63);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new global::System.Drawing.Size(106, 13);
			this.lblSource.TabIndex = 10;
			this.lblSource.Text = "Source Management";
			this.gbxSource.Controls.Add(this.cmbVSSDBPath);
			this.gbxSource.Controls.Add(this.label2);
			this.gbxSource.Controls.Add(this.btnVSSDBPath);
			this.gbxSource.Controls.Add(this.combPort);
			this.gbxSource.Controls.Add(this.combServerName);
			this.gbxSource.Controls.Add(this.label3);
			this.gbxSource.Controls.Add(this.labelServerName);
			this.gbxSource.Controls.Add(this.rdoFileSys);
			this.gbxSource.Controls.Add(this.rdoVSS);
			this.gbxSource.Controls.Add(this.rdoSD);
			this.gbxSource.Controls.Add(this.rdoVSTF);
			this.gbxSource.Controls.Add(this.btnBrowseDiff);
			this.gbxSource.Controls.Add(this.lblDiffItem);
			this.gbxSource.Controls.Add(this.txtDiffItem);
			this.gbxSource.Location = new global::System.Drawing.Point(116, 42);
			this.gbxSource.Name = "gbxSource";
			this.gbxSource.Size = new global::System.Drawing.Size(488, 117);
			this.gbxSource.TabIndex = 1;
			this.gbxSource.TabStop = false;
			this.cmbVSSDBPath.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVSSDBPath.Enabled = false;
			this.cmbVSSDBPath.FormattingEnabled = true;
			this.cmbVSSDBPath.Location = new global::System.Drawing.Point(136, 87);
			this.cmbVSSDBPath.Name = "cmbVSSDBPath";
			this.cmbVSSDBPath.Size = new global::System.Drawing.Size(302, 21);
			this.cmbVSSDBPath.TabIndex = 12;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(28, 87);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(102, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "VSS Database Path";
			this.btnVSSDBPath.Enabled = false;
			this.btnVSSDBPath.Location = new global::System.Drawing.Point(447, 88);
			this.btnVSSDBPath.Name = "btnVSSDBPath";
			this.btnVSSDBPath.Size = new global::System.Drawing.Size(31, 19);
			this.btnVSSDBPath.TabIndex = 9;
			this.btnVSSDBPath.Text = "...";
			this.btnVSSDBPath.UseVisualStyleBackColor = true;
			this.btnVSSDBPath.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.combPort.FormattingEnabled = true;
			this.combPort.Location = new global::System.Drawing.Point(338, 53);
			this.combPort.Name = "combPort";
			this.combPort.Size = new global::System.Drawing.Size(100, 21);
			this.combPort.TabIndex = 8;
			this.combPort.SelectedIndexChanged += new global::System.EventHandler(this.combPort_SelectedIndexChanged);
			this.combServerName.FormattingEnabled = true;
			this.combServerName.Location = new global::System.Drawing.Point(136, 53);
			this.combServerName.Name = "combServerName";
			this.combServerName.Size = new global::System.Drawing.Size(100, 21);
			this.combServerName.TabIndex = 6;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(278, 57);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(26, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Port";
			this.labelServerName.AutoSize = true;
			this.labelServerName.Location = new global::System.Drawing.Point(28, 57);
			this.labelServerName.Name = "labelServerName";
			this.labelServerName.Size = new global::System.Drawing.Size(69, 13);
			this.labelServerName.TabIndex = 5;
			this.labelServerName.Text = "Server Name";
			this.rdoFileSys.AutoSize = true;
			this.rdoFileSys.Location = new global::System.Drawing.Point(338, 21);
			this.rdoFileSys.Name = "rdoFileSys";
			this.rdoFileSys.Size = new global::System.Drawing.Size(78, 17);
			this.rdoFileSys.TabIndex = 4;
			this.rdoFileSys.Text = "File System";
			this.rdoFileSys.UseVisualStyleBackColor = true;
			this.rdoFileSys.CheckedChanged += new global::System.EventHandler(this.rdoFileSys_CheckedChanged);
			this.rdoVSS.AutoSize = true;
			this.rdoVSS.Location = new global::System.Drawing.Point(192, 19);
			this.rdoVSS.Name = "rdoVSS";
			this.rdoVSS.Size = new global::System.Drawing.Size(112, 17);
			this.rdoVSS.TabIndex = 3;
			this.rdoVSS.Text = "Visual SourceSafe";
			this.rdoVSS.UseVisualStyleBackColor = true;
			this.rdoVSS.CheckedChanged += new global::System.EventHandler(this.rdoVSS_CheckedChanged);
			this.rdoSD.AutoSize = true;
			this.rdoSD.Location = new global::System.Drawing.Point(408, 21);
			this.rdoSD.Name = "rdoSD";
			this.rdoSD.Size = new global::System.Drawing.Size(91, 17);
			this.rdoSD.TabIndex = 2;
			this.rdoSD.Text = "Source Depot";
			this.rdoSD.UseVisualStyleBackColor = true;
			this.rdoSD.Visible = false;
			this.rdoSD.CheckedChanged += new global::System.EventHandler(this.rdoSD_CheckedChanged);
			this.rdoVSTF.AutoSize = true;
			this.rdoVSTF.Checked = true;
			this.rdoVSTF.Location = new global::System.Drawing.Point(19, 19);
			this.rdoVSTF.Name = "rdoVSTF";
			this.rdoVSTF.Size = new global::System.Drawing.Size(142, 17);
			this.rdoVSTF.TabIndex = 1;
			this.rdoVSTF.TabStop = true;
			this.rdoVSTF.Text = "Team Foundation Server";
			this.rdoVSTF.UseVisualStyleBackColor = true;
			this.rdoVSTF.CheckedChanged += new global::System.EventHandler(this.rdoVSTF_CheckedChanged);
			this.lblReportCategory.AutoSize = true;
			this.lblReportCategory.Location = new global::System.Drawing.Point(8, 542);
			this.lblReportCategory.Name = "lblReportCategory";
			this.lblReportCategory.Size = new global::System.Drawing.Size(73, 13);
			this.lblReportCategory.TabIndex = 11;
			this.lblReportCategory.Text = "Filter category";
			this.gbxReportCategory.Controls.Add(this.rbtnLabelChangeSet);
			this.gbxReportCategory.Controls.Add(this.lblBaseVersion);
			this.gbxReportCategory.Controls.Add(this.txtBaseVersion);
			this.gbxReportCategory.Controls.Add(this.lblDiffVersion);
			this.gbxReportCategory.Controls.Add(this.txtDiffVersion);
			this.gbxReportCategory.Controls.Add(this.rbtnBaseChangeSet);
			this.gbxReportCategory.Controls.Add(this.BaseLabelChangeSet);
			this.gbxReportCategory.Controls.Add(this.textBeseBox);
			this.gbxReportCategory.Controls.Add(this.DiffLabelChangeSet);
			this.gbxReportCategory.Controls.Add(this.textDiffBox);
			this.gbxReportCategory.Location = new global::System.Drawing.Point(116, 526);
			this.gbxReportCategory.Name = "gbxReportCategory";
			this.gbxReportCategory.Size = new global::System.Drawing.Size(488, 64);
			this.gbxReportCategory.TabIndex = 3;
			this.gbxReportCategory.TabStop = false;
			this.groupBox1.Controls.Add(this.chkboxMReport);
			this.groupBox1.Controls.Add(this.chkboxStandarReport);
			this.groupBox1.Controls.Add(this.chkboxPspMetrics);
			this.groupBox1.Location = new global::System.Drawing.Point(116, 468);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(488, 52);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.chkboxMReport.AutoSize = true;
			this.chkboxMReport.Location = new global::System.Drawing.Point(188, 19);
			this.chkboxMReport.Name = "chkboxMReport";
			this.chkboxMReport.Size = new global::System.Drawing.Size(70, 17);
			this.chkboxMReport.TabIndex = 17;
			this.chkboxMReport.Text = "M Report";
			this.chkboxMReport.UseVisualStyleBackColor = true;
			this.chkboxStandarReport.AutoCheck = false;
			this.chkboxStandarReport.AutoSize = true;
			this.chkboxStandarReport.Checked = true;
			this.chkboxStandarReport.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkboxStandarReport.Location = new global::System.Drawing.Point(43, 19);
			this.chkboxStandarReport.Name = "chkboxStandarReport";
			this.chkboxStandarReport.Size = new global::System.Drawing.Size(101, 17);
			this.chkboxStandarReport.TabIndex = 16;
			this.chkboxStandarReport.Text = "StandardReport";
			this.chkboxStandarReport.UseVisualStyleBackColor = true;
			this.chkboxPspMetrics.AutoSize = true;
			this.chkboxPspMetrics.Location = new global::System.Drawing.Point(313, 19);
			this.chkboxPspMetrics.Name = "chkboxPspMetrics";
			this.chkboxPspMetrics.Size = new global::System.Drawing.Size(84, 17);
			this.chkboxPspMetrics.TabIndex = 15;
			this.chkboxPspMetrics.Text = "PSP Metrics";
			this.chkboxPspMetrics.UseVisualStyleBackColor = true;
			this.lblMReport.AutoSize = true;
			this.lblMReport.Location = new global::System.Drawing.Point(12, 487);
			this.lblMReport.Name = "lblMReport";
			this.lblMReport.Size = new global::System.Drawing.Size(44, 13);
			this.lblMReport.TabIndex = 13;
			this.lblMReport.Text = "Reports";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(619, 645);
			base.Controls.Add(this.lblMReport);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.gbxReportCategory);
			base.Controls.Add(this.lblReportCategory);
			base.Controls.Add(this.lblSource);
			base.Controls.Add(this.gbxSource);
			base.Controls.Add(this.lblMessage);
			base.Controls.Add(this.lblType);
			base.Controls.Add(this.gbxCounterType);
			base.Controls.Add(this.txtCounterItem);
			base.Controls.Add(this.lblCounterItem);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmCounterItem";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Counter Item";
			base.Load += new global::System.EventHandler(this.frmCounterItem_Load);
			this.gbxCounterType.ResumeLayout(false);
			this.gbxCounterType.PerformLayout();
			this.gbxSource.ResumeLayout(false);
			this.gbxSource.PerformLayout();
			this.gbxReportCategory.ResumeLayout(false);
			this.gbxReportCategory.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001A9 RID: 425
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.Label lblCounterItem;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.TextBox txtCounterItem;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.GroupBox gbxCounterType;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.DateTimePicker dtpFromDate;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.RadioButton rbtnDateRange;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.RadioButton rbtnLatest;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.DateTimePicker dtpToDate;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.Label lblFromDate;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.Label lblType;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.Label lblMessage;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.RadioButton rbtnLabelChangeSet;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.Label lblSource;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.GroupBox gbxSource;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.Label lblReportCategory;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.GroupBox gbxReportCategory;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.RadioButton rbtnItemFolder;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.TextBox txtDiffVersion;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.Label lblDiffVersion;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.TextBox txtBaseVersion;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Forms.Label lblBaseVersion;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001C3 RID: 451
		private global::System.Windows.Forms.Label labelServerName;

		// Token: 0x040001C4 RID: 452
		private global::System.Windows.Forms.RadioButton rdoFileSys;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Forms.RadioButton rdoVSS;

		// Token: 0x040001C6 RID: 454
		private global::System.Windows.Forms.RadioButton rdoSD;

		// Token: 0x040001C7 RID: 455
		private global::System.Windows.Forms.RadioButton rdoVSTF;

		// Token: 0x040001C8 RID: 456
		private global::System.Windows.Forms.ComboBox combServerName;

		// Token: 0x040001C9 RID: 457
		private global::System.Windows.Forms.ComboBox combPort;

		// Token: 0x040001CA RID: 458
		private global::System.Windows.Forms.Button btnBrowseDiff;

		// Token: 0x040001CB RID: 459
		private global::System.Windows.Forms.TextBox txtDiffItem;

		// Token: 0x040001CC RID: 460
		private global::System.Windows.Forms.Label lblDiffItem;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Forms.Button btnVSSDBPath;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Forms.TextBox textDiffBox;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.Label DiffLabelChangeSet;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.TextBox textBeseBox;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.Label BaseLabelChangeSet;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.RadioButton rbtnBaseChangeSet;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Forms.Button btnLatest;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Forms.Label lbLatest;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Forms.RadioButton rbtnDiffSet;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.CheckBox ckbPrevious;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.TextBox txtDiff;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.TextBox txtBase;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.Button btnDiff;

		// Token: 0x040001DD RID: 477
		private global::System.Windows.Forms.Button btnBase;

		// Token: 0x040001DE RID: 478
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040001DF RID: 479
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040001E0 RID: 480
		private global::System.Windows.Forms.ComboBox cmbFSDiff;

		// Token: 0x040001E1 RID: 481
		private global::System.Windows.Forms.ComboBox cmbFSBase;

		// Token: 0x040001E2 RID: 482
		private global::System.Windows.Forms.ComboBox comLatest;

		// Token: 0x040001E3 RID: 483
		private global::System.Windows.Forms.ComboBox cmbVSSDBPath;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001E5 RID: 485
		private global::System.Windows.Forms.Label lblMReport;

		// Token: 0x040001E6 RID: 486
		private global::System.Windows.Forms.Label lblworkItem;

		// Token: 0x040001E7 RID: 487
		private global::System.Windows.Forms.TextBox txtWorkItem;

		// Token: 0x040001E8 RID: 488
		private global::System.Windows.Forms.RadioButton rbtnLatestworkitem;

		// Token: 0x040001E9 RID: 489
		private global::System.Windows.Forms.CheckBox chkboxMReport;

		// Token: 0x040001EA RID: 490
		private global::System.Windows.Forms.CheckBox chkboxStandarReport;

		// Token: 0x040001EB RID: 491
		private global::System.Windows.Forms.CheckBox chkboxPspMetrics;
	}
}
