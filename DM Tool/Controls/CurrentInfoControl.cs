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
    public partial class CurrentInfoControl : UserControl
    {
        private TabPage _parent;

        public CurrentInfoControl()
        {
            InitializeComponent();
        }

        public CurrentInfoControl(TabPage page)
        {
            InitializeComponent();
            _parent = page;
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
           // dtpTime.
        }
    }
}
