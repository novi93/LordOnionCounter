namespace LOC.View
{
    partial class FrmCountPG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCountPG));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnInvertcheck = new LOC.View.OnionButton();
            this.BtnCheckAll = new LOC.View.OnionButton();
            this.btnExit = new LOC.View.OnionButton();
            this.btnExport = new LOC.View.OnionButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvMain = new LOC.View.OnionGrid();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnCollapse = new LOC.View.OnionButton();
            this.pnlCs = new System.Windows.Forms.Panel();
            this.BtnInvertCheckCs = new LOC.View.OnionButton();
            this.BtnCheckAllCs = new LOC.View.OnionButton();
            this.BtnGetListCS = new LOC.View.OnionButton();
            this.pnlGrdCs = new System.Windows.Forms.Panel();
            this.dgvChangeset = new LOC.View.OnionGrid();
            this.pnlWorkItem = new System.Windows.Forms.Panel();
            this.lblWorkItemName = new System.Windows.Forms.Label();
            this.lblworkItem = new System.Windows.Forms.Label();
            this.TxtWorkItem = new System.Windows.Forms.TextBox();
            this.grbConect = new System.Windows.Forms.GroupBox();
            this.BtnAddServer = new LOC.View.OnionButton();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCopyRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.splPanel = new System.Windows.Forms.SplitContainer();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.grbOption = new System.Windows.Forms.GroupBox();
            this.labDesignPercent = new System.Windows.Forms.Label();
            this.txtDesignPercent = new System.Windows.Forms.TextBox();
            this.BtnClearAll = new LOC.View.OnionButton();
            this.BtnClearCache = new LOC.View.OnionButton();
            this.btnClearLog = new LOC.View.OnionButton();
            this.LblGuid = new System.Windows.Forms.Label();
            this.BtnNewGui = new LOC.View.OnionButton();
            this.chkCntDesigner = new System.Windows.Forms.CheckBox();
            this.chkGodMode = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlCs.SuspendLayout();
            this.pnlGrdCs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeset)).BeginInit();
            this.pnlWorkItem.SuspendLayout();
            this.grbConect.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPanel)).BeginInit();
            this.splPanel.Panel1.SuspendLayout();
            this.splPanel.Panel2.SuspendLayout();
            this.splPanel.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.grbOption.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(785, 733);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnInvertcheck);
            this.pnlFooter.Controls.Add(this.BtnCheckAll);
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Controls.Add(this.btnExport);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 689);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(785, 44);
            this.pnlFooter.TabIndex = 30;
            // 
            // btnInvertcheck
            // 
            this.btnInvertcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvertcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertcheck.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnInvertcheck.Image = ((System.Drawing.Image)(resources.GetObject("btnInvertcheck.Image")));
            this.btnInvertcheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvertcheck.Location = new System.Drawing.Point(151, 6);
            this.btnInvertcheck.Name = "btnInvertcheck";
            this.btnInvertcheck.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnInvertcheck.Size = new System.Drawing.Size(136, 34);
            this.btnInvertcheck.TabIndex = 1;
            this.btnInvertcheck.Text = "Invert Check[F3]";
            this.btnInvertcheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvertcheck.UseVisualStyleBackColor = true;
            this.btnInvertcheck.Click += new System.EventHandler(this.BtnInvertCheck_Click);
            // 
            // BtnCheckAll
            // 
            this.BtnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckAll.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnCheckAll.Image")));
            this.BtnCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckAll.Location = new System.Drawing.Point(10, 6);
            this.BtnCheckAll.Name = "BtnCheckAll";
            this.BtnCheckAll.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnCheckAll.Size = new System.Drawing.Size(136, 34);
            this.BtnCheckAll.TabIndex = 0;
            this.BtnCheckAll.Text = "Check All[F2]";
            this.BtnCheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCheckAll.UseVisualStyleBackColor = true;
            this.BtnCheckAll.Click += new System.EventHandler(this.BtnCheckAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(663, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(119, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit [F12]";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(516, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExport.Size = new System.Drawing.Size(119, 34);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Count[F11]";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Controls.Add(this.dgvMain);
            this.pnlBody.Location = new System.Drawing.Point(0, 282);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlBody.Size = new System.Drawing.Size(782, 403);
            this.pnlBody.TabIndex = 20;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.DisplaySumRowHeader = false;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(10, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 18;
            this.dgvMain.RowTemplate.Height = 21;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(772, 403);
            this.dgvMain.SummaryColumns = null;
            this.dgvMain.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvMain.SummaryRowSpace = 0;
            this.dgvMain.SummaryRowVisible = false;
            this.dgvMain.SumRowHeaderText = null;
            this.dgvMain.SumRowHeaderTextBold = false;
            this.dgvMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnCollapse);
            this.pnlHeader.Controls.Add(this.pnlCs);
            this.pnlHeader.Controls.Add(this.pnlWorkItem);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(785, 276);
            this.pnlHeader.TabIndex = 10;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Location = new System.Drawing.Point(762, 3);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(20, 34);
            this.btnCollapse.TabIndex = 4;
            this.btnCollapse.TabStop = false;
            this.btnCollapse.Text = "⇄";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.BtnCollapse_Click);
            // 
            // pnlCs
            // 
            this.pnlCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCs.Controls.Add(this.BtnInvertCheckCs);
            this.pnlCs.Controls.Add(this.BtnCheckAllCs);
            this.pnlCs.Controls.Add(this.BtnGetListCS);
            this.pnlCs.Controls.Add(this.pnlGrdCs);
            this.pnlCs.Location = new System.Drawing.Point(9, 43);
            this.pnlCs.Name = "pnlCs";
            this.pnlCs.Size = new System.Drawing.Size(773, 230);
            this.pnlCs.TabIndex = 20;
            // 
            // BtnInvertCheckCs
            // 
            this.BtnInvertCheckCs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInvertCheckCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInvertCheckCs.Location = new System.Drawing.Point(688, 175);
            this.BtnInvertCheckCs.Name = "BtnInvertCheckCs";
            this.BtnInvertCheckCs.Size = new System.Drawing.Size(80, 25);
            this.BtnInvertCheckCs.TabIndex = 30;
            this.BtnInvertCheckCs.TabStop = false;
            this.BtnInvertCheckCs.Text = "Invert Check";
            this.BtnInvertCheckCs.UseVisualStyleBackColor = true;
            this.BtnInvertCheckCs.Click += new System.EventHandler(this.BtnInvertCheckCs_Click);
            // 
            // BtnCheckAllCs
            // 
            this.BtnCheckAllCs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCheckAllCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckAllCs.Location = new System.Drawing.Point(688, 146);
            this.BtnCheckAllCs.Name = "BtnCheckAllCs";
            this.BtnCheckAllCs.Size = new System.Drawing.Size(80, 25);
            this.BtnCheckAllCs.TabIndex = 20;
            this.BtnCheckAllCs.TabStop = false;
            this.BtnCheckAllCs.Text = "Check All";
            this.BtnCheckAllCs.UseVisualStyleBackColor = true;
            this.BtnCheckAllCs.Click += new System.EventHandler(this.BtnCheckAllCs_Click);
            // 
            // BtnGetListCS
            // 
            this.BtnGetListCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGetListCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetListCS.Location = new System.Drawing.Point(688, 204);
            this.BtnGetListCS.Name = "BtnGetListCS";
            this.BtnGetListCS.Size = new System.Drawing.Size(80, 25);
            this.BtnGetListCS.TabIndex = 40;
            this.BtnGetListCS.Text = "Get List";
            this.BtnGetListCS.UseVisualStyleBackColor = true;
            this.BtnGetListCS.Click += new System.EventHandler(this.BtnGetListCS_Click);
            // 
            // pnlGrdCs
            // 
            this.pnlGrdCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrdCs.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrdCs.Controls.Add(this.dgvChangeset);
            this.pnlGrdCs.Location = new System.Drawing.Point(0, 0);
            this.pnlGrdCs.Name = "pnlGrdCs";
            this.pnlGrdCs.Size = new System.Drawing.Size(682, 230);
            this.pnlGrdCs.TabIndex = 21;
            // 
            // dgvChangeset
            // 
            this.dgvChangeset.AllowUserToAddRows = false;
            this.dgvChangeset.AllowUserToDeleteRows = false;
            this.dgvChangeset.AllowUserToOrderColumns = true;
            this.dgvChangeset.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvChangeset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChangeset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvChangeset.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChangeset.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChangeset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeset.DisplaySumRowHeader = false;
            this.dgvChangeset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChangeset.Location = new System.Drawing.Point(0, 0);
            this.dgvChangeset.MultiSelect = false;
            this.dgvChangeset.Name = "dgvChangeset";
            this.dgvChangeset.RowHeadersVisible = false;
            this.dgvChangeset.RowHeadersWidth = 18;
            this.dgvChangeset.RowTemplate.Height = 21;
            this.dgvChangeset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChangeset.Size = new System.Drawing.Size(682, 230);
            this.dgvChangeset.SummaryColumns = null;
            this.dgvChangeset.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvChangeset.SummaryRowSpace = 0;
            this.dgvChangeset.SummaryRowVisible = false;
            this.dgvChangeset.SumRowHeaderText = null;
            this.dgvChangeset.SumRowHeaderTextBold = false;
            this.dgvChangeset.TabIndex = 10;
            this.dgvChangeset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChangeset_CellContentClick);
            this.dgvChangeset.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChangeset_CellValueChanged);
            // 
            // pnlWorkItem
            // 
            this.pnlWorkItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkItem.Controls.Add(this.lblWorkItemName);
            this.pnlWorkItem.Controls.Add(this.lblworkItem);
            this.pnlWorkItem.Controls.Add(this.TxtWorkItem);
            this.pnlWorkItem.Location = new System.Drawing.Point(9, 6);
            this.pnlWorkItem.Name = "pnlWorkItem";
            this.pnlWorkItem.Size = new System.Drawing.Size(747, 31);
            this.pnlWorkItem.TabIndex = 10;
            // 
            // lblWorkItemName
            // 
            this.lblWorkItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkItemName.Location = new System.Drawing.Point(170, 8);
            this.lblWorkItemName.Name = "lblWorkItemName";
            this.lblWorkItemName.Size = new System.Drawing.Size(574, 12);
            this.lblWorkItemName.TabIndex = 4;
            this.lblWorkItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblworkItem
            // 
            this.lblworkItem.AutoSize = true;
            this.lblworkItem.Location = new System.Drawing.Point(4, 8);
            this.lblworkItem.Name = "lblworkItem";
            this.lblworkItem.Size = new System.Drawing.Size(52, 12);
            this.lblworkItem.TabIndex = 4;
            this.lblworkItem.Text = "WorkItem";
            // 
            // TxtWorkItem
            // 
            this.TxtWorkItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWorkItem.Location = new System.Drawing.Point(74, 5);
            this.TxtWorkItem.Name = "TxtWorkItem";
            this.TxtWorkItem.Size = new System.Drawing.Size(90, 19);
            this.TxtWorkItem.TabIndex = 10;
            this.TxtWorkItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtWorkItem.Enter += new System.EventHandler(this.TxtWorkItem_Enter);
            this.TxtWorkItem.Validating += new System.ComponentModel.CancelEventHandler(this.TxtWorkItem_Validating);
            // 
            // grbConect
            // 
            this.grbConect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbConect.Controls.Add(this.BtnAddServer);
            this.grbConect.Location = new System.Drawing.Point(3, 3);
            this.grbConect.Name = "grbConect";
            this.grbConect.Size = new System.Drawing.Size(469, 46);
            this.grbConect.TabIndex = 10;
            this.grbConect.TabStop = false;
            this.grbConect.Text = "Connect Manager";
            // 
            // BtnAddServer
            // 
            this.BtnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddServer.Location = new System.Drawing.Point(6, 18);
            this.BtnAddServer.Name = "BtnAddServer";
            this.BtnAddServer.Size = new System.Drawing.Size(80, 25);
            this.BtnAddServer.TabIndex = 0;
            this.BtnAddServer.Text = "Change";
            this.BtnAddServer.UseVisualStyleBackColor = true;
            this.BtnAddServer.Click += new System.EventHandler(this.BtnAddServer_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(467, 542);
            this.txtLog.TabIndex = 0;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.TxtLog_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCopyRight});
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1265, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(137, 17);
            this.lblCopyRight.Text = "Created by Sói đi dép lào";
            // 
            // splPanel
            // 
            this.splPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splPanel.Location = new System.Drawing.Point(0, 0);
            this.splPanel.Name = "splPanel";
            // 
            // splPanel.Panel1
            // 
            this.splPanel.Panel1.Controls.Add(this.pnlMain);
            // 
            // splPanel.Panel2
            // 
            this.splPanel.Panel2.Controls.Add(this.pnlSetting);
            this.splPanel.Size = new System.Drawing.Size(1265, 733);
            this.splPanel.SplitterDistance = 785;
            this.splPanel.SplitterWidth = 5;
            this.splPanel.TabIndex = 2;
            this.splPanel.TabStop = false;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.grbOption);
            this.pnlSetting.Controls.Add(this.panel1);
            this.pnlSetting.Controls.Add(this.grbConect);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(475, 733);
            this.pnlSetting.TabIndex = 5;
            // 
            // grbOption
            // 
            this.grbOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbOption.Controls.Add(this.labDesignPercent);
            this.grbOption.Controls.Add(this.txtDesignPercent);
            this.grbOption.Controls.Add(this.BtnClearAll);
            this.grbOption.Controls.Add(this.BtnClearCache);
            this.grbOption.Controls.Add(this.btnClearLog);
            this.grbOption.Controls.Add(this.LblGuid);
            this.grbOption.Controls.Add(this.BtnNewGui);
            this.grbOption.Controls.Add(this.chkCntDesigner);
            this.grbOption.Controls.Add(this.chkGodMode);
            this.grbOption.Location = new System.Drawing.Point(3, 55);
            this.grbOption.Name = "grbOption";
            this.grbOption.Size = new System.Drawing.Size(469, 125);
            this.grbOption.TabIndex = 20;
            this.grbOption.TabStop = false;
            this.grbOption.Text = "Option";
            // 
            // labDesignPercent
            // 
            this.labDesignPercent.AutoSize = true;
            this.labDesignPercent.Location = new System.Drawing.Point(178, 103);
            this.labDesignPercent.Name = "labDesignPercent";
            this.labDesignPercent.Size = new System.Drawing.Size(11, 12);
            this.labDesignPercent.TabIndex = 42;
            this.labDesignPercent.Text = "%";
            // 
            // txtDesignPercent
            // 
            this.txtDesignPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesignPercent.Location = new System.Drawing.Point(115, 98);
            this.txtDesignPercent.Name = "txtDesignPercent";
            this.txtDesignPercent.Size = new System.Drawing.Size(57, 19);
            this.txtDesignPercent.TabIndex = 60;
            this.txtDesignPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesignPercent.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesignPercent_Validating);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearAll.Location = new System.Drawing.Point(92, 68);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(80, 25);
            this.BtnClearAll.TabIndex = 30;
            this.BtnClearAll.Text = "Clear All";
            this.BtnClearAll.UseVisualStyleBackColor = true;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // BtnClearCache
            // 
            this.BtnClearCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearCache.Location = new System.Drawing.Point(6, 68);
            this.BtnClearCache.Name = "BtnClearCache";
            this.BtnClearCache.Size = new System.Drawing.Size(80, 25);
            this.BtnClearCache.TabIndex = 20;
            this.BtnClearCache.Text = "Clear Cache";
            this.BtnClearCache.UseVisualStyleBackColor = true;
            this.BtnClearCache.Click += new System.EventHandler(this.BtnClearCache_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Location = new System.Drawing.Point(178, 68);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(80, 25);
            this.btnClearLog.TabIndex = 40;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // LblGuid
            // 
            this.LblGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblGuid.Location = new System.Drawing.Point(92, 40);
            this.LblGuid.Name = "LblGuid";
            this.LblGuid.Size = new System.Drawing.Size(371, 18);
            this.LblGuid.TabIndex = 4;
            this.LblGuid.Text = "GUID";
            this.LblGuid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnNewGui
            // 
            this.BtnNewGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewGui.Location = new System.Drawing.Point(6, 37);
            this.BtnNewGui.Name = "BtnNewGui";
            this.BtnNewGui.Size = new System.Drawing.Size(80, 25);
            this.BtnNewGui.TabIndex = 10;
            this.BtnNewGui.Text = "New GUID";
            this.BtnNewGui.UseVisualStyleBackColor = true;
            this.BtnNewGui.Click += new System.EventHandler(this.BtnNewGui_Click);
            // 
            // chkCntDesigner
            // 
            this.chkCntDesigner.AutoSize = true;
            this.chkCntDesigner.Location = new System.Drawing.Point(6, 99);
            this.chkCntDesigner.Name = "chkCntDesigner";
            this.chkCntDesigner.Size = new System.Drawing.Size(103, 16);
            this.chkCntDesigner.TabIndex = 50;
            this.chkCntDesigner.Text = "Count Designer";
            this.chkCntDesigner.UseVisualStyleBackColor = true;
            // 
            // chkGodMode
            // 
            this.chkGodMode.AutoSize = true;
            this.chkGodMode.Location = new System.Drawing.Point(6, 18);
            this.chkGodMode.Name = "chkGodMode";
            this.chkGodMode.Size = new System.Drawing.Size(75, 16);
            this.chkGodMode.TabIndex = 0;
            this.chkGodMode.Text = "God Mode";
            this.chkGodMode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Location = new System.Drawing.Point(3, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 544);
            this.panel1.TabIndex = 30;
            // 
            // FrmCountPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1265, 755);
            this.Controls.Add(this.splPanel);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCountPG";
            this.Text = "Lord Onion Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCountPG_FormClosing);
            this.Load += new System.EventHandler(this.FrmCountPG_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlCs.ResumeLayout(false);
            this.pnlGrdCs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeset)).EndInit();
            this.pnlWorkItem.ResumeLayout(false);
            this.pnlWorkItem.PerformLayout();
            this.grbConect.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splPanel.Panel1.ResumeLayout(false);
            this.splPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splPanel)).EndInit();
            this.splPanel.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.grbOption.ResumeLayout(false);
            this.grbOption.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlWorkItem;
        private System.Windows.Forms.Panel pnlCs;
        private System.Windows.Forms.TextBox TxtWorkItem;
        private System.Windows.Forms.GroupBox grbConect;
        private System.Windows.Forms.Label lblworkItem;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblWorkItemName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyRight;
        private System.Windows.Forms.SplitContainer splPanel;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblGuid;
        private System.Windows.Forms.GroupBox grbOption;
        private System.Windows.Forms.CheckBox chkGodMode;
        private OnionButton BtnGetListCS;
        private OnionButton BtnAddServer;
        private OnionButton btnExport;
        private OnionButton btnInvertcheck;
        private OnionButton BtnCheckAll;
        private OnionButton btnCollapse;
        private OnionButton btnClearLog;
        private OnionButton btnExit;
        private OnionButton BtnNewGui;
        private OnionButton BtnClearCache;
        private OnionButton BtnClearAll;
        private System.Windows.Forms.Panel pnlGrdCs;
        private OnionButton BtnInvertCheckCs;
        private OnionButton BtnCheckAllCs;
        private OnionGrid dgvMain;
        private OnionGrid dgvChangeset;
        private System.Windows.Forms.CheckBox chkCntDesigner;
        private System.Windows.Forms.Label labDesignPercent;
        private System.Windows.Forms.TextBox txtDesignPercent;
    }
}