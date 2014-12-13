using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Classes;

namespace DM_Tool.Controls
{

    public partial class CharacterControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parentPage;
        private CreatureType tc;
        private CreatureSize size;
        private Character _character;
        private List<KeyValuePair<string, int>> classLevels = new List<KeyValuePair<string, int>>();
        private int RacialHD = 0;
        private bool Loaded = false;

        public CharacterControl()
        {
            InitializeComponent();
            Init();
            Loaded = true;
        }

        public CharacterControl(TabPage parentPage, Character c)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;

            _character = c;
            CharacterSheet cSheet = c.GetCharacterSheet();

            this.chkCampaign.Checked = c._campaignSpecific;
            this.tbName.Text = cSheet.name;
            this.tbRaceName.Text = cSheet.raceName;
            this.tbClasses.Text = cSheet.classes;
            this.tbLevels.Text = cSheet.levels;
            this.cbType.SelectedItem = cSheet.creatureType;
            this.cbSize.SelectedItem = cSheet.size;

            this.tbRacialHD.Text = cSheet.hitDieNum.ToString();
            this.tbInit.Text = cSheet.init.ToString();
            this.tbInitMisc.Text = cSheet.initMisc.ToString();
            this.tbSpeed.Text = cSheet.speed;
            this.tbBAB.Text = ((PublicManager.BABType)cSheet.baseAttackBonus).ToString();
            this.tbFort.Text = ((PublicManager.SaveType)cSheet.fortSave).ToString();
            this.tbRef.Text = ((PublicManager.SaveType)cSheet.refSave).ToString();
            this.tbWill.Text = ((PublicManager.SaveType)cSheet.willSave).ToString();
            
            this.tbStr.Text = cSheet.str.ToString();
            this.tbDex.Text = cSheet.dex.ToString();
            this.tbCon.Text = cSheet.con.ToString();
            this.tbInt.Text = cSheet.intelligence.ToString();
            this.tbWis.Text = cSheet.wis.ToString();
            this.tbCha.Text = cSheet.cha.ToString();

            this.tbNatAC.Text = cSheet.natAC.ToString();
            this.tbArmorAC.Text = cSheet.armorAC.ToString();
            this.tbShieldAC.Text = cSheet.shieldAC.ToString();
            this.tbDefAC.Text = cSheet.defAC.ToString();
            this.tbAttack.Text = cSheet.attack;
            this.tbFullAttack.Text = cSheet.fullAttack;
            this.tbSpace.Text = cSheet.space.ToString();
            this.tbReach.Text = cSheet.reach.ToString();

            FillSpecialsColumn(cSheet.feats, "colFeats");
            FillSpecialsColumn(cSheet.specialAttacks, "colSpecialAttacks");
            FillSpecialsColumn(cSheet.specialQualities, "colSpecialQualities");

            AssignCharacterSkills();
            tc = mgr.listCreatureTypes.Find(x => x.name.Equals(cbType.SelectedText));
            GetClassLevels();
            Loaded = true;
            UpdateSheet();

