using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmSampleType : Form
    {
        /// <summary>
        /// Initializes a new instance of the frmSampleType form and applies the style.
        /// </summary>
        public frmSampleType()
        {
            InitializeComponent();
            ApplyStyle();
        }

        /// <summary>
        /// Handles the Load event of the frmSampleType form. Adds a new item to the binding source.
        /// </summary>
        private void frmSampleType_Load(object sender, EventArgs e)
        {
            this.sampleTypeBindingSource.AddNew();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// Handles the Click event of the button1 control. Validates input and inserts a new sample type into the database.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text.Trim();
            string storageTemp = storageTemperatureTextBox.Text.Trim();
            string containerType = containerTypeTextBox.Text.Trim();

            int maxHoldingTimeHrs;
            bool isValidTime = int.TryParse(maxHoldingTimeHrsTextBox.Text.Trim(), out maxHoldingTimeHrs);

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter a sample description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isValidTime)
            {
                MessageBox.Show("Please enter a valid value for maximum retention time (in hours).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MessageBox.Show("New sample type added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            descriptionTextBox.Clear();
            storageTemperatureTextBox.Clear();
            maxHoldingTimeHrsTextBox.Clear();
            containerTypeTextBox.Clear();
            descriptionTextBox.Focus();
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