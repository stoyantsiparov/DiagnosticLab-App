using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ApplyStyle();
        }

        private void technicianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.technicianBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagnosticLabDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.SampleType' table. You can move, or remove it, as needed.
            this.sampleTypeTableAdapter.Fill(this.diagnosticLabDataSet.SampleType);
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.TestType' table. You can move, or remove it, as needed.
            this.testTypeTableAdapter.Fill(this.diagnosticLabDataSet.TestType);
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.LabTestRecord' table. You can move, or remove it, as needed.
            this.labTestRecordTableAdapter.Fill(this.diagnosticLabDataSet.LabTestRecord);
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.diagnosticLabDataSet.Technician);

        }

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
