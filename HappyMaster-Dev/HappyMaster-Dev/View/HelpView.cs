using System;
using Un4seen.Bass;
namespace HappyMaster_Dev.View
{
    public partial class HelpView : DMSkin.Main
    {
        public HelpView()
        {
            InitializeComponent();
        }

        private void HelpView_Load(object sender, EventArgs e)
        {

        }
        private void dmButtonClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Linker_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            switch (TextBoxInfo.Visible)
            {
                case true:
                    TextBoxInfo.Visible = false;
                    break;
                case false:
                    TextBoxInfo.Visible = true;
                    break;
            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            BassNet.ShowAbout(new System.Windows.Forms.Form());
        }
    }
}
