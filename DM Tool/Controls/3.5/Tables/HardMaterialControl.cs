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
    public partial class HardMaterialControl : UserControl
    {
        private PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parentPage;
        private bool _edit;

        public HardMaterialControl()
        {
            InitializeComponent();
        }

        public HardMaterialControl(TabPage page, bool editMode)
        {
            this._parentPage = page;
            this._edit = editMode;

            InitializeComponent();

            foreach (HardMaterial m in mgr.listHardMaterials)
            {
                dataGridView1.Rows.Add(m.name, m.minValueMod, m.maxValueMod, m.ratio);
            }

            CanEditControl(editMode);
        }

        private void btnSaveAndEdit_Click(object sender, EventArgs e)
        {
            if (btnSaveAndEdit.Text == "Save")
            {
                mgr.totalHardMaterialRatios = 0;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["colName"].Value != null)
                    {
                        string name = r.Cells["colName"].Value.ToString();
                        string minValueMod = (r.Cells["colMinValueMod"].Value != null) ? r.Cells["colMinValueMod"].Value.ToString() : "0";
                        string maxValueMod = (r.Cells["colMaxValueMod"].Value != null) ? r.Cells["colMaxValueMod"].Value.ToString() : "0";
                        string weight = (r.Cells["colWeight"].Value != null) ? r.Cells["colWeight"].Value.ToString() : "0";

                        btnSaveAndEdit.Text = "Edit";
                        CanEditControl(false);
                        HardMaterial tc = mgr.listHardMaterials.Find(x => x.name.Equals(name));
                        if (tc != null)
                        {
                            mgr.listHardMaterials.Remove(tc);
                        }
                        mgr.totalQualityRatios += Convert.ToInt32(weight);
                        mgr.listHardMaterials.Add(new HardMaterial(name, Convert.ToInt32(minValueMod), Convert.ToInt32(maxValueMod), Convert.ToInt32(weight)));
                        PublicManager.SerializeHardMaterialsToXML(mgr.listHardMaterials);
                    }
                    else
                    {
                        r.Dispose();
                    }
                }
            }
            else if (btnSaveAndEdit.Text == "Edit")
            {
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
