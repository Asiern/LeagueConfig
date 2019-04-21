using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.settingspath = openFileDialog.FileName.ToString();
                Properties.Settings.Default.Save();
                settingspath.Text = Properties.Settings.Default.settingspath;
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeagueConfigdir = folderBrowserDialog1.SelectedPath.ToString();
                Properties.Settings.Default.Save();
                savepath.Text = Properties.Settings.Default.LeagueConfigdir;
                Properties.Settings.Default.Save();
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Program.OpenDetailFormOnClose = true;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 0;
            if (Properties.Settings.Default.LeagueConfigdir != null && Properties.Settings.Default.settingspath != null)
            {
                a = 1;
                Program.OpenDetailFormOnClose = true;
                this.Close();
            }
            else
            {
                savepath.Text = Properties.Settings.Default.LeagueConfigdir;
                settingspath.Text = Properties.Settings.Default.settingspath;
            }
        }
    }
}
