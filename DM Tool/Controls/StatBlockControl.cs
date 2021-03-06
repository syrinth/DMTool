﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Classes;
using DM_Tool.Controls.Spell_Controls;

namespace DM_Tool.Controls
{

    public partial class StatBlockControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parent;
        private CreatureType tc;
        private CreatureSize size;
        private Character _character;
        private List<KeyValuePair<string, int>> classLevels = new List<KeyValuePair<string, int>>();
        private int RacialHD = 0;

        public StatBlockControl()
        {
            InitializeComponent();
            Init();
        }

        public StatBlockControl(TabPage parentPage, Character c)
        {
            InitializeComponent();
            Init();

            _parent = parentPage;

            _character = c;
            StatBlock statBlock = c.GetCharacterSheet();

            this.chkCampaign.Checked = c._campaignSpecific;
            this.tbName.Text = statBlock.name;
            this.tbRaceName.Text = statBlock.raceName;
            this.tbClasses.Text = statBlock.classes;
            this.tbLevels.Text = statBlock.levels;
            this.cbType.SelectedItem = statBlock.creatureType;
            this.cbSize.SelectedItem = statBlock.size;

            this.tbRacialHD.Text = statBlock.hitDieNum.ToString();
            this.tbHD.Text = statBlock.hdInfo;
            this.tbInit.Text = statBlock.init.ToString();
            this.tbInitMisc.Text = statBlock.initMisc.ToString();
            this.tbSpeed.Text = statBlock.speed;
            this.tbBAB.Text = ((PublicManager.BABType)statBlock.baseAttackBonus).ToString();
            this.tbGrapple.Text = statBlock.grapple.ToString();
            this.tbFort.Text = ((PublicManager.SaveType)statBlock.fortSave).ToString();
            this.tbRef.Text = ((PublicManager.SaveType)statBlock.refSave).ToString();
            this.tbWill.Text = ((PublicManager.SaveType)statBlock.willSave).ToString();
            
            this.tbStr.Text = statBlock.str.ToString();
            this.tbDex.Text = statBlock.dex.ToString();
            this.tbCon.Text = statBlock.con.ToString();
            this.tbInt.Text = statBlock.intelligence.ToString();
            this.tbWis.Text = statBlock.wis.ToString();
            this.tbCha.Text = statBlock.cha.ToString();

            this.tbAttack.Text = statBlock.attack;
            this.tbFullAttack.Text = statBlock.fullAttack;
            this.tbSpace.Text = statBlock.space.ToString();
            this.tbReach.Text = statBlock.reach.ToString();

            //Write out Armor Class
            WriteACToTextBox(statBlock);
            this.tbTouchAC.Text = statBlock.touchAC.ToString();
            this.tbFFAC.Text = statBlock.ffAC.ToString();

            tbFeats.Text = statBlock.feats;
            tbSpecAtks.Text = statBlock.specialAttacks;
            tbSpecQualities.Text = statBlock.specialQualities;

            AssignCharacterSkills();
            tc = mgr.listCreatureTypes.Find(x => x.name.Equals(cbType.SelectedItem));
            GetClassLevels();

            foreach (List<string> s in c._spells)
            {
                string className = s[0];

                TabPage page = new TabPage(className);
                TextInformationControl ctl = new TextInformationControl(s[1]);
                page.Controls.Add(ctl);
                this.tabSpellPages.Controls.Add(page);
                this.tabSpellPages.SelectedTab = page;
            }

            AssignEquipment(c._equipment);

            //Goes last to overwrite any issues
            this.tbHP.Text = statBlock.hp.ToString();
        }

        public StatBlockControl(TabPage parentPage)
        {
            InitializeComponent();
            Init();
            InitEmptyDGV();

            _parent = parentPage;
        }

        public StatBlockControl(TabPage parentPage, string name)
        {
            InitializeComponent();
            Init();
            InitEmptyDGV();

            _parent = parentPage;

            tbName.Text = name;
        }

        public void Init()
        {
            tc = new CreatureType();
            LoadTypes();
            LoadSizes();
            cbType.SelectedIndex = 0;
        }

        public void WriteACToTextBox(StatBlock statBlock)
        {
            AppendACValsToTextBox(statBlock.natAC.ToString(), "Nat");
            AppendACValsToTextBox(statBlock.armorAC.ToString(), "Armor");
            AppendACValsToTextBox(statBlock.shieldAC.ToString(), "Shield");
            AppendACValsToTextBox(statBlock.defAC.ToString(), "Def");
            AppendACValsToTextBox(size.GetModifier().ToString(), "Size");
            AppendACValsToTextBox(GetModifier(tbDex.Text).ToString(), "Dex");

            this.tbTotalAC.Text = statBlock.totalAC.ToString();
        }

