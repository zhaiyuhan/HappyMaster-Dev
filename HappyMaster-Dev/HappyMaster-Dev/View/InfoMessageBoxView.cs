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
    public partial class InfoMessageBoxView : CCWin.CCSkinMain
    {
        public InfoMessageBoxView()
        {
            InitializeComponent();
        }

        private void InfoMessageBoxView_Load(object sender, EventArgs e)
        {
            CloseView.Enabled = true;
        }

        private void CloseView_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
