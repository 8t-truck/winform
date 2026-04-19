namespace Project1_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = (int.Parse(lblDisplay.Text) + 1).ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrClock.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrClock.Stop();
        }
    }
}
