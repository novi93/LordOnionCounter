namespace MS.IT.LOC.UI
{
	// Token: 0x0200000B RID: 11
	public partial class frmCounterItems : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000045DC File Offset: 0x000035DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004614 File Offset: 0x00003614
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmCounterItems));
			this.conMenuMain = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.configureToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer = new global::System.Windows.Forms.SplitContainer();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.lblMethodology = new global::System.Windows.Forms.Label();
			this.lblApplication = new global::System.Windows.Forms.Label();
			this.lblQuarter = new global::System.Windows.Forms.Label();
			this.cboMethodology = new global::System.Windows.Forms.ComboBox();
			this.cboApplication = new global::System.Windows.Forms.ComboBox();
			this.cboQuarter = new global::System.Windows.Forms.ComboBox();
			this.lblFileters = new global::System.Windows.Forms.Label();
			this.toolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.toolStripButtonNew = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripButtonUpdate = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDelete = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSave = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonConfiguration = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonCount = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonViewConfig = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCategories = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExit = new global::System.Windows.Forms.ToolStripButton();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.taskToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.configurationToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.countToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.eXitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.setupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.countingStandardToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.categoriesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kLOCReportToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kLOCByApplicationToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kLOCByQuarterByApplicationToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.userGuideToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.lvwCounterItems = new global::System.Windows.Forms.ListView();
			this.colCountAgain = new global::System.Windows.Forms.ColumnHeader();
			this.colCounterItem = new global::System.Windows.Forms.ColumnHeader();
			this.colCounterType = new global::System.Windows.Forms.ColumnHeader();
			this.colConfiguration = new global::System.Windows.Forms.ColumnHeader();
			this.colServerName = new global::System.Windows.Forms.ColumnHeader();
			this.colServerType = new global::System.Windows.Forms.ColumnHeader();
			this.lblTaskProperty = new global::System.Windows.Forms.Label();
			this.propertyGrid1 = new global::System.Windows.Forms.PropertyGrid();
			this.CounterDataDataSet = new global::MS.IT.LOC.UI.CounterDataDataSet();
			this.ReportQuery1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportQuery1TableAdapter = new global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.ReportQuery1TableAdapter();
			this.TotalLOCBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.TotalLOCTableAdapter = new global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.TotalLOCTableAdapter();
			this.conMenuMain.SuspendLayout();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.CounterDataDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ReportQuery1BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.TotalLOCBindingSource).BeginInit();
			base.SuspendLayout();
			this.conMenuMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addToolStripMenuItem,
				this.updateToolStripMenuItem,
				this.deleteToolStripMenuItem,
				this.toolStripMenuItem1,
				this.configureToolStripMenuItem
			});
			this.conMenuMain.Name = "conMenuMain";
			this.conMenuMain.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.conMenuMain.Size = new global::System.Drawing.Size(122, 98);
			this.addToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("addToolStripMenuItem.Image");
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new global::System.Drawing.Size(121, 22);
			this.addToolStripMenuItem.Text = "&New";
			this.addToolStripMenuItem.Click += new global::System.EventHandler(this.addToolStripMenuItem_Click);
			this.updateToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("updateToolStripMenuItem.Image");
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new global::System.Drawing.Size(121, 22);
			this.updateToolStripMenuItem.Text = "&Update";
			this.updateToolStripMenuItem.Click += new global::System.EventHandler(this.updateToolStripMenuItem_Click);
			this.deleteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("deleteToolStripMenuItem.Image");
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(121, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.deleteToolStripMenuItem_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(118, 6);
			this.configureToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("configureToolStripMenuItem.Image");
			this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			this.configureToolStripMenuItem.Size = new global::System.Drawing.Size(121, 22);
			this.configureToolStripMenuItem.Text = "&Configure";
			this.configureToolStripMenuItem.Click += new global::System.EventHandler(this.configureToolStripMenuItem_Click);
			this.splitContainer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer.Panel1.Controls.Add(this.panel1);
			this.splitContainer.Panel1.Controls.Add(this.menuStrip1);
			this.splitContainer.Panel1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.splitContainer.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainer.Size = new global::System.Drawing.Size(727, 394);
			this.splitContainer.SplitterDistance = 101;
			this.splitContainer.TabIndex = 0;
			this.panel1.Controls.Add(this.lblMethodology);
			this.panel1.Controls.Add(this.lblApplication);
			this.panel1.Controls.Add(this.lblQuarter);
			this.panel1.Controls.Add(this.cboMethodology);
			this.panel1.Controls.Add(this.cboApplication);
			this.panel1.Controls.Add(this.cboQuarter);
			this.panel1.Controls.Add(this.lblFileters);
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(727, 80);
			this.panel1.TabIndex = 21;
			this.lblMethodology.AutoSize = true;
			this.lblMethodology.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblMethodology.Location = new global::System.Drawing.Point(328, 32);
			this.lblMethodology.Name = "lblMethodology";
			this.lblMethodology.Size = new global::System.Drawing.Size(68, 13);
			this.lblMethodology.TabIndex = 43;
			this.lblMethodology.Text = "Methodology";
			this.lblApplication.AutoSize = true;
			this.lblApplication.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblApplication.Location = new global::System.Drawing.Point(192, 32);
			this.lblApplication.Name = "lblApplication";
			this.lblApplication.Size = new global::System.Drawing.Size(59, 13);
			this.lblApplication.TabIndex = 42;
			this.lblApplication.Text = "Application";
			this.lblQuarter.AutoSize = true;
			this.lblQuarter.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblQuarter.Location = new global::System.Drawing.Point(56, 32);
			this.lblQuarter.Name = "lblQuarter";
			this.lblQuarter.Size = new global::System.Drawing.Size(46, 13);
			this.lblQuarter.TabIndex = 41;
			this.lblQuarter.Text = "Release";
			this.cboMethodology.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMethodology.FormattingEnabled = true;
			this.cboMethodology.Location = new global::System.Drawing.Point(328, 49);
			this.cboMethodology.Name = "cboMethodology";
			this.cboMethodology.Size = new global::System.Drawing.Size(121, 21);
			this.cboMethodology.TabIndex = 39;
			this.cboMethodology.SelectionChangeCommitted += new global::System.EventHandler(this.cbo_SelectionChangeCommitted);
			this.cboMethodology.SelectedIndexChanged += new global::System.EventHandler(this.cboMethodology_SelectedIndexChanged);
			this.cboApplication.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboApplication.FormattingEnabled = true;
			this.cboApplication.Location = new global::System.Drawing.Point(192, 49);
			this.cboApplication.Name = "cboApplication";
			this.cboApplication.Size = new global::System.Drawing.Size(121, 21);
			this.cboApplication.TabIndex = 38;
			this.cboApplication.SelectionChangeCommitted += new global::System.EventHandler(this.cbo_SelectionChangeCommitted);
			this.cboQuarter.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboQuarter.FormattingEnabled = true;
			this.cboQuarter.Location = new global::System.Drawing.Point(56, 49);
			this.cboQuarter.Name = "cboQuarter";
			this.cboQuarter.Size = new global::System.Drawing.Size(121, 21);
			this.cboQuarter.TabIndex = 37;
			this.cboQuarter.SelectionChangeCommitted += new global::System.EventHandler(this.cbo_SelectionChangeCommitted);
			this.lblFileters.AutoSize = true;
			this.lblFileters.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblFileters.Location = new global::System.Drawing.Point(5, 53);
			this.lblFileters.Name = "lblFileters";
			this.lblFileters.Size = new global::System.Drawing.Size(41, 13);
			this.lblFileters.TabIndex = 40;
			this.lblFileters.Text = "Filters";
			this.toolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripButtonNew,
				this.toolStripButtonUpdate,
				this.toolStripButtonDelete,
				this.toolStripButtonSave,
				this.toolStripSeparator1,
				this.toolStripButtonConfiguration,
				this.toolStripSeparator2,
				this.toolStripButtonCount,
				this.toolStripSeparator3,
				this.toolStripButtonViewConfig,
				this.toolStripButtonCategories,
				this.toolStripSeparator4,
				this.toolStripButtonExit
			});
			this.toolStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new global::System.Drawing.Size(727, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStripButtonNew.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonNew.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonNew.Image");
			this.toolStripButtonNew.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButtonNew.Name = "toolStripButtonNew";
			this.toolStripButtonNew.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonNew.Text = "New";
			this.toolStripButtonNew.Click += new global::System.EventHandler(this.btnNew_Click);
			this.toolStripButtonUpdate.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonUpdate.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonUpdate.Image");
			this.toolStripButtonUpdate.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
			this.toolStripButtonUpdate.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonUpdate.Text = "Update";
			this.toolStripButtonUpdate.Click += new global::System.EventHandler(this.btnUpdate_Click);
			this.toolStripButtonDelete.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDelete.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonDelete.Image");
			this.toolStripButtonDelete.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButtonDelete.Name = "toolStripButtonDelete";
			this.toolStripButtonDelete.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonDelete.Text = "Delete";
			this.toolStripButtonDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.toolStripButtonSave.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonSave.Image");
			this.toolStripButtonSave.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonSave.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButtonConfiguration.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonConfiguration.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonConfiguration.Image");
			this.toolStripButtonConfiguration.ImageTransparentColor = global::System.Drawing.Color.OldLace;
			this.toolStripButtonConfiguration.Name = "toolStripButtonConfiguration";
			this.toolStripButtonConfiguration.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonConfiguration.Text = "Configure";
			this.toolStripButtonConfiguration.Click += new global::System.EventHandler(this.btnConfigure_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButtonCount.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCount.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonCount.Image");
			this.toolStripButtonCount.ImageTransparentColor = global::System.Drawing.Color.OldLace;
			this.toolStripButtonCount.Name = "toolStripButtonCount";
			this.toolStripButtonCount.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonCount.Text = "Count";
			this.toolStripButtonCount.Click += new global::System.EventHandler(this.btnCount_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButtonViewConfig.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonViewConfig.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonViewConfig.Image");
			this.toolStripButtonViewConfig.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButtonViewConfig.Name = "toolStripButtonViewConfig";
			this.toolStripButtonViewConfig.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonViewConfig.Text = "View Counting Standard";
			this.toolStripButtonViewConfig.Click += new global::System.EventHandler(this.btnViewConfiguration_Click);
			this.toolStripButtonCategories.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCategories.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonCategories.Image");
			this.toolStripButtonCategories.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonCategories.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButtonCategories.Name = "toolStripButtonCategories";
			this.toolStripButtonCategories.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonCategories.Text = "Manage Categories";
			this.toolStripButtonCategories.Click += new global::System.EventHandler(this.btnCategory_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButtonExit.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonExit.Image");
			this.toolStripButtonExit.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButtonExit.Name = "toolStripButtonExit";
			this.toolStripButtonExit.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripButtonExit.Text = "Exit";
			this.toolStripButtonExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.taskToolStripMenuItem,
				this.setupToolStripMenuItem,
				this.reportsToolStripMenuItem,
				this.helpToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.ShowItemToolTips = true;
			this.menuStrip1.Size = new global::System.Drawing.Size(727, 24);
			this.menuStrip1.TabIndex = 20;
			this.menuStrip1.Text = "menuStrip1";
			this.taskToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.newToolStripMenuItem,
				this.updateToolStripMenuItem1,
				this.deleteToolStripMenuItem1,
				this.saveToolStripMenuItem,
				this.toolStripMenuItem2,
				this.configurationToolStripMenuItem,
				this.toolStripMenuItem3,
				this.countToolStripMenuItem,
				this.toolStripMenuItem4,
				this.eXitToolStripMenuItem
			});
			this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
			this.taskToolStripMenuItem.Size = new global::System.Drawing.Size(83, 20);
			this.taskToolStripMenuItem.Text = "Counter &Task";
			this.newToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("newToolStripMenuItem.Image");
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131150;
			this.newToolStripMenuItem.Size = new global::System.Drawing.Size(139, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new global::System.EventHandler(this.btnNew_Click);
			this.updateToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("updateToolStripMenuItem1.Image");
			this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
			this.updateToolStripMenuItem1.Size = new global::System.Drawing.Size(139, 22);
			this.updateToolStripMenuItem1.Text = "&Update";
			this.updateToolStripMenuItem1.Click += new global::System.EventHandler(this.btnUpdate_Click);
			this.deleteToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("deleteToolStripMenuItem1.Image");
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new global::System.Drawing.Size(139, 22);
			this.deleteToolStripMenuItem1.Text = "&Delete";
			this.deleteToolStripMenuItem1.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.saveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("saveToolStripMenuItem.Image");
			this.saveToolStripMenuItem.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131155;
			this.saveToolStripMenuItem.Size = new global::System.Drawing.Size(139, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new global::System.EventHandler(this.btnSave_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(136, 6);
			this.configurationToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("configurationToolStripMenuItem.Image");
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new global::System.Drawing.Size(139, 22);
			this.configurationToolStripMenuItem.Text = "C&onfiguration";
			this.configurationToolStripMenuItem.Click += new global::System.EventHandler(this.btnConfigure_Click);
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new global::System.Drawing.Size(136, 6);
			this.countToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("countToolStripMenuItem.Image");
			this.countToolStripMenuItem.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.countToolStripMenuItem.Name = "countToolStripMenuItem";
			this.countToolStripMenuItem.ShortcutKeys = global::System.Windows.Forms.Keys.F5;
			this.countToolStripMenuItem.Size = new global::System.Drawing.Size(139, 22);
			this.countToolStripMenuItem.Text = "&Count";
			this.countToolStripMenuItem.Click += new global::System.EventHandler(this.btnCount_Click);
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new global::System.Drawing.Size(136, 6);
			this.eXitToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("eXitToolStripMenuItem.Image");
			this.eXitToolStripMenuItem.Name = "eXitToolStripMenuItem";
			this.eXitToolStripMenuItem.Size = new global::System.Drawing.Size(139, 22);
			this.eXitToolStripMenuItem.Text = "E&xit";
			this.eXitToolStripMenuItem.Click += new global::System.EventHandler(this.btnExit_Click);
			this.setupToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.countingStandardToolStripMenuItem,
				this.categoriesToolStripMenuItem,
				this.toolStripMenuItem5,
				this.settingsToolStripMenuItem
			});
			this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
			this.setupToolStripMenuItem.Size = new global::System.Drawing.Size(47, 20);
			this.setupToolStripMenuItem.Text = "&Setup";
			this.countingStandardToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("countingStandardToolStripMenuItem.Image");
			this.countingStandardToolStripMenuItem.Name = "countingStandardToolStripMenuItem";
			this.countingStandardToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.countingStandardToolStripMenuItem.Text = "Counting &Standard";
			this.countingStandardToolStripMenuItem.Click += new global::System.EventHandler(this.btnViewConfiguration_Click);
			this.categoriesToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("categoriesToolStripMenuItem.Image");
			this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
			this.categoriesToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.categoriesToolStripMenuItem.Text = "&Categories";
			this.categoriesToolStripMenuItem.Click += new global::System.EventHandler(this.btnCategory_Click);
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new global::System.Drawing.Size(161, 6);
			this.toolStripMenuItem5.Visible = false;
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131151;
			this.settingsToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.settingsToolStripMenuItem.Text = "&Options";
			this.settingsToolStripMenuItem.Visible = false;
			this.settingsToolStripMenuItem.Click += new global::System.EventHandler(this.settingsToolStripMenuItem_Click);
			this.reportsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.kLOCReportToolStripMenuItem,
				this.kLOCByApplicationToolStripMenuItem,
				this.kLOCByQuarterByApplicationToolStripMenuItem
			});
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new global::System.Drawing.Size(57, 20);
			this.reportsToolStripMenuItem.Text = "&Reports";
			this.reportsToolStripMenuItem.Visible = false;
			this.kLOCReportToolStripMenuItem.Name = "kLOCReportToolStripMenuItem";
			this.kLOCReportToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.ShiftKey | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control);
			this.kLOCReportToolStripMenuItem.Size = new global::System.Drawing.Size(264, 22);
			this.kLOCReportToolStripMenuItem.Text = "&KLOC Report";
			this.kLOCReportToolStripMenuItem.Click += new global::System.EventHandler(this.kLOCReportToolStripMenuItem_Click);
			this.kLOCByApplicationToolStripMenuItem.Name = "kLOCByApplicationToolStripMenuItem";
			this.kLOCByApplicationToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.ShiftKey | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control);
			this.kLOCByApplicationToolStripMenuItem.Size = new global::System.Drawing.Size(264, 22);
			this.kLOCByApplicationToolStripMenuItem.Text = "KLOC by &Application";
			this.kLOCByApplicationToolStripMenuItem.Click += new global::System.EventHandler(this.kLOCByApplicationToolStripMenuItem_Click);
			this.kLOCByQuarterByApplicationToolStripMenuItem.Name = "kLOCByQuarterByApplicationToolStripMenuItem";
			this.kLOCByQuarterByApplicationToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.ShiftKey | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control);
			this.kLOCByQuarterByApplicationToolStripMenuItem.Size = new global::System.Drawing.Size(264, 22);
			this.kLOCByQuarterByApplicationToolStripMenuItem.Text = "KLOC by &Quarter by Application";
			this.kLOCByQuarterByApplicationToolStripMenuItem.Click += new global::System.EventHandler(this.kLOCByQuarterByApplicationToolStripMenuItem_Click);
			this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.userGuideToolStripMenuItem,
				this.toolStripMenuItem6,
				this.aboutToolStripMenuItem
			});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new global::System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
			this.userGuideToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.userGuideToolStripMenuItem.Text = "&User Guide";
			this.userGuideToolStripMenuItem.Click += new global::System.EventHandler(this.userGuideToolStripMenuItem_Click);
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new global::System.Drawing.Size(149, 6);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.aboutToolStripMenuItem_Click);
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.lvwCounterItems);
			this.splitContainer1.Panel1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Panel2.Controls.Add(this.lblTaskProperty);
			this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
			this.splitContainer1.Panel2.Padding = new global::System.Windows.Forms.Padding(1);
			this.splitContainer1.Panel2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new global::System.Drawing.Size(727, 289);
			this.splitContainer1.SplitterDistance = 458;
			this.splitContainer1.TabIndex = 1;
			this.lvwCounterItems.AllowColumnReorder = true;
			this.lvwCounterItems.CheckBoxes = true;
			this.lvwCounterItems.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colCountAgain,
				this.colCounterItem,
				this.colCounterType,
				this.colConfiguration,
				this.colServerName,
				this.colServerType
			});
			this.lvwCounterItems.ContextMenuStrip = this.conMenuMain;
			this.lvwCounterItems.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lvwCounterItems.FullRowSelect = true;
			this.lvwCounterItems.GridLines = true;
			this.lvwCounterItems.HideSelection = false;
			this.lvwCounterItems.Location = new global::System.Drawing.Point(0, 0);
			this.lvwCounterItems.MultiSelect = false;
			this.lvwCounterItems.Name = "lvwCounterItems";
			this.lvwCounterItems.ShowItemToolTips = true;
			this.lvwCounterItems.Size = new global::System.Drawing.Size(458, 289);
			this.lvwCounterItems.TabIndex = 33;
			this.lvwCounterItems.UseCompatibleStateImageBehavior = false;
			this.lvwCounterItems.View = global::System.Windows.Forms.View.Details;
			this.lvwCounterItems.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.lvwCounterItems_ItemChecked);
			this.lvwCounterItems.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.lvwCounterItems_ColumnClick);
			this.lvwCounterItems.ItemSelectionChanged += new global::System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwCounterItems_ItemSelectionChanged);
			this.colCountAgain.DisplayIndex = 3;
			this.colCountAgain.Text = "Enable";
			this.colCountAgain.Width = 47;
			this.colCounterItem.DisplayIndex = 0;
			this.colCounterItem.Text = "Task Name";
			this.colCounterItem.Width = 133;
			this.colCounterType.DisplayIndex = 1;
			this.colCounterType.Text = "Type";
			this.colCounterType.Width = 55;
			this.colConfiguration.DisplayIndex = 2;
			this.colConfiguration.Text = "Configured?";
			this.colConfiguration.Width = 72;
			this.colServerName.Text = "ServerName";
			this.colServerName.Width = 72;
			this.colServerType.Text = "ServerType";
			this.colServerType.Width = 70;
			this.lblTaskProperty.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblTaskProperty.AutoSize = true;
			this.lblTaskProperty.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTaskProperty.Location = new global::System.Drawing.Point(88, 6);
			this.lblTaskProperty.Name = "lblTaskProperty";
			this.lblTaskProperty.Size = new global::System.Drawing.Size(113, 13);
			this.lblTaskProperty.TabIndex = 45;
			this.lblTaskProperty.Text = "Counter Task Property";
			this.propertyGrid1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.propertyGrid1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.Location = new global::System.Drawing.Point(1, 1);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new global::System.Drawing.Size(263, 287);
			this.propertyGrid1.TabIndex = 1;
			this.propertyGrid1.UseCompatibleTextRendering = true;
			this.propertyGrid1.PropertyValueChanged += new global::System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
			this.CounterDataDataSet.DataSetName = "CounterDataDataSet";
			this.CounterDataDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.ReportQuery1BindingSource.DataMember = "ReportQuery1";
			this.ReportQuery1BindingSource.DataSource = this.CounterDataDataSet;
			this.ReportQuery1TableAdapter.ClearBeforeFill = true;
			this.TotalLOCBindingSource.DataMember = "TotalLOC";
			this.TotalLOCBindingSource.DataSource = this.CounterDataDataSet;
			this.TotalLOCTableAdapter.ClearBeforeFill = true;
			base.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(727, 394);
			base.Controls.Add(this.splitContainer);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmCounterItems";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Microsoft Line Of Code Counter";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmCounterItems_FormClosing);
			base.Load += new global::System.EventHandler(this.frmCounterItems_Load);
			this.conMenuMain.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.CounterDataDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ReportQuery1BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.TotalLOCBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000030 RID: 48
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ContextMenuStrip conMenuMain;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.BindingSource ReportQuery1BindingSource;

		// Token: 0x04000038 RID: 56
		private global::MS.IT.LOC.UI.CounterDataDataSet CounterDataDataSet;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.BindingSource TotalLOCBindingSource;

		// Token: 0x0400003A RID: 58
		private global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.ReportQuery1TableAdapter ReportQuery1TableAdapter;

		// Token: 0x0400003B RID: 59
		private global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.TotalLOCTableAdapter TotalLOCTableAdapter;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.SplitContainer splitContainer;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.ToolStripMenuItem eXitToolStripMenuItem;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ToolStripMenuItem countingStandardToolStripMenuItem;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ToolStripMenuItem kLOCReportToolStripMenuItem;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ToolStripMenuItem kLOCByApplicationToolStripMenuItem;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.ToolStripMenuItem kLOCByQuarterByApplicationToolStripMenuItem;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label lblMethodology;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label lblApplication;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label lblQuarter;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.ComboBox cboMethodology;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.ComboBox cboApplication;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.ComboBox cboQuarter;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label lblFileters;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ToolStrip toolStrip1;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ToolStripButton toolStripButtonNew;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ToolStripButton toolStripButtonUpdate;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ToolStripButton toolStripButtonDelete;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ToolStripButton toolStripButtonSave;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ToolStripButton toolStripButtonConfiguration;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ToolStripButton toolStripButtonCount;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.ToolStripButton toolStripButtonViewConfig;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.ToolStripButton toolStripButtonCategories;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.ToolStripButton toolStripButtonExit;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.PropertyGrid propertyGrid1;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.ListView lvwCounterItems;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.ColumnHeader colCountAgain;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.ColumnHeader colCounterItem;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.ColumnHeader colCounterType;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ColumnHeader colConfiguration;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label lblTaskProperty;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.ColumnHeader colServerName;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.ColumnHeader colServerType;
	}
}
