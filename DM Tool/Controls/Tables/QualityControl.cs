using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DM_Tool.Controls
{
    public partial class QualityControl : UserControl
    {
        private PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parentPage;
        private bool _edit;

        public QualityControl()
        {
            InitializeComponent();
        }

        public QualityControl(TabPage page, bool editMode)
        {
            this._parentPage = page;
            this._edit = editMode;

            InitializeComponent();

            foreach (Quality q in mgr.listQualities)
            {
                dataGridView1.Rows.Add(q._name, q._minValueMod, q._maxValueMod, q._weight);
            }

            CanEditControl(editMode);
        }

        private void btnSaveAndEdit_Click(object sender, EventArgs e)
        {
            if (btnSaveAndEdit.Text == "Save")
            {
                mgr.totalQualityRatios = 0;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["colName"].Value != null)
                    {
                        string qualityName = r.Cells["colName"].Value.ToString();
                        string minValueMod = (r.Cells["colMinValueMod"].Value != null) ? r.Cells["colMinValueMod"].Value.ToString() : "0";
                        string maxValueMod = (r.Cells["colMaxValueMod"].Value != null) ? r.Cells["colMaxValueMod"].Value.ToString() : "0";
                        string weight = (r.Cells["colWeight"].Value != null) ? r.Cells["colWeight"].Value.ToString() : "0";

                        btnSaveAndEdit.Text = "Edit";
                        CanEditControl(false);
                        Quality tc = mgr.listQualities.Find(x => x._name.Equals(qualityName));
                        if (tc != null)
                        {
                            mgr.listQualities.Remove(tc);
                        }
                        mgr.totalQualityRatios += Convert.ToInt32(weight);
                        mgr.listQualities.Add(new Quality(qualityName, Convert.ToInt32(minValueMod), Convert.ToInt32(maxValueMod), Convert.ToInt32(weight)));
                        PublicManager.SerializeQualitiesToXML(mgr.listQualities);
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
