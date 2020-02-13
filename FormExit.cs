using System;
using ComponentFactory.Krypton.Toolkit;

namespace MatchingHelper
{
    public partial class FormExit : KryptonForm
    {
        public FormExit()
        {
            InitializeComponent();
        }

        private void FormExit_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Environment.Exit(0);
        }
    }
}
