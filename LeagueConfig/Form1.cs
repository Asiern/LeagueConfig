using MaterialSkin.Controls;
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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingspath.Text = Properties.Settings.Default.settingspath;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Program.OpenDetailFormOnClose = true;
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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
    }
}
