using System;

namespace IGAutoScraper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNewLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSetLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ScrapeNowColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scrapeTimerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scrapeAllButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lastScrapeTextBox = new System.Windows.Forms.TextBox();
            this.notificationTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notificationTrayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideIGAutoScraperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTimerNumericUpDown)).BeginInit();
            this.notificationTrayContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadDirectoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // downloadDirectoryToolStripMenuItem
            // 
            this.downloadDirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.setNewLocationToolStripMenuItem,
            this.removeSetLocationToolStripMenuItem});
            this.downloadDirectoryToolStripMenuItem.Name = "downloadDirectoryToolStripMenuItem";
            this.downloadDirectoryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.downloadDirectoryToolStripMenuItem.Text = "Download Location";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.openToolStripMenuItem.Text = "Open Location In Explorer";
            this.openToolStripMenuItem.ToolTipText = "Open Location In Explorer";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // setNewLocationToolStripMenuItem
            // 
            this.setNewLocationToolStripMenuItem.Name = "setNewLocationToolStripMenuItem";
            this.setNewLocationToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.setNewLocationToolStripMenuItem.Text = "Set New Location";
            this.setNewLocationToolStripMenuItem.Click += new System.EventHandler(this.setNewLocationToolStripMenuItem_Click);
            // 
            // removeSetLocationToolStripMenuItem
            // 
            this.removeSetLocationToolStripMenuItem.Name = "removeSetLocationToolStripMenuItem";
            this.removeSetLocationToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.removeSetLocationToolStripMenuItem.Text = "Remove Set Location";
            this.removeSetLocationToolStripMenuItem.Click += new System.EventHandler(this.removeSetLocationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsernameColumn,
            this.ScrapeColumn,
            this.ScrapeNowColumn,
            this.DeleteColumn});
            this.dataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView.Location = new System.Drawing.Point(5, 80);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(550, 230);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.DataPropertyName = "Username";
            this.UsernameColumn.FillWeight = 300F;
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.Name = "UsernameColumn";
            // 
            // ScrapeColumn
            // 
            this.ScrapeColumn.DataPropertyName = "ScrapeType";
            this.ScrapeColumn.FillWeight = 92.8934F;
            this.ScrapeColumn.HeaderText = "Scrape";
            this.ScrapeColumn.Items.AddRange(new object[] {
            IGAutoScraper.ScrapeType.All,
            IGAutoScraper.ScrapeType.AllPosts,
            IGAutoScraper.ScrapeType.PostImages,
            IGAutoScraper.ScrapeType.PostVideos,
            IGAutoScraper.ScrapeType.AllStory,
            IGAutoScraper.ScrapeType.StoryImages,
            IGAutoScraper.ScrapeType.StoryVideos});
            this.ScrapeColumn.Name = "ScrapeColumn";
            this.ScrapeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScrapeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ScrapeNowColumn
            // 
            this.ScrapeNowColumn.HeaderText = "";
            this.ScrapeNowColumn.Name = "ScrapeNowColumn";
            this.ScrapeNowColumn.Text = "Scrape Now";
            this.ScrapeNowColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(377, 54);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(179, 22);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add New User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login username/password";
            this.toolTip.SetToolTip(this.label1, "Required for private profiles and story media");
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Location = new System.Drawing.Point(136, 55);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(115, 20);
            this.loginUsernameTextBox.TabIndex = 5;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(256, 55);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '•';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(115, 20);
            this.loginPasswordTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Scan every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "minutes";
            // 
            // scrapeTimerNumericUpDown
            // 
            this.scrapeTimerNumericUpDown.Location = new System.Drawing.Point(66, 28);
            this.scrapeTimerNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.scrapeTimerNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scrapeTimerNumericUpDown.Name = "scrapeTimerNumericUpDown";
            this.scrapeTimerNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.scrapeTimerNumericUpDown.TabIndex = 10;
            this.scrapeTimerNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scrapeTimerNumericUpDown.ValueChanged += new System.EventHandler(this.scanTimerNumericUpDown_ValueChanged);
            // 
            // scrapeAllButton
            // 
            this.scrapeAllButton.Location = new System.Drawing.Point(376, 28);
            this.scrapeAllButton.Name = "scrapeAllButton";
            this.scrapeAllButton.Size = new System.Drawing.Size(179, 22);
            this.scrapeAllButton.TabIndex = 11;
            this.scrapeAllButton.Text = "Scrape All Now";
            this.scrapeAllButton.UseVisualStyleBackColor = true;
            this.scrapeAllButton.Click += new System.EventHandler(this.scrapeAllButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last scrape was:";
            // 
            // lastScrapeTextBox
            // 
            this.lastScrapeTextBox.Enabled = false;
            this.lastScrapeTextBox.Location = new System.Drawing.Point(278, 29);
            this.lastScrapeTextBox.Name = "lastScrapeTextBox";
            this.lastScrapeTextBox.Size = new System.Drawing.Size(93, 20);
            this.lastScrapeTextBox.TabIndex = 13;
            // 
            // notificationTrayIcon
            // 
            this.notificationTrayIcon.ContextMenuStrip = this.notificationTrayContextMenuStrip;
            this.notificationTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationTrayIcon.Icon")));
            this.notificationTrayIcon.Text = "DoubleClick to Open/Hide";
            this.notificationTrayIcon.Visible = true;
            this.notificationTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notificationTrayContextMenuStrip
            // 
            this.notificationTrayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideIGAutoScraperToolStripMenuItem});
            this.notificationTrayContextMenuStrip.Name = "notificationTrayContextMenuStrip";
            this.notificationTrayContextMenuStrip.Size = new System.Drawing.Size(213, 26);
            // 
            // showHideIGAutoScraperToolStripMenuItem
            // 
            this.showHideIGAutoScraperToolStripMenuItem.Name = "showHideIGAutoScraperToolStripMenuItem";
            this.showHideIGAutoScraperToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.showHideIGAutoScraperToolStripMenuItem.Text = "Show/Hide IGAutoScraper";
            this.showHideIGAutoScraperToolStripMenuItem.Click += new System.EventHandler(this.showHideIGAutoScraperToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 318);
            this.Controls.Add(this.lastScrapeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scrapeAllButton);
            this.Controls.Add(this.scrapeTimerNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUsernameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(576, 1100);
            this.MinimumSize = new System.Drawing.Size(576, 39);
            this.Name = "Main";
            this.Text = "IGAutoScraper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTimerNumericUpDown)).EndInit();
            this.notificationTrayContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScrapeTypeColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStripMenuItem downloadDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNewLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSetLocationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScrapeColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ScrapeNowColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown scrapeTimerNumericUpDown;
        private System.Windows.Forms.Button scrapeAllButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastScrapeTextBox;
        private System.Windows.Forms.NotifyIcon notificationTrayIcon;
        private System.Windows.Forms.ContextMenuStrip notificationTrayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showHideIGAutoScraperToolStripMenuItem;
    }
}

