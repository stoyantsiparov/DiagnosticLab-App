using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmLabTestRecord : Form
    {
        private string connectionString =
            "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        public frmLabTestRecord()
        {
            InitializeComponent();
        }

        private void frmLabTestRecord_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadLabTestRecords();
        }

        private void LoadLabTestRecords()
        {
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("sp_GetAllLabTests", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                labTestRecordDataGridView.DataSource = dt;

                ConfigureComboBoxColumns();
            }
        }

        private void ConfigureComboBoxColumns()
        {
            if (labTestRecordDataGridView.Columns["TechnicianID"] is DataGridViewComboBoxColumn techCol)
            {
                techCol.DataSource = GetTechnicianTable();
                techCol.DisplayMember = "FullName";
                techCol.ValueMember = "TechnicianID";
                techCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }

            if (labTestRecordDataGridView.Columns["TestTypeID"] is DataGridViewComboBoxColumn testCol)
            {
                testCol.DataSource = GetTestTypeTable();
                testCol.DisplayMember = "Name";
                testCol.ValueMember = "TestTypeID";
                testCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }

            if (labTestRecordDataGridView.Columns["SampleTypeID"] is DataGridViewComboBoxColumn sampleCol)
            {
                sampleCol.DataSource = GetSampleTypeTable();
                sampleCol.DisplayMember = "Description";
                sampleCol.ValueMember = "SampleTypeID";
                sampleCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
        }

        private void LoadComboBoxes()
        {
            // Technician
            var techDt = GetTechnicianTable();
            technicianIDComboBox.DataSource = techDt;
            technicianIDComboBox.DisplayMember = "FullName";
            technicianIDComboBox.ValueMember = "TechnicianID";
            technicianIDComboBox.SelectedIndex = -1;

            // TestType
            var testDt = GetTestTypeTable();
            testTypeIDComboBox.DataSource = testDt;
            testTypeIDComboBox.DisplayMember = "Name";
            testTypeIDComboBox.ValueMember = "TestTypeID";
            testTypeIDComboBox.SelectedIndex = -1;

            // SampleType
            var sampleDt = GetSampleTypeTable();
            sampleTypeIDComboBox.DataSource = sampleDt;
            sampleTypeIDComboBox.DisplayMember = "Description";
            sampleTypeIDComboBox.ValueMember = "SampleTypeID";
            sampleTypeIDComboBox.SelectedIndex = -1;
        }

        private DataTable GetTechnicianTable()
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter(
                       "SELECT TechnicianID, FirstName + ' ' + LastName AS FullName FROM Technician", connectionString))
            {
                da.Fill(dt);
            }

            return dt;
        }

        private DataTable GetTestTypeTable()
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter("SELECT TestTypeID, Name FROM TestType", connectionString))
            {
                da.Fill(dt);
            }

            return dt;
        }

        private DataTable GetSampleTypeTable()
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter(
                       "SELECT SampleTypeID, Description FROM SampleType", connectionString))
            {
                da.Fill(dt);
            }

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("sp_InsertLabTest", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PatientName", patientNameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@TestDate", testDateDateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@TestTypeID", testTypeIDComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@TechnicianID", technicianIDComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@SampleTypeID", sampleTypeIDComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@FinalPrice", decimal.Parse(finalPriceTextBox.Text.Trim()));
                cmd.Parameters.AddWithValue("@ResultSummary", resultSummaryTextBox.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            LoadLabTestRecords();
            MessageBox.Show("Записът е добавен успешно.");
        }

        private void labTestRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (labTestRecordDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                var id = labTestRecordDataGridView.Rows[e.RowIndex].Cells[0].Value;

                if (id == null || id == DBNull.Value)
                {
                    labTestRecordDataGridView.Rows.RemoveAt(e.RowIndex);
                    return;
                }

                int labTestId = Convert.ToInt32(id);

                var confirm = MessageBox.Show("Наистина ли искате да изтриете този запис?", "Потвърждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_DeleteLabTest", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LabTestID", labTestId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    LoadLabTestRecords();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in labTestRecordDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (!int.TryParse(Convert.ToString(row.Cells[3].Value), out int testTypeId)) continue;
                    if (!int.TryParse(Convert.ToString(row.Cells[4].Value), out int techId)) continue;
                    if (!int.TryParse(Convert.ToString(row.Cells[5].Value), out int sampleId)) continue;
                    if (!decimal.TryParse(Convert.ToString(row.Cells[6].Value), out decimal price)) continue;
                    if (!DateTime.TryParse(Convert.ToString(row.Cells[2].Value), out DateTime testDate)) continue;

                    string patientName = Convert.ToString(row.Cells[1].Value);
                    string resultSummary = Convert.ToString(row.Cells[7].Value);
                    object idVal = row.Cells[0].Value;

                    SqlCommand cmd;

                    if (idVal == null || idVal == DBNull.Value)
                    {
                        cmd = new SqlCommand("sp_InsertLabTest", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_UpdateLabTest", con);
                        cmd.Parameters.AddWithValue("@LabTestID", Convert.ToInt32(idVal));
                    }

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientName", patientName);
                    cmd.Parameters.AddWithValue("@TestDate", testDate);
                    cmd.Parameters.AddWithValue("@TestTypeID", testTypeId);
                    cmd.Parameters.AddWithValue("@TechnicianID", techId);
                    cmd.Parameters.AddWithValue("@SampleTypeID", sampleId);
                    cmd.Parameters.AddWithValue("@FinalPrice", price);
                    cmd.Parameters.AddWithValue("@ResultSummary", resultSummary);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }

            LoadLabTestRecords();
            MessageBox.Show("Записите са обновени успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientNameTextBox.Clear();
            finalPriceTextBox.Clear();
            resultSummaryTextBox.Clear();

            testTypeIDComboBox.SelectedIndex = -1;
            technicianIDComboBox.SelectedIndex = -1;
            sampleTypeIDComboBox.SelectedIndex = -1;

            testDateDateTimePicker.Value = DateTime.Now;

            patientNameTextBox.Focus(); // Курсорът отива в първото поле
        }
    }
}