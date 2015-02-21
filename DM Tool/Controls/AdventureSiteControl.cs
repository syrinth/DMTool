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
    public partial class AdventureSiteControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();

        private TabPage _parent;
        private AdventureSite _adventureSite;
        private List<RoomControl> _roomCtls;
        private MainPanel _mainPanel;

        public AdventureSiteControl()
        {
            InitializeComponent();
        }

        public AdventureSiteControl(TabPage parentPage, MainPanel mainPanel)
        {
            InitializeComponent();

            this._parent = parentPage;
            _adventureSite = new AdventureSite();
            _roomCtls = new List<RoomControl>();
            _mainPanel = mainPanel;
        }

        public AdventureSiteControl(TabPage parentPage, AdventureSite advSite, MainPanel mainPanel)
        {
            InitializeComponent();

            _parent = parentPage;
            _mainPanel = mainPanel;
            _adventureSite = advSite;
            _roomCtls = new List<RoomControl>();

            tbName.Text = advSite.GetName();
            tbLocation.Text = advSite.GetLocation();
            tbDescription.Text = advSite.GetDescription();

            foreach (string r in _adventureSite.GetRoomNames())
            {
                dgvRooms.Rows.Add(r);
            }

        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            this._parent.Text = tbName.Text;
            _adventureSite.SetName(tbName.Text);
        }

        public void ReplaceRoomName(string oldName, string newName)
        {
            foreach (DataGridViewRow r in dgvRooms.Rows)
            {
                if (r.Cells["colRoom"].Value != null)
                {
                    if (r.Cells["colRoom"].Value.ToString().Equals(oldName))
                    {
                        r.Cells["colRoom"].Value = newName;
                        foreach (RoomControl rc in _roomCtls)
                        {
                            rc.SetRoomInformation(oldName, newName);
                        }
                        return;
                    }
                }
            }
        }

        public int RoomPageOpen(string roomName)
        {
            int rv = -1;
            foreach (Control tp in tabAdventureSite.Controls)
            {
                if (tp.Text == roomName)
                {
                    rv = tp.TabIndex;
                }
            }

            return rv;
        }

        public AdventureSite GetAdventureSite()
        {
            return _adventureSite;
        }

        public void AddPage(TabPage page)
        {
            this.tabAdventureSite.Controls.Add(page);
            this.tabAdventureSite.SelectedTab = page;
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
            DataGridViewCell cell = dgvRooms.Rows[e.RowIndex].Cells["colRoom"];
            if (!row.IsNewRow)
            {
                string roomName = cell.Value.ToString();
                Room advRoom = _adventureSite.FindRoom(roomName);
                if (advRoom != null)
                {
                    int roomNameIndex = RoomPageOpen(roomName);
                    if (roomNameIndex != -1)
                    {
                        this.tabAdventureSite.SelectedIndex = roomNameIndex;
                        return;
                    }

                    TabPage page = new TabPage(roomName);
                    RoomControl room = new RoomControl(page, advRoom, this);
                    _roomCtls.Add(room);
                    page.Controls.Add(room);
                    AddPage(page);
                }
            }
        }

        private void dgvRooms_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewCell cell = dgvRooms.Rows[e.RowIndex].Cells["colRoom"];
            if (cell.Value != null)
            {
                string name = cell.Value.ToString();

                if (!_adventureSite.ContainsRoom(name))
                {
                    Room newRoom = new Room(name);

                    this._adventureSite.AddRoom(newRoom);
                    foreach (RoomControl rc in _roomCtls)
                    {
                        rc.SetRoomInformation();
                    }
                }
            }
        }

        public ControlCollection GetAdventureSiteTabPages()
        {
            return this.tabAdventureSite.Controls;
        }

        public void SetSelectedTabByIndex(int x)
        {
            this.tabAdventureSite.SelectedIndex = x;
        }

        public MainPanel GetMainPanel()
        {
            return _mainPanel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty)
            {
                _parent.Text = tbName.Text;
                SaveRooms();
                AdventureSite adv = mgr.listAdvSites.Find(x => x.GetName().Equals(tbName.Text));
                if (adv != null)
                {
                    mgr.listAdvSites.Remove(adv);
                }
                mgr.listAdvSites.Add(new AdventureSite(tbName.Text, tbDescription.Text, tbLocation.Text, _adventureSite.GetRooms()));
                mgr.listAdvSites.Sort((a, b) => a.GetName().CompareTo(b.GetName()));
                PublicManager.SerializeAdventuresToXML(mgr.listAdvSites);
                mgr.DisplayAdvSites();
            }
        }

        public void SaveRooms()
        {
            foreach (RoomControl rc in _roomCtls)
            {
                rc.Save();
            }
        }
    }
}
