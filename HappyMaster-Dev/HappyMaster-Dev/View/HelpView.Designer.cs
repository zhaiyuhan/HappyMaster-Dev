namespace HappyMaster_Dev.View
{
    partial class HelpView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpView));
            this.dmButtonClose1 = new DMSkin.Controls.DMButtonClose();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroLabel1 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel2 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel3 = new DMSkin.Metro.Controls.MetroLabel();
            this.Linker = new System.Windows.Forms.LinkLabel();
            this.TextBoxInfo = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // dmButtonClose1
            // 
            this.dmButtonClose1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonClose1.Location = new System.Drawing.Point(523, 0);
            this.dmButtonClose1.MaximumSize = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.MinimumSize = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.Name = "dmButtonClose1";
            this.dmButtonClose1.Size = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.TabIndex = 0;
            this.dmButtonClose1.Click += new System.EventHandler(this.dmButtonClose1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(8, 10);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(104, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "关于HappyMaster";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "HappyMaster Beta4Final";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "版本号 0.4.6.8";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "© 2016 HAODA";
            // 
            // Linker
            // 
            this.Linker.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.Linker.AutoSize = true;
            this.Linker.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Linker.LinkColor = System.Drawing.Color.DodgerBlue;
            this.Linker.Location = new System.Drawing.Point(472, 323);
            this.Linker.Name = "Linker";
            this.Linker.Size = new System.Drawing.Size(72, 16);
            this.Linker.TabIndex = 6;
            this.Linker.TabStop = true;
            this.Linker.Text = "许可条款";
            this.Linker.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linker_LinkClicked);
            // 
            // TextBoxInfo
            // 
            this.TextBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxInfo.DownBack = null;
            this.TextBoxInfo.Icon = null;
            this.TextBoxInfo.IconIsButton = false;
            this.TextBoxInfo.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBoxInfo.IsPasswordChat = '\0';
            this.TextBoxInfo.IsSystemPasswordChar = false;
            this.TextBoxInfo.Lines = new string[] {
        "HappyMaster由翟长腿编写，开源分享用于交流学习，",
        "请使用学习者尊重原作者劳动成果。",
        "本程序主要用于播放音频文件，使用BASS.NET.dll",
        "BASS.NET不可用于商用，如果抵触BASS.NET条款，一切后果自负",
        "本作者概不负责",
        "此外界面使用DMSkin和CSkin，感谢两位原作者的分享",
        "如果用于商用请向原作者小江或乔克斯获得允许",
        "一切都应遵守道德和法律",
        "发扬开源精神               ",
        "                                                                                 " +
            "        2016.9.16 款"};
            this.TextBoxInfo.Location = new System.Drawing.Point(8, 138);
            this.TextBoxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxInfo.MaxLength = 32767;
            this.TextBoxInfo.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextBoxInfo.MouseBack = null;
            this.TextBoxInfo.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBoxInfo.Multiline = true;
            this.TextBoxInfo.Name = "TextBoxInfo";
            this.TextBoxInfo.NormlBack = null;
            this.TextBoxInfo.Padding = new System.Windows.Forms.Padding(5);
            this.TextBoxInfo.ReadOnly = false;
            this.TextBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxInfo.Size = new System.Drawing.Size(461, 201);
            // 
            // 
            // 
            this.TextBoxInfo.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInfo.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxInfo.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.TextBoxInfo.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextBoxInfo.SkinTxt.Multiline = true;
            this.TextBoxInfo.SkinTxt.Name = "BaseText";
            this.TextBoxInfo.SkinTxt.Size = new System.Drawing.Size(451, 191);
            this.TextBoxInfo.SkinTxt.TabIndex = 0;
            this.TextBoxInfo.SkinTxt.Text = resources.GetString("resource.Text");
            this.TextBoxInfo.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBoxInfo.SkinTxt.WaterText = "";
            this.TextBoxInfo.TabIndex = 7;
            this.TextBoxInfo.Text = resources.GetString("TextBoxInfo.Text");
            this.TextBoxInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxInfo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBoxInfo.WaterText = "";
            this.TextBoxInfo.WordWrap = true;
            // 
            // HelpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 343);
            this.Controls.Add(this.TextBoxInfo);
            this.Controls.Add(this.Linker);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.dmButtonClose1);
            this.DM_DropBack = false;
            this.DM_ShowDrawIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HelpView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.Controls.DMButtonClose dmButtonClose1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private DMSkin.Metro.Controls.MetroLabel metroLabel1;
        private DMSkin.Metro.Controls.MetroLabel metroLabel2;
        private DMSkin.Metro.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.LinkLabel Linker;
        private CCWin.SkinControl.SkinTextBox TextBoxInfo;
    }
}