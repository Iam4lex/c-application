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
    public partial class frmSubjectAllocation : Form
    {
        public frmSubjectAllocation()
        {
            InitializeComponent();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }
    }
}
