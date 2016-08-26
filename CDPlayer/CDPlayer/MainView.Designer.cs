namespace CDPlayer
{
    partial class MainView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new DMSkin.Controls.DMButtonCloseLight();
            this.btnMin = new DMSkin.Controls.DMButtonMinLight();
            this.btnControlPanel = new CCWin.SkinControl.SkinButton();
            this.PanelControlPanel = new CCWin.SkinControl.SkinPanel();
            this.Volume = new DMSkin.Metro.Controls.MetroTrackBar();
            this.btnStop = new DMSkin.MetroDMButton();
            this.btnPause = new DMSkin.MetroDMButton();
            this.btnPlay = new DMSkin.MetroDMButton();
            this.btnLoadFile = new DMSkin.MetroDMButton();
            this.btnSetOp = new DMSkin.MetroDMButton();
            this.ShowTimer = new System.Windows.Forms.Timer(this.components);
            this.HideTimer = new System.Windows.Forms.Timer(this.components);
            this.Slider = new CCWin.SkinControl.SkinTrackBar();
            this.Pos = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelLeftTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PanelControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(424, 0);
            this.btnClose.MaximumSize = new System.Drawing.Size(30, 27);
            this.btnClose.MinimumSize = new System.Drawing.Size(30, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Location = new System.Drawing.Point(394, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 27);
            this.btnMin.TabIndex = 1;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnControlPanel.BaseColor = System.Drawing.Color.Transparent;
            this.btnControlPanel.BorderColor = System.Drawing.Color.Transparent;
            this.btnControlPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnControlPanel.DownBack = null;
            this.btnControlPanel.DownBaseColor = System.Drawing.Color.Transparent;
            this.btnControlPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnControlPanel.Location = new System.Drawing.Point(372, 483);
            this.btnControlPanel.MouseBack = null;
            this.btnControlPanel.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.NormlBack = null;
            this.btnControlPanel.Size = new System.Drawing.Size(75, 23);
            this.btnControlPanel.TabIndex = 2;
            this.btnControlPanel.Text = "展开面板";
            this.btnControlPanel.UseVisualStyleBackColor = false;
            this.btnControlPanel.Click += new System.EventHandler(this.btnControlPanel_Click);
            // 
            // PanelControlPanel
            // 
            this.PanelControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.PanelControlPanel.BackgroundImage = global::CDPlayer.Properties.Resources.glassBg;
            this.PanelControlPanel.Controls.Add(this.Volume);
            this.PanelControlPanel.Controls.Add(this.btnStop);
            this.PanelControlPanel.Controls.Add(this.btnPause);
            this.PanelControlPanel.Controls.Add(this.btnPlay);
            this.PanelControlPanel.Controls.Add(this.btnLoadFile);
            this.PanelControlPanel.Controls.Add(this.btnSetOp);
            this.PanelControlPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.PanelControlPanel.DownBack = null;
            this.PanelControlPanel.Location = new System.Drawing.Point(0, 31);
            this.PanelControlPanel.MaximumSize = new System.Drawing.Size(150, 447);
            this.PanelControlPanel.MinimumSize = new System.Drawing.Size(0, 447);
            this.PanelControlPanel.MouseBack = null;
            this.PanelControlPanel.Name = "PanelControlPanel";
            this.PanelControlPanel.NormlBack = null;
            this.PanelControlPanel.Size = new System.Drawing.Size(150, 447);
            this.PanelControlPanel.TabIndex = 3;
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.DM_UseCustomBackColor = true;
            this.Volume.Location = new System.Drawing.Point(8, 370);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(135, 23);
            this.Volume.TabIndex = 5;
            this.Volume.Value = 100;
            this.Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Volume_Scroll);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.DownImage = global::CDPlayer.Properties.Resources.MineButtonPress;
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Image = null;
            this.btnStop.IsShowBorder = false;
            this.btnStop.Location = new System.Drawing.Point(8, 126);
            this.btnStop.MoveImage = global::CDPlayer.Properties.Resources.MineButtonENTER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NormalImage = global::CDPlayer.Properties.Resources.MineButtonNOMRMAL;
            this.btnStop.Size = new System.Drawing.Size(125, 35);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseEnter += new System.EventHandler(this.btnStop_MouseEnter);
            this.btnStop.MouseLeave += new System.EventHandler(this.btnStop_MouseLeave);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.DownImage = global::CDPlayer.Properties.Resources.MineButtonPress;
            this.btnPause.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPause.Image = null;
            this.btnPause.IsShowBorder = false;
            this.btnPause.Location = new System.Drawing.Point(7, 85);
            this.btnPause.MoveImage = global::CDPlayer.Properties.Resources.MineButtonENTER;
            this.btnPause.Name = "btnPause";
            this.btnPause.NormalImage = global::CDPlayer.Properties.Resources.MineButtonNOMRMAL;
            this.btnPause.Size = new System.Drawing.Size(125, 35);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.MouseEnter += new System.EventHandler(this.btnPause_MouseEnter);
            this.btnPause.MouseLeave += new System.EventHandler(this.btnPause_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DownImage = global::CDPlayer.Properties.Resources.MineButtonPress;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.Image = null;
            this.btnPlay.IsShowBorder = false;
            this.btnPlay.Location = new System.Drawing.Point(8, 43);
            this.btnPlay.MoveImage = global::CDPlayer.Properties.Resources.MineButtonENTER;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.NormalImage = global::CDPlayer.Properties.Resources.MineButtonNOMRMAL;
            this.btnPlay.Size = new System.Drawing.Size(125, 35);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadFile.DownImage = global::CDPlayer.Properties.Resources.MineButtonPress;
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadFile.Image = null;
            this.btnLoadFile.IsShowBorder = false;
            this.btnLoadFile.Location = new System.Drawing.Point(8, 3);
            this.btnLoadFile.MoveImage = global::CDPlayer.Properties.Resources.MineButtonENTER;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.NormalImage = global::CDPlayer.Properties.Resources.MineButtonNOMRMAL;
            this.btnLoadFile.Size = new System.Drawing.Size(125, 35);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "加载文件";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            this.btnLoadFile.MouseEnter += new System.EventHandler(this.btnLoadFile_MouseEnter);
            this.btnLoadFile.MouseLeave += new System.EventHandler(this.btnLoadFile_MouseLeave);
            // 
            // btnSetOp
            // 
            this.btnSetOp.BackColor = System.Drawing.Color.Transparent;
            this.btnSetOp.DownImage = global::CDPlayer.Properties.Resources.Hover;
            this.btnSetOp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetOp.Image = null;
            this.btnSetOp.IsShowBorder = false;
            this.btnSetOp.Location = new System.Drawing.Point(3, 409);
            this.btnSetOp.MoveImage = global::CDPlayer.Properties.Resources.Hover;
            this.btnSetOp.Name = "btnSetOp";
            this.btnSetOp.NormalImage = global::CDPlayer.Properties.Resources.Normal;
            this.btnSetOp.Size = new System.Drawing.Size(140, 35);
            this.btnSetOp.TabIndex = 0;
            this.btnSetOp.Text = "轻度透明";
            this.btnSetOp.UseVisualStyleBackColor = false;
            this.btnSetOp.Click += new System.EventHandler(this.btnSetOp_Click);
            this.btnSetOp.MouseEnter += new System.EventHandler(this.btnSetOp_MouseEnter);
            this.btnSetOp.MouseLeave += new System.EventHandler(this.btnSetOp_MouseLeave);
            // 
            // ShowTimer
            // 
            this.ShowTimer.Interval = 10;
            this.ShowTimer.Tick += new System.EventHandler(this.ShowTimer_Tick);
            // 
            // HideTimer
            // 
            this.HideTimer.Interval = 10;
            this.HideTimer.Tick += new System.EventHandler(this.HideTimer_Tick);
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.Transparent;
            this.Slider.BackRectangle = new System.Drawing.Rectangle(0, 0, 10, 10);
            this.Slider.Bar = null;
            this.Slider.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Saturation;
            this.Slider.BaseColor = System.Drawing.Color.White;
            this.Slider.Location = new System.Drawing.Point(73, 481);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(280, 45);
            this.Slider.TabIndex = 4;
            this.Slider.Track = null;
            this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // Pos
            // 
            this.Pos.Tick += new System.EventHandler(this.Pos_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTime.Location = new System.Drawing.Point(267, 481);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 12);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "00:00";
            // 
            // labelLeftTime
            // 
            this.labelLeftTime.AutoSize = true;
            this.labelLeftTime.BackColor = System.Drawing.Color.Transparent;
            this.labelLeftTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLeftTime.Location = new System.Drawing.Point(331, 481);
            this.labelLeftTime.Name = "labelLeftTime";
            this.labelLeftTime.Size = new System.Drawing.Size(35, 12);
            this.labelLeftTime.TabIndex = 6;
            this.labelLeftTime.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(314, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "\\";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CDPlayer.Properties.Resources.CDPlayerView;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLeftTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.PanelControlPanel);
            this.Controls.Add(this.btnControlPanel);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.DM_BackLayout = false;
            this.DM_BackShade = false;
            this.DM_howBorder = false;
            this.DM_ShowDrawIcon = false;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.PanelControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.Controls.DMButtonCloseLight btnClose;
        private DMSkin.Controls.DMButtonMinLight btnMin;
        private CCWin.SkinControl.SkinButton btnControlPanel;
        private CCWin.SkinControl.SkinPanel PanelControlPanel;
        private System.Windows.Forms.Timer ShowTimer;
        private System.Windows.Forms.Timer HideTimer;
        private DMSkin.MetroDMButton btnSetOp;
        private DMSkin.MetroDMButton btnLoadFile;
        private DMSkin.MetroDMButton btnPlay;
        private DMSkin.MetroDMButton btnPause;
        private DMSkin.MetroDMButton btnStop;
        private DMSkin.Metro.Controls.MetroTrackBar Volume;
        private CCWin.SkinControl.SkinTrackBar Slider;
        private System.Windows.Forms.Timer Pos;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelLeftTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

