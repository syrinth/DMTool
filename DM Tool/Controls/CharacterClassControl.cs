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
    public partial class CharacterClassControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();

        public CharacterClassControl()
        {
            InitializeComponent();
        }

        public CharacterClassControl(TabPage page, string name)
        {

            InitializeComponent();
            Init();
             this.tbName.Text = name;
        }

        public CharacterClassControl(TabPage page, CharacterClass c){

            InitializeComponent();
            Init();
            if (c != null)
            {
                this.tbName.Text = c.name;
                this.cbHitDieSize.Text = c.hitDieSize.ToString();
                this.cbBAB.Text = ((PublicManager.BABType)c.baseAttackBonus).ToString();
                this.cbFort.Text = ((PublicManager.SaveType)c.fortSave).ToString();
                this.cbRef.Text = ((PublicManager.SaveType)c.refSave).ToString();
                this.cbWill.Text = ((PublicManager.SaveType)c.willSave).ToString();
                this.cbSkillPoints.Text = c.skillPoints.ToString();
            }
        }

        private void Init()
        {
            cbHitDieSize.Items.AddRange(new object[] { "4", "6", "8", "10", "12" });
            cbHitDieSize.SelectedIndex = 0;
            cbBAB.DataSource = Enum.GetValues(typeof(PublicManager.BABType));
            cbFort.DataSource = Enum.GetValues(typeof(PublicManager.SaveType));
            cbRef.DataSource = Enum.GetValues(typeof(PublicManager.SaveType));
            cbWill.DataSource = Enum.GetValues(typeof(PublicManager.SaveType));
            cbSkillPoints.Items.AddRange(new object[] { "2", "4", "6", "8", "10", "12" });
            cbSkillPoints.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty)
            {
                CharacterClass cc = mgr.listCharacterClasses.Find(x => x.name.Equals(tbName.Text));
                if (cc == null)
                {
                    mgr.listCharacterClasses.Add(new CharacterClass(tbName.Text, cbBAB.SelectedIndex, cbHitDieSize.SelectedItem.ToString(), cbFort.SelectedIndex, cbRef.SelectedIndex, cbWill.SelectedIndex, cbSkillPoints.SelectedItem.ToString()));
                }
                else
                {
                    mgr.listCharacterClasses.Remove(cc);
                    mgr.listCharacterClasses.Add(new CharacterClass(tbName.Text, cbBAB.SelectedIndex, cbHitDieSize.SelectedItem.ToString(), cbFort.SelectedIndex, cbRef.SelectedIndex, cbWill.SelectedIndex, cbSkillPoints.SelectedItem.ToString()));
                }
                mgr.listCharacterClasses.Sort((p1, p2) => string.Compare(p1.name, p2.name, true));
                PublicManager.SerializeCharacterClassesToXML(mgr.listCharacterClasses);
                mgr.NewTab("Character Class", tbName.Text);
            }
            else
            {
                MessageBox.Show("Name cannot be empty!", "Error");
            }
        }
    }
}
