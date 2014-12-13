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
                string val = string.Empty;
                int colIndex = 0;
                if (dgvXP.Columns.Count == i)
                {
                    colIndex = AddColumn(xpLedger[i][0]);
                    dgvXP.Columns[colIndex].ToolTipText = "Total Exp: 0";
                }
                for(int j = 1; j < xpLedger[i].Count-1; j++)
                {
                    val = xpLedger[i][j];
                    if (dgvXP.Rows.Count == j)
                    {
                        dgvXP.Rows.Add();
                    }
                    dgvXP.Rows[j-1].Cells[i].Value = val;
                }
            }

            dgvTotalXP.Rows[0].Cells[0].Value = "Total Exp: ";
            foreach (DataGridViewColumn c in dgvXP.Columns)
            {
                CalculateTotalXP(c.Index, c.DisplayIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<List<string>> xpLedger = new List<List<string>>();

            foreach (DataGridViewColumn col in dgvXP.Columns)
            {
                List<string> currColumn = new List<string>();
                currColumn.Add(col.HeaderText);
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

        private void addNewColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInputDialog txtDiag = new TextInputDialog("Enter Character Name");
            txtDiag.ShowDialog();

            if (txtDiag.DialogResult == DialogResult.OK)
            {
                string colName = txtDiag.GetText();
                AddColumn(colName);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            //String.Format("{0}", CalculateTotalExp());
        }

        private int AddColumn(string colName)
        {
            dgvTotalXP.Columns.Add(colName + "Total", colName + "Total");
            int colIndex = dgvXP.Columns.Add(colName, colName);
            DataGridViewColumn newCol = dgvXP.Columns[colIndex];

            for (int i = 1; i < dgvXP.ColumnCount-1; i++)
            {
                DataGridViewColumn col = dgvXP.Columns[i];

                string text1 = col.HeaderText;
                string text2 = newCol.HeaderText;
                if (text1.CompareTo(text2) > 0)
                {
                    int temp = col.DisplayIndex;
                    newCol.DisplayIndex = temp;
                    col.DisplayIndex = colIndex;

                }
            }
            return colIndex;
        }

        private void dgvXP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 1)
            {
                return;
            }

            DataGridViewCell cell = dgvXP.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value != null)
            {
                if (PublicCode.ConvertToIntSafely(cell.Value.ToString()) == 0)
                {
                    cell.Value = 0;
                }
            }

            CalculateTotalXP(cell.ColumnIndex, dgvXP.Columns[cell.ColumnIndex].DisplayIndex);
        }

        private void CalculateTotalXP(int colIndex, int displayIndex)
        {
            if (colIndex == 0)
            {
                return;
            }
            int totalXP = 0;

            foreach (DataGridViewRow r in dgvXP.Rows)
            {
                DataGridViewCell c = r.Cells[colIndex];
                if (c.Value != null)
                {
                    totalXP += PublicCode.ConvertToIntSafely(c.Value.ToString());
                }
            }

            dgvTotalXP.Rows[0].Cells[displayIndex].Value = totalXP;
        }
    }
}
