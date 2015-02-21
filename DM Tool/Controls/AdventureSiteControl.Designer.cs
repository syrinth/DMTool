namespace DM_Tool.Controls
{
    partial class AdventureSiteControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tabAdventureSite = new System.Windows.Forms.TabControl();
            this.tabPageAdventureSite = new System.Windows.Forms.TabPage();
            this.lblRooms = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tabAdventureSite.SuspendLayout();
            this.tabPageAdventureSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabAdventureSite
            // 
            this.tabAdventureSite.Controls.Add(this.tabPageAdventureSite);
            this.tabAdventureSite.Location = new System.Drawing.Point(3, 3);
            this.tabAdventureSite.Name = "tabAdventureSite";
            this.tabAdventureSite.SelectedIndex = 0;
            this.tabAdventureSite.Size = new System.Drawing.Size(594, 465);
            this.tabAdventureSite.TabIndex = 74;
            // 
            // tabPageAdventureSite
            // 
            this.tabPageAdventureSite.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdventureSite.Controls.Add(this.lblRooms);
            this.tabPageAdventureSite.Controls.Add(this.dgvRooms);
            this.tabPageAdventureSite.Controls.Add(this.lblLocation);
            this.tabPageAdventureSite.Controls.Add(this.tbLocation);
            this.tabPageAdventureSite.Controls.Add(this.tbDescription);
            this.tabPageAdventureSite.Controls.Add(this.lblDesc);
            this.tabPageAdventureSite.Controls.Add(this.tbName);
            this.tabPageAdventureSite.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdventureSite.Name = "tabPageAdventureSite";
            this.tabPageAdventureSite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdventureSite.Size = new System.Drawing.Size(586, 439);
            this.tabPageAdventureSite.TabIndex = 0;
            this.tabPageAdventureSite.Text = "Information";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(6, 169);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(56, 19);
            this.lblRooms.TabIndex = 6;
            this.lblRooms.Text = "Rooms";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.ColumnHeadersVisible = false;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoom});
            this.dgvRooms.Location = new System.Drawing.Point(10, 191);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(240, 160);
            this.dgvRooms.TabIndex = 5;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellValueChanged);
            // 
            // colRoom
            // 
            this.colRoom.HeaderText = "Room";
            this.colRoom.Name = "colRoom";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(347, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(67, 19);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(420, 10);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(156, 20);
            this.tbLocation.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(10, 72);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(566, 73);
            this.tbDescription.TabIndex = 2;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(6, 50);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 19);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(8, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(218, 26);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Name";
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // AdventureSiteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabAdventureSite);
            this.Controls.Add(this.btnSave);
            this.Name = "AdventureSiteControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.tabAdventureSite.ResumeLayout(false);
            this.tabPageAdventureSite.ResumeLayout(false);
            this.tabPageAdventureSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabAdventureSite;
        private System.Windows.Forms.TabPage tabPageAdventureSite;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
    }
}
