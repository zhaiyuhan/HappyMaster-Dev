using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Cd;
namespace CDPlayer
{
    public partial class MainView : DMSkin.Main
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            if(!Bass.BASS_Init(-1,44100,BASSInit.BASS_DEVICE_CPSPEAKERS,this.Handle))
            {
                DMSkin.MetroMessageBox.Show(this, Bass.BASS_ErrorGetCode().ToString());
            }
            PanelControlPanel.Width = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool ifShow = true;
        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            if (ifShow == true)
            {
                HideTimer.Enabled = false;
                for (int i = 0; i < 1; i++)
                { ShowTimer.Enabled = true; }
                ifShow = false;
                btnControlPanel.Text = "隐藏面板";
            }
            else if (ifShow == false)
            {
                ShowTimer.Enabled = false;
                for (int i = 0; i < 1; i++)
                { HideTimer.Enabled = true; }
                ifShow = true;
                btnControlPanel.Text = "展开面板";
            }

        }

        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                PanelControlPanel.Width += 1;
            }
        }

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                PanelControlPanel.Width -= 1;
            }
        }
        int OpLevel = 3;
        private void btnSetOp_Click(object sender, EventArgs e)
        {
            switch(OpLevel)
            {
                case 3:
                    btnSetOp.Text = "深度透明";
                    this.DM_SkinOpacity = 0.8;
                    this.Hide();
                    this.Show();
                    OpLevel = 2;
                    break;
                case 2:
                    btnSetOp.Text = "取消透明";
                    this.DM_SkinOpacity = 0.5;
                    this.Hide();
                    this.Show();
                    OpLevel = 1;
                    break;
                case 1:
                    btnSetOp.Text = "轻度透明";
                    this.DM_SkinOpacity = 1;
                    this.Hide();
                    this.Show();
                    OpLevel = 3;
                    break;
            }
        }

        private void btnSetOp_MouseEnter(object sender, EventArgs e)
        {
            btnSetOp.ForeColor = Color.White;
        }

        private void btnSetOp_MouseLeave(object sender, EventArgs e)
        {
            btnSetOp.ForeColor = Color.Black;
        }
        public string filename = string.Empty;
        public int stream = 0;//BassCd.BASS_CD_StreamCreateFile(,BASSFlag.BASS_SAMPLE_FLOAT);
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                filename = ofd.FileName;
            }
        }
        bool ifFirst = true;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (ifFirst == true)
            {
                stream = BassCd.BASS_CD_StreamCreateFile(filename,BASSFlag.BASS_SAMPLE_FLOAT);
                Bass.BASS_ChannelPlay(stream, true);
                ifFirst = false;
            }
            else if (ifFirst == false)
            {
                Bass.BASS_ChannelPlay(stream, false);
            }
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelPause(stream);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(stream);
        }

        private void btnLoadFile_MouseEnter(object sender, EventArgs e)
        {
            btnLoadFile.ForeColor = Color.White;
        }

        private void btnLoadFile_MouseLeave(object sender, EventArgs e)
        {
            btnLoadFile.ForeColor = Color.Black;
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.White;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.Black;
        }

        private void btnPause_MouseEnter(object sender, EventArgs e)
        {
            btnPause.ForeColor = Color.White;
        }

        private void btnPause_MouseLeave(object sender, EventArgs e)
        {
            btnPause.ForeColor = Color.Black;
        }

        private void btnStop_MouseEnter(object sender, EventArgs e)
        {
            btnStop.ForeColor = Color.White;
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            btnStop.ForeColor = Color.Black;
        }

        
    }
}
