using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HappyMaster_Dev.View;
using System.IO;

namespace HappyMaster_Dev.View
{
    public partial class MessageBoxView : DMSkin.Main
    {
        public MessageBoxView()
        {
            InitializeComponent();
            
        }
        public string filename;
        private void MessageBoxView_Load(object sender, EventArgs e)
        {
            
        }

        private void labelOK_Click(object sender, EventArgs e)
        {
            info.Text = "重新加载文件试试(ू• ̮ •ू❁)";
            Show.Enabled = true;
        }

        private void labelCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
