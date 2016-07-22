using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using HappyMaster.Core;

namespace KrcMusic
{
    public partial class KrcWin : Form
    {

       
        public KrcWin()
        {
            InitializeComponent();
        }

        const int Guying_HTLEFT = 10;
        const int Guying_HTRIGHT = 11;
        const int Guying_HTTOP = 12;
        const int Guying_HTTOPLEFT = 13;
        const int Guying_HTTOPRIGHT = 14;
        const int Guying_HTBOTTOM = 15;
        const int Guying_HTBOTTOMLEFT = 0x10;
        const int Guying_HTBOTTOMRIGHT = 17;
       
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;
                CreateParams cParms = base.CreateParams;
                cParms.Style = cParms.Style | WS_MINIMIZEBOX;   // 允许最小化操作
                if (!DesignMode)//设计模式下不执行代码 && isLayeredWindowForm
                {
                    cParms.ExStyle |= 0x00080000; // WS_EX_LAYERED层样式
                }
                return cParms;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //Win32.SetWindowLong(Handle, Win32.GWL_EXSTYLE, Win32.GetWindowLong(Handle, Win32.GWL_EXSTYLE) | Win32.WS_EX_LAYERED);
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = 100;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 50; //(Screen.PrimaryScreen.WorkingArea.Height - this.Height )/2 ;
            this.Left = 0;
            
            TextInfo.FontFamily = new FontFamily("微软雅黑");
            TextInfo.FontSize = 40;
            timer1.Enabled = true;
        }


        public KrcText TextInfo = new KrcText();

