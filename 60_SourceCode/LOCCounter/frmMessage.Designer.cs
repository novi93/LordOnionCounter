namespace MS.IT.LOC.UI
{
	// Token: 0x02000004 RID: 4
	public partial class frmMessage : global::System.Windows.Forms.Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002978 File Offset: 0x00001978
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029B0 File Offset: 0x000019B0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmMessage));
			this.admit = new global::System.Windows.Forms.Button();
			this.cancel = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.detail = new global::System.Windows.Forms.Button();
			this.txtShowMsg = new global::System.Windows.Forms.TextBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.admit.Location = new global::System.Drawing.Point(202, 76);
			this.admit.Name = "admit";
			this.admit.Size = new global::System.Drawing.Size(75, 23);
			this.admit.TabIndex = 2;
			this.admit.Text = "&Ok";
			this.admit.UseVisualStyleBackColor = true;
			this.admit.Click += new global::System.EventHandler(this.admit_Click);
			this.cancel.Location = new global::System.Drawing.Point(297, 76);
			this.cancel.Name = "cancel";
			this.cancel.Size = new global::System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 3;
			this.cancel.Text = "&Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new global::System.EventHandler(this.admit_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(103, 25);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(204, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "There are some files can't be downloaded";
			this.detail.Location = new global::System.Drawing.Point(21, 76);
			this.detail.Name = "detail";
			this.detail.Size = new global::System.Drawing.Size(75, 23);
			this.detail.TabIndex = 6;
			this.detail.Text = "&Detail";
			this.detail.UseVisualStyleBackColor = true;
			this.detail.Click += new global::System.EventHandler(this.detail_Click);
			this.txtShowMsg.Location = new global::System.Drawing.Point(12, 108);
			this.txtShowMsg.Multiline = true;
			this.txtShowMsg.Name = "txtShowMsg";
			this.txtShowMsg.ReadOnly = true;
			this.txtShowMsg.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtShowMsg.Size = new global::System.Drawing.Size(360, 152);
			this.txtShowMsg.TabIndex = 9;
			this.txtShowMsg.Visible = false;
			this.txtShowMsg.WordWrap = false;
			this.pictureBox1.BackgroundImage = global::MS.IT.LOC.UI.Properties.Resources.ErrorPic;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(21, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(55, 54);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			base.ClientSize = new global::System.Drawing.Size(384, 120);
			base.Controls.Add(this.txtShowMsg);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.detail);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.cancel);
			base.Controls.Add(this.admit);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmMessage";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Download Error";
			base.Load += new global::System.EventHandler(this.frmMessage_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button admit;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button cancel;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button detail;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TextBox txtShowMsg;
	}
}
