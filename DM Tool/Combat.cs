using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Controls;
using DM_Tool.Classes;

namespace DM_Tool
{
    public partial class Combat : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parentPage;
        private DataGridViewRow currentTurn;

        private MainPanel _mainPanel;

        public Combat()
        {
            InitializeComponent();
        }

        public Combat(TabPage parentPage, MainPanel mainPanel)
        {
            InitializeComponent();
            _mainPanel = mainPanel;
            _parentPage = parentPage;
            this.Init.ValueType = typeof(int);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvCombat.Rows.Clear();
            dgvEffects.Rows.Clear();
            currentTurn = null;
            ((DataGridViewComboBoxColumn)dgvEffects.Columns["Owner"]).Items.Clear();
        }

        private void dgvCombat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (dgvCombat.Columns["Init"] != null)
            {
                if (e.ColumnIndex == dgvCombat.Columns["Init"].Index)
                {
                    dgvCombat.Sort(dgvCombat.Columns["Init"], ListSortDirection.Descending);
                }
                else if (e.ColumnIndex == dgvCombat.Columns["CharacterName"].Index)
                {
                    DataGridViewRow currRow = dgvCombat.Rows[e.RowIndex];
                    DataGridViewCell cell = currRow.Cells["CharacterName"];
                    string name = cell.Value.ToString();
                    ((DataGridViewComboBoxColumn)dgvEffects.Columns["Owner"]).Items.Add(name);

                    //Search listCharacters
                    //List<Character> charactersList = mgr.listCharacters;
                    CharacterSheet sheet = mgr.listCharacters.Find(x => x.GetName().ToUpper().Equals(name.ToUpper())).GetCharacterSheet();
                    if (sheet != null)
                    {
                        currRow.Cells["AC"].Value = sheet.totalAC;
                        currRow.Cells["currHP"].Value = sheet.maxHP;
                        currRow.Cells["maxHP"].Value = sheet.maxHP;
                        currRow.Cells["fort"].Value = sheet.fortSave;
                        currRow.Cells["reflex"].Value = sheet.refSave;
                        currRow.Cells["will"].Value = sheet.willSave;
                        currRow.Cells["touchAC"].Value = sheet.touchAC;
                        currRow.Cells["flatFootAC"].Value = sheet.ffAC;
                    }
                }
                else if (e.ColumnIndex == dgvCombat.Columns["Icon"].Index)
                {
                    DataGridViewComboBoxColumn column = ((DataGridViewComboBoxColumn)dgvEffects.Columns["Owner"]);
                    for (int i = 0; i < column.Items.Count; i++)
                    {
                        DataGridViewRow currRow = dgvCombat.Rows[e.RowIndex];
                        DataGridViewCell cell = currRow.Cells["CharacterName"];
                        if (cell.Value != null && cell.Value.ToString() != string.Empty)
                        {
                            string name = cell.Value.ToString();

                            string val = column.Items[i].ToString();
                            if (val.Equals(name))
                            {
                                column.Items[i] += "-" + currRow.Cells["Icon"].Value.ToString();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Really close combat?", "Leave Combat?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                _parentPage.Dispose();
            }
        }

        private void Combat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Next();
            }
        }

        private void Next()
        {
            if (dgvCombat.Rows.Count > 0)
            {
                if (currentTurn == null)
                {
                    currentTurn = dgvCombat.Rows[0];
                }
                else
                {
                    int currRow = currentTurn.Index + 1;
                    if (currRow >= dgvCombat.Rows.Count || dgvCombat.Rows[currRow].Cells["CharacterName"].Value == null)
                    {
                        currRow = 0;
                    }

                    currentTurn.DefaultCellStyle.BackColor = Color.White;
                    currentTurn = dgvCombat.Rows[currRow];
                }

                currentTurn.DefaultCellStyle.BackColor = Color.Red;

                foreach (DataGridViewRow r in dgvEffects.Rows)
                {
                    if (r.Cells["EffectsName"].Value != null)
                    {
                        string matchName = currentTurn.Cells["CharacterName"].Value.ToString();

                        if(currentTurn.Cells["Icon"].Value.ToString() != string.Empty){
                            matchName += "-" + currentTurn.Cells["Icon"].Value.ToString();
                        }

                        if (r.Cells["Owner"].Value.ToString() == matchName)
                        {
                            int currDuration = Convert.ToInt32(r.Cells["Duration"].Value);
                            currDuration -= 1;
                            if (currDuration <= 0)
                            {
                                dgvEffects.Rows.Remove(r);
                            }
                            else
                            {
                                r.Cells["Duration"].Value = currDuration;
                            }
                        }
                    }
                }
            }
            this.dgvCombat.FirstDisplayedScrollingRowIndex = currentTurn.Index;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentTurn == null && dgvCombat.Rows.Count > 0)
            {
                currentTurn = dgvCombat.Rows[0];
                currentTurn.DefaultCellStyle.BackColor = Color.Red;
                btnNext.Text = "Next Turn";
                this.dgvCombat.FirstDisplayedScrollingRowIndex = currentTurn.Index;
            }
            else
            {
                Next();
            }
        }


