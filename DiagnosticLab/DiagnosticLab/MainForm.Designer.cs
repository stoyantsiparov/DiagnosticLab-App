namespace DiagnosticLab
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byOneParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byMoreParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.listToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.masterDetailsToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testTToolStripMenuItem,
            this.technicianToolStripMenuItem,
            this.sampleTypeToolStripMenuItem});
            this.supportToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.Support_Icon_Uniform;
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.supportToolStripMenuItem.Text = "Support";
            // 
            // testTToolStripMenuItem
            // 
            this.testTToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.testType;
            this.testTToolStripMenuItem.Name = "testTToolStripMenuItem";
            this.testTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.testTToolStripMenuItem.Text = "TestType";
            this.testTToolStripMenuItem.Click += new System.EventHandler(this.testTypeToolStripMenuItem_Click);
            // 
            // technicianToolStripMenuItem
            // 
            this.technicianToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.лаб;
            this.technicianToolStripMenuItem.Name = "technicianToolStripMenuItem";
            this.technicianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.technicianToolStripMenuItem.Text = "Technician";
            this.technicianToolStripMenuItem.Click += new System.EventHandler(this.technicianToolStripMenuItem_Click);
            // 
            // sampleTypeToolStripMenuItem
            // 
            this.sampleTypeToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.sampletype;
            this.sampleTypeToolStripMenuItem.Name = "sampleTypeToolStripMenuItem";
            this.sampleTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sampleTypeToolStripMenuItem.Text = "SampleType";
            this.sampleTypeToolStripMenuItem.Click += new System.EventHandler(this.sampleTypeToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testTypeToolStripMenuItem,
            this.technicianToolStripMenuItem1,
            this.sampleTypeToolStripMenuItem1});
            this.listToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.Lists_Icon_Uniform;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.listToolStripMenuItem.Text = "Lists";
            // 
            // testTypeToolStripMenuItem
            // 
            this.testTypeToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.testType;
            this.testTypeToolStripMenuItem.Name = "testTypeToolStripMenuItem";
            this.testTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.testTypeToolStripMenuItem.Text = "TestType";
            this.testTypeToolStripMenuItem.Click += new System.EventHandler(this.testTypeToolStripMenuItem_Click_1);
            // 
            // technicianToolStripMenuItem1
            // 
            this.technicianToolStripMenuItem1.Image = global::DiagnosticLab.Properties.Resources.лаб;
            this.technicianToolStripMenuItem1.Name = "technicianToolStripMenuItem1";
            this.technicianToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.technicianToolStripMenuItem1.Text = "Technician";
            this.technicianToolStripMenuItem1.Click += new System.EventHandler(this.technicianToolStripMenuItem1_Click);
            // 
            // sampleTypeToolStripMenuItem1
            // 
            this.sampleTypeToolStripMenuItem1.Image = global::DiagnosticLab.Properties.Resources.sampletype;
            this.sampleTypeToolStripMenuItem1.Name = "sampleTypeToolStripMenuItem1";
            this.sampleTypeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sampleTypeToolStripMenuItem1.Text = "SampleType";
            this.sampleTypeToolStripMenuItem1.Click += new System.EventHandler(this.sampleTypeToolStripMenuItem1_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.Records_Icon_Uniform;
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // masterDetailsToolStripMenuItem
            // 
            this.masterDetailsToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.labMD;
            this.masterDetailsToolStripMenuItem.Name = "masterDetailsToolStripMenuItem";
            this.masterDetailsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.masterDetailsToolStripMenuItem.Text = "Technician MD";
            this.masterDetailsToolStripMenuItem.Click += new System.EventHandler(this.masterDetailsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byOneParameterToolStripMenuItem,
            this.byMoreParametersToolStripMenuItem});
            this.searchToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.Search_Icon_Uniform;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // byOneParameterToolStripMenuItem
            // 
            this.byOneParameterToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.sear;
            this.byOneParameterToolStripMenuItem.Name = "byOneParameterToolStripMenuItem";
            this.byOneParameterToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.byOneParameterToolStripMenuItem.Text = "By one parameter";
            this.byOneParameterToolStripMenuItem.Click += new System.EventHandler(this.byOneParameterToolStripMenuItem_Click);
            // 
            // byMoreParametersToolStripMenuItem
            // 
            this.byMoreParametersToolStripMenuItem.Image = global::DiagnosticLab.Properties.Resources.sear;
            this.byMoreParametersToolStripMenuItem.Name = "byMoreParametersToolStripMenuItem";
            this.byMoreParametersToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.byMoreParametersToolStripMenuItem.Text = "By more parameters";
            this.byMoreParametersToolStripMenuItem.Click += new System.EventHandler(this.byMoreParametersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DiagnosticLab";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sampleTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byOneParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byMoreParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDetailsToolStripMenuItem;
    }
}