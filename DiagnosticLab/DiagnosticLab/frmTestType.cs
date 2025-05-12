using System;
using System.Data;
using System.Data.SqlClient;
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
            // TODO: This line of code loads data into the 'diagnosticLabDataSet.LabTestRecord' table. You can move, or remove it, as needed.
            this.testTypeTableAdapter.Fill(this.diagnosticLabDataSet.TestType);
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";


        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (!decimal.TryParse(basePriceTextBox.Text.Trim(), out decimal basePrice))
            {
                MessageBox.Show("Моля, въведете валидна стойност за базова цена.", "Валидиране", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Моля, въведете име на теста.", "Валидиране", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_TestType_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@BasePrice", basePrice);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Нов тестов тип е добавен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Изчистване на полетата за нов запис
            nameTextBox.Clear();
            basePriceTextBox.Clear();
            nameTextBox.Focus(); // Поставя курсора отново в полето за име
        }
    }
}