            //Goes last to overwrite any issues
            this.tbHP.Text = cSheet.hp.ToString();
        }

        public CharacterControl(TabPage parentPage)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;
            Loaded = true;
        }

        public CharacterControl(TabPage parentPage, string name)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;

            tbName.Text = name;
            btnSave.Text = "Save";
            Loaded = true;
        }

        public void Init()
        {
            tc = new CreatureType();
            LoadTypes();
            LoadSizes();
            cbType.SelectedIndex = 0;

            List<string> skills = new List<string>(){"(Int)|Appraise", "(Dex)|Balance", "(Cha)|Bluff", "(Str)|Climb", "(Con)|Concentration", "(Int)|Craft",
                                   "(Int)|Decipher Script", "(Cha)|Diplomacy", "(Dex)|Disable Device", "(Cha)|Disguise", "(Dex)|Escape Artist",
                                   "(Dex)|Forgery", "(Cha)|Gather Information", "(Cha)|Handle Animal", "(Wis)|Heal", "(Dex)|Hide", "(Cha)|Intimidate",
                                   "(Str)|Jump", "(Int)|Knowledge", "(Wis)|Listen", "(Dex)|Move Silently", "(Dex)|Open Lock", "(Cha)|Perform", "(Int)|Profession",
                                   "(Dex)|Ride", "(Int)|Search", "(Wis)|Sense Motive", "(Dex)|Sleight Of Hand", "(Int)|Speak Language", "(Int)|Spellcraft",
                                   "(Wis)|Spot", "(Wis)|Survival", "(Str)|Swim", "(Dex)|Tumble", "(Cha)|Use Magic Device", "(Dex)|Use Rope"};


            foreach (string s in skills)
            {
                string[] split = s.Split('|');
                dgvSkills.Rows.Add(false, split[0], split[1], "0", "0", "0", "0");
            }
        }

        public void AssignCharacterSkills()
        {
            for (int i = 0; i < dgvSkills.Rows.Count; i++ )
            {
                DataGridViewRow r = dgvSkills.Rows[i];
                if (_character.GetSkills().Count > 0)
                {
                    string[] split = _character.GetSkills()[i].Split('|');

                    r.Cells["colTotal"].Value = split[0];
                    r.Cells["colMod"].Value = split[1];
                    r.Cells["colRanks"].Value = split[2];
                    r.Cells["colMisc"].Value = split[3];
                }
            }
        }

        private void LoadTypes()
        {
            cbType.Items.Clear();
            foreach (CreatureType type in mgr.listCreatureTypes)
            {
                cbType.Items.Add(type.name);
            }
        }

        private void LoadSizes()
        {
            cbSize.Items.Clear();
            foreach (CreatureSize s in mgr.listCreatureSizes)
            {
                cbSize.Items.Add(s.GetName());
            }
            cbSize.SelectedItem = "Medium";
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            frmNewCreatureType frm = new frmNewCreatureType();
            frm.ShowDialog();

            LoadTypes();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }


        private void tbHDNum_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        public void UpdateSheet()
        {
            if (Loaded)
            {
                try
                {
                    tc = mgr.listCreatureTypes.Find(x => x.name.Equals(cbType.SelectedItem));
                }
                catch { }
                GetClassLevels();
                try
                {
                    RacialHD = Convert.ToInt32(tbRacialHD.Text);
                }
                catch { }

                if (classLevels.Count > 0 || RacialHD > 0)
                {

                    tbInit.Text = (Convert.ToInt32(tbInitDex.Text) + Convert.ToInt32(tbInitMisc.Text)).ToString();
                    //Calculate the BAB and Grapple
                    CalculateBABGrapple();

                    //Calculate Saving Throws
                    CalculateSaves();

                    CalculateBaseHP();

                    CalculateAC();

                    CalculateSkills();
                }
            }
        }

        public void CalculateBaseHP()
        {
            int HDNum = 0;
            tbHD.Text = "";
            int hp = 0;
            if (RacialHD > 0)
            {
                int racialHDNum = Convert.ToInt32(tbRacialHD.Text);
                HDNum = racialHDNum;
                double HDSize = Convert.ToDouble(tc.hitDieSize);
                double avgHpPerDie = (HDSize + 1) / 2;
                double averageHP = racialHDNum * avgHpPerDie;

                tbHD.Text = racialHDNum.ToString() + "d" + tc.hitDieSize.ToString();
                hp = Convert.ToInt32(averageHP);

                if (classLevels.Count > 0)
                {
                    tbHD.Text += " + ";
                }
            }

            foreach(KeyValuePair<string, int> kvp in classLevels){
                int classHDNum = kvp.Value;
                HDNum += classHDNum;

                CharacterClass c = mgr.listCharacterClasses.Find(x => x.name.Equals(kvp.Key));
                if (c != null)
                {
                    double classHDSize = Convert.ToDouble(c.hitDieSize);
                    double avgHpPerClassDie = (classHDSize + 1) / 2;
                    double averageClassHP = classHDNum * avgHpPerClassDie;
                    hp += Convert.ToInt32(averageClassHP);
                    tbHD.Text += classHDNum.ToString() + "d" + classHDSize.ToString() + " + ";
                }
            }

            string val = tbHD.Text;
            int last = val.LastIndexOf(" + ");
            if (last > 0)
            {
                tbHD.Text = val.Remove(last);
            }

            if (tc.name != "Undead")
            {
                hp += (GetModifier(tbCon.Text) * HDNum);
                tbHD.Text += " + " + (GetModifier(tbCon.Text) * HDNum);
            }

            tbHP.Text = hp.ToString();
        }

        public void CalculateBABGrapple()
        {
            int bab = 0;
            if (RacialHD > 0)
            {
                if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.POOR)
                {
                    bab = (Convert.ToInt32(tbRacialHD.Text) / 2);
                }
                else if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.AVERAGE)
                {
                    bab = (Int32)(Convert.ToInt32(tbRacialHD.Text) * .75);
                }
                else if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.GOOD)
                {
                    bab = Convert.ToInt32(tbRacialHD.Text);
                }
            }

            foreach (KeyValuePair<string, int> kvp in classLevels)
            {
                int classHDNum = kvp.Value;
                CharacterClass c = mgr.listCharacterClasses.Find(x => x.name.Equals(kvp.Key));
                if (c != null)
                {
                    if ((PublicManager.BABType)c.baseAttackBonus == PublicManager.BABType.POOR)
                    {
                        bab += (Convert.ToInt32(classHDNum) / 2);
                    }
                    else if ((PublicManager.BABType)c.baseAttackBonus == PublicManager.BABType.AVERAGE)
                    {
                        bab += (Int32)(Convert.ToInt32(classHDNum) * .75);
                    }
                    else if ((PublicManager.BABType)c.baseAttackBonus == PublicManager.BABType.GOOD)
                    {
                        bab += Convert.ToInt32(classHDNum);
                    }
                }
            }

            tbBAB.Text = bab.ToString();

            tbGrapple.Text = (Convert.ToInt32(tbBAB.Text) + size.GetSpecialModifier() + GetModifier(tbStr.Text)).ToString();
        }

        public void CalculateSaves()
        {
            CalculateFortSave();
            CalculateRefSave();
            CalculateWillSave();
        }

        public void CalculateAC()
        {
            int totalAC = 10;
            int touchAC = 10;
            int flatFootedAC = 10;
            try
            {
                if (tbSizeAC.Text != string.Empty)
                {
                    totalAC += Convert.ToInt32(tbSizeAC.Text);
                    touchAC += Convert.ToInt32(tbSizeAC.Text);
                    flatFootedAC += Convert.ToInt32(tbSizeAC.Text);
                }
                if (tbDexAC.Text != string.Empty)
                {
                    totalAC += Convert.ToInt32(tbDexAC.Text);
                    touchAC += Convert.ToInt32(tbDexAC.Text);
                    if (Convert.ToInt32(tbDexAC.Text) < 0)
                    {
                        flatFootedAC += Convert.ToInt32(tbDexAC.Text);
                    }
                }
                if (tbNatAC.Text != string.Empty)
                {
                    totalAC += Convert.ToInt32(tbNatAC.Text);
                    flatFootedAC += Convert.ToInt32(tbNatAC.Text);
                }
                if (tbArmorAC.Text != string.Empty)
                {
                    totalAC += Convert.ToInt32(tbArmorAC.Text);
                    flatFootedAC += Convert.ToInt32(tbArmorAC.Text);
                }
                if (tbShieldAC.Text != string.Empty)
                {
                    totalAC += Convert.ToInt32(tbShieldAC.Text);
                    flatFootedAC += Convert.ToInt32(tbShieldAC.Text);
                }
                if (tbDefAC.Text != string.Empty)
                {
                    totalAC += Convert.ToInt32(tbDefAC.Text);
                    touchAC += Convert.ToInt32(tbDefAC.Text);
                    flatFootedAC += Convert.ToInt32(tbDefAC.Text);
                }
            }
            catch { }
            tbTotalAC.Text = totalAC.ToString();
            tbTouchAC.Text = touchAC.ToString();
            tbFFAC.Text = flatFootedAC.ToString();
        }

        public int GetModifier(string number)
        {
            if (number != string.Empty)
            {
                int num = PublicCode.ConvertToIntSafely(number);
                double mod = 0;
                if (num >= 10)
                {
                    mod = Math.Ceiling((double)((num - 10) / 2));
                }
                else
                {
                    mod = Math.Floor((double)((num - 11) / 2));
                }

                return (int)mod;
            }
            return 0;
        }

        public void CalculateFortSave()
        {
            int fort = 0;
            if (RacialHD > 0)
            {
                if ((PublicManager.SaveType)tc.fortSave == PublicManager.SaveType.POOR)
                {
                    fort = Convert.ToInt32(tbRacialHD.Text) / 3;
                }
                else if ((PublicManager.SaveType)tc.fortSave == PublicManager.SaveType.GOOD)
                {
                    fort = (Convert.ToInt32(tbRacialHD.Text) / 2) + 2;
                }
            }

            foreach (KeyValuePair<string, int> kvp in classLevels)
            {
                int classHDNum = kvp.Value;
                CharacterClass c = mgr.listCharacterClasses.Find(x => x.name.Equals(kvp.Key));
                if (c != null)
                {
                    if ((PublicManager.SaveType)c.fortSave == PublicManager.SaveType.POOR)
                    {
                        fort += Convert.ToInt32(classHDNum) / 3;
                    }
                    else if ((PublicManager.SaveType)c.fortSave == PublicManager.SaveType.GOOD)
                    {
                        fort += (Convert.ToInt32(classHDNum) / 2) + 2;
                    }
                }
            }

            if (tc.name != "Undead")
            {
                fort += GetModifier(tbCon.Text);
            }
            tbFort.Text = fort.ToString();
        }

        public void CalculateRefSave()
        {
            int reflex = 0;
            if (RacialHD > 0)
            {
                if ((PublicManager.SaveType)tc.refSave == PublicManager.SaveType.POOR)
                {
                    reflex = Convert.ToInt32(tbRacialHD.Text) / 3;
                }
                else if ((PublicManager.SaveType)tc.refSave == PublicManager.SaveType.GOOD)
                {
                    reflex = (Convert.ToInt32(tbRacialHD.Text) / 2) + 2;
                }
            }

            foreach (KeyValuePair<string, int> kvp in classLevels)
            {
                int classHDNum = kvp.Value;
                CharacterClass c = mgr.listCharacterClasses.Find(x => x.name.Equals(kvp.Key));
                if (c != null)
                {
                    if ((PublicManager.SaveType)c.refSave == PublicManager.SaveType.POOR)
                    {
                        reflex += Convert.ToInt32(classHDNum) / 3;
                    }
                    else if ((PublicManager.SaveType)c.refSave == PublicManager.SaveType.GOOD)
                    {
                        reflex += (Convert.ToInt32(classHDNum) / 2) + 2;
                    }
                }
            }

            reflex += GetModifier(tbDex.Text);
            tbRef.Text = reflex.ToString();
        }

        public void CalculateWillSave()
        {
            int will = 0;
            if (RacialHD > 0)
            {
                if ((PublicManager.SaveType)tc.willSave == PublicManager.SaveType.POOR)
                {
                    will = Convert.ToInt32(tbRacialHD.Text) / 3;
                }
                else if ((PublicManager.SaveType)tc.willSave == PublicManager.SaveType.GOOD)
                {
                    will = (Convert.ToInt32(tbRacialHD.Text) / 2) + 2;
                }
            }

            foreach (KeyValuePair<string, int> kvp in classLevels)
            {
                int classHDNum = kvp.Value;
                CharacterClass c = mgr.listCharacterClasses.Find(x => x.name.Equals(kvp.Key));
                if (c != null)
                {
                    if ((PublicManager.SaveType)c.willSave == PublicManager.SaveType.POOR)
                    {
                        will += Convert.ToInt32(classHDNum) / 3;
                    }
                    else if ((PublicManager.SaveType)c.willSave == PublicManager.SaveType.GOOD)
                    {
                        will += (Convert.ToInt32(classHDNum) / 2) + 2;
                    }
                }
            }

            will += GetModifier(tbWis.Text);
            tbWill.Text = will.ToString();
        }

        private void tbCon_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void tbDex_TextChanged(object sender, EventArgs e)
        {
            tbDexAC.Text = GetModifier(tbDex.Text).ToString();
            tbInitDex.Text = GetModifier(tbDex.Text).ToString();
            UpdateSheet();
        }

        private void tbWis_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty)
            {
                if (tbRaceName.Text == "Race")
                {
                    tbRaceName.Text = "";
                }
                _parentPage.Text = tbName.Text;
                if (mgr.listCharacters.Count > 0)
                {
                    try
                    {
                        Character character = GetRightCharacterList().Find(x => x.GetName().Equals(tbName.Text));
                        if (tc != null)
                        {
                            GetRightCharacterList().Remove(character);
                        }
                    }
                    catch { }
                }

                GetRightCharacterList().Add(new Character(CharacterSheetToString(), chkCampaign.Checked, GetSkillsList()));
                try
                {
                    GetRightCharacterList().Sort((a, b) => a.GetName().CompareTo(b.GetName()));
                }
                catch { }
                if (chkCampaign.Checked)
                {
                    PublicManager.SerializeCampaignCharactersToXML(mgr.listCampaignCharacters);
                }
                else
                {
                    PublicManager.SerializeCharactersToXML(mgr.listCharacters);
                }
                mgr.DisplayCharacters();
            }
            else
            {
                MessageBox.Show("Name cannot be empty!", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(null, "Really delete object?", "Delete Object?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Character character = GetRightCharacterList().Find(x => x.GetName().Equals(tbName.Text));
                GetRightCharacterList().Remove(character);
                mgr.listCombinedCharacters.Remove(character);
                mgr.DisplayCharacters();
                _parentPage.Dispose();
            }
        }

        private void tbSizeAC_TextChanged(object sender, EventArgs e)
        {
            CalculateAC();
        }

        private void tbDefAC_TextChanged(object sender, EventArgs e)
        {
            CalculateAC();
        }

        private void tbShieldAC_TextChanged(object sender, EventArgs e)
        {
            CalculateAC();
        }

        private void tbArmorAC_TextChanged(object sender, EventArgs e)
        {
            CalculateAC();
        }

        private void tbNatAC_TextChanged(object sender, EventArgs e)
        {
            CalculateAC();
        }

        private void tbDexAC_TextChanged(object sender, EventArgs e)
        {
            CalculateAC();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = mgr.listCreatureSizes.Find(x => x.GetName().Equals(cbSize.SelectedItem.ToString()));
            tbSizeAC.Text = size.GetModifier().ToString();

            UpdateSheet();
        }

        private void tbInitDex_TextChanged(object sender, EventArgs e)
        {
            tbInit.Text = (Convert.ToInt32(tbInitDex.Text) + Convert.ToInt32(tbInitMisc.Text)).ToString();
        }

        private void tbInitMisc_TextChanged(object sender, EventArgs e)
        {
            tbInit.Text = (Convert.ToInt32(tbInitDex.Text) + Convert.ToInt32(tbInitMisc.Text)).ToString();
        }

        private void tbRaceName_Leave(object sender, EventArgs e)
        {
            Character character = mgr.listCharacters.Find(x => x.GetName().Equals(tbRaceName.Text));
            
            if (character != null)
            {
                CharacterSheet cSheet = character.GetCharacterSheet();
                this.cbType.SelectedItem = cSheet.creatureType;
                this.cbSize.SelectedItem = cSheet.size;

                this.tbRacialHD.Text = cSheet.hitDieNum.ToString();
                this.tbInit.Text = cSheet.init.ToString();
                this.tbInitMisc.Text = cSheet.initMisc.ToString();
                this.tbSpeed.Text = cSheet.speed;
                this.tbBAB.Text = cSheet.baseAttackBonus.ToString();
                this.tbFort.Text = cSheet.fortSave.ToString();
                this.tbRef.Text = cSheet.refSave.ToString();
                this.tbWill.Text = cSheet.willSave.ToString();

                this.tbStr.Text = cSheet.str.ToString();
                this.tbDex.Text = cSheet.dex.ToString();
                this.tbCon.Text = cSheet.con.ToString();
                this.tbInt.Text = cSheet.intelligence.ToString();
                this.tbWis.Text = cSheet.wis.ToString();
                this.tbCha.Text = cSheet.cha.ToString();

                this.tbNatAC.Text = cSheet.natAC.ToString();
                this.tbArmorAC.Text = cSheet.armorAC.ToString();
                this.tbShieldAC.Text = cSheet.shieldAC.ToString();
                this.tbDefAC.Text = cSheet.defAC.ToString();
                this.tbAttack.Text = cSheet.attack;
                this.tbFullAttack.Text = cSheet.fullAttack;
                this.tbSpace.Text = cSheet.space.ToString();
                this.tbReach.Text = cSheet.reach.ToString();

                FillSpecialsColumn(cSheet.feats, "colFeats");
                FillSpecialsColumn(cSheet.specialAttacks, "colSpecialAttacks");
                FillSpecialsColumn(cSheet.specialQualities, "colSpecialQualities");

                //Goes last to overwrite any issues
                this.tbHP.Text = cSheet.hp.ToString();
            }
        }

        private string[] CharacterSheetToString()
        {
            return new string[]{tbName.Text, tbRaceName.Text, tbClasses.Text, tbLevels.Text, cbType.SelectedItem.ToString(), cbSize.SelectedItem.ToString(), tbRacialHD.Text,
                                            tbHP.Text, tbInit.Text, tbInitMisc.Text, tbSpeed.Text,
                                            tbBAB.Text, tbFort.Text, tbRef.Text, tbWill.Text,
                                            tbStr.Text, tbDex.Text, tbCon.Text, tbInt.Text,
                                            tbWis.Text, tbCha.Text, tbNatAC.Text, tbArmorAC.Text,
                                            tbShieldAC.Text, tbDefAC.Text, tbAttack.Text, tbFullAttack.Text, tbSpace.Text,
                                            tbReach.Text, GetSpecialsColumn("colSpecialAttacks"), GetSpecialsColumn("colSpecialQualities"), GetSpecialsColumn("colFeats"),
                                            tbHP.Text, tbTotalAC.Text, tbTouchAC.Text, tbFFAC.Text};
                
        }

        private void AbilityChangeSkills(string stat, int modVal)
        {
            foreach (DataGridViewRow r in dgvSkills.Rows)
            {
                DataGridViewCell skillTypeCell = r.Cells["colAbility"];
                DataGridViewCell abilityModCell = r.Cells["colMod"];
                DataGridViewCell abilityRanksCell = r.Cells["colRanks"];
                DataGridViewCell abilityMiscCell = r.Cells["colMisc"];
                DataGridViewCell abilityTotalCell = r.Cells["colTotal"];
                
                if (skillTypeCell.Value != null && skillTypeCell.Value.ToString().Contains(stat))
                {
                    abilityModCell = r.Cells["colMod"];
                    abilityModCell = r.Cells["colMod"];
                    abilityModCell.Value = modVal.ToString();

                    abilityTotalCell.Value = Convert.ToInt32(abilityModCell.Value) + Convert.ToInt32(abilityRanksCell.Value) + Convert.ToInt32(abilityMiscCell.Value);
                }
            }
        }

        private void tbStr_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void CalculateSkills()
        {
            AbilityChangeSkills("Str", GetModifier(tbStr.Text));
            AbilityChangeSkills("Dex", GetModifier(tbDex.Text));
            AbilityChangeSkills("Con", GetModifier(tbCon.Text));
            AbilityChangeSkills("Int", GetModifier(tbInt.Text));
            AbilityChangeSkills("Wis", GetModifier(tbWis.Text));
            AbilityChangeSkills("Cha", GetModifier(tbCha.Text));
        }

        private void dgvSkills_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow r = dgvSkills.Rows[e.RowIndex];
                if (!r.IsNewRow)
                {

                    DataGridViewCell skillTypeCell = r.Cells["colAbility"];
                    DataGridViewCell abilityModCell = r.Cells["colMod"];
                    DataGridViewCell abilityRanksCell = r.Cells["colRanks"];
                    DataGridViewCell abilityMiscCell = r.Cells["colMisc"];
                    DataGridViewCell abilityTotalCell = r.Cells["colTotal"];

                    abilityTotalCell.Value = (Convert.ToInt32(abilityModCell.Value) + Convert.ToInt32(abilityRanksCell.Value) + Convert.ToInt32(abilityMiscCell.Value)).ToString();
                }
            }
        }

        private List<string> GetSkillsList()
        {
            List<string> skillsList = new List<string>();

            foreach (DataGridViewRow r in dgvSkills.Rows)
            {
                DataGridViewCell abilityTotalCell = r.Cells["colTotal"];
                DataGridViewCell abilityModCell = r.Cells["colMod"];
                DataGridViewCell abilityRanksCell = r.Cells["colRanks"];
                DataGridViewCell abilityMiscCell = r.Cells["colMisc"];

                skillsList.Add(abilityTotalCell.Value + "|" + abilityModCell.Value + "|" + abilityRanksCell.Value + "|" + abilityMiscCell.Value);
            }

            return skillsList;

        }

        private void tbCha_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void tbInt_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void tbFeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillSpecialsColumn(string values, string colName)
        {
            string[] split = values.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                if (dgvSpecials.Rows[i].IsNewRow)
                {
                    dgvSpecials.Rows.Add();
                }
                dgvSpecials.Rows[i].Cells[colName].Value = split[i].Trim();
            }
        }

        private string GetSpecialsColumn(string colName)
        {
            string rv = string.Empty;

            foreach (DataGridViewRow r in dgvSpecials.Rows)
            {
                rv += r.Cells[colName].Value + ", ";
            }

            return rv.Trim(); ;
        }

        private List<Character> GetRightCharacterList()
        {
            if (chkCampaign.Checked)
            {
                return mgr.listCampaignCharacters;
            }
            else
            {
                return mgr.listCharacters;
            }
        }

        private void tbClasses_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctxtClasses.Items.Clear();
                string[] split = tbClasses.Text.Split('/');
                foreach (string s in split)
                {
                    if (!s.Equals(string.Empty))
                    {
                        ctxtClasses.Items.Add("Open " + s.Trim());
                    }
                }
                ctxtClasses.Show();
            }
        }

        private void ctxtClasses_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string name = e.ClickedItem.Text;
            name = name.Replace("Open ", "");
            mgr.NewTab("Character Class", name);
        }

        private void tbClassesLevels_Leave(object sender, EventArgs e)
        {
            GetClassLevels();
            UpdateSheet();
        }

        private void GetClassLevels(){
            classLevels.Clear();
            List<string> classes = new List<string>();
            string[] classesSplit = tbClasses.Text.Split('/');
            foreach (string s in classesSplit)
            {
                if (!s.Equals(string.Empty))
                {
                    classes.Add(s.Trim());
                }
            }

            List<string> levels = new List<string>();
            string[] levelsSplit = tbLevels.Text.Split('/');
            foreach (string s in levelsSplit)
            {
                if (!s.Equals(string.Empty))
                {
                    levels.Add(s.Trim());
                }
            }

            for( int i=0; i < classes.Count; i++)
            {
                if (levels.Count > i)
                {
                    try
                    {
                        classLevels.Add(new KeyValuePair<string, int>(classes[i], Convert.ToInt32(levels[i])));
                    }
                    catch { }
                }
            }
        }
    }
}
