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
                LabelRate.Text = "44.100 kHZ";
                TextBoxFileName.Text = tagInfo.filename;
                PictureBox.BackgroundImage = MainView.exalbumart;
                TopPanel.BackgroundImage = MainView.exalbumart;
            }
            LabelCreatTime.Text = "" + _fileinfo.CreationTime;
            double last = _fileinfo.Length / 1024 % 1024 / 10;            
            LabelFileSize.Text = _fileinfo.Length / 1024 / 1024 + "." + Math.Round(last, 2) + "MB";
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

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            if (CopyFile.ShowDialog() ==System.Windows.Forms.DialogResult.OK) 
            {            
                _fileinfo.CopyTo(CopyFile.FileName);
            }
        }
    }
}
