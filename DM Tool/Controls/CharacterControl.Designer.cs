﻿namespace DM_Tool.Controls
{
    partial class CharacterControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCharacterSheet = new System.Windows.Forms.TabControl();
            this.tabPageCharacterSheet = new System.Windows.Forms.TabPage();
            this.tbHD = new System.Windows.Forms.TextBox();
            this.tbRacialHD = new System.Windows.Forms.TextBox();
            this.dgvSpecials = new System.Windows.Forms.DataGridView();
            this.colFeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialAttacks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialQualities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlaws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbLevels = new System.Windows.Forms.TextBox();
            this.tbClasses = new System.Windows.Forms.TextBox();
            this.ctxtClasses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbRaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFFAC = new System.Windows.Forms.Label();
            this.tbFFAC = new System.Windows.Forms.TextBox();
            this.lblTouchAC = new System.Windows.Forms.Label();
            this.tbTouchAC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInitDex = new System.Windows.Forms.Label();
            this.tbInitMisc = new System.Windows.Forms.TextBox();
            this.tbInitDex = new System.Windows.Forms.TextBox();
            this.tbReach = new System.Windows.Forms.TextBox();
            this.tbGrapple = new System.Windows.Forms.TextBox();
            this.tbDefAC = new System.Windows.Forms.TextBox();
            this.tbShieldAC = new System.Windows.Forms.TextBox();
            this.tbArmorAC = new System.Windows.Forms.TextBox();
            this.tbNatAC = new System.Windows.Forms.TextBox();
            this.tbDexAC = new System.Windows.Forms.TextBox();
            this.tbSizeAC = new System.Windows.Forms.TextBox();
            this.lblTotalAc = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.tbSpace = new System.Windows.Forms.TextBox();
            this.tbFullAttack = new System.Windows.Forms.TextBox();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.tbTotalAC = new System.Windows.Forms.TextBox();
            this.tbInit = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbWill = new System.Windows.Forms.TextBox();
            this.lblWill = new System.Windows.Forms.Label();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.tbCha = new System.Windows.Forms.TextBox();
            this.lblCha = new System.Windows.Forms.Label();
            this.tbWis = new System.Windows.Forms.TextBox();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.tbCon = new System.Windows.Forms.TextBox();
            this.tbDex = new System.Windows.Forms.TextBox();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.lblStr = new System.Windows.Forms.Label();
            this.tbFort = new System.Windows.Forms.TextBox();
            this.lblFort = new System.Windows.Forms.Label();
            this.tbBAB = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.lblBABGrapple = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.colClassSkill = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAbility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRanks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkCampaign = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblHP = new System.Windows.Forms.Label();
            this.tabCharacterSheet.SuspendLayout();
            this.tabPageCharacterSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecials)).BeginInit();
            this.tabSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCharacterSheet
            // 
            this.tabCharacterSheet.Controls.Add(this.tabPageCharacterSheet);
            this.tabCharacterSheet.Controls.Add(this.tabSkills);
            this.tabCharacterSheet.Location = new System.Drawing.Point(3, 3);
            this.tabCharacterSheet.Name = "tabCharacterSheet";
            this.tabCharacterSheet.SelectedIndex = 0;
            this.tabCharacterSheet.Size = new System.Drawing.Size(594, 465);
            this.tabCharacterSheet.TabIndex = 75;
            // 
            // tabPageCharacterSheet
            // 
            this.tabPageCharacterSheet.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCharacterSheet.Controls.Add(this.lblHP);
            this.tabPageCharacterSheet.Controls.Add(this.tbHD);
            this.tabPageCharacterSheet.Controls.Add(this.tbRacialHD);
            this.tabPageCharacterSheet.Controls.Add(this.dgvSpecials);
            this.tabPageCharacterSheet.Controls.Add(this.tbLevels);
            this.tabPageCharacterSheet.Controls.Add(this.tbClasses);
            this.tabPageCharacterSheet.Controls.Add(this.tbRaceName);
            this.tabPageCharacterSheet.Controls.Add(this.label2);
            this.tabPageCharacterSheet.Controls.Add(this.lblFFAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbFFAC);
            this.tabPageCharacterSheet.Controls.Add(this.lblTouchAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbTouchAC);
            this.tabPageCharacterSheet.Controls.Add(this.label1);
            this.tabPageCharacterSheet.Controls.Add(this.lblInitDex);
            this.tabPageCharacterSheet.Controls.Add(this.tbInitMisc);
            this.tabPageCharacterSheet.Controls.Add(this.tbInitDex);
            this.tabPageCharacterSheet.Controls.Add(this.tbReach);
            this.tabPageCharacterSheet.Controls.Add(this.tbGrapple);
            this.tabPageCharacterSheet.Controls.Add(this.tbDefAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbShieldAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbArmorAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbNatAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbDexAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbSizeAC);
            this.tabPageCharacterSheet.Controls.Add(this.lblTotalAc);
            this.tabPageCharacterSheet.Controls.Add(this.tbSpeed);
            this.tabPageCharacterSheet.Controls.Add(this.cbSize);
            this.tabPageCharacterSheet.Controls.Add(this.lblInit);
            this.tabPageCharacterSheet.Controls.Add(this.tbSpace);
            this.tabPageCharacterSheet.Controls.Add(this.tbFullAttack);
            this.tabPageCharacterSheet.Controls.Add(this.tbAttack);
            this.tabPageCharacterSheet.Controls.Add(this.tbTotalAC);
            this.tabPageCharacterSheet.Controls.Add(this.tbInit);
            this.tabPageCharacterSheet.Controls.Add(this.tbName);
            this.tabPageCharacterSheet.Controls.Add(this.tbWill);
            this.tabPageCharacterSheet.Controls.Add(this.lblWill);
            this.tabPageCharacterSheet.Controls.Add(this.tbRef);
            this.tabPageCharacterSheet.Controls.Add(this.lblRef);
            this.tabPageCharacterSheet.Controls.Add(this.tbCha);
            this.tabPageCharacterSheet.Controls.Add(this.lblCha);
            this.tabPageCharacterSheet.Controls.Add(this.tbWis);
            this.tabPageCharacterSheet.Controls.Add(this.lblWis);
            this.tabPageCharacterSheet.Controls.Add(this.lblInt);
            this.tabPageCharacterSheet.Controls.Add(this.lblCon);
            this.tabPageCharacterSheet.Controls.Add(this.lblDex);
            this.tabPageCharacterSheet.Controls.Add(this.tbInt);
            this.tabPageCharacterSheet.Controls.Add(this.tbCon);
            this.tabPageCharacterSheet.Controls.Add(this.tbDex);
            this.tabPageCharacterSheet.Controls.Add(this.tbStr);
            this.tabPageCharacterSheet.Controls.Add(this.lblStr);
            this.tabPageCharacterSheet.Controls.Add(this.tbFort);
            this.tabPageCharacterSheet.Controls.Add(this.lblFort);
            this.tabPageCharacterSheet.Controls.Add(this.tbBAB);
            this.tabPageCharacterSheet.Controls.Add(this.tbHP);
            this.tabPageCharacterSheet.Controls.Add(this.lblBABGrapple);
            this.tabPageCharacterSheet.Controls.Add(this.cbType);
            this.tabPageCharacterSheet.Location = new System.Drawing.Point(4, 22);
            this.tabPageCharacterSheet.Name = "tabPageCharacterSheet";
            this.tabPageCharacterSheet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharacterSheet.Size = new System.Drawing.Size(586, 439);
            this.tabPageCharacterSheet.TabIndex = 0;
            this.tabPageCharacterSheet.Text = "Character Sheet";
            // 
            // tbHD
            // 
            this.tbHD.Location = new System.Drawing.Point(8, 59);
            this.tbHD.Name = "tbHD";
            this.tbHD.Size = new System.Drawing.Size(205, 20);
            this.tbHD.TabIndex = 146;
            this.toolTip1.SetToolTip(this.tbHD, "Hit Dice HP calculations");
            // 
            // tbRacialHD
            // 
            this.tbRacialHD.Location = new System.Drawing.Point(219, 33);
            this.tbRacialHD.Name = "tbRacialHD";
            this.tbRacialHD.Size = new System.Drawing.Size(29, 20);
            this.tbRacialHD.TabIndex = 145;
            this.tbRacialHD.Text = "0";
            this.toolTip1.SetToolTip(this.tbRacialHD, "Racial HD");
            // 
            // dgvSpecials
            // 
            this.dgvSpecials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFeats,
            this.colSpecialAttacks,
            this.colSpecialQualities,
            this.colFlaws,
            this.colTrais});
            this.dgvSpecials.Location = new System.Drawing.Point(8, 338);
            this.dgvSpecials.MultiSelect = false;
            this.dgvSpecials.Name = "dgvSpecials";
            this.dgvSpecials.RowHeadersVisible = false;
            this.dgvSpecials.Size = new System.Drawing.Size(572, 95);
            this.dgvSpecials.TabIndex = 143;
            // 
            // colFeats
            // 
            this.colFeats.HeaderText = "Feats";
            this.colFeats.Name = "colFeats";
            // 
            // colSpecialAttacks
            // 
            this.colSpecialAttacks.HeaderText = "Spec. Attacks";
            this.colSpecialAttacks.Name = "colSpecialAttacks";
            // 
            // colSpecialQualities
            // 
            this.colSpecialQualities.HeaderText = "Spec. Qualities";
            this.colSpecialQualities.Name = "colSpecialQualities";
            // 
            // colFlaws
            // 
            this.colFlaws.HeaderText = "Flaws";
            this.colFlaws.Name = "colFlaws";
            // 
            // colTrais
            // 
            this.colTrais.HeaderText = "Traits";
            this.colTrais.Name = "colTrais";
            // 
            // tbLevels
            // 
            this.tbLevels.Location = new System.Drawing.Point(358, 6);
            this.tbLevels.Name = "tbLevels";
            this.tbLevels.Size = new System.Drawing.Size(100, 20);
            this.tbLevels.TabIndex = 142;
            this.toolTip1.SetToolTip(this.tbLevels, "Levels [1/2/3/4]");
            this.tbLevels.Leave += new System.EventHandler(this.tbClassesLevels_Leave);
            // 
            // tbClasses
            // 
            this.tbClasses.ContextMenuStrip = this.ctxtClasses;
            this.tbClasses.Location = new System.Drawing.Point(252, 6);
            this.tbClasses.Name = "tbClasses";
            this.tbClasses.Size = new System.Drawing.Size(100, 20);
            this.tbClasses.TabIndex = 141;
            this.toolTip1.SetToolTip(this.tbClasses, "Classes [1/2/3/4] Right-click to open classes");
            this.tbClasses.Leave += new System.EventHandler(this.tbClassesLevels_Leave);
            this.tbClasses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbClasses_MouseDown);
            // 
            // ctxtClasses
            // 
            this.ctxtClasses.Name = "ctxtClasses";
            this.ctxtClasses.Size = new System.Drawing.Size(61, 4);
            this.ctxtClasses.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxtClasses_ItemClicked);
            // 
            // tbRaceName
            // 
            this.tbRaceName.Location = new System.Drawing.Point(146, 6);
            this.tbRaceName.Name = "tbRaceName";
            this.tbRaceName.Size = new System.Drawing.Size(89, 20);
            this.tbRaceName.TabIndex = 140;
            this.tbRaceName.Text = "Race";
            this.tbRaceName.Leave += new System.EventHandler(this.tbRaceName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Speed:";
            // 
            // lblFFAC
            // 
            this.lblFFAC.AutoSize = true;
            this.lblFFAC.Location = new System.Drawing.Point(328, 136);
            this.lblFFAC.Name = "lblFFAC";
            this.lblFFAC.Size = new System.Drawing.Size(60, 13);
            this.lblFFAC.TabIndex = 138;
            this.lblFFAC.Text = "Flat-Footed";
            // 
            // tbFFAC
            // 
            this.tbFFAC.Location = new System.Drawing.Point(394, 133);
            this.tbFFAC.Name = "tbFFAC";
            this.tbFFAC.Size = new System.Drawing.Size(20, 20);
            this.tbFFAC.TabIndex = 137;
            this.tbFFAC.Text = "0";
            // 
            // lblTouchAC
            // 
            this.lblTouchAC.AutoSize = true;
            this.lblTouchAC.Location = new System.Drawing.Point(258, 136);
            this.lblTouchAC.Name = "lblTouchAC";
            this.lblTouchAC.Size = new System.Drawing.Size(38, 13);
            this.lblTouchAC.TabIndex = 136;
            this.lblTouchAC.Text = "Touch";
            // 
            // tbTouchAC
            // 
            this.tbTouchAC.Location = new System.Drawing.Point(302, 133);
            this.tbTouchAC.Name = "tbTouchAC";
            this.tbTouchAC.Size = new System.Drawing.Size(20, 20);
            this.tbTouchAC.TabIndex = 135;
            this.tbTouchAC.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Misc:";
            // 
            // lblInitDex
            // 
            this.lblInitDex.AutoSize = true;
            this.lblInitDex.Location = new System.Drawing.Point(57, 87);
            this.lblInitDex.Name = "lblInitDex";
            this.lblInitDex.Size = new System.Drawing.Size(29, 13);
            this.lblInitDex.TabIndex = 133;
            this.lblInitDex.Text = "Dex:";
            // 
            // tbInitMisc
            // 
            this.tbInitMisc.Location = new System.Drawing.Point(150, 84);
            this.tbInitMisc.Name = "tbInitMisc";
            this.tbInitMisc.Size = new System.Drawing.Size(20, 20);
            this.tbInitMisc.TabIndex = 132;
            this.tbInitMisc.Text = "0";
            this.tbInitMisc.TextChanged += new System.EventHandler(this.tbInitMisc_TextChanged);
            // 
            // tbInitDex
            // 
            this.tbInitDex.Location = new System.Drawing.Point(92, 84);
            this.tbInitDex.Name = "tbInitDex";
            this.tbInitDex.Size = new System.Drawing.Size(20, 20);
            this.tbInitDex.TabIndex = 131;
            this.tbInitDex.Text = "0";
            this.tbInitDex.TextChanged += new System.EventHandler(this.tbInitDex_TextChanged);
            // 
            // tbReach
            // 
            this.tbReach.Location = new System.Drawing.Point(88, 236);
            this.tbReach.Name = "tbReach";
            this.tbReach.Size = new System.Drawing.Size(20, 20);
            this.tbReach.TabIndex = 130;
            this.tbReach.Text = "5";
            // 
            // tbGrapple
            // 
            this.tbGrapple.Location = new System.Drawing.Point(150, 158);
            this.tbGrapple.Name = "tbGrapple";
            this.tbGrapple.ReadOnly = true;
            this.tbGrapple.Size = new System.Drawing.Size(47, 20);
            this.tbGrapple.TabIndex = 129;
            // 
            // tbDefAC
            // 
            this.tbDefAC.Location = new System.Drawing.Point(228, 133);
            this.tbDefAC.Name = "tbDefAC";
            this.tbDefAC.Size = new System.Drawing.Size(20, 20);
            this.tbDefAC.TabIndex = 128;
            this.tbDefAC.Text = "0";
            this.tbDefAC.TextChanged += new System.EventHandler(this.tbDefAC_TextChanged);
            // 
            // tbShieldAC
            // 
            this.tbShieldAC.Location = new System.Drawing.Point(202, 133);
            this.tbShieldAC.Name = "tbShieldAC";
            this.tbShieldAC.Size = new System.Drawing.Size(20, 20);
            this.tbShieldAC.TabIndex = 127;
            this.tbShieldAC.Text = "0";
            this.tbShieldAC.TextChanged += new System.EventHandler(this.tbShieldAC_TextChanged);
            // 
            // tbArmorAC
            // 
            this.tbArmorAC.Location = new System.Drawing.Point(176, 133);
            this.tbArmorAC.Name = "tbArmorAC";
            this.tbArmorAC.Size = new System.Drawing.Size(20, 20);
            this.tbArmorAC.TabIndex = 126;
            this.tbArmorAC.Text = "0";
            this.tbArmorAC.TextChanged += new System.EventHandler(this.tbArmorAC_TextChanged);
            // 
            // tbNatAC
            // 
            this.tbNatAC.Location = new System.Drawing.Point(150, 133);
            this.tbNatAC.Name = "tbNatAC";
            this.tbNatAC.Size = new System.Drawing.Size(20, 20);
            this.tbNatAC.TabIndex = 125;
            this.tbNatAC.Text = "0";
            this.tbNatAC.TextChanged += new System.EventHandler(this.tbNatAC_TextChanged);
            // 
            // tbDexAC
            // 
            this.tbDexAC.Enabled = false;
            this.tbDexAC.Location = new System.Drawing.Point(124, 133);
            this.tbDexAC.Name = "tbDexAC";
            this.tbDexAC.ReadOnly = true;
            this.tbDexAC.Size = new System.Drawing.Size(20, 20);
            this.tbDexAC.TabIndex = 124;
            this.tbDexAC.TextChanged += new System.EventHandler(this.tbDexAC_TextChanged);
            // 
            // tbSizeAC
            // 
            this.tbSizeAC.Enabled = false;
            this.tbSizeAC.Location = new System.Drawing.Point(99, 133);
            this.tbSizeAC.Name = "tbSizeAC";
            this.tbSizeAC.ReadOnly = true;
            this.tbSizeAC.Size = new System.Drawing.Size(20, 20);
            this.tbSizeAC.TabIndex = 123;
            this.tbSizeAC.TextChanged += new System.EventHandler(this.tbSizeAC_TextChanged);
            // 
            // lblTotalAc
            // 
            this.lblTotalAc.AutoSize = true;
            this.lblTotalAc.Location = new System.Drawing.Point(8, 136);
            this.lblTotalAc.Name = "lblTotalAc";
            this.lblTotalAc.Size = new System.Drawing.Size(24, 13);
            this.lblTotalAc.TabIndex = 122;
            this.lblTotalAc.Text = "AC:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(59, 107);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbSpeed.TabIndex = 121;
            this.tbSpeed.Text = "30";
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(8, 32);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(78, 21);
            this.cbSize.TabIndex = 120;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(8, 87);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(24, 13);
            this.lblInit.TabIndex = 119;
            this.lblInit.Text = "Init:";
            // 
            // tbSpace
            // 
            this.tbSpace.Location = new System.Drawing.Point(60, 236);
            this.tbSpace.Name = "tbSpace";
            this.tbSpace.Size = new System.Drawing.Size(20, 20);
            this.tbSpace.TabIndex = 115;
            this.tbSpace.Text = "5";
            // 
            // tbFullAttack
            // 
            this.tbFullAttack.Location = new System.Drawing.Point(59, 210);
            this.tbFullAttack.Name = "tbFullAttack";
            this.tbFullAttack.Size = new System.Drawing.Size(449, 20);
            this.tbFullAttack.TabIndex = 114;
            this.tbFullAttack.Text = "Full Attack";
            // 
            // tbAttack
            // 
            this.tbAttack.Location = new System.Drawing.Point(59, 184);
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(449, 20);
            this.tbAttack.TabIndex = 113;
            this.tbAttack.Text = "Attack";
            // 
            // tbTotalAC
            // 
            this.tbTotalAC.Location = new System.Drawing.Point(60, 133);
            this.tbTotalAC.Name = "tbTotalAC";
            this.tbTotalAC.Size = new System.Drawing.Size(33, 20);
            this.tbTotalAC.TabIndex = 112;
            this.tbTotalAC.Text = "0";
            // 
            // tbInit
            // 
            this.tbInit.Location = new System.Drawing.Point(36, 84);
            this.tbInit.Name = "tbInit";
            this.tbInit.Size = new System.Drawing.Size(21, 20);
            this.tbInit.TabIndex = 111;
            this.tbInit.Text = "0";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(8, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(132, 20);
            this.tbName.TabIndex = 110;
            this.tbName.Text = "Name";
            // 
            // tbWill
            // 
            this.tbWill.Location = new System.Drawing.Point(223, 262);
            this.tbWill.Name = "tbWill";
            this.tbWill.Size = new System.Drawing.Size(33, 20);
            this.tbWill.TabIndex = 109;
            // 
            // lblWill
            // 
            this.lblWill.AutoSize = true;
            this.lblWill.Location = new System.Drawing.Point(193, 265);
            this.lblWill.Name = "lblWill";
            this.lblWill.Size = new System.Drawing.Size(24, 13);
            this.lblWill.TabIndex = 108;
            this.lblWill.Text = "Will";
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(154, 262);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(33, 20);
            this.tbRef.TabIndex = 107;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(124, 265);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(24, 13);
            this.lblRef.TabIndex = 106;
            this.lblRef.Text = "Ref";
            // 
            // tbCha
            // 
            this.tbCha.Location = new System.Drawing.Point(428, 289);
            this.tbCha.Name = "tbCha";
            this.tbCha.Size = new System.Drawing.Size(33, 20);
            this.tbCha.TabIndex = 105;
            this.tbCha.Text = "10";
            this.tbCha.TextChanged += new System.EventHandler(this.tbCha_TextChanged);
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(396, 292);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(26, 13);
            this.lblCha.TabIndex = 104;
            this.lblCha.Text = "Cha";
            // 
            // tbWis
            // 
            this.tbWis.Location = new System.Drawing.Point(357, 289);
            this.tbWis.Name = "tbWis";
            this.tbWis.Size = new System.Drawing.Size(33, 20);
            this.tbWis.TabIndex = 103;
            this.tbWis.Text = "10";
            this.tbWis.TextChanged += new System.EventHandler(this.tbWis_TextChanged);
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(326, 292);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(25, 13);
            this.lblWis.TabIndex = 102;
            this.lblWis.Text = "Wis";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(262, 292);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(19, 13);
            this.lblInt.TabIndex = 101;
            this.lblInt.Text = "Int";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(193, 292);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(26, 13);
            this.lblCon.TabIndex = 100;
            this.lblCon.Text = "Con";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(124, 292);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(26, 13);
            this.lblDex.TabIndex = 99;
            this.lblDex.Text = "Dex";
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(287, 289);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(33, 20);
            this.tbInt.TabIndex = 98;
            this.tbInt.Text = "10";
            this.tbInt.TextChanged += new System.EventHandler(this.tbInt_TextChanged);
            // 
            // tbCon
            // 
            this.tbCon.Location = new System.Drawing.Point(223, 289);
            this.tbCon.Name = "tbCon";
            this.tbCon.Size = new System.Drawing.Size(33, 20);
            this.tbCon.TabIndex = 97;
            this.tbCon.Text = "10";
            this.tbCon.TextChanged += new System.EventHandler(this.tbCon_TextChanged);
            // 
            // tbDex
            // 
            this.tbDex.Location = new System.Drawing.Point(154, 289);
            this.tbDex.Name = "tbDex";
            this.tbDex.Size = new System.Drawing.Size(33, 20);
            this.tbDex.TabIndex = 96;
            this.tbDex.Text = "10";
            this.tbDex.TextChanged += new System.EventHandler(this.tbDex_TextChanged);
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(85, 289);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(33, 20);
            this.tbStr.TabIndex = 95;
            this.tbStr.Text = "10";
            this.tbStr.TextChanged += new System.EventHandler(this.tbStr_TextChanged);
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(61, 292);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(20, 13);
            this.lblStr.TabIndex = 94;
            this.lblStr.Text = "Str";
            // 
            // tbFort
            // 
            this.tbFort.Location = new System.Drawing.Point(85, 262);
            this.tbFort.Name = "tbFort";
            this.tbFort.Size = new System.Drawing.Size(33, 20);
            this.tbFort.TabIndex = 93;
            // 
            // lblFort
            // 
            this.lblFort.AutoSize = true;
            this.lblFort.Location = new System.Drawing.Point(61, 265);
            this.lblFort.Name = "lblFort";
            this.lblFort.Size = new System.Drawing.Size(25, 13);
            this.lblFort.TabIndex = 92;
            this.lblFort.Text = "Fort";
            // 
            // tbBAB
            // 
            this.tbBAB.Location = new System.Drawing.Point(100, 158);
            this.tbBAB.Name = "tbBAB";
            this.tbBAB.ReadOnly = true;
            this.tbBAB.Size = new System.Drawing.Size(47, 20);
            this.tbBAB.TabIndex = 90;
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(219, 59);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(29, 20);
            this.tbHP.TabIndex = 89;
            this.tbHP.Text = "0";
            this.toolTip1.SetToolTip(this.tbHP, "Total HP");
            // 
            // lblBABGrapple
            // 
            this.lblBABGrapple.AutoSize = true;
            this.lblBABGrapple.Location = new System.Drawing.Point(8, 161);
            this.lblBABGrapple.Name = "lblBABGrapple";
            this.lblBABGrapple.Size = new System.Drawing.Size(70, 13);
            this.lblBABGrapple.TabIndex = 87;
            this.lblBABGrapple.Text = "BAB/Grapple";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(92, 32);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 83;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // tabSkills
            // 
            this.tabSkills.Controls.Add(this.dgvSkills);
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Size = new System.Drawing.Size(586, 439);
            this.tabSkills.TabIndex = 1;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // dgvSkills
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            this.dgvSkills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClassSkill,
            this.colAbility,
            this.colSkillName,
            this.colTotal,
            this.colMod,
            this.colRanks,
            this.colMisc});
            this.dgvSkills.Location = new System.Drawing.Point(3, 3);
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.RowHeadersVisible = false;
            this.dgvSkills.Size = new System.Drawing.Size(580, 433);
            this.dgvSkills.TabIndex = 0;
            this.dgvSkills.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkills_CellValueChanged);
            // 
            // colClassSkill
            // 
            this.colClassSkill.FillWeight = 7F;
            this.colClassSkill.HeaderText = "Class Skill";
            this.colClassSkill.Name = "colClassSkill";
            this.colClassSkill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClassSkill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAbility
            // 
            this.colAbility.FillWeight = 7F;
            this.colAbility.HeaderText = "Stat";
            this.colAbility.Name = "colAbility";
            // 
            // colSkillName
            // 
            this.colSkillName.FillWeight = 50F;
            this.colSkillName.HeaderText = "Skill";
            this.colSkillName.Name = "colSkillName";
            this.colSkillName.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTotal.FillWeight = 10F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colMod
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMod.DefaultCellStyle = dataGridViewCellStyle8;
            this.colMod.FillWeight = 10F;
            this.colMod.HeaderText = "Ability Mod";
            this.colMod.Name = "colMod";
            // 
            // colRanks
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRanks.DefaultCellStyle = dataGridViewCellStyle9;
            this.colRanks.FillWeight = 10F;
            this.colRanks.HeaderText = "Ranks";
            this.colRanks.Name = "colRanks";
            // 
            // colMisc
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMisc.DefaultCellStyle = dataGridViewCellStyle10;
            this.colMisc.FillWeight = 10F;
            this.colMisc.HeaderText = "Misc";
            this.colMisc.Name = "colMisc";
            // 
            // chkCampaign
            // 
            this.chkCampaign.AutoSize = true;
            this.chkCampaign.Location = new System.Drawing.Point(95, 478);
            this.chkCampaign.Name = "chkCampaign";
            this.chkCampaign.Size = new System.Drawing.Size(73, 17);
            this.chkCampaign.TabIndex = 144;
            this.chkCampaign.Text = "Campaign";
            this.chkCampaign.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(512, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.IsBalloon = true;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(249, 62);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 147;
            this.lblHP.Text = "HP";
            // 
            // CharacterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkCampaign);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabCharacterSheet);
            this.Name = "CharacterControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.tabCharacterSheet.ResumeLayout(false);
            this.tabPageCharacterSheet.ResumeLayout(false);
            this.tabPageCharacterSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecials)).EndInit();
            this.tabSkills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCharacterSheet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabPageCharacterSheet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.DataGridView dgvSkills;
        private System.Windows.Forms.TextBox tbLevels;
        private System.Windows.Forms.TextBox tbClasses;
        private System.Windows.Forms.TextBox tbRaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFFAC;
        private System.Windows.Forms.TextBox tbFFAC;
        private System.Windows.Forms.Label lblTouchAC;
        private System.Windows.Forms.TextBox tbTouchAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInitDex;
        private System.Windows.Forms.TextBox tbInitMisc;
        private System.Windows.Forms.TextBox tbInitDex;
        private System.Windows.Forms.TextBox tbReach;
        private System.Windows.Forms.TextBox tbGrapple;
        private System.Windows.Forms.TextBox tbDefAC;
        private System.Windows.Forms.TextBox tbShieldAC;
        private System.Windows.Forms.TextBox tbArmorAC;
        private System.Windows.Forms.TextBox tbNatAC;
        private System.Windows.Forms.TextBox tbDexAC;
        private System.Windows.Forms.TextBox tbSizeAC;
        private System.Windows.Forms.Label lblTotalAc;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.TextBox tbSpace;
        private System.Windows.Forms.TextBox tbFullAttack;
        private System.Windows.Forms.TextBox tbAttack;
        private System.Windows.Forms.TextBox tbTotalAC;
        private System.Windows.Forms.TextBox tbInit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbWill;
        private System.Windows.Forms.Label lblWill;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox tbCha;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.TextBox tbWis;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.TextBox tbInt;
        private System.Windows.Forms.TextBox tbCon;
        private System.Windows.Forms.TextBox tbDex;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.TextBox tbFort;
        private System.Windows.Forms.Label lblFort;
        private System.Windows.Forms.TextBox tbBAB;
        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.Label lblBABGrapple;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colClassSkill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRanks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMisc;
        private System.Windows.Forms.DataGridView dgvSpecials;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialAttacks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialQualities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlaws;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrais;
        private System.Windows.Forms.CheckBox chkCampaign;
        private System.Windows.Forms.ContextMenuStrip ctxtClasses;
        private System.Windows.Forms.TextBox tbRacialHD;
        private System.Windows.Forms.TextBox tbHD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblHP;
    }
}
