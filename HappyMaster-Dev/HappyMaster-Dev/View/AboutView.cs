using System;
using System.Windows.Forms;

namespace HappyMaster_Dev.View
{
    public partial class AboutView : DMSkin.Main
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void AboutView_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutView_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainView.ifAboutViewOpen = false;
        }
    }
}
