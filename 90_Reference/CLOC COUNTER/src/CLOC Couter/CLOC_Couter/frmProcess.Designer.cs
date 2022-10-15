namespace CLOC_Couter
{
	// Token: 0x02000012 RID: 18
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmProcess : global::System.Windows.Forms.Form
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
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

		// Token: 0x06000165 RID: 357 RVA: 0x0000CE00 File Offset: 0x0000B000
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.Blue;
			this.Label1.Location = new global::System.Drawing.Point(83, 35);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(116, 19);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Đang xử lý ...";
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.GroupBox1.Location = new global::System.Drawing.Point(4, -3);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.GroupBox1.Size = new global::System.Drawing.Size(209, 80);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Label3.Image = global::CLOC_Couter.My.Resources.Resources.timg11;
			this.Label3.Location = new global::System.Drawing.Point(3, 12);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(73, 65);
			this.Label3.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(215, 81);
			base.Controls.Add(this.GroupBox1);
			this.Font = new global::System.Drawing.Font("MS UI Gothic", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 128);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			base.Name = "frmProcess";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Process";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000093 RID: 147
		private global::System.ComponentModel.IContainer components;
	}
}
