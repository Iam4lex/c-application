using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cams
{
    public partial class frmSplash : Form
    {
        int counter;
        public frmSplash()
        {
            InitializeComponent();
            counter = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 20;
            if (counter <= 100)
            {
                lblProgress.Text = "Progress : " + counter + "%";
                progressBar1.Value = counter;
            }

            if (counter == 100) 
            {
                frmLogin login = new frmLogin();
                login.Visible = true;
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
