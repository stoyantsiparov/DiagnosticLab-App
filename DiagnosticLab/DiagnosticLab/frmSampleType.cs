using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmSampleType : Form
    {
        public frmSampleType()
        {
            InitializeComponent();
        }

        private void frmSampleType_Load(object sender, EventArgs e)
        {
            this.sampleTypeBindingSource.AddNew();

        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text.Trim();
            string storageTemp = storageTemperatureTextBox.Text.Trim();
            string containerType = containerTypeTextBox.Text.Trim();

            int maxHoldingTimeHrs;
            bool isValidTime = int.TryParse(maxHoldingTimeHrsTextBox.Text.Trim(), out maxHoldingTimeHrs);

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Моля, въведете описание на пробата.", "Валидиране", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isValidTime)
            {
                MessageBox.Show("Моля, въведете валидна стойност за максимално време за съхранение (в часове).", "Валидиране", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SampleType_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@StorageTemperature", string.IsNullOrEmpty(storageTemp) ? DBNull.Value : (object)storageTemp);
                cmd.Parameters.AddWithValue("@MaxHoldingTimeHrs", maxHoldingTimeHrs);
                cmd.Parameters.AddWithValue("@ContainerType", string.IsNullOrEmpty(containerType) ? DBNull.Value : (object)containerType);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Нов тип проба е добавен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Изчистване на полетата
            descriptionTextBox.Clear();
            storageTemperatureTextBox.Clear();
            maxHoldingTimeHrsTextBox.Clear();
            containerTypeTextBox.Clear();
            descriptionTextBox.Focus();
        }
    }
}