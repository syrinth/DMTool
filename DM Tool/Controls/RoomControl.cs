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
    public partial class RoomControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private Room _room;
        private TabPage _parent;
        private AdventureSiteControl _advSiteCtl;
        private AdventureSite _advSite;

        public RoomControl()
        {
            InitializeComponent();
        }

        public RoomControl(TabPage parent, Room room, AdventureSiteControl adventureSiteControl)
        {
            InitializeComponent();
            this._room = room;

            this._parent = parent;
            this._advSiteCtl = adventureSiteControl;
            this._advSite = adventureSiteControl.GetAdventureSite();
            this.tbDescription.Text = room._description;
            this.tbSkills.Text = room._relevantChecks;

            _parent.Text = room._name;
            tbName.Text = _room._name;
            string[] split;
            try
            {
                split = room._encounters.Split('|');
                foreach (string s in split)
                {
                    dgvEncounters.Rows.Add(s);
                }
            }
            catch { }

            try{
                split = room._traps.Split('|');
                foreach (string s in split)
                {
                    dgvTraps.Rows.Add(s);
                }
            }
            catch { }

            try{
                split = room._loot.Split('|');
                foreach (string s in split)
                {
                    dgvLoot.Rows.Add(s);
                }
            }
            catch { }

            ((DataGridViewComboBoxColumn)dgvRooms.Columns["colRoom"]).DataSource = _advSite.GetRoomNames();
            try{
                split = room._rooms.Split('|');
                foreach (string s in split)
                {
                    dgvRooms.Rows.Add(s);
                }
            }
            catch { }

            
        }

        public RoomControl(TabPage parent, AdventureSiteControl adventureSiteControl)
        {
            InitializeComponent();
            _room = new Room();
            this._parent = parent;
            this._advSiteCtl = adventureSiteControl;

            tbName.Text = _parent.Text;
            _room._name = _parent.Text;

        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            string oldName = _room._name;

            if (_advSiteCtl.RoomPageOpen(tbName.Text) != -1)
            {
                tbName.Text = oldName;
            }
            else
            {
                _parent.Text = tbName.Text;
                _room._name = tbName.Text;

                _advSiteCtl.ReplaceRoomName(oldName, _room._name);
            }
        }

        private void btnCloseRoom_Click(object sender, EventArgs e)
        {
            this._parent.Dispose();
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
            DataGridViewCell cell = dgvRooms.Rows[e.RowIndex].Cells["colRoom"];
            if (cell.Value != null)
            {
                string roomName = cell.Value.ToString();
                Room advRoom = _advSite.FindRoom(roomName);
                if (advRoom != null)
                {
                    int roomNameIndex = _advSiteCtl.RoomPageOpen(roomName);
                    if (roomNameIndex != -1)
                    {
                        this._advSiteCtl.SetSelectedTabByIndex(roomNameIndex);
                        return;
                    }

                    TabPage page = new TabPage(roomName);
                    RoomControl room = new RoomControl(page, advRoom, _advSiteCtl);
                    page.Controls.Add(room);
                    _advSiteCtl.AddPage(page);
                }
            }
        }

        public void SetRoomInformation(string oldName, string newName)
        {
            SetRoomInformation();
            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                if (row.Cells["colRoom"].Value != null)
                {
                    if (row.Cells["colRoom"].Value.ToString().Equals(oldName))
                    {
                        row.Cells["colRoom"].Value = newName;
                    }
                }
            }
        }

        public void SetRoomInformation()
        {
            ((DataGridViewComboBoxColumn)dgvRooms.Columns["colRoom"]).DataSource = _advSite.GetRoomNames();
        }

        private void dgvRooms_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvRooms.CurrentCell = dgvRooms.Rows[dgvRooms.Rows.Count - 1].Cells["colRoom"];
        }


        public void Save()
        {
            _room._name = tbName.Text;
            _room._description = tbDescription.Text;
            _room._relevantChecks = tbSkills.Text;

            string temp = string.Empty;
            foreach (DataGridViewRow row in dgvEncounters.Rows)
            {
                try
                {
                    temp += row.Cells["colMonster"].Value.ToString() + "|";
                }
                catch { }
            }
            _room._encounters = temp.Trim('|');

            temp = string.Empty;
            foreach (DataGridViewRow row in dgvTraps.Rows)
            {
                try
                {
                    temp += row.Cells["colTrap"].Value.ToString() + "|";
                }
                catch { }
            }
            _room._traps = temp.Trim('|');

            temp = string.Empty;
            foreach (DataGridViewRow row in dgvLoot.Rows)
            {
                try
                {
                    temp += row.Cells["colLoot"].Value.ToString() + "|";
                }
                catch { }
            }
            _room._loot = temp.Trim('|');

            temp = string.Empty;
            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                try
                {
                    temp += row.Cells["colRoom"].Value.ToString() + "|";
                }
                catch { }
            }
            _room._rooms = temp.Trim('|');
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataGridViewCell cell = dgvEncounters.SelectedRows[0].Cells["colMonster"];
            if (cell.Value != null && cell.Value != string.Empty)
            {
                string charName = cell.Value.ToString();
                CharacterSheet sheet = mgr.listCharacterSheets.Find(x => x.name.ToUpper().Equals(charName.ToUpper()));
                if (sheet != null)
                {
                    if (_advSiteCtl.GetMainPanel().PageOpen(charName))
                    {
                        return;
                    }

                    TabPage page = new TabPage(charName);
                    MonsterControl mc = new MonsterControl(page, sheet);
                    page.Controls.Add(mc);
                    mc.Dock = DockStyle.Fill;

                    _advSiteCtl.GetMainPanel().AddOrSelectPage(page);
                }
                else
                {
                    TabPage page = new TabPage(charName);
                    MonsterControl mc = new MonsterControl(page, charName);
                    page.Controls.Add(mc);
                    mc.Dock = DockStyle.Fill;

                    _advSiteCtl.GetMainPanel().AddOrSelectPage(page);
                }
            }
        }

        private void dgvEncounters_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo Hti;
            if (e.Button == MouseButtons.Right)
            {
                Hti = dgvEncounters.HitTest(e.X, e.Y);
                if (Hti.Type == DataGridViewHitTestType.Cell)
                {
                    if (!((DataGridViewRow)(dgvEncounters.Rows[Hti.RowIndex])).Selected)
                    {
                        dgvEncounters.ClearSelection();
                        ((DataGridViewRow)dgvEncounters.Rows[Hti.RowIndex]).Selected = true;
                    }
                    ctxtMenu.Show(MousePosition);
                }
            }
        }
    }
}
