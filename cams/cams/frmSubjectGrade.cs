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
    public partial class frmSubjectGrade : Form
    {
        public frmSubjectGrade()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void frmSubjectGrade_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("Are you sure you want to Reset ? ", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
              if (result == DialogResult.OK)
              {
                  txtCredits.Text = "";
                  txtDepartmentId.Text = "";
                  txtDepId.Text = "";
                  txtDescriprion.Text = "";
                  txtEmail.Text = "";
                  txtInstructorId.Text = "";
                  txtName.Text = "";
                  txtPhoneNumber.Text = "";
                  txtSubjectCode.Text = "";
                  txtSubjectId.Text = "";
                  txtSubjectName.Text = "";
              }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System is under maitenace, You won't be able to save now", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
