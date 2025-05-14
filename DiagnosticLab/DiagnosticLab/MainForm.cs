using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // Максимизиране на прозореца
            ApplyStyle();
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

        private void ApplyStyle()
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFBDE");
            this.IsMdiContainer = true; // За поддръжка на MDI стил

            foreach (Control ctrl in this.Controls)
            {
                switch (ctrl)
                {
                    case Label lbl:
                        lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        lbl.ForeColor = ColorTranslator.FromHtml("#096B68");
                        break;

                    case MenuStrip menu:
                        menu.BackColor = ColorTranslator.FromHtml("#90D1CA");
                        menu.ForeColor = Color.Black;
                        menu.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        break;
                }
            }
        }
    }
}