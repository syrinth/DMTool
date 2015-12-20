namespace DM_Tool.Controls
{
    partial class CurrentInfoControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvTotalXP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvXP = new System.Windows.Forms.DataGridView();
            this.colEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtCalendarEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXP)).BeginInit();
            this.ctxtMenu.SuspendLayout();
            this.ctxtCalendarEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(14, 17);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 19);
            this.lblLocation.TabIndex = 74;
            this.lblLocation.Text = "Location:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 75;
            this.lblDate.Text = "Date:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(98, 18);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(200, 20);
            this.tbLocation.TabIndex = 78;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm  tt";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(463, 7);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(120, 31);
            this.dtpTime.TabIndex = 82;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.ContextMenuStrip = this.ctxtCalendarEdit;
            this.tbCurrentDate.Location = new System.Drawing.Point(98, 47);
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCurrentDate.Size = new System.Drawing.Size(200, 20);
            this.tbCurrentDate.TabIndex = 84;
            this.tbCurrentDate.Leave += new System.EventHandler(this.tbCurrentDate_Leave);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(304, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 23);
            this.btnNext.TabIndex = 83;
            this.btnNext.Text = "Next Day";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvTotalXP
            // 
            this.dgvTotalXP.AllowUserToResizeRows = false;
            this.dgvTotalXP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalXP.ColumnHeadersVisible = false;
            this.dgvTotalXP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvTotalXP.Location = new System.Drawing.Point(3, 444);
            this.dgvTotalXP.MultiSelect = false;
            this.dgvTotalXP.Name = "dgvTotalXP";
            this.dgvTotalXP.ReadOnly = true;
            this.dgvTotalXP.RowHeadersVisible = false;
            this.dgvTotalXP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTotalXP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotalXP.Size = new System.Drawing.Size(580, 24);
            this.dgvTotalXP.TabIndex = 86;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Event";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvXP
            // 
            this.dgvXP.AllowUserToResizeRows = false;
            this.dgvXP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEvent});
            this.dgvXP.ContextMenuStrip = this.ctxtMenu;
            this.dgvXP.Location = new System.Drawing.Point(3, 95);
            this.dgvXP.Name = "dgvXP";
            this.dgvXP.RowHeadersVisible = false;
            this.dgvXP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXP.Size = new System.Drawing.Size(580, 337);
            this.dgvXP.TabIndex = 85;
            this.dgvXP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXP_CellValueChanged);
            // 
            // colEvent
            // 
            this.colEvent.HeaderText = "Event";
            this.colEvent.Name = "colEvent";
            // 
            // ctxtMenu
            // 
            this.ctxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewColumnToolStripMenuItem,
            this.deleteColumnToolStripMenuItem});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.Size = new System.Drawing.Size(170, 48);
            // 
            // addNewColumnToolStripMenuItem
            // 
            this.addNewColumnToolStripMenuItem.Name = "addNewColumnToolStripMenuItem";
            this.addNewColumnToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addNewColumnToolStripMenuItem.Text = "Add New Column";
            this.addNewColumnToolStripMenuItem.Click += new System.EventHandler(this.addNewColumnToolStripMenuItem_Click);
            // 
            // deleteColumnToolStripMenuItem
            // 
            this.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            this.deleteColumnToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteColumnToolStripMenuItem.Text = "Delete Column";
            this.deleteColumnToolStripMenuItem.Click += new System.EventHandler(this.deleteColumnToolStripMenuItem_Click);
            // 
            // ctxtCalendarEdit
            // 
            this.ctxtCalendarEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCalendarToolStripMenuItem});
            this.ctxtCalendarEdit.Name = "ctxtCalendarEdit";
            this.ctxtCalendarEdit.Size = new System.Drawing.Size(145, 26);
            // 
            // editCalendarToolStripMenuItem
            // 
            this.editCalendarToolStripMenuItem.Name = "editCalendarToolStripMenuItem";
            this.editCalendarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editCalendarToolStripMenuItem.Text = "Edit Calendar";
            this.editCalendarToolStripMenuItem.Click += new System.EventHandler(this.editCalendarToolStripMenuItem_Click);
            // 
            // CurrentInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTotalXP);
            this.Controls.Add(this.dgvXP);
            this.Controls.Add(this.tbCurrentDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSave);
            this.Name = "CurrentInfoControl";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXP)).EndInit();
            this.ctxtMenu.ResumeLayout(false);
            this.ctxtCalendarEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox tbCurrentDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvTotalXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvent;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtCalendarEdit;
        private System.Windows.Forms.ToolStripMenuItem editCalendarToolStripMenuItem;
    }
}
