using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.Misc;
using Un4seen.Bass.AddOn.Tags;



namespace HappyMaster
{
    public partial class AppViewer : DMSkin.Main
    {
        public string album, artist, title, year;
        public int volume = Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM);
        Image albumArt;
        public static Image changebg;
        public static string filename = String.Empty;
        int stream = 0;
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
        public AppViewer()
        {
            InitializeComponent();
        }
        
        public void AppViewer_Load(object sender, EventArgs e)
        {
            if(!Bass.BASS_Init(-1,44100,BASSInit.BASS_DEVICE_CPSPEAKERS,this.Handle))
            {
                MessageBox.Show(Bass.BASS_ErrorGetCode().ToString());
                BassNet.Registration("zhaiyuhanx@hotmail.com", "2X3931422312422");
            }
             
            Infoablum.Text = "";
            Infoartist.Text = "";
            InfoTitle.Text = "";
            Infoyear.Text = "";
            textBoxTitle.Left = (this.ClientRectangle.Width - textBoxTitle.Width) / 2; textBoxTitle.BringToFront();
            textBoxArtist.Left = (this.ClientRectangle.Width - textBoxArtist.Width) / 2; textBoxArtist.BringToFront();
            Panel1.Left = (this.ClientRectangle.Width - Panel1.Width) / 2; Panel1.BringToFront();
            Player.Left = (this.ClientRectangle.Width - Player.Width) / 2; Player.BringToFront();
            Panel2.Left = (this.ClientRectangle.Width - Panel2.Width) / 2; Panel2.BringToFront();          
            VolumeMaster.DM_Value = (double)volume;
            PlayControlsBG.Left = (this.ClientRectangle.Width - PlayControlsBG.Width) / 2; PlayControlsBG.BringToFront();

        }

       
        private void CloseViewer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximization_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }         else if(WindowState==FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }       

        

        private void AppViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_ChannelStop(stream);
            Bass.BASS_StreamFree(stream);
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }
        private Visuals _vis = new Visuals(); // visuals class instance
        #region Spectrum
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

        private void pictureBoxSpectrum_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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


        #endregion Spectrum
        private void Position_Tick(object sender, EventArgs e)
        {
            len = Bass.BASS_ChannelGetLength(stream); // length in bytes
            totaltime = Bass.BASS_ChannelBytes2Seconds(stream, len); // the total time length
            long pos = Bass.BASS_ChannelGetPosition(stream); // position in bytes
            double elapsedtime = Bass.BASS_ChannelBytes2Seconds(stream, pos); // the elapsed time length
            double remainingtime = totaltime - elapsedtime;
            ThisTime.Text = String.Format(Utils.FixTimespan(elapsedtime, "MMSS"));
            TotalTime.Text = String.Format(Utils.FixTimespan(remainingtime, "MMSS"));
            Pos.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
            double pSecsD = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));
            Pos.Value = (int)pSecsD;
            if(Bass.BASS_ChannelIsActive(stream)==BASSActive.BASS_ACTIVE_PLAYING)
            {
                DrawSpectrum();
            }
            else
            {
                pictureBoxSpectrum.Image = null;
                Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_play;
                Pos.Value = 0;
            }
        }

        private void Player_MouseMove(object sender, MouseEventArgs e)
        {
            //Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_pause;
        }

        private void Player_MouseLeave(object sender, EventArgs e)
        {
            //Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_play;

        }

        private void Player_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void VolumeMaster_Click(object sender, EventArgs e)
        {
            volume = (int)VolumeMaster.DM_Value;
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, volume * 100);
        }
        long len = 0; double totaltime;
        private void LoadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName)) { filename = ofd.FileName; } else { filename = String.Empty; }
                //if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
                {
                    //Position.Enabled = false;
                    Bass.BASS_StreamFree(stream);
                    stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
                    len = Bass.BASS_ChannelGetLength(stream); // length in bytes
                    totaltime = Bass.BASS_ChannelBytes2Seconds(stream, len); // the total time length
                    TotalTime.Text = String.Format(Utils.FixTimespan(totaltime, "MMSS"));
                    BASS_CHANNELINFO info = new BASS_CHANNELINFO();
                    Bass.BASS_ChannelGetInfo(stream, info);
                    TAG_INFO tagInfo = new TAG_INFO(filename);
                    TagPicture picture = new TagPicture(filename);
                    Panel2.Visible = false;
                    ListBoxMusicList.Items.Add(filename);
                    if (BassTags.BASS_TAG_GetFromFile(stream, tagInfo))
                    {
                        this.textBoxTitle.Text = tagInfo.title;
                        this.textBoxArtist.Text = tagInfo.artist + "-" + tagInfo.album;
                        album = tagInfo.album;
                        title = tagInfo.title;
                        artist = tagInfo.artist;
                        year = tagInfo.year;
                        GetPicture();
                        AlbumViewer.BackgroundImage = albumArt;
                        textBoxTitle.Left = (this.ClientRectangle.Width - textBoxTitle.Width) / 2; textBoxTitle.BringToFront();
                        textBoxTitle.Visible = true;
                        textBoxArtist.Left = (this.ClientRectangle.Width - textBoxArtist.Width) / 2; textBoxArtist.BringToFront();
                        textBoxArtist.Visible = true;
                        Panel1.Left = (this.ClientRectangle.Width - Panel1.Width) / 2; Panel1.BringToFront();
                        Panel1.Visible = true;
                        InfoPicture.Visible = true;
                    }
                }
            }
        }
        private void Play()
        {
            if (filename != String.Empty)
            {            
                BASS_CHANNELINFO info = new BASS_CHANNELINFO();
                TAG_INFO  tagInfo = new TAG_INFO(filename);
                Bass.BASS_ChannelGetInfo(stream, info);          
                if (BassTags.BASS_TAG_GetFromFile(stream, tagInfo))
                {
                    this.textBoxTitle.Text = tagInfo.title;
                    this.textBoxArtist.Text = tagInfo.artist + "-" + tagInfo.album;
                    GetPicture();
                    
                }
                if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
                {
                    Bass.BASS_ChannelStop(stream);
                    Bass.BASS_StreamFree(stream);
                    stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
                    Bass.BASS_ChannelPlay(stream, true);
                    Position.Enabled = true;
                    Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_pause;
                    AlbumViewer.BackgroundImage = albumArt;
                    
                }
                else if(stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
                {
                    Bass.BASS_ChannelPause(stream);
                    Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_pause;
                }
                else if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
                {
                    Bass.BASS_ChannelPlay(stream, false);
                    Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_play;
                }
                else if (stream != 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PAUSED)
                {
                    Bass.BASS_ChannelPlay(stream, false);
                    Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_pause;
                }
                else if (stream == 0 && Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_STOPPED)
                {
                    Bass.BASS_StreamFree(stream);
            
                    Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_play;
                }
            }

        }

        private void Pos_Scroll(object sender, ScrollEventArgs e)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)Pos.Value);
        }

        private void pictureBoxSpectrum_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                specIdx++;
            else
                specIdx--;

            if (specIdx > 15)
                specIdx = 0;
            if (specIdx < 0)
                specIdx = 15;
           // this.labelVis.Text = String.Format("{0} of 16 (click L/R mouse to change)", specIdx + 1);
            this.pictureBoxSpectrum.Image = null;
            _vis.ClearPeaks();
        }

        private void List_Click(object sender, EventArgs e)
        {
            switch(PlayList.Visible)
            {
                case true:
                    PlayList.Visible = false; Panel1.Visible = true; Panel2.Visible = false; textBoxArtist.Visible = true; textBoxTitle.Visible = true;More.Enabled = true;
                    break;
                case false:
                    PlayList.Visible = true;Panel1.Visible = false;Panel2.Visible = false;textBoxArtist.Visible = false;textBoxTitle.Visible = false;More.Enabled = false;
                    break;
            }
        }

        private void LoadPicture_Click(object sender, EventArgs e)
        {
            this.DM_BackPalace = changebg;
            LoadPicture.Visible = false;
            Panel2.Visible = false;
            Panel1.Visible = true;
            textBoxArtist.Visible = true;
            textBoxTitle.Visible = true;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            LoadFile();

        }

        private void AlbumViewer_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
            textBoxArtist.Visible = false;
            textBoxTitle.Visible = false;
        }

        private void DSPViewerShow_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(stream);
            System.Diagnostics.Process.Start("DSPViewer.exe", System.IO.Directory.GetCurrentDirectory());


        }

        private void EncoderShow_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(stream);
            System.Diagnostics.Process.Start("EncoderViewer.exe", System.IO.Directory.GetCurrentDirectory());
        }

        private void ListBoxMusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            filename = ListBoxMusicList.SelectedItem.ToString();
        }

        private void CloseListBox_Click(object sender, EventArgs e)
        {
            PlayList.Visible = false;
            textBoxArtist.Visible = true;
            textBoxTitle.Visible = true;
            Panel1.Visible = true;
            More.Enabled = true;
        }

        private void ListBoxMusicList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //DMSkin.MetroMessageBox.Show(this,"Click");
            Bass.BASS_ChannelStop(stream);
            Bass.BASS_StreamFree(stream);
            stream = Bass.BASS_StreamCreateFile(filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
            Bass.BASS_ChannelPlay(stream, true);
            Position.Enabled = true;
            Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_pause;
            AlbumViewer.BackgroundImage = albumArt;
        }

        private void ShowMessageBox_Click(object sender, EventArgs e)
        {
            DMSkin.MetroMessageBox.Show(this, "双击播放");
        }

        private void OpenSetting_Click(object sender, EventArgs e)
        {
            UI.Setting setting = new UI.Setting();
            setting.Show();
            if (LoadPicture.Visible == true) { LoadPicture.Visible = false; }
            else if (LoadPicture.Visible == false) { LoadPicture.Visible = true; }
        }



        private void More_Click(object sender, EventArgs e)
        {
            if(Panel1.Visible==false&&textBoxArtist.Visible==false&&textBoxTitle.Visible==false&&Panel2.Visible==false&&stream==0)//First
            {          
                Panel2.Visible = true;

            }else if(Panel1.Visible == false && textBoxArtist.Visible == false && textBoxTitle.Visible == false && Panel2.Visible == true&&stream==0)//First
            {
                Panel2.Visible = false;

            } else if(Panel1.Visible == false && textBoxArtist.Visible == false && textBoxTitle.Visible == false && Panel2.Visible == true&&stream!=0)//Again
            {
                Panel1.Visible = true;
                textBoxTitle.Visible = true;
                textBoxArtist.Visible = true;

                Panel2.Visible = false;
                InfoPicture.BackgroundImage = albumArt;
                InfoTitle.Text = title;
                Infoartist.Text = artist;
                Infoablum.Text = album;
            }else if(Panel1.Visible == true && textBoxArtist.Visible == true && textBoxTitle.Visible == true && Panel2.Visible == false)
            {
                Panel1.Visible = false;
                textBoxTitle.Visible = false;
                textBoxArtist.Visible = false;

                Panel2.Visible = true;
                InfoPicture.BackgroundImage = albumArt;
                InfoTitle.Text = title;
                Infoartist.Text = artist;
                Infoablum.Text = album;
               
            }
            else if (Panel1.Visible == false && textBoxArtist.Visible == false && textBoxTitle.Visible == false && Panel2.Visible == false && stream != 0)//Again
            {
                Panel2.Visible = true;
            }
        }

        private void AppViewer_Resize(object sender, EventArgs e)
        {
            textBoxTitle.Left = (this.ClientRectangle.Width - textBoxTitle.Width) / 2; textBoxTitle.BringToFront();
            textBoxArtist.Left = (this.ClientRectangle.Width - textBoxArtist.Width) / 2;textBoxArtist.BringToFront();
            Panel1.Left = (this.ClientRectangle.Width - Panel1.Width) / 2; Panel1.BringToFront();
            Player.Left = (this.ClientRectangle.Width - Player.Width) / 2; Player.BringToFront();
            Panel2.Left = (this.ClientRectangle.Width - Panel2.Width) / 2; Panel2.BringToFront();     
            PlayControlsBG.Left = (this.ClientRectangle.Width - PlayControlsBG.Width) / 2; PlayControlsBG.BringToFront();
        }


    }
}
