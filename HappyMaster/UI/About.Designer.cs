namespace HappyMaster.UI
{
    partial class About
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
            this.CloseAbout = new DMSkin.Controls.DMButtonCloseLight();
            this.Title = new CCWin.SkinControl.SkinLabel();
            this.HAODA = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // CloseAbout
            // 
            this.CloseAbout.BackColor = System.Drawing.Color.Transparent;
            this.CloseAbout.Location = new System.Drawing.Point(0, 0);
            this.CloseAbout.MaximumSize = new System.Drawing.Size(30, 27);
            this.CloseAbout.MinimumSize = new System.Drawing.Size(30, 27);
            this.CloseAbout.Name = "CloseAbout";
            this.CloseAbout.Size = new System.Drawing.Size(30, 27);
            this.CloseAbout.TabIndex = 0;
            this.CloseAbout.Click += new System.EventHandler(this.CloseAbout_Click);
            // 
            // Title
            // 
            this.Title.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Forme;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("方正兰亭超细黑简体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(60, 68);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(243, 35);
            this.Title.TabIndex = 1;
            this.Title.Text = "Happy Master";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // HAODA
            // 
            this.HAODA.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Forme;
            this.HAODA.AutoSize = true;
            this.HAODA.BackColor = System.Drawing.Color.Transparent;
            this.HAODA.BorderColor = System.Drawing.Color.Transparent;
            this.HAODA.Font = new System.Drawing.Font("方正兰亭超细黑简体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HAODA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HAODA.Location = new System.Drawing.Point(128, 237);
            this.HAODA.Name = "HAODA";
            this.HAODA.Size = new System.Drawing.Size(119, 54);
            this.HAODA.TabIndex = 2;
            this.HAODA.Text = "HAO DA\r\n   2016";
            // 
            // About
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(377, 511);
            this.Controls.Add(this.HAODA);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CloseAbout);
            this.DM_BackPalace = global::HappyMaster.Properties.Resources.About;
            this.DM_DropBack = false;
            this.DM_howBorder = false;
            this.DM_Radius = 1;
            this.DM_ShowDrawIcon = false;
            this.MaximizeBox = false;
            this.Name = "About";
            this.RoundStyle = DMSkin.SkinClass.RoundStyle.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.Controls.DMButtonCloseLight CloseAbout;
        private CCWin.SkinControl.SkinLabel Title;
        private CCWin.SkinControl.SkinLabel HAODA;
    }
}