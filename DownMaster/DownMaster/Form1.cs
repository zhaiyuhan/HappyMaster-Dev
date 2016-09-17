using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DownMaster
{
    public partial class Form1 : DMSkin.Main
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDown_MouseEnter(object sender, EventArgs e)
        {
            btnDown.ForeColor = Color.White;
        }

        private void btnDown_MouseLeave(object sender, EventArgs e)
        {
            btnDown.ForeColor = Color.Black;
        }

        XL.DownTaskInfo info = new XL.DownTaskInfo();
        private IntPtr a;

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                btnDown.Enabled = false;
                timer1.Enabled = true;
                timer1.Interval = 500;
                var initSuccess = XL.XL_Init();
                if (initSuccess)
                {
                    XL.DownTaskParam p = new XL.DownTaskParam()
                    {
                        IsResume = 0,
                        szTaskUrl = urlTextbox.Text,
                        szFilename = FilenameText.Text,
                        szSavePath = AppDomain.CurrentDomain.BaseDirectory
                    };
                    a = XL.XL_CreateTask(p);
                    var startSuccess = XL.XL_StartTask(a);
                    downProgress.Focus();
                }
                else
                {
                    MessageBox.Show("XL_Init初始化失败");
                }
            }
            catch (Exception ex)
            {
                btnDown.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //var qq = XL.XL_QueryTaskInfoEx(a, info);
            downProgress.Value = (int)(info.fPercent * 100);
            //var aa = string.Format("{0}进度{1},速度{2},状态{3}", DateTime.Now, info.fPercent, info.nSpeed, info.stat);
            //listBox1.Items.Add(aa);
            if (info.stat == XL.DOWN_TASK_STATUS.TSC_COMPLETE)
            {
                btnDown.Enabled = true;
                timer1.Enabled = false;
            }
        }
    }
}
