namespace LOC.View
{
    partial class FrmCountResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCountResult));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCopyRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnExit = new LOC.View.OnionButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvdetail = new LOC.View.OnionGrid();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCopyRight});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(137, 17);
            this.lblCopyRight.Text = "Created by Sói đi dép lào";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.BtnExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 410);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.panel4.Size = new System.Drawing.Size(884, 49);
            this.panel4.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(752, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnExit.Size = new System.Drawing.Size(119, 34);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit [F12]";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvdetail);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(881, 404);
            this.panel2.TabIndex = 2;
            // 
            // dgvdetail
            // 
            this.dgvdetail.AllowUserToAddRows = false;
            this.dgvdetail.AllowUserToDeleteRows = false;
            this.dgvdetail.AllowUserToOrderColumns = true;
            this.dgvdetail.AllowUserToResizeRows = false;
            this.dgvdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvdetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.DisplaySumRowHeader = true;
            this.dgvdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdetail.FormatString = "N0";
            this.dgvdetail.Location = new System.Drawing.Point(10, 10);
            this.dgvdetail.MultiSelect = false;
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.RowHeadersVisible = false;
            this.dgvdetail.RowHeadersWidth = 18;
            this.dgvdetail.RowTemplate.Height = 21;
            this.dgvdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvdetail.Size = new System.Drawing.Size(861, 384);
            this.dgvdetail.SummaryColumns = null;
            this.dgvdetail.SummaryRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvdetail.SummaryRowSpace = 0;
            this.dgvdetail.SummaryRowVisible = true;
            this.dgvdetail.SumRowHeaderText = "★★★　SUMARY　★★★";
            this.dgvdetail.SumRowHeaderTextBold = true;
            this.dgvdetail.TabIndex = 0;
            this.dgvdetail.TabStop = false;
            this.dgvdetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetail_CellEndEdit);
            this.dgvdetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvdetail_CellValidating);
            this.dgvdetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetail_CellValueChanged);
            this.dgvdetail.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvdetail_DataBindingComplete);
            // 
            // FrmCountResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCountResult";
            this.Text = "Lord Onion Counter - Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCountResult_FormClosing);
            this.Load += new System.EventHandler(this.FrmCountResult_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyRight;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private OnionGrid dgvdetail;
        private OnionButton BtnExit;
    }
}