namespace HappyMaster.UI
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.CloseSetting = new CCWin.SkinControl.SkinPictureBox();
            this.skinPictureBox2 = new CCWin.SkinControl.SkinPictureBox();
            this.Minimize = new CCWin.SkinControl.SkinPictureBox();
            this.HelpShow = new DMSkin.MetroDMButton();
            this.FlowLayoutPanel = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.Apply = new DMSkin.MetroDMButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tomPanel1 = new TSkin.TOMPanel();
            this.LoadPicture = new DMSkin.MetroDMButton();
            this.Effect1 = new DMSkin.MetroDMButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutShow = new DMSkin.MetroDMButton();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.FlowLayoutPanel.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseSetting
            // 
            this.CloseSetting.BackColor = System.Drawing.Color.Transparent;
            this.CloseSetting.BackgroundImage = global::HappyMaster.Properties.Resources.CloseR;
            this.CloseSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseSetting.Location = new System.Drawing.Point(20, 13);
            this.CloseSetting.Name = "CloseSetting";
            this.CloseSetting.Size = new System.Drawing.Size(18, 18);
            this.CloseSetting.TabIndex = 0;
            this.CloseSetting.TabStop = false;
            this.CloseSetting.Click += new System.EventHandler(this.CloseSetting_Click);
            // 
            // skinPictureBox2
            // 
            this.skinPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox2.BackgroundImage = global::HappyMaster.Properties.Resources.MaximizationR;
            this.skinPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPictureBox2.Location = new System.Drawing.Point(44, 13);
            this.skinPictureBox2.Name = "skinPictureBox2";
            this.skinPictureBox2.Size = new System.Drawing.Size(18, 18);
            this.skinPictureBox2.TabIndex = 1;
            this.skinPictureBox2.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::HappyMaster.Properties.Resources.MinimizeR;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Location = new System.Drawing.Point(70, 13);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(18, 18);
            this.Minimize.TabIndex = 2;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // HelpShow
            // 
            this.HelpShow.BackColor = System.Drawing.Color.Transparent;
            this.HelpShow.DownImage = global::HappyMaster.Properties.Resources.button5;
            this.HelpShow.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpShow.ForeColor = System.Drawing.Color.Gray;
            this.HelpShow.Image = global::HappyMaster.Properties.Resources.button1;
            this.HelpShow.IsShowBorder = false;
            this.HelpShow.Location = new System.Drawing.Point(16, 313);
            this.HelpShow.MoveImage = ((System.Drawing.Image)(resources.GetObject("HelpShow.MoveImage")));
            this.HelpShow.Name = "HelpShow";
            this.HelpShow.NormalImage = global::HappyMaster.Properties.Resources.button1;
            this.HelpShow.Size = new System.Drawing.Size(87, 35);
            this.HelpShow.TabIndex = 3;
            this.HelpShow.Text = "Help";
            this.HelpShow.UseVisualStyleBackColor = false;
            this.HelpShow.Click += new System.EventHandler(this.HelpShow_Click);
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.AutoSize = true;
            this.FlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel.Controls.Add(this.skinPanel1);
            this.FlowLayoutPanel.Controls.Add(this.panel1);
            this.FlowLayoutPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.FlowLayoutPanel.DownBack = null;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(8, 53);
            this.FlowLayoutPanel.MouseBack = null;
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.NormlBack = null;
            this.FlowLayoutPanel.Size = new System.Drawing.Size(719, 357);
            this.FlowLayoutPanel.TabIndex = 5;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.Apply);
            this.skinPanel1.Controls.Add(this.numericUpDown);
            this.skinPanel1.Controls.Add(this.tomPanel1);
            this.skinPanel1.Controls.Add(this.LoadPicture);
            this.skinPanel1.Controls.Add(this.Effect1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(3, 3);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(591, 348);
            this.skinPanel1.TabIndex = 11;
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.Transparent;
            this.Apply.DownImage = global::HappyMaster.Properties.Resources.button5;
            this.Apply.Font = new System.Drawing.Font("方正兰亭超细黑简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Apply.ForeColor = System.Drawing.Color.Gray;
            this.Apply.Image = global::HappyMaster.Properties.Resources.button1;
            this.Apply.IsShowBorder = false;
            this.Apply.Location = new System.Drawing.Point(462, 310);
            this.Apply.MoveImage = ((System.Drawing.Image)(resources.GetObject("Apply.MoveImage")));
            this.Apply.Name = "Apply";
            this.Apply.NormalImage = global::HappyMaster.Properties.Resources.button1;
            this.Apply.Size = new System.Drawing.Size(87, 35);
            this.Apply.TabIndex = 15;
            this.Apply.Text = "应用更改";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(459, 89);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown.TabIndex = 14;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged_1);
            // 
            // tomPanel1
            // 
            this.tomPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tomPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tomPanel1.Gauss = 1;
            this.tomPanel1.Image = null;
            this.tomPanel1.IsGauss = false;
            this.tomPanel1.Location = new System.Drawing.Point(3, 3);
            this.tomPanel1.Name = "tomPanel1";
            this.tomPanel1.Size = new System.Drawing.Size(453, 342);
            this.tomPanel1.TabIndex = 13;
            // 
            // LoadPicture
            // 
            this.LoadPicture.BackColor = System.Drawing.Color.Transparent;
            this.LoadPicture.DownImage = global::HappyMaster.Properties.Resources.button5;
            this.LoadPicture.Font = new System.Drawing.Font("方正兰亭超细黑简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoadPicture.ForeColor = System.Drawing.Color.Gray;
            this.LoadPicture.Image = global::HappyMaster.Properties.Resources.button1;
            this.LoadPicture.IsShowBorder = false;
            this.LoadPicture.Location = new System.Drawing.Point(459, 7);
            this.LoadPicture.MoveImage = ((System.Drawing.Image)(resources.GetObject("LoadPicture.MoveImage")));
            this.LoadPicture.Name = "LoadPicture";
            this.LoadPicture.NormalImage = global::HappyMaster.Properties.Resources.button1;
            this.LoadPicture.Size = new System.Drawing.Size(87, 35);
            this.LoadPicture.TabIndex = 8;
            this.LoadPicture.Text = "更改背景";
            this.LoadPicture.UseVisualStyleBackColor = false;
            this.LoadPicture.Click += new System.EventHandler(this.LoadPicture_Click);
            // 
            // Effect1
            // 
            this.Effect1.BackColor = System.Drawing.Color.Transparent;
            this.Effect1.DownImage = global::HappyMaster.Properties.Resources.button5;
            this.Effect1.Font = new System.Drawing.Font("方正兰亭超细黑简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Effect1.ForeColor = System.Drawing.Color.Gray;
            this.Effect1.Image = global::HappyMaster.Properties.Resources.button1;
            this.Effect1.IsShowBorder = false;
            this.Effect1.Location = new System.Drawing.Point(459, 48);
            this.Effect1.MoveImage = ((System.Drawing.Image)(resources.GetObject("Effect1.MoveImage")));
            this.Effect1.Name = "Effect1";
            this.Effect1.NormalImage = global::HappyMaster.Properties.Resources.button1;
            this.Effect1.Size = new System.Drawing.Size(87, 35);
            this.Effect1.TabIndex = 11;
            this.Effect1.Text = "高斯模糊";
            this.Effect1.UseVisualStyleBackColor = false;
            this.Effect1.Click += new System.EventHandler(this.Effect1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelpShow);
            this.panel1.Location = new System.Drawing.Point(600, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 351);
            this.panel1.TabIndex = 9;
            // 
            // AboutShow
            // 
            this.AboutShow.BackColor = System.Drawing.Color.Transparent;
            this.AboutShow.DownImage = global::HappyMaster.Properties.Resources.button5;
            this.AboutShow.Font = new System.Drawing.Font("方正兰亭超细黑简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutShow.ForeColor = System.Drawing.Color.Gray;
            this.AboutShow.Image = global::HappyMaster.Properties.Resources.button1;
            this.AboutShow.IsShowBorder = false;
            this.AboutShow.Location = new System.Drawing.Point(628, 12);
            this.AboutShow.MoveImage = ((System.Drawing.Image)(resources.GetObject("AboutShow.MoveImage")));
            this.AboutShow.Name = "AboutShow";
            this.AboutShow.NormalImage = global::HappyMaster.Properties.Resources.button1;
            this.AboutShow.Size = new System.Drawing.Size(87, 35);
            this.AboutShow.TabIndex = 5;
            this.AboutShow.Text = "About";
            this.AboutShow.UseVisualStyleBackColor = false;
            this.AboutShow.Click += new System.EventHandler(this.AboutShow_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 414);
            this.Controls.Add(this.AboutShow);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.skinPictureBox2);
            this.Controls.Add(this.CloseSetting);
            this.DM_ShowDrawIcon = false;
            this.DoubleBuffered = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(731, 414);
            this.MinimumSize = new System.Drawing.Size(731, 414);
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.FlowLayoutPanel.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox CloseSetting;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox2;
        private CCWin.SkinControl.SkinPictureBox Minimize;
        private DMSkin.MetroDMButton HelpShow;
        private CCWin.SkinControl.SkinFlowLayoutPanel FlowLayoutPanel;
        private DMSkin.MetroDMButton AboutShow;
        private DMSkin.MetroDMButton LoadPicture;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private DMSkin.MetroDMButton Effect1;
        private TSkin.TOMPanel tomPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private DMSkin.MetroDMButton Apply;
    }
}