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
    public partial class frmSampleType : Form
    {
        public frmSampleType()
        {
            InitializeComponent();
        }

        private void sampleTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sampleTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagnosticLabDataSet);

        }

        private void frmSampleType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.SampleType' table. You can move, or remove it, as needed.
            this.sampleTypeTableAdapter.Fill(this.diagnosticLabDataSet.SampleType);

        }
    }
}
