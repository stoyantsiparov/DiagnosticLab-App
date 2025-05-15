using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmLabTestRecord : Form
    {
        private string connectionString =
            "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// Initializes a new instance of the frmLabTestRecord form.
        /// </summary>
        public frmLabTestRecord()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the form load event. Loads combo boxes, lab test records, applies style, and sets up event handlers.
        /// </summary>
        private void frmLabTestRecord_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadLabTestRecords();
            ApplyStyle();
            testTypeIDComboBox.SelectedIndexChanged += TestTypeIDComboBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Loads all lab test records from the database and configures DataGridView columns.
        /// </summary>
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

        /// <summary>
        /// Configures DataGridView ComboBox columns for Technician, TestType, and SampleType.
        /// </summary>
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

        /// <summary>
        /// Loads data for Technician, TestType, and SampleType combo boxes.
        /// </summary>
        private void LoadComboBoxes()
        {
            var techDt = GetTechnicianTable();
            technicianIDComboBox.DataSource = techDt;
            technicianIDComboBox.DisplayMember = "FullName";
            technicianIDComboBox.ValueMember = "TechnicianID";
            technicianIDComboBox.SelectedIndex = -1;

            var testDt = GetTestTypeTable();
            testTypeIDComboBox.DataSource = testDt;
            testTypeIDComboBox.DisplayMember = "Name";
            testTypeIDComboBox.ValueMember = "TestTypeID";
            testTypeIDComboBox.SelectedIndex = -1;

            var sampleDt = GetSampleTypeTable();
            sampleTypeIDComboBox.DataSource = sampleDt;
            sampleTypeIDComboBox.DisplayMember = "Description";
            sampleTypeIDComboBox.ValueMember = "SampleTypeID";
            sampleTypeIDComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Retrieves the technician table from the database.
        /// </summary>
        /// <returns>DataTable containing technician information.</returns>
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

        /// <summary>
        /// Retrieves the test type table from the database.
        /// </summary>
        /// <returns>DataTable containing test type information.</returns>
        private DataTable GetTestTypeTable()
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter("SELECT TestTypeID, Name FROM TestType", connectionString))
            {
                da.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// Retrieves the sample type table from the database.
        /// </summary>
        /// <returns>DataTable containing sample type information.</returns>
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

        /// <summary>
        /// Handles the click event for the add button. Inserts a new lab test record into the database.
        /// </summary>
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
            MessageBox.Show("The record was added successfully.");
        }

        /// <summary>
        /// Handles the cell click event for the DataGridView, including deleting records.
        /// </summary>
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

        /// <summary>
        /// Handles the click event for the update button. Updates or inserts lab test records from the DataGridView.
        /// </summary>
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
            MessageBox.Show("The records have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the click event for the clear button. Clears all input fields and resets controls.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            patientNameTextBox.Clear();
            finalPriceTextBox.Clear();
            resultSummaryTextBox.Clear();
            testTypeIDComboBox.SelectedIndex = -1;
            technicianIDComboBox.SelectedIndex = -1;
            sampleTypeIDComboBox.SelectedIndex = -1;
            testDateDateTimePicker.Value = DateTime.Now;
            patientNameTextBox.Focus();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event for the test type combo box. Sets the final price based on the selected test type.
        /// </summary>
        private void TestTypeIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testTypeIDComboBox.SelectedValue == null || testTypeIDComboBox.SelectedIndex == -1)
                return;

            int selectedTestTypeID = Convert.ToInt32(testTypeIDComboBox.SelectedValue);

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT BasePrice FROM TestType WHERE TestTypeID = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", selectedTestTypeID);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null && decimal.TryParse(result.ToString(), out decimal basePrice))
                {
                    decimal finalPrice = basePrice * 1.20m;
                    finalPriceTextBox.Text = finalPrice.ToString("0.00");
                }
            }
        }

        /// <summary>
        /// Applies custom styles to the form and its controls.
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