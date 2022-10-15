namespace CLOC_Couter
{
	// Token: 0x02000011 RID: 17
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmResultDiff : global::System.Windows.Forms.Form
	{
		// Token: 0x06000125 RID: 293 RVA: 0x0000B20C File Offset: 0x0000940C
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000B25C File Offset: 0x0000945C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtHeSodiff = new global::System.Windows.Forms.ComboBox();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtDesignLOC = new global::System.Windows.Forms.TextBox();
			this.txtNewEditLOC = new global::System.Windows.Forms.TextBox();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.txtTotalNewEditLoc = new global::System.Windows.Forms.TextBox();
			this.btnExport = new global::System.Windows.Forms.Button();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtTotalBaseLoc = new global::System.Windows.Forms.TextBox();
			this.txtBaseDesign = new global::System.Windows.Forms.TextBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.txtBaseLOC = new global::System.Windows.Forms.TextBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.CompareFileBindingSource1 = new global::System.Windows.Forms.BindingSource(this.components);
			this.CompareFileBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.grdResult = new global::System.Windows.Forms.DataGridView();
			this.CompareFileBindingSource2 = new global::System.Windows.Forms.BindingSource(this.components);
			this.ViewTableLOCBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.CompareFileBindingSource1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CompareFileBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.grdResult).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CompareFileBindingSource2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ViewTableLOCBindingSource).BeginInit();
			base.SuspendLayout();
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new global::System.Drawing.Point(14, 499);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(88, 13);
			this.Label4.TabIndex = 61;
			this.Label4.Text = "Tỷ lệ LOC Design";
			this.txtHeSodiff.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtHeSodiff.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtHeSodiff.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtHeSodiff.FormattingEnabled = true;
			this.txtHeSodiff.Items.AddRange(new object[]
			{
				"5",
				"10",
				"15",
				"20",
				"25",
				"30",
				"35",
				"40",
				"45",
				"50",
				"55",
				"60",
				"65",
				"70",
				"75",
				"80",
				"85",
				"90",
				"95",
				"100"
			});
			this.txtHeSodiff.Location = new global::System.Drawing.Point(108, 495);
			this.txtHeSodiff.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtHeSodiff.Name = "txtHeSodiff";
			this.txtHeSodiff.Size = new global::System.Drawing.Size(103, 21);
			this.txtHeSodiff.TabIndex = 62;
			this.GroupBox1.Controls.Add(this.txtDesignLOC);
			this.GroupBox1.Controls.Add(this.txtNewEditLOC);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtTotalNewEditLoc);
			this.GroupBox1.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.GroupBox1.Location = new global::System.Drawing.Point(435, 529);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new global::System.Drawing.Size(465, 75);
			this.GroupBox1.TabIndex = 74;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "LOC tạo mới/chỉnh sửa";
			this.txtDesignLOC.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtDesignLOC.Enabled = false;
			this.txtDesignLOC.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesignLOC.Location = new global::System.Drawing.Point(173, 42);
			this.txtDesignLOC.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtDesignLOC.Name = "txtDesignLOC";
			this.txtDesignLOC.Size = new global::System.Drawing.Size(103, 21);
			this.txtDesignLOC.TabIndex = 76;
			this.txtNewEditLOC.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtNewEditLOC.Enabled = false;
			this.txtNewEditLOC.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNewEditLOC.Location = new global::System.Drawing.Point(173, 18);
			this.txtNewEditLOC.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNewEditLOC.Name = "txtNewEditLOC";
			this.txtNewEditLOC.Size = new global::System.Drawing.Size(103, 21);
			this.txtNewEditLOC.TabIndex = 75;
			this.Label9.AutoSize = true;
			this.Label9.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label9.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.Label9.Location = new global::System.Drawing.Point(295, 32);
			this.Label9.Name = "Label9";
			this.Label9.Size = new global::System.Drawing.Size(59, 13);
			this.Label9.TabIndex = 74;
			this.Label9.Text = "Tổng LOC";
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(74, 45);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(81, 13);
			this.Label6.TabIndex = 73;
			this.Label6.Text = "LOC (giao diện)";
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(35, 21);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Label5.Size = new global::System.Drawing.Size(123, 13);
			this.Label5.TabIndex = 72;
			this.Label5.Text = "LOC (tạo mới/chỉnh sửa)";
			this.txtTotalNewEditLoc.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtTotalNewEditLoc.Enabled = false;
			this.txtTotalNewEditLoc.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotalNewEditLoc.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.txtTotalNewEditLoc.Location = new global::System.Drawing.Point(355, 29);
			this.txtTotalNewEditLoc.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTotalNewEditLoc.Name = "txtTotalNewEditLoc";
			this.txtTotalNewEditLoc.Size = new global::System.Drawing.Size(103, 21);
			this.txtTotalNewEditLoc.TabIndex = 71;
			this.btnExport.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnExport.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.btnExport.Location = new global::System.Drawing.Point(790, 494);
			this.btnExport.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new global::System.Drawing.Size(104, 33);
			this.btnExport.TabIndex = 78;
			this.btnExport.Text = "Export File";
			this.btnExport.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Controls.Add(this.txtTotalBaseLoc);
			this.GroupBox4.Controls.Add(this.txtBaseDesign);
			this.GroupBox4.Controls.Add(this.Label8);
			this.GroupBox4.Controls.Add(this.txtBaseLOC);
			this.GroupBox4.Controls.Add(this.Label7);
			this.GroupBox4.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox4.Location = new global::System.Drawing.Point(9, 529);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Size = new global::System.Drawing.Size(412, 75);
			this.GroupBox4.TabIndex = 79;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "LOC mẫu";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.Label1.Location = new global::System.Drawing.Point(239, 32);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(59, 13);
			this.Label1.TabIndex = 78;
			this.Label1.Text = "Tổng LOC";
			this.txtTotalBaseLoc.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtTotalBaseLoc.Enabled = false;
			this.txtTotalBaseLoc.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotalBaseLoc.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.txtTotalBaseLoc.Location = new global::System.Drawing.Point(299, 29);
			this.txtTotalBaseLoc.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTotalBaseLoc.Name = "txtTotalBaseLoc";
			this.txtTotalBaseLoc.Size = new global::System.Drawing.Size(103, 21);
			this.txtTotalBaseLoc.TabIndex = 77;
			this.txtBaseDesign.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtBaseDesign.Enabled = false;
			this.txtBaseDesign.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBaseDesign.Location = new global::System.Drawing.Point(122, 39);
			this.txtBaseDesign.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBaseDesign.Name = "txtBaseDesign";
			this.txtBaseDesign.Size = new global::System.Drawing.Size(103, 21);
			this.txtBaseDesign.TabIndex = 76;
			this.Label8.AutoSize = true;
			this.Label8.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.Location = new global::System.Drawing.Point(35, 42);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(81, 13);
			this.Label8.TabIndex = 75;
			this.Label8.Text = "LOC (giao diện)";
			this.txtBaseLOC.AcceptsReturn = true;
			this.txtBaseLOC.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtBaseLOC.Enabled = false;
			this.txtBaseLOC.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBaseLOC.Location = new global::System.Drawing.Point(122, 14);
			this.txtBaseLOC.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBaseLOC.Name = "txtBaseLOC";
			this.txtBaseLOC.Size = new global::System.Drawing.Size(103, 21);
			this.txtBaseLOC.TabIndex = 74;
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(66, 17);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Label7.Size = new global::System.Drawing.Size(50, 13);
			this.Label7.TabIndex = 73;
			this.Label7.Text = "LOC mẫu";
			this.grdResult.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.grdResult.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdResult.Location = new global::System.Drawing.Point(10, 8);
			this.grdResult.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.grdResult.Name = "grdResult";
			this.grdResult.RowTemplate.Height = 21;
			this.grdResult.Size = new global::System.Drawing.Size(890, 479);
			this.grdResult.TabIndex = 80;
			this.CompareFileBindingSource2.DataSource = typeof(global::CLOC_Couter.CompareFile);
			this.ViewTableLOCBindingSource.DataSource = typeof(global::CLOC_Couter.frmResultDiff);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(909, 623);
			base.Controls.Add(this.grdResult);
			base.Controls.Add(this.GroupBox4);
			base.Controls.Add(this.btnExport);
			base.Controls.Add(this.GroupBox1);
			base.Controls.Add(this.txtHeSodiff);
			base.Controls.Add(this.Label4);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.MaximizeBox = false;
			base.Name = "frmResultDiff";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kết quả so sánh";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.CompareFileBindingSource1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CompareFileBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.grdResult).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CompareFileBindingSource2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ViewTableLOCBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000076 RID: 118
		private global::System.ComponentModel.IContainer components;
	}
}
