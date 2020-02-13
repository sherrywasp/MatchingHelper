using ComponentFactory.Krypton.Toolkit;

namespace MatchingHelper
{
    public partial class FormWritingDone : KryptonForm
    {
        public FormWritingDone()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.timer1.Stop();
            this.Hide();
        }

        private void FormWritingDone_Load(object sender, System.EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
