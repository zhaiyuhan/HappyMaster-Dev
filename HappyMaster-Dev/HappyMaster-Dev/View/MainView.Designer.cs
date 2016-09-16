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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.btnClose = new DMSkin.MetroDMButton();
            this.btnMin = new DMSkin.MetroDMButton();
            this.btnMax = new DMSkin.MetroDMButton();
            this.btnLoadFile = new DMSkin.MetroDMButton();
            this.panelSetting = new CCWin.SkinControl.SkinPanel();
            this.btnCDPlayer = new DMSkin.MetroDMButton();
            this.LineforPanelSetting = new CCWin.SkinControl.SkinLine();
            this.btnMore = new CCWin.SkinControl.SkinPictureBox();
            this.btnAbout = new DMSkin.MetroDMButton();
            this.btnShowLiveImage = new DMSkin.MetroDMButton();
            this.LeftView = new CCWin.SkinControl.SkinPictureBox();
            this.bottomPanel = new CCWin.SkinControl.SkinPanel();
            this.playControl = new CCWin.SkinControl.SkinPictureBox();
            this.VolumeMaster = new DMSkin.Controls.DMProgressBar();
            this.labelLeftTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.Pos = new DMSkin.Metro.Controls.MetroTrackBar();
            this.btnSetting = new DMSkin.MetroDMButton();
            this.AlbumViewer = new CCWin.SkinControl.SkinPictureBox();
            this.MusicTitle = new CCWin.SkinControl.SkinLabel();
            this.ArtistName = new CCWin.SkinControl.SkinLabel();
            this.LoadMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.Position = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSpectrum = new CCWin.SkinControl.SkinPictureBox();
            this.RightView = new CCWin.SkinControl.SkinPictureBox();
            this.btnHidePicturebBox = new DMSkin.MetroDMButton();
            this.panelMore = new System.Windows.Forms.Panel();
            this.btnChangeTextColor = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.btnDIY = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHelpShow = new DMSkin.MetroDMButton();
            this.btnDone = new DMSkin.Metro.Controls.MetroButton();
            this.btnChangeBG = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkExpandEdge = new DMSkin.Controls.DMCheckBox();
            this.BarRadius = new CCWin.SkinControl.SkinTrackBar();
            this.labelbtnGlassAblumView = new CCWin.SkinControl.SkinLabel();
            this.btnGlassAblumView = new DMSkin.MetroDMButton();
            this.labelDoneTimer = new System.Windows.Forms.Timer(this.components);
            this.panelHelp = new CCWin.SkinControl.SkinPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseHelpView = new CCWin.SkinControl.SkinPictureBox();
            this.btnHelpView = new CCWin.SkinControl.SkinPictureBox();
            this.btnEnrecoder = new CCWin.SkinControl.SkinPictureBox();
            this.btnShowDSP = new CCWin.SkinControl.SkinPictureBox();
            this.FreeMemory = new System.Windows.Forms.Timer(this.components);
            this.PlayThread = new System.ComponentModel.BackgroundWorker();
            this.panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftView)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightView)).BeginInit();
            this.panelMore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarRadius)).BeginInit();
            this.panelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseHelpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnrecoder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDSP)).BeginInit();
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
            this.btnClose.TabStop = false;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
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
            this.btnMin.TabStop = false;
            this.btnMin.Text = "";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
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
            this.btnMax.TabStop = false;
            this.btnMax.Text = "";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            this.btnMax.MouseHover += new System.EventHandler(this.btnMax_MouseHover);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadFile.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuLoadFileBlue;
            this.btnLoadFile.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadFile.Image = null;
            this.btnLoadFile.IsShowBorder = false;
            this.btnLoadFile.Location = new System.Drawing.Point(7, 15);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadFile.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuLoadFileBlue;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuLoadFileWhite;
            this.btnLoadFile.Size = new System.Drawing.Size(238, 28);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.TabStop = false;
            this.btnLoadFile.Text = "";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            this.btnLoadFile.MouseEnter += new System.EventHandler(this.btnLoadFile_MouseEnter);
            // 
            // panelSetting
            // 
            this.panelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSetting.BackColor = System.Drawing.Color.Transparent;
            this.panelSetting.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.MenuBG;
            this.panelSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSetting.Controls.Add(this.btnCDPlayer);
            this.panelSetting.Controls.Add(this.LineforPanelSetting);
            this.panelSetting.Controls.Add(this.btnMore);
            this.panelSetting.Controls.Add(this.btnAbout);
            this.panelSetting.Controls.Add(this.btnShowLiveImage);
            this.panelSetting.Controls.Add(this.btnLoadFile);
            this.panelSetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panelSetting.DownBack = null;
            this.panelSetting.ForeColor = System.Drawing.Color.Black;
            this.panelSetting.Location = new System.Drawing.Point(0, 256);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(0);
            this.panelSetting.MouseBack = null;
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.NormlBack = null;
            this.panelSetting.Size = new System.Drawing.Size(252, 200);
            this.panelSetting.TabIndex = 8;
            this.panelSetting.Visible = false;
            // 
            // btnCDPlayer
            // 
            this.btnCDPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnCDPlayer.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuCDPlayerWhite;
            this.btnCDPlayer.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCDPlayer.Image = null;
            this.btnCDPlayer.IsShowBorder = false;
            this.btnCDPlayer.Location = new System.Drawing.Point(7, 71);
            this.btnCDPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCDPlayer.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuCDPlayerWhite;
            this.btnCDPlayer.Name = "btnCDPlayer";
            this.btnCDPlayer.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuCDPlayer;
            this.btnCDPlayer.Size = new System.Drawing.Size(238, 28);
            this.btnCDPlayer.TabIndex = 10;
            this.btnCDPlayer.TabStop = false;
            this.btnCDPlayer.Text = "";
            this.btnCDPlayer.UseVisualStyleBackColor = false;
            this.btnCDPlayer.Click += new System.EventHandler(this.btnCDPlayer_Click);
            this.btnCDPlayer.MouseEnter += new System.EventHandler(this.btnCDPlayer_MouseEnter);
            // 
            // LineforPanelSetting
            // 
            this.LineforPanelSetting.BackColor = System.Drawing.Color.Transparent;
            this.LineforPanelSetting.LineColor = System.Drawing.Color.Gray;
            this.LineforPanelSetting.LineHeight = 1;
            this.LineforPanelSetting.Location = new System.Drawing.Point(9, 132);
            this.LineforPanelSetting.Name = "LineforPanelSetting";
            this.LineforPanelSetting.Size = new System.Drawing.Size(233, 10);
            this.LineforPanelSetting.TabIndex = 9;
            this.LineforPanelSetting.Text = "skinLine1";
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.MenuNormal;
            this.btnMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMore.Location = new System.Drawing.Point(9, 105);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(234, 23);
            this.btnMore.TabIndex = 8;
            this.btnMore.TabStop = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            this.btnMore.MouseEnter += new System.EventHandler(this.btnMore_MouseEnter);
            this.btnMore.MouseLeave += new System.EventHandler(this.btnMore_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuAboutAppBlue;
            this.btnAbout.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.Image = null;
            this.btnAbout.IsShowBorder = false;
            this.btnAbout.Location = new System.Drawing.Point(7, 139);
            this.btnAbout.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuAboutAppBlue;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuAboutAppWhite;
            this.btnAbout.Size = new System.Drawing.Size(238, 28);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter_1);
            // 
            // btnShowLiveImage
            // 
            this.btnShowLiveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnShowLiveImage.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuLivePic;
            this.btnShowLiveImage.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowLiveImage.Image = null;
            this.btnShowLiveImage.IsShowBorder = false;
            this.btnShowLiveImage.Location = new System.Drawing.Point(7, 43);
            this.btnShowLiveImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowLiveImage.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuLivePic;
            this.btnShowLiveImage.Name = "btnShowLiveImage";
            this.btnShowLiveImage.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuLivePicWhite;
            this.btnShowLiveImage.Size = new System.Drawing.Size(238, 28);
            this.btnShowLiveImage.TabIndex = 6;
            this.btnShowLiveImage.TabStop = false;
            this.btnShowLiveImage.Text = "";
            this.btnShowLiveImage.UseVisualStyleBackColor = false;
            this.btnShowLiveImage.Click += new System.EventHandler(this.btnShowLiveImage_Click);
            this.btnShowLiveImage.MouseEnter += new System.EventHandler(this.btnShowLiveImage_MouseEnter);
            // 
            // LeftView
            // 
            this.LeftView.BackColor = System.Drawing.Color.Transparent;
            this.LeftView.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.LeftWhite;
            this.LeftView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LeftView.Location = new System.Drawing.Point(7, 250);
            this.LeftView.Name = "LeftView";
            this.LeftView.Size = new System.Drawing.Size(50, 50);
            this.LeftView.TabIndex = 15;
            this.LeftView.TabStop = false;
            this.LeftView.Visible = false;
            this.LeftView.Click += new System.EventHandler(this.Left_Click);
            this.LeftView.MouseEnter += new System.EventHandler(this.LeftView_MouseEnter);
            this.LeftView.MouseLeave += new System.EventHandler(this.LeftView_MouseLeave);
            this.LeftView.MouseHover += new System.EventHandler(this.LeftView_MouseHover);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.glassBG2;
            this.bottomPanel.Controls.Add(this.playControl);
            this.bottomPanel.Controls.Add(this.VolumeMaster);
            this.bottomPanel.Controls.Add(this.labelLeftTime);
            this.bottomPanel.Controls.Add(this.labelTime);
            this.bottomPanel.Controls.Add(this.Pos);
            this.bottomPanel.Controls.Add(this.btnSetting);
            this.bottomPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bottomPanel.DownBack = null;
            this.bottomPanel.Location = new System.Drawing.Point(0, 459);
            this.bottomPanel.MouseBack = null;
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.NormlBack = null;
            this.bottomPanel.Size = new System.Drawing.Size(931, 85);
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
            this.playControl.MouseHover += new System.EventHandler(this.playControl_MouseHover);
            // 
            // VolumeMaster
            // 
            this.VolumeMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeMaster.BackColor = System.Drawing.Color.Transparent;
            this.VolumeMaster.DM_BackColor = System.Drawing.Color.White;
            this.VolumeMaster.DM_BlockColor = System.Drawing.Color.DimGray;
            this.VolumeMaster.DM_BufferColor = System.Drawing.Color.Silver;
            this.VolumeMaster.DM_BufferValue = 0D;
            this.VolumeMaster.DM_DrawRound = true;
            this.VolumeMaster.Dm_OperationModel = DMSkin.Controls.DMProgressBar.OperationModel.Slide;
            this.VolumeMaster.DM_RoundColor = System.Drawing.Color.Silver;
            this.VolumeMaster.DM_RoundSize = 15;
            this.VolumeMaster.DM_RoundX = 1;
            this.VolumeMaster.DM_RoundY = 5;
            this.VolumeMaster.DM_Value = 100D;
            this.VolumeMaster.Location = new System.Drawing.Point(810, 16);
            this.VolumeMaster.Name = "VolumeMaster";
            this.VolumeMaster.Size = new System.Drawing.Size(118, 24);
            this.VolumeMaster.TabIndex = 4;
            this.VolumeMaster.TabStop = false;
            this.VolumeMaster.Click += new System.EventHandler(this.VolumeMaster_Click);
            this.VolumeMaster.MouseHover += new System.EventHandler(this.VolumeMaster_MouseHover);
            // 
            // labelLeftTime
            // 
            this.labelLeftTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeftTime.AutoSize = true;
            this.labelLeftTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLeftTime.Location = new System.Drawing.Point(867, 65);
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
            this.labelTime.Location = new System.Drawing.Point(44, 65);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 12);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00";
            // 
            // Pos
            // 
            this.Pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pos.BackColor = System.Drawing.Color.Transparent;
            this.Pos.DM_UseCustomBackColor = true;
            this.Pos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pos.Location = new System.Drawing.Point(85, 59);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(770, 23);
            this.Pos.TabIndex = 1;
            this.Pos.TabStop = false;
            this.Pos.Text = "metroTrackBar1";
            this.Pos.Value = 0;
            this.Pos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pos_Scroll);
            this.Pos.MouseHover += new System.EventHandler(this.Pos_MouseHover);
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
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // AlbumViewer
            // 
            this.AlbumViewer.BackColor = System.Drawing.Color.Transparent;
            this.AlbumViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumViewer.Location = new System.Drawing.Point(343, 38);
            this.AlbumViewer.Name = "AlbumViewer";
            this.AlbumViewer.Size = new System.Drawing.Size(200, 200);
            this.AlbumViewer.TabIndex = 10;
            this.AlbumViewer.TabStop = false;
            this.AlbumViewer.Visible = false;
            this.AlbumViewer.Click += new System.EventHandler(this.AlbumViewer_Click);
            this.AlbumViewer.MouseHover += new System.EventHandler(this.AlbumViewer_MouseHover);
            // 
            // MusicTitle
            // 
            this.MusicTitle.AutoSize = true;
            this.MusicTitle.BackColor = System.Drawing.Color.Transparent;
            this.MusicTitle.BorderColor = System.Drawing.Color.Transparent;
            this.MusicTitle.Font = new System.Drawing.Font(".PingFang SC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicTitle.ForeColor = System.Drawing.Color.White;
            this.MusicTitle.Location = new System.Drawing.Point(382, 294);
            this.MusicTitle.Name = "MusicTitle";
            this.MusicTitle.Size = new System.Drawing.Size(175, 33);
            this.MusicTitle.TabIndex = 11;
            this.MusicTitle.Text = "MusicTitle";
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.BackColor = System.Drawing.Color.Transparent;
            this.ArtistName.BorderColor = System.Drawing.Color.Transparent;
            this.ArtistName.Font = new System.Drawing.Font(".PingFang SC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ArtistName.ForeColor = System.Drawing.Color.White;
            this.ArtistName.Location = new System.Drawing.Point(382, 336);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(120, 21);
            this.ArtistName.TabIndex = 12;
            this.ArtistName.Text = "ArtistName";
            // 
            // LoadMediaFile
            // 
            this.LoadMediaFile.Title = "HappyMaster-打开音频文件";
            // 
            // Position
            // 
            this.Position.Tick += new System.EventHandler(this.Position_Tick);
            // 
            // pictureBoxSpectrum
            // 
            this.pictureBoxSpectrum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSpectrum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSpectrum.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.glassBg;
            this.pictureBoxSpectrum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSpectrum.Location = new System.Drawing.Point(7, 38);
            this.pictureBoxSpectrum.Name = "pictureBoxSpectrum";
            this.pictureBoxSpectrum.Size = new System.Drawing.Size(900, 206);
            this.pictureBoxSpectrum.TabIndex = 13;
            this.pictureBoxSpectrum.TabStop = false;
            this.pictureBoxSpectrum.Visible = false;
            this.pictureBoxSpectrum.Click += new System.EventHandler(this.pictureBoxSpectrum_Click);
            this.pictureBoxSpectrum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSpectrum_MouseClick);
            this.pictureBoxSpectrum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSpectrum_MouseDown);
            // 
            // RightView
            // 
            this.RightView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightView.BackColor = System.Drawing.Color.Transparent;
            this.RightView.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.RightWhite;
            this.RightView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RightView.Location = new System.Drawing.Point(857, 250);
            this.RightView.Name = "RightView";
            this.RightView.Size = new System.Drawing.Size(50, 50);
            this.RightView.TabIndex = 14;
            this.RightView.TabStop = false;
            this.RightView.Visible = false;
            this.RightView.Click += new System.EventHandler(this.Right_Click);
            this.RightView.MouseEnter += new System.EventHandler(this.RightView_MouseEnter);
            this.RightView.MouseLeave += new System.EventHandler(this.RightView_MouseLeave);
            this.RightView.MouseHover += new System.EventHandler(this.RightView_MouseHover);
            // 
            // btnHidePicturebBox
            // 
            this.btnHidePicturebBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHidePicturebBox.BackColor = System.Drawing.Color.Transparent;
            this.btnHidePicturebBox.DownImage = global::HappyMaster_Dev.Properties.Resources.down;
            this.btnHidePicturebBox.Image = null;
            this.btnHidePicturebBox.IsShowBorder = false;
            this.btnHidePicturebBox.Location = new System.Drawing.Point(882, 38);
            this.btnHidePicturebBox.MoveImage = global::HappyMaster_Dev.Properties.Resources.down;
            this.btnHidePicturebBox.Name = "btnHidePicturebBox";
            this.btnHidePicturebBox.NormalImage = global::HappyMaster_Dev.Properties.Resources.downWhite;
            this.btnHidePicturebBox.Size = new System.Drawing.Size(25, 25);
            this.btnHidePicturebBox.TabIndex = 16;
            this.btnHidePicturebBox.TabStop = false;
            this.btnHidePicturebBox.Text = "";
            this.btnHidePicturebBox.UseVisualStyleBackColor = false;
            this.btnHidePicturebBox.Visible = false;
            this.btnHidePicturebBox.Click += new System.EventHandler(this.btnHidePicturebBox_Click);
            this.btnHidePicturebBox.MouseHover += new System.EventHandler(this.btnHidePicturebBox_MouseHover);
            // 
            // panelMore
            // 
            this.panelMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMore.BackColor = System.Drawing.Color.Transparent;
            this.panelMore.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.SecondMenuBG;
            this.panelMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMore.Controls.Add(this.btnChangeTextColor);
            this.panelMore.Controls.Add(this.labelVolumeValue);
            this.panelMore.Controls.Add(this.btnDIY);
            this.panelMore.Controls.Add(this.btnHelpShow);
            this.panelMore.Controls.Add(this.btnDone);
            this.panelMore.Controls.Add(this.btnChangeBG);
            this.panelMore.Controls.Add(this.label1);
            this.panelMore.Controls.Add(this.ChkExpandEdge);
            this.panelMore.Controls.Add(this.BarRadius);
            this.panelMore.Controls.Add(this.labelbtnGlassAblumView);
            this.panelMore.Controls.Add(this.btnGlassAblumView);
            this.panelMore.Location = new System.Drawing.Point(255, 250);
            this.panelMore.Name = "panelMore";
            this.panelMore.Size = new System.Drawing.Size(232, 203);
            this.panelMore.TabIndex = 17;
            this.panelMore.Visible = false;
            // 
            // btnChangeTextColor
            // 
            this.btnChangeTextColor.AutoSize = true;
            this.btnChangeTextColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeTextColor.BackColor = System.Drawing.Color.White;
            this.btnChangeTextColor.Depth = 0;
            this.btnChangeTextColor.ForeColor = System.Drawing.Color.Black;
            this.btnChangeTextColor.Location = new System.Drawing.Point(150, 102);
            this.btnChangeTextColor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeTextColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeTextColor.Name = "btnChangeTextColor";
            this.btnChangeTextColor.Primary = false;
            this.btnChangeTextColor.Size = new System.Drawing.Size(61, 36);
            this.btnChangeTextColor.TabIndex = 11;
            this.btnChangeTextColor.TabStop = false;
            this.btnChangeTextColor.Text = "字体颜色";
            this.btnChangeTextColor.UseVisualStyleBackColor = false;
            this.btnChangeTextColor.Click += new System.EventHandler(this.btnChangeTextColor_Click);
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.AutoSize = true;
            this.labelVolumeValue.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVolumeValue.ForeColor = System.Drawing.Color.Black;
            this.labelVolumeValue.Location = new System.Drawing.Point(10, 165);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(56, 17);
            this.labelVolumeValue.TabIndex = 10;
            this.labelVolumeValue.Text = "当前音量";
            // 
            // btnDIY
            // 
            this.btnDIY.AutoSize = true;
            this.btnDIY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDIY.BackColor = System.Drawing.Color.White;
            this.btnDIY.Depth = 0;
            this.btnDIY.ForeColor = System.Drawing.Color.Black;
            this.btnDIY.Location = new System.Drawing.Point(83, 102);
            this.btnDIY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDIY.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDIY.Name = "btnDIY";
            this.btnDIY.Primary = false;
            this.btnDIY.Size = new System.Drawing.Size(61, 36);
            this.btnDIY.TabIndex = 9;
            this.btnDIY.TabStop = false;
            this.btnDIY.Text = "应用设置";
            this.btnDIY.UseVisualStyleBackColor = false;
            this.btnDIY.Click += new System.EventHandler(this.btnDIY_Click);
            // 
            // btnHelpShow
            // 
            this.btnHelpShow.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpShow.DownImage = ((System.Drawing.Image)(resources.GetObject("btnHelpShow.DownImage")));
            this.btnHelpShow.Font = new System.Drawing.Font(".System San Francisco Display", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpShow.ForeColor = System.Drawing.Color.Black;
            this.btnHelpShow.Image = null;
            this.btnHelpShow.IsShowBorder = false;
            this.btnHelpShow.Location = new System.Drawing.Point(162, 155);
            this.btnHelpShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpShow.MoveImage = global::HappyMaster_Dev.Properties.Resources.MineButtonENTER;
            this.btnHelpShow.Name = "btnHelpShow";
            this.btnHelpShow.NormalImage = global::HappyMaster_Dev.Properties.Resources.MineButtonNOMRMAL;
            this.btnHelpShow.Size = new System.Drawing.Size(61, 31);
            this.btnHelpShow.TabIndex = 8;
            this.btnHelpShow.TabStop = false;
            this.btnHelpShow.Text = "Help";
            this.btnHelpShow.UseVisualStyleBackColor = false;
            this.btnHelpShow.Click += new System.EventHandler(this.btnHelpShow_Click);
            this.btnHelpShow.MouseEnter += new System.EventHandler(this.btnHelpShow_MouseEnter);
            this.btnHelpShow.MouseLeave += new System.EventHandler(this.btnHelpShow_MouseLeave);
            // 
            // btnDone
            // 
            this.btnDone.DM_UseSelectable = true;
            this.btnDone.Enabled = false;
            this.btnDone.Location = new System.Drawing.Point(152, 70);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(65, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "应用更改";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnChangeBG
            // 
            this.btnChangeBG.AutoSize = true;
            this.btnChangeBG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeBG.BackColor = System.Drawing.Color.White;
            this.btnChangeBG.Depth = 0;
            this.btnChangeBG.ForeColor = System.Drawing.Color.Black;
            this.btnChangeBG.Location = new System.Drawing.Point(14, 102);
            this.btnChangeBG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeBG.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeBG.Name = "btnChangeBG";
            this.btnChangeBG.Primary = false;
            this.btnChangeBG.Size = new System.Drawing.Size(61, 36);
            this.btnChangeBG.TabIndex = 6;
            this.btnChangeBG.TabStop = false;
            this.btnChangeBG.Text = "窗体设置";
            this.btnChangeBG.UseVisualStyleBackColor = false;
            this.btnChangeBG.Click += new System.EventHandler(this.btnChangeBG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "扩展边际不啦 _(:3 」∠)_ ";
            // 
            // ChkExpandEdge
            // 
            this.ChkExpandEdge.BackColor = System.Drawing.Color.Transparent;
            this.ChkExpandEdge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChkExpandEdge.Checked = false;
            this.ChkExpandEdge.Location = new System.Drawing.Point(14, 74);
            this.ChkExpandEdge.Name = "ChkExpandEdge";
            this.ChkExpandEdge.Size = new System.Drawing.Size(15, 19);
            this.ChkExpandEdge.TabIndex = 3;
            this.ChkExpandEdge.Click += new System.EventHandler(this.ChkExpandEdge_Click);
            // 
            // BarRadius
            // 
            this.BarRadius.BackColor = System.Drawing.Color.Transparent;
            this.BarRadius.Bar = global::HappyMaster_Dev.Properties.Resources.slider;
            this.BarRadius.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Img;
            this.BarRadius.BaseColor = System.Drawing.Color.DarkGray;
            this.BarRadius.Enabled = false;
            this.BarRadius.Location = new System.Drawing.Point(14, 45);
            this.BarRadius.Maximum = 255;
            this.BarRadius.Name = "BarRadius";
            this.BarRadius.Size = new System.Drawing.Size(197, 45);
            this.BarRadius.TabIndex = 2;
            this.BarRadius.TabStop = false;
            this.BarRadius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarRadius.Track = global::HappyMaster_Dev.Properties.Resources.ScrollBarNOMARL;
            this.BarRadius.Value = 10;
            this.BarRadius.Scroll += new System.EventHandler(this.BarRadius_Scroll);
            this.BarRadius.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarRadius_MouseUp);
            // 
            // labelbtnGlassAblumView
            // 
            this.labelbtnGlassAblumView.AutoSize = true;
            this.labelbtnGlassAblumView.BackColor = System.Drawing.Color.Transparent;
            this.labelbtnGlassAblumView.BorderColor = System.Drawing.Color.Transparent;
            this.labelbtnGlassAblumView.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelbtnGlassAblumView.ForeColor = System.Drawing.Color.Black;
            this.labelbtnGlassAblumView.Location = new System.Drawing.Point(35, 16);
            this.labelbtnGlassAblumView.Name = "labelbtnGlassAblumView";
            this.labelbtnGlassAblumView.Size = new System.Drawing.Size(169, 17);
            this.labelbtnGlassAblumView.TabIndex = 1;
            this.labelbtnGlassAblumView.Text = "(・ˍ・*)是否高斯模糊专辑图片";
            this.labelbtnGlassAblumView.Click += new System.EventHandler(this.labelbtnGlassAblumView_Click);
            // 
            // btnGlassAblumView
            // 
            this.btnGlassAblumView.BackColor = System.Drawing.Color.Transparent;
            this.btnGlassAblumView.DownImage = global::HappyMaster_Dev.Properties.Resources.checkBoxChecked;
            this.btnGlassAblumView.Image = null;
            this.btnGlassAblumView.IsShowBorder = false;
            this.btnGlassAblumView.Location = new System.Drawing.Point(8, 16);
            this.btnGlassAblumView.MoveImage = global::HappyMaster_Dev.Properties.Resources.checkBoxHover;
            this.btnGlassAblumView.Name = "btnGlassAblumView";
            this.btnGlassAblumView.NormalImage = global::HappyMaster_Dev.Properties.Resources.checkBox;
            this.btnGlassAblumView.Size = new System.Drawing.Size(20, 20);
            this.btnGlassAblumView.TabIndex = 0;
            this.btnGlassAblumView.TabStop = false;
            this.btnGlassAblumView.Text = "";
            this.btnGlassAblumView.UseVisualStyleBackColor = false;
            this.btnGlassAblumView.Click += new System.EventHandler(this.btnGlassAblumView_Click);
            // 
            // labelDoneTimer
            // 
            this.labelDoneTimer.Interval = 500;
            this.labelDoneTimer.Tick += new System.EventHandler(this.labelDoneTimer_Tick);
            // 
            // panelHelp
            // 
            this.panelHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHelp.BackColor = System.Drawing.Color.Transparent;
            this.panelHelp.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.glassBG2;
            this.panelHelp.Controls.Add(this.label5);
            this.panelHelp.Controls.Add(this.label4);
            this.panelHelp.Controls.Add(this.label3);
            this.panelHelp.Controls.Add(this.label2);
            this.panelHelp.Controls.Add(this.btnCloseHelpView);
            this.panelHelp.Controls.Add(this.btnHelpView);
            this.panelHelp.Controls.Add(this.btnEnrecoder);
            this.panelHelp.Controls.Add(this.btnShowDSP);
            this.panelHelp.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panelHelp.DownBack = null;
            this.panelHelp.Location = new System.Drawing.Point(0, 144);
            this.panelHelp.MouseBack = null;
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.NormlBack = null;
            this.panelHelp.Palace = true;
            this.panelHelp.Radius = 20;
            this.panelHelp.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.panelHelp.Size = new System.Drawing.Size(931, 116);
            this.panelHelp.TabIndex = 20;
            this.panelHelp.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(542, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "关闭页面";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(458, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "帮助";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "格式转换";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "打开DSP";
            // 
            // btnCloseHelpView
            // 
            this.btnCloseHelpView.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseHelpView.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.logout;
            this.btnCloseHelpView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseHelpView.Location = new System.Drawing.Point(546, 27);
            this.btnCloseHelpView.Name = "btnCloseHelpView";
            this.btnCloseHelpView.Size = new System.Drawing.Size(50, 50);
            this.btnCloseHelpView.TabIndex = 3;
            this.btnCloseHelpView.TabStop = false;
            this.btnCloseHelpView.Click += new System.EventHandler(this.btnCloseHelpView_Click);
            this.btnCloseHelpView.MouseEnter += new System.EventHandler(this.btnCloseHelpView_MouseEnter);
            this.btnCloseHelpView.MouseLeave += new System.EventHandler(this.btnCloseHelpView_MouseLeave);
            // 
            // btnHelpView
            // 
            this.btnHelpView.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpView.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.help;
            this.btnHelpView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelpView.Location = new System.Drawing.Point(452, 27);
            this.btnHelpView.Name = "btnHelpView";
            this.btnHelpView.Size = new System.Drawing.Size(50, 50);
            this.btnHelpView.TabIndex = 2;
            this.btnHelpView.TabStop = false;
            this.btnHelpView.Click += new System.EventHandler(this.btnHelpView_Click);
            this.btnHelpView.MouseEnter += new System.EventHandler(this.btnHelpView_MouseEnter);
            this.btnHelpView.MouseLeave += new System.EventHandler(this.btnHelpView_MouseLeave);
            // 
            // btnEnrecoder
            // 
            this.btnEnrecoder.BackColor = System.Drawing.Color.Transparent;
            this.btnEnrecoder.BackgroundImage = global::HappyMaster_Dev.Properties.Resources._switch;
            this.btnEnrecoder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnrecoder.Location = new System.Drawing.Point(367, 27);
            this.btnEnrecoder.Name = "btnEnrecoder";
            this.btnEnrecoder.Size = new System.Drawing.Size(50, 50);
            this.btnEnrecoder.TabIndex = 1;
            this.btnEnrecoder.TabStop = false;
            this.btnEnrecoder.Click += new System.EventHandler(this.btnEnrecoder_Click);
            this.btnEnrecoder.MouseEnter += new System.EventHandler(this.btnEnrecoder_MouseEnter);
            this.btnEnrecoder.MouseLeave += new System.EventHandler(this.btnEnrecoder_MouseLeave);
            // 
            // btnShowDSP
            // 
            this.btnShowDSP.BackColor = System.Drawing.Color.Transparent;
            this.btnShowDSP.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.compass;
            this.btnShowDSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowDSP.Location = new System.Drawing.Point(277, 27);
            this.btnShowDSP.Name = "btnShowDSP";
            this.btnShowDSP.Size = new System.Drawing.Size(50, 50);
            this.btnShowDSP.TabIndex = 0;
            this.btnShowDSP.TabStop = false;
            this.btnShowDSP.Click += new System.EventHandler(this.btnShowDSP_Click);
            this.btnShowDSP.MouseEnter += new System.EventHandler(this.btnShowDSP_MouseEnter);
            this.btnShowDSP.MouseLeave += new System.EventHandler(this.btnShowDSP_MouseLeave);
            // 
            // FreeMemory
            // 
            this.FreeMemory.Enabled = true;
            this.FreeMemory.Tick += new System.EventHandler(this.FreeMemory_Tick);
            // 
            // PlayThread
            // 
            this.PlayThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PlayThread_DoWork);
            this.PlayThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PlayThread_RunWorkerCompleted);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Beta5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 541);
            this.Controls.Add(this.AlbumViewer);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.panelMore);
            this.Controls.Add(this.LeftView);
            this.Controls.Add(this.btnHidePicturebBox);
            this.Controls.Add(this.RightView);
            this.Controls.Add(this.pictureBoxSpectrum);
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.MusicTitle);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.DM_EffectBack = System.Drawing.Color.Transparent;
            this.DM_howBorder = false;
            this.DM_Radius = 1;
            this.DM_ShadowWidth = 6;
            this.DM_ShowDrawIcon = false;
            this.DM_SkinOpacity = 0.9D;
            this.DM_TitleColor = System.Drawing.Color.Transparent;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Click += new System.EventHandler(this.MainView_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainView_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainView_KeyUp);
            this.Resize += new System.EventHandler(this.MainView_Resize);
            this.panelSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftView)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightView)).EndInit();
            this.panelMore.ResumeLayout(false);
            this.panelMore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarRadius)).EndInit();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseHelpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnrecoder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDSP)).EndInit();
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
        private DMSkin.Metro.Controls.MetroTrackBar Pos;
        private System.Windows.Forms.Label labelLeftTime;
        private System.Windows.Forms.Label labelTime;
        private DMSkin.Controls.DMProgressBar VolumeMaster;
        private CCWin.SkinControl.SkinPictureBox playControl;
        private CCWin.SkinControl.SkinLabel MusicTitle;
        private CCWin.SkinControl.SkinLabel ArtistName;
        public System.Windows.Forms.OpenFileDialog LoadMediaFile;
        private System.Windows.Forms.Timer Position;
        private CCWin.SkinControl.SkinPictureBox pictureBoxSpectrum;
        private CCWin.SkinControl.SkinPictureBox RightView;
        private CCWin.SkinControl.SkinPictureBox LeftView;
        private DMSkin.MetroDMButton btnHidePicturebBox;
        private CCWin.SkinControl.SkinLine LineforPanelSetting;
        private CCWin.SkinControl.SkinPictureBox btnMore;
        private System.Windows.Forms.Panel panelMore;
        private DMSkin.MetroDMButton btnGlassAblumView;
        private CCWin.SkinControl.SkinLabel labelbtnGlassAblumView;
        private CCWin.SkinControl.SkinTrackBar BarRadius;
        private System.Windows.Forms.Label label1;
        private DMSkin.Controls.DMCheckBox ChkExpandEdge;
        public CCWin.SkinControl.SkinPictureBox AlbumViewer;
        private MaterialSkin.Controls.MaterialFlatButton btnChangeBG;
        private DMSkin.Metro.Controls.MetroButton btnDone;
        private System.Windows.Forms.Timer labelDoneTimer;
        private CCWin.SkinControl.SkinPanel panelHelp;
        private CCWin.SkinControl.SkinPictureBox btnShowDSP;
        private CCWin.SkinControl.SkinPictureBox btnHelpView;
        private CCWin.SkinControl.SkinPictureBox btnEnrecoder;
        private CCWin.SkinControl.SkinPictureBox btnCloseHelpView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DMSkin.MetroDMButton btnHelpShow;
        private MaterialSkin.Controls.MaterialFlatButton btnDIY;
        private DMSkin.MetroDMButton btnCDPlayer;
        public System.Windows.Forms.Timer FreeMemory;
        private System.ComponentModel.BackgroundWorker PlayThread;
        private System.Windows.Forms.Label labelVolumeValue;
        private MaterialSkin.Controls.MaterialFlatButton btnChangeTextColor;
    }
}