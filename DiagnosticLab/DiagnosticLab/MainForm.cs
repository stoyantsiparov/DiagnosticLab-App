using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the MainForm class and applies the initial style.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            ApplyStyle(ColorTranslator.FromHtml("#129990"));
        }

        /// <summary>
        /// Opens the Test Type form as an MDI child.
        /// </summary>
        private void testTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTestType();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the Technician form as an MDI child.
        /// </summary>
        private void technicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTechnician();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the Sample Type form as an MDI child.
        /// </summary>
        private void sampleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSampleType();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the Test Type List form as an MDI child.
        /// </summary>
        private void testTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frm = new frmTestTypeList();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the Technician List form as an MDI child.
        /// </summary>
        private void technicianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmTechnicianList();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the Sample Type List form as an MDI child.
        /// </summary>
        private void sampleTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmSampleTypeList();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the Lab Test Record form as an MDI child.
        /// </summary>
        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmLabTestRecord();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the By One Parameter form as an MDI child.
        /// </summary>
        private void byOneParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmByOneParam();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Opens the By More Parameters form as an MDI child.
        /// </summary>
        private void byMoreParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmByMoreParam();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Applies the specified color style to the form and its controls.
        /// </summary>
        /// <param name="color">The color to apply to the MDI client area.</param>
        private void ApplyStyle(Color color)
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFBDE");
            this.IsMdiContainer = true;

            foreach (Control ctrl in this.Controls)
            {
                switch (ctrl)
                {
                    case Label lbl:
                        lbl.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                        lbl.ForeColor = ColorTranslator.FromHtml("#096B68");
                        break;

                    case MenuStrip menu:
                        menu.BackColor = ColorTranslator.FromHtml("#FFFBDE");
                        menu.ForeColor = Color.Black;
                        menu.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        break;
                }
            }

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient client)
                {
                    client.BackColor = color;
                    break;
                }
            }
        }
    }
}