namespace DiagnosticLab
{
    partial class frmLabTestRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label testDateLabel;
            System.Windows.Forms.Label testTypeIDLabel;
            System.Windows.Forms.Label technicianIDLabel;
            System.Windows.Forms.Label sampleTypeIDLabel;
            System.Windows.Forms.Label finalPriceLabel;
            System.Windows.Forms.Label resultSummaryLabel;
            this.diagnosticLabDataSet = new DiagnosticLab.DiagnosticLabDataSet();
            this.labTestRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTestRecordTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.LabTestRecordTableAdapter();
            this.tableAdapterManager = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager();
            this.technicianTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TechnicianTableAdapter();
            this.testTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TestTypeTableAdapter();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.testDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.testTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianIDComboBox = new System.Windows.Forms.ComboBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.sampleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalPriceTextBox = new System.Windows.Forms.TextBox();
            this.resultSummaryTextBox = new System.Windows.Forms.TextBox();
            this.labTestRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TechnicianID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SampleTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sampleTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter();
            this.testTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            patientNameLabel = new System.Windows.Forms.Label();
            testDateLabel = new System.Windows.Forms.Label();
            testTypeIDLabel = new System.Windows.Forms.Label();
            technicianIDLabel = new System.Windows.Forms.Label();
            sampleTypeIDLabel = new System.Windows.Forms.Label();
            finalPriceLabel = new System.Windows.Forms.Label();
            resultSummaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(15, 111);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(91, 16);
            patientNameLabel.TabIndex = 1;
            patientNameLabel.Text = "Patient Name:";
            // 
            // testDateLabel
            // 
            testDateLabel.AutoSize = true;
            testDateLabel.Location = new System.Drawing.Point(15, 140);
            testDateLabel.Name = "testDateLabel";
            testDateLabel.Size = new System.Drawing.Size(69, 16);
            testDateLabel.TabIndex = 3;
            testDateLabel.Text = "Test Date:";
            // 
            // testTypeIDLabel
            // 
            testTypeIDLabel.AutoSize = true;
            testTypeIDLabel.Location = new System.Drawing.Point(15, 167);
            testTypeIDLabel.Name = "testTypeIDLabel";
            testTypeIDLabel.Size = new System.Drawing.Size(72, 16);
            testTypeIDLabel.TabIndex = 5;
            testTypeIDLabel.Text = "Test Type:";
            // 
            // technicianIDLabel
            // 
            technicianIDLabel.AutoSize = true;
            technicianIDLabel.Location = new System.Drawing.Point(15, 197);
            technicianIDLabel.Name = "technicianIDLabel";
            technicianIDLabel.Size = new System.Drawing.Size(116, 16);
            technicianIDLabel.TabIndex = 7;
            technicianIDLabel.Text = "Technician Name:";
            // 
            // sampleTypeIDLabel
            // 
            sampleTypeIDLabel.AutoSize = true;
            sampleTypeIDLabel.Location = new System.Drawing.Point(15, 227);
            sampleTypeIDLabel.Name = "sampleTypeIDLabel";
            sampleTypeIDLabel.Size = new System.Drawing.Size(128, 16);
            sampleTypeIDLabel.TabIndex = 9;
            sampleTypeIDLabel.Text = "Sample Description:";
            // 
            // finalPriceLabel
            // 
            finalPriceLabel.AutoSize = true;
            finalPriceLabel.Location = new System.Drawing.Point(15, 257);
            finalPriceLabel.Name = "finalPriceLabel";
            finalPriceLabel.Size = new System.Drawing.Size(73, 16);
            finalPriceLabel.TabIndex = 11;
            finalPriceLabel.Text = "Final Price:";
            // 
            // resultSummaryLabel
            // 
            resultSummaryLabel.AutoSize = true;
            resultSummaryLabel.Location = new System.Drawing.Point(15, 285);
            resultSummaryLabel.Name = "resultSummaryLabel";
            resultSummaryLabel.Size = new System.Drawing.Size(108, 16);
            resultSummaryLabel.TabIndex = 13;
            resultSummaryLabel.Text = "Result Summary:";
            // 
            // diagnosticLabDataSet
            // 
            this.diagnosticLabDataSet.DataSetName = "DiagnosticLabDataSet";
            this.diagnosticLabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labTestRecordBindingSource
            // 
            this.labTestRecordBindingSource.DataMember = "LabTestRecord";
            this.labTestRecordBindingSource.DataSource = this.diagnosticLabDataSet;
            // 
            // labTestRecordTableAdapter
            // 
            this.labTestRecordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LabTestRecordTableAdapter = this.labTestRecordTableAdapter;
            this.tableAdapterManager.SampleTypeTableAdapter = null;
            this.tableAdapterManager.TechnicianTableAdapter = this.technicianTableAdapter;
            this.tableAdapterManager.TestTypeTableAdapter = this.testTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // technicianTableAdapter
            // 
            this.technicianTableAdapter.ClearBeforeFill = true;
            // 
            // testTypeTableAdapter
            // 
            this.testTypeTableAdapter.ClearBeforeFill = true;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestRecordBindingSource, "PatientName", true));
            this.patientNameTextBox.Location = new System.Drawing.Point(215, 111);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(251, 22);
            this.patientNameTextBox.TabIndex = 2;
            // 
            // testDateDateTimePicker
            // 
            this.testDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.labTestRecordBindingSource, "TestDate", true));
            this.testDateDateTimePicker.Location = new System.Drawing.Point(215, 139);
            this.testDateDateTimePicker.Name = "testDateDateTimePicker";
            this.testDateDateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.testDateDateTimePicker.TabIndex = 4;
            // 
            // testTypeIDComboBox
            // 
            this.testTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestRecordBindingSource, "TestTypeID", true));
            this.testTypeIDComboBox.DataSource = this.testTypeBindingSource;
            this.testTypeIDComboBox.DisplayMember = "Name";
            this.testTypeIDComboBox.FormattingEnabled = true;
            this.testTypeIDComboBox.Location = new System.Drawing.Point(215, 167);
            this.testTypeIDComboBox.Name = "testTypeIDComboBox";
            this.testTypeIDComboBox.Size = new System.Drawing.Size(251, 24);
            this.testTypeIDComboBox.TabIndex = 6;
            this.testTypeIDComboBox.ValueMember = "TestTypeID";
            // 
            // testTypeBindingSource
            // 
            this.testTypeBindingSource.DataMember = "TestType";
            this.testTypeBindingSource.DataSource = this.diagnosticLabDataSet;
            // 
            // technicianIDComboBox
            // 
            this.technicianIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestRecordBindingSource, "TechnicianID", true));
            this.technicianIDComboBox.DataSource = this.technicianBindingSource;
            this.technicianIDComboBox.DisplayMember = "TechnicianID";
            this.technicianIDComboBox.FormattingEnabled = true;
            this.technicianIDComboBox.Location = new System.Drawing.Point(215, 197);
            this.technicianIDComboBox.Name = "technicianIDComboBox";
            this.technicianIDComboBox.Size = new System.Drawing.Size(251, 24);
            this.technicianIDComboBox.TabIndex = 8;
            this.technicianIDComboBox.ValueMember = "TechnicianID";
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataMember = "Technician";
            this.technicianBindingSource.DataSource = this.diagnosticLabDataSet;
            // 
            // sampleTypeIDComboBox
            // 
            this.sampleTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestRecordBindingSource, "SampleTypeID", true));
            this.sampleTypeIDComboBox.DataSource = this.sampleTypeBindingSource;
            this.sampleTypeIDComboBox.DisplayMember = "Description";
            this.sampleTypeIDComboBox.FormattingEnabled = true;
            this.sampleTypeIDComboBox.Location = new System.Drawing.Point(215, 227);
            this.sampleTypeIDComboBox.Name = "sampleTypeIDComboBox";
            this.sampleTypeIDComboBox.Size = new System.Drawing.Size(251, 24);
            this.sampleTypeIDComboBox.TabIndex = 10;
            this.sampleTypeIDComboBox.ValueMember = "SampleTypeID";
            // 
            // sampleTypeBindingSource
            // 
            this.sampleTypeBindingSource.DataMember = "SampleType";
            this.sampleTypeBindingSource.DataSource = this.diagnosticLabDataSet;
            // 
            // finalPriceTextBox
            // 
            this.finalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestRecordBindingSource, "FinalPrice", true));
            this.finalPriceTextBox.Location = new System.Drawing.Point(215, 257);
            this.finalPriceTextBox.Name = "finalPriceTextBox";
            this.finalPriceTextBox.Size = new System.Drawing.Size(251, 22);
            this.finalPriceTextBox.TabIndex = 12;
            this.finalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultSummaryTextBox
            // 
            this.resultSummaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestRecordBindingSource, "ResultSummary", true));
            this.resultSummaryTextBox.Location = new System.Drawing.Point(215, 285);
            this.resultSummaryTextBox.Name = "resultSummaryTextBox";
            this.resultSummaryTextBox.Size = new System.Drawing.Size(251, 22);
            this.resultSummaryTextBox.TabIndex = 14;
            // 
            // labTestRecordDataGridView
            // 
            this.labTestRecordDataGridView.AutoGenerateColumns = false;
            this.labTestRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.TestTypeID,
            this.TechnicianID,
            this.SampleTypeID,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Delete});
            this.labTestRecordDataGridView.DataSource = this.labTestRecordBindingSource;
            this.labTestRecordDataGridView.Location = new System.Drawing.Point(479, 111);
            this.labTestRecordDataGridView.Name = "labTestRecordDataGridView";
            this.labTestRecordDataGridView.RowHeadersWidth = 51;
            this.labTestRecordDataGridView.RowTemplate.Height = 24;
            this.labTestRecordDataGridView.Size = new System.Drawing.Size(1053, 257);
            this.labTestRecordDataGridView.TabIndex = 15;
            this.labTestRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.labTestRecordDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LabTestID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LabTestID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TestDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Test Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // TestTypeID
            // 
            this.TestTypeID.DataPropertyName = "TestTypeID";
            this.TestTypeID.DataSource = this.testTypeBindingSource;
            this.TestTypeID.DisplayMember = "Name";
            this.TestTypeID.HeaderText = "Test Type";
            this.TestTypeID.MinimumWidth = 6;
            this.TestTypeID.Name = "TestTypeID";
            this.TestTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TestTypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TestTypeID.ValueMember = "TestTypeID";
            this.TestTypeID.Width = 125;
            // 
            // TechnicianID
            // 
            this.TechnicianID.DataPropertyName = "TechnicianID";
            this.TechnicianID.DataSource = this.technicianBindingSource;
            this.TechnicianID.HeaderText = "Technician Name";
            this.TechnicianID.MinimumWidth = 6;
            this.TechnicianID.Name = "TechnicianID";
            this.TechnicianID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TechnicianID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TechnicianID.Width = 125;
            // 
            // SampleTypeID
            // 
            this.SampleTypeID.DataPropertyName = "SampleTypeID";
            this.SampleTypeID.DataSource = this.sampleTypeBindingSource;
            this.SampleTypeID.DisplayMember = "Description";
            this.SampleTypeID.HeaderText = "Sample Description";
            this.SampleTypeID.MinimumWidth = 6;
            this.SampleTypeID.Name = "SampleTypeID";
            this.SampleTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SampleTypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SampleTypeID.ValueMember = "SampleTypeID";
            this.SampleTypeID.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FinalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "Final Price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ResultSummary";
            this.dataGridViewTextBoxColumn8.HeaderText = "Result Summary";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // sampleTypeTableAdapter
            // 
            this.sampleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // testTypeBindingSource1
            // 
            this.testTypeBindingSource1.DataMember = "TestType";
            this.testTypeBindingSource1.DataSource = this.diagnosticLabDataSet;
            // 
            // testTypeBindingSource2
            // 
            this.testTypeBindingSource2.DataMember = "TestType";
            this.testTypeBindingSource2.DataSource = this.diagnosticLabDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "Updade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmLabTestRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTestRecordDataGridView);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(testDateLabel);
            this.Controls.Add(this.testDateDateTimePicker);
            this.Controls.Add(testTypeIDLabel);
            this.Controls.Add(this.testTypeIDComboBox);
            this.Controls.Add(technicianIDLabel);
            this.Controls.Add(this.technicianIDComboBox);
            this.Controls.Add(sampleTypeIDLabel);
            this.Controls.Add(this.sampleTypeIDComboBox);
            this.Controls.Add(finalPriceLabel);
            this.Controls.Add(this.finalPriceTextBox);
            this.Controls.Add(resultSummaryLabel);
            this.Controls.Add(this.resultSummaryTextBox);
            this.Name = "frmLabTestRecord";
            this.Text = "frmLabTestRecord";
            this.Load += new System.EventHandler(this.frmLabTestRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiagnosticLabDataSet diagnosticLabDataSet;
        private System.Windows.Forms.BindingSource labTestRecordBindingSource;
        private DiagnosticLabDataSetTableAdapters.LabTestRecordTableAdapter labTestRecordTableAdapter;
        private DiagnosticLabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.DateTimePicker testDateDateTimePicker;
        private System.Windows.Forms.ComboBox testTypeIDComboBox;
        private System.Windows.Forms.ComboBox technicianIDComboBox;
        private System.Windows.Forms.ComboBox sampleTypeIDComboBox;
        private System.Windows.Forms.TextBox finalPriceTextBox;
        private System.Windows.Forms.TextBox resultSummaryTextBox;
        private System.Windows.Forms.DataGridView labTestRecordDataGridView;
        private DiagnosticLabDataSetTableAdapters.TestTypeTableAdapter testTypeTableAdapter;
        private System.Windows.Forms.BindingSource testTypeBindingSource;
        private DiagnosticLabDataSetTableAdapters.TechnicianTableAdapter technicianTableAdapter;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.BindingSource sampleTypeBindingSource;
        private DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter sampleTypeTableAdapter;
        private System.Windows.Forms.BindingSource testTypeBindingSource1;
        private System.Windows.Forms.BindingSource testTypeBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn TestTypeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn TechnicianID;
        private System.Windows.Forms.DataGridViewComboBoxColumn SampleTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}