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

        public CharacterControl()
        {
            InitializeComponent();
            Init(); 
        }

        public CharacterControl(TabPage parentPage, Character c)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;

            _character = c;
            CharacterSheet cSheet = c.GetCharacterSheet();

            this.tbName.Text = cSheet.name;
            this.tbRaceName.Text = cSheet.raceName;
            this.tbClasses.Text = cSheet.classes;
            this.tbLevels.Text = cSheet.levels;
            this.cbType.SelectedItem = cSheet.type;
            this.cbSize.SelectedItem = cSheet.size;

            this.tbHDSize.Text = cSheet.hitDieSize.ToString();
            this.tbHDNum.Text = cSheet.hitDieNum.ToString();
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
            this.tbSpecialAttacks.Text = cSheet.specialAttacks;
            this.tbSpecialQualities.Text = cSheet.specialQualities;
            this.tbFeats.Text = cSheet.feats;

            //Goes last to overwrite any issues
            this.tbHP.Text =cSheet.hp.ToString();
            AssignCharacterSkills();
        }

        public CharacterControl(TabPage parentPage)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;
        }

        public CharacterControl(TabPage parentPage, string name)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;

            tbName.Text = name;
            btnSave.Text = "Save";

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
            tc = mgr.listCreatureTypes.Find(x => x.name.Equals(cbType.SelectedItem.ToString()));
            tbHDSize.Text = tc.hitDieSize.ToString();

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
            int result;
            if (tbHDNum.Text != string.Empty)
            {
                if (Convert.ToInt32(tbHDNum.Text) > 0 && !int.TryParse(tbHDNum.Text, out result))
                {
                    MessageBox.Show("Must be int!");
                }
                else
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
            int HDNum = Convert.ToInt32(tbHDNum.Text);
            double HDSize = Convert.ToDouble(tbHDSize.Text);
            double avgHpPerDie = (HDSize+1)/2;
            double averageHP = HDNum * avgHpPerDie;
            int hp = Convert.ToInt32(averageHP);
            if (tc.name != "Undead")
            {
                hp += (GetModifier(tbCon.Text) * HDNum);
            }

            tbHP.Text = hp.ToString();
        }

        public void CalculateBABGrapple()
        {
            int bab = 0;
            if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.POOR)
            {
                bab = (Convert.ToInt32(tbHDNum.Text) / 2);
            }
            else if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.AVERAGE)
            {
                bab = (Int32)(Convert.ToInt32(tbHDNum.Text) * .75);
            }
            else if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.GOOD)
            {
                bab = Convert.ToInt32(tbHDNum.Text);
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
                int num = Convert.ToInt32(number);
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
            if ((PublicManager.SaveType)tc.fortSave == PublicManager.SaveType.POOR)
            {
                fort = Convert.ToInt32(tbHDNum.Text) / 3;
            }
            else if ((PublicManager.SaveType)tc.fortSave == PublicManager.SaveType.GOOD)
            {
                fort = (Convert.ToInt32(tbHDNum.Text) / 2) + 2;
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
            if ((PublicManager.SaveType)tc.refSave == PublicManager.SaveType.POOR)
            {
                reflex = Convert.ToInt32(tbHDNum.Text) / 3;
            }
            else if ((PublicManager.SaveType)tc.refSave == PublicManager.SaveType.GOOD)
            {
                reflex = (Convert.ToInt32(tbHDNum.Text) / 2) + 2;
            }
            reflex += GetModifier(tbDex.Text);
            tbRef.Text = reflex.ToString();
        }

        public void CalculateWillSave()
        {
            int will = 0;
            if ((PublicManager.SaveType)tc.willSave == PublicManager.SaveType.POOR)
            {
                will = Convert.ToInt32(tbHDNum.Text) / 3;
            }
            else if ((PublicManager.SaveType)tc.willSave == PublicManager.SaveType.GOOD)
            {
                will = (Convert.ToInt32(tbHDNum.Text) / 2) + 2;
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
                        Character character = mgr.listCharacters.Find(x => x.GetName().Equals(tbName.Text));
                        if (tc != null)
                        {
                            mgr.listCharacters.Remove(character);
                        }
                    }
                    catch { }
                }

                mgr.listCharacters.Add(new Character(CharacterSheetToString(), GetSkillsList()));
                try
                {
                    mgr.listCharacters.Sort((a, b) => a.GetName().CompareTo(b.GetName()));
                }
                catch { }
                PublicManager.SerializeCharactersToXML(mgr.listCharacters);
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
                Character character = mgr.listCharacters.Find(x => x.GetName().Equals(tbName.Text));
                mgr.listCharacters.Remove(character);
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
                this.cbType.SelectedItem = cSheet.type;
                this.cbSize.SelectedItem = cSheet.size;

                this.tbHDSize.Text = cSheet.hitDieSize.ToString();
                this.tbHDNum.Text = cSheet.hitDieNum.ToString();
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
                this.tbSpecialAttacks.Text = cSheet.specialAttacks;
                this.tbSpecialQualities.Text = cSheet.specialQualities;
                this.tbFeats.Text = cSheet.feats;

                //Goes last to overwrite any issues
                this.tbHP.Text = cSheet.hp.ToString();
            }
        }

        private string[] CharacterSheetToString()
        {
            return new string[]{tbName.Text, tbRaceName.Text, tbClasses.Text, tbLevels.Text, cbType.SelectedItem.ToString(), cbSize.SelectedItem.ToString(), tbHDNum.Text,
                                            tbHDSize.Text, tbHP.Text, tbInit.Text, tbInitMisc.Text, tbSpeed.Text,
                                            tbBAB.Text, tbFort.Text, tbRef.Text, tbWill.Text,
                                            tbStr.Text, tbDex.Text, tbCon.Text, tbInt.Text,
                                            tbWis.Text, tbCha.Text, tbNatAC.Text, tbArmorAC.Text,
                                            tbShieldAC.Text, tbDefAC.Text, tbAttack.Text, tbFullAttack.Text, tbSpace.Text,
                                            tbReach.Text, tbSpecialAttacks.Text, tbSpecialQualities.Text, tbFeats.Text, tbHP.Text, tbTotalAC.Text, tbTouchAC.Text, tbFFAC.Text};
                
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
    }
}
