using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmSampleDetails : Form
    {
        public frmSampleDetails()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

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
            // Зареждане на SampleType (Master)
            this.sampleTypeTableAdapter.Fill(this.diagnosticLabDataSet.SampleType);

            // Зареждане на TestType
            this.testTypeTableAdapter.Fill(this.diagnosticLabDataSet.TestType);

            // Зареждане на LabTestRecord (Detail)
            this.labTestRecordTableAdapter.Fill(this.diagnosticLabDataSet.LabTestRecord);

            // Зареждане на Technician с FullName
            DataTable technicianTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Technician", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                conn.Open();
                adapter.Fill(technicianTable);
            }

            technicianTable.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            technicianBindingSource.DataSource = technicianTable;

            // Свързване на technicianComboBoxColumn
            if (labTestRecordDataGridView.Columns["technicianComboBoxColumn"] is DataGridViewComboBoxColumn technicianColumn)
            {
                technicianColumn.DataSource = technicianBindingSource;
                technicianColumn.DisplayMember = "FullName";
                technicianColumn.ValueMember = "TechnicianID";
                technicianColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }

            // Свързване на testTypeComboBoxColumn
            testTypeBindingSource.DataSource = diagnosticLabDataSet.TestType;
            if (labTestRecordDataGridView.Columns["testTypeComboBoxColumn"] is DataGridViewComboBoxColumn testTypeColumn)
            {
                testTypeColumn.DataSource = testTypeBindingSource;
                testTypeColumn.DisplayMember = "Name";
                testTypeColumn.ValueMember = "TestTypeID";
                testTypeColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
        }
    }
}