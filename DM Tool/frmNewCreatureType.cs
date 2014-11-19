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
    public partial class frmNewCreatureType : Form
    {
        public PublicManager mgr = PublicManager.GetInstance();

        public frmNewCreatureType()
        {
            InitializeComponent();
            Init();
            
        }

        public frmNewCreatureType(string name)
        {
            InitializeComponent();
            Init();

            CreatureType tc = mgr.listCreatureTypes.Find(x => x.name.Equals(name));
            tbName.Text = tc.name;
            cbHitDieSize.SelectedItem = tc.hitDieSize.ToString();
            cbBAB.SelectedIndex = tc.baseAttackBonus;
            cbFort.SelectedIndex = tc.fortSave;
            cbRef.SelectedIndex = tc.refSave;
            cbWill.SelectedIndex = tc.willSave;
            cbSkillPoints.SelectedItem = tc.skillPoints.ToString();
            tbTraits.Text = tc.traits;
        }

        private void Init()
        {
            cbHitDieSize.Items.AddRange(new object[] {"4", "6", "8", "10", "12"});
            cbHitDieSize.SelectedIndex = 0;
            cbBAB.DataSource = Enum.GetValues(typeof(PublicManager.BABType));
            cbFort.DataSource = Enum.GetValues(typeof(PublicManager.SaveType));
            cbRef.DataSource = Enum.GetValues(typeof(PublicManager.SaveType));
            cbWill.DataSource = Enum.GetValues(typeof(PublicManager.SaveType));
            cbSkillPoints.Items.AddRange(new object[] {"2", "4", "6", "8", "10", "12"});
            cbSkillPoints.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty)
            {
                CreatureType tc = mgr.listCreatureTypes.Find(x => x.name.Equals(tbName.Text));
                if (tc == null)
                {
                    mgr.listCreatureTypes.Add(new CreatureType(tbName.Text, cbBAB.SelectedIndex, cbHitDieSize.SelectedItem.ToString(), cbFort.SelectedIndex, cbRef.SelectedIndex, cbWill.SelectedIndex, cbSkillPoints.SelectedItem.ToString(), tbTraits.Text));
                }
                else
                {
                    mgr.listCreatureTypes.Remove(tc);
                    mgr.listCreatureTypes.Add(new CreatureType(tbName.Text, cbBAB.SelectedIndex, cbHitDieSize.SelectedItem.ToString(), cbFort.SelectedIndex, cbRef.SelectedIndex, cbWill.SelectedIndex, cbSkillPoints.SelectedItem.ToString(), tbTraits.Text));
                }
                mgr.listCreatureTypes.Sort((p1,p2)=>string.Compare(p1.name, p2.name, true));
                PublicManager.SerializeCreatureTypesToXML(mgr.listCreatureTypes);
                mgr.NewTab("Type", tbName.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Name cannot be empty!", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(null, "Really Delete?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                CreatureType tc = mgr.listCreatureTypes.Find(x => x.name.Equals(tbName.Text));
                if (tc != null)
                {
                    mgr.listCreatureTypes.Remove(tc);
                }
                this.Close();
            }
        }
    }
}
