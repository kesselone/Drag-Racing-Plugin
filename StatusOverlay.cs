using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Settings;




namespace SpeedAndDistance
{
    public partial class StatusOverlay : Form
    {
        public StatusOverlay()
        {
            InitializeComponent();
        }

        private void StatusOverlay_Load(object sender, EventArgs e)
        {
            int numbuttons = 4;

            buttonSettings.Size = new Size(this.Size.Height, this.Size.Height);
            buttonSettings.Location = new Point(0, 0);
            button1.Size = new Size((this.Size.Width-38) / numbuttons, this.Size.Height);
            button1.Location = new Point(this.Size.Height, 0);
            button2.Size = new Size((this.Size.Width - this.Size.Height) / numbuttons, this.Size.Height);
            button2.Location = new Point((this.Size.Width - this.Size.Height) / numbuttons + this.Size.Height, 0);
            button3.Size = new Size((this.Size.Width - this.Size.Height) / numbuttons, this.Size.Height);
            button3.Location = new Point(2 * (this.Size.Width - this.Size.Height) / numbuttons + this.Size.Height, 0);
            label1.Location= new Point(3 * (this.Size.Width - this.Size.Height) / numbuttons + this.Size.Height, 0);
            label2.Location = new Point(3 * (this.Size.Width - this.Size.Height) / numbuttons + this.Size.Height, 20);
            label3.Location = new Point(3 * (this.Size.Width - this.Size.Height) / numbuttons + this.Size.Height+label2.Width+50, 20);

            button1.Text = Properties.Settings.Default.R_6Name+" (F6)";
            button2.Text = Properties.Settings.Default.R_7Name+" (F7)";
            button3.Text = Properties.Settings.Default.R_8Name+" (F8)";

            
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //this must change...
            buttonSettings.Enabled = false;
            SetDistancePerRev setDistancePerRev = new SetDistancePerRev();
            setDistancePerRev.Show();
            
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            label1.Text = "Speed: " + Properties.Status.Default.speed_kph.ToString("G4") + " km/h";
            label2.Text = "Distance: " + Properties.Status.Default.distance_m.ToString("G4") + " m";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
