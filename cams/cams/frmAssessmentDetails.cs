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
    public partial class frmAssessmentDetails : Form
    {
        public frmAssessmentDetails()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System is under maitenace, You won't be able to save now", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmAssessmentDetails_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("Are you sure you want to Reset ? ", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
              if (result == DialogResult.OK)
              {
                  txtCreationDate.Text = "";
                  txtCredits.Text = "";
                  txtDepartmentId.Text = "";
                  txtDescription.Text = "";
                  txtLastUpdated.Text = "";
                  txtMaxEnrollment.Text = "";
                  txtRoomNumber.Text = "";
                  txtSemister.Text = "";
                  txtSubjectCode.Text = "";
                  txtSubjectId.Text = "";
                  txtSubjectName.Text = "";
              }

        }
    }
}
