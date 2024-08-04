namespace KonataIzumi
{
    public partial class Main : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private int scalingFactor = 50;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.music;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);

            if (startStopMusic.Text == "Start")
            {
                snd.Play();
                startStopMusic.Text = "Stop";
            }
            else
            {
                snd.Stop();
                startStopMusic.Text = "Start";
            }
        }

        private void alwaysOnTopToggle_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                alwaysOnTopToggle.Text = "Enable";
            }
            else
            {
                this.TopMost = true;
                alwaysOnTopToggle.Text = "Disable";
            }
        }

        private void sizeIncrease_Click(object sender, EventArgs e)
        {
            this.ClientSize = new Size(this.Size.Width + scalingFactor, this.Size.Height + scalingFactor);
        }

        private void sizeDecrease_Click(object sender, EventArgs e)
        {
            this.ClientSize = new Size(this.Size.Width - scalingFactor, this.Size.Height - scalingFactor);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made with <3 by aqeuus aka https://github.com/scrillex0995");
        }
    }
}
