//  ┏┓　    ┏┓
//┏┛┻━━━┛┻┓
//┃　　　　　    ┃
//┃　　 ━　   　┃
//┃　┳┛　┗┳　┃
//┃　　　　　    ┃
//┃　　　┻　  　┃
//┃　　　　　    ┃
//┗━┓　　　┏━┛
//    ┃　　　┃   神兽保佑 Tom所属
//    ┃　　　┃   代码无BUG！
//    ┃　　　┗━━━┓
//    ┃　　　　      ┗┓
//    ┃　　　　      ┏┛
//    ┗┓┓┏━┳┓┏┛
//      ┃┫┫  ┃┫┫
//      ┗┻┛  ┗┻┛

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Drawing.Imaging;

namespace TSkin
{
    [DefaultProperty("Text")]
    public partial class TOMPanel : Panel
    {
        public TOMPanel()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.Selectable |
                ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.Transparent;
            this.UpdateStyles();
        }

        Image _ag = null;
        /// <summary>
        /// 进度颜色
        /// </summary>
        [Description("设置图像")]
        public Image Image
        {
            get { return _ag; }
            set
            {
                _ag = value;
                if (_ag != null)
                {
                    sWidth = _ag.Width; sHeight = _ag.Height;
                }
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            try
            {
                Graphics g = pevent.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                int destHeight = ClientRectangle.Height; int destWidth = ClientRectangle.Width;
                Rectangle rect = new Rectangle(ClientRectangle.X, ClientRectangle.Y, destWidth, destHeight);
                if (BackColor != Color.Transparent)
                {
                    g.FillRectangle(new SolidBrush(BackColor), rect);
                }
                if (_ag != null)
                {
                    Image imgSource = _ag;
                    int sW = 0, sH = 0;
                    if ((sWidth * destHeight) > (sHeight * destWidth))
                    {
                        sH = destHeight;
                        sW = (sWidth * destHeight) / sHeight;
                    }
                    else
                    {
                        sW = destWidth;
                        sH = (destWidth * sHeight) / sWidth;
                    }
                    if (_IsGauss)
                    {
                        Bitmap b1 = new Bitmap(imgSource);
                        imgSource = API.ImageGauss.Init(b1, _Gauss);
                    }
                    // 设置画布的描绘质量         
                    g.DrawImage(imgSource, new Rectangle((destWidth - sW) / 2, (destHeight - sH) / 2, sW, sH), 0, 0, imgSource.Width, imgSource.Height, GraphicsUnit.Pixel);
                    //g.DrawImage(imgSource, rect, 0, 0, imgSource.Width, imgSource.Height, GraphicsUnit.Pixel);
                }
            }
            catch { }
        }
        bool _IsGauss = false;
        [Description("是否启动高斯模糊")]
        public bool IsGauss
        {
            get { return _IsGauss; }
            set
            {
                _IsGauss = value;
                this.Refresh();
            }
        }
        int _Gauss;
        [Description("高斯模糊程序0-255")]
        public int Gauss
        {
            get { return _Gauss; }
            set
            {
                if (value <= 0)
                {
                    _Gauss = 1;
                }
                else if (value > 255)
                {
                    _Gauss = 255;
                }
                else
                {
                    _Gauss = value;
                }
                this.Refresh();
            }
        }
        private int sWidth = 0;
        private int sHeight = 0;
    }
}