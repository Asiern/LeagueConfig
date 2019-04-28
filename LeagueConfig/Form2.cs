using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace LeagueConfig
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/XahNKEeB").Contains("1.1"))
            {
                if (MessageBox.Show("Update available", "LeagueConfigUpdater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/PapaElGunmen/LeagueConfig/releases");
                }
                else
                {

                }
            }
        }

        public void Settings_Click(object sender, EventArgs e)
        {
            Form1 Settings = new Form1();
            Settings.Show();
        }

        private void Save()
        {
            try
            {
                string filename = System.IO.Path.GetFileName(Properties.Settings.Default.settingspath);
                string source = Properties.Settings.Default.settingspath;
                string foldername = "LeagueConfig";
                //Dest
                var destinationpath = Path.Combine(Path.GetDirectoryName(source), foldername);
                var destination = Path.Combine(destinationpath, filename);

                //Create folder
                System.IO.Directory.CreateDirectory(destinationpath);

                //Copy
                System.IO.File.Copy(source, destination, true);

                //Save Settings
                Properties.Settings.Default.LeagueConfigdir = destinationpath;
                Properties.Settings.Default.settingspath = source;
                Properties.Settings.Default.Save();

                notif.Text = "Settings Saved";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadConfig()
        {
            try
            {
                string filename = System.IO.Path.GetFileName(Properties.Settings.Default.settingspath);
                string sourcefile = Path.Combine(Properties.Settings.Default.LeagueConfigdir, filename);
                string destinationfile = Properties.Settings.Default.settingspath;
                string backupdir = Path.Combine(Properties.Settings.Default.LeagueConfigdir, "BackupConfig");

                //Create Backup Folder
                System.IO.Directory.CreateDirectory(backupdir);
                //Backup Settings
                System.IO.File.Copy(destinationfile, Path.Combine(backupdir, filename), true);

                //Copy
                System.IO.File.Copy(sourcefile, destinationfile, true);

                //Save Settings
                Properties.Settings.Default.Backupdir = backupdir;
                Properties.Settings.Default.Save();

                notif.Text = "Settings Loaded";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Restore()
        {
            try
            {
                string filename = System.IO.Path.GetFileName(Properties.Settings.Default.settingspath);
                string backupdir = Properties.Settings.Default.Backupdir;
                string destination = Properties.Settings.Default.settingspath;

                //Copy
                System.IO.File.Copy(Path.Combine(backupdir, filename), destination, true);

                notif.Text = "Settings Restored";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   

    private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.settingspath == "")
            {
                Form1 Settings = new Form1();
                Settings.Show();
            }
            Properties.Settings.Default.stage = "1";
            Properties.Settings.Default.Save();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.settingspath == "")
            {
                MessageBox.Show("League path not set");
            }
            else
            {
                Save();
                notif.Text = "Settings Saved";
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            string stage = Properties.Settings.Default.stage;

            if (stage == "3")
            {
                if (Properties.Settings.Default.settingspath == "")
                {
                    MessageBox.Show("League path not set");
                }
                else
                {
                    Restore();
                    savebtn.Text = "Load Config";
                    notif.Text = "Config Restored";
                    Properties.Settings.Default.stage = "1";
                }
            }
            else
            {
                if (Properties.Settings.Default.settingspath == "")
                {
                    MessageBox.Show("League path not set");
                }
                else
                {
                    LoadConfig();
                    savebtn.Text = "Restore Config";
                    notif.Text = "Config Loaded";
                    Properties.Settings.Default.stage = "3";
                }
            }
        }

        private void Settings_Click_1(object sender, EventArgs e)
        {
            Form1 Settings = new Form1();
            Settings.Show();
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            Form3 help = new Form3();
            help.Show();
        }

        private void notif_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
