using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Classes;
using DM_Tool.Controls;
using System.IO;
namespace DM_Tool
{
    public partial class MainPanel : Form
    {
        private enum ListDisplay { ALL, TYPES, CHARACTERS, CHARCLASSES, BASEITEMS, ADVSITES, ENCTABLES};
        private List<string> baseMenu;

        public PublicManager mgr = PublicManager.GetInstance();

        private ListDisplay display;
        public MainPanel()
        {
            InitializeComponent();

            display = ListDisplay.ALL;
            mgr.SetMain(this);
            SetMenuToBase();
            FindCampaigns();
            this.Text = mgr.GetCampaignName();
        }

        private void saveCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tabOpenObjects.TabPages)
            {
                page.Controls.ToString();
            }
            mgr.Save();
        }

        private void createACharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newCharacter = "New Character";
            TabPage page = new TabPage(newCharacter);
            StatBlockControl mc = new StatBlockControl(page);
            page.Controls.Add(mc);
            mc.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            display = ListDisplay.TYPES;
            foreach(CreatureType type in mgr.listCreatureTypes){
                dgView.Rows.Add(type.name);
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgView.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (name == "--Main Menu")
            {
                SetMenuToBase();
            }

            if (display == ListDisplay.ALL)
            {
                if (name == "Types")
                {
                    dgView.Rows.Clear();
                    display = ListDisplay.TYPES;
                    dgView.Rows.Add("--Main Menu");
                    foreach (CreatureType type in mgr.listCreatureTypes)
                    {
                        dgView.Rows.Add(type.name);
                    }
                }
                if (name == "Stat Blocks")
                {
                    DisplayCharacters();
                }
                if (name == "Character Classes")
                {
                    DisplayCharacterClasses();
                }
                if (name == "Base Items")
                {
                    DisplayBaseItems();
                }
                if (name == "Adventure Sites")
                {
                    DisplayAdventureSites();
                }
                if (name == "Encounter Tables")
                {
                    DisplayEncounterTables();
                }
            }
            else if (display == ListDisplay.TYPES)
            {
                foreach(TabPage page in tabOpenObjects.TabPages)
                {
                    if (page.Text == name)
                    {
                        tabOpenObjects.SelectedTab = page;
                        return;
                    }
                }
                mgr.NewTab("Type", name);
            }
            else if (display == ListDisplay.CHARACTERS)
            {
                foreach (TabPage page in tabOpenObjects.TabPages)
                {
                    if (page.Text == name)
                    {
                        tabOpenObjects.SelectedTab = page;
                        return;
                    }
                }
                mgr.NewTab("Character", name);
            }
            else if (display == ListDisplay.CHARCLASSES)
            {
                foreach (TabPage page in tabOpenObjects.TabPages)
                {
                    if (page.Text == name)
                    {
                        tabOpenObjects.SelectedTab = page;
                        return;
                    }
                }
                mgr.NewTab("Character Class", name);
            }
            else if (display == ListDisplay.BASEITEMS)
            {
                foreach (TabPage page in tabOpenObjects.TabPages)
                {
                    if (page.Text == name)
                    {
                        tabOpenObjects.SelectedTab = page;
                        return;
                    }
                }
                mgr.NewTab("BaseItem", name);
            }
            else if (display == ListDisplay.ADVSITES)
            {
                foreach (TabPage page in tabOpenObjects.TabPages)
                {
                    if (page.Text == name)
                    {
                        tabOpenObjects.SelectedTab = page;
                        return;
                    }
                }
                mgr.NewTab("AdventureSite", name);
            }
            else if (display == ListDisplay.ENCTABLES)
            {
                foreach (TabPage page in tabOpenObjects.TabPages)
                {
                    if (page.Text == name)
                    {
                        tabOpenObjects.SelectedTab = page;
                        return;
                    }
                }
                mgr.NewTab("EncounterTable", name);
            }
        }

        public void AddOrSelectPage(TabPage page)
        {
            bool found = false;
            foreach (TabPage p in tabOpenObjects.TabPages)
            {
                if (p.Text == page.Text)
                {
                    page = p;
                    found = true;
                }
            }
            if (!found)
            {
                tabOpenObjects.Controls.Add(page);
            }
            tabOpenObjects.SelectedTab = page;
            tabOpenObjects.Focus();
        }

        /// <summary>
        /// Sets the menu to the base, default state of showing all object headers
        /// </summary>
        public void SetMenuToBase()
        {
            baseMenu = mgr.GetBaseMenuEntries();
            display = ListDisplay.ALL;
            dgView.Rows.Clear();
            foreach (string s in baseMenu)
            {
                dgView.Rows.Add(s);
            }
        }

        public void DisplayCharacters()
        {
            dgView.Rows.Clear();
            mgr.listCombinedCharacters.Clear();
            mgr.listCombinedCharacters.AddRange(mgr.listCharacters);
            mgr.listCombinedCharacters.AddRange(mgr.listCampaignCharacters);
            mgr.listCombinedCharacters.Sort((p1, p2) => string.Compare(p1.GetName(), p2.GetName(), true));
            display = ListDisplay.CHARACTERS;
            dgView.Rows.Add("--Main Menu");
            foreach (Character c in mgr.listCombinedCharacters)
            {
                dgView.Rows.Add(c.GetName());
            }
        }

        public void DisplayCharacterClasses()
        {
            dgView.Rows.Clear();

            display = ListDisplay.CHARCLASSES;
            dgView.Rows.Add("--Main Menu");
            foreach (CharacterClass cc in mgr.listCharacterClasses)
            {
                dgView.Rows.Add(cc.name);
            }
        }

        public void DisplayBaseItems()
        {
            dgView.Rows.Clear();
            display = ListDisplay.BASEITEMS;
            dgView.Rows.Add("--Main Menu");
            foreach (BaseItem m in mgr.listBaseItems)
            {
                dgView.Rows.Add(m.name);
            }
        }

        public void DisplayAdventureSites()
        {
            dgView.Rows.Clear();
            display = ListDisplay.ADVSITES;
            dgView.Rows.Add("--Main Menu");
            foreach (AdventureSite m in mgr.listAdvSites)
            {
                dgView.Rows.Add(m.GetName());
            }
        }

        public void DisplayEncounterTables()
        {
            dgView.Rows.Clear();
            display = ListDisplay.ENCTABLES;
            dgView.Rows.Add("--Main Menu");
            foreach (EncounterTable e in mgr.listEncounterTables)
            {
                dgView.Rows.Add(e.GetName());
            }
        }

        private void newBaseItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newArtObject = "New Base Item";
            TabPage page = new TabPage(newArtObject);
            BaseItemControl i = new BaseItemControl(page, true);
            page.Controls.Add(i);
            i.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void qualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newArtObject = "Table: Quality";
            TabPage page = new TabPage(newArtObject);
            QualityControl i = new QualityControl(page, false);
            page.Controls.Add(i);
            i.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void baseItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newBaseItem = "Table: Base Items";
            TabPage page = new TabPage(newBaseItem);
            BaseItemControl i = new BaseItemControl(page, false);
            page.Controls.Add(i);
            i.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void hardMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n = "Table: Hard Materials";
            TabPage page = new TabPage(n);
            HardMaterialControl i = new HardMaterialControl(page, false);
            page.Controls.Add(i);
            i.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void newCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CampaignCreatorDialog txtBox = new CampaignCreatorDialog();
            txtBox.ShowDialog();

            if (txtBox.DialogResult == DialogResult.OK)
            {
                string name = txtBox.GetName();
                Directory.CreateDirectory("./" + "//Files//" + name);
                mgr.SetCampaignName(name);
                mgr.SetCampaignType(txtBox.GetCampaignType());
            }

            mgr.WriteCampaignConfigFile();
            FindCampaigns();

            mgr.WriteConfigFile();
            this.Text = mgr.GetCampaignName();
            mgr.LoadCampaign();
        }

        private void battleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string combat = "Combat";
            TabPage page = new TabPage(combat);
            Combat aoc = new Combat(page, this);
            page.Controls.Add(aoc);
            aoc.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void newAdventureSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("New Adventure Site");
            AdventureSiteControl aoc = new AdventureSiteControl(page, this);
            page.Controls.Add(aoc);
            aoc.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        public bool PageOpen(string pageName)
        {
            foreach (Control tp in tabOpenObjects.Controls)
            {
                if (tp.Text == pageName)
                {
                    return true;
                }
            }

            return false;
        }

        private void tabOpenObjects_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (tabOpenObjects.SelectedTab != null)
                {
                    tabOpenObjects.SelectedTab.Dispose();
                }
            }

            if (Form.ModifierKeys == Keys.Control)
            {
                if (e.KeyChar == (char)Keys.S)
                {
                    if (tabOpenObjects.SelectedTab != null)
                    {
                        MessageBox.Show("1");
                    }
                }
            }
        }

        private void closeThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabOpenObjects.SelectedTab.Dispose();
        }

        private void closeAllOpenTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabOpenObjects.TabPages.Clear();
        }

        private void tabOpenObjects_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < tabOpenObjects.TabCount; i++)
                {
                    Rectangle r = tabOpenObjects.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        tabOpenObjects.SelectedIndex = i;
                        ctxtTabsMenu.Show(MousePosition);
                    }
                }
            }
        }

        private void closeAllToTheRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int current = tabOpenObjects.SelectedIndex;

            List<TabPage> pagesToClose = new List<TabPage>();
            for (int i = ++current; i < tabOpenObjects.TabCount; i++)
            {
                pagesToClose.Add(tabOpenObjects.TabPages[i]);
            }

            foreach (TabPage t in pagesToClose)
            {
                t.Dispose();
            }
        }

        private void derpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("New Character");
            StatBlockControl aoc = new StatBlockControl();
            page.Controls.Add(aoc);
            aoc.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void FindCampaigns()
        {
            string filePath = Environment.CurrentDirectory + "\\Files";

            List<string> dirs = new List<string>(Directory.EnumerateDirectories(filePath));
            foreach (string s in dirs)
            {
                if(File.Exists(s+"\\config.txt")){
                    string campaignName = Path.GetFileNameWithoutExtension(s);

                    if (!loadCampaignToolStripMenuItem.DropDownItems.ContainsKey(campaignName))
                    {
                        ToolStripMenuItem newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        newMenuItem.Name = campaignName;
                        newMenuItem.Size = new System.Drawing.Size(164, 22);
                        newMenuItem.Text = campaignName;
                        newMenuItem.Click += new System.EventHandler(loadCampaign);

                        loadCampaignToolStripMenuItem.DropDownItems.Add(newMenuItem);
                    }
                }
            }
        }

        /// <summary>
        /// Loads the selected campaign information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadCampaign(object sender, EventArgs e)
        {
            mgr.SetCampaignName(sender.ToString());
            mgr.CheckCampaignConfigFile();
            mgr.WriteConfigFile();
            this.Text = mgr.GetCampaignName();
            SetMenuToBase();
            tabOpenObjects.TabPages.Clear();

            mgr.LoadCampaign();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentInfo = "Current Info";
            TabPage page = new TabPage(currentInfo);
            CurrentInfoControl mc = new CurrentInfoControl(page, this, PublicManager.DeserializeXPLedgerFromXML());
            page.Controls.Add(mc);
            mc.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void dgView_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo Hti;
            if (e.Button == MouseButtons.Right)
            {
                Hti = dgView .HitTest(e.X, e.Y);
                if (Hti.Type == DataGridViewHitTestType.Cell)
                {
                    if (!((DataGridViewRow)(dgView.Rows[Hti.RowIndex])).Selected)
                    {
                        dgView.ClearSelection();
                        ((DataGridViewRow)dgView.Rows[Hti.RowIndex]).Selected = true;
                    }
                    ctxtMenuItem.Show(MousePosition);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dgView.SelectedRows[0].Cells[0].Value.ToString();

            if (display == ListDisplay.TYPES)
            {
                DialogResult res = MessageBox.Show(null, "Really delete " + name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    mgr.listCreatureTypes.Remove(mgr.listCreatureTypes.Find(x => x.name.Equals(name)));
                }
            }
            else if (display == ListDisplay.CHARACTERS)
            {
                DialogResult res = MessageBox.Show(null, "Really delete " + name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Character c = mgr.listCombinedCharacters.Find(x => x.GetName().Equals(name));
                    mgr.listCombinedCharacters.Remove(c);
                    if (c._campaignSpecific)
                    {
                        mgr.listCampaignCharacters.Remove(c);
                    }
                    else
                    {
                        mgr.listCharacters.Remove(c);
                    }
                    mgr.DisplayCharacters();
                }
            }
            else if (display == ListDisplay.CHARCLASSES)
            {
                DialogResult res = MessageBox.Show(null, "Really delete " + name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    mgr.listCharacterClasses.Remove(mgr.listCharacterClasses.Find(x => x.name.Equals(name)));
                    mgr.DisplayCharacterClasses();
                }
            }
            else if (display == ListDisplay.BASEITEMS)
            {
                DialogResult res = MessageBox.Show(null, "Really delete " + name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    mgr.listBaseItems.Remove(mgr.listBaseItems.Find(x => x.name.Equals(name)));
                }
            }
            else if (display == ListDisplay.ADVSITES)
            {
                DialogResult res = MessageBox.Show(null, "Really delete " + name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    mgr.listAdvSites.Remove(mgr.listAdvSites.Find(x => x.GetName().Equals(name)));
                    mgr.DisplayAdvSites();
                }
            }
            mgr.Save();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (display == ListDisplay.TYPES)
            {
                TabPage page = new TabPage("New Creature Type");
                TypeControl aoc = new TypeControl(page);
                page.Controls.Add(aoc);
                aoc.Dock = DockStyle.Fill;
                AddOrSelectPage(page);
            }
            else if (display == ListDisplay.CHARACTERS)
            {
                string newCharacter = "New Character";
                TabPage page = new TabPage(newCharacter);
                StatBlockControl mc = new StatBlockControl(page);
                page.Controls.Add(mc);
                mc.Dock = DockStyle.Fill;
                AddOrSelectPage(page);
            }
            else if (display == ListDisplay.CHARCLASSES)
            {
                string name = "New Class";
                mgr.NewTab("Character Class", name);
            }
            else if (display == ListDisplay.BASEITEMS)
            {
                string newArtObject = "New Art Object";
                TabPage page = new TabPage(newArtObject);
                ArtObjectControl aoc = new ArtObjectControl(page);
                page.Controls.Add(aoc);
                aoc.Dock = DockStyle.Fill;
                AddOrSelectPage(page);
            }
            else if (display == ListDisplay.ADVSITES)
            {
                TabPage page = new TabPage("New Adventure Site");
                AdventureSiteControl aoc = new AdventureSiteControl(page, this);
                page.Controls.Add(aoc);
                aoc.Dock = DockStyle.Fill;
                AddOrSelectPage(page);
            }
            else if (display == ListDisplay.ENCTABLES)
            {
                TabPage page = new TabPage("New Encounter Table");
                EncounterTableControl aoc = new EncounterTableControl(page, this);
                page.Controls.Add(aoc);
                aoc.Dock = DockStyle.Fill;
                AddOrSelectPage(page);
            }
        }

        private void tabOpenObjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && e.Modifiers == Keys.Control)
            {
                if (tabOpenObjects.SelectedTab != null)
                {
                    int index = tabOpenObjects.SelectedIndex;
                    if (index > 0)
                    {
                        TabPage current = tabOpenObjects.TabPages[index];
                        TabPage prev = tabOpenObjects.TabPages[index - 1];
                        tabOpenObjects.TabPages[index - 1] = current;
                        tabOpenObjects.TabPages[index] = prev;
                    }
                }
            }

            if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Control)
            {
                if (tabOpenObjects.SelectedTab != null)
                {
                    int index = tabOpenObjects.SelectedIndex;
                    if (index < tabOpenObjects.TabPages.Count-1)
                    {
                        TabPage current = tabOpenObjects.TabPages[index];
                        TabPage next = tabOpenObjects.TabPages[index + 1];
                        tabOpenObjects.TabPages[index + 1] = current;
                        tabOpenObjects.TabPages[index] = next;
                    }
                }
            }
        }
    }
}