        private void btnDeleteEffect_Click(object sender, EventArgs e)
        {
            if (dgvEffects.SelectedRows.Count > 0)
            {
                dgvEffects.Rows.Remove(dgvEffects.SelectedRows[0]);
            }
        }

        private void btnNewEffect_Click(object sender, EventArgs e)
        {

            if (btnNewEffect.Text == "Add Effects")
            {
                btnNewEffect.Text = "Finished";
                dgvEffects.AllowUserToAddRows = true;
                dgvEffects.CurrentCell = dgvEffects.Rows[dgvEffects.Rows.Count - 1].Cells["EffectsName"];
                dgvEffects.BeginEdit(true);
            }
            else if (btnNewEffect.Text == "Finished")
            {
                btnNewEffect.Text = "Add Effects";
                dgvEffects.AllowUserToAddRows = false;
            }
        }


        private void btnAddCharacters_Click(object sender, EventArgs e)
        {
            if (btnAddCharacters.Text == "Add Characters")
            {
                btnAddCharacters.Text = "Finished";
                dgvCombat.AllowUserToAddRows = true;
                dgvCombat.CurrentCell = dgvCombat.Rows[dgvCombat.Rows.Count - 1].Cells["CharacterName"];
                dgvCombat.BeginEdit(true);
            }
            else if (btnAddCharacters.Text == "Finished")
            {
                btnAddCharacters.Text = "Add Characters";
                dgvCombat.AllowUserToAddRows = false;
            }
        }

        private void ctxtMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (!dgvCombat.SelectedRows[0].IsNewRow)
            {
                if (currentTurn.Index == dgvCombat.SelectedRows[0].Index)
                {
                    Next();

                }
                dgvCombat.Rows.Remove(dgvCombat.SelectedRows[0]);
            }
        }

        private void dgvCombat_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo Hti;
            if (e.Button == MouseButtons.Right)
            {
                Hti = dgvCombat.HitTest(e.X, e.Y);
                if (Hti.Type == DataGridViewHitTestType.Cell)
                {
                    if (!((DataGridViewRow)(dgvCombat.Rows[Hti.RowIndex])).Selected)
                    {
                        dgvCombat.ClearSelection();
                        ((DataGridViewRow)dgvCombat.Rows[Hti.RowIndex]).Selected = true;
                    }
                    ctxtCombat.Show(MousePosition);
                }
            }
        }

        private void dgvCombat_Leave(object sender, EventArgs e)
        {
            dgvCombat.ClearSelection();
        }

        private void dgvEffects_Leave(object sender, EventArgs e)
        {
            dgvEffects.ClearSelection();
        }

        private void openCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgvCombat.SelectedRows[0].Cells["CharacterName"];
            if (cell == null || cell.Value == null)
            {
                return;
            }

            string charName = cell.Value.ToString();
            Character character = mgr.listCharacters.Find(x => x.GetName().ToUpper().Equals(charName.ToUpper()));

            if (character != null)
            {

                if (_mainPanel.PageOpen(charName))
                {
                    return;
                }

                TabPage page = new TabPage(charName);
                CharacterControl mc = new CharacterControl(page, character);
                page.Controls.Add(mc);
                mc.Dock = DockStyle.Fill;

                _mainPanel.AddOrSelectPage(page);
            }
            else
            {
                TabPage page = new TabPage(charName);
                CharacterControl mc = new CharacterControl(page, charName);
                page.Controls.Add(mc);
                mc.Dock = DockStyle.Fill;

                _mainPanel.AddOrSelectPage(page);
            }
        }
    }
}
