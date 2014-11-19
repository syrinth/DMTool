namespace DM_Tool
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabOpenObjects = new System.Windows.Forms.TabControl();
            this.ctxtTabsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllOpenTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToTheRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.campaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monstersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAMonsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adventureSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdventureSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.ctxtTabsMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltMain
            // 
            this.spltMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spltMain.Location = new System.Drawing.Point(0, 27);
            this.spltMain.Name = "spltMain";
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.dgView);
            this.spltMain.Panel1.Controls.Add(this.btnSearch);
            this.spltMain.Panel1.Controls.Add(this.textBox1);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.tabOpenObjects);
            this.spltMain.Size = new System.Drawing.Size(832, 541);
            this.spltMain.SplitterDistance = 225;
            this.spltMain.TabIndex = 0;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToResizeColumns = false;
            this.dgView.AllowUserToResizeRows = false;
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgView.ColumnHeadersVisible = false;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgView.GridColor = System.Drawing.SystemColors.Window;
            this.dgView.Location = new System.Drawing.Point(0, 31);
            this.dgView.MultiSelect = false;
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersVisible = false;
            this.dgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgView.Size = new System.Drawing.Size(222, 507);
            this.dgView.TabIndex = 2;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabOpenObjects_KeyPress);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(131, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabOpenObjects
            // 
            this.tabOpenObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpenObjects.Location = new System.Drawing.Point(3, 4);
            this.tabOpenObjects.Name = "tabOpenObjects";
            this.tabOpenObjects.SelectedIndex = 0;
            this.tabOpenObjects.Size = new System.Drawing.Size(600, 537);
            this.tabOpenObjects.TabIndex = 0;
            this.tabOpenObjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabOpenObjects_KeyPress);
            this.tabOpenObjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabOpenObjects_MouseDown);
            // 
            // ctxtTabsMenu
            // 
            this.ctxtTabsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeThisToolStripMenuItem,
            this.closeAllOpenTabsToolStripMenuItem,
            this.closeAllToTheRightToolStripMenuItem});
            this.ctxtTabsMenu.Name = "ctxtTabsMenu";
            this.ctxtTabsMenu.Size = new System.Drawing.Size(186, 70);
            // 
            // closeThisToolStripMenuItem
            // 
            this.closeThisToolStripMenuItem.Name = "closeThisToolStripMenuItem";
            this.closeThisToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.closeThisToolStripMenuItem.Text = "Close";
            this.closeThisToolStripMenuItem.Click += new System.EventHandler(this.closeThisToolStripMenuItem_Click);
            // 
            // closeAllOpenTabsToolStripMenuItem
            // 
            this.closeAllOpenTabsToolStripMenuItem.Name = "closeAllOpenTabsToolStripMenuItem";
            this.closeAllOpenTabsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.closeAllOpenTabsToolStripMenuItem.Text = "Close All";
            this.closeAllOpenTabsToolStripMenuItem.Click += new System.EventHandler(this.closeAllOpenTabsToolStripMenuItem_Click);
            // 
            // closeAllToTheRightToolStripMenuItem
            // 
            this.closeAllToTheRightToolStripMenuItem.Name = "closeAllToTheRightToolStripMenuItem";
            this.closeAllToTheRightToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.closeAllToTheRightToolStripMenuItem.Text = "Close All to the Right";
            this.closeAllToTheRightToolStripMenuItem.Click += new System.EventHandler(this.closeAllToTheRightToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campaignToolStripMenuItem,
            this.battleToolStripMenuItem,
            this.monstersToolStripMenuItem,
            this.newItemToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.adventureSiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // campaignToolStripMenuItem
            // 
            this.campaignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCampaignToolStripMenuItem,
            this.loadCampaignToolStripMenuItem,
            this.saveCampaignToolStripMenuItem});
            this.campaignToolStripMenuItem.Name = "campaignToolStripMenuItem";
            this.campaignToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.campaignToolStripMenuItem.Text = "Campaign";
            // 
            // newCampaignToolStripMenuItem
            // 
            this.newCampaignToolStripMenuItem.Name = "newCampaignToolStripMenuItem";
            this.newCampaignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newCampaignToolStripMenuItem.Text = "New Campaign";
            this.newCampaignToolStripMenuItem.Click += new System.EventHandler(this.newCampaignToolStripMenuItem_Click);
            // 
            // loadCampaignToolStripMenuItem
            // 
            this.loadCampaignToolStripMenuItem.Name = "loadCampaignToolStripMenuItem";
            this.loadCampaignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadCampaignToolStripMenuItem.Text = "Load Campaign";
            // 
            // saveCampaignToolStripMenuItem
            // 
            this.saveCampaignToolStripMenuItem.Name = "saveCampaignToolStripMenuItem";
            this.saveCampaignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveCampaignToolStripMenuItem.Text = "Save Campaign";
            this.saveCampaignToolStripMenuItem.Click += new System.EventHandler(this.saveCampaignToolStripMenuItem_Click);
            // 
            // battleToolStripMenuItem
            // 
            this.battleToolStripMenuItem.Name = "battleToolStripMenuItem";
            this.battleToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.battleToolStripMenuItem.Text = "&Battle";
            this.battleToolStripMenuItem.Click += new System.EventHandler(this.battleToolStripMenuItem_Click);
            // 
            // monstersToolStripMenuItem
            // 
            this.monstersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAMonsterToolStripMenuItem,
            this.typesToolStripMenuItem});
            this.monstersToolStripMenuItem.Name = "monstersToolStripMenuItem";
            this.monstersToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.monstersToolStripMenuItem.Text = "Monsters";
            // 
            // createAMonsterToolStripMenuItem
            // 
            this.createAMonsterToolStripMenuItem.Name = "createAMonsterToolStripMenuItem";
            this.createAMonsterToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createAMonsterToolStripMenuItem.Text = "Create a Monster";
            this.createAMonsterToolStripMenuItem.Click += new System.EventHandler(this.createAMonsterToolStripMenuItem_Click);
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewTypeToolStripMenuItem});
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.typesToolStripMenuItem.Text = "Types";
            this.typesToolStripMenuItem.Click += new System.EventHandler(this.typesToolStripMenuItem_Click);
            // 
            // createNewTypeToolStripMenuItem
            // 
            this.createNewTypeToolStripMenuItem.Name = "createNewTypeToolStripMenuItem";
            this.createNewTypeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createNewTypeToolStripMenuItem.Text = "Create New Type";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseItemsToolStripMenuItem,
            this.qualityToolStripMenuItem,
            this.hardMaterialsToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // baseItemsToolStripMenuItem
            // 
            this.baseItemsToolStripMenuItem.Name = "baseItemsToolStripMenuItem";
            this.baseItemsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.baseItemsToolStripMenuItem.Text = "Base Items";
            this.baseItemsToolStripMenuItem.Click += new System.EventHandler(this.baseItemsToolStripMenuItem_Click);
            // 
            // qualityToolStripMenuItem
            // 
            this.qualityToolStripMenuItem.Name = "qualityToolStripMenuItem";
            this.qualityToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.qualityToolStripMenuItem.Text = "Quality";
            this.qualityToolStripMenuItem.Click += new System.EventHandler(this.qualityToolStripMenuItem_Click);
            // 
            // hardMaterialsToolStripMenuItem
            // 
            this.hardMaterialsToolStripMenuItem.Name = "hardMaterialsToolStripMenuItem";
            this.hardMaterialsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.hardMaterialsToolStripMenuItem.Text = "HardMaterials";
            this.hardMaterialsToolStripMenuItem.Click += new System.EventHandler(this.hardMaterialsToolStripMenuItem_Click);
            // 
            // adventureSiteToolStripMenuItem
            // 
            this.adventureSiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdventureSiteToolStripMenuItem,
            this.derpToolStripMenuItem});
            this.adventureSiteToolStripMenuItem.Name = "adventureSiteToolStripMenuItem";
            this.adventureSiteToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.adventureSiteToolStripMenuItem.Text = "Adventure Sites";
            // 
            // newAdventureSiteToolStripMenuItem
            // 
            this.newAdventureSiteToolStripMenuItem.Name = "newAdventureSiteToolStripMenuItem";
            this.newAdventureSiteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newAdventureSiteToolStripMenuItem.Text = "New Adventure Site";
            this.newAdventureSiteToolStripMenuItem.Click += new System.EventHandler(this.newAdventureSiteToolStripMenuItem_Click);
            // 
            // derpToolStripMenuItem
            // 
            this.derpToolStripMenuItem.Name = "derpToolStripMenuItem";
            this.derpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.derpToolStripMenuItem.Text = "derp";
            this.derpToolStripMenuItem.Click += new System.EventHandler(this.derpToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 568);
            this.Controls.Add(this.spltMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPanel";
            this.Text = "DM Tool";
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel1.PerformLayout();
            this.spltMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ctxtTabsMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem campaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCampaignToolStripMenuItem;
        private System.Windows.Forms.TabControl tabOpenObjects;
        private System.Windows.Forms.ToolStripMenuItem monstersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAMonsterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewTypeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adventureSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdventureSiteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtTabsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllOpenTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToTheRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derpToolStripMenuItem;
    }
}

