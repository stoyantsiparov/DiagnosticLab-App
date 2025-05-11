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
    public partial class frmTestType : Form
    {
        public frmTestType()
        {
            InitializeComponent();
        }

        private void testTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagnosticLabDataSet);

        }

        private void frmTestType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.TestType' table. You can move, or remove it, as needed.
            this.testTypeTableAdapter.Fill(this.diagnosticLabDataSet.TestType);

        }
    }
}
