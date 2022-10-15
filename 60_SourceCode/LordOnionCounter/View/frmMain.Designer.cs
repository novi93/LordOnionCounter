namespace LOC.View
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTeamProjectCollection = new System.Windows.Forms.ComboBox();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.btnGetCss = new System.Windows.Forms.Button();
            this.btnGetListCS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCs = new System.Windows.Forms.Label();
            this.txtListCSID = new System.Windows.Forms.TextBox();
            this.pnlCs = new System.Windows.Forms.Panel();
            this.lblWorkItemName = new System.Windows.Forms.Label();
            this.lblworkItem = new System.Windows.Forms.Label();
            this.txtWorkItem = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCs.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1265, 455);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnUncheckAll);
            this.pnlFooter.Controls.Add(this.btnCheckAll);
            this.pnlFooter.Controls.Add(this.btnExport);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 373);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1265, 82);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(128, 3);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(119, 34);
            this.btnUncheckAll.TabIndex = 1;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(3, 3);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(119, 34);
            this.btnCheckAll.TabIndex = 1;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1124, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 34);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Trololo Sing Along!";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Controls.Add(this.dgvMain);
            this.pnlBody.Location = new System.Drawing.Point(0, 108);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1262, 259);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 18;
            this.dgvMain.RowTemplate.Height = 21;
            this.dgvMain.Size = new System.Drawing.Size(1262, 259);
            this.dgvMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.txtLog);
            this.pnlHeader.Controls.Add(this.groupBox1);
            this.pnlHeader.Controls.Add(this.btnGetCss);
            this.pnlHeader.Controls.Add(this.btnGetListCS);
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.pnlCs);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1265, 102);
            this.pnlHeader.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(529, 9);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(497, 85);
            this.txtLog.TabIndex = 4;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTeamProjectCollection);
            this.groupBox1.Controls.Add(this.btnAddServer);
            this.groupBox1.Location = new System.Drawing.Point(1032, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Manager";
            // 
            // cmbTeamProjectCollection
            // 
            this.cmbTeamProjectCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamProjectCollection.FormattingEnabled = true;
            this.cmbTeamProjectCollection.Location = new System.Drawing.Point(10, 26);
            this.cmbTeamProjectCollection.Name = "cmbTeamProjectCollection";
            this.cmbTeamProjectCollection.Size = new System.Drawing.Size(121, 20);
            this.cmbTeamProjectCollection.TabIndex = 0;
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(137, 26);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 21);
            this.btnAddServer.TabIndex = 1;
            this.btnAddServer.Text = "Add";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // btnGetCss
            // 
            this.btnGetCss.Location = new System.Drawing.Point(83, 39);
            this.btnGetCss.Name = "btnGetCss";
            this.btnGetCss.Size = new System.Drawing.Size(96, 21);
            this.btnGetCss.TabIndex = 1;
            this.btnGetCss.Text = "Get Changesets";
            this.btnGetCss.UseVisualStyleBackColor = true;
            this.btnGetCss.Click += new System.EventHandler(this.btnGetCss_Click);
            // 
            // btnGetListCS
            // 
            this.btnGetListCS.Location = new System.Drawing.Point(441, 62);
            this.btnGetListCS.Name = "btnGetListCS";
            this.btnGetListCS.Size = new System.Drawing.Size(82, 34);
            this.btnGetListCS.TabIndex = 1;
            this.btnGetListCS.Text = "Hù !!!!";
            this.btnGetListCS.UseVisualStyleBackColor = true;
            this.btnGetListCS.Click += new System.EventHandler(this.btnGetListCS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCs);
            this.panel1.Controls.Add(this.txtListCSID);
            this.panel1.Location = new System.Drawing.Point(9, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 32);
            this.panel1.TabIndex = 0;
            // 
            // lblCs
            // 
            this.lblCs.AutoSize = true;
            this.lblCs.Location = new System.Drawing.Point(3, 7);
            this.lblCs.Name = "lblCs";
            this.lblCs.Size = new System.Drawing.Size(65, 12);
            this.lblCs.TabIndex = 3;
            this.lblCs.Text = "Changesets";
            // 
            // txtListCSID
            // 
            this.txtListCSID.Location = new System.Drawing.Point(74, 3);
            this.txtListCSID.Multiline = true;
            this.txtListCSID.Name = "txtListCSID";
            this.txtListCSID.Size = new System.Drawing.Size(346, 25);
            this.txtListCSID.TabIndex = 2;
            this.txtListCSID.Text = "31442";
            // 
            // pnlCs
            // 
            this.pnlCs.Controls.Add(this.lblWorkItemName);
            this.pnlCs.Controls.Add(this.lblworkItem);
            this.pnlCs.Controls.Add(this.txtWorkItem);
            this.pnlCs.Location = new System.Drawing.Point(9, 6);
            this.pnlCs.Name = "pnlCs";
            this.pnlCs.Size = new System.Drawing.Size(514, 29);
            this.pnlCs.TabIndex = 0;
            // 
            // lblWorkItemName
            // 
            this.lblWorkItemName.Location = new System.Drawing.Point(165, 8);
            this.lblWorkItemName.Name = "lblWorkItemName";
            this.lblWorkItemName.Size = new System.Drawing.Size(346, 12);
            this.lblWorkItemName.TabIndex = 4;
            this.lblWorkItemName.Text = "lblWorkItemName";
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
            // txtWorkItem
            // 
            this.txtWorkItem.Location = new System.Drawing.Point(74, 5);
            this.txtWorkItem.Name = "txtWorkItem";
            this.txtWorkItem.Size = new System.Drawing.Size(85, 19);
            this.txtWorkItem.TabIndex = 2;
            this.txtWorkItem.Text = "1149";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1265, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(137, 17);
            this.toolStripStatusLabel1.Text = "Created by Sói đi dép lào";
            // 
            // frmSemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSemi";
            this.Text = "Lord Onion Counter";
            this.pnlMain.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCs.ResumeLayout(false);
            this.pnlCs.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlCs;
        private System.Windows.Forms.Button btnGetListCS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCs;
        private System.Windows.Forms.TextBox txtListCSID;
        private System.Windows.Forms.TextBox txtWorkItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTeamProjectCollection;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Label lblworkItem;
        private System.Windows.Forms.Button btnGetCss;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblWorkItemName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}