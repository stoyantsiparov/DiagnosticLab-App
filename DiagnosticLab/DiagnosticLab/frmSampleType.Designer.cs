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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSampleType));
            this.diagnosticLabDataSet = new DiagnosticLab.DiagnosticLabDataSet();
            this.sampleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleTypeTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.SampleTypeTableAdapter();
            this.tableAdapterManager = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager();
            this.sampleTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sampleTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.storageTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.maxHoldingTimeHrsTextBox = new System.Windows.Forms.TextBox();
            this.containerTypeTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            storageTemperatureLabel = new System.Windows.Forms.Label();
            maxHoldingTimeHrsLabel = new System.Windows.Forms.Label();
            containerTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingNavigator)).BeginInit();
            this.sampleTypeBindingNavigator.SuspendLayout();
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
            this.sampleTypeBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.sampleTypeBindingNavigator.TabIndex = 0;
            this.sampleTypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // sampleTypeBindingNavigatorSaveItem
            // 
            this.sampleTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sampleTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sampleTypeBindingNavigatorSaveItem.Image")));
            this.sampleTypeBindingNavigatorSaveItem.Name = "sampleTypeBindingNavigatorSaveItem";
            this.sampleTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.sampleTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.sampleTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.sampleTypeBindingNavigatorSaveItem_Click);
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
            // frmSampleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(storageTemperatureLabel);
            this.Controls.Add(this.storageTemperatureTextBox);
            this.Controls.Add(maxHoldingTimeHrsLabel);
            this.Controls.Add(this.maxHoldingTimeHrsTextBox);
            this.Controls.Add(containerTypeLabel);
            this.Controls.Add(this.containerTypeTextBox);
            this.Controls.Add(this.sampleTypeBindingNavigator);
            this.Name = "frmSampleType";
            this.Text = "frmSampleType";
            this.Load += new System.EventHandler(this.frmSampleType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTypeBindingNavigator)).EndInit();
            this.sampleTypeBindingNavigator.ResumeLayout(false);
            this.sampleTypeBindingNavigator.PerformLayout();
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
    }
}