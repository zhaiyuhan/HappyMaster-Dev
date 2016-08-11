using System;
using System.Drawing;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;
using System.IO;

namespace HappyMaster_Dev.View
{
    public partial class Infomation : DMSkin.Main
    {
        public Infomation()
        {
            InitializeComponent();
        }
        public string _Filename;
        public int _stream;
        FileInfo _fileinfo = new FileInfo(MainView.exfilename);
        private void Infomation_Load(object sender, EventArgs e)
        {
            _Filename = MainView.exfilename;
            _stream = Bass.BASS_StreamCreateFile(_Filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
            BASS_CHANNELINFO _info = new BASS_CHANNELINFO();
            Bass.BASS_ChannelGetInfo(_stream, _info);
            TAG_INFO tagInfo = new TAG_INFO(_Filename);
            if (BassTags.BASS_TAG_GetFromFile(_stream, tagInfo))
            {
                TextBoxTitle.Text = tagInfo.title;
                TextBoxArtist.Text = tagInfo.artist;
                TextBoxAlbum.Text = tagInfo.album;
                LabelBit.Text = tagInfo.bitrate.ToString() + " kbps";
                LabelRate.Text = "44.100 kHZ";
            }
            LabelCreatTime.Text = "" + _fileinfo.CreationTime;
            double last = _fileinfo.Length / 1024 % 1024;
            LabelFileSize.Text = _fileinfo.Length / 1024 / 1024 + "." + last + "MB";
            //HumanReadableFilesize(Convert.ToDouble(_fileinfo.Length)) + last;
        }
        private String HumanReadableFilesize(double size)
        {
            String[] units = new String[] { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)   {  size /= mod;   i++;  }
            return Math.Round(size) + units[i];
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
    }
}
