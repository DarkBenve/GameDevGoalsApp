namespace GameDevGoals
{
    partial class GameDevGoals
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDevGoals));
            this.textBoxNewGoal = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkedListBoxGoals = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCounters = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveChecked = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNewGoal
            // 
            this.textBoxNewGoal.AccessibleDescription = "";
            this.textBoxNewGoal.AccessibleName = "textBoxNewGoal";
            this.textBoxNewGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNewGoal.Location = new System.Drawing.Point(137, 13);
            this.textBoxNewGoal.Name = "textBoxNewGoal";
            this.textBoxNewGoal.Size = new System.Drawing.Size(786, 25);
            this.textBoxNewGoal.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleName = "buttonAdd";
            this.buttonAdd.Location = new System.Drawing.Point(500, 41);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 25);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Aggiungi";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxGoals
            // 
            this.checkedListBoxGoals.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkedListBoxGoals.CheckOnClick = true;
            this.checkedListBoxGoals.FormattingEnabled = true;
            this.checkedListBoxGoals.Location = new System.Drawing.Point(137, 91);
            this.checkedListBoxGoals.Name = "checkedListBoxGoals";
            this.checkedListBoxGoals.Size = new System.Drawing.Size(786, 295);
            this.checkedListBoxGoals.TabIndex = 2;
            this.checkedListBoxGoals.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxGoals_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.labelCounters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 154);
            this.panel1.TabIndex = 3;
            // 
            // labelCounters
            // 
            this.labelCounters.AccessibleName = "labelCounters";
            this.labelCounters.AutoSize = true;
            this.labelCounters.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCounters.Location = new System.Drawing.Point(0, 0);
            this.labelCounters.Name = "labelCounters";
            this.labelCounters.Size = new System.Drawing.Size(82, 14);
            this.labelCounters.TabIndex = 0;
            this.labelCounters.Text = "Completati 0/0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveChecked);
            this.flowLayoutPanel1.Controls.Add(this.btnClearAll);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(902, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 154);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRemoveChecked
            // 
            this.btnRemoveChecked.AccessibleName = "btnRemoveChecked";
            this.btnRemoveChecked.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveChecked.Name = "btnRemoveChecked";
            this.btnRemoveChecked.Size = new System.Drawing.Size(146, 25);
            this.btnRemoveChecked.TabIndex = 0;
            this.btnRemoveChecked.Text = "Rimuovi spuntati";
            this.btnRemoveChecked.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AccessibleName = "btnClearAll";
            this.btnClearAll.Location = new System.Drawing.Point(3, 34);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(146, 25);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Svuota tutto";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // GameDevGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1102, 688);
            this.Controls.Add(this.checkedListBoxGoals);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNewGoal);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameDevGoals";
            this.Text = "GameDevGoals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewGoal;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckedListBox checkedListBoxGoals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRemoveChecked;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label labelCounters;
    }
}

