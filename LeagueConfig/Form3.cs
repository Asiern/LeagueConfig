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
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Asiern/LeagueConfig#users-guide");
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Asiern/LeagueConfig");
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Asiern/LeagueConfig/releases");
        }
    }
}
