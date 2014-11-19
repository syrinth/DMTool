namespace DM_Tool
{
    partial class frmMonsterMaker
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
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewType = new System.Windows.Forms.Button();
            this.lblHDNum = new System.Windows.Forms.Label();
            this.lblHDSize = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblBABGrapple = new System.Windows.Forms.Label();
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInit = new System.Windows.Forms.TextBox();
            this.tbTotalAC = new System.Windows.Forms.TextBox();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbSpace = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTotalAc = new System.Windows.Forms.Label();
            this.lblSizeAC = new System.Windows.Forms.Label();
            this.tbSizeAC = new System.Windows.Forms.TextBox();
            this.lblDexAC = new System.Windows.Forms.Label();
            this.tbDexAC = new System.Windows.Forms.TextBox();
            this.lblNaturalAC = new System.Windows.Forms.Label();
            this.tbNatAC = new System.Windows.Forms.TextBox();
            this.lblArmorAC = new System.Windows.Forms.Label();
            this.tbArmorAC = new System.Windows.Forms.TextBox();
            this.lblShieldAC = new System.Windows.Forms.Label();
            this.tbShieldAC = new System.Windows.Forms.TextBox();
            this.lblDefAC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbGrapple = new System.Windows.Forms.TextBox();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblFullAttack = new System.Windows.Forms.Label();
            this.lblSpaceReach = new System.Windows.Forms.Label();
            this.tbReach = new System.Windows.Forms.TextBox();
            this.lblSpcAttacks = new System.Windows.Forms.Label();
            this.lblSpcQualities = new System.Windows.Forms.Label();
            this.lblFeats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(11, 35);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(134, 32);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewType
            // 
            this.btnNewType.Location = new System.Drawing.Point(264, 30);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(75, 23);
            this.btnNewType.TabIndex = 3;
            this.btnNewType.Text = "New Type";
            this.btnNewType.UseVisualStyleBackColor = true;
            this.btnNewType.Click += new System.EventHandler(this.btnNewType_Click);
            // 
            // lblHDNum
            // 
            this.lblHDNum.AutoSize = true;
            this.lblHDNum.Location = new System.Drawing.Point(11, 62);
            this.lblHDNum.Name = "lblHDNum";
            this.lblHDNum.Size = new System.Drawing.Size(78, 13);
            this.lblHDNum.TabIndex = 4;
            this.lblHDNum.Text = "Number of HD:";
            // 
            // lblHDSize
            // 
            this.lblHDSize.AutoSize = true;
            this.lblHDSize.Location = new System.Drawing.Point(11, 88);
            this.lblHDSize.Name = "lblHDSize";
            this.lblHDSize.Size = new System.Drawing.Size(61, 13);
            this.lblHDSize.TabIndex = 5;
            this.lblHDSize.Text = "Size of HD:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(11, 118);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(55, 13);
            this.lblHP.TabIndex = 6;
            this.lblHP.Text = "Hit Points:";
            // 
            // lblBABGrapple
            // 
            this.lblBABGrapple.AutoSize = true;
            this.lblBABGrapple.Location = new System.Drawing.Point(12, 141);
            this.lblBABGrapple.Name = "lblBABGrapple";
            this.lblBABGrapple.Size = new System.Drawing.Size(70, 13);
            this.lblBABGrapple.TabIndex = 7;
            this.lblBABGrapple.Text = "BAB/Grapple";
            // 
            // tbHDNum
            // 
            this.tbHDNum.Location = new System.Drawing.Point(134, 59);
            this.tbHDNum.Name = "tbHDNum";
            this.tbHDNum.Size = new System.Drawing.Size(100, 20);
            this.tbHDNum.TabIndex = 8;
            this.tbHDNum.TextChanged += new System.EventHandler(this.tbHDNum_TextChanged);
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(134, 111);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(100, 20);
            this.tbHP.TabIndex = 10;
            // 
            // tbBAB
            // 
            this.tbBAB.Location = new System.Drawing.Point(134, 138);
            this.tbBAB.Name = "tbBAB";
            this.tbBAB.ReadOnly = true;
            this.tbBAB.Size = new System.Drawing.Size(47, 20);
            this.tbBAB.TabIndex = 11;
            // 
            // tbHDSize
            // 
            this.tbHDSize.Location = new System.Drawing.Point(134, 85);
            this.tbHDSize.Name = "tbHDSize";
            this.tbHDSize.ReadOnly = true;
            this.tbHDSize.Size = new System.Drawing.Size(100, 20);
            this.tbHDSize.TabIndex = 12;
            // 
            // tbFort
            // 
            this.tbFort.Location = new System.Drawing.Point(37, 164);
            this.tbFort.Name = "tbFort";
            this.tbFort.ReadOnly = true;
            this.tbFort.Size = new System.Drawing.Size(33, 20);
            this.tbFort.TabIndex = 14;
            // 
            // lblFort
            // 
            this.lblFort.AutoSize = true;
            this.lblFort.Location = new System.Drawing.Point(11, 167);
            this.lblFort.Name = "lblFort";
            this.lblFort.Size = new System.Drawing.Size(25, 13);
            this.lblFort.TabIndex = 13;
            this.lblFort.Text = "Fort";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(11, 193);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(20, 13);
            this.lblStr.TabIndex = 15;
            this.lblStr.Text = "Str";
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(37, 190);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(33, 20);
            this.tbStr.TabIndex = 16;
            this.tbStr.Text = "10";
            // 
            // tbDex
            // 
            this.tbDex.Location = new System.Drawing.Point(110, 190);
            this.tbDex.Name = "tbDex";
            this.tbDex.Size = new System.Drawing.Size(33, 20);
            this.tbDex.TabIndex = 17;
            this.tbDex.Text = "10";
            this.tbDex.TextChanged += new System.EventHandler(this.tbDex_TextChanged);
            // 
            // tbCon
            // 
            this.tbCon.Location = new System.Drawing.Point(181, 190);
            this.tbCon.Name = "tbCon";
            this.tbCon.Size = new System.Drawing.Size(33, 20);
            this.tbCon.TabIndex = 18;
            this.tbCon.Text = "10";
            this.tbCon.TextChanged += new System.EventHandler(this.tbCon_TextChanged);
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(245, 190);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(33, 20);
            this.tbInt.TabIndex = 19;
            this.tbInt.Text = "10";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(81, 193);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(26, 13);
            this.lblDex.TabIndex = 20;
            this.lblDex.Text = "Dex";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(149, 193);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(26, 13);
            this.lblCon.TabIndex = 21;
            this.lblCon.Text = "Con";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(220, 193);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(19, 13);
            this.lblInt.TabIndex = 22;
            this.lblInt.Text = "Int";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(284, 193);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(25, 13);
            this.lblWis.TabIndex = 23;
            this.lblWis.Text = "Wis";
            // 
            // tbWis
            // 
            this.tbWis.Location = new System.Drawing.Point(315, 190);
            this.tbWis.Name = "tbWis";
            this.tbWis.Size = new System.Drawing.Size(33, 20);
            this.tbWis.TabIndex = 24;
            this.tbWis.Text = "10";
            this.tbWis.TextChanged += new System.EventHandler(this.tbWis_TextChanged);
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(354, 193);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(26, 13);
            this.lblCha.TabIndex = 25;
            this.lblCha.Text = "Cha";
            // 
            // tbCha
            // 
            this.tbCha.Location = new System.Drawing.Point(386, 190);
            this.tbCha.Name = "tbCha";
            this.tbCha.Size = new System.Drawing.Size(33, 20);
            this.tbCha.TabIndex = 26;
            this.tbCha.Text = "10";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(81, 167);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(24, 13);
            this.lblRef.TabIndex = 27;
            this.lblRef.Text = "Ref";
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(110, 164);
            this.tbRef.Name = "tbRef";
            this.tbRef.ReadOnly = true;
            this.tbRef.Size = new System.Drawing.Size(33, 20);
            this.tbRef.TabIndex = 28;
            // 
            // lblWill
            // 
            this.lblWill.AutoSize = true;
            this.lblWill.Location = new System.Drawing.Point(151, 167);
            this.lblWill.Name = "lblWill";
            this.lblWill.Size = new System.Drawing.Size(24, 13);
            this.lblWill.TabIndex = 29;
            this.lblWill.Text = "Will";
            // 
            // tbWill
            // 
            this.tbWill.Location = new System.Drawing.Point(181, 164);
            this.tbWill.Name = "tbWill";
            this.tbWill.ReadOnly = true;
            this.tbWill.Size = new System.Drawing.Size(33, 20);
            this.tbWill.TabIndex = 30;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(134, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 32;
            // 
            // tbInit
            // 
            this.tbInit.Location = new System.Drawing.Point(134, 216);
            this.tbInit.Name = "tbInit";
            this.tbInit.Size = new System.Drawing.Size(100, 20);
            this.tbInit.TabIndex = 33;
            // 
            // tbTotalAC
            // 
            this.tbTotalAC.Location = new System.Drawing.Point(37, 268);
            this.tbTotalAC.Name = "tbTotalAC";
            this.tbTotalAC.Size = new System.Drawing.Size(33, 20);
            this.tbTotalAC.TabIndex = 35;
            // 
            // tbAttack
            // 
            this.tbAttack.Location = new System.Drawing.Point(134, 294);
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(100, 20);
            this.tbAttack.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(134, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 37;
            // 
            // tbSpace
            // 
            this.tbSpace.Location = new System.Drawing.Point(134, 346);
            this.tbSpace.Name = "tbSpace";
            this.tbSpace.Size = new System.Drawing.Size(47, 20);
            this.tbSpace.TabIndex = 38;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(134, 372);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(449, 20);
            this.textBox7.TabIndex = 39;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(134, 398);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(449, 20);
            this.textBox8.TabIndex = 40;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(134, 424);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(362, 20);
            this.textBox9.TabIndex = 41;
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(12, 219);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(24, 13);
            this.lblInit.TabIndex = 42;
            this.lblInit.Text = "Init:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(450, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 43;
            this.lblSize.Text = "Size:";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(483, 6);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(100, 21);
            this.cbSize.TabIndex = 44;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(134, 242);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbSpeed.TabIndex = 45;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(11, 245);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 46;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblTotalAc
            // 
            this.lblTotalAc.AutoSize = true;
            this.lblTotalAc.Location = new System.Drawing.Point(11, 271);
            this.lblTotalAc.Name = "lblTotalAc";
            this.lblTotalAc.Size = new System.Drawing.Size(24, 13);
            this.lblTotalAc.TabIndex = 47;
            this.lblTotalAc.Text = "AC:";
            // 
            // lblSizeAC
            // 
            this.lblSizeAC.AutoSize = true;
            this.lblSizeAC.Location = new System.Drawing.Point(84, 271);
            this.lblSizeAC.Name = "lblSizeAC";
            this.lblSizeAC.Size = new System.Drawing.Size(27, 13);
            this.lblSizeAC.TabIndex = 49;
            this.lblSizeAC.Text = "Size";
            // 
            // tbSizeAC
            // 
            this.tbSizeAC.Location = new System.Drawing.Point(110, 268);
            this.tbSizeAC.Name = "tbSizeAC";
            this.tbSizeAC.Size = new System.Drawing.Size(33, 20);
            this.tbSizeAC.TabIndex = 48;
            // 
            // lblDexAC
            // 
            this.lblDexAC.AutoSize = true;
            this.lblDexAC.Location = new System.Drawing.Point(155, 271);
            this.lblDexAC.Name = "lblDexAC";
            this.lblDexAC.Size = new System.Drawing.Size(26, 13);
            this.lblDexAC.TabIndex = 51;
            this.lblDexAC.Text = "Dex";
            // 
            // tbDexAC
            // 
            this.tbDexAC.Location = new System.Drawing.Point(181, 268);
            this.tbDexAC.Name = "tbDexAC";
            this.tbDexAC.Size = new System.Drawing.Size(33, 20);
            this.tbDexAC.TabIndex = 50;
            // 
            // lblNaturalAC
            // 
            this.lblNaturalAC.AutoSize = true;
            this.lblNaturalAC.Location = new System.Drawing.Point(219, 271);
            this.lblNaturalAC.Name = "lblNaturalAC";
            this.lblNaturalAC.Size = new System.Drawing.Size(24, 13);
            this.lblNaturalAC.TabIndex = 53;
            this.lblNaturalAC.Text = "Nat";
            // 
            // tbNatAC
            // 
            this.tbNatAC.Location = new System.Drawing.Point(245, 268);
            this.tbNatAC.Name = "tbNatAC";
            this.tbNatAC.Size = new System.Drawing.Size(33, 20);
            this.tbNatAC.TabIndex = 52;
            // 
            // lblArmorAC
            // 
            this.lblArmorAC.AutoSize = true;
            this.lblArmorAC.Location = new System.Drawing.Point(289, 271);
            this.lblArmorAC.Name = "lblArmorAC";
            this.lblArmorAC.Size = new System.Drawing.Size(34, 13);
            this.lblArmorAC.TabIndex = 55;
            this.lblArmorAC.Text = "Armor";
            // 
            // tbArmorAC
            // 
            this.tbArmorAC.Location = new System.Drawing.Point(329, 268);
            this.tbArmorAC.Name = "tbArmorAC";
            this.tbArmorAC.Size = new System.Drawing.Size(33, 20);
            this.tbArmorAC.TabIndex = 54;
            // 
            // lblShieldAC
            // 
            this.lblShieldAC.AutoSize = true;
            this.lblShieldAC.Location = new System.Drawing.Point(360, 271);
            this.lblShieldAC.Name = "lblShieldAC";
            this.lblShieldAC.Size = new System.Drawing.Size(36, 13);
            this.lblShieldAC.TabIndex = 57;
            this.lblShieldAC.Text = "Shield";
            // 
            // tbShieldAC
            // 
            this.tbShieldAC.Location = new System.Drawing.Point(402, 268);
            this.tbShieldAC.Name = "tbShieldAC";
            this.tbShieldAC.Size = new System.Drawing.Size(33, 20);
            this.tbShieldAC.TabIndex = 56;
            // 
            // lblDefAC
            // 
            this.lblDefAC.AutoSize = true;
            this.lblDefAC.Location = new System.Drawing.Point(441, 271);
            this.lblDefAC.Name = "lblDefAC";
            this.lblDefAC.Size = new System.Drawing.Size(55, 13);
            this.lblDefAC.TabIndex = 59;
            this.lblDefAC.Text = "Deflection";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 58;
            // 
            // tbGrapple
            // 
            this.tbGrapple.Location = new System.Drawing.Point(187, 138);
            this.tbGrapple.Name = "tbGrapple";
            this.tbGrapple.ReadOnly = true;
            this.tbGrapple.Size = new System.Drawing.Size(47, 20);
            this.tbGrapple.TabIndex = 61;
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(12, 297);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(41, 13);
            this.lblAttack.TabIndex = 62;
            this.lblAttack.Text = "Attack:";
            // 
            // lblFullAttack
            // 
            this.lblFullAttack.AutoSize = true;
            this.lblFullAttack.Location = new System.Drawing.Point(12, 323);
            this.lblFullAttack.Name = "lblFullAttack";
            this.lblFullAttack.Size = new System.Drawing.Size(60, 13);
            this.lblFullAttack.TabIndex = 63;
            this.lblFullAttack.Text = "Full-Attack:";
            // 
            // lblSpaceReach
            // 
            this.lblSpaceReach.AutoSize = true;
            this.lblSpaceReach.Location = new System.Drawing.Point(12, 349);
            this.lblSpaceReach.Name = "lblSpaceReach";
            this.lblSpaceReach.Size = new System.Drawing.Size(75, 13);
            this.lblSpaceReach.TabIndex = 64;
            this.lblSpaceReach.Text = "Space/Reach";
            // 
            // tbReach
            // 
            this.tbReach.Location = new System.Drawing.Point(187, 346);
            this.tbReach.Name = "tbReach";
            this.tbReach.Size = new System.Drawing.Size(47, 20);
            this.tbReach.TabIndex = 65;
            // 
            // lblSpcAttacks
            // 
            this.lblSpcAttacks.AutoSize = true;
            this.lblSpcAttacks.Location = new System.Drawing.Point(12, 375);
            this.lblSpcAttacks.Name = "lblSpcAttacks";
            this.lblSpcAttacks.Size = new System.Drawing.Size(87, 13);
            this.lblSpcAttacks.TabIndex = 66;
            this.lblSpcAttacks.Text = "Special Attacks: ";
            // 
            // lblSpcQualities
            // 
            this.lblSpcQualities.AutoSize = true;
            this.lblSpcQualities.Location = new System.Drawing.Point(12, 401);
            this.lblSpcQualities.Name = "lblSpcQualities";
            this.lblSpcQualities.Size = new System.Drawing.Size(88, 13);
            this.lblSpcQualities.TabIndex = 67;
            this.lblSpcQualities.Text = "Special Qualities:";
            // 
            // lblFeats
            // 
            this.lblFeats.AutoSize = true;
            this.lblFeats.Location = new System.Drawing.Point(12, 427);
            this.lblFeats.Name = "lblFeats";
            this.lblFeats.Size = new System.Drawing.Size(36, 13);
            this.lblFeats.TabIndex = 68;
            this.lblFeats.Text = "Feats:";
            // 
            // frmMonsterMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 470);
            this.Controls.Add(this.lblFeats);
            this.Controls.Add(this.lblSpcQualities);
            this.Controls.Add(this.lblSpcAttacks);
            this.Controls.Add(this.tbReach);
            this.Controls.Add(this.lblSpaceReach);
            this.Controls.Add(this.lblFullAttack);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.tbGrapple);
            this.Controls.Add(this.lblDefAC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblShieldAC);
            this.Controls.Add(this.tbShieldAC);
            this.Controls.Add(this.lblArmorAC);
            this.Controls.Add(this.tbArmorAC);
            this.Controls.Add(this.lblNaturalAC);
            this.Controls.Add(this.tbNatAC);
            this.Controls.Add(this.lblDexAC);
            this.Controls.Add(this.tbDexAC);
            this.Controls.Add(this.lblSizeAC);
            this.Controls.Add(this.tbSizeAC);
            this.Controls.Add(this.lblTotalAc);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tbSpace);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbAttack);
            this.Controls.Add(this.tbTotalAC);
            this.Controls.Add(this.tbInit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
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
            this.Controls.Add(this.lblType);
            this.Name = "frmMonsterMaker";
            this.Text = "frmMonsterMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.Label lblHDNum;
        private System.Windows.Forms.Label lblHDSize;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblBABGrapple;
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbInit;
        private System.Windows.Forms.TextBox tbTotalAC;
        private System.Windows.Forms.TextBox tbAttack;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbSpace;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTotalAc;
        private System.Windows.Forms.Label lblSizeAC;
        private System.Windows.Forms.TextBox tbSizeAC;
        private System.Windows.Forms.Label lblDexAC;
        private System.Windows.Forms.TextBox tbDexAC;
        private System.Windows.Forms.Label lblNaturalAC;
        private System.Windows.Forms.TextBox tbNatAC;
        private System.Windows.Forms.Label lblArmorAC;
        private System.Windows.Forms.TextBox tbArmorAC;
        private System.Windows.Forms.Label lblShieldAC;
        private System.Windows.Forms.TextBox tbShieldAC;
        private System.Windows.Forms.Label lblDefAC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbGrapple;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblFullAttack;
        private System.Windows.Forms.Label lblSpaceReach;
        private System.Windows.Forms.TextBox tbReach;
        private System.Windows.Forms.Label lblSpcAttacks;
        private System.Windows.Forms.Label lblSpcQualities;
        private System.Windows.Forms.Label lblFeats;
    }
}