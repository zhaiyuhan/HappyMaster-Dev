using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.Misc;
using Un4seen.Bass.AddOn.Tags;

namespace HappyMaster_Dev.View
{
    public partial class MainView : DMSkin.Main
    {
        public MainView()
        {
            InitializeComponent();
            
        }

        #region GETPICTURE
        private byte[] GetBytes(byte[] bytes, int start, int end)
        {
            byte[] tByte = new byte[end + 1 - start];
            int index = 0;

            for (int i = 0; i < bytes.Length; i++)
            {
                if (i >= start && i <= end)
                {
                    tByte[index] = bytes[i];
                    index++;
                }
            }
            return tByte;
        }
        public Image AlbumArt
        {
            get { return albumArt; }
            set { albumArt = value; }
        }
        private void GetPicture()
        {
            //先尝试从ID3V2中查找图片
            if (!GetPictureFromID3V2())
            {

            }

        }
        private bool bytesToImage(byte[] bystes)
        {
            byte[] imageBytes;
            int start = 0;
            int end = 0;
            ImageConverter converter;
            for (int i = 0; i < bystes.Length; i++)
            {
                if (bystes[i] == 0xFF && bystes[i + 1] == 0xd8)
                {
                    start = i;
                    break;
                }
            }
            try
            {
                for (int i = bystes.Length - 2; i > 0; i--)
                {
                    if (bystes[i] == 0xFF && bystes[i + 1] == 0xd9)
                    {
                        end = i + 1;
                        break;
                    }
                }

                imageBytes = GetBytes(bystes, start, end);
                MemoryStream ms = new MemoryStream(imageBytes);
                albumArt = Image.FromStream(ms);
                ms.Dispose();
                return true;
            }
            catch (System.Exception)
            {
                try
                {//尝试从前面开始查找
                    for (int i = start; i < bystes.Length; i++)
                    {
                        if (bystes[i] == 0xFF && bystes[i + 1] == 0xd9)
                        {
                            end = i + 1;
                            break;
                        }
                    }

                    imageBytes = GetBytes(bystes, start, end);
                    converter = new ImageConverter();
                    albumArt = (converter.ConvertFrom(imageBytes) as Image);
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }


        }
        private bool GetPictureFromID3V2()
        {
            IntPtr ptr = Bass.BASS_ChannelGetTags(stream, BASSTag.BASS_TAG_ID3V2);
            if (ptr != IntPtr.Zero)
            {
                try
                {
                    List<string> list = new List<string>();
                    HappyPlayer.Extra.ID3V2 ID3V2Tag = new HappyPlayer.Extra.ID3V2(ptr);

                    while (ID3V2Tag.k())
                    {
                        string str = ID3V2Tag.m();
                        object obj2 = ID3V2Tag.j();
                        short num2 = ID3V2Tag.i();
                        if (string.IsNullOrEmpty(str))
                        {
                            break;
                        }
                        //读取图片
                        if (((str == "APIC") || (str == "PIC")) && (obj2 is byte[]))
                        {
                            if (bytesToImage(obj2 as byte[]))
                            {
                                return true;
                            }
                        }
                    }
                    ID3V2Tag.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        #endregion GETPICTURE
        public bool isPlay = false;
        public string filename = String.Empty;
        public int stream = 0;
        public void InitUI()
        {
            MusicTitle.Left = (this.ClientRectangle.Width - MusicTitle.Width) / 2; //MusicTitle.BringToFront();
            ArtistName.Left = (this.ClientRectangle.Width - ArtistName.Width) / 2; //ArtistName.BringToFront();
            playControl.Left = (this.ClientRectangle.Width - playControl.Width) / 2; playControl.BringToFront();
            AlbumViewer.Left = (this.ClientRectangle.Width - AlbumViewer.Width) / 2; AlbumViewer.BringToFront();

        }
        private void MainView_Load(object sender, EventArgs e)
        {
            InitUI();
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS, this.Handle))
            {
                DMSkin.MetroMessageBox.Show(this, Bass.BASS_ErrorGetCode().ToString());
                BassNet.Registration("zhaiyuhanx@hotmail.com", "2X3931422312422");
            }
            MusicTitle.Text = "";
            ArtistName.Text = "";

        }

        private void MainView_Resize(object sender, EventArgs e)
        {
            InitUI();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            switch (panelSetting.Visible)
            {
                case true:
                    panelSetting.Visible = false;
                    break;
                case false:
                    panelSetting.Visible = true;
                    panelSetting.BringToFront();
                    break;
                default:
                    break;
            }
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.Black;
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.White;
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            View.AboutView about = new AboutView();
            about.Show();
        }

        private void btnLoadFile_MouseEnter(object sender, EventArgs e)
        {
            btnLoadFile.ForeColor = Color.White;
        }

        private void btnLoadFile_MouseLeave(object sender, EventArgs e)
        {
            btnLoadFile.ForeColor = Color.Black;
        }

        private void playControl_MouseEnter(object sender, EventArgs e)
        {

        }

        private void playControl_MouseLeave(object sender, EventArgs e)
        {

        }
       private void Play()
        {
            if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {//first play
                Bass.BASS_ChannelStop(stream);
                Bass.BASS_StreamFree(stream);
                stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
                //creat stream
                Bass.BASS_ChannelPlay(stream, true);
                //Position.Enabled = true;
                //Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_pause;
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.pause;
                AlbumViewer.BackgroundImage = albumArt;
                this.Text = "正在播放";
            }
            else if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                //playing
                Bass.BASS_ChannelPause(stream);
                //Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_play;
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
                this.Text = "播放暂停";
            }
            else if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PAUSED)
            {
                //pause
                Bass.BASS_ChannelPlay(stream, false);
                //Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_pause;
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.pause;
                this.Text = "正在播放";
            }
            else if (stream == 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                Bass.BASS_StreamFree(stream);
                //Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_play;
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
                this.Text = "Happy Master";
            }
        }

