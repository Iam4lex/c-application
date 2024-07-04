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
    public partial class frmInstructor : Form
    {
        public frmInstructor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInstructorCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInstructor_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will erase everithing! Are you sure you want to continue? ", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result == DialogResult.Yes)
            {
                txtInstructorCode.Text = "";
                txtSirname.Text = "";
                txtFirstName.Text = "";
                cboGender.Text = "";
                cboDesignation.Text = "";
                txtPhonenumber.Text = "";
                txtEmail.Text = "";
                txtInstructorInitials.Text = "";
                chb.Text = "";
                cboPrivirage.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInstructorCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInstructorCode.Focus();
            }

            else if (txtSirname.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSirname.Focus();
            }

            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Ensure all field are fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }

            else if (cboGender.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGender.Focus();
            }

            else if (cboDesignation.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDesignation.Focus();
            }

            else if (txtPhonenumber.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhonenumber.Focus();
            }

            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Ensure all fields are fiels", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }

            else if (txtInstructorInitials.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInstructorInitials.Focus();
            }

            else if (chb.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chb.Focus();
            }

            else if (cboPrivirage.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPrivirage.Focus();
            }

            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }

            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Ensure all fields are field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }

            else
            {
                MessageBox.Show("System is under maintenace.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will erase everithing! Are you sure you want to continue? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                txtInstructorCode.Text = "";
                txtSirname.Text = "";
                txtFirstName.Text = "";
                cboGender.Text = "";
                cboDesignation.Text = "";
                txtPhonenumber.Text = "";
                txtEmail.Text = "";
                txtInstructorInitials.Text = "";
                chb.Text = "";
                cboPrivirage.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                this.Dispose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System is under maitenance. Nothing to search yet", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
