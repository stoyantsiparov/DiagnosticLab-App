using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmSampleTypeList : Form
    {
        public frmSampleTypeList()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        private void frmSampleTypeList_Load(object sender, EventArgs e)
        {
            LoadSampleTypes();
        }

        private void sampleTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sampleTypeDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Сигурни ли сте, че искате да изтриете този запис?",
                    "Потвърждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    int sampleTypeId = Convert.ToInt32(sampleTypeDataGridView.Rows[e.RowIndex].Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_SampleType_Delete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SampleTypeID", sampleTypeId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    LoadSampleTypes();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sampleTypeDataGridView.CurrentRow != null)
            {
                int sampleTypeId = Convert.ToInt32(sampleTypeDataGridView.CurrentRow.Cells[0].Value);
                string description = sampleTypeDataGridView.CurrentRow.Cells[1].Value.ToString();
                string storageTemp = sampleTypeDataGridView.CurrentRow.Cells[2].Value?.ToString();
                int maxHoldTime = Convert.ToInt32(sampleTypeDataGridView.CurrentRow.Cells[3].Value);
                string containerType = sampleTypeDataGridView.CurrentRow.Cells[4].Value?.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_SampleType_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SampleTypeID", sampleTypeId);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@StorageTemperature", string.IsNullOrEmpty(storageTemp) ? DBNull.Value : (object)storageTemp);
                    cmd.Parameters.AddWithValue("@MaxHoldingTimeHrs", maxHoldTime);
                    cmd.Parameters.AddWithValue("@ContainerType", string.IsNullOrEmpty(containerType) ? DBNull.Value : (object)containerType);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Записът е успешно обновен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSampleTypes();
            }
            else
            {
                MessageBox.Show("Няма избран ред за запис.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadSampleTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SampleType_Select", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                adapter.Fill(dt);
            }

            sampleTypeDataGridView.DataSource = dt;
        }
    }
}