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
    public partial class SettingView : DMSkin.Main
    {
        public SettingView()
        {
            InitializeComponent();
        }
        public int thislevel;
        public void exopToLevel()
        {
            if (MainView.exop == 1.0) { thislevel = 5; }
            else if (MainView.exop == 0.9) { thislevel = 4; }
            else if (MainView.exop == 0.8) { thislevel = 3; }
            else if (MainView.exop == 0.7) { thislevel = 2; }
            else if (MainView.exop == 0.6) { thislevel = 1; }
            else if (MainView.exop == 0.5) { thislevel = 0; }
        }
        
        private void Setting_Load(object sender, EventArgs e)
        {
            exopToLevel();
            OpTextBox.Text = "透明度等级" + thislevel;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeBg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MainView.exBackground = Image.FromFile(ofd.FileName);
                ViewBg.BackgroundImage = Image.FromFile(ofd.FileName);        
            }
        }

        private void btnChangeBg_MouseEnter(object sender, EventArgs e)
        {
            btnChangeBg.ForeColor = Color.White;
        }

        private void btnChangeBg_MouseLeave(object sender, EventArgs e)
        {
            btnChangeBg.ForeColor = Color.Black;
        }

        private void ClearBg_MouseEnter(object sender, EventArgs e)
        {
            ClearBg.ForeColor = Color.White;
        }

        private void ClearBg_MouseLeave(object sender, EventArgs e)
        {
            ClearBg.ForeColor = Color.Black;
        }

        private void ClearBg_Click(object sender, EventArgs e)
        {
            MainView.exBackground = null;
            ViewBg.BackgroundImage = null;
        }
        
        private void btnUp_Click(object sender, EventArgs e)
        {
            if(MainView.exop==1.0)
            {

            }else if(MainView.exop==0.9)
            {
                MainView.exop = 0.2;
            }
            else if (MainView.exop == 0.8)
            {
                MainView.exop = 0.3;
            }
            else if (MainView.exop == 0.7)
            {
                MainView.exop = 0.4;
            }
            else if (MainView.exop == 0.6)
            {
                MainView.exop = 0.5;
            }
            else if (MainView.exop == 0.5)
            {
                MainView.exop = 0.6;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            
        }
    }
}
