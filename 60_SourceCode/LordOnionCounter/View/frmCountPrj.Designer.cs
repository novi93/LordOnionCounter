namespace LOC.View
{
    partial class FrmCountPrj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCountPrj));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnUncheckAll = new OnionButton();
            this.btnCheckAll = new OnionButton();
            this.btnExit = new OnionButton();
            this.btnCount = new OnionButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnCollapse = new OnionButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new OnionButton();
            this.pnlWorkItem = new System.Windows.Forms.Panel();
            this.cbbPrj = new System.Windows.Forms.ComboBox();
            this.lblPrj = new System.Windows.Forms.Label();
            this.btnCountAll = new OnionButton();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splPanel = new System.Windows.Forms.SplitContainer();
            this.btnClearLog = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new OnionButton();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlWorkItem.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPanel)).BeginInit();
            this.splPanel.Panel1.SuspendLayout();
            this.splPanel.Panel2.SuspendLayout();
            this.splPanel.SuspendLayout();
            this.btnClearLog.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(800, 433);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnUncheckAll);
            this.pnlFooter.Controls.Add(this.btnCheckAll);
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Controls.Add(this.btnCount);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 384);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 49);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUncheckAll.Location = new System.Drawing.Point(128, 3);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(119, 34);
            this.btnUncheckAll.TabIndex = 1;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.BtnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckAll.Location = new System.Drawing.Point(3, 3);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(119, 34);
            this.btnCheckAll.TabIndex = 0;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.BtnCheckAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(678, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnCount
            // 
            this.btnCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCount.Location = new System.Drawing.Point(504, 3);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(119, 34);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Download & Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnExport_Click);
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
            this.pnlBody.Size = new System.Drawing.Size(797, 270);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 18;
            this.dgvMain.RowTemplate.Height = 21;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(797, 270);
            this.dgvMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnCollapse);
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Controls.Add(this.pnlWorkItem);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 102);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapse.Location = new System.Drawing.Point(777, 3);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(20, 94);
            this.btnCollapse.TabIndex = 4;
            this.btnCollapse.TabStop = false;
            this.btnCollapse.Text = "⇄";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.BtnCollapse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(9, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 29);
            this.panel2.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(74, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(519, 19);
            this.txtSearch.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 12);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(599, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 21);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // pnlWorkItem
            // 
            this.pnlWorkItem.Controls.Add(this.cbbPrj);
            this.pnlWorkItem.Controls.Add(this.lblPrj);
            this.pnlWorkItem.Controls.Add(this.btnCountAll);
            this.pnlWorkItem.Location = new System.Drawing.Point(9, 6);
            this.pnlWorkItem.Name = "pnlWorkItem";
            this.pnlWorkItem.Size = new System.Drawing.Size(762, 29);
            this.pnlWorkItem.TabIndex = 0;
            // 
            // cbbPrj
            // 
            this.cbbPrj.AllowDrop = true;
            this.cbbPrj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPrj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPrj.FormattingEnabled = true;
            this.cbbPrj.Location = new System.Drawing.Point(74, 5);
            this.cbbPrj.MaxDropDownItems = 15;
            this.cbbPrj.Name = "cbbPrj";
            this.cbbPrj.Size = new System.Drawing.Size(519, 20);
            this.cbbPrj.TabIndex = 0;
            // 
            // lblPrj
            // 
            this.lblPrj.AutoSize = true;
            this.lblPrj.Location = new System.Drawing.Point(4, 8);
            this.lblPrj.Name = "lblPrj";
            this.lblPrj.Size = new System.Drawing.Size(41, 12);
            this.lblPrj.TabIndex = 4;
            this.lblPrj.Text = "Project";
            // 
            // btnCountAll
            // 
            this.btnCountAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountAll.Location = new System.Drawing.Point(599, 5);
            this.btnCountAll.Name = "btnCountAll";
            this.btnCountAll.Size = new System.Drawing.Size(98, 21);
            this.btnCountAll.TabIndex = 10;
            this.btnCountAll.Text = "Count ALL";
            this.btnCountAll.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(455, 397);
            this.txtLog.TabIndex = 0;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.TxtLog_TextChanged);
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
            this.splPanel.Panel2.Controls.Add(this.btnClearLog);
            this.splPanel.Size = new System.Drawing.Size(1265, 433);
            this.splPanel.SplitterDistance = 800;
            this.splPanel.TabIndex = 2;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Controls.Add(this.panel1);
            this.btnClearLog.Controls.Add(this.button2);
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearLog.Location = new System.Drawing.Point(0, 0);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(461, 433);
            this.btnClearLog.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 397);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clear Log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // frmCountPrj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1265, 455);
            this.Controls.Add(this.splPanel);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCountPrj";
            this.Text = "Lord Onion Counter";
            this.pnlMain.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlWorkItem.ResumeLayout(false);
            this.pnlWorkItem.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splPanel.Panel1.ResumeLayout(false);
            this.splPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splPanel)).EndInit();
            this.splPanel.ResumeLayout(false);
            this.btnClearLog.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPrj;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnCountAll;
        private System.Windows.Forms.SplitContainer splPanel;
        private System.Windows.Forms.Panel btnClearLog;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbPrj;
    }
}