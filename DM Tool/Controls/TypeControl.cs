using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DM_Tool
{
    public partial class TypeControl : UserControl
    {
        private TabPage _parent;
        public TypeControl(CreatureType type)
        {
            InitializeComponent();

            _parent = null;
            this.tbName.Text = type.name;
            this.tbHD.Text = String.Format("d{0}", type.hitDieSize);
            this.tbBAB.Text = ((PublicManager.BABType)type.baseAttackBonus).ToString();
            this.tbFort.Text = ((PublicManager.SaveType)type.fortSave).ToString();
            this.tbRef.Text = ((PublicManager.SaveType)type.refSave).ToString();
            this.tbWill.Text = ((PublicManager.SaveType)type.willSave).ToString();
            this.tbSkills.Text = String.Format("{0} + Int per level", type.skillPoints);
            this.tbTraits.Text = type.traits;
        }

        public TypeControl(TabPage parentPage)
        {
            InitializeComponent();

            _parent = parentPage;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmNewCreatureType frm = new frmNewCreatureType(this.tbName.Text);
            frm.ShowDialog();
            this.Parent.Dispose();
        }
    }
}
