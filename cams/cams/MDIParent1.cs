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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.MdiParent = this;
            main.Height = this.Height;
            main.Width = this.Width;
            main.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Visible = true;
                this.Dispose();
            }
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstructor inst = new frmInstructor();
            inst.MdiParent = this;
            inst.Height = this.Height;
            inst.Width = this.Width;
            inst.Visible = true;

            frmLearner learner = new frmLearner();
            learner.Dispose();

            frmMain main = new frmMain();
            main.Dispose();

            frmGrade grade = new frmGrade();
            grade.Dispose();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrade grade = new frmGrade();
            grade.Visible = true;
            grade.Height = this.Height;
            grade.Width = this.Width;
            grade.MdiParent = this;

            frmLearner learner = new frmLearner();
            learner.Dispose();

            frmMain main = new frmMain();
            main.Dispose();

            frmInstructor inst = new frmInstructor();
            inst.Dispose();
        }

        private void learnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLearner learner = new frmLearner();
            learner.Visible = true;
            learner.Height = this.Height;
            learner.Width = this.Width;
            learner.MdiParent = this;

            frmMain main = new frmMain();
            main.Dispose();

            frmInstructor inst = new frmInstructor();
            inst.Dispose();

            frmGrade grade = new frmGrade();
            grade.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmInstructor inst = new frmInstructor();
            inst.MdiParent = this;
            inst.Height = this.Height;
            inst.Width = this.Width;
            inst.Visible = true;

            frmLearner learner = new frmLearner();
            learner.Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmGrade grade = new frmGrade();
            grade.Visible = true;
            grade.Height = this.Height;
            grade.Width = this.Width;
            grade.MdiParent = this;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmLearner learner = new frmLearner();
            learner.Visible = true;
            learner.Height = this.Height;
            learner.Width = this.Width;
            learner.MdiParent = this;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Visible = true;
            main.Height = this.Height;
            main.Width = this.Height;
            main.MdiParent = this;

            frmLearner learner = new frmLearner();
            learner.Visible = false;

            frmGrade grade = new frmGrade();
            grade.Visible = false;

            frmInstructor inst = new frmInstructor();
            inst.Visible = false;
        }

        private void subjectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectDetails sub = new frmSubjectDetails();
            sub.Visible = true;
            sub.Height = this.Height;
            sub.Width = this.Width;
            sub.MdiParent = this;
        }

        private void subjectAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectAllocation form = new frmSubjectAllocation();
            form.Visible = true;
            form.Height = this.Height;
            form.Width = this.Width;
            form.MdiParent = this;
        }

        private void subjectGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectGrade grade = new frmSubjectGrade();
            grade.Visible = true;
            grade.Height = this.Height;
            grade.Width = this.Width;
            grade.MdiParent = this;
        }

        private void assessmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssessmentDetails asses = new frmAssessmentDetails();
            asses.Visible = true;
            asses.Height = this.Height;
            asses.Width = this.Width;
            asses.MdiParent = this;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.MdiParent = this;
            main.Height = this.Height;
            main.Width = this.Width;
            main.Visible = true;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmSubjectDetails sub = new frmSubjectDetails();
            sub.Visible = true;
            sub.Height = this.Height;
            sub.Width = this.Width;
            sub.MdiParent = this;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
