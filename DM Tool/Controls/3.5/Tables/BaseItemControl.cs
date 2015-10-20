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
    public partial class BaseItemControl : UserControl
    {
        private PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parentPage;
        private bool _edit;

        public BaseItemControl()
        {
            InitializeComponent();
        }

        public BaseItemControl(TabPage page, bool editMode)
        {
            this._parentPage = page;
            this._edit = editMode;

            InitializeComponent();

            foreach (BaseItem i in mgr.listBaseItems)
            {
                dataGridView1.Rows.Add(i.name, i.minValue, i.maxValue, i.weight, i.ratio);
            }

            CanEditControl(editMode);
        }

        private void btnSaveAndEdit_Click(object sender, EventArgs e)
        {
            if (btnSaveAndEdit.Text == "Save")
            {
                dataGridView1.AllowUserToAddRows = false;
                mgr.totalBaseItemRatios = 0;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["colName"].Value != null)
                    {
                        string itemName = r.Cells["colName"].Value.ToString();
                        string minValueMod = (r.Cells["colMinValue"].Value != null) ? r.Cells["colMinValue"].Value.ToString() : "0";
                        string maxValueMod = (r.Cells["colMaxValue"].Value != null) ? r.Cells["colMaxValue"].Value.ToString() : "0";
                        string weight = (r.Cells["colWeight"].Value != null) ? r.Cells["colWeight"].Value.ToString() : "0";
                        string ratio = (r.Cells["colRatio"].Value != null) ? r.Cells["colRatio"].Value.ToString() : "0";

                        btnSaveAndEdit.Text = "Edit";
                        CanEditControl(false);
                        BaseItem i = mgr.listBaseItems.Find(x => x.name.Equals(itemName));
                        if (i != null)
                        {
                            mgr.listBaseItems.Remove(i);
                        }
                        mgr.totalBaseItemRatios += Convert.ToInt32(weight);
                        mgr.listBaseItems.Add(new BaseItem(itemName, Convert.ToInt32(minValueMod), Convert.ToInt32(maxValueMod), Convert.ToInt32(weight), Convert.ToInt32(ratio)));
                        PublicManager.SerializeBaseItemsToXML(mgr.listBaseItems);
                    }
                    else
                    {
                        r.Dispose();
                    }
                }
            }
            else if (btnSaveAndEdit.Text == "Edit")
            {
                dataGridView1.AllowUserToAddRows = true;
                btnSaveAndEdit.Text = "Save";
                CanEditControl(true);
            }
        }

        private void CanEditControl(bool value)
        {
            dataGridView1.ReadOnly = !value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _parentPage.Dispose();
        }
    }
}
