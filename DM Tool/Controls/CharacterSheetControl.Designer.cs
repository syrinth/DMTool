namespace DM_Tool
{/*
    partial class MonsterControl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewType = new System.Windows.Forms.Button();
            this.tbHDNum = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbBAB = new System.Windows.Forms.TextBox();
            this.tbHDSize = new System.Windows.Forms.TextBox();
            this.tbFort = new System.Windows.Forms.TextBox();
            this.lblFort = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.tbDex = new System.Windows.Forms.TextBox();
            this.tbCon = new System.Windows.Forms.TextBox();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.tbWis = new System.Windows.Forms.TextBox();
            this.lblCha = new System.Windows.Forms.Label();
            this.tbCha = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.lblWill = new System.Windows.Forms.Label();
            this.tbWill = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInit = new System.Windows.Forms.TextBox();
            this.tbTotalAC = new System.Windows.Forms.TextBox();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.tbFullAttack = new System.Windows.Forms.TextBox();
            this.tbSpace = new System.Windows.Forms.TextBox();
            this.tbSpecialAttacks = new System.Windows.Forms.TextBox();
            this.tbSpecialQualities = new System.Windows.Forms.TextBox();
            this.tbFeats = new System.Windows.Forms.TextBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lblTotalAc = new System.Windows.Forms.Label();
            this.tbSizeAC = new System.Windows.Forms.TextBox();
            this.tbDexAC = new System.Windows.Forms.TextBox();
            this.tbNatAC = new System.Windows.Forms.TextBox();
            this.tbArmorAC = new System.Windows.Forms.TextBox();
            this.tbShieldAC = new System.Windows.Forms.TextBox();
            this.tbDefAC = new System.Windows.Forms.TextBox();
            this.tbGrapple = new System.Windows.Forms.TextBox();
            this.tbReach = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbInitDex = new System.Windows.Forms.TextBox();
            this.tbInitMisc = new System.Windows.Forms.TextBox();
            this.lblInitDex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTouchAC = new System.Windows.Forms.Label();
            this.tbTouchAC = new System.Windows.Forms.TextBox();
            this.lblFFAC = new System.Windows.Forms.Label();
            this.tbFFAC = new System.Windows.Forms.TextBox();
            this.lblBABGrapple = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblHDSize = new System.Windows.Forms.Label();
            this.lblHDNum = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbRaceName = new System.Windows.Forms.TextBox();
            this.tbClasses = new System.Windows.Forms.TextBox();
            this.tbLevels = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(109, 32);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewType
            // 
            this.btnNewType.Location = new System.Drawing.Point(426, 474);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(75, 23);
            this.btnNewType.TabIndex = 3;
            this.btnNewType.Text = "New Type";
            this.btnNewType.UseVisualStyleBackColor = true;
            this.btnNewType.Visible = false;
            // 
            // tbHDNum
            // 
            this.tbHDNum.Location = new System.Drawing.Point(31, 59);
            this.tbHDNum.Name = "tbHDNum";
            this.tbHDNum.Size = new System.Drawing.Size(20, 20);
            this.tbHDNum.TabIndex = 8;
            this.tbHDNum.TextChanged += new System.EventHandler(this.tbHDNum_TextChanged);
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(115, 59);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(50, 20);
            this.tbHP.TabIndex = 10;
            // 
            // tbBAB
            // 
            this.tbBAB.Location = new System.Drawing.Point(95, 158);
            this.tbBAB.Name = "tbBAB";
            this.tbBAB.ReadOnly = true;
            this.tbBAB.Size = new System.Drawing.Size(47, 20);
            this.tbBAB.TabIndex = 11;
            // 
            // tbHDSize
            // 
            this.tbHDSize.Location = new System.Drawing.Point(66, 59);
            this.tbHDSize.Name = "tbHDSize";
            this.tbHDSize.ReadOnly = true;
            this.tbHDSize.Size = new System.Drawing.Size(20, 20);
            this.tbHDSize.TabIndex = 12;
            // 
            // tbFort
            // 
            this.tbFort.Location = new System.Drawing.Point(112, 314);
            this.tbFort.Name = "tbFort";
            this.tbFort.Size = new System.Drawing.Size(33, 20);
            this.tbFort.TabIndex = 14;
            // 
            // lblFort
            // 
            this.lblFort.AutoSize = true;
            this.lblFort.Location = new System.Drawing.Point(88, 317);
            this.lblFort.Name = "lblFort";
            this.lblFort.Size = new System.Drawing.Size(25, 13);
            this.lblFort.TabIndex = 13;
            this.lblFort.Text = "Fort";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(88, 344);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(20, 13);
            this.lblStr.TabIndex = 15;
            this.lblStr.Text = "Str";
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(112, 341);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(33, 20);
            this.tbStr.TabIndex = 16;
            this.tbStr.Text = "10";
            // 
            // tbDex
            // 
            this.tbDex.Location = new System.Drawing.Point(181, 341);
            this.tbDex.Name = "tbDex";
            this.tbDex.Size = new System.Drawing.Size(33, 20);
            this.tbDex.TabIndex = 17;
            this.tbDex.Text = "10";
            this.tbDex.TextChanged += new System.EventHandler(this.tbDex_TextChanged);
            // 
            // tbCon
            // 
            this.tbCon.Location = new System.Drawing.Point(250, 341);
            this.tbCon.Name = "tbCon";
            this.tbCon.Size = new System.Drawing.Size(33, 20);
            this.tbCon.TabIndex = 18;
            this.tbCon.Text = "10";
            this.tbCon.TextChanged += new System.EventHandler(this.tbCon_TextChanged);
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(314, 341);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(33, 20);
            this.tbInt.TabIndex = 19;
            this.tbInt.Text = "10";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(151, 344);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(26, 13);
            this.lblDex.TabIndex = 20;
            this.lblDex.Text = "Dex";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(220, 344);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(26, 13);
            this.lblCon.TabIndex = 21;
            this.lblCon.Text = "Con";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(289, 344);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(19, 13);
            this.lblInt.TabIndex = 22;
            this.lblInt.Text = "Int";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(353, 344);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(25, 13);
            this.lblWis.TabIndex = 23;
            this.lblWis.Text = "Wis";
            // 
            // tbWis
            // 
            this.tbWis.Location = new System.Drawing.Point(384, 341);
            this.tbWis.Name = "tbWis";
            this.tbWis.Size = new System.Drawing.Size(33, 20);
            this.tbWis.TabIndex = 24;
            this.tbWis.Text = "10";
            this.tbWis.TextChanged += new System.EventHandler(this.tbWis_TextChanged);
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(423, 344);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(26, 13);
            this.lblCha.TabIndex = 25;
            this.lblCha.Text = "Cha";
            // 
            // tbCha
            // 
            this.tbCha.Location = new System.Drawing.Point(455, 341);
            this.tbCha.Name = "tbCha";
            this.tbCha.Size = new System.Drawing.Size(33, 20);
            this.tbCha.TabIndex = 26;
            this.tbCha.Text = "10";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(151, 317);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(24, 13);
            this.lblRef.TabIndex = 27;
            this.lblRef.Text = "Ref";
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(181, 314);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(33, 20);
            this.tbRef.TabIndex = 28;
            // 
            // lblWill
            // 
            this.lblWill.AutoSize = true;
            this.lblWill.Location = new System.Drawing.Point(220, 317);
            this.lblWill.Name = "lblWill";
            this.lblWill.Size = new System.Drawing.Size(24, 13);
            this.lblWill.TabIndex = 29;
            this.lblWill.Text = "Will";
            // 
            // tbWill
            // 
            this.tbWill.Location = new System.Drawing.Point(250, 314);
            this.tbWill.Name = "tbWill";
            this.tbWill.Size = new System.Drawing.Size(33, 20);
            this.tbWill.TabIndex = 30;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(132, 20);
            this.tbName.TabIndex = 32;
            this.tbName.Text = "Name";
            this.toolTip.SetToolTip(this.tbName, "Character Name");
            // 
            // tbInit
            // 
            this.tbInit.Location = new System.Drawing.Point(31, 84);
            this.tbInit.Name = "tbInit";
            this.tbInit.Size = new System.Drawing.Size(21, 20);
            this.tbInit.TabIndex = 33;
            this.tbInit.Text = "0";
            // 
            // tbTotalAC
            // 
            this.tbTotalAC.Location = new System.Drawing.Point(55, 133);
            this.tbTotalAC.Name = "tbTotalAC";
            this.tbTotalAC.Size = new System.Drawing.Size(33, 20);
            this.tbTotalAC.TabIndex = 35;
            this.tbTotalAC.Text = "0";
            // 
            // tbAttack
            // 
            this.tbAttack.Location = new System.Drawing.Point(87, 184);
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(449, 20);
            this.tbAttack.TabIndex = 36;
            this.tbAttack.Text = "Attack";
            // 
            // tbFullAttack
            // 
            this.tbFullAttack.Location = new System.Drawing.Point(87, 210);
            this.tbFullAttack.Name = "tbFullAttack";
            this.tbFullAttack.Size = new System.Drawing.Size(449, 20);
            this.tbFullAttack.TabIndex = 37;
            this.tbFullAttack.Text = "Full Attack";
            // 
            // tbSpace
            // 
            this.tbSpace.Location = new System.Drawing.Point(87, 236);
            this.tbSpace.Name = "tbSpace";
            this.tbSpace.Size = new System.Drawing.Size(20, 20);
            this.tbSpace.TabIndex = 38;
            this.tbSpace.Text = "5";
            // 
            // tbSpecialAttacks
            // 
            this.tbSpecialAttacks.Location = new System.Drawing.Point(87, 262);
            this.tbSpecialAttacks.Name = "tbSpecialAttacks";
            this.tbSpecialAttacks.Size = new System.Drawing.Size(449, 20);
            this.tbSpecialAttacks.TabIndex = 39;
            this.tbSpecialAttacks.Text = "Special Attacks";
            // 
            // tbSpecialQualities
            // 
            this.tbSpecialQualities.Location = new System.Drawing.Point(87, 288);
            this.tbSpecialQualities.Name = "tbSpecialQualities";
            this.tbSpecialQualities.Size = new System.Drawing.Size(449, 20);
            this.tbSpecialQualities.TabIndex = 40;
            this.tbSpecialQualities.Text = "Special Qualities";
            // 
            // tbFeats
            // 
            this.tbFeats.Location = new System.Drawing.Point(87, 370);
            this.tbFeats.Name = "tbFeats";
            this.tbFeats.Size = new System.Drawing.Size(449, 20);
            this.tbFeats.TabIndex = 41;
            this.tbFeats.Text = "Feats";
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(3, 87);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(24, 13);
            this.lblInit.TabIndex = 42;
            this.lblInit.Text = "Init:";
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(3, 32);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(100, 21);
            this.cbSize.TabIndex = 44;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(54, 107);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbSpeed.TabIndex = 45;
            this.tbSpeed.Text = "30";
            // 
            // lblTotalAc
            // 
            this.lblTotalAc.AutoSize = true;
            this.lblTotalAc.Location = new System.Drawing.Point(3, 136);
            this.lblTotalAc.Name = "lblTotalAc";
            this.lblTotalAc.Size = new System.Drawing.Size(24, 13);
            this.lblTotalAc.TabIndex = 47;
            this.lblTotalAc.Text = "AC:";
            // 
            // tbSizeAC
            // 
            this.tbSizeAC.Enabled = false;
            this.tbSizeAC.Location = new System.Drawing.Point(94, 133);
            this.tbSizeAC.Name = "tbSizeAC";
            this.tbSizeAC.ReadOnly = true;
            this.tbSizeAC.Size = new System.Drawing.Size(20, 20);
            this.tbSizeAC.TabIndex = 48;
            this.toolTip.SetToolTip(this.tbSizeAC, "Size Modifer");
            this.tbSizeAC.TextChanged += new System.EventHandler(this.tbSizeAC_TextChanged);
            // 
            // tbDexAC
            // 
            this.tbDexAC.Enabled = false;
            this.tbDexAC.Location = new System.Drawing.Point(119, 133);
            this.tbDexAC.Name = "tbDexAC";
            this.tbDexAC.ReadOnly = true;
            this.tbDexAC.Size = new System.Drawing.Size(20, 20);
            this.tbDexAC.TabIndex = 50;
            this.toolTip.SetToolTip(this.tbDexAC, "Dex Modifier");
            this.tbDexAC.TextChanged += new System.EventHandler(this.tbDexAC_TextChanged);
            // 
            // tbNatAC
            // 
            this.tbNatAC.Location = new System.Drawing.Point(145, 133);
            this.tbNatAC.Name = "tbNatAC";
            this.tbNatAC.Size = new System.Drawing.Size(20, 20);
            this.tbNatAC.TabIndex = 52;
            this.tbNatAC.Text = "0";
            this.toolTip.SetToolTip(this.tbNatAC, "Natural Armor");
            this.tbNatAC.TextChanged += new System.EventHandler(this.tbNatAC_TextChanged);
            // 
            // tbArmorAC
            // 
            this.tbArmorAC.Location = new System.Drawing.Point(171, 133);
            this.tbArmorAC.Name = "tbArmorAC";
            this.tbArmorAC.Size = new System.Drawing.Size(20, 20);
            this.tbArmorAC.TabIndex = 54;
            this.tbArmorAC.Text = "0";
            this.toolTip.SetToolTip(this.tbArmorAC, "Armor Bonus");
            this.tbArmorAC.TextChanged += new System.EventHandler(this.tbArmorAC_TextChanged);
            // 
            // tbShieldAC
            // 
            this.tbShieldAC.Location = new System.Drawing.Point(197, 133);
            this.tbShieldAC.Name = "tbShieldAC";
            this.tbShieldAC.Size = new System.Drawing.Size(20, 20);
            this.tbShieldAC.TabIndex = 56;
            this.tbShieldAC.Text = "0";
            this.toolTip.SetToolTip(this.tbShieldAC, "Shield Bonus");
            this.tbShieldAC.TextChanged += new System.EventHandler(this.tbShieldAC_TextChanged);
            // 
            // tbDefAC
            // 
            this.tbDefAC.Location = new System.Drawing.Point(223, 133);
            this.tbDefAC.Name = "tbDefAC";
            this.tbDefAC.Size = new System.Drawing.Size(20, 20);
            this.tbDefAC.TabIndex = 58;
            this.tbDefAC.Text = "0";
            this.toolTip.SetToolTip(this.tbDefAC, "Deflection Bonus");
            this.tbDefAC.TextChanged += new System.EventHandler(this.tbDefAC_TextChanged);
            // 
            // tbGrapple
            // 
            this.tbGrapple.Location = new System.Drawing.Point(145, 158);
            this.tbGrapple.Name = "tbGrapple";
            this.tbGrapple.ReadOnly = true;
            this.tbGrapple.Size = new System.Drawing.Size(47, 20);
            this.tbGrapple.TabIndex = 61;
            // 
            // tbReach
            // 
            this.tbReach.Location = new System.Drawing.Point(115, 236);
            this.tbReach.Name = "tbReach";
            this.tbReach.Size = new System.Drawing.Size(20, 20);
            this.tbReach.TabIndex = 65;
            this.tbReach.Text = "5";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbInitDex
            // 
            this.tbInitDex.Location = new System.Drawing.Point(87, 84);
            this.tbInitDex.Name = "tbInitDex";
            this.tbInitDex.Size = new System.Drawing.Size(20, 20);
            this.tbInitDex.TabIndex = 71;
            this.tbInitDex.Text = "0";
            this.tbInitDex.TextChanged += new System.EventHandler(this.tbInitDex_TextChanged);
            // 
            // tbInitMisc
            // 
            this.tbInitMisc.Location = new System.Drawing.Point(145, 84);
            this.tbInitMisc.Name = "tbInitMisc";
            this.tbInitMisc.Size = new System.Drawing.Size(20, 20);
            this.tbInitMisc.TabIndex = 72;
            this.tbInitMisc.Text = "0";
            this.tbInitMisc.TextChanged += new System.EventHandler(this.tbInitMisc_TextChanged);
            // 
            // lblInitDex
            // 
            this.lblInitDex.AutoSize = true;
            this.lblInitDex.Location = new System.Drawing.Point(52, 87);
            this.lblInitDex.Name = "lblInitDex";
            this.lblInitDex.Size = new System.Drawing.Size(29, 13);
            this.lblInitDex.TabIndex = 73;
            this.lblInitDex.Text = "Dex:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Misc:";
            // 
            // lblTouchAC
            // 
            this.lblTouchAC.AutoSize = true;
            this.lblTouchAC.Location = new System.Drawing.Point(253, 136);
            this.lblTouchAC.Name = "lblTouchAC";
            this.lblTouchAC.Size = new System.Drawing.Size(38, 13);
            this.lblTouchAC.TabIndex = 76;
            this.lblTouchAC.Text = "Touch";
            // 
            // tbTouchAC
            // 
            this.tbTouchAC.Location = new System.Drawing.Point(297, 133);
            this.tbTouchAC.Name = "tbTouchAC";
            this.tbTouchAC.Size = new System.Drawing.Size(20, 20);
            this.tbTouchAC.TabIndex = 75;
            this.tbTouchAC.Text = "0";
            // 
            // lblFFAC
            // 
            this.lblFFAC.AutoSize = true;
            this.lblFFAC.Location = new System.Drawing.Point(323, 136);
            this.lblFFAC.Name = "lblFFAC";
            this.lblFFAC.Size = new System.Drawing.Size(60, 13);
            this.lblFFAC.TabIndex = 78;
            this.lblFFAC.Text = "Flat-Footed";
            // 
            // tbFFAC
            // 
            this.tbFFAC.Location = new System.Drawing.Point(389, 133);
            this.tbFFAC.Name = "tbFFAC";
            this.tbFFAC.Size = new System.Drawing.Size(20, 20);
            this.tbFFAC.TabIndex = 77;
            this.tbFFAC.Text = "0";
            // 
            // lblBABGrapple
            // 
            this.lblBABGrapple.AutoSize = true;
            this.lblBABGrapple.Location = new System.Drawing.Point(3, 161);
            this.lblBABGrapple.Name = "lblBABGrapple";
            this.lblBABGrapple.Size = new System.Drawing.Size(70, 13);
            this.lblBABGrapple.TabIndex = 7;
            this.lblBABGrapple.Text = "BAB/Grapple";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(88, 62);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(25, 13);
            this.lblHP.TabIndex = 6;
            this.lblHP.Text = "HP:";
            // 
            // lblHDSize
            // 
            this.lblHDSize.AutoSize = true;
            this.lblHDSize.Location = new System.Drawing.Point(52, 62);
            this.lblHDSize.Name = "lblHDSize";
            this.lblHDSize.Size = new System.Drawing.Size(13, 13);
            this.lblHDSize.TabIndex = 5;
            this.lblHDSize.Text = "d";
            // 
            // lblHDNum
            // 
            this.lblHDNum.AutoSize = true;
            this.lblHDNum.Location = new System.Drawing.Point(3, 62);
            this.lblHDNum.Name = "lblHDNum";
            this.lblHDNum.Size = new System.Drawing.Size(26, 13);
            this.lblHDNum.TabIndex = 4;
            this.lblHDNum.Text = "HD:";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 300;
            this.toolTip.ReshowDelay = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Speed:";
            // 
            // tbRaceName
            // 
            this.tbRaceName.Location = new System.Drawing.Point(141, 6);
            this.tbRaceName.Name = "tbRaceName";
            this.tbRaceName.Size = new System.Drawing.Size(89, 20);
            this.tbRaceName.TabIndex = 80;
            this.tbRaceName.Leave += new System.EventHandler(this.tbRaceName_Leave);
            // 
            // tbClasses
            // 
            this.tbClasses.Location = new System.Drawing.Point(247, 6);
            this.tbClasses.Name = "tbClasses";
            this.tbClasses.Size = new System.Drawing.Size(100, 20);
            this.tbClasses.TabIndex = 81;
            // 
            // tbLevels
            // 
            this.tbLevels.Location = new System.Drawing.Point(353, 6);
            this.tbLevels.Name = "tbLevels";
            this.tbLevels.Size = new System.Drawing.Size(100, 20);
            this.tbLevels.TabIndex = 82;
            // 
            // MonsterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLevels);
            this.Controls.Add(this.tbClasses);
            this.Controls.Add(this.tbRaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFFAC);
            this.Controls.Add(this.tbFFAC);
            this.Controls.Add(this.lblTouchAC);
            this.Controls.Add(this.tbTouchAC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInitDex);
            this.Controls.Add(this.tbInitMisc);
            this.Controls.Add(this.tbInitDex);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbReach);
            this.Controls.Add(this.tbGrapple);
            this.Controls.Add(this.tbDefAC);
            this.Controls.Add(this.tbShieldAC);
            this.Controls.Add(this.tbArmorAC);
            this.Controls.Add(this.tbNatAC);
            this.Controls.Add(this.tbDexAC);
            this.Controls.Add(this.tbSizeAC);
            this.Controls.Add(this.lblTotalAc);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.tbFeats);
            this.Controls.Add(this.tbSpecialQualities);
            this.Controls.Add(this.tbSpecialAttacks);
            this.Controls.Add(this.tbSpace);
            this.Controls.Add(this.tbFullAttack);
            this.Controls.Add(this.tbAttack);
            this.Controls.Add(this.tbTotalAC);
            this.Controls.Add(this.tbInit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbWill);
            this.Controls.Add(this.lblWill);
            this.Controls.Add(this.tbRef);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.tbCha);
            this.Controls.Add(this.lblCha);
            this.Controls.Add(this.tbWis);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.tbInt);
            this.Controls.Add(this.tbCon);
            this.Controls.Add(this.tbDex);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.tbFort);
            this.Controls.Add(this.lblFort);
            this.Controls.Add(this.tbHDSize);
            this.Controls.Add(this.tbBAB);
            this.Controls.Add(this.tbHP);
            this.Controls.Add(this.tbHDNum);
            this.Controls.Add(this.lblBABGrapple);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblHDSize);
            this.Controls.Add(this.lblHDNum);
            this.Controls.Add(this.btnNewType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbType);
            this.Name = "MonsterControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.TextBox tbHDNum;
        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.TextBox tbBAB;
        private System.Windows.Forms.TextBox tbHDSize;
        private System.Windows.Forms.TextBox tbFort;
        private System.Windows.Forms.Label lblFort;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.TextBox tbDex;
        private System.Windows.Forms.TextBox tbCon;
        private System.Windows.Forms.TextBox tbInt;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.TextBox tbWis;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.TextBox tbCha;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.Label lblWill;
        private System.Windows.Forms.TextBox tbWill;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbInit;
        private System.Windows.Forms.TextBox tbTotalAC;
        private System.Windows.Forms.TextBox tbAttack;
        private System.Windows.Forms.TextBox tbFullAttack;
        private System.Windows.Forms.TextBox tbSpace;
        private System.Windows.Forms.TextBox tbSpecialAttacks;
        private System.Windows.Forms.TextBox tbSpecialQualities;
        private System.Windows.Forms.TextBox tbFeats;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lblTotalAc;
        private System.Windows.Forms.TextBox tbSizeAC;
        private System.Windows.Forms.TextBox tbDexAC;
        private System.Windows.Forms.TextBox tbNatAC;
        private System.Windows.Forms.TextBox tbArmorAC;
        private System.Windows.Forms.TextBox tbShieldAC;
        private System.Windows.Forms.TextBox tbDefAC;
        private System.Windows.Forms.TextBox tbGrapple;
        private System.Windows.Forms.TextBox tbReach;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbInitDex;
        private System.Windows.Forms.TextBox tbInitMisc;
        private System.Windows.Forms.Label lblInitDex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTouchAC;
        private System.Windows.Forms.TextBox tbTouchAC;
        private System.Windows.Forms.Label lblFFAC;
        private System.Windows.Forms.TextBox tbFFAC;
        private System.Windows.Forms.Label lblBABGrapple;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblHDSize;
        private System.Windows.Forms.Label lblHDNum;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRaceName;
        private System.Windows.Forms.TextBox tbClasses;
        private System.Windows.Forms.TextBox tbLevels;
    }*/
}
