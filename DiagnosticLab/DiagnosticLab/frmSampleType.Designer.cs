namespace DiagnosticLab
{
    partial class frmSampleType
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
            this.diagnosticLabDataSet = new DiagnosticLab.DiagnosticLabDataSet();
            this.sampleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter();
            this.tableAdapterManager = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.storageTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.maxHoldingTimeHrsTextBox = new System.Windows.Forms.TextBox();
            this.containerTypeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            storageTemperatureLabel = new System.Windows.Forms.Label();
            maxHoldingTimeHrsLabel = new System.Windows.Forms.Label();
            containerTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(51, 143);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // storageTemperatureLabel
            // 
            storageTemperatureLabel.AutoSize = true;
            storageTemperatureLabel.Location = new System.Drawing.Point(51, 234);
            storageTemperatureLabel.Name = "storageTemperatureLabel";
            storageTemperatureLabel.Size = new System.Drawing.Size(139, 16);
            storageTemperatureLabel.TabIndex = 3;
            storageTemperatureLabel.Text = "Storage Temperature:";
            // 
            // maxHoldingTimeHrsLabel
            // 
            maxHoldingTimeHrsLabel.AutoSize = true;
            maxHoldingTimeHrsLabel.Location = new System.Drawing.Point(51, 262);
            maxHoldingTimeHrsLabel.Name = "maxHoldingTimeHrsLabel";
            maxHoldingTimeHrsLabel.Size = new System.Drawing.Size(143, 16);
            maxHoldingTimeHrsLabel.TabIndex = 5;
            maxHoldingTimeHrsLabel.Text = "Max Holding Time Hrs:";
            // 
            // containerTypeLabel
            // 
            containerTypeLabel.AutoSize = true;
            containerTypeLabel.Location = new System.Drawing.Point(51, 290);
            containerTypeLabel.Name = "containerTypeLabel";
            containerTypeLabel.Size = new System.Drawing.Size(102, 16);
            containerTypeLabel.TabIndex = 7;
            containerTypeLabel.Text = "Container Type:";
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
            this.tableAdapterManager.LabTestRecordTableAdapter = null;
            this.tableAdapterManager.SampleTypeTableAdapter = this.sampleTypeTableAdapter;
            this.tableAdapterManager.TechnicianTableAdapter = null;
            this.tableAdapterManager.TestTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(200, 140);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(161, 85);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // storageTemperatureTextBox
            // 
            this.storageTemperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "StorageTemperature", true));
            this.storageTemperatureTextBox.Location = new System.Drawing.Point(200, 231);
            this.storageTemperatureTextBox.Name = "storageTemperatureTextBox";
            this.storageTemperatureTextBox.Size = new System.Drawing.Size(161, 22);
            this.storageTemperatureTextBox.TabIndex = 4;
            // 
            // maxHoldingTimeHrsTextBox
            // 
            this.maxHoldingTimeHrsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "MaxHoldingTimeHrs", true));
            this.maxHoldingTimeHrsTextBox.Location = new System.Drawing.Point(200, 259);
            this.maxHoldingTimeHrsTextBox.Name = "maxHoldingTimeHrsTextBox";
            this.maxHoldingTimeHrsTextBox.Size = new System.Drawing.Size(161, 22);
            this.maxHoldingTimeHrsTextBox.TabIndex = 6;
            // 
            // containerTypeTextBox
            // 
            this.containerTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleTypeBindingSource, "ContainerType", true));
            this.containerTypeTextBox.Location = new System.Drawing.Point(200, 287);
            this.containerTypeTextBox.Name = "containerTypeTextBox";
            this.containerTypeTextBox.Size = new System.Drawing.Size(161, 22);
            this.containerTypeTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSampleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(storageTemperatureLabel);
            this.Controls.Add(this.storageTemperatureTextBox);
            this.Controls.Add(maxHoldingTimeHrsLabel);
            this.Controls.Add(this.maxHoldingTimeHrsTextBox);
            this.Controls.Add(containerTypeLabel);
            this.Controls.Add(this.containerTypeTextBox);
            this.Name = "frmSampleType";
            this.Text = "frmSampleType";
            this.Load += new System.EventHandler(this.frmSampleType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiagnosticLabDataSet diagnosticLabDataSet;
        private System.Windows.Forms.BindingSource sampleTypeBindingSource;
        private DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter sampleTypeTableAdapter;
        private DiagnosticLabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox storageTemperatureTextBox;
        private System.Windows.Forms.TextBox maxHoldingTimeHrsTextBox;
        private System.Windows.Forms.TextBox containerTypeTextBox;
        private System.Windows.Forms.Button button1;
    }
}