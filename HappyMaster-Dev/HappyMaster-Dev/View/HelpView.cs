using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyMaster_Dev.View
{
    public partial class HelpView : DMSkin.Main
    {
        public HelpView()
        {
            InitializeComponent();
        }

        private void HelpView_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_MouseEnter(object sender, EventArgs e)
        {
            btnDone.ForeColor = Color.White;
        }

        private void btnDone_MouseLeave(object sender, EventArgs e)
        {
            btnDone.ForeColor = Color.Black;
        }
    }
}
