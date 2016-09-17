namespace DownMaster
{
    partial class Form1
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
            this.urlTextbox = new DMSkin.Metro.Controls.MetroTextBox();
            this.FilenameText = new DMSkin.Metro.Controls.MetroTextBox();
            this.metroLabel1 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel2 = new DMSkin.Metro.Controls.MetroLabel();
            this.downProgress = new DMSkin.Metro.Controls.MetroProgressBar();
            this.btnDown = new DMSkin.MetroDMButton();
            this.btnClose = new DMSkin.MetroDMButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // urlTextbox
            // 
            this.urlTextbox.DM_UseSelectable = true;
            this.urlTextbox.Lines = new string[0];
            this.urlTextbox.Location = new System.Drawing.Point(92, 69);
            this.urlTextbox.MaxLength = 32767;
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.PasswordChar = '\0';
            this.urlTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlTextbox.SelectedText = "";
            this.urlTextbox.Size = new System.Drawing.Size(354, 23);
            this.urlTextbox.TabIndex = 1;
            // 
            // FilenameText
            // 
            this.FilenameText.DM_UseSelectable = true;
            this.FilenameText.Lines = new string[0];
            this.FilenameText.Location = new System.Drawing.Point(92, 98);
            this.FilenameText.MaxLength = 32767;
            this.FilenameText.Name = "FilenameText";
            this.FilenameText.PasswordChar = '\0';
            this.FilenameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilenameText.SelectedText = "";
            this.FilenameText.Size = new System.Drawing.Size(273, 23);
            this.FilenameText.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "下载地址：";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "保存为：";
            // 
            // downProgress
            // 
            this.downProgress.Location = new System.Drawing.Point(7, 178);
            this.downProgress.Name = "downProgress";
            this.downProgress.Size = new System.Drawing.Size(439, 23);
            this.downProgress.TabIndex = 5;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.DownImage = global::DownMaster.Properties.Resources.MineButtonPress;
            this.btnDown.Image = null;
            this.btnDown.IsShowBorder = false;
            this.btnDown.Location = new System.Drawing.Point(372, 93);
            this.btnDown.MoveImage = global::DownMaster.Properties.Resources.MineButtonENTER;
            this.btnDown.Name = "btnDown";
            this.btnDown.NormalImage = global::DownMaster.Properties.Resources.MineButtonNOMRMAL;
            this.btnDown.Size = new System.Drawing.Size(75, 34);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "下载";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            this.btnDown.MouseEnter += new System.EventHandler(this.btnDown_MouseEnter);
            this.btnDown.MouseLeave += new System.EventHandler(this.btnDown_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DownImage = global::DownMaster.Properties.Resources.buttonClosePRESS;
            this.btnClose.Image = null;
            this.btnClose.IsShowBorder = false;
            this.btnClose.Location = new System.Drawing.Point(7, 5);
            this.btnClose.MoveImage = global::DownMaster.Properties.Resources.buttonCloseENTER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalImage = global::DownMaster.Properties.Resources.buttonCloseNORMAL;
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 218);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.downProgress);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.FilenameText);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.btnClose);
            this.DM_howBorder = false;
            this.DM_ShowDrawIcon = false;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.MetroDMButton btnClose;
        private DMSkin.Metro.Controls.MetroTextBox urlTextbox;
        private DMSkin.Metro.Controls.MetroTextBox FilenameText;
        private DMSkin.Metro.Controls.MetroLabel metroLabel1;
        private DMSkin.Metro.Controls.MetroLabel metroLabel2;
        private DMSkin.Metro.Controls.MetroProgressBar downProgress;
        private DMSkin.MetroDMButton btnDown;
        private System.Windows.Forms.Timer timer1;
    }
}

