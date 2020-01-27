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
            button1.Size = new Size(this.Size.Width / 3, 38);
            button1.Location = new Point(0, 0);
            button2.Size = new Size(this.Size.Width / 3, 38);
            button2.Location = new Point(this.Size.Width / 3, 0);
            button3.Size = new Size(this.Size.Width / 3, 38);
            button3.Location = new Point(2 * this.Size.Width / 3, 0);

            button1.Text = Properties.Settings.Default.R_6Name+" (F6)";
            button2.Text = Properties.Settings.Default.R_7Name+" (F7)";
            button3.Text = Properties.Settings.Default.R_8Name+" (F8)";

            



        }
    }
}
