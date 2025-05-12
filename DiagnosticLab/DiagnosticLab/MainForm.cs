using System;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void testTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTestType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void technicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTechnician();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sampleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSampleType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void testTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frm = new frmTestTypeList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void technicianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmTechnicianList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sampleTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmSampleTypeList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmLabTestRecord();
            frm.MdiParent = this;
            frm.Show();
        }

        private void byOneParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmByOneParam();
            frm.MdiParent = this;
            frm.Show();
        }

        private void byMoreParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmByMoreParam();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}