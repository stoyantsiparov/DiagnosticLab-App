using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmTestTypeList : Form
    {
        public frmTestTypeList()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// Handles the form load event. Loads test types and applies UI styles.
        /// </summary>
        private void frmTestTypeList_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
            ApplyStyle();
        }

        /// <summary>
        /// Handles cell click events in the DataGridView, including deleting a test type.
        /// </summary>
        private void testTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && testTypeDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this entry?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    int testTypeId = Convert.ToInt32(testTypeDataGridView.Rows[e.RowIndex].Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_TestType_Delete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TestTypeID", testTypeId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadTestTypes();
                }
            }
        }

        /// <summary>
        /// Handles the update button click event to update the selected test type.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (testTypeDataGridView.CurrentRow != null)
            {
                int testTypeId = Convert.ToInt32(testTypeDataGridView.CurrentRow.Cells[0].Value);
                string name = testTypeDataGridView.CurrentRow.Cells[1].Value.ToString();
                decimal basePrice = Convert.ToDecimal(testTypeDataGridView.CurrentRow.Cells[2].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_TestType_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TestTypeID", testTypeId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@BasePrice", basePrice);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("The record has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTestTypes();
            }
            else
            {
                MessageBox.Show("No recording line selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Loads test types from the database and binds them to the DataGridView.
        /// </summary>
        private void LoadTestTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_TestType_Select", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                adapter.Fill(dt);
            }

            testTypeDataGridView.DataSource = dt;
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
                }
            }

            testTypeDataGridView.EnableHeadersVisualStyles = false;
            testTypeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#129990");
            testTypeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            testTypeDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            testTypeDataGridView.DefaultCellStyle.BackColor = Color.White;
            testTypeDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
    }
}