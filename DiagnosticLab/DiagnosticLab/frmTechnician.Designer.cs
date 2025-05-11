namespace DiagnosticLab
{
    partial class frmTechnician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechnician));
            this.diagnosticLabDataSet = new DiagnosticLab.DiagnosticLabDataSet();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianTableAdapter = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TechnicianTableAdapter();
            this.tableAdapterManager = new DiagnosticLab.DiagnosticLabDataSetTableAdapters.TableAdapterManager();
            this.technicianBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.technicianBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.certificationTextBox = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            certificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).BeginInit();
            this.technicianBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(59, 149);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(75, 16);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(59, 177);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 16);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // certificationLabel
            // 
            certificationLabel.AutoSize = true;
            certificationLabel.Location = new System.Drawing.Point(59, 205);
            certificationLabel.Name = "certificationLabel";
            certificationLabel.Size = new System.Drawing.Size(79, 16);
            certificationLabel.TabIndex = 5;
            certificationLabel.Text = "Certification:";
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
            this.tableAdapterManager.LabTestRecordTableAdapter = null;
            this.tableAdapterManager.SampleTypeTableAdapter = null;
            this.tableAdapterManager.TechnicianTableAdapter = this.technicianTableAdapter;
            this.tableAdapterManager.TestTypeTableAdapter = null;
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
            this.technicianBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.technicianBindingNavigator.TabIndex = 0;
            this.technicianBindingNavigator.Text = "bindingNavigator1";
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
            // technicianBindingNavigatorSaveItem
            // 
            this.technicianBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.technicianBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("technicianBindingNavigatorSaveItem.Image")));
            this.technicianBindingNavigatorSaveItem.Name = "technicianBindingNavigatorSaveItem";
            this.technicianBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.technicianBindingNavigatorSaveItem.Text = "Save Data";
            this.technicianBindingNavigatorSaveItem.Click += new System.EventHandler(this.technicianBindingNavigatorSaveItem_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(144, 146);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(162, 22);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(144, 174);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(162, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // certificationTextBox
            // 
            this.certificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Certification", true));
            this.certificationTextBox.Location = new System.Drawing.Point(144, 202);
            this.certificationTextBox.Name = "certificationTextBox";
            this.certificationTextBox.Size = new System.Drawing.Size(162, 22);
            this.certificationTextBox.TabIndex = 6;
            // 
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(certificationLabel);
            this.Controls.Add(this.certificationTextBox);
            this.Controls.Add(this.technicianBindingNavigator);
            this.Name = "frmTechnician";
            this.Text = "frmTechnician";
            this.Load += new System.EventHandler(this.frmTechnician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticLabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).EndInit();
            this.technicianBindingNavigator.ResumeLayout(false);
            this.technicianBindingNavigator.PerformLayout();
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
    }
}