using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DM_Tool
{
    public partial class frmMonsterMaker : Form
    {
        public PublicManager mgr = PublicManager.GetInstance();

        private CreatureType tc;
        public frmMonsterMaker()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            tc = new CreatureType();
            LoadTypes();
            cbType.SelectedIndex = 0;
        }

        private void LoadTypes()
        {
            cbType.Items.Clear();
            foreach (CreatureType type in mgr.creatureTypes)
            {
                cbType.Items.Add(type.name);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tc = mgr.creatureTypes.Find(x => x.name.Equals(cbType.SelectedItem.ToString()));
            tbHDSize.Text = tc.hitDieSize.ToString();

            UpdateSheet();
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            frmNewCreatureType frm = new frmNewCreatureType();
            frm.ShowDialog();

            LoadTypes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty)
            {
                CreatureType tc = mgr.creatureTypes.Find(x => x.name.Equals(tbName.Text));
                if (tc == null)
                {
                    mgr.monsters.Add(new Monster(tbName.Text, Convert.ToInt32(tbHDNum.Text), Convert.ToInt32(tbHDSize.Text), Convert.ToInt32(tbHP.Text), Convert.ToInt32(tbBAB.Text), Convert.ToInt32(tbFort.Text), Convert.ToInt32(tbRef.Text), Convert.ToInt32(tbWill.Text)));
                }
                else
                {
                    mgr.creatureTypes.Remove(tc);
                    mgr.monsters.Add(new Monster(tbName.Text, Convert.ToInt32(tbHDNum.Text), Convert.ToInt32(tbHDSize.Text), Convert.ToInt32(tbHP.Text), Convert.ToInt32(tbBAB.Text), Convert.ToInt32(tbFort.Text), Convert.ToInt32(tbRef.Text), Convert.ToInt32(tbWill.Text)));
                }
                mgr.SaveMonsters();
                //mgr.NewTab(tbName.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Name cannot be empty!", "Error");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(tbHDNum.Text, out result))
            {
                MessageBox.Show("Must be int!");
            }
            else
            {

            }
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
                    //Calculate the BAB
                    CalculateBAB();

                    //Calculate Saving Throws
                    CalculateSaves();

                    CalculateBaseHP();
                }
            }
        }

        public void CalculateBaseHP()
        {
            int HDNum = Convert.ToInt32(tbHDNum.Text);
            int HDSize = Convert.ToInt32(tbHDSize.Text);
            int hp = HDSize + ((HDNum -1) * (HDSize/2)) + (GetModifier(tbCon.Text) * HDNum);

            tbHP.Text = hp.ToString();
        }

        public void CalculateBAB()
        {

            if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.POOR)
            {
                tbBAB.Text = (Convert.ToInt32(tbHDNum.Text) / 2).ToString();
            }
            else if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.AVERAGE)
            {
                tbBAB.Text = (Convert.ToInt32(tbHDNum.Text) * .75).ToString();
            }
            else if ((PublicManager.BABType)tc.baseAttackBonus == PublicManager.BABType.GOOD)
            {
                tbBAB.Text = Convert.ToInt32(tbHDNum.Text).ToString();
            }
        }

        public void CalculateSaves()
        {
            CalculateFortSave();
            CalculateRefSave();
            CalculateWillSave();
        }

        public int GetModifier(string number)
        {
            if (number != string.Empty)
            {
                int num = Convert.ToInt32(number);
                int mod = Math.Max(0, (num - 10) / 2);
                return mod;
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
            fort += GetModifier(tbCon.Text);
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

        private void tbDex_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void tbCon_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void tbWis_TextChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }
    }
}
