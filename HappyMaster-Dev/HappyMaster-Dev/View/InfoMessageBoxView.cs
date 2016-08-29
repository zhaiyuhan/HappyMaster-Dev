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
        
        public static string getText = string.Empty;
        
        private void InfoMessageBoxView_Load(object sender, EventArgs e)
        {
            
            setLabel.Text = getText;
            CloseView.Enabled = true;

        }

        private void CloseView_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxinfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}