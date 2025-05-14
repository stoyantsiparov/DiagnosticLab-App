using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DiagnosticLab
{
    public partial class frmByMoreParam : Form
    {
        private string connectionString =
            "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        public frmByMoreParam()
        {
            InitializeComponent();
            Load += frmByMoreParam_Load; // добавяме обработчик на събитието Load
            ApplyStyle();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchRecords();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labTestRecordDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Няма данни за експортиране.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Изберете файл за запис",
                FileName = "LabTestSearch.xlsx"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = saveDialog.FileName;

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            Excel._Worksheet worksheet;

            bool isNew = !System.IO.File.Exists(filePath);

            if (isNew)
            {
                workbook = excelApp.Workbooks.Add();
                worksheet = workbook.Sheets[1];
                worksheet.Name = "LabTestSearch";
            }
            else
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1];
            }

            int startRow = 1;

            if (isNew)
            {
                int colIndex = 1;
                foreach (DataGridViewColumn col in labTestRecordDataGridView.Columns)
                {
                    if (col.Visible)
                    {
                        worksheet.Cells[startRow, colIndex] = col.HeaderText;
                        colIndex++;
                    }
                }
                startRow++;
            }
            else
            {
                while (worksheet.Cells[startRow, 1].Value != null)
                    startRow++;
            }

            for (int i = 0; i < labTestRecordDataGridView.Rows.Count; i++)
            {
                int colIndex = 1;
                for (int j = 0; j < labTestRecordDataGridView.Columns.Count; j++)
                {
                    if (labTestRecordDataGridView.Columns[j].Visible)
                    {
                        var value = labTestRecordDataGridView.Rows[i].Cells[j].Value;
                        worksheet.Cells[startRow + i, colIndex] = value?.ToString();
                        colIndex++;
                    }
                }
            }

            worksheet.Columns.AutoFit();

            if (isNew)
                workbook.SaveAs(filePath);
            else
                workbook.Save();

            workbook.Close(false);
            excelApp.Quit();

            MessageBox.Show("Данните са успешно експортирани в Excel.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPatientName.Clear();

            comboTechnician.SelectedIndex = -1;
            comboTestType.SelectedIndex = -1;
            comboSampleType.SelectedIndex = -1;

            dateFrom.Value = DateTime.Now.AddMonths(-1);
            dateTo.Value = DateTime.Now.AddMonths(1);

            SearchRecords();
        }

        private void frmByMoreParam_Load(object sender, EventArgs e)
        {
            LoadFilters();
            SearchRecords();
        }

        private void LoadFilters()
        {
            // Technician
            using (var da = new SqlDataAdapter(
                       "SELECT TechnicianID, FirstName + ' ' + LastName AS FullName FROM Technician", connectionString))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboTechnician.DataSource = dt;
                comboTechnician.DisplayMember = "FullName";
                comboTechnician.ValueMember = "TechnicianID";
                comboTechnician.SelectedIndex = -1;
            }

            // TestType
            using (var da = new SqlDataAdapter("SELECT TestTypeID, Name FROM TestType", connectionString))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboTestType.DataSource = dt;
                comboTestType.DisplayMember = "Name";
                comboTestType.ValueMember = "TestTypeID";
                comboTestType.SelectedIndex = -1;
            }

            // SampleType
            using (var da = new SqlDataAdapter("SELECT SampleTypeID, Description FROM SampleType", connectionString))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboSampleType.DataSource = dt;
                comboSampleType.DisplayMember = "Description";
                comboSampleType.ValueMember = "SampleTypeID";
                comboSampleType.SelectedIndex = -1;
            }

            // Дати по подразбиране
            dateFrom.Value = DateTime.Now.AddMonths(-1);
            dateTo.Value = DateTime.Now.AddMonths(1);
        }

        private void SearchRecords()
        {
            string query = @"
        SELECT 
            l.LabTestID,
            l.PatientName,
            l.TestDate,
            t.Name AS TestType,
            tech.FirstName + ' ' + tech.LastName AS Technician,
            s.Description AS Sample,
            l.FinalPrice,
            l.ResultSummary
        FROM LabTestRecord l
        JOIN TestType t ON l.TestTypeID = t.TestTypeID
        JOIN Technician tech ON l.TechnicianID = tech.TechnicianID
        JOIN SampleType s ON l.SampleTypeID = s.SampleTypeID
        WHERE 1=1";

            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                query += " AND l.PatientName LIKE @name";
                parameters.Add(new SqlParameter("@name", "%" + txtPatientName.Text.Trim() + "%"));
            }

            if (comboTechnician.SelectedIndex != -1)
            {
                query += " AND l.TechnicianID = @techID";
                parameters.Add(new SqlParameter("@techID", comboTechnician.SelectedValue));
            }

            if (comboTestType.SelectedIndex != -1)
            {
                query += " AND l.TestTypeID = @testID";
                parameters.Add(new SqlParameter("@testID", comboTestType.SelectedValue));
            }

            if (comboSampleType.SelectedIndex != -1)
            {
                query += " AND l.SampleTypeID = @sampleID";
                parameters.Add(new SqlParameter("@sampleID", comboSampleType.SelectedValue));
            }

            query += " AND l.TestDate BETWEEN @from AND @to";
            parameters.Add(new SqlParameter("@from", dateFrom.Value.Date));
            parameters.Add(new SqlParameter("@to", dateTo.Value.Date));

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddRange(parameters.ToArray());

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                labTestRecordDataGridView.DataSource = dt;
            }

            labTestRecordDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

                    case ComboBox cmb:
                        cmb.Font = new Font("Segoe UI", 9);
                        break;

                    case TextBox tb:
                        tb.Font = new Font("Segoe UI", 9);
                        break;

                    case DateTimePicker dtp:
                        dtp.Font = new Font("Segoe UI", 9);
                        break;
                }
            }

            labTestRecordDataGridView.EnableHeadersVisualStyles = false;
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#129990");
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labTestRecordDataGridView.DefaultCellStyle.BackColor = Color.White;
            labTestRecordDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
    }
}