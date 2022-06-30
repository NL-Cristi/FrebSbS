namespace FrebIt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuContainerFirst = new System.Windows.Forms.SplitContainer();
            this.FirstScanButton = new System.Windows.Forms.Button();
            this.FirstBrowseButton = new System.Windows.Forms.Button();
            this.FirstFolderTextBox = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondScanButton = new System.Windows.Forms.Button();
            this.SecondBrowseButton = new System.Windows.Forms.Button();
            this.SecondFolderTextBox = new System.Windows.Forms.TextBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.MenuOptions = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SingleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.First2022 = new System.Windows.Forms.ToolStripMenuItem();
            this.First2019 = new System.Windows.Forms.ToolStripMenuItem();
            this.First2016 = new System.Windows.Forms.ToolStripMenuItem();
            this.First2012R2 = new System.Windows.Forms.ToolStripMenuItem();
            this.First2012 = new System.Windows.Forms.ToolStripMenuItem();
            this.First2008R2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Second2022 = new System.Windows.Forms.ToolStripMenuItem();
            this.Second2019 = new System.Windows.Forms.ToolStripMenuItem();
            this.Second2016 = new System.Windows.Forms.ToolStripMenuItem();
            this.Second2012R2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Second2012 = new System.Windows.Forms.ToolStripMenuItem();
            this.Second2008R2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.FirstContainer = new System.Windows.Forms.SplitContainer();
            this.FirstDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.FirstWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SecondContainer = new System.Windows.Forms.SplitContainer();
            this.SecondDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.SecondWebBrowser = new System.Windows.Forms.WebBrowser();
            this.FirstfolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SecondfolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MenuContainerFirst)).BeginInit();
            this.MenuContainerFirst.Panel1.SuspendLayout();
            this.MenuContainerFirst.Panel2.SuspendLayout();
            this.MenuContainerFirst.SuspendLayout();
            this.MenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstContainer)).BeginInit();
            this.FirstContainer.Panel1.SuspendLayout();
            this.FirstContainer.Panel2.SuspendLayout();
            this.FirstContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondContainer)).BeginInit();
            this.SecondContainer.Panel1.SuspendLayout();
            this.SecondContainer.Panel2.SuspendLayout();
            this.SecondContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuContainerFirst
            // 
            this.MenuContainerFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuContainerFirst.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuContainerFirst.IsSplitterFixed = true;
            this.MenuContainerFirst.Location = new System.Drawing.Point(0, 27);
            this.MenuContainerFirst.Name = "MenuContainerFirst";
            // 
            // MenuContainerFirst.Panel1
            // 
            this.MenuContainerFirst.Panel1.Controls.Add(this.FirstScanButton);
            this.MenuContainerFirst.Panel1.Controls.Add(this.FirstBrowseButton);
            this.MenuContainerFirst.Panel1.Controls.Add(this.FirstFolderTextBox);
            this.MenuContainerFirst.Panel1.Controls.Add(this.FirstLabel);
            // 
            // MenuContainerFirst.Panel2
            // 
            this.MenuContainerFirst.Panel2.Controls.Add(this.SecondScanButton);
            this.MenuContainerFirst.Panel2.Controls.Add(this.SecondBrowseButton);
            this.MenuContainerFirst.Panel2.Controls.Add(this.SecondFolderTextBox);
            this.MenuContainerFirst.Panel2.Controls.Add(this.SecondLabel);
            this.MenuContainerFirst.Panel2Collapsed = true;
            this.MenuContainerFirst.Size = new System.Drawing.Size(2378, 50);
            this.MenuContainerFirst.SplitterDistance = 1142;
            this.MenuContainerFirst.TabIndex = 0;
            // 
            // FirstScanButton
            // 
            this.FirstScanButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstScanButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstScanButton.Location = new System.Drawing.Point(764, 0);
            this.FirstScanButton.Name = "FirstScanButton";
            this.FirstScanButton.Size = new System.Drawing.Size(106, 50);
            this.FirstScanButton.TabIndex = 4;
            this.FirstScanButton.Text = "Scan";
            this.FirstScanButton.UseVisualStyleBackColor = true;
            this.FirstScanButton.Click += new System.EventHandler(this.FirstScanButton_Click);
            // 
            // FirstBrowseButton
            // 
            this.FirstBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FirstBrowseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstBrowseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstBrowseButton.Location = new System.Drawing.Point(707, 0);
            this.FirstBrowseButton.Name = "FirstBrowseButton";
            this.FirstBrowseButton.Size = new System.Drawing.Size(57, 50);
            this.FirstBrowseButton.TabIndex = 3;
            this.FirstBrowseButton.Text = "...";
            this.FirstBrowseButton.UseVisualStyleBackColor = true;
            this.FirstBrowseButton.Click += new System.EventHandler(this.FirstBrowseButton_Click);
            // 
            // FirstFolderTextBox
            // 
            this.FirstFolderTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstFolderTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstFolderTextBox.Location = new System.Drawing.Point(91, 0);
            this.FirstFolderTextBox.Name = "FirstFolderTextBox";
            this.FirstFolderTextBox.Size = new System.Drawing.Size(616, 25);
            this.FirstFolderTextBox.TabIndex = 2;
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLabel.Location = new System.Drawing.Point(0, 0);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(91, 19);
            this.FirstLabel.TabIndex = 0;
            this.FirstLabel.Text = "First | Folder :";
            // 
            // SecondScanButton
            // 
            this.SecondScanButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SecondScanButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondScanButton.Location = new System.Drawing.Point(782, 0);
            this.SecondScanButton.Name = "SecondScanButton";
            this.SecondScanButton.Size = new System.Drawing.Size(106, 100);
            this.SecondScanButton.TabIndex = 8;
            this.SecondScanButton.Text = "Scan";
            this.SecondScanButton.UseVisualStyleBackColor = true;
            this.SecondScanButton.Click += new System.EventHandler(this.SecondScanButton_Click);
            // 
            // SecondBrowseButton
            // 
            this.SecondBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SecondBrowseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SecondBrowseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondBrowseButton.Location = new System.Drawing.Point(725, 0);
            this.SecondBrowseButton.Name = "SecondBrowseButton";
            this.SecondBrowseButton.Size = new System.Drawing.Size(57, 100);
            this.SecondBrowseButton.TabIndex = 7;
            this.SecondBrowseButton.Text = "...";
            this.SecondBrowseButton.UseVisualStyleBackColor = true;
            this.SecondBrowseButton.Click += new System.EventHandler(this.SecondBrowseButton_Click);
            // 
            // SecondFolderTextBox
            // 
            this.SecondFolderTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SecondFolderTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondFolderTextBox.Location = new System.Drawing.Point(109, 0);
            this.SecondFolderTextBox.Name = "SecondFolderTextBox";
            this.SecondFolderTextBox.Size = new System.Drawing.Size(616, 25);
            this.SecondFolderTextBox.TabIndex = 6;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SecondLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondLabel.Location = new System.Drawing.Point(0, 0);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(109, 19);
            this.SecondLabel.TabIndex = 5;
            this.SecondLabel.Text = "Second | Folder :";
            // 
            // MenuOptions
            // 
            this.MenuOptions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.HelpMenu});
            this.MenuOptions.Location = new System.Drawing.Point(0, 0);
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(2378, 27);
            this.MenuOptions.TabIndex = 1;
            this.MenuOptions.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SingleMenu,
            this.CompareMenu,
            this.SecondMenu});
            this.modeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // SingleMenu
            // 
            this.SingleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.First2022,
            this.First2019,
            this.First2016,
            this.First2012R2,
            this.First2012,
            this.First2008R2});
            this.SingleMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleMenu.Name = "SingleMenu";
            this.SingleMenu.Size = new System.Drawing.Size(143, 24);
            this.SingleMenu.Text = "First";
            this.SingleMenu.Click += new System.EventHandler(this.SingleMenu_Click);
            // 
            // First2022
            // 
            this.First2022.Name = "First2022";
            this.First2022.Size = new System.Drawing.Size(126, 24);
            this.First2022.Text = "2022";
            this.First2022.Click += new System.EventHandler(this.First2022_Click);
            // 
            // First2019
            // 
            this.First2019.Name = "First2019";
            this.First2019.Size = new System.Drawing.Size(126, 24);
            this.First2019.Text = "2019";
            this.First2019.Click += new System.EventHandler(this.First2019_Click);
            // 
            // First2016
            // 
            this.First2016.Name = "First2016";
            this.First2016.Size = new System.Drawing.Size(126, 24);
            this.First2016.Text = "2016";
            this.First2016.Click += new System.EventHandler(this.First2016_Click);
            // 
            // First2012R2
            // 
            this.First2012R2.Name = "First2012R2";
            this.First2012R2.Size = new System.Drawing.Size(126, 24);
            this.First2012R2.Text = "2012R2";
            this.First2012R2.Click += new System.EventHandler(this.First2012R2_Click);
            // 
            // First2012
            // 
            this.First2012.Name = "First2012";
            this.First2012.Size = new System.Drawing.Size(126, 24);
            this.First2012.Text = "2012";
            this.First2012.Click += new System.EventHandler(this.First2012_Click);
            // 
            // First2008R2
            // 
            this.First2008R2.Name = "First2008R2";
            this.First2008R2.Size = new System.Drawing.Size(126, 24);
            this.First2008R2.Text = "2008R2";
            this.First2008R2.Click += new System.EventHandler(this.First2008R2_Click);
            // 
            // CompareMenu
            // 
            this.CompareMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareMenu.Name = "CompareMenu";
            this.CompareMenu.Size = new System.Drawing.Size(143, 24);
            this.CompareMenu.Text = "SideBySide";
            this.CompareMenu.Click += new System.EventHandler(this.CompareMenu_Click);
            // 
            // SecondMenu
            // 
            this.SecondMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Second2022,
            this.Second2019,
            this.Second2016,
            this.Second2012R2,
            this.Second2012,
            this.Second2008R2});
            this.SecondMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondMenu.Name = "SecondMenu";
            this.SecondMenu.Size = new System.Drawing.Size(143, 24);
            this.SecondMenu.Text = "Second";
            this.SecondMenu.Click += new System.EventHandler(this.SecondMenu_Click);
            // 
            // Second2022
            // 
            this.Second2022.Name = "Second2022";
            this.Second2022.Size = new System.Drawing.Size(126, 24);
            this.Second2022.Text = "2022";
            this.Second2022.Click += new System.EventHandler(this.Second2022_Click);
            // 
            // Second2019
            // 
            this.Second2019.Name = "Second2019";
            this.Second2019.Size = new System.Drawing.Size(126, 24);
            this.Second2019.Text = "2019";
            this.Second2019.Click += new System.EventHandler(this.Second2019_Click);
            // 
            // Second2016
            // 
            this.Second2016.Name = "Second2016";
            this.Second2016.Size = new System.Drawing.Size(126, 24);
            this.Second2016.Text = "2016";
            this.Second2016.Click += new System.EventHandler(this.Second2016_Click);
            // 
            // Second2012R2
            // 
            this.Second2012R2.Name = "Second2012R2";
            this.Second2012R2.Size = new System.Drawing.Size(126, 24);
            this.Second2012R2.Text = "2012R2";
            this.Second2012R2.Click += new System.EventHandler(this.Second2012R2_Click);
            // 
            // Second2012
            // 
            this.Second2012.Name = "Second2012";
            this.Second2012.Size = new System.Drawing.Size(126, 24);
            this.Second2012.Text = "2012";
            this.Second2012.Click += new System.EventHandler(this.Second2012_Click);
            // 
            // Second2008R2
            // 
            this.Second2008R2.Name = "Second2008R2";
            this.Second2008R2.Size = new System.Drawing.Size(126, 24);
            this.Second2008R2.Text = "2008R2";
            this.Second2008R2.Click += new System.EventHandler(this.Second2008R2_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(49, 23);
            this.HelpMenu.Text = "Help";
            this.HelpMenu.Click += new System.EventHandler(this.HelpMenu_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainContainer.Location = new System.Drawing.Point(0, 77);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.FirstContainer);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.SecondContainer);
            this.MainContainer.Panel2Collapsed = true;
            this.MainContainer.Size = new System.Drawing.Size(2378, 984);
            this.MainContainer.SplitterDistance = 1142;
            this.MainContainer.TabIndex = 2;
            // 
            // FirstContainer
            // 
            this.FirstContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstContainer.Location = new System.Drawing.Point(0, 0);
            this.FirstContainer.Name = "FirstContainer";
            this.FirstContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // FirstContainer.Panel1
            // 
            this.FirstContainer.Panel1.Controls.Add(this.FirstDataGridView);
            // 
            // FirstContainer.Panel2
            // 
            this.FirstContainer.Panel2.Controls.Add(this.FirstWebBrowser);
            this.FirstContainer.Size = new System.Drawing.Size(2378, 984);
            this.FirstContainer.SplitterDistance = 354;
            this.FirstContainer.TabIndex = 0;
            // 
            // FirstDataGridView
            // 
            this.FirstDataGridView.AllowUserToAddRows = false;
            this.FirstDataGridView.AllowUserToDeleteRows = false;
            this.FirstDataGridView.AllowUserToOrderColumns = true;
            this.FirstDataGridView.AllowUserToResizeRows = false;
            this.FirstDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FirstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstDataGridView.FilterAndSortEnabled = true;
            this.FirstDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.FirstDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FirstDataGridView.Name = "FirstDataGridView";
            this.FirstDataGridView.ReadOnly = true;
            this.FirstDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstDataGridView.RowHeadersVisible = false;
            this.FirstDataGridView.RowHeadersWidth = 62;
            this.FirstDataGridView.RowTemplate.Height = 28;
            this.FirstDataGridView.Size = new System.Drawing.Size(2378, 354);
            this.FirstDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.FirstDataGridView.TabIndex = 0;
            this.FirstDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FirstDataGridView_CellClick);
            this.FirstDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FirstDataGridView_CellContentClick);
            this.FirstDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FirstDataGridView_CellContentDoubleClick);
            this.FirstDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FirstDataGridView_ColumnHeaderMouseClick);
            this.FirstDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FirstDataGridView_ColumnHeaderMouseClick);
            // 
            // FirstWebBrowser
            // 
            this.FirstWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.FirstWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.FirstWebBrowser.Name = "FirstWebBrowser";
            this.FirstWebBrowser.Size = new System.Drawing.Size(2378, 626);
            this.FirstWebBrowser.TabIndex = 0;
            // 
            // SecondContainer
            // 
            this.SecondContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondContainer.Location = new System.Drawing.Point(0, 0);
            this.SecondContainer.Name = "SecondContainer";
            this.SecondContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SecondContainer.Panel1
            // 
            this.SecondContainer.Panel1.Controls.Add(this.SecondDataGridView);
            // 
            // SecondContainer.Panel2
            // 
            this.SecondContainer.Panel2.Controls.Add(this.SecondWebBrowser);
            this.SecondContainer.Size = new System.Drawing.Size(96, 100);
            this.SecondContainer.SplitterDistance = 35;
            this.SecondContainer.TabIndex = 0;
            // 
            // SecondDataGridView
            // 
            this.SecondDataGridView.AllowUserToAddRows = false;
            this.SecondDataGridView.AllowUserToDeleteRows = false;
            this.SecondDataGridView.AllowUserToOrderColumns = true;
            this.SecondDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SecondDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondDataGridView.FilterAndSortEnabled = true;
            this.SecondDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.SecondDataGridView.Location = new System.Drawing.Point(0, 0);
            this.SecondDataGridView.Name = "SecondDataGridView";
            this.SecondDataGridView.ReadOnly = true;
            this.SecondDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecondDataGridView.RowHeadersVisible = false;
            this.SecondDataGridView.RowHeadersWidth = 62;
            this.SecondDataGridView.RowTemplate.Height = 28;
            this.SecondDataGridView.Size = new System.Drawing.Size(96, 35);
            this.SecondDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.SecondDataGridView.TabIndex = 0;
            this.SecondDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SecondDataGridView_CellClick);
            this.SecondDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SecondDataGridView_CellClick);
            this.SecondDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SecondDataGridView_CellClick);
            this.SecondDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FirstDataGridView_ColumnHeaderMouseClick);
            this.SecondDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FirstDataGridView_ColumnHeaderMouseClick);
            // 
            // SecondWebBrowser
            // 
            this.SecondWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.SecondWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.SecondWebBrowser.Name = "SecondWebBrowser";
            this.SecondWebBrowser.Size = new System.Drawing.Size(96, 61);
            this.SecondWebBrowser.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2378, 1061);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.MenuContainerFirst);
            this.Controls.Add(this.MenuOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FrebSbS";
            this.MenuContainerFirst.Panel1.ResumeLayout(false);
            this.MenuContainerFirst.Panel1.PerformLayout();
            this.MenuContainerFirst.Panel2.ResumeLayout(false);
            this.MenuContainerFirst.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuContainerFirst)).EndInit();
            this.MenuContainerFirst.ResumeLayout(false);
            this.MenuOptions.ResumeLayout(false);
            this.MenuOptions.PerformLayout();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.FirstContainer.Panel1.ResumeLayout(false);
            this.FirstContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstContainer)).EndInit();
            this.FirstContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstDataGridView)).EndInit();
            this.SecondContainer.Panel1.ResumeLayout(false);
            this.SecondContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondContainer)).EndInit();
            this.SecondContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer MenuContainerFirst;
        private System.Windows.Forms.MenuStrip MenuOptions;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SingleMenu;
        private System.Windows.Forms.ToolStripMenuItem CompareMenu;
        private System.Windows.Forms.ToolStripMenuItem SecondMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.Button FirstScanButton;
        private System.Windows.Forms.Button FirstBrowseButton;
        private System.Windows.Forms.TextBox FirstFolderTextBox;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.Button SecondScanButton;
        private System.Windows.Forms.Button SecondBrowseButton;
        private System.Windows.Forms.TextBox SecondFolderTextBox;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.SplitContainer FirstContainer;
        private System.Windows.Forms.SplitContainer SecondContainer;
        private Zuby.ADGV.AdvancedDataGridView FirstDataGridView;
        private System.Windows.Forms.WebBrowser FirstWebBrowser;
        private System.Windows.Forms.WebBrowser SecondWebBrowser;
        private System.Windows.Forms.FolderBrowserDialog FirstfolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog SecondfolderBrowserDialog;
        private Zuby.ADGV.AdvancedDataGridView SecondDataGridView;
        private System.Windows.Forms.ToolStripMenuItem First2008R2;
        private System.Windows.Forms.ToolStripMenuItem First2012;
        private System.Windows.Forms.ToolStripMenuItem First2012R2;
        private System.Windows.Forms.ToolStripMenuItem First2016;
        private System.Windows.Forms.ToolStripMenuItem First2019;
        private System.Windows.Forms.ToolStripMenuItem First2022;
        private System.Windows.Forms.ToolStripMenuItem Second2008R2;
        private System.Windows.Forms.ToolStripMenuItem Second2012;
        private System.Windows.Forms.ToolStripMenuItem Second2012R2;
        private System.Windows.Forms.ToolStripMenuItem Second2016;
        private System.Windows.Forms.ToolStripMenuItem Second2019;
        private System.Windows.Forms.ToolStripMenuItem Second2022;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

