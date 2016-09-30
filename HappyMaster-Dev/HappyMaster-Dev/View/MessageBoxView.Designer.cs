namespace HappyMaster_Dev.View
{
    partial class MessageBoxView
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
            this.labelOK = new CCWin.SkinControl.SkinLabel();
            this.labelCancel = new CCWin.SkinControl.SkinLabel();
            this.Title = new CCWin.SkinControl.SkinLabel();
            this.info = new CCWin.SkinControl.SkinLabel();
            this.LoadMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.ShowView = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelOK
            // 
            this.labelOK.AutoSize = true;
            this.labelOK.BackColor = System.Drawing.Color.Transparent;
            this.labelOK.BorderColor = System.Drawing.Color.Transparent;
            this.labelOK.Font = new System.Drawing.Font(".萍方-简", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelOK.Location = new System.Drawing.Point(61, 162);
            this.labelOK.Name = "labelOK";
            this.labelOK.Size = new System.Drawing.Size(60, 41);
            this.labelOK.TabIndex = 0;
            this.labelOK.Text = "OK";
            this.labelOK.Click += new System.EventHandler(this.labelOK_Click);
            // 
            // labelCancel
            // 
            this.labelCancel.AutoSize = true;
            this.labelCancel.BackColor = System.Drawing.Color.Transparent;
            this.labelCancel.BorderColor = System.Drawing.Color.Transparent;
            this.labelCancel.Font = new System.Drawing.Font(".萍方-简", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCancel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCancel.Location = new System.Drawing.Point(228, 162);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(109, 41);
            this.labelCancel.TabIndex = 1;
            this.labelCancel.Text = "Cancel";
            this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(123, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(133, 38);
            this.Title.TabIndex = 2;
            this.Title.Text = "错误提示";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.BorderColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.info.ForeColor = System.Drawing.Color.Black;
            this.info.Location = new System.Drawing.Point(21, 68);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(316, 75);
            this.info.TabIndex = 3;
            this.info.Text = "无法进行播放，判断为无文件写入，\r\n无法创建流，请检查是否正确加载\r\n音频文件(｡˘•ε•˘｡)";
            // 
            // LoadMediaFile
            // 
            this.LoadMediaFile.Title = "HappyMaster-打开音频文件";
            // 
            // ShowView
            // 
            this.ShowView.Interval = 2000;
            this.ShowView.Tick += new System.EventHandler(this.Show_Tick);
            // 
            // MessageBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.Alert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 207);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.labelCancel);
            this.Controls.Add(this.labelOK);
            //this.DM_DropBack = false;
            this.DM_howBorder = false;
            //this.DM_ShowDrawIcon = false;
            this.Name = "MessageBoxView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MessageBoxView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel labelOK;
        private CCWin.SkinControl.SkinLabel labelCancel;
        private CCWin.SkinControl.SkinLabel Title;
        private CCWin.SkinControl.SkinLabel info;
        public System.Windows.Forms.OpenFileDialog LoadMediaFile;
        private System.Windows.Forms.Timer ShowView;
    }
}