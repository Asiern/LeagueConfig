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
                string source = @Properties.Settings.Default.settingspath;
                string savelocation = Properties.Settings.Default.savepath;
                var destination = Path.Combine(savelocation,filename);

                //Copy
                System.IO.File.Copy(source, destination, false);

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
                string destination = @Properties.Settings.Default.settingspath;
                string savelocation = Properties.Settings.Default.savepath;
                var source = Path.Combine(savelocation, filename);

                //Copy
                System.IO.File.Copy(source, destination, false);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
