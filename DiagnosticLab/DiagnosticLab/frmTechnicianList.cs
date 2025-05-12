using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmTechnicianList : Form
    {
        public frmTechnicianList()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        private void frmTechnicianList_Load(object sender, EventArgs e)
        {
            LoadTechnicians();
        }

        private void technicianDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && technicianDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Сигурни ли сте, че искате да изтриете този запис?",
                    "Потвърждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    int technicianId = Convert.ToInt32(technicianDataGridView.Rows[e.RowIndex].Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_Technician_Delete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TechnicianID", technicianId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadTechnicians();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (technicianDataGridView.CurrentRow != null)
            {
                int technicianId = Convert.ToInt32(technicianDataGridView.CurrentRow.Cells[0].Value);
                string firstName = technicianDataGridView.CurrentRow.Cells[1].Value.ToString();
                string lastName = technicianDataGridView.CurrentRow.Cells[2].Value.ToString();
                string certification = technicianDataGridView.CurrentRow.Cells[3].Value?.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_Technician_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TechnicianID", technicianId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Certification", string.IsNullOrEmpty(certification) ? DBNull.Value : (object)certification);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Записът е успешно обновен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTechnicians();
            }
            else
            {
                MessageBox.Show("Няма избран ред за запис.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadTechnicians()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_Technician_Select", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                adapter.Fill(dt);
            }

            technicianDataGridView.DataSource = dt;
        }
    }
}