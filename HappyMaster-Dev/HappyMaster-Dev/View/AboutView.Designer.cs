namespace HappyMaster_Dev.View
{
    partial class AboutView
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
            this.btnClose = new DMSkin.MetroDMButton();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DownImage = global::HappyMaster_Dev.Properties.Resources.buttonClosePRESS;
            this.btnClose.Image = null;
            this.btnClose.IsShowBorder = false;
            this.btnClose.Location = new System.Drawing.Point(7, 8);
            this.btnClose.MoveImage = global::HappyMaster_Dev.Properties.Resources.buttonCloseENTER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalImage = global::HappyMaster_Dev.Properties.Resources.buttonCloseNORMAL;
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.AboutViewBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.btnClose);
            this.DM_howBorder = false;
            this.DM_Radius = 8;
            this.DM_ShowDrawIcon = false;
            this.DM_SkinOpacity = 0.8D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutView_FormClosing);
            this.Load += new System.EventHandler(this.AboutView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.MetroDMButton btnClose;
    }
}