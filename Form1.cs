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
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.R_6Name = textBoxR6.Text;
            Properties.Settings.Default.R_7Name = textBoxR7.Text;
            Properties.Settings.Default.R_8Name = textBoxR8.Text;
            this.Close();
        }
    }
}
