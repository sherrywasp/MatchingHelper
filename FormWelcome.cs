using System;
using ComponentFactory.Krypton.Toolkit;

namespace MatchingHelper
{
    public partial class FormWelcome : KryptonForm
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            FormMain frmMain = new FormMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