        public bool NeedRefresh = true;
        private Bitmap LastBitmapBgText;    //缓存背景绘图
        private Bitmap LastBitmapKrcText;   //缓存KRC绘图
        private string LastText;
        private float LastTextWidth;

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            testPercent+=(float)new Random().Next(0,10)/10;
            if (testPercent > 100)
            {
                testPercent = 100;
            }
            kd.DrawKrc("三星galaxy note7 苹果Iphone 8", testPercent);
            if (testPercent >= 100)
            {
                testPercent = 0;
            }
            */
        }
        bool DrBack = false;
        public Bitmap DrawKrc(string text, float percent, string textLast = "", string textNext = "")
        {
            //背景文字图层bmp
            lastStr = text;
            intp = percent;
            int KrcWidth = 0; //当前歌词宽度
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            sf.FormatFlags = StringFormatFlags.NoWrap;
            if (text == "")
            {
                return new Bitmap(10, 10);
            }
            //return new Bitmap(10, 10);
            if (LastText != text || NeedRefresh)
            {
                NeedRefresh = false;
                
                LastText = text;
                //绘制背景

                //  
                //Krc覆盖图层bmp
                Bitmap bmpDrawable = new Bitmap(this.Width, this.Height);
                //最终图层
                Graphics bg = Graphics.FromImage(bmpDrawable);

                bg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
                bg.SmoothingMode = SmoothingMode.HighQuality;
                // bg.InterpolationMode = InterpolationMode.HighQualityBicubic;
                bg.CompositingQuality = CompositingQuality.HighQuality;

                
                // bg.FillRectangle(new SolidBrush(Color.FromArgb(0x30000000)), new Rectangle(0, 0, this.Width, this.Height));
                //计算文字实际宽度
                SizeF TextSize = bg.MeasureString(text, new Font(TextInfo.FontFamily, TextInfo.FontSize * 0.75F), this.Width, sf);
                //计算当前歌词宽度
                LastTextWidth = TextSize.Width;


                if (DrBack)
                {
                    bg.FillRectangle(new SolidBrush(Color.FromArgb(120, 255, 255, 255)), 0, 0, Width, Height);
                }
                else
                {
                    bg.FillRectangle(new SolidBrush(Color.FromArgb(5, 255, 255, 255)), Width / 3, 0, Width - Width / 3 * 2, Height);
                }

                //绘制文字阴影
                for (int i = -6; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(text, TextInfo.FontFamily, 0, TextInfo.FontSize, new Rectangle(i, i, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((6 - Math.Abs(i)) * (15 - Math.Abs(i)), Color.Black)), gphBG);
                }
                for (int i = -2; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(text, TextInfo.FontFamily, 0, TextInfo.FontSize, new Rectangle(i, i, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((5 - Math.Abs(i)) * (13 - Math.Abs(i)), Color.Black)), gphBG);
                }

                for (int i = -6; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(text, TextInfo.FontFamily, 0, TextInfo.FontSize, new Rectangle(0, i, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((6 - Math.Abs(i)) * (15 - Math.Abs(i)), Color.Black)), gphBG);
                }
                for (int i = -2; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(text, TextInfo.FontFamily, 0, TextInfo.FontSize, new Rectangle(i, 0, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((5 - Math.Abs(i)) * (13 - Math.Abs(i)), Color.Black)), gphBG);
                }

                LinearGradientBrush bgNextBrush = new LinearGradientBrush(new RectangleF(0, 20 / 0.75F, TextSize.Width, this.Height),
    Color.FromArgb(0xFF, 0xD1, 0xFF, 0x36), Color.FromArgb(0xFF, 0xD1, 0xFF, 0x36), LinearGradientMode.Vertical);

                LinearGradientBrush bgTextBrush = new LinearGradientBrush(new RectangleF(0, TextSize.Height / 0.75F, TextSize.Width, TextSize.Height / 0.75F),
                    Color.FromArgb(0xFF, 0x88, 0xF4, 0x21), Color.FromArgb(0xFF, 0x0F, 0x68, 0x00), LinearGradientMode.Vertical);
                //绘制KRC背景文字
                GraphicsPath gph = new GraphicsPath();
                gph.AddString(text, TextInfo.FontFamily, 0, TextInfo.FontSize, new Rectangle(0, 0, this.Width, this.Height), sf);
                bg.FillPath(bgTextBrush, gph);

                sf.LineAlignment = StringAlignment.Near;

                for (int i = -3; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textLast, TextInfo.FontFamily, 0, 20, new Rectangle(i, i, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((4 - Math.Abs(i)) * (15 - Math.Abs(i)), Color.Black)), gphBG);

                }
                for (int i = -2; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textLast, TextInfo.FontFamily, 0, 20, new Rectangle(i, i, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((5 - Math.Abs(i)) * (13 - Math.Abs(i)), Color.Black)), gphBG);
                }
                for (int i = -3; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textLast, TextInfo.FontFamily, 0, 20, new Rectangle(0, i, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((4 - Math.Abs(i)) * (15 - Math.Abs(i)), Color.Black)), gphBG);
                }
                for (int i = -2; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textLast, TextInfo.FontFamily, 0, 20, new Rectangle(i, 0, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((5 - Math.Abs(i)) * (13 - Math.Abs(i)), Color.Black)), gphBG);
                }


                GraphicsPath gphLast = new GraphicsPath();
                gphLast.AddString(textLast, TextInfo.FontFamily, 0, 20, new Rectangle(0, 0, this.Width, this.Height), sf);
                bg.FillPath(bgNextBrush, gphLast);


                int y = Convert.ToInt32((TextInfo.FontSize + 20F) / 0.75F) - 10;

                for (int i = -3; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textNext, TextInfo.FontFamily, 0, 20, new Rectangle(i, i + y, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((4 - Math.Abs(i)) * (15 - Math.Abs(i)), Color.Black)), gphBG);

                }
                for (int i = -2; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textNext, TextInfo.FontFamily, 0, 20, new Rectangle(i, i + y, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((5 - Math.Abs(i)) * (13 - Math.Abs(i)), Color.Black)), gphBG);
                }
                for (int i = -3; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textNext, TextInfo.FontFamily, 0, 20, new Rectangle(0, i + y, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((4 - Math.Abs(i)) * (15 - Math.Abs(i)), Color.Black)), gphBG);
                }
                for (int i = -2; i < 5; i++)
                {
                    GraphicsPath gphBG = new GraphicsPath();
                    gphBG.AddString(textNext, TextInfo.FontFamily, 0, 20, new Rectangle(i, 0 + y, this.Width, this.Height), sf);
                    bg.FillPath(new SolidBrush(Color.FromArgb((5 - Math.Abs(i)) * (13 - Math.Abs(i)), Color.Black)), gphBG);
                }





                GraphicsPath gphNext = new GraphicsPath();
                gphNext.AddString(textNext, TextInfo.FontFamily, 0, 20, new Rectangle(0, y,
                    this.Width, this.Height), sf);
                bg.FillPath(bgNextBrush, gphNext);


                sf.LineAlignment = StringAlignment.Center;


                Bitmap bmpKrc = new Bitmap(this.Width, this.Height);
                //Krc覆盖图层
                Graphics KrcBg = Graphics.FromImage(bmpKrc);
                KrcBg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
                KrcBg.SmoothingMode = SmoothingMode.HighQuality;
                // KrcBg.InterpolationMode = InterpolationMode.HighQualityBilinear;
                KrcBg.CompositingQuality = CompositingQuality.HighQuality;

                //绘制KRC文字
                GraphicsPath KrcGph = new GraphicsPath();
                StringFormat KrcSf = new StringFormat();
                KrcSf.Alignment = StringAlignment.Center;
                KrcSf.LineAlignment = StringAlignment.Center;
                KrcSf.FormatFlags = StringFormatFlags.NoWrap;
                KrcGph.AddString(text, TextInfo.FontFamily, 0, TextInfo.FontSize, new Rectangle(0, 0, this.Width, this.Height), KrcSf);

                LinearGradientBrush bgKRCBrush = new LinearGradientBrush(new RectangleF(0, TextSize.Height / 0.75F / 2, TextSize.Width, TextSize.Height / 0.75F / 2),
                    Color.FromArgb(0xFF, 0x9C, 0xFE, 0x17), Color.FromArgb(0xFF, 0xEC, 0xFE, 0xD4), LinearGradientMode.Vertical);

                KrcBg.FillPath(bgKRCBrush, KrcGph);


                LastBitmapBgText = new Bitmap(bmpDrawable);
                LastBitmapKrcText = new Bitmap(bmpKrc);

                bg.Dispose();
                gph.Dispose();
                KrcSf.Dispose();
                KrcBg.Dispose();
                KrcGph.Dispose();
                bmpDrawable.Dispose();
                bmpKrc.Dispose();
                Debug.Print(System.DateTime.Now.ToString() + " refresh");

            }

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics main = Graphics.FromImage(bmp);

            KrcWidth = (int)(LastTextWidth * percent / 100F + (Convert.ToSingle(this.Width) - LastTextWidth) / 2F);

            main.DrawImage(LastBitmapBgText, new Point(0, 0));

            TextureBrush tBrush = new TextureBrush(LastBitmapKrcText);
            main.FillRectangle(tBrush, new Rectangle(0, 0, (int)KrcWidth, this.Height));

            main.Dispose();
            tBrush.Dispose();
            sf.Dispose();


            SetBits(bmp);
            return bmp;
        }


        private void KrcWin_Resize(object sender, EventArgs e)
        {
            NeedRefresh = true;
        }

        /// <summary>
        /// 更新窗体
        /// </summary>
        /// <param name="bitmap"></param>
        public void SetBits(Bitmap bitmap)
        {
            IntPtr oldBits = IntPtr.Zero;
            IntPtr screenDC = Win32.GetDC(IntPtr.Zero);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr memDc = Win32.CreateCompatibleDC(screenDC);
            try
            {
                Win32.Point topLoc = new Win32.Point(Left, Top);
                Win32.Size bitMapSize = new Win32.Size(bitmap.Width, bitmap.Height);
                Win32.BLENDFUNCTION blendFunc = new Win32.BLENDFUNCTION();
                Win32.Point srcLoc = new Win32.Point(0, 0);
                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0)); //创建GDI位图
                oldBits = Win32.SelectObject(memDc, hBitmap);
                blendFunc.BlendOp = Win32.AC_SRC_OVER;
                blendFunc.SourceConstantAlpha = 255;
                blendFunc.AlphaFormat = Win32.AC_SRC_ALPHA;
                blendFunc.BlendFlags = 0;
                Win32.UpdateLayeredWindow(Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, Win32.ULW_ALPHA);  //更新窗体
            }
            finally
            {
                if (hBitmap != IntPtr.Zero)
                {
                    Win32.SelectObject(memDc, oldBits);
                    Win32.DeleteObject(hBitmap);
                }
                Win32.ReleaseDC(IntPtr.Zero, screenDC);
                Win32.DeleteDC(memDc);
            }
            bitmap.Dispose(); //释放
        }
        string lastStr;
        float intp;
        private void KrcWin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void KrcWin_MouseLeave(object sender, EventArgs e)
        {
            DrBack = false;
            NeedRefresh = true;
            DrawKrc(lastStr, intp);
        }

        private void KrcWin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//窗体移动
        }
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]//无边框窗体移动
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void KrcWin_MouseEnter(object sender, EventArgs e)
        {
            
           
        }

        private void KrcWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePosition.X<Width/3||MousePosition.X>Width/3*2)
            {
                DrBack = false;
                NeedRefresh = true;
                DrawKrc(lastStr, intp);
            }
            else
            {
                DrBack = true;
                NeedRefresh = true;
                DrawKrc(lastStr, intp);
            }
        }
    }
}
