namespace CLOC_Couter
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmResultCountFile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00009EB4 File Offset: 0x000080B4
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

		// Token: 0x06000101 RID: 257 RVA: 0x00009F04 File Offset: 0x00008104
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.txtDesignLOC = new global::System.Windows.Forms.TextBox();
			this.txtTotalLOC = new global::System.Windows.Forms.TextBox();
			this.txtNewLOC = new global::System.Windows.Forms.TextBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtHeSo = new global::System.Windows.Forms.ComboBox();
			this.btnExport = new global::System.Windows.Forms.Button();
			this.grdResult = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.InformationBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.grdResult).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.InformationBindingSource).BeginInit();
			base.SuspendLayout();
			this.txtDesignLOC.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtDesignLOC.Enabled = false;
			this.txtDesignLOC.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesignLOC.Location = new global::System.Drawing.Point(140, 34);
			this.txtDesignLOC.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtDesignLOC.Name = "txtDesignLOC";
			this.txtDesignLOC.Size = new global::System.Drawing.Size(104, 21);
			this.txtDesignLOC.TabIndex = 56;
			this.txtTotalLOC.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtTotalLOC.Enabled = false;
			this.txtTotalLOC.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotalLOC.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.txtTotalLOC.Location = new global::System.Drawing.Point(325, 25);
			this.txtTotalLOC.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTotalLOC.Name = "txtTotalLOC";
			this.txtTotalLOC.Size = new global::System.Drawing.Size(104, 21);
			this.txtTotalLOC.TabIndex = 55;
			this.txtNewLOC.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtNewLOC.Enabled = false;
			this.txtNewLOC.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNewLOC.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.txtNewLOC.Location = new global::System.Drawing.Point(140, 12);
			this.txtNewLOC.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNewLOC.Name = "txtNewLOC";
			this.txtNewLOC.Size = new global::System.Drawing.Size(104, 21);
			this.txtNewLOC.TabIndex = 54;
			this.Label8.AutoSize = true;
			this.Label8.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.Label8.Location = new global::System.Drawing.Point(260, 29);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(59, 13);
			this.Label8.TabIndex = 53;
			this.Label8.Text = "Tổng LOC";
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(53, 37);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(81, 13);
			this.Label7.TabIndex = 52;
			this.Label7.Text = "LOC (giao diện)";
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(11, 16);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(123, 13);
			this.Label6.TabIndex = 51;
			this.Label6.Text = "LOC (tạo mới/chỉnh sửa)";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new global::System.Drawing.Point(41, 536);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(107, 13);
			this.Label1.TabIndex = 57;
			this.Label1.Text = "Tỷ lệ LOC (giao diện)";
			this.txtHeSo.BackColor = global::System.Drawing.SystemColors.HighlightText;
			this.txtHeSo.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtHeSo.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtHeSo.FormattingEnabled = true;
			this.txtHeSo.Items.AddRange(new object[]
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
			this.txtHeSo.Location = new global::System.Drawing.Point(154, 532);
			this.txtHeSo.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtHeSo.Name = "txtHeSo";
			this.txtHeSo.Size = new global::System.Drawing.Size(104, 21);
			this.txtHeSo.TabIndex = 58;
			this.btnExport.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnExport.Location = new global::System.Drawing.Point(800, 526);
			this.btnExport.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new global::System.Drawing.Size(84, 39);
			this.btnExport.TabIndex = 77;
			this.btnExport.Text = "Export File";
			this.btnExport.UseVisualStyleBackColor = true;
			this.grdResult.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.grdResult.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdResult.Location = new global::System.Drawing.Point(14, 15);
			this.grdResult.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.grdResult.Name = "grdResult";
			this.grdResult.RowTemplate.Height = 21;
			this.grdResult.Size = new global::System.Drawing.Size(870, 506);
			this.grdResult.TabIndex = 78;
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.txtNewLOC);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.txtTotalLOC);
			this.GroupBox1.Controls.Add(this.txtDesignLOC);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Font = new global::System.Drawing.Font("Tahoma", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.GroupBox1.Location = new global::System.Drawing.Point(287, 523);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new global::System.Drawing.Size(441, 72);
			this.GroupBox1.TabIndex = 75;
			this.GroupBox1.TabStop = false;
			this.InformationBindingSource.DataSource = typeof(global::CLOC_Couter.information);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(898, 604);
			base.Controls.Add(this.grdResult);
			base.Controls.Add(this.btnExport);
			base.Controls.Add(this.GroupBox1);
			base.Controls.Add(this.txtHeSo);
			base.Controls.Add(this.Label1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.MaximizeBox = false;
			base.Name = "frmResultCountFile";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kết quả";
			((global::System.ComponentModel.ISupportInitialize)this.grdResult).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.InformationBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000065 RID: 101
		private global::System.ComponentModel.IContainer components;
	}
}
