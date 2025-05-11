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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.listToolStripMenuItem});
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
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.supportToolStripMenuItem.Text = "Support";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testTypeToolStripMenuItem,
            this.technicianToolStripMenuItem1,
            this.sampleTypeToolStripMenuItem1});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.listToolStripMenuItem.Text = "List";
            // 
            // testTToolStripMenuItem
            // 
            this.testTToolStripMenuItem.Name = "testTToolStripMenuItem";
            this.testTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.testTToolStripMenuItem.Text = "TestType";
            this.testTToolStripMenuItem.Click += new System.EventHandler(this.testTypeToolStripMenuItem_Click);
            // 
            // technicianToolStripMenuItem
            // 
            this.technicianToolStripMenuItem.Name = "technicianToolStripMenuItem";
            this.technicianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.technicianToolStripMenuItem.Text = "Technician";
            this.technicianToolStripMenuItem.Click += new System.EventHandler(this.technicianToolStripMenuItem_Click);
            // 
            // sampleTypeToolStripMenuItem
            // 
            this.sampleTypeToolStripMenuItem.Name = "sampleTypeToolStripMenuItem";
            this.sampleTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sampleTypeToolStripMenuItem.Text = "SampleType";
            this.sampleTypeToolStripMenuItem.Click += new System.EventHandler(this.sampleTypeToolStripMenuItem_Click);
            // 
            // testTypeToolStripMenuItem
            // 
            this.testTypeToolStripMenuItem.Name = "testTypeToolStripMenuItem";
            this.testTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.testTypeToolStripMenuItem.Text = "TestType";
            // 
            // technicianToolStripMenuItem1
            // 
            this.technicianToolStripMenuItem1.Name = "technicianToolStripMenuItem1";
            this.technicianToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.technicianToolStripMenuItem1.Text = "Technician";
            // 
            // sampleTypeToolStripMenuItem1
            // 
            this.sampleTypeToolStripMenuItem1.Name = "sampleTypeToolStripMenuItem1";
            this.sampleTypeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sampleTypeToolStripMenuItem1.Text = "SampleType";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
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
    }
}