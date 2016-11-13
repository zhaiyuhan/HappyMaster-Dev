using System;
using System.Drawing;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using GdipEffect;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Linq;

namespace HappyMaster_Dev.View
{
    public partial class Infomation : DMSkin.Main
    {
        public Infomation()
        {
            InitializeComponent();
        }
        public Image albumArt;// = MainView.exalbumart;
        //copied from Main View
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
            IntPtr ptr = Bass.BASS_ChannelGetTags(_stream, BASSTag.BASS_TAG_ID3V2);
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

        public string _Filename;
        public int _stream;
        FileInfo _fileinfo = new FileInfo(MainView.exfilename);
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
                Bmp.GaussianBlur(ref Rect, 100, false);
                Sw.Stop();
                TopPanel.BackgroundImage = Bmp;
            }
        }/*
        BASS_CHANNELINFO info = new BASS_CHANNELINFO();
        Bass.BASS_ChannelGetInfo(stream, info);*/
        string thisFileType = string.Empty;
        public void getType()
        {
            BASS_CHANNELINFO info = new BASS_CHANNELINFO();
            Bass.BASS_ChannelGetInfo(_stream, info); // get info
            Debug.WriteLine(info.freq);
            LabelRate.Text = info.freq + " kHZ";
            switch (info.ctype)
            {
                case BASSChannelType.BASS_CTYPE_STREAM_MP3:
                    btnCopyFile.Text= "拷贝MP3文件到";
                    break;
                case BASSChannelType.BASS_CTYPE_STREAM_MF:
                    btnCopyFile.Text = "拷贝FLAC文件到";
                    break;
                case BASSChannelType.BASS_CTYPE_STREAM_OGG:
                    btnCopyFile.Text = "拷贝OGG文件到";
                    break;
                case BASSChannelType.BASS_CTYPE_STREAM_AAC:
                    btnCopyFile.Text = "拷贝ACC文件到";
                    break;
                case BASSChannelType.BASS_CTYPE_STREAM_WAV:
                    btnCopyFile.Text = "拷贝WAV文件到";
                    break;
                case BASSChannelType.BASS_CTYPE_STREAM_WMA:
                    btnCopyFile.Text = "拷贝WMA文件到";
                    break;
                case BASSChannelType.BASS_CTYPE_STREAM_APE:
                    btnCopyFile.Text = "拷贝APE文件到";
                    break;
                case BASSChannelType.BASS_CTYPE_STREAM_FLAC:
                    btnCopyFile.Text = "拷贝FLAC文件到";
                    break;
                default:
                    btnCopyFile.Text = "拷贝未知格式文件到";
                    break;

            }
        }
        void outputFileName()
        {
            string strFilePath = _Filename;
            CopyFile.FileName=TextBoxTitle.Text+ Path.GetExtension(strFilePath);
        }
        private void Infomation_Load(object sender, EventArgs e)
        {
            if (MainView.exfilename != string.Empty) 
            {
                _Filename = MainView.exfilename;
            }           
            _stream = Bass.BASS_StreamCreateFile(_Filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
            BASS_CHANNELINFO _info = new BASS_CHANNELINFO();
            Bass.BASS_ChannelGetInfo(_stream, _info);
            TAG_INFO tagInfo = new TAG_INFO(_Filename);
            if (BassTags.BASS_TAG_GetFromFile(_stream, tagInfo))
            {
                GetPicture();
                TextBoxTitle.Text = tagInfo.title;
                TextBoxArtist.Text = tagInfo.artist;
                TextBoxAlbum.Text = tagInfo.album;
                LabelBit.Text = tagInfo.bitrate.ToString() + " K bps";
                
                TextBoxFileName.Text = tagInfo.filename;
                PictureBox.BackgroundImage = MainView.exalbumart;
                TopPanel.BackgroundImage = MainView.exalbumart;
            }
            else
            {
                //GetPicture();
                TextBoxTitle.Text = tagInfo.title;
                TextBoxArtist.Text = tagInfo.artist;
                TextBoxAlbum.Text = tagInfo.album;
                LabelBit.Text = tagInfo.bitrate.ToString() + " K bps";
                
                TextBoxFileName.Text = tagInfo.filename;
                PictureBox.BackgroundImage = null;
                TopPanel.BackgroundImage = null;
            }
            LabelCreatTime.Text = "" + _fileinfo.CreationTime;
            double last = _fileinfo.Length / 1024 % 1024 / 10;            
            LabelFileSize.Text = _fileinfo.Length / 1024 / 1024 + "." + Math.Round(last, 2) + "MB";
            LabelLastEditTime.Text = _fileinfo.LastWriteTime.ToString();
            /*Glass Top Background*/
            if (albumArt == null)
            {
                return;
            }
            else
            {
                Bmp = (Bitmap)albumArt;
                BitmapData BmpData = new BitmapData();
                Bmp.LockBits(new Rectangle(0, 0, Bmp.Width, Bmp.Height), ImageLockMode.ReadWrite, Bmp.PixelFormat, BmpData);
                ImagePointer = BmpData.Scan0;
                DataLength = BmpData.Stride * BmpData.Height;
                ImageCopyPointer = Marshal.AllocHGlobal(DataLength);
                CopyMemory(ImageCopyPointer, ImagePointer, DataLength);
                Bmp.UnlockBits(BmpData);
                TopPanel.BackgroundImage = Bmp;
                UpdateImage();
            }

            /*End*/
            getType();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_MouseEnter(object sender, EventArgs e)
        {
            btnDone.ForeColor = Color.White;
        }

        private void btnDone_MouseLeave(object sender, EventArgs e)
        {
            btnDone.ForeColor = Color.Black;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (PictureBox.BackgroundImage != null)
            {
                Bitmap outputImage = new Bitmap(PictureBox.BackgroundImage);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "获取专辑图片并保存为";
                sfd.Filter = "JPG文件(*.jpg)|*.jpg";
                sfd.FileName = TextBoxTitle.Text + "的专辑封面";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    outputImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                
            }
        }
        protected void setToolTip()
        {
            ToolTip thistip = new ToolTip();
            thistip.InitialDelay = 200;
            thistip.AutoPopDelay = 10 * 100;
            thistip.ReshowDelay = 200;
            thistip.ShowAlways = true;
            thistip.IsBalloon = false;
            string tipOverwrite = "保存专辑图片";
            thistip.SetToolTip(PictureBox, tipOverwrite);
        }
        private void TopPanel_MouseHover(object sender, EventArgs e)
        {
        }

        private void PictureBox_MouseHover(object sender, EventArgs e)
        {
            setToolTip();
        }
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
           // PictureBox
            /*PictureBox panel = (PictureBox)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (PictureBox p in panel.Controls.OfType<PictureBox>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }*/
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            
            CopyFile.Title = "拷贝文件到";
            //getType();         
            outputFileName();                 
            if (CopyFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {                
                _fileinfo.CopyTo(CopyFile.FileName);
            }
        }
    }
}
