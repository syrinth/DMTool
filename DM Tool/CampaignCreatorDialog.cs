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
    public partial class CampaignCreatorDialog : Form
    {
        public CampaignCreatorDialog()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
        }

        public string GetName()
        {
            return tbFileName.Text;
        }

        public string GetCampaignType()
        {
            return cbType.SelectedItem.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
