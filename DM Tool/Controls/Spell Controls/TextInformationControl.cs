using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DM_Tool.Controls.Spell_Controls
{
    public partial class TextInformationControl : UserControl, SpellPage
    {
        public TextInformationControl()
        {
            InitializeComponent();
        }

        public TextInformationControl(string info)
        {
            InitializeComponent();
            txtSorcererSpells.Text = info;
        }

        public string GetSpellInfo()
        {
            return txtSorcererSpells.Text;
        }
    }
}
