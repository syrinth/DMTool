namespace DM_Tool.Controls
{
    partial class RoomControl
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvEncounters = new System.Windows.Forms.DataGridView();
            this.colMonster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTraps = new System.Windows.Forms.DataGridView();
            this.colTrapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoot = new System.Windows.Forms.DataGridView();
            this.colLoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSkills = new System.Windows.Forms.TextBox();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabEncounters = new System.Windows.Forms.TabPage();
            this.tabConnections = new System.Windows.Forms.TabPage();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabTraps = new System.Windows.Forms.TabPage();
            this.tabLoot = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncounters)).BeginInit();
            this.ctxtMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoot)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabEncounters.SuspendLayout();
            this.tabConnections.SuspendLayout();
            this.tabSkills.SuspendLayout();
            this.tabTraps.SuspendLayout();
            this.tabLoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(7, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 26);
            this.tbName.TabIndex = 0;
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.ColumnHeadersVisible = false;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoom});
            this.dgvRooms.Location = new System.Drawing.Point(0, 0);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.Size = new System.Drawing.Size(562, 212);
            this.dgvRooms.TabIndex = 7;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvRooms_CurrentCellDirtyStateChanged);
            // 
            // colRoom
            // 
            this.colRoom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colRoom.HeaderText = "Room";
            this.colRoom.Name = "colRoom";
            this.colRoom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvEncounters
            // 
            this.dgvEncounters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncounters.ColumnHeadersVisible = false;
            this.dgvEncounters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonster});
            this.dgvEncounters.Location = new System.Drawing.Point(0, 0);
            this.dgvEncounters.MultiSelect = false;
            this.dgvEncounters.Name = "dgvEncounters";
            this.dgvEncounters.RowHeadersVisible = false;
            this.dgvEncounters.Size = new System.Drawing.Size(562, 212);
            this.dgvEncounters.TabIndex = 9;
            this.dgvEncounters.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvEncounters_MouseDown);
            // 
            // colMonster
            // 
            this.colMonster.HeaderText = "Room";
            this.colMonster.Name = "colMonster";
            this.colMonster.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ctxtMenu
            // 
            this.ctxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // dgvTraps
            // 
            this.dgvTraps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraps.ColumnHeadersVisible = false;
            this.dgvTraps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrapName});
            this.dgvTraps.ContextMenuStrip = this.ctxtMenu;
            this.dgvTraps.Location = new System.Drawing.Point(0, 0);
            this.dgvTraps.MultiSelect = false;
            this.dgvTraps.Name = "dgvTraps";
            this.dgvTraps.RowHeadersVisible = false;
            this.dgvTraps.Size = new System.Drawing.Size(562, 212);
            this.dgvTraps.TabIndex = 11;
            // 
            // colTrapName
            // 
            this.colTrapName.HeaderText = "Room";
            this.colTrapName.Name = "colTrapName";
            this.colTrapName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvLoot
            // 
            this.dgvLoot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoot.ColumnHeadersVisible = false;
            this.dgvLoot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoot});
            this.dgvLoot.ContextMenuStrip = this.ctxtMenu;
            this.dgvLoot.Location = new System.Drawing.Point(0, 0);
            this.dgvLoot.MultiSelect = false;
            this.dgvLoot.Name = "dgvLoot";
            this.dgvLoot.RowHeadersVisible = false;
            this.dgvLoot.Size = new System.Drawing.Size(562, 212);
            this.dgvLoot.TabIndex = 13;
            // 
            // colLoot
            // 
            this.colLoot.HeaderText = "Room";
            this.colLoot.Name = "colLoot";
            this.colLoot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(7, 35);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(570, 157);
            this.tbDescription.TabIndex = 15;
            // 
            // tbSkills
            // 
            this.tbSkills.Location = new System.Drawing.Point(0, 0);
            this.tbSkills.Multiline = true;
            this.tbSkills.Name = "tbSkills";
            this.tbSkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSkills.Size = new System.Drawing.Size(566, 216);
            this.tbSkills.TabIndex = 16;
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabEncounters);
            this.tabCtrl.Controls.Add(this.tabConnections);
            this.tabCtrl.Controls.Add(this.tabSkills);
            this.tabCtrl.Controls.Add(this.tabTraps);
            this.tabCtrl.Controls.Add(this.tabLoot);
            this.tabCtrl.Location = new System.Drawing.Point(7, 198);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(570, 238);
            this.tabCtrl.TabIndex = 17;
            // 
            // tabEncounters
            // 
            this.tabEncounters.Controls.Add(this.dgvEncounters);
            this.tabEncounters.Location = new System.Drawing.Point(4, 22);
            this.tabEncounters.Name = "tabEncounters";
            this.tabEncounters.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncounters.Size = new System.Drawing.Size(562, 212);
            this.tabEncounters.TabIndex = 0;
            this.tabEncounters.Text = "Encounters";
            this.tabEncounters.UseVisualStyleBackColor = true;
            // 
            // tabConnections
            // 
            this.tabConnections.Controls.Add(this.dgvRooms);
            this.tabConnections.Location = new System.Drawing.Point(4, 22);
            this.tabConnections.Name = "tabConnections";
            this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnections.Size = new System.Drawing.Size(562, 212);
            this.tabConnections.TabIndex = 1;
            this.tabConnections.Text = "Connections";
            this.tabConnections.UseVisualStyleBackColor = true;
            // 
            // tabSkills
            // 
            this.tabSkills.Controls.Add(this.tbSkills);
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Size = new System.Drawing.Size(562, 212);
            this.tabSkills.TabIndex = 4;
            this.tabSkills.Text = "Relevant Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabTraps
            // 
            this.tabTraps.Controls.Add(this.dgvTraps);
            this.tabTraps.Location = new System.Drawing.Point(4, 22);
            this.tabTraps.Name = "tabTraps";
            this.tabTraps.Size = new System.Drawing.Size(562, 212);
            this.tabTraps.TabIndex = 2;
            this.tabTraps.Text = "Traps";
            this.tabTraps.UseVisualStyleBackColor = true;
            // 
            // tabLoot
            // 
            this.tabLoot.Controls.Add(this.dgvLoot);
            this.tabLoot.Location = new System.Drawing.Point(4, 22);
            this.tabLoot.Name = "tabLoot";
            this.tabLoot.Size = new System.Drawing.Size(562, 212);
            this.tabLoot.TabIndex = 3;
            this.tabLoot.Text = "Loot";
            this.tabLoot.UseVisualStyleBackColor = true;
            // 
            // RoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Name = "RoomControl";
            this.Size = new System.Drawing.Size(586, 439);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncounters)).EndInit();
            this.ctxtMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoot)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabEncounters.ResumeLayout(false);
            this.tabConnections.ResumeLayout(false);
            this.tabSkills.ResumeLayout(false);
            this.tabSkills.PerformLayout();
            this.tabTraps.ResumeLayout(false);
            this.tabLoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewComboBoxColumn colRoom;
        private System.Windows.Forms.DataGridView dgvEncounters;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonster;
        private System.Windows.Forms.DataGridView dgvTraps;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrapName;
        private System.Windows.Forms.DataGridView dgvLoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoot;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbSkills;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabEncounters;
        private System.Windows.Forms.TabPage tabConnections;
        private System.Windows.Forms.TabPage tabTraps;
        private System.Windows.Forms.TabPage tabLoot;
        private System.Windows.Forms.TabPage tabSkills;
    }
}
