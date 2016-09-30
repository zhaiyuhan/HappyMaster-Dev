using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(
        IntPtr hProcess,
        int dwMinimumWorkingSetSize,
        int dwMaximumWorkingSetSize
        );
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        private void FreeMemory_Tick(object sender, EventArgs e)
        {
           ClearMemory();
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
            //Try to start looking the image from the ID3V2
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
                {
                    //Try to start looking from the front
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
                        //read image
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
        public bool isPlay = false;//play state
        public string filename = String.Empty;//filename
        public int stream = 0;//stream
        //empyty;
        public void InitUI()
        {
            bottomPanel.Size = new Size(607, 67);
            bottomPanel.Left = (this.ClientRectangle.Width - bottomPanel.Width) / 2; bottomPanel.BringToFront();
            MusicTitle.Left = (this.ClientRectangle.Width - MusicTitle.Width) / 2; 
            ArtistName.Left = (this.ClientRectangle.Width - ArtistName.Width) / 2;            
            AlbumViewer.Left = (this.ClientRectangle.Width - AlbumViewer.Width) / 2;
            playControl.Left = (this.bottomPanel.Width - playControl.Width) / 2; playControl.BringToFront();
            panelSetting.Location = new Point(bottomPanel.Location.X, this.Width / 2 - 200);
            panelMore.Location = new Point(panelSetting.Location.X + panelSetting.Width + 5, panelSetting.Location.Y - 20);
            //custom layout
            //except playControl is always on top,and all of them are always in the middle
            btnLoadFile.TabStop = false;
            Debug.WriteLine(playControl.Location);
        }
        public void InitpanelHelp()
        {
            Size panelHelpSize = new Size(931, 116);
            Point panelHelpLocation = new Point(0, this.Height - 250);
            panelHelp.Location = panelHelpLocation;
            panelHelp.Size = panelHelpSize;
            panelHelp.Left = (this.ClientRectangle.Width - panelHelp.Width) / 2;           
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            InitUI();//Run...
            InitpanelHelp();
            this.Text = "欢迎";
           //Initialization interface,BASS.NET
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS, this.Handle))//Set  parameter
            {
                DMSkin.MetroMessageBox.Show(this, Bass.BASS_ErrorGetCode().ToString());
                BassNet.Registration("zhaiyuhanx@hotmail.com", "2X3931422312422");
                //registered BASS.NET,if not,will a display panel prompts you,It is not free to be paid
            }
            MusicTitle.Text = "";
            ArtistName.Text = "";
        }

        private void MainView_Resize(object sender, EventArgs e)
        {
            InitUI();
            InitpanelHelp();
            //if Triggering Resize event,sure all of them are always in the middle
        }
        //btnControl ,like title bar
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
        }//title bar ,finished
        void btnSettingEvent()
        {
            if (canShowpanelSetting == true)
            {
                switch (panelSetting.Visible)
                {
                    case true:
                        panelSetting.Visible = false;
                        panelMore.Visible = false;
                        playControl.Focus();
                        btnLoadFile.TabStop = false;
                        break;
                    case false:
                        panelSetting.Visible = true;
                        panelSetting.BringToFront();
                        playControl.Focus();
                        labelVolumeValue.Text = "当前音量: " + volume;
                        break;
                    default:
                        break;
                }
            }
            else if (canShowpanelSetting == false)
            {
                return;
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (canShowpanelSetting == true)
            {
                switch (panelSetting.Visible)
            {
                case true:
                    panelSetting.Visible = false;
                    panelMore.Visible = false;
                    playControl.Focus();
                    btnLoadFile.TabStop = false;
                    break;
                case false:
                    panelSetting.Visible = true;
                    panelSetting.BringToFront();
                    playControl.Focus();
                    labelVolumeValue.Text = "当前音量: " + volume;
                    break;
                default:
                    break;
            }
            }else if(canShowpanelSetting == false)
            {
                return;
            }
            
        }//Show Setting Panel ,make sure it is on top
         //after beta3.1 the event is useless
        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.Black;
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.White;
        }//
        void showAboutView()
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
                return;
                //ifAboutViewOpen = false;in View.AboutView FormClosingeEvent, so ifAboutViewOpen is static
            }
        }
        public static bool ifAboutViewOpen = false;//View.AboutView is not a dialog, so just can open one view
        private void btnAbout_Click(object sender, EventArgs e)
        {
            showAboutView();
            
        }
        //PlayControl if true,pause icon, if false, play icon
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
        void creatstream()
        {
            stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
        }
        //Play function         
        private void Play()
        {
            if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                //first play
                Bass.BASS_ChannelStop(stream);
                Bass.BASS_StreamFree(stream);
                creatstream();
                //create stream
                Bass.BASS_ChannelPlay(stream, true);
                Position.Enabled = true;
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.pause;
                AlbumViewer.BackgroundImage = albumArt;
                this.Text = "正在播放";
                isPlay = true;
                Debug.WriteLine("Now Playing");
                Debug.WriteLine(tagInfo.title + " Title");
                Debug.WriteLine(tagInfo.artist + " Artist");
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
                //finished 
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
            }//if no stream create,show View.MessageBoxView messagebox
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, (int)VolumeMaster.DM_Value * 100);
            //set volume
            AlbumViewer.Visible = true;
            
            Play();
        }
        //free res
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_ChannelStop(stream);
            Bass.BASS_StreamFree(stream);
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }//
        long length = 0; double totaltime; public static Image albumArt;
        TAG_INFO tagInfo;
        void outputtagInfoTitle(string title)
        {
            if (title != string.Empty) 
            {
                MusicTitle.Text = title;
                while(MusicTitle.Text=="")
                {
                    MusicTitle.Text = filename;
                }
            }
            else
            {
                MusicTitle.Text = filename;
            }
        }
        void outputtagInfoArtist(string artsit)
        {
            if (tagInfo.artist != string.Empty && tagInfo.album != string.Empty)
            {
                ArtistName.Text = tagInfo.artist + " - " + tagInfo.album;
            }
            else if (tagInfo.artist != string.Empty && tagInfo.album == string.Empty)
            {
                ArtistName.Text = tagInfo.artist;
            }
            else if (tagInfo.artist == string.Empty && tagInfo.album != string.Empty)
            {
                ArtistName.Text = tagInfo.album;
            }
        }
        //function LoadFile
        public void LoadFile()
        {
            if (LoadMediaFile.ShowDialog() == DialogResult.OK) 
            {
                if (File.Exists(LoadMediaFile.FileName)) { filename = LoadMediaFile.FileName; } else { filename = String.Empty; }//get filename 
                exfilename = LoadMediaFile.FileName;//set filename
                Bass.BASS_StreamFree(stream);//free last stream
                stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);//create new stream
                length = Bass.BASS_ChannelGetLength(stream); //get the stream length
                totaltime = Bass.BASS_ChannelBytes2Seconds(stream, length); //get the total time
                labelLeftTime.Text = String.Format(Utils.FixTimespan(totaltime, "MMSS"));//set time to MMSS minutes second             
                MusicTitle.Text = "";
                ArtistName.Text = "";
                if (stream != 0)
                {
                    AlbumViewer.BackgroundImage = null;
                    AlbumViewer.Visible = true;
                    workImage = AlbumViewer.BackgroundImage;
                }
                tagInfo = new TAG_INFO(filename);
                if (BassTags.BASS_TAG_GetFromFile(stream, tagInfo))
                {//get tag information
                    AlbumViewer.BackgroundImage = null;
                    GetPicture();
                    AlbumViewer.BackgroundImage = albumArt;
                    string setTitle = tagInfo.title;
                    outputtagInfoTitle(setTitle);
                    outputtagInfoArtist(tagInfo.artist);
                    InitUI();
                }else
                {
                    //if no artist infomation 
                    AlbumViewer.BackgroundImage = null;
                    GetPicture();
                    AlbumViewer.BackgroundImage = albumArt;
                    string setTitle = tagInfo.title;
                    outputtagInfoTitle(setTitle);
                    outputtagInfoArtist(tagInfo.artist);
                    InitUI();
                }
            }
        }
        public void btnLoadFile_Click(object sender, EventArgs e)
        {
            LoadFile();//LoadFile Function
                       //Hide Surplus Panel
            panelSetting.Visible = false;
            //AlbumViewer.Visible = true;
            panelMore.Visible = false;
            //set workImage
            //workImage = AlbumViewer.BackgroundImage;
            
            playControl.Focus();
        }

        private void Position_Tick(object sender, EventArgs e)
        {
            length = Bass.BASS_ChannelGetLength(stream); 
            totaltime = Bass.BASS_ChannelBytes2Seconds(stream, length); 
            long pos = Bass.BASS_ChannelGetPosition(stream); 
            double elapsedtime = Bass.BASS_ChannelBytes2Seconds(stream, pos);//current time
            double remainingtime = totaltime - elapsedtime;//left time
            labelTime.Text = String.Format(Utils.FixTimespan(elapsedtime, "MMSS"));
            labelLeftTime.Text = " -" + String.Format(Utils.FixTimespan(remainingtime, "MMSS"));
            //set pos max value ,avoid overflow
            Pos.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
            //set pos, and double into int
            double pSecsD = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));
            Pos.Value = (int)pSecsD;
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                DrawSpectrum();
                //Live Picture Panel
            }
            else if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {               
                playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
                Pos.Value = 0;
                labelTime.Text = "00:00";
                labelLeftTime.Text = "00:00";
                this.Text = "Happy Master";
                //Finished play
            }
        }

        private void Pos_Scroll(object sender, ScrollEventArgs e)
        {
            //set pos
            Bass.BASS_ChannelSetPosition(stream, (double)Pos.Value);
            Pos.TabStop = false;
            playControl.Focus();
        }
        //set volume
        public int volume = Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM) / 100;
        private void VolumeMaster_Click(object sender, EventArgs e)
        {
            volume = (int)VolumeMaster.DM_Value;
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, volume * 100);
        }//

        private void btnShowLiveImage_Click(object sender, EventArgs e)
        {
            while(pictureBoxSpectrum.Visible==false)
            {
                if (ifTran == false)
                {
                    pictureBoxSpectrum.BackColor = Color.Gainsboro;
                    pictureBoxSpectrum.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.glassBg;
                }
                else if (ifTran == true)
                {
                    pictureBoxSpectrum.BackColor = Color.Transparent;
                    pictureBoxSpectrum.BackgroundImage = null;
                }
                pictureBoxSpectrum.Visible = true;
                //make sure pictureBoxSpecturm and btnHidePictureBox on the top
                pictureBoxSpectrum.BringToFront();
                btnHidePicturebBox.BringToFront();
                RightView.Visible = true;
                LeftView.Visible = true;
                btnHidePicturebBox.Visible = true;
                panelSetting.Visible = false;               
                panelMore.Visible = false;
                panelSetting.Visible = false;
            }
        }
        //from Demo:
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
        //Hide the Live Picture Box
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
            //this.pictureBoxSpectrum.Image = null;
            _vis.ClearPeaks();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            specIdx++;
            if (specIdx > 15)
                specIdx = 0;
            if (specIdx < 0)
                specIdx = 15;
            //this.pictureBoxSpectrum.Image = null;
            _vis.ClearPeaks();
        }
        //
        private void pictureBoxSpectrum_MouseClick(object sender, MouseEventArgs e)
        {
            //do...
        }
        //
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
            View.InfoMessageBoxView.getText = "专辑图片高斯模糊处理设置成功ヽ(•̀ω•́ )ゝ";
            View.InfoMessageBoxView iv = new InfoMessageBoxView();
            iv.ShowDialog();
        }

        private void labelDoneTimer_Tick(object sender, EventArgs e)
        {
        }
        /*Ex Value to custom main form*/
        public static Image exBackground = null;
        public static double exop = 0.9;
        public static bool ifRadius = false;
        public static bool ifTran = true;
        
        private void btnChangeBG_Click(object sender, EventArgs e)
        {
            if (this.DM_Radius > 1) { ifRadius = true; }
            else if (this.DM_Radius == 1) { ifRadius = false; }
            View.SettingView sv = new SettingView();
            exBackground = this.BackgroundImage;           
            sv.ShowDialog();
            Debug.WriteLine(ifTran);
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
            canShowpanelSetting = true;
        }

        private void btnShowDSP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("DSPViewer.exe", System.IO.Directory.GetCurrentDirectory());
        }

        private void btnEnrecoder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EncoderViewer.exe", System.IO.Directory.GetCurrentDirectory());
        }
        //HelpPanel
        private void btnShowDSP_MouseEnter(object sender, EventArgs e)
        {
            btnShowDSP.Height += 5;
            btnShowDSP.Width += 5;
        }

        private void btnShowDSP_MouseLeave(object sender, EventArgs e)
        {
            btnShowDSP.Height -= 5;
            btnShowDSP.Width -= 5;
        }

        private void btnEnrecoder_MouseEnter(object sender, EventArgs e)
        {
            btnEnrecoder.Height += 5;
            btnEnrecoder.Width += 5;
        }

        private void btnEnrecoder_MouseLeave(object sender, EventArgs e)
        {
            btnEnrecoder.Height -= 5;
            btnEnrecoder.Width -= 5;
        }

        private void btnHelpView_MouseEnter(object sender, EventArgs e)
        {
            btnHelpView.Width += 5;
            btnHelpView.Height += 5;
        }

        private void btnHelpView_MouseLeave(object sender, EventArgs e)
        {
            btnHelpView.Height -= 5;
            btnHelpView.Width -= 5;
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
        }//

        private void MainView_Click(object sender, EventArgs e)
        {
            panelMore.Visible = false;
            panelSetting.Visible = false;//Hide PanelMore PanelSetting
            playControl.Focus();
        }
        public bool canShowpanelSetting = true;
        private void btnHelpShow_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = true;
            panelHelp.BringToFront();
            panelSetting.Visible = false;
            panelMore.Visible = false;
            canShowpanelSetting = false;
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
            //this.DM_SkinOpacity = exop;         
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
        public static string exfilename = string.Empty;
        public static Image exalbumart = null;

        private void labelbtnGlassAblumView_Click(object sender, EventArgs e)
        {

        }

        private void btnCDPlayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CDPlayer.exe", System.IO.Directory.GetCurrentDirectory());
        }
       
        private void PlayThread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
             Thread threadPlay = new Thread(new ThreadStart(creatstream));       
             threadPlay.Start();
             Thread.Sleep(5000);
             e.Result = e.Argument + "work thread done";
        }

        private void MainView_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Space == e.KeyCode)
            {
                Play();
            }else if (Keys.Down == e.KeyCode)
            {
                VolumeMaster.DM_Value -= 10;
                volume = (int)VolumeMaster.DM_Value;
                Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, volume * 100);
            }else if (Keys.Up == e.KeyCode)
            {
                VolumeMaster.DM_Value += 10;
                volume = (int)VolumeMaster.DM_Value;
                Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, volume * 100);
            }
        }

        private void MainView_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void PlayThread_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Play();
        }

        private void pictureBoxSpectrum_Click(object sender, EventArgs e)
        {

        }

        private void RightView_MouseEnter(object sender, EventArgs e)
        {
            RightView.Width += 5;
            //RightView.Height += 5;
        }

        private void RightView_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "向右切换";
            thistip.SetToolTip(RightView, tipOverwrite);
        }

        private void RightView_MouseLeave(object sender, EventArgs e)
        {
            RightView.Width -= 5;
            //RightView.Height -= 5;
        }

        private void LeftView_MouseEnter(object sender, EventArgs e)
        {
            LeftView.Width -= 5;
            //LeftView.Height -= 5;
        }

        private void LeftView_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "向左切换";
            thistip.SetToolTip(LeftView, tipOverwrite);
        }

        private void LeftView_MouseLeave(object sender, EventArgs e)
        {
            LeftView.Width += 5;
            //LeftView.Height += 5;
        }

        private void btnHidePicturebBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "隐藏波形图片";
            thistip.SetToolTip(btnHidePicturebBox, tipOverwrite);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "关闭程序";
            thistip.SetToolTip(btnClose, tipOverwrite);
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "最小化程序";
            thistip.SetToolTip(btnMin, tipOverwrite);
        }

        private void btnMax_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "最大化程序";
            thistip.SetToolTip(btnMax, tipOverwrite);
        }

        private void AlbumViewer_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "点击查看更多信息";
            thistip.SetToolTip(AlbumViewer, tipOverwrite);
        }

        private void playControl_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "播放";
            string tipOverwrite2 = "暂停/空格暂停";
            switch(isPlay)
            {
                case true:
                        thistip.SetToolTip(playControl, tipOverwrite2);
                    break;
                case false:
                    thistip.SetToolTip(playControl, tipOverwrite);
                    break;
                default:
                    break;
            }
        }
         
        private void VolumeMaster_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "当前音量" + volume.ToString() + Environment.NewLine + "拖动更新";
            thistip.SetToolTip(VolumeMaster, tipOverwrite);
                    
        }

        private void Pos_MouseHover(object sender, EventArgs e)
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            long pos = Bass.BASS_ChannelGetPosition(stream);
            double elapsedtime = Bass.BASS_ChannelBytes2Seconds(stream, pos);
            string tipOverwrite = String.Empty;
            if (stream != 0)
            {                
                tipOverwrite= "当前进度" + String.Format(Utils.FixTimespan(elapsedtime, "MMSS")); 
                thistip.SetToolTip(Pos, tipOverwrite);
            }else if (stream == 0)
            {
                tipOverwrite = "当前进度 00:00";
                thistip.SetToolTip(Pos, tipOverwrite);
            }
            
        }
        bool ifOnForeColorSuit = false;
        private void btnChangeTextColor_Click(object sender, EventArgs e)
        {
            switch(ifOnForeColorSuit)
            {
                case false:
                    MusicTitle.ForeColorSuit = true;
                    ArtistName.ForeColorSuit = true;
                    labelTime.ForeColorSuit = true;
                    labelLeftTime.ForeColorSuit = true;
                    ifOnForeColorSuit = true;
                    break;
                case true:
                    MusicTitle.ForeColorSuit = false;
                    ArtistName.ForeColorSuit = false;
                    labelTime.ForeColorSuit = false;
                    labelLeftTime.ForeColorSuit = false;
                    ifOnForeColorSuit = false;
                    break;
                default:
                    break;
            }
        }
        
        private void HidePanelMore()
        {
            if (panelMore.Visible == true) { panelMore.Visible = false; }
        }
        private void btnAbout_MouseEnter_1(object sender, EventArgs e)
        {
            HidePanelMore();
        }

        private void btnCDPlayer_MouseEnter(object sender, EventArgs e)
        {
            HidePanelMore();
        }

        private void btnShowLiveImage_MouseEnter(object sender, EventArgs e)
        {
            HidePanelMore();
        }

        private void btnLoadFile_MouseEnter(object sender, EventArgs e)
        {
            HidePanelMore();
        }

        private void AlbumViewer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                                this.AlbumViewer.ClientRectangle,
                                Color.Gray,//7f9db9
                                3,
                                ButtonBorderStyle.Solid,
                                Color.Gray,
                                3,
                                ButtonBorderStyle.Solid,
                                Color.Gray,
                                3,
                                ButtonBorderStyle.Solid,
                                Color.Gray,
                                3,
                                ButtonBorderStyle.Solid);
        }

        private void AlbumViewer_Click_1(object sender, EventArgs e)
        {
            if (stream != 0)
            {
                exalbumart = albumArt;
                if (exfilename != null)
                {
                    System.Diagnostics.Debug.WriteLine("exfilename is not empty and filename is " + exfilename);
                }
                if (exalbumart != null)
                {
                    System.Diagnostics.Debug.WriteLine("exalbumart is not null");
                }
                //hide panelSetting and panelMore
                panelSetting.Visible = false;
                panelMore.Visible = false;
                View.Infomation iv = new Infomation();
                iv.ShowDialog();
            }
        }

        private void AlbumViewer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            btnSettingEvent();
        }

        private void btnSetting_MouseEnter(object sender, EventArgs e)
        {
            btnSetting.DM_Color = Color.LightGray;
        }

        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.DM_Color = Color.White;
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
                Bmp = (Bitmap)AlbumViewer.BackgroundImage;
                if(Bmp==null)
                {
                    View.InfoMessageBoxView.getText = "没有专辑图片(,,• ₃ •,,) ";
                    new View.InfoMessageBoxView().ShowDialog();
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
                    AlbumViewer.BackgroundImage = Bmp;
                    UpdateImage();
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
                View.InfoMessageBoxView.getText = "已经取消高斯模糊 (。-`ω´-) ";
                View.InfoMessageBoxView iv = new InfoMessageBoxView();
                iv.ShowDialog();
            }
           
        }
        
    }
}
