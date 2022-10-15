namespace CLOC_Couter
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmSelectFileorFolder : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00008EA0 File Offset: 0x000070A0
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

		// Token: 0x060000D7 RID: 215 RVA: 0x00008EF0 File Offset: 0x000070F0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtPath = new global::System.Windows.Forms.TextBox();
			this.btnForderDialog = new global::System.Windows.Forms.Button();
			this.treResult = new global::System.Windows.Forms.TreeView();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(15, 15);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(48, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Thư mục";
			this.txtPath.Location = new global::System.Drawing.Point(63, 12);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new global::System.Drawing.Size(373, 21);
			this.txtPath.TabIndex = 1;
			this.btnForderDialog.Location = new global::System.Drawing.Point(441, 12);
			this.btnForderDialog.Name = "btnForderDialog";
			this.btnForderDialog.Size = new global::System.Drawing.Size(47, 18);
			this.btnForderDialog.TabIndex = 2;
			this.btnForderDialog.Text = "...";
			this.btnForderDialog.UseVisualStyleBackColor = true;
			this.treResult.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.treResult.CheckBoxes = true;
			this.treResult.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.treResult.FullRowSelect = true;
			this.treResult.Location = new global::System.Drawing.Point(14, 42);
			this.treResult.Name = "treResult";
			this.treResult.Size = new global::System.Drawing.Size(607, 577);
			this.treResult.TabIndex = 3;
			this.btnOK.Location = new global::System.Drawing.Point(214, 636);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(66, 21);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Chọn";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnCancel.Location = new global::System.Drawing.Point(340, 636);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(65, 20);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(633, 662);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.treResult);
			base.Controls.Add(this.btnForderDialog);
			base.Controls.Add(this.txtPath);
			base.Controls.Add(this.Label1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "frmSelectFileorFolder";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn thư mục hoặc tập tin cần tính";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005A RID: 90
		private global::System.ComponentModel.IContainer components;
	}
}