        public void InitEmptyDGV()
        {
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

            List<string> equipment = new List<string>() { "Head", "Face", "Neck", "Body", "Armor", "Back", "Belt", "Bracers", "Gloves", "Ring R.", "Ring L.", "Feet" };
            foreach (string s in equipment)
            {
                dgvEquipment.Rows.Add(s, "", "");
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
                    int count = 0;
                    if (split.Length == 5)
                    {
                        r.Cells["colSkillName"].Value = split[count++];
                    }
                    r.Cells["colTotal"].Value = split[count++];
                    r.Cells["colMod"].Value = split[count++];
                    r.Cells["colRanks"].Value = split[count++];
                    r.Cells["colMisc"].Value = split[count++];
                }
            }
        }

        public void AssignEquipment(List<string> equip)
        {
            for(int i=0; i < equip.Count; i++)
            {
                try
                {
                    string[] split = equip[i].Split('|');

                    dgvEquipment.Rows.Add(split[0], split[1]);
                }catch{}
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

        private void btnNewType_Click(object sender, EventArgs e)
        {
            frmNewCreatureType frm = new frmNewCreatureType();
            frm.ShowDialog();

            LoadTypes();
        }

        public void GetRacialHD()
        {
            try
            {
                RacialHD = Convert.ToInt32(tbRacialHD.Text);
            }
            catch { }
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

        private string[] StatBlockToString()
        {
            return new string[]{tbName.Text, tbRaceName.Text, tbClasses.Text, tbLevels.Text, cbType.SelectedItem.ToString(), cbSize.SelectedItem.ToString(), tbRacialHD.Text,
                                            tbHP.Text, tbInit.Text, tbInitMisc.Text, tbSpeed.Text,
                                            tbBAB.Text, tbFort.Text, tbRef.Text, tbWill.Text,
                                            tbStr.Text, tbDex.Text, tbCon.Text, tbInt.Text,
                                            tbWis.Text, tbCha.Text, ParseValFromAC("Nat"), ParseValFromAC("Armor"),
                                            ParseValFromAC("Shield"), ParseValFromAC("Def"), tbAttack.Text, tbFullAttack.Text, tbSpace.Text,
                                            tbReach.Text, tbSpecAtks.Text, tbSpecQualities.Text, tbFeats.Text,
                                            tbHP.Text, tbTotalAC.Text, tbTouchAC.Text, tbFFAC.Text, tbGrapple.Text, tbHD.Text};
                
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

                    abilityTotalCell.Value = PublicCode.ConvertToIntSafely(abilityModCell.Value.ToString()) + PublicCode.ConvertToIntSafely(abilityRanksCell.Value.ToString()) + PublicCode.ConvertToIntSafely(abilityMiscCell.Value.ToString());
                }
            }
        }

        private List<string> GetSkillsList()
        {
            List<string> skillsList = new List<string>();

            foreach (DataGridViewRow r in dgvSkills.Rows)
            {
                DataGridViewCell abilitySkillName = r.Cells["colSkillName"];
                DataGridViewCell abilityTotalCell = r.Cells["colTotal"];
                DataGridViewCell abilityModCell = r.Cells["colMod"];
                DataGridViewCell abilityRanksCell = r.Cells["colRanks"];
                DataGridViewCell abilityMiscCell = r.Cells["colMisc"];

                skillsList.Add(abilitySkillName.Value + "|" + abilityTotalCell.Value + "|" + abilityModCell.Value + "|" + abilityRanksCell.Value + "|" + abilityMiscCell.Value);
            }

            return skillsList;
        }

        private List<List<string>> GetSpellsList()
        {
            List<List<string>> spellPages = new List<List<string>>();

            foreach (TabPage p in tabSpellPages.TabPages)
            {
                List<string> spellPageInfo = new List<string>();
                spellPageInfo.Add(p.Text);

                foreach (Control c in p.Controls)
                {
                    try
                    {
                        spellPageInfo.Add(((SpellPage)c).GetSpellInfo());
                    }
                    catch
                    {
                    }
                }

                spellPages.Add(spellPageInfo);
            }

            return spellPages;
        }

        private List<string> GetEquipmentList()
        {
            List<string> equipmentList = new List<string>();

            foreach (DataGridViewRow r in dgvEquipment.Rows)
            {
                if (r.Cells["colSlot"].Value != null || r.Cells["colItemName"].Value != null)
                {
                    DataGridViewCell itemSlot = r.Cells["colSlot"];
                    DataGridViewCell itemName = r.Cells["colItemName"];

                    equipmentList.Add(itemSlot.Value + "|" + itemName.Value);
                }
            }

            return equipmentList;
        }

        private List<Character> GetCorrectCharacterList()
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

        private void AppendACValsToTextBox(string val, string type){
            int intVal = PublicCode.ConvertToIntSafely(val);
            if (intVal == 0)
            {
                return;
            }

            if(tbACVals.Text.Length > 0){
                tbACVals.Text += ", ";
            }
            
            if (intVal > 0)
            {
                tbACVals.Text += "+";
            }
            tbACVals.Text += val + " " + type;
        }

        private string ParseValFromAC(string acType){
            string[] split = tbACVals.Text.Split(',');

            for (int i = 0; i < split.Length; i++)
            {
                try
                {
                    string[] acSplit = split[i].Replace("+", "").Trim().Split(' ');
                    string modVal = acSplit[0];
                    string modName = acSplit[1];
                    if (modName == acType)
                    {
                        return modVal.Split(' ')[0];
                    }
                }
                catch { }
            }
            return "";
        }

        #region Events
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string control = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl.Name;

            switch (control)
            {
                case "tabPageCharacterSheet":
                    UpdateSheet();
                    break;
                case "tbHD":
                    CalculateBaseHP();
                    break;
                case "tbBAB":
                    CalculateBAB();
                    break;
                case "tbGrapple":
                    CalculateGrapple();
                    break;
                case "tbHP":
                    CalculateBaseHP();
                    break;
                case "tbTotalAC":
                    CalculateAC();
                    break;
                case "tbFort":
                    CalculateFortSave();
                    break;
                case "tbRef":
                    CalculateRefSave();
                    break;
                case "tbWill":
                    CalculateWillSave();
                    break;
                default:
                    break;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty)
            {
                if (tbRaceName.Text == "Race")
                {
                    tbRaceName.Text = "";
                }
                _parent.Text = tbName.Text;
                if (mgr.listCharacters.Count > 0)
                {
                    try
                    {
                        Character character = GetCorrectCharacterList().Find(x => x.GetName().Equals(tbName.Text));
                        if (character != null)
                        {
                            GetCorrectCharacterList().Remove(character);
                        }
                        if (chkCampaign.Checked)
                        {
                            character = mgr.listCharacters.Find(x => x.GetName().Equals(tbName.Text));
                            if (character != null)
                            {
                                mgr.listCharacters.Remove(character);
                            }
                        }
                    }
                    catch { }
                }

                GetCorrectCharacterList().Add(new Character(StatBlockToString(), chkCampaign.Checked, GetSkillsList(), GetSpellsList(), GetEquipmentList()));
                try
                {
                    GetCorrectCharacterList().Sort((a, b) => a.GetName().CompareTo(b.GetName()));
                }
                catch { }
                PublicManager.SerializeCampaignCharactersToXML(mgr.listCampaignCharacters);
                PublicManager.SerializeCharactersToXML(mgr.listCharacters);
                mgr.DisplayCharacters();
            }
            else
            {
                MessageBox.Show("Name cannot be empty!", "Error");
            }
        }

        private void tabInventoryContainers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctxtInventory.Show(Cursor.Position);
            }
        }
        
        private void tabSpells_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctxtNewSpellPage.Show(Cursor.Position);
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
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = mgr.listCreatureSizes.Find(x => x.GetName().Equals(cbSize.SelectedItem.ToString()));
        }

        private void tbRaceName_Leave(object sender, EventArgs e)
        {
            Character character = mgr.listCharacters.Find(x => x.GetName().Equals(tbRaceName.Text));

            if (character != null)
            {
                StatBlock cSheet = character.GetCharacterSheet();
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

                this.tbAttack.Text = cSheet.attack;
                this.tbFullAttack.Text = cSheet.fullAttack;
                this.tbSpace.Text = cSheet.space.ToString();
                this.tbReach.Text = cSheet.reach.ToString();

                tbFeats.Text = cSheet.feats;
                tbSpecAtks.Text = cSheet.specialAttacks;
                tbSpecQualities.Text = cSheet.specialQualities;

                //Goes last to overwrite any issues
                this.tbHP.Text = cSheet.hp.ToString();
            }
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

                    abilityTotalCell.Value = (PublicCode.ConvertToIntSafely(abilityModCell.Value.ToString()) + PublicCode.ConvertToIntSafely(abilityRanksCell.Value.ToString()) + PublicCode.ConvertToIntSafely(abilityMiscCell.Value.ToString())).ToString();
                }
                if (e.ColumnIndex == dgvSkills.Columns["colSkillName"].Index)
                {
                    dgvSkills.Sort(dgvSkills.Columns["colSkillName"], ListSortDirection.Ascending);
                }
            }
        }

        private void addNewSpellPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInputDialog txtDiag = new TextInputDialog("Spell page name?");
            txtDiag.ShowDialog();

            if (txtDiag.DialogResult == DialogResult.OK)
            {
                string className = txtDiag.GetText();

                TabPage page = new TabPage(className);
                TextInformationControl ctl = new TextInformationControl();//page, advRoom, this);
                page.Controls.Add(ctl);
                this.tabSpellPages.Controls.Add(page);
                this.tabSpellPages.SelectedTab = page;
            }
        }

        //These three stay automatic since there are only Dex and Misc modifiers to the Initiative and they should stay in sync
        private void tbInitDex_TextChanged(object sender, EventArgs e)
        {
            tbInit.Text = (Convert.ToInt32(tbInitDex.Text) + Convert.ToInt32(tbInitMisc.Text)).ToString();
        }
        private void tbInitMisc_TextChanged(object sender, EventArgs e)
        {
            tbInit.Text = (Convert.ToInt32(tbInitDex.Text) + Convert.ToInt32(tbInitMisc.Text)).ToString();
        }
        private void tbDex_TextChanged(object sender, EventArgs e)
        {
            tbInitDex.Text = GetModifier(tbDex.Text).ToString();
        }
        #endregion

        #region Update Methods
        public void UpdateSheet()
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
                CalculateBAB();
                CalculateGrapple();

                //Calculate Saving Throws
                CalculateSaves();

                CalculateBaseHP();

                CalculateAC();

                CalculateSkills();
            }
        }

        public void CalculateSaves()
        {
            CalculateFortSave();
            CalculateRefSave();
            CalculateWillSave();
        }
        
        public void CalculateFortSave()
        {
            int fort = 0;
            GetRacialHD();
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
            GetRacialHD();
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
            GetRacialHD();
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
        
        private void CalculateSkills()
        {
            AbilityChangeSkills("Str", GetModifier(tbStr.Text));
            AbilityChangeSkills("Dex", GetModifier(tbDex.Text));
            AbilityChangeSkills("Con", GetModifier(tbCon.Text));
            AbilityChangeSkills("Int", GetModifier(tbInt.Text));
            AbilityChangeSkills("Wis", GetModifier(tbWis.Text));
            AbilityChangeSkills("Cha", GetModifier(tbCha.Text));
        }

        public void CalculateBaseHP()
        {
            int HDNum = 0;
            tbHD.Text = "";
            int hp = 0;
            GetRacialHD();
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

            foreach (KeyValuePair<string, int> kvp in classLevels)
            {
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

        public void CalculateBAB()
        {
            int bab = 0;
            GetRacialHD();
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
        }

        public void CalculateGrapple()
        {
            tbGrapple.Text = (Convert.ToInt32(tbBAB.Text) + size.GetSpecialModifier() + GetModifier(tbStr.Text)).ToString();
        }

        public void CalculateAC()
        {
            int totalAC = 10;
            int touchAC = 10;
            int flatFootedAC = 10;

            string[] split = tbACVals.Text.Split(',');

            for (int i = 0; i < split.Length; i++)
            {
                try
                {
                    string modVal = split[i].Trim().Replace("+", "");
                    string modType = modVal.Trim().Split(' ')[1];
                    modVal = modVal.Split(' ')[0];
                    switch (modType)
                    {
                        case "Dex":
                            totalAC += Convert.ToInt32(modVal);
                            touchAC += Convert.ToInt32(modVal);
                            if (Convert.ToInt32(modVal) < 0)
                            {
                                flatFootedAC += Convert.ToInt32(modVal);
                            }
                            break;
                        case "Nat":
                            totalAC += Convert.ToInt32(modVal);
                            flatFootedAC += Convert.ToInt32(modVal);
                            break;
                        case "Armor":
                            totalAC += Convert.ToInt32(modVal);
                            flatFootedAC += Convert.ToInt32(modVal);
                            break;
                        case "Shield":
                            totalAC += Convert.ToInt32(modVal);
                            flatFootedAC += Convert.ToInt32(modVal);
                            break;
                        case "Def":
                            totalAC += Convert.ToInt32(modVal);
                            touchAC += Convert.ToInt32(modVal);
                            flatFootedAC += Convert.ToInt32(modVal);
                            break;
                        case "Size":
                            totalAC += Convert.ToInt32(modVal);
                            touchAC += Convert.ToInt32(modVal);
                            flatFootedAC += Convert.ToInt32(modVal);
                            break;
                        default:
                            break;
                    }
                }
                catch { }
            }

            tbTotalAC.Text = totalAC.ToString();
            tbTouchAC.Text = touchAC.ToString();
            tbFFAC.Text = flatFootedAC.ToString();
        }
        #endregion

        
    }
}
