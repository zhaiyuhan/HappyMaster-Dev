using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyMaster.UI
{
    public partial class About : DMSkin.Main
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void CloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Title_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Help.exe", System.IO.Directory.GetCurrentDirectory());
        }
    }
}
