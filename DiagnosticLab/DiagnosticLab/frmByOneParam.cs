using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DiagnosticLab
{
    public partial class frmByOneParam : Form
    {
        private string connectionString =
            "Data Source=OMEN\\SQLEXPRESS;Initial Catalog=DiagnosticLab;Integrated Security=True;TrustServerCertificate=True";

        public frmByOneParam()
        {
            InitializeComponent();
            Load += frmByOneParam_Load; // добавяме обработчик на събитието Load
            ApplyStyle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Моля, въведете дума за търсене.");
                return;
            }

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"
                SELECT 
                    l.LabTestID,
                    l.PatientName,
                    l.TestDate,
                    l.TestTypeID,
                    l.TechnicianID,
                    l.SampleTypeID,
                    t.Name AS TestType,
                    tech.FirstName + ' ' + tech.LastName AS Technician,
                    s.Description AS Sample,
                    l.FinalPrice,
                    l.ResultSummary
                FROM LabTestRecord l
                JOIN TestType t ON l.TestTypeID = t.TestTypeID
                JOIN Technician tech ON l.TechnicianID = tech.TechnicianID
                JOIN SampleType s ON l.SampleTypeID = s.SampleTypeID
                WHERE
                    l.PatientName LIKE @kw OR
                    l.ResultSummary LIKE @kw OR
                    t.Name LIKE @kw OR
                    tech.FirstName LIKE @kw OR
                    tech.LastName LIKE @kw OR
                    s.Description LIKE @kw
            ", con))
            {
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                labTestRecordDataGridView.DataSource = dt;
            }

            HideTechnicalColumns();
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
                FileName = "LabTestRecords.xlsx"
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
                worksheet.Name = "LabTestRecords";
            }
            else
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1];
            }

            int startRow = 1;

            // Записваме заглавия само ако е нов файл
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
                // Намираме първия празен ред
                while (worksheet.Cells[startRow, 1].Value != null)
                    startRow++;
            }

            // Запис на данни
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

            // Запазваме САМО ако файлът е нов
            if (isNew)
            {
                workbook.SaveAs(filePath);
            }
            else
            {
                workbook.Save();
            }

            workbook.Close(false);
            excelApp.Quit();

            MessageBox.Show("Данните бяха успешно добавени към Excel файла.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadAllLabTestRecords();
        }

        private void frmByOneParam_Load(object sender, EventArgs e)
        {
            LoadAllLabTestRecords(); // зарежда всички данни при отваряне
        }

        private void HideTechnicalColumns()
        {
            string[] hiddenCols = { "LabTestID", "TestTypeID", "TechnicianID", "SampleTypeID" };
            foreach (string col in hiddenCols)
            {
                if (labTestRecordDataGridView.Columns.Contains(col))
                    labTestRecordDataGridView.Columns[col].Visible = false;
            }

            labTestRecordDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadAllLabTestRecords()
        {
            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"
                SELECT 
                    l.LabTestID,
                    l.PatientName,
                    l.TestDate,
                    l.TestTypeID,
                    l.TechnicianID,
                    l.SampleTypeID,
                    t.Name AS TestType,
                    tech.FirstName + ' ' + tech.LastName AS Technician,
                    s.Description AS Sample,
                    l.FinalPrice,
                    l.ResultSummary
                FROM LabTestRecord l
                JOIN TestType t ON l.TestTypeID = t.TestTypeID
                JOIN Technician tech ON l.TechnicianID = tech.TechnicianID
                JOIN SampleType s ON l.SampleTypeID = s.SampleTypeID
            ", con))
            {
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                labTestRecordDataGridView.DataSource = dt;
            }

            HideTechnicalColumns();
        }

        private void ApplyStyle()
        {
            // Основен фон на формата
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
                }
            }

            // Стилизация на DataGridView
            labTestRecordDataGridView.EnableHeadersVisualStyles = false;
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#129990");
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            labTestRecordDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labTestRecordDataGridView.DefaultCellStyle.BackColor = Color.White;
            labTestRecordDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
    }
}