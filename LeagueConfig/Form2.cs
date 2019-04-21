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

namespace LeagueConfig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Program.OpenDetailFormOnClose = true;
            Form1 Settings = new Form1();
            Settings.Show();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(Properties.Settings.Default.settingspath);
                string source = Properties.Settings.Default.settingspath;
                string foldername = "LeagueConfig";
                //Dest
                var destinationpath = Path.Combine(Path.GetDirectoryName(source),foldername);
                var destination = Path.Combine(destinationpath,filename);

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

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(Properties.Settings.Default.settingspath);
                string sourcefile = Path.Combine(Properties.Settings.Default.LeagueConfigdir,filename);
                string destinationfile = Properties.Settings.Default.settingspath;
                string backupdir = Path.Combine(Properties.Settings.Default.LeagueConfigdir, "BackupConfig");

                //Create Backup Folder
                System.IO.Directory.CreateDirectory(backupdir);
                //Backup Settings
                System.IO.File.Copy(destinationfile, Path.Combine(backupdir,filename), true);

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

        private void restorebtn_Click(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   

    private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
