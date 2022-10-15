namespace CLOC_Couter
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmSelectFileRepository : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00008304 File Offset: 0x00006504
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

		// Token: 0x060000B6 RID: 182 RVA: 0x00008354 File Offset: 0x00006554
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.treResult = new global::System.Windows.Forms.TreeView();
			base.SuspendLayout();
			this.btnCancel.Location = new global::System.Drawing.Point(309, 618);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(76, 25);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnOK.Location = new global::System.Drawing.Point(162, 618);
			this.btnOK.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(77, 26);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "Chọn";
			this.btnOK.UseVisualStyleBackColor = true;
			this.treResult.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.treResult.CheckBoxes = true;
			this.treResult.Font = new global::System.Drawing.Font("Times New Roman", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.treResult.FullRowSelect = true;
			this.treResult.Location = new global::System.Drawing.Point(7, 13);
			this.treResult.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.treResult.Name = "treResult";
			this.treResult.Size = new global::System.Drawing.Size(570, 597);
			this.treResult.TabIndex = 8;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(589, 657);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.treResult);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			base.Name = "frmSelectFileRepository";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Chọn file cần tính";
			base.ResumeLayout(false);
		}

		// Token: 0x0400004D RID: 77
		private global::System.ComponentModel.IContainer components;
	}
}
