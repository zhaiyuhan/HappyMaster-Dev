using System;
using System.Drawing;
using System.Windows.Forms;

namespace HappyMaster_Dev.View
{
    public partial class SettingView : DMSkin.Main
    {
        public SettingView()
        {
            InitializeComponent();
        }
        public static int thislevel = 6;
        public void OpToLevel(double op)
        {
            if (op == 1.0) { thislevel = 6; }
            else if (op == 0.9) { thislevel = 5; }
            else if (op == 0.8) { thislevel = 4; }
            else if (op == 0.7) { thislevel = 3; }
            else if (op == 0.6) { thislevel = 2; }
            else if (op == 0.5) { thislevel = 1; }
            else if (op == 0.5) { thislevel = 0; }
        }
        public void MineEvent(int level)
        {
            switch (level)
            {
                case 6:
                    L6.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L5.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L4.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L3.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L2.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L1.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    OpTextBox.Text = "透明度等级6";
                    break;
                case 5:
                    L6.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L5.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L4.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L3.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L2.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L1.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    OpTextBox.Text = "透明度等级5";
                    break;
                case 4:
                    L6.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L5.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L4.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L3.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L2.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L1.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    OpTextBox.Text = "透明度等级4";
                    break;
                case 3:
                    L6.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L5.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L4.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L3.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L2.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L1.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    OpTextBox.Text = "透明度等级3";
                    break;
                case 2:
                    L6.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L5.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L4.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L3.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L2.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    L1.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    OpTextBox.Text = "透明度等级2";
                    break;
                case 1:
                    L6.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L5.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L4.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L3.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L2.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L1.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.OpLevel;
                    OpTextBox.Text = "透明度等级1";
                    break;
                case 0:
                    L6.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L5.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L4.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L3.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L2.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    L1.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Opstatic;
                    OpTextBox.Text = "透明度等级0";
                    break;
            }
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            if (MainView.ifRadius == true)
            {
                ifRadius.Checked = true;
            }
            else
            {
                ifRadius.Checked = false;
            }
            OpToLevel(MainView.exop);
            MineEvent(thislevel);
            
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
            if (MainView.exop < 1.0 || MainView.exop >= 0.5)
            {
                MainView.exop += 0.1; thislevel++;
            }
            
           
            MineEvent(thislevel); 
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (MainView.exop > 0.5 || MainView.exop <= 1.0)
            {
                MainView.exop -= 0.1;
            thislevel--;
            }
                
            MineEvent(thislevel);
        }


        private void SettingView_Shown(object sender, EventArgs e)
        {
            
            OpToLevel(MainView.exop);
            MineEvent(thislevel);
            ViewBg.BackgroundImage = MainView.exBackground;
            this.Refresh();
        }

        private void SettingView_Load(object sender, EventArgs e)
        {
            OpToLevel(MainView.exop);
            MineEvent(thislevel);
            ViewBg.BackgroundImage = MainView.exBackground;
        }

        private void ifRadius_CheckedChanged(object sender, EventArgs e)
        {
            if(ifRadius.Checked==true)
            {
                MainView.ifRadius = true;
            }
        }

        private void ViewBg_Click(object sender, EventArgs e)
        {

        }

        private void ifTran_CheckedChanged(object sender, EventArgs e)
        {
            if (ifRadius.Checked == true)
            {
                MainView.ifTran = true;
            }
        }
    }
}
