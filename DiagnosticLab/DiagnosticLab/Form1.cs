using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the Form1 class and applies the custom style.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ApplyStyle();
        }

        private string connectionString =
            "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// Handles the save operation for the technician binding navigator.
        /// Validates the form, ends edit mode, and updates all changes to the dataset.
        /// </summary>
        private void technicianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.technicianBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagnosticLabDataSet);
        }

        /// <summary>
        /// Handles the Form1 load event.
        /// Fills the dataset tables for sample types, test types, lab test records, and technicians.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.sampleTypeTableAdapter.Fill(this.diagnosticLabDataSet.SampleType);
            this.testTypeTableAdapter.Fill(this.diagnosticLabDataSet.TestType);
            this.labTestRecordTableAdapter.Fill(this.diagnosticLabDataSet.LabTestRecord);
            this.technicianTableAdapter.Fill(this.diagnosticLabDataSet.Technician);
        }

        /// <summary>
        /// Applies custom styles to the form and its controls, including colors and fonts.
        /// Also styles the DataGridView headers and cells.
        /// </summary>
        private void ApplyStyle()
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFBDE");

            foreach (Control ctrl in this.Controls)
            {
                switch (ctrl)
                {
                    case Label lbl:
                        lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        lbl.ForeColor = ColorTranslator.FromHtml("#096B68");
                        break;
                    case Button btn:
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = ColorTranslator.FromHtml("#90D1CA");
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("Segoe UI", 10);
                        btn.Cursor = Cursors.Hand;
                        break;
                    case ComboBox cmb:
                        cmb.Font = new Font("Segoe UI", 9);
                        break;
                    case TextBox tb:
                        tb.Font = new Font("Segoe UI", 9);
                        break;
                    case DateTimePicker dtp:
                        dtp.Font = new Font("Segoe UI", 9);
                        break;
                }
            }

            labTestRecordDataGridView.EnableHeadersVisualStyles = false;
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#129990");
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labTestRecordDataGridView.DefaultCellStyle.BackColor = Color.White;
            labTestRecordDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
    }
}