namespace DM_Tool.Controls
{
    partial class QualityControl
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveAndEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinValueMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxValueMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(508, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveAndEdit
            // 
            this.btnSaveAndEdit.Location = new System.Drawing.Point(427, 474);
            this.btnSaveAndEdit.Name = "btnSaveAndEdit";
            this.btnSaveAndEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAndEdit.TabIndex = 71;
            this.btnSaveAndEdit.Text = "Edit";
            this.btnSaveAndEdit.UseVisualStyleBackColor = true;
            this.btnSaveAndEdit.Click += new System.EventHandler(this.btnSaveAndEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colMinValueMod,
            this.colMaxValueMod,
            this.colWeight});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(593, 464);
            this.dataGridView1.TabIndex = 74;
            // 
            // colName
            // 
            this.colName.FillWeight = 60F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colMinValueMod
            // 
            this.colMinValueMod.FillWeight = 20F;
            this.colMinValueMod.HeaderText = "Min Value";
            this.colMinValueMod.Name = "colMinValueMod";
            // 
            // colMaxValueMod
            // 
            this.colMaxValueMod.FillWeight = 20F;
            this.colMaxValueMod.HeaderText = "Max Value";
            this.colMaxValueMod.Name = "colMaxValueMod";
            // 
            // colWeight
            // 
            this.colWeight.FillWeight = 20F;
            this.colWeight.HeaderText = "Weight";
            this.colWeight.Name = "colWeight";
            // 
            // QualityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveAndEdit);
            this.Name = "QualityControl";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveAndEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinValueMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxValueMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
    }
}
