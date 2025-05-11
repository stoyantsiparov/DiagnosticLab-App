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
    public partial class frmTechnicianList : Form
    {
        public frmTechnicianList()
        {
            InitializeComponent();
        }

        private void technicianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.technicianBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diagnosticLabDataSet);

        }

        private void frmTechnicianList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.diagnosticLabDataSet.Technician);

        }
    }
}
