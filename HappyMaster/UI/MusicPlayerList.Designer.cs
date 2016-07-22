namespace HappyMaster.UI
{
    partial class MusicPlayerList
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
            this.CloseList = new DMSkin.Controls.DMButtonMinLight();
            this.addFile = new CCWin.SkinControl.SkinPictureBox();
            this.DeletFile = new CCWin.SkinControl.SkinPictureBox();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.PlaySelect = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySelect)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseList
            // 
            this.CloseList.BackColor = System.Drawing.Color.Transparent;
            this.CloseList.Location = new System.Drawing.Point(7, 4);
            this.CloseList.Name = "CloseList";
            this.CloseList.Size = new System.Drawing.Size(30, 27);
            this.CloseList.TabIndex = 0;
            this.CloseList.Click += new System.EventHandler(this.CloseList_Click);
            // 
            // addFile
            // 
            this.addFile.BackColor = System.Drawing.Color.Transparent;
            this.addFile.BackgroundImage = global::HappyMaster.Properties.Resources.download_L;
            this.addFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addFile.Location = new System.Drawing.Point(7, 364);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(30, 30);
            this.addFile.TabIndex = 2;
            this.addFile.TabStop = false;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // DeletFile
            // 
            this.DeletFile.BackColor = System.Drawing.Color.Transparent;
            this.DeletFile.BackgroundImage = global::HappyMaster.Properties.Resources.trash_L;
            this.DeletFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletFile.Location = new System.Drawing.Point(561, 367);
            this.DeletFile.Name = "DeletFile";
            this.DeletFile.Size = new System.Drawing.Size(30, 30);
            this.DeletFile.TabIndex = 3;
            this.DeletFile.TabStop = false;
            this.DeletFile.Click += new System.EventHandler(this.DeletFile_Click);
            // 
            // PlayList
            // 
            this.PlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayList.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayList.FormattingEnabled = true;
            this.PlayList.ItemHeight = 25;
            this.PlayList.Location = new System.Drawing.Point(7, 37);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(579, 325);
            this.PlayList.TabIndex = 4;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.PlayList_SelectedIndexChanged);
            // 
            // PlaySelect
            // 
            this.PlaySelect.BackColor = System.Drawing.Color.Transparent;
            this.PlaySelect.BackgroundImage = global::HappyMaster.Properties.Resources.player;
            this.PlaySelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlaySelect.Location = new System.Drawing.Point(279, 364);
            this.PlaySelect.Name = "PlaySelect";
            this.PlaySelect.Size = new System.Drawing.Size(30, 30);
            this.PlaySelect.TabIndex = 5;
            this.PlaySelect.TabStop = false;
            this.PlaySelect.Click += new System.EventHandler(this.PlaySelect_Click);
            // 
            // MusicPlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 399);
            this.Controls.Add(this.PlaySelect);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.DeletFile);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.CloseList);
            this.DM_Back = global::HappyMaster.Properties.Resources.ListBG;
            this.DM_CanResize = true;
            this.DM_howBorder = false;
            this.DM_Radius = 1;
            this.DM_ShowDrawIcon = false;
            this.Name = "MusicPlayerList";
            this.RoundStyle = DMSkin.SkinClass.RoundStyle.None;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MusicPlayerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Controls.DMButtonMinLight CloseList;
        private CCWin.SkinControl.SkinPictureBox addFile;
        private CCWin.SkinControl.SkinPictureBox DeletFile;
        private System.Windows.Forms.ListBox PlayList;
        private CCWin.SkinControl.SkinPictureBox PlaySelect;
    }
}