using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmSampleDetails : Form
    {
        public frmSampleDetails()
        {
            InitializeComponent();
        }

        private void sampleTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sampleTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagnosticLabDataSet);

        }

        private void sampleTypeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sampleTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagnosticLabDataSet);

        }

        private void frmSampleDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.LabTestRecord' table. You can move, or remove it, as needed.
            this.labTestRecordTableAdapter.Fill(this.diagnosticLabDataSet.LabTestRecord);
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.SampleType' table. You can move, or remove it, as needed.
            this.sampleTypeTableAdapter.Fill(this.diagnosticLabDataSet.SampleType);

        }
    }
}
