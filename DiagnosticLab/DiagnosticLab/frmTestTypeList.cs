using System;
using System.Data;
using System.Data.SqlClient;
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

        private void frmTestTypeList_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
        }

        private void testTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && testTypeDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Потвърждение от потребителя
                var confirm = MessageBox.Show("Сигурни ли сте, че искате да изтриете този запис?",
                    "Потвърждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    // Вземане на ID от избрания ред
                    int testTypeId = Convert.ToInt32(testTypeDataGridView.Rows[e.RowIndex].Cells[0].Value);

                    // Извикване на процедурата
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_TestType_Delete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TestTypeID", testTypeId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    // Обновяване на данните в грида
                    LoadTestTypes();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testTypeDataGridView.CurrentRow != null)
            {
                // Вземане на стойности от текущо избрания ред
                int testTypeId = Convert.ToInt32(testTypeDataGridView.CurrentRow.Cells[0].Value);
                string name = testTypeDataGridView.CurrentRow.Cells[1].Value.ToString();
                decimal basePrice = Convert.ToDecimal(testTypeDataGridView.CurrentRow.Cells[2].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_TestType_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Параметри за процедурата
                    cmd.Parameters.AddWithValue("@TestTypeID", testTypeId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@BasePrice", basePrice);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Записът е успешно обновен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTestTypes();
            }
            else
            {
                MessageBox.Show("Няма избран ред за запис.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
    }
}