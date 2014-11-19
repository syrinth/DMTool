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
    public partial class TextInputDialog : Form
    {
        public TextInputDialog(string lblText)
        {
            InitializeComponent();

            lbl.Text = lblText;
        }

        public string GetText()
        {
            return tbFileName.Text;
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
