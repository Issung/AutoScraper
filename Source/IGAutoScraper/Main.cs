using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using IGAutoScraper;

namespace IGAutoScraper
{ 
    public partial class Main : Form
    {
        public static readonly string USERS_FILEPATH = Application.CommonAppDataPath + "\\users.dat";
        public List<User> users = new List<User>();
        public BindingSource bindingSource = new BindingSource();

        System.Windows.Forms.Timer scrapeTimer;

        public Main()
        {
            /*users.AddRange(new User[] { 
                new User { Username = "Test1", ScrapeType = ScrapeType.All },
                new User { Username = "Test2", ScrapeType = ScrapeType.AllPosts },
                new User { Username = "Test3", ScrapeType = ScrapeType.AllStory }
            });*/

            InitializeComponent();

            if (File.Exists(USERS_FILEPATH))
            {
                users = (List<User>)JsonSerializer.Deserialize(File.ReadAllText(USERS_FILEPATH), users.GetType());
            }

            loginUsernameTextBox.Text = Properties.Settings.Default.username;
            loginPasswordTextBox.Text = Properties.Settings.Default.password;

            bindingSource.DataSource = users;
            dataGridView.DataSource = bindingSource;

            scrapeTimerNumericUpDown.Value = Properties.Settings.Default.scrapeTimerMinutes;

            scrapeTimer = new Timer();
            scrapeTimer.Interval = Properties.Settings.Default.scrapeTimerMinutes * 60000; //Convert mins to milliseconds.
            scrapeTimer.Tick += scrapeTimer_Tick;
            scrapeTimer.Enabled = true;
        }

        private void scrapeTimer_Tick(object sender, EventArgs e)
        {
            ScrapeAll();
        }

        private void ScrapeAll()
        {
            for (int i = 0; i < users.Count; i++)
                Scrape(i);

            lastScrapeTextBox.Text = DateTime.Now.ToString("dd MMM HH:mm:ss");
        }

        private void Scrape(int rowIndex)
        {
            User user = users[rowIndex];

            Utilities.RunScraper(
                user.Username,
                user.ScrapeType,
                Properties.Settings.Default.downloadDirectory,
                loginUsernameTextBox.Text,
                loginPasswordTextBox.Text);
        }

        private void breakButton_Click(object sender, System.EventArgs e)
        {
            Console.WriteLine("Break!");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bindingSource.Add(new User { Username = "UsernameHere" + users.Count, ScrapeType = ScrapeType.All });
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == ScrapeNowColumn.Index)
                    Scrape(e.RowIndex);
                else if (e.ColumnIndex == DeleteColumn.Index)
                    bindingSource.RemoveAt(e.RowIndex);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.downloadDirectory;

            if (String.IsNullOrWhiteSpace(path))
                path = Program.INSTALL_DIRECTORY;

            Process.Start(path);
        }

        private void setNewLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = Utilities.OpenDirectory();
            
            if (dirInfo != null)
            {
                Properties.Settings.Default.downloadDirectory = dirInfo.FullName;
                Properties.Settings.Default.Save();
            }
        }

        private void removeSetLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.downloadDirectory = null;
            Properties.Settings.Default.Save();
        }

        private void scanTimerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (scrapeTimer != null)
            { 
                Properties.Settings.Default.scrapeTimerMinutes = scrapeTimer.Interval;
                scrapeTimer.Interval = (int)scrapeTimerNumericUpDown.Value * 60000;
            }
        }

        private void scrapeAllButton_Click(object sender, EventArgs e)
        {
            ScrapeAll();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.username = loginUsernameTextBox.Text;
            Properties.Settings.Default.password = loginPasswordTextBox.Text;
            Properties.Settings.Default.Save();

            string serializedUsers = JsonSerializer.Serialize(users, users.GetType());
            File.WriteAllText(USERS_FILEPATH, serializedUsers);

            notificationTrayIcon.Visible = false;
            notificationTrayIcon.Dispose();
            scrapeTimer.Enabled = false;
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // When minimized hide from taskbar if trayicon enabled
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void showHideIGAutoScraperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Visible)
                Hide();
            else
                Show();
        }
    }
}
