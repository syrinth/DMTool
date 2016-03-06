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
    public partial class EncounterTableControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parent;
        private EncounterTable _encounterTable;
        private MainPanel _mainPanel;

        public EncounterTableControl()
        {
            InitializeComponent();
        }

        public EncounterTableControl(TabPage parentPage, MainPanel mainPanel)
        {
            InitializeComponent();

            this._parent = parentPage;
            _encounterTable = new EncounterTable();
            _mainPanel = mainPanel;
        }

        public EncounterTableControl(TabPage parentPage, EncounterTable encTable, MainPanel mainPanel)
        {
            InitializeComponent();

            _parent = parentPage;
            _mainPanel = mainPanel;
            _encounterTable = encTable;

            tbName.Text = _encounterTable.GetName();
            tbPercent.Text = _encounterTable.GetPercent();

            for(int i = 0; i < encTable.GetEncounters().Count; i++){
                dgvTable.Rows.Add(encTable.GetWeights()[i], encTable.GetEncounters()[i]);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTable.ClearSelection();
            dgvTable.AllowUserToAddRows = false;
            if (tbName.Text != string.Empty)
            {
                
                _parent.Text = tbName.Text;
                if (mgr.listCharacters.Count > 0)
                {
                    try
                    {
                        EncounterTable character = mgr.listEncounterTables.Find(x => x.GetName().Equals(tbName.Text));
                        if (character != null)
                        {
                            mgr.listEncounterTables.Remove(character);
                        }
                    }
                    catch { }
                }

                mgr.listEncounterTables.Add(new EncounterTable(tbName.Text, PublicCode.ConvertToIntSafely(tbPercent.Text.ToString()), GetWeights(), GetEncounters()));
                try
                {
                    mgr.listEncounterTables.Sort((a, b) => a.GetName().CompareTo(b.GetName()));
                }
                catch { }
                PublicManager.SerializeEncounterTablesToXML(mgr.listEncounterTables);
                mgr.DisplayEncounterTables();
            }
            else
            {
                MessageBox.Show("Name cannot be empty!", "Error");
            }
            dgvTable.AllowUserToAddRows = true;
        }

        private List<string> GetWeights()
        {
            List<string> weights = new List<string>();
            foreach (DataGridViewRow r in dgvTable.Rows)
            {
                weights.Add(r.Cells["colPercent"].Value.ToString());
            }

            return weights;
        }

        private List<string> GetEncounters()
        {
            List<string> encs = new List<string>();
            foreach (DataGridViewRow r in dgvTable.Rows)
            {
                encs.Add(r.Cells["colEncounter"].Value.ToString());
            }

            return encs;
        }

        private void bnRoll_Click(object sender, EventArgs e)
        {
            dgvTable.AllowUserToAddRows = false;
            dgvResults.Rows.Clear();
            int numOfRolls = PublicCode.ConvertToIntSafely(tbNumPeriods.Text);
            Random rnd = new Random();

            for (int i = 0; i < numOfRolls; i++)
            {
                if (rnd.Next(1, 100) <= PublicCode.ConvertToIntSafely(tbPercent.Text))
                {
                    int encounterRoll = rnd.Next(1, GetTotalWeight());

                    foreach (DataGridViewRow r in dgvTable.Rows)
                    {
                        encounterRoll -= PublicCode.ConvertToIntSafely(r.Cells["colPercent"].Value.ToString());

                        if (encounterRoll <= 0)
                        {
                            dgvResults.Rows.Add((i+1).ToString(), r.Cells["colEncounter"].Value.ToString());
                            break;
                        }
                    }
                }
            }
            dgvTable.AllowUserToAddRows = true;
        }

        private int GetTotalWeight(){
            int val = 0;
            foreach (DataGridViewRow r in dgvTable.Rows){
                val += PublicCode.ConvertToIntSafely(r.Cells["colPercent"].Value.ToString());
            }
            return val;
        }
    }
}
