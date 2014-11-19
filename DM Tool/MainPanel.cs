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
        private enum ListDisplay { ALL, TYPES, MONSTERS, BASEITEMS, ADVSITES};
        private List<string> baseMenu = new List<string> { "Types", "Monsters", "Base Items", "Adventure Sites"};

        public PublicManager mgr = PublicManager.GetInstance();

        private ListDisplay display;
        public MainPanel()
        {
            InitializeComponent();

            display = ListDisplay.ALL;
            mgr.listCreatureTypes = new List<CreatureType>();
            mgr.listCharacterSheets = new List<CharacterSheet>();
            mgr.listBaseItems = new List<BaseItem>();
            mgr.listQualities = new List<Quality>();
            mgr.listHardMaterials = new List<HardMaterial>();
            mgr.listBaseItemNames = new List<string>();
            mgr.listCreatureSizes = new List<CreatureSize>();
            mgr.listAdvSites = new List<AdventureSite>();
            mgr.SetMain(this);
            mgr.LoadDefault();
            SetMenuToBase();
            this.Text = mgr.GetCampaign();
        }


        

        private void saveCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mgr.Save();
        }

        private void createAMonsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newMonster = "New Monster";
            TabPage page = new TabPage(newMonster);
            MonsterControl mc = new MonsterControl(page);
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

            if (name == "--Main Manu")
            {
                SetMenuToBase();
            }

            if (display == ListDisplay.ALL)
            {
                if (name == "Types")
                {
                    dgView.Rows.Clear();
                    display = ListDisplay.TYPES;
                    dgView.Rows.Add("--Main Manu");
                    foreach (CreatureType type in mgr.listCreatureTypes)
                    {
                        dgView.Rows.Add(type.name);
                    }
                }
                if (name == "Monsters")
                {
                    DisplayCreatures();
                }
                if (name == "Base Items")
                {
                    DisplayBaseItems();
                }
                if (name == "Adventure Sites")
                {
                    DisplayAdventureSites();
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
            else if (display == ListDisplay.MONSTERS)
            {
                foreach (TabPage page in tabOpenObjects.TabPages)
                {
                    if (page.Text == name)
                    {
                        tabOpenObjects.SelectedTab = page;
                        return;
                    }
                }
                mgr.NewTab("Monster", name);
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

        public void SetMenuToBase()
        {
            display = ListDisplay.ALL;
            dgView.Rows.Clear();
            foreach (string s in baseMenu)
            {
                dgView.Rows.Add(s);
            }
        }

        public void DisplayCreatures()
        {
            dgView.Rows.Clear();
            display = ListDisplay.MONSTERS;
            dgView.Rows.Add("--Main Manu");
            foreach (CharacterSheet m in mgr.listCharacterSheets)
            {
                dgView.Rows.Add(m.name);
            }
        }

        public void DisplayBaseItems()
        {
            dgView.Rows.Clear();
            display = ListDisplay.BASEITEMS;
            dgView.Rows.Add("--Main Manu");
            foreach (BaseItem m in mgr.listBaseItems)
            {
                dgView.Rows.Add(m.name);
            }
        }

        public void DisplayAdventureSites()
        {
            dgView.Rows.Clear();
            display = ListDisplay.ADVSITES;
            dgView.Rows.Add("--Main Manu");
            foreach (AdventureSite m in mgr.listAdvSites)
            {
                dgView.Rows.Add(m.GetName());
            }
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newArtObject = "New Art Object";
            TabPage page = new TabPage(newArtObject);
            ArtObjectControl aoc = new ArtObjectControl(page);
            page.Controls.Add(aoc);
            aoc.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
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

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAndEdit_Click(object sender, EventArgs e)
        {

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
            TextInputDialog txtBox = new TextInputDialog("Enter Campaign Name");
            txtBox.ShowDialog();

            if (txtBox.DialogResult == DialogResult.OK)
            {
                mgr.SetCampaign(txtBox.GetText());
            }

            Directory.CreateDirectory("./" + mgr.GetCampaign());

            mgr.WriteConfigFile();
            this.Text = mgr.GetCampaign();
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
            CharacterControl aoc = new CharacterControl();
            page.Controls.Add(aoc);
            aoc.Dock = DockStyle.Fill;
            AddOrSelectPage(page);
        }

        private void loadCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new  FolderBrowserDialog();
            fbd.SelectedPath = Environment.CurrentDirectory;
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] split = fbd.SelectedPath.Split('\\');
                mgr.SetCampaign(split[split.Length -1]);
            }

            Directory.CreateDirectory("./" + mgr.GetCampaign());

            mgr.WriteConfigFile();
            this.Text = mgr.GetCampaign();
            mgr.LoadCampaign();
        }
    }
}
