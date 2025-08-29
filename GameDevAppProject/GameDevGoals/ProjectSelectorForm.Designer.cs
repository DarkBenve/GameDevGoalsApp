namespace GameDevGoals
{
    partial class ProjectSelectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Button btnRemove;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(12, 12);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(260, 20);
            this.textBoxProjectName.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 38);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(260, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Crea/Apri progetto";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.Location = new System.Drawing.Point(12, 67);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(260, 134);
            this.listBoxProjects.TabIndex = 2;
            this.listBoxProjects.DoubleClick += new System.EventHandler(this.listBoxProjects_DoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 207);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(260, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Rimuovi progetto selezionato";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ProjectSelectorForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBoxProjects);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBoxProjectName);
            this.Name = "ProjectSelectorForm";
            this.Text = "Seleziona progetto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}