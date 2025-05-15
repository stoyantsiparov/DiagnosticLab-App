using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmTestType : Form
    {
        /// <summary>
        /// Initializes a new instance of the frmTestType form and applies the style.
        /// </summary>
        public frmTestType()
        {
            InitializeComponent();
            ApplyStyle();
        }

        /// <summary>
        /// Handles the Load event of the frmTestType form. Adds a new record to the binding source.
        /// </summary>
        private void frmTestType_Load(object sender, EventArgs e)
        {
            this.testTypeBindingSource.AddNew();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// Handles the Click event of the button1 control. Validates input and inserts a new test type into the database.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (!decimal.TryParse(basePriceTextBox.Text.Trim(), out decimal basePrice))
            {
                MessageBox.Show("Please enter a valid base price value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a test name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MessageBox.Show("New test type added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nameTextBox.Clear();
            basePriceTextBox.Clear();
            nameTextBox.Focus();
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

                    case TextBox tb:
                        tb.Font = new Font("Segoe UI", 9);
                        break;
                }
            }
        }
    }
}