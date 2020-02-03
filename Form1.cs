using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedAndDistance
{
    public partial class fom_rename : Form
    {
        public fom_rename()
        {
            InitializeComponent();
        }

        private void fom_rename_Load(object sender, EventArgs e)
        {
            textBoxR6.Text = Properties.Settings.Default.R_6Name;
            textBoxR7.Text = Properties.Settings.Default.R_7Name;
            textBoxR8.Text = Properties.Settings.Default.R_8Name;
            checkBox1.Checked= Properties.Settings.Default.R6dis_on_speed;
            checkBox2.Checked = Properties.Settings.Default.R7dis_on_speed;
            checkBox3.Checked = Properties.Settings.Default.R8dis_on_speed;


        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.R_6Name = textBoxR6.Text;
            Properties.Settings.Default.R_7Name = textBoxR7.Text;
            Properties.Settings.Default.R_8Name = textBoxR8.Text;
            Properties.Settings.Default.R6dis_on_speed = checkBox1.Checked;
            Properties.Settings.Default.R7dis_on_speed = checkBox2.Checked;
            Properties.Settings.Default.R8dis_on_speed = checkBox3.Checked;

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
