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
    public partial class CurrentInfoControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parent;
        public Calendar _calendar;

        private MainPanel _mainPanel;

        public CurrentInfoControl()
        {
            InitializeComponent();
        }

        public CurrentInfoControl(TabPage page, MainPanel mainPanel, List<List<string>> xpLedger)
        {
            InitializeComponent();
            _parent = page;
            _mainPanel = mainPanel;
            _calendar = mgr.GetCalendar();

            tbCurrentDate.Text = _calendar.GetCurrentDayOfWeek() + ", " + _calendar.GetCurrentMonth() + " " + _calendar.GetCurrentDay() + ", " + _calendar.GetCurrentYear() + " " + _calendar.GetYearName();
            dtpTime.Text = _calendar.GetTime();

            for (int i = 0; i < xpLedger.Count; i++)
            {
                string val = string.Empty;
                int colIndex = 0;
                if (dgvXP.Columns.Count == i)
                {
                    colIndex = AddColumn(xpLedger[i][0]);
                    dgvXP.Columns[colIndex].ToolTipText = "Total Exp: 0";
                }
                for (int j = 1; j < xpLedger[i].Count - 1; j++)
                {
                    val = xpLedger[i][j];
                    if (dgvXP.Rows.Count == j)
                    {
                        dgvXP.Rows.Add();
                    }
                    dgvXP.Rows[j - 1].Cells[i].Value = val;
                }
            }

            dgvTotalXP.Rows[0].Cells[0].Value = "Total Exp: ";
            foreach (DataGridViewColumn c in dgvXP.Columns)
            {
                CalculateTotalXP(c.Index, c.DisplayIndex);
            }
        }

        #region Date/Time
        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
           // dtpTime.
        }

        private string[] ParseDate()
        {
            return tbCurrentDate.Text.Split(new Char[] { ',', ' ' });
        }

        private void tbCurrentDate_Leave(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            int maxDays = _calendar.GetMonthDays(date[2]);
            int curr = PublicCode.ConvertToIntSafely(date[3]);

            if (curr > 0 && curr <= maxDays)
            {
                _calendar.SetCurrentDay(curr);
            }
            else
            {
                if (curr <= 0)
                {
                    date[3] = "1";
                    _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[3]));
                }
                else if (curr > maxDays)
                {
                    date[3] = maxDays.ToString();
                    _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[3]));
                }

                tbCurrentDate.Text = _calendar.GetCurrentDayOfWeek() + ", " + date[2] + " " + _calendar.GetCurrentDay() + ", " + date[5] + " " + _calendar.GetYearName();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            int maxDays = _calendar.GetMonthDays(date[2]);
            int currDay = PublicCode.ConvertToIntSafely(date[3]) + 1;

            if (currDay > 0 && currDay <= maxDays)
            {
                _calendar.SetCurrentDay(currDay);
            }
            else
            {
                if (currDay <= 0)
                {
                    date[3] = "1";
                    _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[3]));
                }
                else if (currDay > maxDays)
                {
                    //increment the month
                    _calendar.GoToNextMonth();
                    date[2] = _calendar.GetCurrentMonth();
                    date[5] = _calendar.GetCurrentYear().ToString();
                    _calendar.SetCurrentDay(1);
                }
            }

            _calendar.GoToNextDayOfWeek();

            dtpTime.Text = "08:00 AM";
            tbCurrentDate.Text = _calendar.GetCurrentDayOfWeek() + ", " + date[2] + " " + _calendar.GetCurrentDay() + ", " + date[5] + " " + _calendar.GetYearName();
        }
        #endregion

        #region XP Ledger
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

        private int AddColumn(string colName)
        {
            dgvTotalXP.Columns.Add(colName + "Total", colName + "Total");
            int colIndex = dgvXP.Columns.Add(colName, colName);
            DataGridViewColumn newCol = dgvXP.Columns[colIndex];

            for (int i = 1; i < dgvXP.ColumnCount - 1; i++)
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

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInputDialog txtDiag = new TextInputDialog("Delete which character?");
            txtDiag.ShowDialog();

            if (txtDiag.DialogResult == DialogResult.OK)
            {
                string colName = txtDiag.GetText();
                dgvXP.Columns.Remove(colName);
                dgvTotalXP.Columns.Remove(colName+"Total");
                btnSave_Click(sender, e);
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Date and Time
            string[] date = ParseDate();
            _calendar.SetCurrentMonth(date[0]);
            _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[1]));
            _calendar.SetCurrentYear(PublicCode.ConvertToIntSafely(date[3]));

            _calendar.SetTime(dtpTime.Text);

            PublicManager.SerializeCalendarToXML();

            //Save XP Ledger
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

        private void editCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentInfo = "Calendar";
            TabPage page = new TabPage(currentInfo);
            CalendarControl mc = new CalendarControl(page);
            page.Controls.Add(mc);
            mc.Dock = DockStyle.Fill;
            _mainPanel.AddOrSelectPage(page);
        }
    }
}
