namespace MS.IT.LOC.UI
{
	// Token: 0x02000011 RID: 17
	public partial class frmMode : global::System.Windows.Forms.Form
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0000D298 File Offset: 0x0000C298
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000D2D0 File Offset: 0x0000C2D0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmMode));
			this.rdModeShared = new global::System.Windows.Forms.RadioButton();
			this.rdModeLocal = new global::System.Windows.Forms.RadioButton();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.panelSqlConfig = new global::System.Windows.Forms.Panel();
			this.btnTest = new global::System.Windows.Forms.Button();
			this.txtDb = new global::System.Windows.Forms.TextBox();
			this.txtServer = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnApply = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.panelSqlConfig.SuspendLayout();
			base.SuspendLayout();
			this.rdModeShared.AutoSize = true;
			this.rdModeShared.Location = new global::System.Drawing.Point(23, 73);
			this.rdModeShared.Name = "rdModeShared";
			this.rdModeShared.Size = new global::System.Drawing.Size(59, 17);
			this.rdModeShared.TabIndex = 1;
			this.rdModeShared.Text = "Shared";
			this.rdModeShared.UseVisualStyleBackColor = true;
			this.rdModeShared.CheckedChanged += new global::System.EventHandler(this.rdModeShared_CheckedChanged);
			this.rdModeLocal.AutoSize = true;
			this.rdModeLocal.Checked = true;
			this.rdModeLocal.Location = new global::System.Drawing.Point(23, 20);
			this.rdModeLocal.Name = "rdModeLocal";
			this.rdModeLocal.Size = new global::System.Drawing.Size(51, 17);
			this.rdModeLocal.TabIndex = 0;
			this.rdModeLocal.TabStop = true;
			this.rdModeLocal.Text = "Local";
			this.rdModeLocal.UseVisualStyleBackColor = true;
			this.rdModeLocal.CheckedChanged += new global::System.EventHandler(this.rdModeLocal_CheckedChanged);
			this.groupBox1.Controls.Add(this.panelSqlConfig);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rdModeLocal);
			this.groupBox1.Controls.Add(this.rdModeShared);
			this.groupBox1.Location = new global::System.Drawing.Point(20, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(390, 251);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mode";
			this.panelSqlConfig.Controls.Add(this.btnTest);
			this.panelSqlConfig.Controls.Add(this.txtDb);
			this.panelSqlConfig.Controls.Add(this.txtServer);
			this.panelSqlConfig.Controls.Add(this.label5);
			this.panelSqlConfig.Controls.Add(this.label4);
			this.panelSqlConfig.Enabled = false;
			this.panelSqlConfig.Location = new global::System.Drawing.Point(23, 137);
			this.panelSqlConfig.Name = "panelSqlConfig";
			this.panelSqlConfig.Size = new global::System.Drawing.Size(337, 98);
			this.panelSqlConfig.TabIndex = 6;
			this.btnTest.Location = new global::System.Drawing.Point(240, 69);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new global::System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 4;
			this.btnTest.Text = "Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new global::System.EventHandler(this.btnTest_Click);
			this.txtDb.Location = new global::System.Drawing.Point(100, 43);
			this.txtDb.Name = "txtDb";
			this.txtDb.Size = new global::System.Drawing.Size(215, 20);
			this.txtDb.TabIndex = 3;
			this.txtDb.TextChanged += new global::System.EventHandler(this.txtDb_TextChanged);
			this.txtServer.Location = new global::System.Drawing.Point(100, 13);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new global::System.Drawing.Size(215, 20);
			this.txtServer.TabIndex = 2;
			this.txtServer.TextChanged += new global::System.EventHandler(this.txtServer_TextChanged);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(16, 43);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(53, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Database";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(16, 13);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(62, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "SQL Server";
			this.label3.Location = new global::System.Drawing.Point(20, 93);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(340, 41);
			this.label3.TabIndex = 5;
			this.label3.Text = "Requires SQL server for storing counter task and counter results.  Canned Reports can be generated on counter results saved using this mode. ";
			this.label2.Location = new global::System.Drawing.Point(20, 40);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(340, 30);
			this.label2.TabIndex = 4;
			this.label2.Text = "Counter task configuration would be locally stored. Counter results will not be stored. Canned reports cannot be used in this mode.";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(93, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Set Counter Mode";
			this.btnApply.Location = new global::System.Drawing.Point(137, 280);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new global::System.Drawing.Size(75, 23);
			this.btnApply.TabIndex = 4;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new global::System.EventHandler(this.btnApply_Click);
			this.btnCancel.Location = new global::System.Drawing.Point(218, 280);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			base.AcceptButton = this.btnApply;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(431, 312);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnApply);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmMode";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Counter Mode";
			base.Load += new global::System.EventHandler(this.frmMode_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panelSqlConfig.ResumeLayout(false);
			this.panelSqlConfig.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000D1 RID: 209
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.RadioButton rdModeShared;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.RadioButton rdModeLocal;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Button btnApply;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Panel panelSqlConfig;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Button btnTest;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.TextBox txtDb;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.TextBox txtServer;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Button btnCancel;
	}
}
