namespace HappyMaster
{
    partial class AppViewer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppViewer));
            this.CloseViewer = new System.Windows.Forms.PictureBox();
            this.Maximization = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.TotalTime = new CCWin.SkinControl.SkinLabel();
            this.ThisTime = new CCWin.SkinControl.SkinLabel();
            this.Position = new System.Windows.Forms.Timer(this.components);
            this.AlbumViewer = new CCWin.SkinControl.SkinPictureBox();
            this.More = new CCWin.SkinControl.SkinPictureBox();
            this.List = new CCWin.SkinControl.SkinPictureBox();
            this.textBoxTitle = new CCWin.SkinControl.SkinLabel();
            this.textBoxArtist = new CCWin.SkinControl.SkinLabel();
            this.Panel1 = new CCWin.SkinControl.SkinPanel();
            this.Pos = new DMSkin.Metro.Controls.MetroTrackBar();
            this.Panel2 = new CCWin.SkinControl.SkinPanel();
            this.EncoderShow = new CCWin.SkinControl.SkinPictureBox();
            this.DSPViewerShow = new CCWin.SkinControl.SkinPictureBox();
            this.LoadPicture = new DMSkin.MetroDMButton();
            this.pictureBoxSpectrum = new System.Windows.Forms.PictureBox();
            this.OpenFile = new CCWin.SkinControl.SkinPictureBox();
            this.Infoyear = new System.Windows.Forms.Label();
            this.VolumeMax = new CCWin.SkinControl.SkinPictureBox();
            this.VolumeMin = new CCWin.SkinControl.SkinPictureBox();
            this.VolumeMaster = new DMSkin.Controls.DMProgressBar();
            this.OpenSetting = new CCWin.SkinControl.SkinPictureBox();
            this.Infoartist = new System.Windows.Forms.Label();
            this.Infoablum = new System.Windows.Forms.Label();
            this.InfoTitle = new System.Windows.Forms.Label();
            this.InfoPicture = new CCWin.SkinControl.SkinPictureBox();
            this.Player = new CCWin.SkinControl.SkinPictureBox();
            this.PlayControlsBG = new CCWin.SkinControl.SkinPanel();
            this.ChangeBG = new System.Windows.Forms.Timer(this.components);
            this.PlayList = new System.Windows.Forms.Panel();
            this.ListBoxMusicList = new System.Windows.Forms.ListBox();
            this.CloseListBox = new DMSkin.Controls.DMButtonMinLight();
            this.ShowMessageBox = new DMSkin.Controls.DMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CloseViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.More)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncoderShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPViewerShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.PlayControlsBG.SuspendLayout();
            this.PlayList.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseViewer
            // 
            this.CloseViewer.BackColor = System.Drawing.Color.Transparent;
            this.CloseViewer.BackgroundImage = global::HappyMaster.Properties.Resources.CloseR;
            this.CloseViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseViewer.Location = new System.Drawing.Point(5, 5);
            this.CloseViewer.Name = "CloseViewer";
            this.CloseViewer.Size = new System.Drawing.Size(15, 15);
            this.CloseViewer.TabIndex = 1;
            this.CloseViewer.TabStop = false;
            this.CloseViewer.Click += new System.EventHandler(this.CloseViewer_Click);
            // 
            // Maximization
            // 
            this.Maximization.BackColor = System.Drawing.Color.Transparent;
            this.Maximization.BackgroundImage = global::HappyMaster.Properties.Resources.MaximizationR;
            this.Maximization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximization.Location = new System.Drawing.Point(26, 5);
            this.Maximization.Name = "Maximization";
            this.Maximization.Size = new System.Drawing.Size(15, 15);
            this.Maximization.TabIndex = 2;
            this.Maximization.TabStop = false;
            this.Maximization.Click += new System.EventHandler(this.Maximization_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::HappyMaster.Properties.Resources.MinimizeR;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Location = new System.Drawing.Point(47, 5);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(15, 15);
            this.Minimize.TabIndex = 3;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.BackColor = System.Drawing.Color.Transparent;
            this.TotalTime.BorderColor = System.Drawing.Color.Transparent;
            this.TotalTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TotalTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalTime.Location = new System.Drawing.Point(167, 245);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(39, 17);
            this.TotalTime.TabIndex = 6;
            this.TotalTime.Text = "00:00";
            // 
            // ThisTime
            // 
            this.ThisTime.AutoSize = true;
            this.ThisTime.BackColor = System.Drawing.Color.Transparent;
            this.ThisTime.BorderColor = System.Drawing.Color.Transparent;
            this.ThisTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThisTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ThisTime.Location = new System.Drawing.Point(3, 245);
            this.ThisTime.Name = "ThisTime";
            this.ThisTime.Size = new System.Drawing.Size(39, 17);
            this.ThisTime.TabIndex = 7;
            this.ThisTime.Text = "00:00";
            // 
            // Position
            // 
            this.Position.Tick += new System.EventHandler(this.Position_Tick);
            // 
            // AlbumViewer
            // 
            this.AlbumViewer.BackColor = System.Drawing.Color.Transparent;
            this.AlbumViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumViewer.Location = new System.Drawing.Point(3, 42);
            this.AlbumViewer.Name = "AlbumViewer";
            this.AlbumViewer.Size = new System.Drawing.Size(200, 200);
            this.AlbumViewer.TabIndex = 8;
            this.AlbumViewer.TabStop = false;
            this.AlbumViewer.Click += new System.EventHandler(this.AlbumViewer_Click);
            // 
            // More
            // 
            this.More.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.More.BackColor = System.Drawing.Color.Transparent;
            this.More.BackgroundImage = global::HappyMaster.Properties.Resources.dots_3;
            this.More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.More.Location = new System.Drawing.Point(796, 46);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(20, 20);
            this.More.TabIndex = 10;
            this.More.TabStop = false;
            this.More.Click += new System.EventHandler(this.More_Click);
            // 
            // List
            // 
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.List.BackColor = System.Drawing.Color.Transparent;
            this.List.BackgroundImage = global::HappyMaster.Properties.Resources.view_list;
            this.List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.List.Location = new System.Drawing.Point(18, 46);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(20, 20);
            this.List.TabIndex = 11;
            this.List.TabStop = false;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AutoEllipsis = true;
            this.textBoxTitle.AutoSize = true;
            this.textBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTitle.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTitle.Location = new System.Drawing.Point(383, 301);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(63, 31);
            this.textBoxTitle.TabIndex = 12;
            this.textBoxTitle.Text = "Title";
            this.textBoxTitle.Visible = false;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.AutoSize = true;
            this.textBoxArtist.BackColor = System.Drawing.Color.Transparent;
            this.textBoxArtist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxArtist.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxArtist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxArtist.Location = new System.Drawing.Point(383, 344);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(63, 31);
            this.textBoxArtist.TabIndex = 13;
            this.textBoxArtist.Text = "Title";
            this.textBoxArtist.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.AlbumViewer);
            this.Panel1.Controls.Add(this.ThisTime);
            this.Panel1.Controls.Add(this.Pos);
            this.Panel1.Controls.Add(this.TotalTime);
            this.Panel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Panel1.DownBack = null;
            this.Panel1.Location = new System.Drawing.Point(319, 31);
            this.Panel1.MouseBack = null;
            this.Panel1.Name = "Panel1";
            this.Panel1.NormlBack = null;
            this.Panel1.Size = new System.Drawing.Size(206, 267);
            this.Panel1.TabIndex = 14;
            this.Panel1.Visible = false;
            // 
            // Pos
            // 
            this.Pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pos.BackColor = System.Drawing.Color.Transparent;
            this.Pos.DM_UseCustomBackColor = true;
            this.Pos.ForeColor = System.Drawing.Color.Transparent;
            this.Pos.Location = new System.Drawing.Point(3, 13);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(200, 23);
            this.Pos.TabIndex = 15;
            this.Pos.Text = "metroTrackBar1";
            this.Pos.Value = 0;
            this.Pos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pos_Scroll);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.BackgroundImage = global::HappyMaster.Properties.Resources.playerbg;
            this.Panel2.Controls.Add(this.EncoderShow);
            this.Panel2.Controls.Add(this.DSPViewerShow);
            this.Panel2.Controls.Add(this.LoadPicture);
            this.Panel2.Controls.Add(this.pictureBoxSpectrum);
            this.Panel2.Controls.Add(this.OpenFile);
            this.Panel2.Controls.Add(this.Infoyear);
            this.Panel2.Controls.Add(this.VolumeMax);
            this.Panel2.Controls.Add(this.VolumeMin);
            this.Panel2.Controls.Add(this.VolumeMaster);
            this.Panel2.Controls.Add(this.OpenSetting);
            this.Panel2.Controls.Add(this.Infoartist);
            this.Panel2.Controls.Add(this.Infoablum);
            this.Panel2.Controls.Add(this.InfoTitle);
            this.Panel2.Controls.Add(this.InfoPicture);
            this.Panel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Panel2.DownBack = null;
            this.Panel2.Location = new System.Drawing.Point(15, 44);
            this.Panel2.MouseBack = null;
            this.Panel2.Name = "Panel2";
            this.Panel2.NormlBack = null;
            this.Panel2.Size = new System.Drawing.Size(346, 374);
            this.Panel2.TabIndex = 17;
            this.Panel2.Visible = false;
            // 
            // EncoderShow
            // 
            this.EncoderShow.BackColor = System.Drawing.Color.Transparent;
            this.EncoderShow.BackgroundImage = global::HappyMaster.Properties.Resources.copyfile_L;
            this.EncoderShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EncoderShow.Location = new System.Drawing.Point(237, 313);
            this.EncoderShow.Name = "EncoderShow";
            this.EncoderShow.Size = new System.Drawing.Size(50, 50);
            this.EncoderShow.TabIndex = 13;
            this.EncoderShow.TabStop = false;
            this.EncoderShow.Click += new System.EventHandler(this.EncoderShow_Click);
            // 
            // DSPViewerShow
            // 
            this.DSPViewerShow.BackColor = System.Drawing.Color.Transparent;
            this.DSPViewerShow.BackgroundImage = global::HappyMaster.Properties.Resources.upload_L1;
            this.DSPViewerShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DSPViewerShow.Location = new System.Drawing.Point(69, 313);
            this.DSPViewerShow.Name = "DSPViewerShow";
            this.DSPViewerShow.Size = new System.Drawing.Size(50, 50);
            this.DSPViewerShow.TabIndex = 12;
            this.DSPViewerShow.TabStop = false;
            this.DSPViewerShow.Click += new System.EventHandler(this.DSPViewerShow_Click);
            // 
            // LoadPicture
            // 
            this.LoadPicture.BackColor = System.Drawing.Color.Transparent;
            this.LoadPicture.DownImage = global::HappyMaster.Properties.Resources.button5;
            this.LoadPicture.Font = new System.Drawing.Font("方正兰亭超细黑简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoadPicture.ForeColor = System.Drawing.Color.Gray;
            this.LoadPicture.Image = global::HappyMaster.Properties.Resources.button1;
            this.LoadPicture.IsShowBorder = false;
            this.LoadPicture.Location = new System.Drawing.Point(125, 313);
            this.LoadPicture.MoveImage = ((System.Drawing.Image)(resources.GetObject("LoadPicture.MoveImage")));
            this.LoadPicture.Name = "LoadPicture";
            this.LoadPicture.NormalImage = global::HappyMaster.Properties.Resources.button1;
            this.LoadPicture.Size = new System.Drawing.Size(87, 35);
            this.LoadPicture.TabIndex = 11;
            this.LoadPicture.Text = "更改背景";
            this.LoadPicture.UseVisualStyleBackColor = false;
            this.LoadPicture.Visible = false;
            this.LoadPicture.Click += new System.EventHandler(this.LoadPicture_Click);
            // 
            // pictureBoxSpectrum
            // 
            this.pictureBoxSpectrum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSpectrum.Location = new System.Drawing.Point(4, 119);
            this.pictureBoxSpectrum.Name = "pictureBoxSpectrum";
            this.pictureBoxSpectrum.Size = new System.Drawing.Size(339, 122);
            this.pictureBoxSpectrum.TabIndex = 10;
            this.pictureBoxSpectrum.TabStop = false;
            this.pictureBoxSpectrum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSpectrum_MouseDown_1);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Transparent;
            this.OpenFile.BackgroundImage = global::HappyMaster.Properties.Resources.drawer_L;
            this.OpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFile.Location = new System.Drawing.Point(4, 313);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(50, 50);
            this.OpenFile.TabIndex = 9;
            this.OpenFile.TabStop = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Infoyear
            // 
            this.Infoyear.AutoSize = true;
            this.Infoyear.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Infoyear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Infoyear.Location = new System.Drawing.Point(290, 93);
            this.Infoyear.Name = "Infoyear";
            this.Infoyear.Size = new System.Drawing.Size(46, 20);
            this.Infoyear.TabIndex = 8;
            this.Infoyear.Text = "label2";
            // 
            // VolumeMax
            // 
            this.VolumeMax.BackColor = System.Drawing.Color.Transparent;
            this.VolumeMax.BackgroundImage = global::HappyMaster.Properties.Resources.maxvolue;
            this.VolumeMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeMax.Location = new System.Drawing.Point(321, 267);
            this.VolumeMax.Name = "VolumeMax";
            this.VolumeMax.Size = new System.Drawing.Size(25, 25);
            this.VolumeMax.TabIndex = 7;
            this.VolumeMax.TabStop = false;
            // 
            // VolumeMin
            // 
            this.VolumeMin.BackColor = System.Drawing.Color.Transparent;
            this.VolumeMin.BackgroundImage = global::HappyMaster.Properties.Resources.minvolue;
            this.VolumeMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeMin.Location = new System.Drawing.Point(4, 267);
            this.VolumeMin.Name = "VolumeMin";
            this.VolumeMin.Size = new System.Drawing.Size(25, 25);
            this.VolumeMin.TabIndex = 6;
            this.VolumeMin.TabStop = false;
            // 
            // VolumeMaster
            // 
            this.VolumeMaster.BackColor = System.Drawing.Color.Transparent;
            this.VolumeMaster.DM_BackColor = System.Drawing.Color.Transparent;
            this.VolumeMaster.DM_BlockColor = System.Drawing.Color.LightGray;
            this.VolumeMaster.DM_BufferColor = System.Drawing.Color.Empty;
            this.VolumeMaster.DM_BufferValue = 0D;
            this.VolumeMaster.DM_DrawRound = true;
            this.VolumeMaster.Dm_OperationModel = DMSkin.Controls.DMProgressBar.OperationModel.Slide;
            this.VolumeMaster.DM_RoundColor = System.Drawing.Color.Silver;
            this.VolumeMaster.DM_RoundSize = 10;
            this.VolumeMaster.DM_RoundX = 2;
            this.VolumeMaster.DM_RoundY = 7;
            this.VolumeMaster.DM_Value = 0D;
            this.VolumeMaster.Location = new System.Drawing.Point(34, 267);
            this.VolumeMaster.Name = "VolumeMaster";
            this.VolumeMaster.Size = new System.Drawing.Size(285, 25);
            this.VolumeMaster.TabIndex = 5;
            this.VolumeMaster.Text = "dmProgressBar1";
            this.VolumeMaster.Click += new System.EventHandler(this.VolumeMaster_Click);
            // 
            // OpenSetting
            // 
            this.OpenSetting.BackColor = System.Drawing.Color.Transparent;
            this.OpenSetting.BackgroundImage = global::HappyMaster.Properties.Resources.Setting;
            this.OpenSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenSetting.Location = new System.Drawing.Point(293, 313);
            this.OpenSetting.Name = "OpenSetting";
            this.OpenSetting.Size = new System.Drawing.Size(50, 50);
            this.OpenSetting.TabIndex = 4;
            this.OpenSetting.TabStop = false;
            this.OpenSetting.Click += new System.EventHandler(this.OpenSetting_Click);
            // 
            // Infoartist
            // 
            this.Infoartist.AutoSize = true;
            this.Infoartist.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Infoartist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Infoartist.Location = new System.Drawing.Point(110, 72);
            this.Infoartist.Name = "Infoartist";
            this.Infoartist.Size = new System.Drawing.Size(46, 20);
            this.Infoartist.TabIndex = 3;
            this.Infoartist.Text = "label2";
            // 
            // Infoablum
            // 
            this.Infoablum.AutoSize = true;
            this.Infoablum.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Infoablum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Infoablum.Location = new System.Drawing.Point(107, 43);
            this.Infoablum.Name = "Infoablum";
            this.Infoablum.Size = new System.Drawing.Size(52, 21);
            this.Infoablum.TabIndex = 2;
            this.Infoablum.Text = "label1";
            // 
            // InfoTitle
            // 
            this.InfoTitle.AutoSize = true;
            this.InfoTitle.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoTitle.Location = new System.Drawing.Point(106, 12);
            this.InfoTitle.Name = "InfoTitle";
            this.InfoTitle.Size = new System.Drawing.Size(62, 27);
            this.InfoTitle.TabIndex = 1;
            this.InfoTitle.Text = "label1";
            // 
            // InfoPicture
            // 
            this.InfoPicture.BackColor = System.Drawing.Color.Transparent;
            this.InfoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoPicture.Location = new System.Drawing.Point(4, 13);
            this.InfoPicture.Name = "InfoPicture";
            this.InfoPicture.Size = new System.Drawing.Size(100, 100);
            this.InfoPicture.TabIndex = 0;
            this.InfoPicture.TabStop = false;
            this.InfoPicture.Visible = false;
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::HappyMaster.Properties.Resources.media_play1;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(380, 26);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 40);
            this.Player.TabIndex = 18;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            this.Player.MouseLeave += new System.EventHandler(this.Player_MouseLeave);
            this.Player.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Player_MouseMove);
            // 
            // PlayControlsBG
            // 
            this.PlayControlsBG.BackColor = System.Drawing.Color.Transparent;
            this.PlayControlsBG.BackgroundImage = global::HappyMaster.Properties.Resources.playerbg;
            this.PlayControlsBG.Controls.Add(this.List);
            this.PlayControlsBG.Controls.Add(this.Player);
            this.PlayControlsBG.Controls.Add(this.More);
            this.PlayControlsBG.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.PlayControlsBG.DownBack = null;
            this.PlayControlsBG.Location = new System.Drawing.Point(-11, 424);
            this.PlayControlsBG.MouseBack = null;
            this.PlayControlsBG.Name = "PlayControlsBG";
            this.PlayControlsBG.NormlBack = null;
            this.PlayControlsBG.Size = new System.Drawing.Size(835, 77);
            this.PlayControlsBG.TabIndex = 19;
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.Transparent;
            this.PlayList.BackgroundImage = global::HappyMaster.Properties.Resources.playerbg;
            this.PlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayList.Controls.Add(this.ShowMessageBox);
            this.PlayList.Controls.Add(this.CloseListBox);
            this.PlayList.Controls.Add(this.ListBoxMusicList);
            this.PlayList.Location = new System.Drawing.Point(7, 26);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(798, 389);
            this.PlayList.TabIndex = 14;
            this.PlayList.Visible = false;
            // 
            // ListBoxMusicList
            // 
            this.ListBoxMusicList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBoxMusicList.FormattingEnabled = true;
            this.ListBoxMusicList.ItemHeight = 19;
            this.ListBoxMusicList.Location = new System.Drawing.Point(3, 111);
            this.ListBoxMusicList.Name = "ListBoxMusicList";
            this.ListBoxMusicList.Size = new System.Drawing.Size(792, 251);
            this.ListBoxMusicList.TabIndex = 0;
            this.ListBoxMusicList.SelectedIndexChanged += new System.EventHandler(this.ListBoxMusicList_SelectedIndexChanged);
            this.ListBoxMusicList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusicList_MouseDoubleClick);
            // 
            // CloseListBox
            // 
            this.CloseListBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseListBox.Location = new System.Drawing.Point(8, 5);
            this.CloseListBox.Name = "CloseListBox";
            this.CloseListBox.Size = new System.Drawing.Size(30, 27);
            this.CloseListBox.TabIndex = 1;
            this.CloseListBox.Click += new System.EventHandler(this.CloseListBox_Click);
            // 
            // ShowMessageBox
            // 
            this.ShowMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowMessageBox.DM_Color = System.Drawing.Color.White;
            this.ShowMessageBox.DM_Font_Size = 18F;
            this.ShowMessageBox.DM_Key = DMSkin.Controls.DMLabelKey.回形针;
            this.ShowMessageBox.DM_Text = "";
            this.ShowMessageBox.Location = new System.Drawing.Point(765, 11);
            this.ShowMessageBox.Name = "ShowMessageBox";
            this.ShowMessageBox.Size = new System.Drawing.Size(30, 30);
            this.ShowMessageBox.TabIndex = 2;
            this.ShowMessageBox.Click += new System.EventHandler(this.ShowMessageBox_Click);
            // 
            // AppViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(812, 497);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.PlayControlsBG);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximization);
            this.Controls.Add(this.CloseViewer);
            this.DM_BackPalace = global::HappyMaster.Properties.Resources._248922_106;
            this.DM_CanResize = true;
            this.DM_howBorder = false;
            this.DM_Radius = 1;
            this.DM_ShowDrawIcon = false;
            this.Name = "AppViewer";
            this.RoundStyle = DMSkin.SkinClass.RoundStyle.None;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppViewer_FormClosing);
            this.Load += new System.EventHandler(this.AppViewer_Load);
            this.Resize += new System.EventHandler(this.AppViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.CloseViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.More)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncoderShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPViewerShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.PlayControlsBG.ResumeLayout(false);
            this.PlayList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseViewer;
        private System.Windows.Forms.PictureBox Maximization;
        private System.Windows.Forms.PictureBox Minimize;
        private CCWin.SkinControl.SkinLabel TotalTime;
        private CCWin.SkinControl.SkinLabel ThisTime;
        private System.Windows.Forms.Timer Position;
        private CCWin.SkinControl.SkinPictureBox AlbumViewer;
        private CCWin.SkinControl.SkinPictureBox More;
        private CCWin.SkinControl.SkinPictureBox List;
        private CCWin.SkinControl.SkinLabel textBoxTitle;
        private CCWin.SkinControl.SkinLabel textBoxArtist;
        private CCWin.SkinControl.SkinPanel Panel1;
        private DMSkin.Metro.Controls.MetroTrackBar Pos;
        private CCWin.SkinControl.SkinPanel Panel2;
        private CCWin.SkinControl.SkinPictureBox InfoPicture;
        private System.Windows.Forms.Label Infoartist;
        private System.Windows.Forms.Label Infoablum;
        private System.Windows.Forms.Label InfoTitle;
        private CCWin.SkinControl.SkinPictureBox OpenSetting;
        private CCWin.SkinControl.SkinPictureBox Player;
        private DMSkin.Controls.DMProgressBar VolumeMaster;
        private CCWin.SkinControl.SkinPictureBox VolumeMax;
        private CCWin.SkinControl.SkinPictureBox VolumeMin;
        private CCWin.SkinControl.SkinPanel PlayControlsBG;
        private System.Windows.Forms.Label Infoyear;
        private System.Windows.Forms.PictureBox pictureBoxSpectrum;
        public System.Windows.Forms.Timer ChangeBG;
        private DMSkin.MetroDMButton LoadPicture;
        private CCWin.SkinControl.SkinPictureBox OpenFile;
        private CCWin.SkinControl.SkinPictureBox DSPViewerShow;
        private CCWin.SkinControl.SkinPictureBox EncoderShow;
        private System.Windows.Forms.Panel PlayList;
        private System.Windows.Forms.ListBox ListBoxMusicList;
        private DMSkin.Controls.DMButtonMinLight CloseListBox;
        private DMSkin.Controls.DMLabel ShowMessageBox;
    }
}

