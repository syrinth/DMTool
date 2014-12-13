namespace DM_Tool.Controls
{
    partial class XPLedgerControl
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
            this.dgvXP = new System.Windows.Forms.DataGridView();
            this.colEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvTotalXP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXP)).BeginInit();
            this.ctxtMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalXP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXP
            // 
            this.dgvXP.AllowUserToResizeRows = false;
            this.dgvXP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEvent});
            this.dgvXP.ContextMenuStrip = this.ctxtMenu;
            this.dgvXP.Location = new System.Drawing.Point(0, 3);
            this.dgvXP.Name = "dgvXP";
            this.dgvXP.RowHeadersVisible = false;
            this.dgvXP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXP.Size = new System.Drawing.Size(597, 435);
            this.dgvXP.TabIndex = 0;
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
            this.addNewColumnToolStripMenuItem});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.Size = new System.Drawing.Size(170, 26);
            // 
            // addNewColumnToolStripMenuItem
            // 
            this.addNewColumnToolStripMenuItem.Name = "addNewColumnToolStripMenuItem";
            this.addNewColumnToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addNewColumnToolStripMenuItem.Text = "Add New Column";
            this.addNewColumnToolStripMenuItem.Click += new System.EventHandler(this.addNewColumnToolStripMenuItem_Click);
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
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // dgvTotalXP
            // 
            this.dgvTotalXP.AllowUserToResizeRows = false;
            this.dgvTotalXP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalXP.ColumnHeadersVisible = false;
            this.dgvTotalXP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvTotalXP.ContextMenuStrip = this.ctxtMenu;
            this.dgvTotalXP.Location = new System.Drawing.Point(0, 444);
            this.dgvTotalXP.MultiSelect = false;
            this.dgvTotalXP.Name = "dgvTotalXP";
            this.dgvTotalXP.ReadOnly = true;
            this.dgvTotalXP.RowHeadersVisible = false;
            this.dgvTotalXP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTotalXP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotalXP.Size = new System.Drawing.Size(597, 24);
            this.dgvTotalXP.TabIndex = 74;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Event";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // XPLedgerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTotalXP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvXP);
            this.Name = "XPLedgerControl";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXP)).EndInit();
            this.ctxtMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalXP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewColumnToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvTotalXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
