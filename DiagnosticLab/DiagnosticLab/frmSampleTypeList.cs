﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DiagnosticLab
{
    public partial class frmSampleTypeList : Form
    {
        public frmSampleTypeList()
        {
            InitializeComponent();
            ApplyStyle();
        }

        private string connectionString = "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// Handles the form load event and loads the sample types.
        /// </summary>
        private void frmSampleTypeList_Load(object sender, EventArgs e)
        {
            LoadSampleTypes();
        }

        /// <summary>
        /// Handles cell click events in the DataGridView, specifically for deleting a sample type.
        /// </summary>
        private void sampleTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sampleTypeDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this entry?",
                    "Confirmation",
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

        /// <summary>
        /// Handles the update button click event to update the selected sample type.
        /// </summary>
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

                MessageBox.Show("The record has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSampleTypes();
            }
            else
            {
                MessageBox.Show("No recording line selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Loads the sample types from the database and binds them to the DataGridView.
        /// </summary>
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

            sampleTypeDataGridView.EnableHeadersVisualStyles = false;
            sampleTypeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#129990");
            sampleTypeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            sampleTypeDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            sampleTypeDataGridView.DefaultCellStyle.BackColor = Color.White;
            sampleTypeDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
    }
}