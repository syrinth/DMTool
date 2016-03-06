namespace DM_Tool.Controls
{
    partial class EncounterTableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.colPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEncounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.tbNumPeriods = new System.Windows.Forms.TextBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bnRoll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.ctxtSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(135, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Name";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToOrderColumns = true;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPercent,
            this.colEncounter});
            this.dgvTable.Location = new System.Drawing.Point(3, 39);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(373, 452);
            this.dgvTable.TabIndex = 1;
            // 
            // colPercent
            // 
            this.colPercent.FillWeight = 30F;
            this.colPercent.HeaderText = "% Weight";
            this.colPercent.Name = "colPercent";
            // 
            // colEncounter
            // 
            this.colEncounter.HeaderText = "Encounter";
            this.colEncounter.Name = "colEncounter";
            // 
            // ctxtSave
            // 
            this.ctxtSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.ctxtSave.Name = "ctxtUpdate";
            this.ctxtSave.Size = new System.Drawing.Size(99, 26);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tbPercent
            // 
            this.tbPercent.Location = new System.Drawing.Point(481, 39);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(100, 20);
            this.tbPercent.TabIndex = 3;
            // 
            // tbNumPeriods
            // 
            this.tbNumPeriods.Location = new System.Drawing.Point(481, 75);
            this.tbNumPeriods.Name = "tbNumPeriods";
            this.tbNumPeriods.Size = new System.Drawing.Size(100, 20);
            this.tbNumPeriods.TabIndex = 4;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeriod,
            this.dataGridViewTextBoxColumn2});
            this.dgvResults.Location = new System.Drawing.Point(382, 129);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(199, 362);
            this.dgvResults.TabIndex = 5;
            // 
            // colPeriod
            // 
            this.colPeriod.FillWeight = 30F;
            this.colPeriod.HeaderText = "Period";
            this.colPeriod.Name = "colPeriod";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Encounter";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Encounter Rate %:";
            // 
            // bnRoll
            // 
            this.bnRoll.Location = new System.Drawing.Point(506, 100);
            this.bnRoll.Name = "bnRoll";
            this.bnRoll.Size = new System.Drawing.Size(75, 23);
            this.bnRoll.TabIndex = 7;
            this.bnRoll.Text = "Roll!";
            this.bnRoll.UseVisualStyleBackColor = true;
            this.bnRoll.Click += new System.EventHandler(this.bnRoll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Periods:";
            // 
            // EncounterTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ctxtSave;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnRoll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.tbNumPeriods);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.tbName);
            this.Name = "EncounterTableControl";
            this.Size = new System.Drawing.Size(594, 494);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ctxtSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ContextMenuStrip ctxtSave;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.TextBox tbNumPeriods;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncounter;

    }
}
