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
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
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
            this.btnSetting = new DMSkin.Controls.DM.DMIcon();
            this.playControl = new CCWin.SkinControl.SkinPictureBox();
            this.VolumeMaster = new DMSkin.Controls.DMProgressBar();
            this.labelLeftTime = new CCWin.SkinControl.SkinLabel();
            this.labelTime = new CCWin.SkinControl.SkinLabel();
            this.Pos = new DMSkin.Metro.Controls.MetroTrackBar();
            this.MusicTitle = new CCWin.SkinControl.SkinLabel();
            this.ArtistName = new CCWin.SkinControl.SkinLabel();
            this.LoadMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.Position = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSpectrum = new CCWin.SkinControl.SkinPictureBox();
            this.RightView = new CCWin.SkinControl.SkinPictureBox();
            this.btnHidePicturebBox = new DMSkin.MetroDMButton();
            this.panelMore = new System.Windows.Forms.Panel();
            this.TabForpanelMore = new DMSkin.Controls.DMTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelbtnGlassAblumView = new CCWin.SkinControl.SkinLabel();
            this.btnChangeTextColor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGlassAblumView = new DMSkin.MetroDMButton();
            this.btnDIY = new MaterialSkin.Controls.MaterialFlatButton();
            this.BarRadius = new CCWin.SkinControl.SkinTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new DMSkin.Metro.Controls.MetroButton();
            this.ChkExpandEdge = new DMSkin.Controls.DMCheckBox();
            this.btnChangeBG = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEncoderView = new DMSkin.MetroDMButton();
            this.btnShowHelp = new DMSkin.MetroDMButton();
            this.btnShowDSPView = new DMSkin.MetroDMButton();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.btnHelpShow = new DMSkin.MetroDMButton();
            this.labelDoneTimer = new System.Windows.Forms.Timer(this.components);
            this.FreeMemory = new System.Windows.Forms.Timer(this.components);
            this.PlayThread = new System.ComponentModel.BackgroundWorker();
            this.AlbumViewer = new CCWin.SkinControl.SkinPanel();
            this.AnimatorforPanelSetting = new CCWin.SkinControl.SkinAnimator(this.components);
            this.panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftView)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightView)).BeginInit();
            this.panelMore.SuspendLayout();
            this.TabForpanelMore.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarRadius)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnClose, CCWin.SkinControl.DecorationType.None);
            this.btnClose.DownImage = global::HappyMaster_Dev.Properties.Resources.buttonClosePRESS;
            this.btnClose.Image = null;
            this.btnClose.IsShowBorder = false;
            this.btnClose.Location = new System.Drawing.Point(10, 15);
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
            this.AnimatorforPanelSetting.SetDecoration(this.btnMin, CCWin.SkinControl.DecorationType.None);
            this.btnMin.DownImage = global::HappyMaster_Dev.Properties.Resources.buttonMinPRESS;
            this.btnMin.Image = null;
            this.btnMin.IsShowBorder = false;
            this.btnMin.Location = new System.Drawing.Point(36, 15);
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
            this.AnimatorforPanelSetting.SetDecoration(this.btnMax, CCWin.SkinControl.DecorationType.None);
            this.btnMax.DownImage = global::HappyMaster_Dev.Properties.Resources.buttonMax;
            this.btnMax.Image = null;
            this.btnMax.IsShowBorder = false;
            this.btnMax.Location = new System.Drawing.Point(62, 15);
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
            this.AnimatorforPanelSetting.SetDecoration(this.btnLoadFile, CCWin.SkinControl.DecorationType.None);
            this.btnLoadFile.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuLoadFileBlue;
            this.btnLoadFile.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadFile.Image = null;
            this.btnLoadFile.IsShowBorder = false;
            this.btnLoadFile.Location = new System.Drawing.Point(1, 20);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadFile.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuLoadFileBlue;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuLoadFileWhite;
            this.btnLoadFile.Size = new System.Drawing.Size(242, 28);
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
            this.panelSetting.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.MenuBgNew;
            this.panelSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSetting.Controls.Add(this.btnCDPlayer);
            this.panelSetting.Controls.Add(this.LineforPanelSetting);
            this.panelSetting.Controls.Add(this.btnMore);
            this.panelSetting.Controls.Add(this.btnAbout);
            this.panelSetting.Controls.Add(this.btnShowLiveImage);
            this.panelSetting.Controls.Add(this.btnLoadFile);
            this.panelSetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AnimatorforPanelSetting.SetDecoration(this.panelSetting, CCWin.SkinControl.DecorationType.None);
            this.panelSetting.DownBack = null;
            this.panelSetting.ForeColor = System.Drawing.Color.Transparent;
            this.panelSetting.Location = new System.Drawing.Point(191, 279);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(0);
            this.panelSetting.MouseBack = null;
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.NormlBack = null;
            this.panelSetting.Palace = true;
            this.panelSetting.Radius = 20;
            this.panelSetting.Size = new System.Drawing.Size(244, 177);
            this.panelSetting.TabIndex = 8;
            this.panelSetting.Visible = false;
            // 
            // btnCDPlayer
            // 
            this.btnCDPlayer.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnCDPlayer, CCWin.SkinControl.DecorationType.None);
            this.btnCDPlayer.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuCDPlayerWhite;
            this.btnCDPlayer.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCDPlayer.Image = null;
            this.btnCDPlayer.IsShowBorder = false;
            this.btnCDPlayer.Location = new System.Drawing.Point(1, 74);
            this.btnCDPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCDPlayer.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuCDPlayerWhite;
            this.btnCDPlayer.Name = "btnCDPlayer";
            this.btnCDPlayer.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuCDPlayer;
            this.btnCDPlayer.Size = new System.Drawing.Size(242, 28);
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
            this.AnimatorforPanelSetting.SetDecoration(this.LineforPanelSetting, CCWin.SkinControl.DecorationType.None);
            this.LineforPanelSetting.LineColor = System.Drawing.Color.Gray;
            this.LineforPanelSetting.LineHeight = 1;
            this.LineforPanelSetting.Location = new System.Drawing.Point(5, 134);
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
            this.AnimatorforPanelSetting.SetDecoration(this.btnMore, CCWin.SkinControl.DecorationType.None);
            this.btnMore.Location = new System.Drawing.Point(3, 105);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(238, 23);
            this.btnMore.TabIndex = 8;
            this.btnMore.TabStop = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            this.btnMore.MouseEnter += new System.EventHandler(this.btnMore_MouseEnter);
            this.btnMore.MouseLeave += new System.EventHandler(this.btnMore_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnAbout, CCWin.SkinControl.DecorationType.None);
            this.btnAbout.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuAboutAppBlue;
            this.btnAbout.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.Image = null;
            this.btnAbout.IsShowBorder = false;
            this.btnAbout.Location = new System.Drawing.Point(1, 146);
            this.btnAbout.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuAboutAppBlue;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuAboutAppWhite;
            this.btnAbout.Size = new System.Drawing.Size(242, 28);
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
            this.AnimatorforPanelSetting.SetDecoration(this.btnShowLiveImage, CCWin.SkinControl.DecorationType.None);
            this.btnShowLiveImage.DownImage = global::HappyMaster_Dev.Properties.Resources.MenuLivePic;
            this.btnShowLiveImage.Font = new System.Drawing.Font(".PingFang SC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowLiveImage.Image = null;
            this.btnShowLiveImage.IsShowBorder = false;
            this.btnShowLiveImage.Location = new System.Drawing.Point(1, 48);
            this.btnShowLiveImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowLiveImage.MoveImage = global::HappyMaster_Dev.Properties.Resources.MenuLivePic;
            this.btnShowLiveImage.Name = "btnShowLiveImage";
            this.btnShowLiveImage.NormalImage = global::HappyMaster_Dev.Properties.Resources.MenuLivePicWhite;
            this.btnShowLiveImage.Size = new System.Drawing.Size(242, 28);
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
            this.AnimatorforPanelSetting.SetDecoration(this.LeftView, CCWin.SkinControl.DecorationType.None);
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
            this.bottomPanel.Controls.Add(this.btnSetting);
            this.bottomPanel.Controls.Add(this.playControl);
            this.bottomPanel.Controls.Add(this.VolumeMaster);
            this.bottomPanel.Controls.Add(this.labelLeftTime);
            this.bottomPanel.Controls.Add(this.labelTime);
            this.bottomPanel.Controls.Add(this.Pos);
            this.bottomPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AnimatorforPanelSetting.SetDecoration(this.bottomPanel, CCWin.SkinControl.DecorationType.None);
            this.bottomPanel.DownBack = null;
            this.bottomPanel.Location = new System.Drawing.Point(193, 459);
            this.bottomPanel.MouseBack = null;
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.NormlBack = null;
            this.bottomPanel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.bottomPanel.Size = new System.Drawing.Size(607, 69);
            this.bottomPanel.TabIndex = 9;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnSetting, CCWin.SkinControl.DecorationType.None);
            this.btnSetting.DM_Color = System.Drawing.Color.White;
            this.btnSetting.DM_Font_Size = 20F;
            this.btnSetting.DM_Key = DMSkin.Controls.DM.DMIcon.DMIconKey.更多;
            this.btnSetting.DM_Text = "";
            this.btnSetting.Location = new System.Drawing.Point(3, 13);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(36, 24);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "dmIcon1";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click_1);
            this.btnSetting.MouseEnter += new System.EventHandler(this.btnSetting_MouseEnter);
            this.btnSetting.MouseLeave += new System.EventHandler(this.btnSetting_MouseLeave);
            this.btnSetting.MouseHover += new System.EventHandler(this.btnSetting_MouseHover);
            // 
            // playControl
            // 
            this.playControl.BackColor = System.Drawing.Color.Transparent;
            this.playControl.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.PlayNormal;
            this.playControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimatorforPanelSetting.SetDecoration(this.playControl, CCWin.SkinControl.DecorationType.None);
            this.playControl.Location = new System.Drawing.Point(281, 7);
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
            this.AnimatorforPanelSetting.SetDecoration(this.VolumeMaster, CCWin.SkinControl.DecorationType.None);
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
            this.VolumeMaster.Location = new System.Drawing.Point(486, 13);
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
            this.labelLeftTime.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.labelLeftTime.AutoSize = true;
            this.labelLeftTime.BackColor = System.Drawing.Color.Transparent;
            this.labelLeftTime.BorderColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.labelLeftTime, CCWin.SkinControl.DecorationType.None);
            this.labelLeftTime.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLeftTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLeftTime.Location = new System.Drawing.Point(543, 49);
            this.labelLeftTime.Name = "labelLeftTime";
            this.labelLeftTime.Size = new System.Drawing.Size(39, 17);
            this.labelLeftTime.TabIndex = 3;
            this.labelLeftTime.Text = "00:00";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.BorderColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.labelTime, CCWin.SkinControl.DecorationType.None);
            this.labelTime.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTime.Location = new System.Drawing.Point(40, 49);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(39, 17);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00";
            // 
            // Pos
            // 
            this.Pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pos.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.Pos, CCWin.SkinControl.DecorationType.None);
            this.Pos.DM_UseCustomBackColor = true;
            this.Pos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pos.Location = new System.Drawing.Point(85, 43);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(446, 23);
            this.Pos.TabIndex = 1;
            this.Pos.TabStop = false;
            this.Pos.Text = "metroTrackBar1";
            this.Pos.Value = 0;
            this.Pos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pos_Scroll);
            this.Pos.MouseHover += new System.EventHandler(this.Pos_MouseHover);
            // 
            // MusicTitle
            // 
            this.MusicTitle.AutoSize = true;
            this.MusicTitle.BackColor = System.Drawing.Color.Transparent;
            this.MusicTitle.BorderColor = System.Drawing.Color.Transparent;
            this.MusicTitle.CausesValidation = false;
            this.AnimatorforPanelSetting.SetDecoration(this.MusicTitle, CCWin.SkinControl.DecorationType.None);
            this.MusicTitle.Font = new System.Drawing.Font(".PingFang SC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicTitle.ForeColor = System.Drawing.Color.White;
            this.MusicTitle.Location = new System.Drawing.Point(389, 294);
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
            this.AnimatorforPanelSetting.SetDecoration(this.ArtistName, CCWin.SkinControl.DecorationType.None);
            this.ArtistName.Font = new System.Drawing.Font(".PingFang SC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ArtistName.ForeColor = System.Drawing.Color.White;
            this.ArtistName.Location = new System.Drawing.Point(412, 350);
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
            this.AnimatorforPanelSetting.SetDecoration(this.pictureBoxSpectrum, CCWin.SkinControl.DecorationType.None);
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
            this.AnimatorforPanelSetting.SetDecoration(this.RightView, CCWin.SkinControl.DecorationType.None);
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
            this.AnimatorforPanelSetting.SetDecoration(this.btnHidePicturebBox, CCWin.SkinControl.DecorationType.None);
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
            this.panelMore.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.MenuBgNew;
            this.panelMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMore.Controls.Add(this.TabForpanelMore);
            this.panelMore.Controls.Add(this.labelVolumeValue);
            this.panelMore.Controls.Add(this.btnHelpShow);
            this.AnimatorforPanelSetting.SetDecoration(this.panelMore, CCWin.SkinControl.DecorationType.None);
            this.panelMore.Location = new System.Drawing.Point(598, 244);
            this.panelMore.Name = "panelMore";
            this.panelMore.Size = new System.Drawing.Size(238, 209);
            this.panelMore.TabIndex = 17;
            this.panelMore.Visible = false;
            // 
            // TabForpanelMore
            // 
            this.TabForpanelMore.BackColor = System.Drawing.Color.Transparent;
            this.TabForpanelMore.Controls.Add(this.tabPage1);
            this.TabForpanelMore.Controls.Add(this.tabPage2);
            this.AnimatorforPanelSetting.SetDecoration(this.TabForpanelMore, CCWin.SkinControl.DecorationType.None);
            this.TabForpanelMore.DMNormalBackColor = System.Drawing.Color.Transparent;
            this.TabForpanelMore.ItemSize = new System.Drawing.Size(80, 32);
            this.TabForpanelMore.Location = new System.Drawing.Point(4, 3);
            this.TabForpanelMore.Name = "TabForpanelMore";
            this.TabForpanelMore.SelectedIndex = 0;
            this.TabForpanelMore.Size = new System.Drawing.Size(231, 176);
            this.TabForpanelMore.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabForpanelMore.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelbtnGlassAblumView);
            this.tabPage1.Controls.Add(this.btnChangeTextColor);
            this.tabPage1.Controls.Add(this.btnGlassAblumView);
            this.tabPage1.Controls.Add(this.btnDIY);
            this.tabPage1.Controls.Add(this.BarRadius);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDone);
            this.tabPage1.Controls.Add(this.ChkExpandEdge);
            this.tabPage1.Controls.Add(this.btnChangeBG);
            this.AnimatorforPanelSetting.SetDecoration(this.tabPage1, CCWin.SkinControl.DecorationType.None);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(223, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个性化";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelbtnGlassAblumView
            // 
            this.labelbtnGlassAblumView.AutoSize = true;
            this.labelbtnGlassAblumView.BackColor = System.Drawing.Color.Transparent;
            this.labelbtnGlassAblumView.BorderColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.labelbtnGlassAblumView, CCWin.SkinControl.DecorationType.None);
            this.labelbtnGlassAblumView.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelbtnGlassAblumView.ForeColor = System.Drawing.Color.Black;
            this.labelbtnGlassAblumView.Location = new System.Drawing.Point(42, 3);
            this.labelbtnGlassAblumView.Name = "labelbtnGlassAblumView";
            this.labelbtnGlassAblumView.Size = new System.Drawing.Size(169, 17);
            this.labelbtnGlassAblumView.TabIndex = 1;
            this.labelbtnGlassAblumView.Text = "(・ˍ・*)是否高斯模糊专辑图片";
            this.labelbtnGlassAblumView.Click += new System.EventHandler(this.labelbtnGlassAblumView_Click);
            // 
            // btnChangeTextColor
            // 
            this.btnChangeTextColor.AutoSize = true;
            this.btnChangeTextColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeTextColor.BackColor = System.Drawing.Color.White;
            this.AnimatorforPanelSetting.SetDecoration(this.btnChangeTextColor, CCWin.SkinControl.DecorationType.None);
            this.btnChangeTextColor.Depth = 0;
            this.btnChangeTextColor.ForeColor = System.Drawing.Color.Black;
            this.btnChangeTextColor.Location = new System.Drawing.Point(158, 88);
            this.btnChangeTextColor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeTextColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeTextColor.Name = "btnChangeTextColor";
            this.btnChangeTextColor.Primary = false;
            this.btnChangeTextColor.Size = new System.Drawing.Size(61, 36);
            this.btnChangeTextColor.TabIndex = 11;
            this.btnChangeTextColor.TabStop = false;
            this.btnChangeTextColor.Text = "文字适应";
            this.btnChangeTextColor.UseVisualStyleBackColor = false;
            this.btnChangeTextColor.Click += new System.EventHandler(this.btnChangeTextColor_Click);
            // 
            // btnGlassAblumView
            // 
            this.btnGlassAblumView.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnGlassAblumView, CCWin.SkinControl.DecorationType.None);
            this.btnGlassAblumView.DownImage = global::HappyMaster_Dev.Properties.Resources.checkBoxChecked;
            this.btnGlassAblumView.Image = null;
            this.btnGlassAblumView.IsShowBorder = false;
            this.btnGlassAblumView.Location = new System.Drawing.Point(6, 6);
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
            // btnDIY
            // 
            this.btnDIY.AutoSize = true;
            this.btnDIY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDIY.BackColor = System.Drawing.Color.White;
            this.AnimatorforPanelSetting.SetDecoration(this.btnDIY, CCWin.SkinControl.DecorationType.None);
            this.btnDIY.Depth = 0;
            this.btnDIY.ForeColor = System.Drawing.Color.Black;
            this.btnDIY.Location = new System.Drawing.Point(73, 88);
            this.btnDIY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDIY.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDIY.Name = "btnDIY";
            this.btnDIY.Primary = false;
            this.btnDIY.Size = new System.Drawing.Size(86, 36);
            this.btnDIY.TabIndex = 9;
            this.btnDIY.TabStop = false;
            this.btnDIY.Text = "取消窗体透明";
            this.btnDIY.UseVisualStyleBackColor = false;
            this.btnDIY.Click += new System.EventHandler(this.btnDIY_Click);
            // 
            // BarRadius
            // 
            this.BarRadius.BackColor = System.Drawing.Color.Transparent;
            this.BarRadius.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.BarRadius.Bar = ((System.Drawing.Image)(resources.GetObject("BarRadius.Bar")));
            this.BarRadius.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Img;
            this.BarRadius.BaseColor = System.Drawing.Color.DarkGray;
            this.AnimatorforPanelSetting.SetDecoration(this.BarRadius, CCWin.SkinControl.DecorationType.None);
            this.BarRadius.Enabled = false;
            this.BarRadius.Location = new System.Drawing.Point(11, 11);
            this.BarRadius.Maximum = 255;
            this.BarRadius.Name = "BarRadius";
            this.BarRadius.Size = new System.Drawing.Size(197, 45);
            this.BarRadius.TabIndex = 2;
            this.BarRadius.TabStop = false;
            this.BarRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BarRadius.Track = ((System.Drawing.Image)(resources.GetObject("BarRadius.Track")));
            this.BarRadius.Value = 10;
            this.BarRadius.Scroll += new System.EventHandler(this.BarRadius_Scroll);
            this.BarRadius.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarRadius_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimatorforPanelSetting.SetDecoration(this.label1, CCWin.SkinControl.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "扩展边际不啦 _(:3 」∠)_ ";
            // 
            // btnDone
            // 
            this.AnimatorforPanelSetting.SetDecoration(this.btnDone, CCWin.SkinControl.DecorationType.None);
            this.btnDone.DM_UseSelectable = true;
            this.btnDone.Enabled = false;
            this.btnDone.Location = new System.Drawing.Point(152, 59);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(65, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "应用更改";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // ChkExpandEdge
            // 
            this.ChkExpandEdge.BackColor = System.Drawing.Color.Transparent;
            this.ChkExpandEdge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChkExpandEdge.Checked = false;
            this.AnimatorforPanelSetting.SetDecoration(this.ChkExpandEdge, CCWin.SkinControl.DecorationType.None);
            this.ChkExpandEdge.Location = new System.Drawing.Point(11, 59);
            this.ChkExpandEdge.Name = "ChkExpandEdge";
            this.ChkExpandEdge.Size = new System.Drawing.Size(15, 19);
            this.ChkExpandEdge.TabIndex = 3;
            this.ChkExpandEdge.Click += new System.EventHandler(this.ChkExpandEdge_Click);
            // 
            // btnChangeBG
            // 
            this.btnChangeBG.AutoSize = true;
            this.btnChangeBG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeBG.BackColor = System.Drawing.Color.White;
            this.AnimatorforPanelSetting.SetDecoration(this.btnChangeBG, CCWin.SkinControl.DecorationType.None);
            this.btnChangeBG.Depth = 0;
            this.btnChangeBG.ForeColor = System.Drawing.Color.Black;
            this.btnChangeBG.Location = new System.Drawing.Point(4, 88);
            this.btnChangeBG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeBG.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeBG.Name = "btnChangeBG";
            this.btnChangeBG.Primary = false;
            this.btnChangeBG.Size = new System.Drawing.Size(61, 36);
            this.btnChangeBG.TabIndex = 6;
            this.btnChangeBG.TabStop = false;
            this.btnChangeBG.Text = "更换壁纸";
            this.btnChangeBG.UseVisualStyleBackColor = false;
            this.btnChangeBG.Click += new System.EventHandler(this.btnChangeBG_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEncoderView);
            this.tabPage2.Controls.Add(this.btnShowHelp);
            this.tabPage2.Controls.Add(this.btnShowDSPView);
            this.AnimatorforPanelSetting.SetDecoration(this.tabPage2, CCWin.SkinControl.DecorationType.None);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(223, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "帮助";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEncoderView
            // 
            this.btnEncoderView.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnEncoderView, CCWin.SkinControl.DecorationType.None);
            this.btnEncoderView.DownImage = global::HappyMaster_Dev.Properties.Resources.Clicked;
            this.btnEncoderView.Font = new System.Drawing.Font(".System San Francisco Display", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncoderView.ForeColor = System.Drawing.Color.Black;
            this.btnEncoderView.Image = null;
            this.btnEncoderView.IsShowBorder = false;
            this.btnEncoderView.Location = new System.Drawing.Point(3, 34);
            this.btnEncoderView.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncoderView.MoveImage = global::HappyMaster_Dev.Properties.Resources.Hover;
            this.btnEncoderView.Name = "btnEncoderView";
            this.btnEncoderView.NormalImage = global::HappyMaster_Dev.Properties.Resources.Normal;
            this.btnEncoderView.Size = new System.Drawing.Size(217, 31);
            this.btnEncoderView.TabIndex = 11;
            this.btnEncoderView.TabStop = false;
            this.btnEncoderView.Text = "格式转换";
            this.btnEncoderView.UseVisualStyleBackColor = false;
            this.btnEncoderView.Click += new System.EventHandler(this.btnEncoderView_Click);
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnShowHelp, CCWin.SkinControl.DecorationType.None);
            this.btnShowHelp.DownImage = global::HappyMaster_Dev.Properties.Resources.Clicked;
            this.btnShowHelp.Font = new System.Drawing.Font(".System San Francisco Display", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHelp.ForeColor = System.Drawing.Color.Black;
            this.btnShowHelp.Image = null;
            this.btnShowHelp.IsShowBorder = false;
            this.btnShowHelp.Location = new System.Drawing.Point(3, 67);
            this.btnShowHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowHelp.MoveImage = global::HappyMaster_Dev.Properties.Resources.Hover;
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.NormalImage = global::HappyMaster_Dev.Properties.Resources.Normal;
            this.btnShowHelp.Size = new System.Drawing.Size(217, 31);
            this.btnShowHelp.TabIndex = 10;
            this.btnShowHelp.TabStop = false;
            this.btnShowHelp.Text = "帮助";
            this.btnShowHelp.UseVisualStyleBackColor = false;
            this.btnShowHelp.Click += new System.EventHandler(this.btnShowHelp_Click);
            // 
            // btnShowDSPView
            // 
            this.btnShowDSPView.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnShowDSPView, CCWin.SkinControl.DecorationType.None);
            this.btnShowDSPView.DownImage = global::HappyMaster_Dev.Properties.Resources.Clicked;
            this.btnShowDSPView.Font = new System.Drawing.Font(".System San Francisco Display", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDSPView.ForeColor = System.Drawing.Color.Black;
            this.btnShowDSPView.Image = null;
            this.btnShowDSPView.IsShowBorder = false;
            this.btnShowDSPView.Location = new System.Drawing.Point(3, 3);
            this.btnShowDSPView.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowDSPView.MoveImage = global::HappyMaster_Dev.Properties.Resources.Hover;
            this.btnShowDSPView.Name = "btnShowDSPView";
            this.btnShowDSPView.NormalImage = global::HappyMaster_Dev.Properties.Resources.Normal;
            this.btnShowDSPView.Size = new System.Drawing.Size(217, 31);
            this.btnShowDSPView.TabIndex = 9;
            this.btnShowDSPView.TabStop = false;
            this.btnShowDSPView.Text = "打开DSP";
            this.btnShowDSPView.UseVisualStyleBackColor = false;
            this.btnShowDSPView.Click += new System.EventHandler(this.showDSPView_Click);
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.AutoSize = true;
            this.AnimatorforPanelSetting.SetDecoration(this.labelVolumeValue, CCWin.SkinControl.DecorationType.None);
            this.labelVolumeValue.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVolumeValue.ForeColor = System.Drawing.Color.Black;
            this.labelVolumeValue.Location = new System.Drawing.Point(5, 182);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(56, 17);
            this.labelVolumeValue.TabIndex = 10;
            this.labelVolumeValue.Text = "当前音量";
            // 
            // btnHelpShow
            // 
            this.btnHelpShow.BackColor = System.Drawing.Color.Transparent;
            this.AnimatorforPanelSetting.SetDecoration(this.btnHelpShow, CCWin.SkinControl.DecorationType.None);
            this.btnHelpShow.DownImage = ((System.Drawing.Image)(resources.GetObject("btnHelpShow.DownImage")));
            this.btnHelpShow.Font = new System.Drawing.Font(".System San Francisco Display", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpShow.ForeColor = System.Drawing.Color.Black;
            this.btnHelpShow.Image = null;
            this.btnHelpShow.IsShowBorder = false;
            this.btnHelpShow.Location = new System.Drawing.Point(175, 175);
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
            // labelDoneTimer
            // 
            this.labelDoneTimer.Interval = 500;
            this.labelDoneTimer.Tick += new System.EventHandler(this.labelDoneTimer_Tick);
            // 
            // FreeMemory
            // 
            this.FreeMemory.Tick += new System.EventHandler(this.FreeMemory_Tick);
            // 
            // PlayThread
            // 
            this.PlayThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PlayThread_DoWork);
            this.PlayThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PlayThread_RunWorkerCompleted);
            // 
            // AlbumViewer
            // 
            this.AlbumViewer.BackColor = System.Drawing.Color.Transparent;
            this.AlbumViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumViewer.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AnimatorforPanelSetting.SetDecoration(this.AlbumViewer, CCWin.SkinControl.DecorationType.None);
            this.AlbumViewer.DownBack = null;
            this.AlbumViewer.Location = new System.Drawing.Point(364, 38);
            this.AlbumViewer.MouseBack = null;
            this.AlbumViewer.Name = "AlbumViewer";
            this.AlbumViewer.NormlBack = null;
            this.AlbumViewer.Radius = 10;
            this.AlbumViewer.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.AlbumViewer.Size = new System.Drawing.Size(200, 200);
            this.AlbumViewer.TabIndex = 21;
            this.AlbumViewer.Click += new System.EventHandler(this.AlbumViewer_Click_1);
            this.AlbumViewer.Paint += new System.Windows.Forms.PaintEventHandler(this.AlbumViewer_Paint_1);
            this.AlbumViewer.MouseHover += new System.EventHandler(this.AlbumViewer_MouseHover_1);
            // 
            // AnimatorforPanelSetting
            // 
            this.AnimatorforPanelSetting.AnimationType = CCWin.SkinControl.AnimationType.Scale;
            this.AnimatorforPanelSetting.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimatorforPanelSetting.DefaultAnimation = animation1;
            this.AnimatorforPanelSetting.MouseDown += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.AnimatorforPanelSetting_MouseDown);
            this.AnimatorforPanelSetting.FramePainted += new System.EventHandler<System.Windows.Forms.PaintEventArgs>(this.AnimatorforPanelSetting_FramePainted);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 541);
            this.Controls.Add(this.AlbumViewer);
            this.Controls.Add(this.panelMore);
            this.Controls.Add(this.LeftView);
            this.Controls.Add(this.btnHidePicturebBox);
            this.Controls.Add(this.RightView);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.pictureBoxSpectrum);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.MusicTitle);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.AnimatorforPanelSetting.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.DM_howBorder = false;
            this.DM_RoundStyle = DMSkin.SkinClass.RoundStyle.None;
            this.DM_ShadowWidth = 6;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainView";
            this.Opacity = 0.85D;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightView)).EndInit();
            this.panelMore.ResumeLayout(false);
            this.panelMore.PerformLayout();
            this.TabForpanelMore.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarRadius)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
        private DMSkin.Metro.Controls.MetroTrackBar Pos;
        private CCWin.SkinControl.SkinLabel labelLeftTime;
        private DMSkin.Controls.DMProgressBar VolumeMaster;
        private CCWin.SkinControl.SkinPictureBox playControl;
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
        private MaterialSkin.Controls.MaterialFlatButton btnChangeBG;
        private DMSkin.Metro.Controls.MetroButton btnDone;
        private System.Windows.Forms.Timer labelDoneTimer;
        private DMSkin.MetroDMButton btnHelpShow;
        private MaterialSkin.Controls.MaterialFlatButton btnDIY;
        private DMSkin.MetroDMButton btnCDPlayer;
        public System.Windows.Forms.Timer FreeMemory;
        private System.ComponentModel.BackgroundWorker PlayThread;
        private System.Windows.Forms.Label labelVolumeValue;
        private MaterialSkin.Controls.MaterialFlatButton btnChangeTextColor;
        private CCWin.SkinControl.SkinLabel MusicTitle;
        private CCWin.SkinControl.SkinLabel labelTime;
        private CCWin.SkinControl.SkinPanel AlbumViewer;
        private DMSkin.Controls.DM.DMIcon btnSetting;
        private DMSkin.Controls.DMTabControl TabForpanelMore;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CCWin.SkinControl.SkinAnimator AnimatorforPanelSetting;
        private DMSkin.MetroDMButton btnShowDSPView;
        private DMSkin.MetroDMButton btnEncoderView;
        private DMSkin.MetroDMButton btnShowHelp;
    }
}