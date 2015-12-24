namespace DM_Tool
{
    partial class Combat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCombat = new System.Windows.Forms.DataGridView();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Init = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reflex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.will = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtCombat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setActiveTurnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvEffects = new System.Windows.Forms.DataGridView();
            this.EffectsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEffects = new System.Windows.Forms.Label();
            this.btnNewEffect = new System.Windows.Forms.Button();
            this.btnDeleteEffect = new System.Windows.Forms.Button();
            this.btnAddCharacters = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombat)).BeginInit();
            this.ctxtCombat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEffects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCombat
            // 
            this.dgvCombat.AllowUserToAddRows = false;
            this.dgvCombat.AllowUserToDeleteRows = false;
            this.dgvCombat.AllowUserToOrderColumns = true;
            this.dgvCombat.AllowUserToResizeColumns = false;
            this.dgvCombat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCombat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCombat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCombat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacterName,
            this.Init,
            this.AC,
            this.currHp,
            this.maxHP,
            this.fort,
            this.reflex,
            this.will,
            this.Icon});
            this.dgvCombat.Location = new System.Drawing.Point(0, 3);
            this.dgvCombat.MultiSelect = false;
            this.dgvCombat.Name = "dgvCombat";
            this.dgvCombat.RowHeadersVisible = false;
            this.dgvCombat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCombat.Size = new System.Drawing.Size(585, 211);
            this.dgvCombat.TabIndex = 0;
            this.dgvCombat.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCombat_CellBeginEdit);
            this.dgvCombat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCombat_CellValueChanged);
            this.dgvCombat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCombat_DataError);
            this.dgvCombat.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCombat_EditingControlShowing);
            this.dgvCombat.Leave += new System.EventHandler(this.dgvCombat_Leave);
            this.dgvCombat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCombat_MouseDown);
            // 
            // CharacterName
            // 
            this.CharacterName.FillWeight = 30F;
            this.CharacterName.HeaderText = "Name";
            this.CharacterName.Name = "CharacterName";
            // 
            // Init
            // 
            this.Init.FillWeight = 10F;
            this.Init.HeaderText = "Init";
            this.Init.Name = "Init";
            // 
            // AC
            // 
            this.AC.FillWeight = 10F;
            this.AC.HeaderText = "AC";
            this.AC.Name = "AC";
            // 
            // currHp
            // 
            this.currHp.FillWeight = 10F;
            this.currHp.HeaderText = "HP";
            this.currHp.Name = "currHp";
            // 
            // maxHP
            // 
            this.maxHP.FillWeight = 10F;
            this.maxHP.HeaderText = "Max";
            this.maxHP.Name = "maxHP";
            // 
            // fort
            // 
            this.fort.FillWeight = 10F;
            this.fort.HeaderText = "Fort";
            this.fort.Name = "fort";
            // 
            // reflex
            // 
            this.reflex.FillWeight = 10F;
            this.reflex.HeaderText = "Ref";
            this.reflex.Name = "reflex";
            // 
            // will
            // 
            this.will.FillWeight = 10F;
            this.will.HeaderText = "Will";
            this.will.Name = "will";
            // 
            // Icon
            // 
            this.Icon.FillWeight = 20F;
            this.Icon.HeaderText = "Icon";
            this.Icon.Name = "Icon";
            // 
            // ctxtCombat
            // 
            this.ctxtCombat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCharacterToolStripMenuItem,
            this.setActiveTurnToolStripMenuItem,
            this.ctxtMenuItemDelete,
            this.toolStripSeparator1,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem});
            this.ctxtCombat.Name = "ctxtCombat";
            this.ctxtCombat.Size = new System.Drawing.Size(195, 120);
            // 
            // openCharacterToolStripMenuItem
            // 
            this.openCharacterToolStripMenuItem.Name = "openCharacterToolStripMenuItem";
            this.openCharacterToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openCharacterToolStripMenuItem.Text = "Open Character";
            this.openCharacterToolStripMenuItem.Click += new System.EventHandler(this.openCharacterToolStripMenuItem_Click);
            // 
            // setActiveTurnToolStripMenuItem
            // 
            this.setActiveTurnToolStripMenuItem.Name = "setActiveTurnToolStripMenuItem";
            this.setActiveTurnToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.setActiveTurnToolStripMenuItem.Text = "Set Active Turn";
            this.setActiveTurnToolStripMenuItem.Click += new System.EventHandler(this.setActiveTurnToolStripMenuItem_Click);
            // 
            // ctxtMenuItemDelete
            // 
            this.ctxtMenuItemDelete.Name = "ctxtMenuItemDelete";
            this.ctxtMenuItemDelete.Size = new System.Drawing.Size(194, 22);
            this.ctxtMenuItemDelete.Text = "Remove From Combat";
            this.ctxtMenuItemDelete.Click += new System.EventHandler(this.ctxtMenuItemDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(493, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(508, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(384, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Start Combat";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvEffects
            // 
            this.dgvEffects.AllowUserToAddRows = false;
            this.dgvEffects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEffects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEffects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EffectsName,
            this.Owner,
            this.Duration});
            this.dgvEffects.Location = new System.Drawing.Point(0, 285);
            this.dgvEffects.MultiSelect = false;
            this.dgvEffects.Name = "dgvEffects";
            this.dgvEffects.RowHeadersVisible = false;
            this.dgvEffects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEffects.Size = new System.Drawing.Size(585, 183);
            this.dgvEffects.TabIndex = 4;
            this.dgvEffects.Leave += new System.EventHandler(this.dgvEffects_Leave);
            // 
            // EffectsName
            // 
            this.EffectsName.HeaderText = "Name";
            this.EffectsName.Name = "EffectsName";
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            this.Owner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Owner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // lblEffects
            // 
            this.lblEffects.AutoSize = true;
            this.lblEffects.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffects.Location = new System.Drawing.Point(3, 263);
            this.lblEffects.Name = "lblEffects";
            this.lblEffects.Size = new System.Drawing.Size(56, 19);
            this.lblEffects.TabIndex = 8;
            this.lblEffects.Text = "Effects";
            // 
            // btnNewEffect
            // 
            this.btnNewEffect.Location = new System.Drawing.Point(3, 474);
            this.btnNewEffect.Name = "btnNewEffect";
            this.btnNewEffect.Size = new System.Drawing.Size(75, 23);
            this.btnNewEffect.TabIndex = 9;
            this.btnNewEffect.Text = "Add Effects";
            this.btnNewEffect.UseVisualStyleBackColor = true;
            this.btnNewEffect.Click += new System.EventHandler(this.btnNewEffect_Click);
            // 
            // btnDeleteEffect
            // 
            this.btnDeleteEffect.Location = new System.Drawing.Point(87, 474);
            this.btnDeleteEffect.Name = "btnDeleteEffect";
            this.btnDeleteEffect.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEffect.TabIndex = 10;
            this.btnDeleteEffect.Text = "Delete";
            this.btnDeleteEffect.UseVisualStyleBackColor = true;
            this.btnDeleteEffect.Click += new System.EventHandler(this.btnDeleteEffect_Click);
            // 
            // btnAddCharacters
            // 
            this.btnAddCharacters.Location = new System.Drawing.Point(3, 220);
            this.btnAddCharacters.Name = "btnAddCharacters";
            this.btnAddCharacters.Size = new System.Drawing.Size(96, 23);
            this.btnAddCharacters.TabIndex = 11;
            this.btnAddCharacters.Text = "Add Characters";
            this.btnAddCharacters.UseVisualStyleBackColor = true;
            this.btnAddCharacters.Click += new System.EventHandler(this.btnAddCharacters_Click);
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddCharacters);
            this.Controls.Add(this.btnDeleteEffect);
            this.Controls.Add(this.btnNewEffect);
            this.Controls.Add(this.lblEffects);
            this.Controls.Add(this.dgvEffects);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvCombat);
            this.Name = "Combat";
            this.Size = new System.Drawing.Size(600, 500);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combat_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombat)).EndInit();
            this.ctxtCombat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEffects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCombat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvEffects;
        private System.Windows.Forms.Label lblEffects;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectsName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btnNewEffect;
        private System.Windows.Forms.Button btnDeleteEffect;
        private System.Windows.Forms.Button btnAddCharacters;
        private System.Windows.Forms.ContextMenuStrip ctxtCombat;
        private System.Windows.Forms.ToolStripMenuItem ctxtMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem openCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Init;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC;
        private System.Windows.Forms.DataGridViewTextBoxColumn currHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn fort;
        private System.Windows.Forms.DataGridViewTextBoxColumn reflex;
        private System.Windows.Forms.DataGridViewTextBoxColumn will;
        private System.Windows.Forms.DataGridViewTextBoxColumn Icon;
        private System.Windows.Forms.ToolStripMenuItem setActiveTurnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
    }
}
