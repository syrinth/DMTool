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
    public partial class XPLedgerControl : UserControl
    {
        PublicManager mgr = PublicManager.GetInstance();
        TabPage _parentPage;

        public XPLedgerControl()
        {
            InitializeComponent();
        }

        public XPLedgerControl(TabPage page, List<List<string>> xpLedger)
        {
            InitializeComponent();
            _parentPage = page;

            for(int i=0; i<xpLedger.Count; i++)
            {
                for(int j = 0; j<xpLedger[i].Count; j++)
                {
                    string val = xpLedger[i][j];
                    if (dgvXP.Rows[j].IsNewRow)
                    {
                        dgvXP.Rows.Add();
                    }
                    dgvXP.Rows[j].Cells[i].Value = val;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<List<string>> xpLedger = new List<List<string>>();

            foreach (DataGridViewColumn col in dgvXP.Columns)
            {
                List<string> currColumn = new List<string>();
                foreach (DataGridViewRow row in dgvXP.Rows)
                {
                    DataGridViewCell cell = row.Cells[col.Index];
                    if (cell.Value != null)
                    {
                        string val = row.Cells[col.Index].Value.ToString();
                        currColumn.Add((val != null) ? val : "");
                    }
                    else
                    {
                        currColumn.Add("");
                    }
                }
                xpLedger.Add(currColumn);
            }
            PublicManager.SerializeXPLedgerToXML(xpLedger);
        }
    }
}
