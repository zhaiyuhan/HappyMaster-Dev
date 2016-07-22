using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HappyMaster.UI
{
    
    public partial class Setting : DMSkin.Main
    {
        public int AppViewerOpacity = 100;
        public Image picture = null;
        public static Image bg = null;
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
        }

        private void CloseSetting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = true;
        }

        private void AboutShow_Click(object sender, EventArgs e)
        {
            UI.About about = new UI.About();
            about.ShowDialog();
        }
        private void HelpShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Help.exe", System.IO.Directory.GetCurrentDirectory());
        }

        private void LoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {            
                tomPanel1.Image = Image.FromFile(ofd.FileName);
            }
        }
        
        private void Effect1_Click(object sender, EventArgs e)
        {
            if (tomPanel1.IsGauss)
            { tomPanel1.IsGauss = false; }
            else { tomPanel1.IsGauss = true; }
            
        }

        private void numericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            tomPanel1.Gauss = Convert.ToInt32(numericUpDown.Value);
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            bg = tomPanel1.Image;
            AppViewer.changebg = bg;
            this.Close();

        }
    }
}
