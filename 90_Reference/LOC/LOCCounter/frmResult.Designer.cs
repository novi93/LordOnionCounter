namespace MS.IT.LOC.UI
{
	// Token: 0x02000024 RID: 36
	public partial class frmResult : global::System.Windows.Forms.Form
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00012FD0 File Offset: 0x00011FD0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00013008 File Offset: 0x00012008
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmResult));
			this.pnlTop = new global::System.Windows.Forms.Panel();
			this.tabCtlResult = new global::System.Windows.Forms.TabControl();
			this.tabPageMReport = new global::System.Windows.Forms.TabPage();
			this.listViewMReport = new global::System.Windows.Forms.ListView();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.tabPageFiles = new global::System.Windows.Forms.TabPage();
			this.lvWItems = new global::System.Windows.Forms.ListView();
			this.colName = new global::System.Windows.Forms.ColumnHeader();
			this.colBase = new global::System.Windows.Forms.ColumnHeader();
			this.colAdded = new global::System.Windows.Forms.ColumnHeader();
			this.colModified = new global::System.Windows.Forms.ColumnHeader();
			this.colDeleted = new global::System.Windows.Forms.ColumnHeader();
			this.colAddedAndcolModified = new global::System.Windows.Forms.ColumnHeader();
			this.tabPageFolders = new global::System.Windows.Forms.TabPage();
			this.listViewFolders = new global::System.Windows.Forms.ListView();
			this.colFolderList = new global::System.Windows.Forms.ColumnHeader();
			this.colFolderBase = new global::System.Windows.Forms.ColumnHeader();
			this.colFolderAdd = new global::System.Windows.Forms.ColumnHeader();
			this.colFolderModify = new global::System.Windows.Forms.ColumnHeader();
			this.colFolderDelete = new global::System.Windows.Forms.ColumnHeader();
			this.colFolderAddModify = new global::System.Windows.Forms.ColumnHeader();
			this.tabPageExcluded = new global::System.Windows.Forms.TabPage();
			this.listViewExcluded = new global::System.Windows.Forms.ListView();
			this.colExcludeName = new global::System.Windows.Forms.ColumnHeader();
			this.colExcludeCounts = new global::System.Windows.Forms.ColumnHeader();
			this.tabPageLanguage = new global::System.Windows.Forms.TabPage();
			this.listViewLanguage = new global::System.Windows.Forms.ListView();
			this.colLanguageName = new global::System.Windows.Forms.ColumnHeader();
			this.colLanguageBase = new global::System.Windows.Forms.ColumnHeader();
			this.colLanguageAdd = new global::System.Windows.Forms.ColumnHeader();
			this.colLanguageModify = new global::System.Windows.Forms.ColumnHeader();
			this.colLanguageDelete = new global::System.Windows.Forms.ColumnHeader();
			this.colLanguageAddModify = new global::System.Windows.Forms.ColumnHeader();
			this.tabPspMetricsSummary = new global::System.Windows.Forms.TabPage();
			this.listViewPspSummary = new global::System.Windows.Forms.ListView();
			this.colFilePath = new global::System.Windows.Forms.ColumnHeader();
			this.colTagType = new global::System.Windows.Forms.ColumnHeader();
			this.colTagValue = new global::System.Windows.Forms.ColumnHeader();
			this.colObjectType = new global::System.Windows.Forms.ColumnHeader();
			this.colPspSElements = new global::System.Windows.Forms.ColumnHeader();
			this.colPspSBase = new global::System.Windows.Forms.ColumnHeader();
			this.colPspSAdded = new global::System.Windows.Forms.ColumnHeader();
			this.tabPspSModified = new global::System.Windows.Forms.ColumnHeader();
			this.colPspSDeleted = new global::System.Windows.Forms.ColumnHeader();
			this.colPspSAM = new global::System.Windows.Forms.ColumnHeader();
			this.tabPspMetricsDetails = new global::System.Windows.Forms.TabPage();
			this.listViewPspDetails = new global::System.Windows.Forms.ListView();
			this.tabPspDFilePath = new global::System.Windows.Forms.ColumnHeader();
			this.colPspDTagType = new global::System.Windows.Forms.ColumnHeader();
			this.colPspDTagName = new global::System.Windows.Forms.ColumnHeader();
			this.colPsDStatus = new global::System.Windows.Forms.ColumnHeader();
			this.tabPspDBase = new global::System.Windows.Forms.ColumnHeader();
			this.colPspDAdd = new global::System.Windows.Forms.ColumnHeader();
			this.colPspDModify = new global::System.Windows.Forms.ColumnHeader();
			this.colPspDDelete = new global::System.Windows.Forms.ColumnHeader();
			this.colPspDAM = new global::System.Windows.Forms.ColumnHeader();
			this.pnlBottom = new global::System.Windows.Forms.Panel();
			this.btnPspReport = new global::System.Windows.Forms.Button();
			this.lblStandardFrom = new global::System.Windows.Forms.Label();
			this.lblFrom = new global::System.Windows.Forms.Label();
			this.lblStandardVersion = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnViewReport = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.colPspDParentName = new global::System.Windows.Forms.ColumnHeader();
			this.pnlTop.SuspendLayout();
			this.tabCtlResult.SuspendLayout();
			this.tabPageMReport.SuspendLayout();
			this.tabPageFiles.SuspendLayout();
			this.tabPageFolders.SuspendLayout();
			this.tabPageExcluded.SuspendLayout();
			this.tabPageLanguage.SuspendLayout();
			this.tabPspMetricsSummary.SuspendLayout();
			this.tabPspMetricsDetails.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			base.SuspendLayout();
			this.pnlTop.Controls.Add(this.tabCtlResult);
			this.pnlTop.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlTop.Location = new global::System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new global::System.Drawing.Size(709, 335);
			this.pnlTop.TabIndex = 3;
			this.tabCtlResult.Controls.Add(this.tabPageMReport);
			this.tabCtlResult.Controls.Add(this.tabPageFiles);
			this.tabCtlResult.Controls.Add(this.tabPageFolders);
			this.tabCtlResult.Controls.Add(this.tabPageExcluded);
			this.tabCtlResult.Controls.Add(this.tabPageLanguage);
			this.tabCtlResult.Controls.Add(this.tabPspMetricsSummary);
			this.tabCtlResult.Controls.Add(this.tabPspMetricsDetails);
			this.tabCtlResult.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabCtlResult.Location = new global::System.Drawing.Point(0, 0);
			this.tabCtlResult.Name = "tabCtlResult";
			this.tabCtlResult.SelectedIndex = 0;
			this.tabCtlResult.Size = new global::System.Drawing.Size(709, 335);
			this.tabCtlResult.TabIndex = 0;
			this.tabPageMReport.Controls.Add(this.listViewMReport);
			this.tabPageMReport.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageMReport.Name = "tabPageMReport";
			this.tabPageMReport.Size = new global::System.Drawing.Size(701, 309);
			this.tabPageMReport.TabIndex = 8;
			this.tabPageMReport.Text = "Task Summary";
			this.tabPageMReport.UseVisualStyleBackColor = true;
			this.listViewMReport.AllowColumnReorder = true;
			this.listViewMReport.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader3,
				this.columnHeader4,
				this.columnHeader5
			});
			this.listViewMReport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewMReport.FullRowSelect = true;
			this.listViewMReport.GridLines = true;
			this.listViewMReport.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewMReport.Location = new global::System.Drawing.Point(0, 0);
			this.listViewMReport.Name = "listViewMReport";
			this.listViewMReport.Size = new global::System.Drawing.Size(701, 309);
			this.listViewMReport.TabIndex = 5;
			this.listViewMReport.UseCompatibleStateImageBehavior = false;
			this.listViewMReport.View = global::System.Windows.Forms.View.Details;
			this.columnHeader3.Text = "Metric";
			this.columnHeader3.Width = 140;
			this.columnHeader4.Text = "Description";
			this.columnHeader4.Width = 302;
			this.columnHeader5.Text = "Data";
			this.columnHeader5.Width = 307;
			this.tabPageFiles.Controls.Add(this.lvWItems);
			this.tabPageFiles.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageFiles.Name = "tabPageFiles";
			this.tabPageFiles.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageFiles.Size = new global::System.Drawing.Size(701, 309);
			this.tabPageFiles.TabIndex = 0;
			this.tabPageFiles.Text = "Files";
			this.tabPageFiles.UseVisualStyleBackColor = true;
			this.lvWItems.AllowColumnReorder = true;
			this.lvWItems.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colName,
				this.colBase,
				this.colAdded,
				this.colModified,
				this.colDeleted,
				this.colAddedAndcolModified
			});
			this.lvWItems.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lvWItems.FullRowSelect = true;
			this.lvWItems.GridLines = true;
			this.lvWItems.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvWItems.Location = new global::System.Drawing.Point(3, 3);
			this.lvWItems.Name = "lvWItems";
			this.lvWItems.Size = new global::System.Drawing.Size(695, 303);
			this.lvWItems.TabIndex = 3;
			this.lvWItems.UseCompatibleStateImageBehavior = false;
			this.lvWItems.View = global::System.Windows.Forms.View.Details;
			this.colName.Text = "File Path";
			this.colName.Width = 586;
			this.colBase.Text = "Base";
			this.colBase.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colAdded.Text = "Added";
			this.colAdded.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colModified.Text = "Modified";
			this.colModified.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colDeleted.Text = "Deleted";
			this.colDeleted.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colAddedAndcolModified.Text = "Added+Modified";
			this.colAddedAndcolModified.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colAddedAndcolModified.Width = 110;
			this.tabPageFolders.Controls.Add(this.listViewFolders);
			this.tabPageFolders.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageFolders.Name = "tabPageFolders";
			this.tabPageFolders.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageFolders.Size = new global::System.Drawing.Size(701, 309);
			this.tabPageFolders.TabIndex = 1;
			this.tabPageFolders.Text = "Folders";
			this.tabPageFolders.UseVisualStyleBackColor = true;
			this.listViewFolders.AllowColumnReorder = true;
			this.listViewFolders.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colFolderList,
				this.colFolderBase,
				this.colFolderAdd,
				this.colFolderModify,
				this.colFolderDelete,
				this.colFolderAddModify
			});
			this.listViewFolders.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewFolders.FullRowSelect = true;
			this.listViewFolders.GridLines = true;
			this.listViewFolders.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewFolders.Location = new global::System.Drawing.Point(3, 3);
			this.listViewFolders.Name = "listViewFolders";
			this.listViewFolders.Size = new global::System.Drawing.Size(695, 303);
			this.listViewFolders.TabIndex = 4;
			this.listViewFolders.UseCompatibleStateImageBehavior = false;
			this.listViewFolders.View = global::System.Windows.Forms.View.Details;
			this.colFolderList.Text = "Folder List";
			this.colFolderList.Width = 586;
			this.colFolderBase.Text = "Base";
			this.colFolderBase.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colFolderAdd.Text = "Added";
			this.colFolderAdd.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colFolderModify.Text = "Modified";
			this.colFolderModify.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colFolderDelete.Text = "Deleted";
			this.colFolderDelete.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colFolderAddModify.Text = "Added+Modified";
			this.colFolderAddModify.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colFolderAddModify.Width = 110;
			this.tabPageExcluded.Controls.Add(this.listViewExcluded);
			this.tabPageExcluded.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageExcluded.Name = "tabPageExcluded";
			this.tabPageExcluded.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageExcluded.Size = new global::System.Drawing.Size(701, 309);
			this.tabPageExcluded.TabIndex = 2;
			this.tabPageExcluded.Text = "Excluded";
			this.tabPageExcluded.UseVisualStyleBackColor = true;
			this.listViewExcluded.AllowColumnReorder = true;
			this.listViewExcluded.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colExcludeName,
				this.colExcludeCounts
			});
			this.listViewExcluded.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewExcluded.FullRowSelect = true;
			this.listViewExcluded.GridLines = true;
			this.listViewExcluded.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewExcluded.Location = new global::System.Drawing.Point(3, 3);
			this.listViewExcluded.Name = "listViewExcluded";
			this.listViewExcluded.Size = new global::System.Drawing.Size(695, 303);
			this.listViewExcluded.TabIndex = 5;
			this.listViewExcluded.UseCompatibleStateImageBehavior = false;
			this.listViewExcluded.View = global::System.Windows.Forms.View.Details;
			this.colExcludeName.Text = "Excluded Name";
			this.colExcludeName.Width = 586;
			this.colExcludeCounts.Text = "Counts";
			this.colExcludeCounts.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.tabPageLanguage.Controls.Add(this.listViewLanguage);
			this.tabPageLanguage.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageLanguage.Name = "tabPageLanguage";
			this.tabPageLanguage.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageLanguage.Size = new global::System.Drawing.Size(701, 309);
			this.tabPageLanguage.TabIndex = 6;
			this.tabPageLanguage.Text = "Language";
			this.tabPageLanguage.UseVisualStyleBackColor = true;
			this.listViewLanguage.AllowColumnReorder = true;
			this.listViewLanguage.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colLanguageName,
				this.colLanguageBase,
				this.colLanguageAdd,
				this.colLanguageModify,
				this.colLanguageDelete,
				this.colLanguageAddModify
			});
			this.listViewLanguage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewLanguage.FullRowSelect = true;
			this.listViewLanguage.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewLanguage.Location = new global::System.Drawing.Point(3, 3);
			this.listViewLanguage.Name = "listViewLanguage";
			this.listViewLanguage.Size = new global::System.Drawing.Size(695, 303);
			this.listViewLanguage.TabIndex = 6;
			this.listViewLanguage.UseCompatibleStateImageBehavior = false;
			this.listViewLanguage.View = global::System.Windows.Forms.View.Details;
			this.colLanguageName.Text = "Language List";
			this.colLanguageName.Width = 586;
			this.colLanguageBase.Text = "Base";
			this.colLanguageBase.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colLanguageAdd.Text = "Added";
			this.colLanguageAdd.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colLanguageModify.Text = "Modified";
			this.colLanguageModify.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colLanguageDelete.Text = "Deleted";
			this.colLanguageDelete.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colLanguageAddModify.Text = "Added+Modified";
			this.colLanguageAddModify.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colLanguageAddModify.Width = 110;
			this.tabPspMetricsSummary.Controls.Add(this.listViewPspSummary);
			this.tabPspMetricsSummary.Location = new global::System.Drawing.Point(4, 22);
			this.tabPspMetricsSummary.Name = "tabPspMetricsSummary";
			this.tabPspMetricsSummary.Size = new global::System.Drawing.Size(701, 309);
			this.tabPspMetricsSummary.TabIndex = 9;
			this.tabPspMetricsSummary.Text = "PSP Metrics Summary";
			this.tabPspMetricsSummary.UseVisualStyleBackColor = true;
			this.listViewPspSummary.AllowColumnReorder = true;
			this.listViewPspSummary.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colFilePath,
				this.colTagType,
				this.colTagValue,
				this.colObjectType,
				this.colPspSElements,
				this.colPspSBase,
				this.colPspSAdded,
				this.tabPspSModified,
				this.colPspSDeleted,
				this.colPspSAM
			});
			this.listViewPspSummary.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewPspSummary.FullRowSelect = true;
			this.listViewPspSummary.GridLines = true;
			this.listViewPspSummary.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewPspSummary.Location = new global::System.Drawing.Point(0, 0);
			this.listViewPspSummary.Name = "listViewPspSummary";
			this.listViewPspSummary.Size = new global::System.Drawing.Size(701, 309);
			this.listViewPspSummary.TabIndex = 4;
			this.listViewPspSummary.UseCompatibleStateImageBehavior = false;
			this.listViewPspSummary.View = global::System.Windows.Forms.View.Details;
			this.colFilePath.Text = "File Path";
			this.colFilePath.Width = 146;
			this.colTagType.Text = "Metric Type";
			this.colTagType.Width = 70;
			this.colTagValue.Text = "Metric Value";
			this.colTagValue.Width = 80;
			this.colObjectType.Text = "Object Type";
			this.colObjectType.Width = 73;
			this.colPspSElements.Text = "Number of Elements";
			this.colPspSElements.Width = 110;
			this.colPspSBase.Text = "Base";
			this.colPspSBase.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspSBase.Width = 49;
			this.colPspSAdded.Text = "Added";
			this.colPspSAdded.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspSAdded.Width = 52;
			this.tabPspSModified.Text = "Modified";
			this.tabPspSModified.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspSDeleted.Text = "Deleted";
			this.colPspSDeleted.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspSDeleted.Width = 57;
			this.colPspSAM.Text = "Added+Modified";
			this.colPspSAM.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspSAM.Width = 90;
			this.tabPspMetricsDetails.Controls.Add(this.listViewPspDetails);
			this.tabPspMetricsDetails.Location = new global::System.Drawing.Point(4, 22);
			this.tabPspMetricsDetails.Name = "tabPspMetricsDetails";
			this.tabPspMetricsDetails.Size = new global::System.Drawing.Size(701, 309);
			this.tabPspMetricsDetails.TabIndex = 10;
			this.tabPspMetricsDetails.Text = "PSP Metrics Details";
			this.tabPspMetricsDetails.UseVisualStyleBackColor = true;
			this.listViewPspDetails.AllowColumnReorder = true;
			this.listViewPspDetails.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.tabPspDFilePath,
				this.colPspDTagType,
				this.colPspDTagName,
				this.colPspDParentName,
				this.colPsDStatus,
				this.tabPspDBase,
				this.colPspDAdd,
				this.colPspDModify,
				this.colPspDDelete,
				this.colPspDAM
			});
			this.listViewPspDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewPspDetails.FullRowSelect = true;
			this.listViewPspDetails.GridLines = true;
			this.listViewPspDetails.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewPspDetails.Location = new global::System.Drawing.Point(0, 0);
			this.listViewPspDetails.Name = "listViewPspDetails";
			this.listViewPspDetails.Size = new global::System.Drawing.Size(701, 309);
			this.listViewPspDetails.TabIndex = 4;
			this.listViewPspDetails.UseCompatibleStateImageBehavior = false;
			this.listViewPspDetails.View = global::System.Windows.Forms.View.Details;
			this.tabPspDFilePath.Text = "File Path";
			this.tabPspDFilePath.Width = 250;
			this.colPspDTagType.Text = "Metric Type";
			this.colPspDTagType.Width = 70;
			this.colPspDTagName.Text = "Metric Value";
			this.colPspDTagName.Width = 80;
			this.colPsDStatus.Text = "Status";
			this.tabPspDBase.Text = "Base";
			this.tabPspDBase.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.tabPspDBase.Width = 47;
			this.colPspDAdd.Text = "Added";
			this.colPspDAdd.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspDAdd.Width = 53;
			this.colPspDModify.Text = "Modified";
			this.colPspDModify.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspDModify.Width = 58;
			this.colPspDDelete.Text = "Deleted";
			this.colPspDDelete.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspDDelete.Width = 53;
			this.colPspDAM.Text = "Added+Modified";
			this.colPspDAM.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colPspDAM.Width = 90;
			this.pnlBottom.Controls.Add(this.btnPspReport);
			this.pnlBottom.Controls.Add(this.lblStandardFrom);
			this.pnlBottom.Controls.Add(this.lblFrom);
			this.pnlBottom.Controls.Add(this.lblStandardVersion);
			this.pnlBottom.Controls.Add(this.label1);
			this.pnlBottom.Controls.Add(this.btnViewReport);
			this.pnlBottom.Controls.Add(this.btnCancel);
			this.pnlBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new global::System.Drawing.Point(0, 335);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new global::System.Drawing.Size(709, 63);
			this.pnlBottom.TabIndex = 4;
			this.btnPspReport.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnPspReport.Location = new global::System.Drawing.Point(306, 8);
			this.btnPspReport.Name = "btnPspReport";
			this.btnPspReport.Size = new global::System.Drawing.Size(120, 23);
			this.btnPspReport.TabIndex = 11;
			this.btnPspReport.Text = "View PSP Report";
			this.btnPspReport.UseVisualStyleBackColor = true;
			this.btnPspReport.Click += new global::System.EventHandler(this.btnPspReport_Click);
			this.lblStandardFrom.AutoSize = true;
			this.lblStandardFrom.Location = new global::System.Drawing.Point(241, 41);
			this.lblStandardFrom.Name = "lblStandardFrom";
			this.lblStandardFrom.Size = new global::System.Drawing.Size(10, 13);
			this.lblStandardFrom.TabIndex = 10;
			this.lblStandardFrom.Text = " ";
			this.lblFrom.AutoSize = true;
			this.lblFrom.Location = new global::System.Drawing.Point(202, 41);
			this.lblFrom.Name = "lblFrom";
			this.lblFrom.Size = new global::System.Drawing.Size(33, 13);
			this.lblFrom.TabIndex = 9;
			this.lblFrom.Text = "From:";
			this.lblStandardVersion.AutoSize = true;
			this.lblStandardVersion.Location = new global::System.Drawing.Point(154, 41);
			this.lblStandardVersion.Name = "lblStandardVersion";
			this.lblStandardVersion.Size = new global::System.Drawing.Size(22, 13);
			this.lblStandardVersion.TabIndex = 8;
			this.lblStandardVersion.Text = "1.0";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(136, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Counting Standard Version:";
			this.btnViewReport.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnViewReport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnViewReport.Location = new global::System.Drawing.Point(148, 8);
			this.btnViewReport.Name = "btnViewReport";
			this.btnViewReport.Size = new global::System.Drawing.Size(87, 23);
			this.btnViewReport.TabIndex = 5;
			this.btnViewReport.Text = "&View Report";
			this.btnViewReport.UseVisualStyleBackColor = true;
			this.btnViewReport.Click += new global::System.EventHandler(this.btnViewReport_Click);
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnCancel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new global::System.Drawing.Point(503, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(87, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&Close";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.colPspDParentName.Text = "Parent";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(709, 398);
			base.Controls.Add(this.pnlTop);
			base.Controls.Add(this.pnlBottom);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmResult";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Result";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Shown += new global::System.EventHandler(this.OnShow);
			this.pnlTop.ResumeLayout(false);
			this.tabCtlResult.ResumeLayout(false);
			this.tabPageMReport.ResumeLayout(false);
			this.tabPageFiles.ResumeLayout(false);
			this.tabPageFolders.ResumeLayout(false);
			this.tabPageExcluded.ResumeLayout(false);
			this.tabPageLanguage.ResumeLayout(false);
			this.tabPspMetricsSummary.ResumeLayout(false);
			this.tabPspMetricsDetails.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400012F RID: 303
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.Panel pnlTop;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.Panel pnlBottom;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.Button btnViewReport;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.Label lblStandardFrom;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Label lblFrom;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.Label lblStandardVersion;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.TabControl tabCtlResult;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.TabPage tabPageFiles;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.ListView lvWItems;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.ColumnHeader colName;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.ColumnHeader colBase;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.ColumnHeader colAdded;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.ColumnHeader colModified;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.ColumnHeader colDeleted;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.ColumnHeader colAddedAndcolModified;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.TabPage tabPageFolders;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.TabPage tabPageExcluded;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.TabPage tabPageLanguage;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.ListView listViewFolders;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.ColumnHeader colFolderList;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.ColumnHeader colFolderBase;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.ColumnHeader colFolderAdd;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.ColumnHeader colFolderModify;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.ColumnHeader colFolderDelete;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.ColumnHeader colFolderAddModify;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.ListView listViewExcluded;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.ColumnHeader colExcludeName;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.ColumnHeader colExcludeCounts;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.ListView listViewLanguage;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.ColumnHeader colLanguageName;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.ColumnHeader colLanguageBase;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.ColumnHeader colLanguageAdd;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.ColumnHeader colLanguageModify;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.ColumnHeader colLanguageDelete;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.ColumnHeader colLanguageAddModify;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.TabPage tabPageMReport;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.ListView listViewMReport;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.ColumnHeader columnHeader5;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.TabPage tabPspMetricsSummary;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.TabPage tabPspMetricsDetails;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.ListView listViewPspSummary;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.ColumnHeader colFilePath;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.ColumnHeader colPspSBase;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.ColumnHeader colPspSAdded;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.ColumnHeader tabPspSModified;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.ColumnHeader colPspSDeleted;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.ColumnHeader colPspSAM;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.ColumnHeader colTagType;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.ColumnHeader colObjectType;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.ColumnHeader colPspSElements;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.ListView listViewPspDetails;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.ColumnHeader tabPspDFilePath;

		// Token: 0x04000168 RID: 360
		private global::System.Windows.Forms.ColumnHeader tabPspDBase;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.ColumnHeader colPspDAdd;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.ColumnHeader colPspDModify;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Forms.ColumnHeader colPspDDelete;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.ColumnHeader colPspDAM;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.ColumnHeader colPspDTagType;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.ColumnHeader colPspDTagName;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.ColumnHeader colTagValue;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.ColumnHeader colPsDStatus;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.Button btnPspReport;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.ColumnHeader colPspDParentName;
	}
}
