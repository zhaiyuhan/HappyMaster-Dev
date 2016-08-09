namespace HappyMaster_Dev.View
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.btnClose = new DMSkin.MetroDMButton();
            this.btnMin = new DMSkin.MetroDMButton();
            this.btnMax = new DMSkin.MetroDMButton();
            this.btnLoadFile = new DMSkin.MetroDMButton();
            this.panelSetting = new CCWin.SkinControl.SkinPanel();
            this.btnAbout = new DMSkin.MetroDMButton();
            this.btnShowLiveImage = new DMSkin.MetroDMButton();
            this.bottomPanel = new CCWin.SkinControl.SkinPanel();
            this.playControl = new CCWin.SkinControl.SkinPictureBox();
            this.Volume = new DMSkin.Controls.DMProgressBar();
            this.labelLeftTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.Slider = new DMSkin.Metro.Controls.MetroTrackBar();
            this.btnSetting = new DMSkin.MetroDMButton();
            this.AlbumViewer = new CCWin.SkinControl.SkinPictureBox();
            this.MusicTitle = new CCWin.SkinControl.SkinLabel();
            this.ArtistName = new CCWin.SkinControl.SkinLabel();
            this.LoadMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.panelSetting.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DownImage = global::HappyMaster_Dev.Properties.Resources.buttonClosePRESS;
            this.btnClose.Image = null;
            this.btnClose.IsShowBorder = false;
            this.btnClose.Location = new System.Drawing.Point(7, 12);
            this.btnClose.MoveImage = global::HappyMaster_Dev.Properties.Resources.buttonCloseENTER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalImage = global::HappyMaster_Dev.Properties.Resources.buttonCloseNORMAL;
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.DownImage = global::HappyMaster_Dev.Properties.Resources.buttonMinPRESS;
            this.btnMin.Image = null;
            this.btnMin.IsShowBorder = false;
            this.btnMin.Location = new System.Drawing.Point(33, 12);
            this.btnMin.MoveImage = global::HappyMaster_Dev.Properties.Resources.buttonMinENTER;
            this.btnMin.Name = "btnMin";
            this.btnMin.NormalImage = global::HappyMaster_Dev.Properties.Resources.buttonMinNOMAL;
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.DownImage = global::HappyMaster_Dev.Properties.Resources.buttonMax;
            this.btnMax.Image = null;
            this.btnMax.IsShowBorder = false;
            this.btnMax.Location = new System.Drawing.Point(59, 12);
            this.btnMax.MoveImage = global::HappyMaster_Dev.Properties.Resources.buttonMax;
            this.btnMax.Name = "btnMax";
            this.btnMax.NormalImage = global::HappyMaster_Dev.Properties.Resources.buttonMax;
            this.btnMax.Size = new System.Drawing.Size(20, 20);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadFile.DownImage = ((System.Drawing.Image)(resources.GetObject("btnLoadFile.DownImage")));
            this.btnLoadFile.Font = new System.Drawing.Font(".萍方-简", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadFile.Image = null;
            this.btnLoadFile.IsShowBorder = false;
            this.btnLoadFile.Location = new System.Drawing.Point(17, 27);
            this.btnLoadFile.MoveImage = global::HappyMaster_Dev.Properties.Resources.MineButtonENTER;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.NormalImage = global::HappyMaster_Dev.Properties.Resources.MineButtonNOMRMAL;
            this.btnLoadFile.Size = new System.Drawing.Size(220, 27);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.Text = "打开文件";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            this.btnLoadFile.MouseEnter += new System.EventHandler(this.btnLoadFile_MouseEnter);
            this.btnLoadFile.MouseLeave += new System.EventHandler(this.btnLoadFile_MouseLeave);
            // 
            // panelSetting
            // 
            this.panelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSetting.BackColor = System.Drawing.Color.Transparent;
            this.panelSetting.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.MenuBG;
            this.panelSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSetting.Controls.Add(this.btnAbout);
            this.panelSetting.Controls.Add(this.btnShowLiveImage);
            this.panelSetting.Controls.Add(this.btnLoadFile);
            this.panelSetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panelSetting.DownBack = null;
            this.panelSetting.ForeColor = System.Drawing.Color.Black;
            this.panelSetting.Location = new System.Drawing.Point(8, 250);
            this.panelSetting.MouseBack = null;
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.NormlBack = null;
            this.panelSetting.Size = new System.Drawing.Size(252, 202);
            this.panelSetting.TabIndex = 8;
            this.panelSetting.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.DownImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.DownImage")));
            this.btnAbout.Font = new System.Drawing.Font(".萍方-简", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.Image = null;
            this.btnAbout.IsShowBorder = false;
            this.btnAbout.Location = new System.Drawing.Point(17, 139);
            this.btnAbout.MoveImage = global::HappyMaster_Dev.Properties.Resources.MineButtonENTER;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.NormalImage = global::HappyMaster_Dev.Properties.Resources.MineButtonNOMRMAL;
            this.btnAbout.Size = new System.Drawing.Size(220, 27);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "关于本程序";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // btnShowLiveImage
            // 
            this.btnShowLiveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnShowLiveImage.DownImage = ((System.Drawing.Image)(resources.GetObject("btnShowLiveImage.DownImage")));
            this.btnShowLiveImage.Font = new System.Drawing.Font(".萍方-简", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowLiveImage.Image = null;
            this.btnShowLiveImage.IsShowBorder = false;
            this.btnShowLiveImage.Location = new System.Drawing.Point(17, 60);
            this.btnShowLiveImage.MoveImage = global::HappyMaster_Dev.Properties.Resources.MineButtonENTER;
            this.btnShowLiveImage.Name = "btnShowLiveImage";
            this.btnShowLiveImage.NormalImage = global::HappyMaster_Dev.Properties.Resources.MineButtonNOMRMAL;
            this.btnShowLiveImage.Size = new System.Drawing.Size(220, 27);
            this.btnShowLiveImage.TabIndex = 6;
            this.btnShowLiveImage.Text = "显示图形";
            this.btnShowLiveImage.UseVisualStyleBackColor = false;
            this.btnShowLiveImage.MouseEnter += new System.EventHandler(this.btnShowLiveImage_MouseEnter);
            this.btnShowLiveImage.MouseLeave += new System.EventHandler(this.btnShowLiveImage_MouseLeave);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.glassBgGry;
            this.bottomPanel.Controls.Add(this.playControl);
            this.bottomPanel.Controls.Add(this.Volume);
            this.bottomPanel.Controls.Add(this.labelLeftTime);
            this.bottomPanel.Controls.Add(this.labelTime);
            this.bottomPanel.Controls.Add(this.Slider);
            this.bottomPanel.Controls.Add(this.btnSetting);
            this.bottomPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.DownBack = null;
            this.bottomPanel.Location = new System.Drawing.Point(4, 455);
            this.bottomPanel.MouseBack = null;
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.NormlBack = null;
            this.bottomPanel.Size = new System.Drawing.Size(923, 82);
            this.bottomPanel.TabIndex = 9;
            // 
            // playControl
            // 
            this.playControl.BackColor = System.Drawing.Color.Transparent;
            this.playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
            this.playControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playControl.Location = new System.Drawing.Point(455, 18);
            this.playControl.MaximumSize = new System.Drawing.Size(30, 30);
            this.playControl.Name = "playControl";
            this.playControl.Size = new System.Drawing.Size(30, 30);
            this.playControl.TabIndex = 5;
            this.playControl.TabStop = false;
            this.playControl.Click += new System.EventHandler(this.playControl_Click);
            this.playControl.MouseEnter += new System.EventHandler(this.playControl_MouseEnter);
            this.playControl.MouseLeave += new System.EventHandler(this.playControl_MouseLeave);
            // 
            // Volume
            // 
            this.Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.DM_BackColor = System.Drawing.Color.White;
            this.Volume.DM_BlockColor = System.Drawing.Color.DarkGray;
            this.Volume.DM_BufferColor = System.Drawing.Color.Silver;
            this.Volume.DM_BufferValue = 0D;
            this.Volume.DM_DrawRound = true;
            this.Volume.Dm_OperationModel = DMSkin.Controls.DMProgressBar.OperationModel.Slide;
            this.Volume.DM_RoundColor = System.Drawing.Color.Silver;
            this.Volume.DM_RoundSize = 15;
            this.Volume.DM_RoundX = 1;
            this.Volume.DM_RoundY = 5;
            this.Volume.DM_Value = 100D;
            this.Volume.Location = new System.Drawing.Point(802, 13);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(118, 24);
            this.Volume.TabIndex = 4;
            // 
            // labelLeftTime
            // 
            this.labelLeftTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeftTime.AutoSize = true;
            this.labelLeftTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLeftTime.Location = new System.Drawing.Point(859, 62);
            this.labelLeftTime.Name = "labelLeftTime";
            this.labelLeftTime.Size = new System.Drawing.Size(35, 12);
            this.labelLeftTime.TabIndex = 3;
            this.labelLeftTime.Text = "00:00";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTime.Location = new System.Drawing.Point(44, 62);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 12);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00";
            // 
            // Slider
            // 
            this.Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Slider.BackColor = System.Drawing.Color.Transparent;
            this.Slider.DM_UseCustomBackColor = true;
            this.Slider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Slider.Location = new System.Drawing.Point(85, 56);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(762, 23);
            this.Slider.TabIndex = 1;
            this.Slider.Text = "metroTrackBar1";
            this.Slider.Value = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.DownImage = global::HappyMaster_Dev.Properties.Resources.settings;
            this.btnSetting.Image = null;
            this.btnSetting.IsShowBorder = false;
            this.btnSetting.Location = new System.Drawing.Point(4, 3);
            this.btnSetting.MoveImage = global::HappyMaster_Dev.Properties.Resources.settings1;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.NormalImage = global::HappyMaster_Dev.Properties.Resources.settingsNormal;
            this.btnSetting.Size = new System.Drawing.Size(45, 45);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // AlbumViewer
            // 
            this.AlbumViewer.BackColor = System.Drawing.Color.Transparent;
            this.AlbumViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumViewer.Location = new System.Drawing.Point(367, 50);
            this.AlbumViewer.Name = "AlbumViewer";
            this.AlbumViewer.Size = new System.Drawing.Size(200, 200);
            this.AlbumViewer.TabIndex = 10;
            this.AlbumViewer.TabStop = false;
            // 
            // MusicTitle
            // 
            this.MusicTitle.AutoSize = true;
            this.MusicTitle.BackColor = System.Drawing.Color.Transparent;
            this.MusicTitle.BorderColor = System.Drawing.Color.Transparent;
            this.MusicTitle.Font = new System.Drawing.Font(".萍方-简", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.MusicTitle.Location = new System.Drawing.Point(382, 294);
            this.MusicTitle.Name = "MusicTitle";
            this.MusicTitle.Size = new System.Drawing.Size(171, 45);
            this.MusicTitle.TabIndex = 11;
            this.MusicTitle.Text = "MusicTitle";
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.BackColor = System.Drawing.Color.Transparent;
            this.ArtistName.BorderColor = System.Drawing.Color.Transparent;
            this.ArtistName.Font = new System.Drawing.Font(".萍方-简", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ArtistName.ForeColor = System.Drawing.SystemColors.Control;
            this.ArtistName.Location = new System.Drawing.Point(382, 336);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(185, 45);
            this.ArtistName.TabIndex = 12;
            this.ArtistName.Text = "ArtistName";
            // 
            // LoadMediaFile
            // 
            this.LoadMediaFile.Title = "HappyMaster-打开音频文件";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 541);
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.MusicTitle);
            this.Controls.Add(this.AlbumViewer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.DM_howBorder = false;
            this.DM_Radius = 1;
            this.DM_ShowDrawIcon = false;
            this.Name = "MainView";
            this.RoundStyle = DMSkin.SkinClass.RoundStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Resize += new System.EventHandler(this.MainView_Resize);
            this.panelSetting.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.MetroDMButton btnClose;
        private DMSkin.MetroDMButton btnMin;
        private DMSkin.MetroDMButton btnMax;
        private DMSkin.MetroDMButton btnLoadFile;
        private CCWin.SkinControl.SkinPanel panelSetting;
        private DMSkin.MetroDMButton btnAbout;
        private DMSkin.MetroDMButton btnShowLiveImage;
        private CCWin.SkinControl.SkinPanel bottomPanel;
        private DMSkin.MetroDMButton btnSetting;
        private DMSkin.Metro.Controls.MetroTrackBar Slider;
        private System.Windows.Forms.Label labelLeftTime;
        private System.Windows.Forms.Label labelTime;
        private DMSkin.Controls.DMProgressBar Volume;
        private CCWin.SkinControl.SkinPictureBox AlbumViewer;
        private CCWin.SkinControl.SkinPictureBox playControl;
        private CCWin.SkinControl.SkinLabel MusicTitle;
        private CCWin.SkinControl.SkinLabel ArtistName;
        public System.Windows.Forms.OpenFileDialog LoadMediaFile;
    }
}