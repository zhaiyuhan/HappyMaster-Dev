namespace HappyMaster_Dev.View
{
    partial class InfoMessageBoxView
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
            this.CloseView = new System.Windows.Forms.Timer(this.components);
            this.setLabel = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // CloseView
            // 
            this.CloseView.Interval = 1000;
            this.CloseView.Tick += new System.EventHandler(this.CloseView_Tick);
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.BackColor = System.Drawing.Color.Transparent;
            this.setLabel.BorderColor = System.Drawing.Color.Transparent;
            this.setLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.setLabel.Location = new System.Drawing.Point(16, 55);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(311, 21);
            this.setLabel.TabIndex = 0;
            this.setLabel.Text = "专辑图片高斯模糊处理设置成功ヽ(•̀ω•́ )ゝ";
            // 
            // InfoMessageBoxView
            // 
            this.AlphaGauss = 1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyMaster_Dev.Properties.Resources.glassBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(351, 125);
            this.Controls.Add(this.setLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoMessageBoxView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "提示信息";
            this.Load += new System.EventHandler(this.InfoMessageBoxView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer CloseView;
        private CCWin.SkinControl.SkinLabel setLabel;
    }
}