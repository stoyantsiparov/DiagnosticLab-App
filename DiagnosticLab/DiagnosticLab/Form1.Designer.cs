namespace DiagnosticLab
{
    partial class Form1
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label storageTemperatureLabel;
            System.Windows.Forms.Label maxHoldingTimeHrsLabel;
            System.Windows.Forms.Label containerTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.diagnosticLabDataSet = new DiagnosticLab.DiagnosticLabDataSet();
            this.sampleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter();
            this.tableAdapterManager = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager();
            this.sampleTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.storageTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.maxHoldingTimeHrsTextBox = new System.Windows.Forms.TextBox();
            this.containerTypeTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.sampleTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.labTestRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTestRecordTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.LabTestRecordTableAdapter();
            this.labTestRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.testTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TestTypeTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionLabel = new System.Windows.Forms.Label();
            storageTemperatureLabel = new System.Windows.Forms.Label();
            maxHoldingTimeHrsLabel = new System.Windows.Forms.Label();
            containerTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingNavigator)).BeginInit();
            this.sampleTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosticLabDataSet
            // 
            this.diagnosticLabDataSet.DataSetName = "DiagnosticLabDataSet";
            this.diagnosticLabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LabTestRecordTableAdapter = this.labTestRecordTableAdapter;
            this.tableAdapterManager.SampleTypeTableAdapter = this.sampleTypeTableAdapter;
            this.tableAdapterManager.TechnicianTableAdapter = null;
            this.tableAdapterManager.TestTypeTableAdapter = this.testTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sampleTypeBindingNavigator
            // 
            this.sampleTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sampleTypeBindingNavigator.BindingSource = this.sampleTypeBindingSource;
            this.sampleTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sampleTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sampleTypeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sampleTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sampleTypeBindingNavigatorSaveItem});
            this.sampleTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sampleTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sampleTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sampleTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sampleTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sampleTypeBindingNavigator.Name = "sampleTypeBindingNavigator";
            this.sampleTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sampleTypeBindingNavigator.Size = new System.Drawing.Size(1490, 27);
            this.sampleTypeBindingNavigator.TabIndex = 0;
            this.sampleTypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(22, 49);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(171, 46);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // storageTemperatureLabel
            // 
            storageTemperatureLabel.AutoSize = true;
            storageTemperatureLabel.Location = new System.Drawing.Point(22, 77);
            storageTemperatureLabel.Name = "storageTemperatureLabel";
            storageTemperatureLabel.Size = new System.Drawing.Size(139, 16);
            storageTemperatureLabel.TabIndex = 3;
            storageTemperatureLabel.Text = "Storage Temperature:";
            // 
            // storageTemperatureTextBox
            // 
            this.storageTemperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "StorageTemperature", true));
            this.storageTemperatureTextBox.Location = new System.Drawing.Point(171, 74);
            this.storageTemperatureTextBox.Name = "storageTemperatureTextBox";
            this.storageTemperatureTextBox.Size = new System.Drawing.Size(100, 22);
            this.storageTemperatureTextBox.TabIndex = 4;
            // 
            // maxHoldingTimeHrsLabel
            // 
            maxHoldingTimeHrsLabel.AutoSize = true;
            maxHoldingTimeHrsLabel.Location = new System.Drawing.Point(22, 105);
            maxHoldingTimeHrsLabel.Name = "maxHoldingTimeHrsLabel";
            maxHoldingTimeHrsLabel.Size = new System.Drawing.Size(143, 16);
            maxHoldingTimeHrsLabel.TabIndex = 5;
            maxHoldingTimeHrsLabel.Text = "Max Holding Time Hrs:";
            // 
            // maxHoldingTimeHrsTextBox
            // 
            this.maxHoldingTimeHrsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "MaxHoldingTimeHrs", true));
            this.maxHoldingTimeHrsTextBox.Location = new System.Drawing.Point(171, 102);
            this.maxHoldingTimeHrsTextBox.Name = "maxHoldingTimeHrsTextBox";
            this.maxHoldingTimeHrsTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxHoldingTimeHrsTextBox.TabIndex = 6;
            // 
            // containerTypeLabel
            // 
            containerTypeLabel.AutoSize = true;
            containerTypeLabel.Location = new System.Drawing.Point(22, 133);
            containerTypeLabel.Name = "containerTypeLabel";
            containerTypeLabel.Size = new System.Drawing.Size(102, 16);
            containerTypeLabel.TabIndex = 7;
            containerTypeLabel.Text = "Container Type:";
            // 
            // containerTypeTextBox
            // 
            this.containerTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "ContainerType", true));
            this.containerTypeTextBox.Location = new System.Drawing.Point(171, 130);
            this.containerTypeTextBox.Name = "containerTypeTextBox";
            this.containerTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.containerTypeTextBox.TabIndex = 8;
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // sampleTypeBindingNavigatorSaveItem
            // 
            this.sampleTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sampleTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sampleTypeBindingNavigatorSaveItem.Image")));
            this.sampleTypeBindingNavigatorSaveItem.Name = "sampleTypeBindingNavigatorSaveItem";
            this.sampleTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sampleTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.sampleTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.sampleTypeBindingNavigatorSaveItem_Click);
            // 
            // labTestRecordBindingSource
            // 
            this.labTestRecordBindingSource.DataMember = "FK__LabTestRe__Sampl__3F466844";
            this.labTestRecordBindingSource.DataSource = this.sampleTypeBindingSource;
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
            this.dataGridViewTextBoxColumn11});
            this.labTestRecordDataGridView.DataSource = this.labTestRecordBindingSource;
            this.labTestRecordDataGridView.Location = new System.Drawing.Point(25, 195);
            this.labTestRecordDataGridView.Name = "labTestRecordDataGridView";
            this.labTestRecordDataGridView.RowHeadersWidth = 51;
            this.labTestRecordDataGridView.RowTemplate.Height = 24;
            this.labTestRecordDataGridView.Size = new System.Drawing.Size(1423, 220);
            this.labTestRecordDataGridView.TabIndex = 9;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LabTestID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LabTestID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TestDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "TestDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TestTypeID";
            this.dataGridViewTextBoxColumn4.DataSource = this.testTypeBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "TestTypeID";
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
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SampleTypeID";
            this.dataGridViewTextBoxColumn6.HeaderText = "SampleTypeID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FinalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "FinalPrice";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ResultSummary";
            this.dataGridViewTextBoxColumn8.HeaderText = "ResultSummary";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 452);
            this.Controls.Add(this.labTestRecordDataGridView);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(storageTemperatureLabel);
            this.Controls.Add(this.storageTemperatureTextBox);
            this.Controls.Add(maxHoldingTimeHrsLabel);
            this.Controls.Add(this.maxHoldingTimeHrsTextBox);
            this.Controls.Add(containerTypeLabel);
            this.Controls.Add(this.containerTypeTextBox);
            this.Controls.Add(this.sampleTypeBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingNavigator)).EndInit();
            this.sampleTypeBindingNavigator.ResumeLayout(false);
            this.sampleTypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiagnosticLabDataSet diagnosticLabDataSet;
        private System.Windows.Forms.BindingSource sampleTypeBindingSource;
        private DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter sampleTypeTableAdapter;
        private DiagnosticLabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sampleTypeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sampleTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox storageTemperatureTextBox;
        private System.Windows.Forms.TextBox maxHoldingTimeHrsTextBox;
        private System.Windows.Forms.TextBox containerTypeTextBox;
        private DiagnosticLabDataSetTableAdapters.LabTestRecordTableAdapter labTestRecordTableAdapter;
        private System.Windows.Forms.BindingSource labTestRecordBindingSource;
        private DiagnosticLabDataSetTableAdapters.TestTypeTableAdapter testTypeTableAdapter;
        private System.Windows.Forms.DataGridView labTestRecordDataGridView;
        private System.Windows.Forms.BindingSource testTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}