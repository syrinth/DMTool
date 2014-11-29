using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Classes;

namespace DM_Tool
{/*
    public partial class MonsterControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parentPage;
        private CreatureType tc;
        private CreatureSize size;

        public MonsterControl()
        {
            InitializeComponent();
            Init(); 
        }

        public MonsterControl(TabPage parentPage, CharacterSheet m)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;

            this.tbName.Text = m.name;
            this.tbRaceName.Text = m.raceName;
            this.tbClasses.Text = m.classes;
            this.tbLevels.Text = m.levels;
            this.cbType.SelectedItem = m.type;
            this.cbSize.SelectedItem = m.size;

            this.tbHDSize.Text = m.hitDieSize.ToString();
            this.tbHDNum.Text = m.hitDieNum.ToString();
            this.tbInit.Text = m.init.ToString();
            this.tbInitMisc.Text = m.initMisc.ToString();
            this.tbSpeed.Text = m.speed;
            this.tbBAB.Text = ((PublicManager.BABType)m.baseAttackBonus).ToString();
            this.tbFort.Text = ((PublicManager.SaveType)m.fortSave).ToString();
            this.tbRef.Text = ((PublicManager.SaveType)m.refSave).ToString();
            this.tbWill.Text = ((PublicManager.SaveType)m.willSave).ToString();
            
            this.tbStr.Text = m.str.ToString();
            this.tbDex.Text = m.dex.ToString();
            this.tbCon.Text = m.con.ToString();
            this.tbInt.Text = m.intelligence.ToString();
            this.tbWis.Text = m.wis.ToString();
            this.tbCha.Text = m.cha.ToString();

            this.tbNatAC.Text = m.natAC.ToString();
            this.tbArmorAC.Text = m.armorAC.ToString();
            this.tbShieldAC.Text = m.shieldAC.ToString();
            this.tbDefAC.Text = m.defAC.ToString();
            this.tbAttack.Text = m.attack;
            this.tbFullAttack.Text = m.fullAttack;
            this.tbSpace.Text = m.space.ToString();
            this.tbReach.Text = m.reach.ToString();
            this.tbSpecialAttacks.Text = m.specialAttacks;
            this.tbSpecialQualities.Text = m.specialQualities;
            this.tbFeats.Text = m.feats;

            //Goes last to overwrite any issues
            this.tbHP.Text = m.hp.ToString();
        }

        public MonsterControl(TabPage parentPage)
        {
            InitializeComponent();
            Init();

            _parentPage = parentPage;
        }

        public MonsterControl(TabPage parentPage, string name)
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
                _parentPage.Text = tbName.Text;
                Character tc = mgr.listCharacters.Find(x => x.GetName.Equals(tbName.Text));
                if (tc != null)
                {
                    mgr.listCharacters.Remove(tc);
                }
                mgr.listCharacters.Add(new CharacterSheet(tbName.Text, tbRaceName.Text, tbClasses.Text, tbLevels.Text, cbType.SelectedItem.ToString(), cbSize.SelectedItem.ToString(), tbHDNum.Text,
                                            tbHDSize.Text, tbHP.Text, tbInit.Text, tbInitMisc.Text, tbSpeed.Text,
                                            tbBAB.Text, tbFort.Text, tbRef.Text, tbWill.Text,
                                            tbStr.Text, tbDex.Text, tbCon.Text, tbInt.Text,
                                            tbWis.Text, tbCha.Text, tbNatAC.Text, tbArmorAC.Text,
                                            tbShieldAC.Text, tbDefAC.Text, tbAttack.Text, tbFullAttack.Text, tbSpace.Text,
                                            tbReach.Text, tbSpecialAttacks.Text, tbSpecialQualities.Text, tbFeats.Text, tbHP.Text, tbTotalAC.Text, tbTouchAC.Text, tbFFAC.Text));
                mgr.listCharacters.Sort((a, b) => a.name.CompareTo(b.name));
                PublicManager.SerializeCharactersToXML(mgr.listCharacters);
                mgr.DisplayCreatures();
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
                CharacterSheet m = mgr.listCharacters.Find(x => x.name.Equals(tbName.Text));
                mgr.listCharacters.Remove(m);
                mgr.DisplayCreatures();
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
            CharacterSheet m = mgr.listCharacters.Find(x => x.name.Equals(tbRaceName.Text));

            if (m != null)
            {
                this.cbType.SelectedItem = m.type;
                this.cbSize.SelectedItem = m.size;

                this.tbHDSize.Text = m.hitDieSize.ToString();
                this.tbHDNum.Text = m.hitDieNum.ToString();
                this.tbInit.Text = m.init.ToString();
                this.tbInitMisc.Text = m.initMisc.ToString();
                this.tbSpeed.Text = m.speed;
                this.tbBAB.Text = m.baseAttackBonus.ToString();
                this.tbFort.Text = m.fortSave.ToString();
                this.tbRef.Text = m.refSave.ToString();
                this.tbWill.Text = m.willSave.ToString();

                this.tbStr.Text = m.str.ToString();
                this.tbDex.Text = m.dex.ToString();
                this.tbCon.Text = m.con.ToString();
                this.tbInt.Text = m.intelligence.ToString();
                this.tbWis.Text = m.wis.ToString();
                this.tbCha.Text = m.cha.ToString();

                this.tbNatAC.Text = m.natAC.ToString();
                this.tbArmorAC.Text = m.armorAC.ToString();
                this.tbShieldAC.Text = m.shieldAC.ToString();
                this.tbDefAC.Text = m.defAC.ToString();
                this.tbAttack.Text = m.attack;
                this.tbFullAttack.Text = m.fullAttack;
                this.tbSpace.Text = m.space.ToString();
                this.tbReach.Text = m.reach.ToString();
                this.tbSpecialAttacks.Text = m.specialAttacks;
                this.tbSpecialQualities.Text = m.specialQualities;
                this.tbFeats.Text = m.feats;

                //Goes last to overwrite any issues
                this.tbHP.Text = m.hp.ToString();
            }
        }
    }*/
}
