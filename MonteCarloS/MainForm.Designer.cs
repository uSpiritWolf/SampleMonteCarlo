namespace MonteCarloS
{
	partial class MainForm
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CencelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanelView = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxOptions = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelOptions = new System.Windows.Forms.TableLayoutPanel();
			this.PointsLabel = new System.Windows.Forms.Label();
			this.pointsNumeric = new System.Windows.Forms.NumericUpDown();
			this.SizePointLabel = new System.Windows.Forms.Label();
			this.sizePointNumeric = new System.Windows.Forms.NumericUpDown();
			this.groupBoxResult = new System.Windows.Forms.GroupBox();
			this.SquarePxl = new System.Windows.Forms.Panel();
			this.SquarePxlTextBox = new System.Windows.Forms.TextBox();
			this.SquarePxlLabel = new System.Windows.Forms.Label();
			this.SquarePrñ = new System.Windows.Forms.Panel();
			this.SquarePrñTextBox = new System.Windows.Forms.TextBox();
			this.SquarePrcLabel = new System.Windows.Forms.Label();
			this.Resolution = new System.Windows.Forms.Panel();
			this.ResolutionTextBox = new System.Windows.Forms.TextBox();
			this.ResolutionLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.ApplyBtn = new System.Windows.Forms.Button();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.menuStrip.SuspendLayout();
			this.tableLayoutPanelView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.tableLayoutPanelRight.SuspendLayout();
			this.groupBoxOptions.SuspendLayout();
			this.tableLayoutPanelOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pointsNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sizePointNumeric)).BeginInit();
			this.groupBoxResult.SuspendLayout();
			this.SquarePxl.SuspendLayout();
			this.SquarePrñ.SuspendLayout();
			this.Resolution.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(979, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.CencelMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// CencelMenuItem
			// 
			this.CencelMenuItem.Enabled = false;
			this.CencelMenuItem.Name = "CencelMenuItem";
			this.CencelMenuItem.Size = new System.Drawing.Size(110, 22);
			this.CencelMenuItem.Text = "Cencel";
			this.CencelMenuItem.Click += new System.EventHandler(this.CencelMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// tableLayoutPanelView
			// 
			this.tableLayoutPanelView.ColumnCount = 3;
			this.tableLayoutPanelView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
			this.tableLayoutPanelView.Controls.Add(this.pictureBox, 0, 0);
			this.tableLayoutPanelView.Controls.Add(this.tableLayoutPanelRight, 2, 0);
			this.tableLayoutPanelView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelView.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelView.Name = "tableLayoutPanelView";
			this.tableLayoutPanelView.RowCount = 1;
			this.tableLayoutPanelView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelView.Size = new System.Drawing.Size(973, 526);
			this.tableLayoutPanelView.TabIndex = 1;
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(3, 3);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(746, 520);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// tableLayoutPanelRight
			// 
			this.tableLayoutPanelRight.ColumnCount = 1;
			this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelRight.Controls.Add(this.groupBoxOptions, 0, 1);
			this.tableLayoutPanelRight.Controls.Add(this.groupBoxResult, 0, 0);
			this.tableLayoutPanelRight.Controls.Add(this.panel1, 0, 2);
			this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelRight.Location = new System.Drawing.Point(755, 3);
			this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
			this.tableLayoutPanelRight.RowCount = 3;
			this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.61165F));
			this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.38835F));
			this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanelRight.Size = new System.Drawing.Size(215, 520);
			this.tableLayoutPanelRight.TabIndex = 3;
			// 
			// groupBoxOptions
			// 
			this.groupBoxOptions.Controls.Add(this.tableLayoutPanelOptions);
			this.groupBoxOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxOptions.Location = new System.Drawing.Point(3, 389);
			this.groupBoxOptions.Name = "groupBoxOptions";
			this.groupBoxOptions.Size = new System.Drawing.Size(209, 92);
			this.groupBoxOptions.TabIndex = 3;
			this.groupBoxOptions.TabStop = false;
			this.groupBoxOptions.Text = "Options";
			// 
			// tableLayoutPanelOptions
			// 
			this.tableLayoutPanelOptions.ColumnCount = 2;
			this.tableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.40097F));
			this.tableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.59903F));
			this.tableLayoutPanelOptions.Controls.Add(this.PointsLabel, 0, 0);
			this.tableLayoutPanelOptions.Controls.Add(this.pointsNumeric, 1, 0);
			this.tableLayoutPanelOptions.Controls.Add(this.SizePointLabel, 0, 1);
			this.tableLayoutPanelOptions.Controls.Add(this.sizePointNumeric, 1, 1);
			this.tableLayoutPanelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelOptions.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanelOptions.Name = "tableLayoutPanelOptions";
			this.tableLayoutPanelOptions.RowCount = 2;
			this.tableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelOptions.Size = new System.Drawing.Size(203, 73);
			this.tableLayoutPanelOptions.TabIndex = 1;
			// 
			// PointsLabel
			// 
			this.PointsLabel.AutoSize = true;
			this.PointsLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.PointsLabel.Location = new System.Drawing.Point(21, 0);
			this.PointsLabel.Name = "PointsLabel";
			this.PointsLabel.Size = new System.Drawing.Size(39, 40);
			this.PointsLabel.TabIndex = 0;
			this.PointsLabel.Text = "Points:";
			this.PointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pointsNumeric
			// 
			this.pointsNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pointsNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.pointsNumeric.Location = new System.Drawing.Point(66, 10);
			this.pointsNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.pointsNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.pointsNumeric.Name = "pointsNumeric";
			this.pointsNumeric.Size = new System.Drawing.Size(134, 20);
			this.pointsNumeric.TabIndex = 1;
			this.pointsNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// SizePointLabel
			// 
			this.SizePointLabel.AutoSize = true;
			this.SizePointLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.SizePointLabel.Location = new System.Drawing.Point(3, 40);
			this.SizePointLabel.Name = "SizePointLabel";
			this.SizePointLabel.Size = new System.Drawing.Size(57, 40);
			this.SizePointLabel.TabIndex = 2;
			this.SizePointLabel.Text = "Size Point:";
			this.SizePointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// sizePointNumeric
			// 
			this.sizePointNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.sizePointNumeric.Location = new System.Drawing.Point(66, 50);
			this.sizePointNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.sizePointNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.sizePointNumeric.Name = "sizePointNumeric";
			this.sizePointNumeric.Size = new System.Drawing.Size(134, 20);
			this.sizePointNumeric.TabIndex = 2;
			this.sizePointNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.sizePointNumeric.ValueChanged += new System.EventHandler(this.sizePointNumeric_ValueChanged);
			// 
			// groupBoxResult
			// 
			this.groupBoxResult.Controls.Add(this.SquarePxl);
			this.groupBoxResult.Controls.Add(this.SquarePrñ);
			this.groupBoxResult.Controls.Add(this.Resolution);
			this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxResult.Location = new System.Drawing.Point(3, 3);
			this.groupBoxResult.Name = "groupBoxResult";
			this.groupBoxResult.Size = new System.Drawing.Size(209, 380);
			this.groupBoxResult.TabIndex = 4;
			this.groupBoxResult.TabStop = false;
			this.groupBoxResult.Text = "Result";
			// 
			// SquarePxl
			// 
			this.SquarePxl.Controls.Add(this.SquarePxlTextBox);
			this.SquarePxl.Controls.Add(this.SquarePxlLabel);
			this.SquarePxl.Dock = System.Windows.Forms.DockStyle.Top;
			this.SquarePxl.Location = new System.Drawing.Point(3, 106);
			this.SquarePxl.Name = "SquarePxl";
			this.SquarePxl.Size = new System.Drawing.Size(203, 45);
			this.SquarePxl.TabIndex = 2;
			// 
			// SquarePxlTextBox
			// 
			this.SquarePxlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SquarePxlTextBox.Location = new System.Drawing.Point(66, 14);
			this.SquarePxlTextBox.Name = "SquarePxlTextBox";
			this.SquarePxlTextBox.ReadOnly = true;
			this.SquarePxlTextBox.Size = new System.Drawing.Size(134, 20);
			this.SquarePxlTextBox.TabIndex = 1;
			// 
			// SquarePxlLabel
			// 
			this.SquarePxlLabel.AutoSize = true;
			this.SquarePxlLabel.Location = new System.Drawing.Point(3, 17);
			this.SquarePxlLabel.Name = "SquarePxlLabel";
			this.SquarePxlLabel.Size = new System.Drawing.Size(60, 13);
			this.SquarePxlLabel.TabIndex = 0;
			this.SquarePxlLabel.Text = "Square pxl:";
			this.SquarePxlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SquarePrñ
			// 
			this.SquarePrñ.Controls.Add(this.SquarePrñTextBox);
			this.SquarePrñ.Controls.Add(this.SquarePrcLabel);
			this.SquarePrñ.Dock = System.Windows.Forms.DockStyle.Top;
			this.SquarePrñ.Location = new System.Drawing.Point(3, 61);
			this.SquarePrñ.Name = "SquarePrñ";
			this.SquarePrñ.Size = new System.Drawing.Size(203, 45);
			this.SquarePrñ.TabIndex = 1;
			// 
			// SquarePrñTextBox
			// 
			this.SquarePrñTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SquarePrñTextBox.Location = new System.Drawing.Point(66, 14);
			this.SquarePrñTextBox.Name = "SquarePrñTextBox";
			this.SquarePrñTextBox.ReadOnly = true;
			this.SquarePrñTextBox.Size = new System.Drawing.Size(134, 20);
			this.SquarePrñTextBox.TabIndex = 1;
			// 
			// SquarePrcLabel
			// 
			this.SquarePrcLabel.AutoSize = true;
			this.SquarePrcLabel.Location = new System.Drawing.Point(3, 17);
			this.SquarePrcLabel.Name = "SquarePrcLabel";
			this.SquarePrcLabel.Size = new System.Drawing.Size(55, 13);
			this.SquarePrcLabel.TabIndex = 0;
			this.SquarePrcLabel.Text = "Square %:";
			this.SquarePrcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Resolution
			// 
			this.Resolution.Controls.Add(this.ResolutionTextBox);
			this.Resolution.Controls.Add(this.ResolutionLabel);
			this.Resolution.Dock = System.Windows.Forms.DockStyle.Top;
			this.Resolution.Location = new System.Drawing.Point(3, 16);
			this.Resolution.Name = "Resolution";
			this.Resolution.Size = new System.Drawing.Size(203, 45);
			this.Resolution.TabIndex = 0;
			// 
			// ResolutionTextBox
			// 
			this.ResolutionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ResolutionTextBox.Location = new System.Drawing.Point(66, 10);
			this.ResolutionTextBox.Name = "ResolutionTextBox";
			this.ResolutionTextBox.ReadOnly = true;
			this.ResolutionTextBox.Size = new System.Drawing.Size(134, 20);
			this.ResolutionTextBox.TabIndex = 1;
			// 
			// ResolutionLabel
			// 
			this.ResolutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ResolutionLabel.AutoSize = true;
			this.ResolutionLabel.Location = new System.Drawing.Point(4, 13);
			this.ResolutionLabel.Name = "ResolutionLabel";
			this.ResolutionLabel.Size = new System.Drawing.Size(60, 13);
			this.ResolutionLabel.TabIndex = 0;
			this.ResolutionLabel.Text = "Resolution:";
			this.ResolutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ClearBtn);
			this.panel1.Controls.Add(this.ApplyBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 487);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(209, 30);
			this.panel1.TabIndex = 5;
			// 
			// ClearBtn
			// 
			this.ClearBtn.Location = new System.Drawing.Point(138, 0);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(46, 30);
			this.ClearBtn.TabIndex = 4;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// ApplyBtn
			// 
			this.ApplyBtn.Location = new System.Drawing.Point(36, 0);
			this.ApplyBtn.Name = "ApplyBtn";
			this.ApplyBtn.Size = new System.Drawing.Size(96, 30);
			this.ApplyBtn.TabIndex = 3;
			this.ApplyBtn.Text = "Apply and show";
			this.ApplyBtn.UseVisualStyleBackColor = true;
			this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_ClickAsync);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelView, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.progressBar, 0, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 2;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(979, 557);
			this.tableLayoutPanelMain.TabIndex = 2;
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBar.Location = new System.Drawing.Point(3, 535);
			this.progressBar.Maximum = 10000;
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(973, 19);
			this.progressBar.Step = 1;
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 77;
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(979, 581);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(995, 620);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Square Monte Carlo";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tableLayoutPanelView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.tableLayoutPanelRight.ResumeLayout(false);
			this.groupBoxOptions.ResumeLayout(false);
			this.tableLayoutPanelOptions.ResumeLayout(false);
			this.tableLayoutPanelOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pointsNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sizePointNumeric)).EndInit();
			this.groupBoxResult.ResumeLayout(false);
			this.SquarePxl.ResumeLayout(false);
			this.SquarePxl.PerformLayout();
			this.SquarePrñ.ResumeLayout(false);
			this.SquarePrñ.PerformLayout();
			this.Resolution.ResumeLayout(false);
			this.Resolution.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelView;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOptions;
		private System.Windows.Forms.Label PointsLabel;
		private System.Windows.Forms.NumericUpDown pointsNumeric;
		private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Label SizePointLabel;
        private System.Windows.Forms.NumericUpDown sizePointNumeric;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
		private System.Windows.Forms.GroupBox groupBoxOptions;
		private System.Windows.Forms.GroupBox groupBoxResult;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Panel Resolution;
		private System.Windows.Forms.TextBox ResolutionTextBox;
		private System.Windows.Forms.Label ResolutionLabel;
		private System.Windows.Forms.Panel SquarePrñ;
		private System.Windows.Forms.Label SquarePrcLabel;
		private System.Windows.Forms.TextBox SquarePrñTextBox;
		private System.Windows.Forms.Panel SquarePxl;
		private System.Windows.Forms.TextBox SquarePxlTextBox;
		private System.Windows.Forms.Label SquarePxlLabel;
		private System.Windows.Forms.ToolStripMenuItem CencelMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button ClearBtn;
	}
}

