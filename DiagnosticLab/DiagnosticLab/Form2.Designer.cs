namespace DiagnosticLab
{
    partial class Form2
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label certificationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.diagnosticLabDataSet = new DiagnosticLab.DiagnosticLabDataSet();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TechnicianTableAdapter();
            this.tableAdapterManager = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager();
            this.technicianBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.certificationTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.technicianBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.labTestRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTestRecordTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.LabTestRecordTableAdapter();
            this.labTestRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.technicianBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TestTypeTableAdapter();
            this.sampleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            certificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).BeginInit();
            this.technicianBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosticLabDataSet
            // 
            this.diagnosticLabDataSet.DataSetName = "DiagnosticLabDataSet";
            this.diagnosticLabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataMember = "Technician";
            this.technicianBindingSource.DataSource = this.diagnosticLabDataSet;
            // 
            // technicianTableAdapter
            // 
            this.technicianTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LabTestRecordTableAdapter = this.labTestRecordTableAdapter;
            this.tableAdapterManager.SampleTypeTableAdapter = this.sampleTypeTableAdapter;
            this.tableAdapterManager.TechnicianTableAdapter = this.technicianTableAdapter;
            this.tableAdapterManager.TestTypeTableAdapter = this.testTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // technicianBindingNavigator
            // 
            this.technicianBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.technicianBindingNavigator.BindingSource = this.technicianBindingSource;
            this.technicianBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.technicianBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.technicianBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.technicianBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.technicianBindingNavigatorSaveItem});
            this.technicianBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.technicianBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.technicianBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.technicianBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.technicianBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.technicianBindingNavigator.Name = "technicianBindingNavigator";
            this.technicianBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.technicianBindingNavigator.Size = new System.Drawing.Size(1656, 27);
            this.technicianBindingNavigator.TabIndex = 0;
            this.technicianBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(56, 66);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(75, 16);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(215, 63);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(56, 94);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 16);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(215, 91);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // certificationLabel
            // 
            certificationLabel.AutoSize = true;
            certificationLabel.Location = new System.Drawing.Point(56, 122);
            certificationLabel.Name = "certificationLabel";
            certificationLabel.Size = new System.Drawing.Size(79, 16);
            certificationLabel.TabIndex = 5;
            certificationLabel.Text = "Certification:";
            // 
            // certificationTextBox
            // 
            this.certificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Certification", true));
            this.certificationTextBox.Location = new System.Drawing.Point(215, 119);
            this.certificationTextBox.Name = "certificationTextBox";
            this.certificationTextBox.Size = new System.Drawing.Size(100, 22);
            this.certificationTextBox.TabIndex = 6;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // technicianBindingNavigatorSaveItem
            // 
            this.technicianBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.technicianBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("technicianBindingNavigatorSaveItem.Image")));
            this.technicianBindingNavigatorSaveItem.Name = "technicianBindingNavigatorSaveItem";
            this.technicianBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.technicianBindingNavigatorSaveItem.Text = "Save Data";
            this.technicianBindingNavigatorSaveItem.Click += new System.EventHandler(this.technicianBindingNavigatorSaveItem_Click);
            // 
            // labTestRecordBindingSource
            // 
            this.labTestRecordBindingSource.DataMember = "FK__LabTestRe__Techn__3E52440B";
            this.labTestRecordBindingSource.DataSource = this.technicianBindingSource;
            // 
            // labTestRecordTableAdapter
            // 
            this.labTestRecordTableAdapter.ClearBeforeFill = true;
            // 
            // labTestRecordDataGridView
            // 
            this.labTestRecordDataGridView.AutoGenerateColumns = false;
            this.labTestRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Delete});
            this.labTestRecordDataGridView.DataSource = this.labTestRecordBindingSource;
            this.labTestRecordDataGridView.Location = new System.Drawing.Point(59, 160);
            this.labTestRecordDataGridView.Name = "labTestRecordDataGridView";
            this.labTestRecordDataGridView.RowHeadersWidth = 51;
            this.labTestRecordDataGridView.RowTemplate.Height = 24;
            this.labTestRecordDataGridView.Size = new System.Drawing.Size(1468, 220);
            this.labTestRecordDataGridView.TabIndex = 7;
            // 
            // technicianBindingSource1
            // 
            this.technicianBindingSource1.DataMember = "Technician";
            this.technicianBindingSource1.DataSource = this.diagnosticLabDataSet;
            // 
            // testTypeBindingSource
            // 
            this.testTypeBindingSource.DataMember = "TestType";
            this.testTypeBindingSource.DataSource = this.diagnosticLabDataSet;
            // 
            // testTypeTableAdapter
            // 
            this.testTypeTableAdapter.ClearBeforeFill = true;
            // 
            // sampleTypeBindingSource
            // 
            this.sampleTypeBindingSource.DataMember = "SampleType";
            this.sampleTypeBindingSource.DataSource = this.diagnosticLabDataSet;
            // 
            // sampleTypeTableAdapter
            // 
            this.sampleTypeTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TestTypeID";
            this.dataGridViewTextBoxColumn4.DataSource = this.testTypeBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Test Type";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "TestTypeID";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TechnicianID";
            this.dataGridViewTextBoxColumn5.HeaderText = "TechnicianID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SampleTypeID";
            this.dataGridViewTextBoxColumn6.DataSource = this.sampleTypeBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sample Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "SampleTypeID";
            this.dataGridViewTextBoxColumn6.Width = 125;
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TestType";
            this.dataGridViewTextBoxColumn9.HeaderText = "TestType";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Technician";
            this.dataGridViewTextBoxColumn10.HeaderText = "Technician";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Sample";
            this.dataGridViewTextBoxColumn11.HeaderText = "Sample";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 450);
            this.Controls.Add(this.labTestRecordDataGridView);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(certificationLabel);
            this.Controls.Add(this.certificationTextBox);
            this.Controls.Add(this.technicianBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).EndInit();
            this.technicianBindingNavigator.ResumeLayout(false);
            this.technicianBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiagnosticLabDataSet diagnosticLabDataSet;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private DiagnosticLabDataSetTableAdapters.TechnicianTableAdapter technicianTableAdapter;
        private DiagnosticLabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator technicianBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton technicianBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox certificationTextBox;
        private DiagnosticLabDataSetTableAdapters.LabTestRecordTableAdapter labTestRecordTableAdapter;
        private System.Windows.Forms.BindingSource labTestRecordBindingSource;
        private System.Windows.Forms.DataGridView labTestRecordDataGridView;
        private DiagnosticLabDataSetTableAdapters.TestTypeTableAdapter testTypeTableAdapter;
        private System.Windows.Forms.BindingSource technicianBindingSource1;
        private System.Windows.Forms.BindingSource testTypeBindingSource;
        private DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter sampleTypeTableAdapter;
        private System.Windows.Forms.BindingSource sampleTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}