        private void playControl_Click(object sender, EventArgs e)
        {
            if(stream == 0)
            {
                View.MessageBoxView messagebox = new MessageBoxView();
                messagebox.ShowDialog();
            }
            Play();
        }

        private void btnShowLiveImage_MouseEnter(object sender, EventArgs e)
        {
            btnShowLiveImage.ForeColor = Color.White;
        }

        private void btnShowLiveImage_MouseLeave(object sender, EventArgs e)
        {
            btnShowLiveImage.ForeColor = Color.Black;
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_ChannelStop(stream);
            Bass.BASS_StreamFree(stream);
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }
        long len = 0; double totaltime; Image albumArt;
        public void LoadFile()
        {
            if(LoadMediaFile.ShowDialog()==DialogResult.OK)
            {
                if (File.Exists(LoadMediaFile.FileName)) { filename = LoadMediaFile.FileName; } else { filename = String.Empty; }
                Bass.BASS_StreamFree(stream);
                stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
                len = Bass.BASS_ChannelGetLength(stream); 
                totaltime = Bass.BASS_ChannelBytes2Seconds(stream, len); 
                labelLeftTime.Text = String.Format(Utils.FixTimespan(totaltime, "MMSS"));
                BASS_CHANNELINFO info = new BASS_CHANNELINFO();
                Bass.BASS_ChannelGetInfo(stream, info);
                TAG_INFO tagInfo = new TAG_INFO(filename);
                TagPicture picture = new TagPicture(filename);
                if (BassTags.BASS_TAG_GetFromFile(stream, tagInfo))
                {
                    GetPicture();
                    AlbumViewer.BackgroundImage = albumArt;
                    MusicTitle.Text = tagInfo.title;
                    ArtistName.Text = tagInfo.artist + " - " + tagInfo.album;
                    InitUI();
                }
            }
        }
        public void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadFile();
            panelSetting.Visible = false;
        }
    }
}
