using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DM_Tool.Controls
{
    public partial class CharacterControl : UserControl
    {
        public CharacterControl()
        {
            InitializeComponent();
            List<string> skills = new List<string>(){"Appraise", "Balance", "Bluff", "Climb", "Concentration", "Craft",
                                   "Decipher Script", "Diplomacy", "Disable Device", "Disguise", "Escape Artist",
                                   "Forgery", "Gather Information", "Handle Animal", "Heal", "Hide", "Intimidate",
                                   "Jump", "Knowledge", "Listen", "Move Silently", "Open Lock", "Perform", "Profession",
                                   "Ride", "Search", "Sense Motive", "Sleight Of Hand", "Speak Language", "Spellcraft",
                                   "Spot", "Survival", "Swim", "Tumble", "Use Magic Device", "Use Rope"};


            foreach(string s in skills)
            {
                dgvSkills.Rows.Add(false, s, "", "", "", "");
            }
        }

        private void tbRaceName_Leave(object sender, EventArgs e)
        {

        }

        private void tbInitMisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInitDex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDefAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbShieldAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArmorAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNatAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDexAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSizeAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbWis_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHDNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
