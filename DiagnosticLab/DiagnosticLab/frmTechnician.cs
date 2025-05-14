using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmTechnician : Form
    {
        public frmTechnician()
        {
            InitializeComponent();
            ApplyStyle();
        }

        private void frmTechnician_Load(object sender, EventArgs e)
        {
            this.technicianBindingSource.AddNew();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string certification = certificationTextBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Моля, попълнете първо и фамилно име.", "Валидиране", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_Technician_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Certification", string.IsNullOrEmpty(certification) ? DBNull.Value : (object)certification);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Нов лаборант е добавен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Изчистване на полетата
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            certificationTextBox.Clear();
            firstNameTextBox.Focus();
        }

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

                    case TextBox tb:
                        tb.Font = new Font("Segoe UI", 9);
                        break;
                }
            }
        }
    }
}