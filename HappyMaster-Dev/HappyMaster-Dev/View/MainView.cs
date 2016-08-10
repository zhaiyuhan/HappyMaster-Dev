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
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using GdipEffect;
using System.Diagnostics;

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
            panelAlbumView.Left = (this.ClientRectangle.Width - panelAlbumView.Width) / 2; //AlbumViewer.BringToFront();

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
                    panelMore.Visible = false;
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
        public static bool ifAboutViewOpen = false;
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            if (ifAboutViewOpen == false)
            {
                View.AboutView about = new AboutView();
                about.Show();
                panelSetting.Visible = false;
                panelMore.Visible = false;
                ifAboutViewOpen = true;
            }
            else
            {
            }
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
            switch(isPlay)
            {
                case true:
                    playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.pausePress;
                    break;
                case false:
                    playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayPress;
                    break;
                default:
                    break;
            }
        }

        private void playControl_MouseLeave(object sender, EventArgs e)
        {
            switch (isPlay)
            {
                case true:
                    playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.pause;
                    break;
                case false:
                    playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
                    break;
                default:
                    break;
            }
        }
       private void Play()
        {
            if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                //first play
                Bass.BASS_ChannelStop(stream);
                Bass.BASS_StreamFree(stream);
                stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
                //creat stream
                Bass.BASS_ChannelPlay(stream, true);
                Position.Enabled = true;
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.pause;
                AlbumViewer.BackgroundImage = albumArt;
                this.Text = "正在播放";
                isPlay = true;
            }
            else if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                //playing
                Bass.BASS_ChannelPause(stream);
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
                this.Text = "播放暂停";
                isPlay = false;
            }
            else if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PAUSED)
            {
                //pause
                Bass.BASS_ChannelPlay(stream, false);
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.pause;
                this.Text = "正在播放";
                isPlay = true;
            }
            else if (stream == 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                Bass.BASS_StreamFree(stream);
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
                this.Text = "Happy Master";
                isPlay = false;
            }
        }

        private void playControl_Click(object sender, EventArgs e)
        {
            if(stream == 0)
            {
                View.MessageBoxView messagebox = new MessageBoxView();
                messagebox.ShowDialog();
            }
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, (int)VolumeMaster.DM_Value * 50);
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
            panelAlbumView.Visible = true;
            panelMore.Visible = false;
            workImage = AlbumViewer.BackgroundImage;
        }

        private void Position_Tick(object sender, EventArgs e)
        {
            len = Bass.BASS_ChannelGetLength(stream); 
            totaltime = Bass.BASS_ChannelBytes2Seconds(stream, len); 
            long pos = Bass.BASS_ChannelGetPosition(stream); 
            double elapsedtime = Bass.BASS_ChannelBytes2Seconds(stream, pos);
            double remainingtime = totaltime - elapsedtime;
            labelTime.Text = String.Format(Utils.FixTimespan(elapsedtime, "MMSS"));
            labelLeftTime.Text = String.Format(Utils.FixTimespan(remainingtime, "MMSS"));
            Pos.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
            double pSecsD = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));
            Pos.Value = (int)pSecsD;
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                DrawSpectrum();
            }
            else if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                pictureBoxSpectrum.Image = null;
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
                Pos.Value = 0;
                labelTime.Text = "00:00";
                labelLeftTime.Text = "00:00";
                this.Text = "Happy Master";
            }
        }

        private void Pos_Scroll(object sender, ScrollEventArgs e)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)Pos.Value);
        }
        public int volume = Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM);
        private void VolumeMaster_Click(object sender, EventArgs e)
        {
            volume = (int)VolumeMaster.DM_Value;
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, volume * 50);
        }

        private void btnShowLiveImage_Click(object sender, EventArgs e)
        {
            while(pictureBoxSpectrum.Visible==false)
            {
                pictureBoxSpectrum.Visible = true;
                pictureBoxSpectrum.BringToFront();
                btnHidePicturebBox.BringToFront();
                RightView.Visible = true;
                LeftView.Visible = true;
                panelSetting.Visible = false;
                btnHidePicturebBox.Visible = true;
                //showHelpPanel.Visible = false;
                panelMore.Visible = false;
            }
            {
                panelSetting.Visible = false;
            }
        }

        private Visuals _vis = new Visuals(); // visuals class instance
        private int specIdx = 15;
        private int voicePrintIdx = 0;
        private void DrawSpectrum()
        {
            switch (specIdx)
            {
                // normal spectrum (width = resolution)
                case 0:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrum(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Transparent, false, false, false);
                    break;
                // normal spectrum (full resolution)
                case 1:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrum(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Transparent, false, true, true);
                    break;
                // line spectrum (width = resolution)
                case 2:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLine(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Transparent, 2, 2, false, false, false);
                    break;
                // line spectrum (full resolution)
                case 3:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLine(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Transparent, 16, 4, false, true, true);
                    break;
                // ellipse spectrum (width = resolution)
                case 4:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumEllipse(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Transparent, 1, 2, false, false, false);
                    break;
                // ellipse spectrum (full resolution)
                case 5:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumEllipse(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Transparent, 2, 4, false, true, true);
                    break;
                // dot spectrum (width = resolution)
                case 6:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumDot(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Lime, Color.Red, Color.Transparent, 1, 0, false, false, false);
                    break;
                // dot spectrum (full resolution)
                case 7:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumDot(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SteelBlue, Color.Pink, Color.Transparent, 2, 1, false, false, true);
                    break;
                // peak spectrum (width = resolution)
                case 8:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLinePeak(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.SeaGreen, Color.LightGreen, Color.Orange, Color.Transparent, 2, 1, 2, 10, false, false, false);
                    break;
                // peak spectrum (full resolution)
                case 9:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumLinePeak(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.GreenYellow, Color.RoyalBlue, Color.DarkOrange, Color.Transparent, 23, 5, 3, 5, false, true, true);
                    break;
                // wave spectrum (width = resolution)
                case 10:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumWave(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Yellow, Color.Orange, Color.Transparent, 1, false, false, false);
                    break;
                // dancing beans spectrum (width = resolution)
                case 11:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumBean(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Chocolate, Color.DarkGoldenrod, Color.Transparent, 4, false, false, true);
                    break;
                // dancing text spectrum (width = resolution)
                case 12:
                    this.pictureBoxSpectrum.Image = _vis.CreateSpectrumText(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.White, Color.Tomato, Color.Transparent, "BASS .NET IS GREAT PIECE! UN4SEEN ROCKS...", false, false, true);
                    break;
                // frequency detection
                case 13:
                    float amp = _vis.DetectFrequency(stream, 10, 500, true);
                    if (amp > 0.3)
                        this.pictureBoxSpectrum.BackColor = Color.Transparent;
                    else
                        this.pictureBoxSpectrum.BackColor = Color.Transparent;
                    break;
                // 3D voice print
                case 14:
                    // we need to draw directly directly on the picture box...
                    // normally you would encapsulate this in your own custom control
                    Graphics g = Graphics.FromHwnd(this.pictureBoxSpectrum.Handle);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    _vis.CreateSpectrum3DVoicePrint(stream, g, new Rectangle(0, 0, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height), Color.Black, Color.White, voicePrintIdx, false, false);
                    g.Dispose();
                    // next call will be at the next pos
                    voicePrintIdx++;
                    if (voicePrintIdx > this.pictureBoxSpectrum.Width - 1)
                        voicePrintIdx = 0;
                    break;
                // WaveForm
                case 15:
                    this.pictureBoxSpectrum.Image = _vis.CreateWaveForm(stream, this.pictureBoxSpectrum.Width, this.pictureBoxSpectrum.Height, Color.Green, Color.Red, Color.Gray, Color.Transparent, 1, true, false, true);
                    break;
            }
        }

        private void btnHidePicturebBox_Click(object sender, EventArgs e)
        {
            pictureBoxSpectrum.Visible = false;
            RightView.Visible = false;
            LeftView.Visible = false;
            btnHidePicturebBox.Visible = false;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            specIdx--;
            if (specIdx > 15)
                specIdx = 0;
            if (specIdx < 0)
                specIdx = 15;
            this.pictureBoxSpectrum.Image = null;
            _vis.ClearPeaks();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            specIdx++;
            if (specIdx > 15)
                specIdx = 0;
            if (specIdx < 0)
                specIdx = 15;
            this.pictureBoxSpectrum.Image = null;
            _vis.ClearPeaks();
        }

        private void pictureBoxSpectrum_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBoxSpectrum_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                specIdx++;
            else
                specIdx--;
            if (specIdx > 15)
                specIdx = 0;
            if (specIdx < 0)
                specIdx = 15;
            this.pictureBoxSpectrum.Image = null;
            _vis.ClearPeaks();
        }

        private void btnMore_MouseEnter(object sender, EventArgs e)
        {
            btnMore.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.MoreOn;
            panelMore.Visible = true;
            panelMore.BringToFront();
        }

        private void btnMore_MouseLeave(object sender, EventArgs e)
        {
            btnMore.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.MenuNormal;
           
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (panelMore.Visible == false)
            {
                panelMore.Visible = true;
            panelMore.BringToFront();
            }
            else
            {
                panelMore.Visible = false;
            }
            
        }
        bool ifGlassEffect = false;
        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = true)]
        private static extern void CopyMemory(IntPtr Dest, IntPtr src, int Length);
        private Bitmap Bmp;
        private IntPtr ImageCopyPointer, ImagePointer;
        private int DataLength;
        private void UpdateImage()
        {
            if (Bmp != null)
            {
                CopyMemory(ImagePointer, ImageCopyPointer, DataLength);
                Rectangle Rect = new Rectangle(0, 0, Bmp.Width, Bmp.Height);
                Stopwatch Sw = new Stopwatch();
                Sw.Start();
                if (ifGlassEffect==true)
                    Bmp.GaussianBlur(ref Rect, BarRadius.Value, ChkExpandEdge.Checked);
                Sw.Stop();
                panelAlbumView.BackgroundImage = Bmp;          
            }
        }

        private void BarRadius_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateImage();
        }
        public Image workImage = null;
        private void ChkExpandEdge_Click(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void BarRadius_Scroll(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            labelDoneTimer.Enabled = true;
            View.InfoMessageBoxView iv = new InfoMessageBoxView();
            iv.ShowDialog();
        }

        private void labelDoneTimer_Tick(object sender, EventArgs e)
        {
        }
        /*自定义窗体内容*/
        public static Image exBackground = null;
        public static double exop = 1.0;
        public static bool ifRadius;
        public static bool ifTran = false;
        private void btnChangeBG_Click(object sender, EventArgs e)
        {
            View.SettingView sv = new SettingView();
            exBackground = this.BackgroundImage;
            sv.ShowDialog();
            
        }
    
        private void btnDIY_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = exBackground;
            MainView_Paint(null,null);
            
            this.Hide();
            this.Show();
        }
        private void btnCloseHelpView_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = false;
            btnSetting.Enabled = true;

        }

        private void btnShowDSP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("DSPViewer.exe", System.IO.Directory.GetCurrentDirectory());
        }

        private void btnEnrecoder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EncoderViewer.exe", System.IO.Directory.GetCurrentDirectory());
        }

        private void btnShowDSP_MouseEnter(object sender, EventArgs e)
        {
            btnShowDSP.Height = 55;
            btnShowDSP.Width = 55;
        }

        private void btnShowDSP_MouseLeave(object sender, EventArgs e)
        {
            btnShowDSP.Height = 50;
            btnShowDSP.Width = 50;
        }

        private void btnEnrecoder_MouseEnter(object sender, EventArgs e)
        {
            btnEnrecoder.Height = 55;
            btnEnrecoder.Width = 55;
        }

        private void btnEnrecoder_MouseLeave(object sender, EventArgs e)
        {
            btnEnrecoder.Height = 50;
            btnEnrecoder.Width = 50;
        }

        private void btnHelpView_MouseEnter(object sender, EventArgs e)
        {
            btnHelpView.Width = 55;
            btnHelpView.Height = 55;
        }

        private void btnHelpView_MouseLeave(object sender, EventArgs e)
        {
            btnHelpView.Height = 50;
            btnHelpView.Width = 50;
        }

        private void btnCloseHelpView_MouseEnter(object sender, EventArgs e)
        {
            btnCloseHelpView.Height = 55;
            btnHelpView.Width = 55;
        }

        private void btnCloseHelpView_MouseLeave(object sender, EventArgs e)
        {
            btnCloseHelpView.Height = 50;
            btnHelpView.Width = 50;
        }

        private void MainView_Click(object sender, EventArgs e)
        {
            panelMore.Visible = false;
            panelSetting.Visible = false;
        }

        private void btnHelpShow_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = true;
            panelHelp.BringToFront();
            panelSetting.Visible = false;
            panelMore.Visible = false;
            btnSetting.Enabled = false;
        }

        private void btnHelpShow_MouseEnter(object sender, EventArgs e)
        {
            btnHelpShow.ForeColor = Color.White;
        }

        private void btnHelpShow_MouseLeave(object sender, EventArgs e)
        {
            btnHelpShow.ForeColor = Color.Black;
        }

        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            this.DM_SkinOpacity = exop;         
            if(ifRadius==true)
            {
                this.DM_Radius = 6;
            }  
            if(ifRadius==false)
            {
                pictureBoxSpectrum.BackgroundImage = null;
            }
        }

        private void btnHelpView_Click(object sender, EventArgs e)
        {
            View.HelpView hv = new HelpView();
            hv.ShowDialog();
        }


        private void btnGlassAblumView_Click(object sender, EventArgs e)
        {
            if(ifGlassEffect == false)
            {
               
                ifGlassEffect = true;
                btnDone.Enabled = true;
                labelbtnGlassAblumView.Text = "(｡･ω･)开启成功，请继续设置";
                btnGlassAblumView.NormalImage = global::HappyMaster_Dev.Properties.Resources.checkBoxChecked;
                btnGlassAblumView.MoveImage = global::HappyMaster_Dev.Properties.Resources.checkBoxCheckedHover;
                BarRadius.Enabled = true;
                BarRadius.Value = 10;              
                    panelAlbumView.BackgroundImage = AlbumViewer.BackgroundImage;
                    Bmp = (Bitmap)panelAlbumView.BackgroundImage;
                   if(Bmp==null)
                {
                    DMSkin.MetroMessageBox.Show(this, "没有专辑图片(,,• ₃ •,,) ");
                    ifGlassEffect = false;
                    labelbtnGlassAblumView.Text = "(・ˍ・*)是否高斯模糊专辑图片";
                    btnGlassAblumView.NormalImage = global::HappyMaster_Dev.Properties.Resources.checkBox;
                    btnGlassAblumView.MoveImage = global::HappyMaster_Dev.Properties.Resources.checkBoxHover;
                    BarRadius.Enabled = false;
                    btnDone.Enabled = false;
                }
                else
                {        
                    BitmapData BmpData = new BitmapData();
                    Bmp.LockBits(new Rectangle(0, 0, Bmp.Width, Bmp.Height), ImageLockMode.ReadWrite, Bmp.PixelFormat, BmpData);
                    ImagePointer = BmpData.Scan0;
                    DataLength = BmpData.Stride * BmpData.Height;
                    ImageCopyPointer = Marshal.AllocHGlobal(DataLength);
                    CopyMemory(ImageCopyPointer, ImagePointer, DataLength);
                    Bmp.UnlockBits(BmpData);
                    panelAlbumView.BackgroundImage = Bmp;
                    UpdateImage();
                    AlbumViewer.BackgroundImage = workImage;

                 }
            }
            else
            {
                btnDone.Enabled = false;
                ifGlassEffect = false;
                labelbtnGlassAblumView.Text = "(・ˍ・*)是否高斯模糊专辑图片";
                btnGlassAblumView.NormalImage = global::HappyMaster_Dev.Properties.Resources.checkBox;
                btnGlassAblumView.MoveImage = global::HappyMaster_Dev.Properties.Resources.checkBoxHover;
                BarRadius.Enabled = false;
                BarRadius.Value = 0;
                UpdateImage();
                panelAlbumView.BackgroundImage = null;
            }
           
        }
        
    }
}
