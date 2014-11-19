using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Classes;

namespace DM_Tool
{
    public partial class ArtObjectControl : UserControl
    {
        private BaseItem _baseItem;
        private Quality _quality;
        private HardMaterial _hardMaterial;
        private int value;
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parentPage;

        public ArtObjectControl()
        {
            InitializeComponent();

            var source = new AutoCompleteStringCollection();
            source.AddRange(mgr.listBaseItemNames.ToArray());
            tbBaseItem.AutoCompleteCustomSource = source;
        }

        public ArtObjectControl(TabPage parentPage)
        {
            InitializeComponent();

            _parentPage = parentPage;
            var source = new AutoCompleteStringCollection();
            source.AddRange(mgr.listBaseItemNames.ToArray());
            tbBaseItem.AutoCompleteCustomSource = source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAndEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _baseItem = mgr.listBaseItems[rnd.Next(mgr.listBaseItems.Count)];
            tbBaseItem.Text = _baseItem.name;

            value = rnd.Next(_baseItem.minValue, _baseItem.maxValue);

            int qualityRoll = rnd.Next(mgr.totalQualityRatios);

            foreach(Quality q in mgr.listQualities){
                qualityRoll -= q._weight;

                if(qualityRoll <= 0){
                    _quality = q;
                    value *= rnd.Next(_quality._minValueMod, q._maxValueMod);
                    break;
                }
            }

            if (_quality == null)
            {
                MessageBox.Show("Quality is null!");
                return;
            }

            tbQuality.Text = _quality._name;

            //Hard Material
            int hardMaterialRoll = rnd.Next(mgr.totalHardMaterialRatios);

            foreach (HardMaterial m in mgr.listHardMaterials)
            {
                hardMaterialRoll -= m.ratio;

                if (hardMaterialRoll <= 0)
                {
                    _hardMaterial = m;
                    value *= rnd.Next(_hardMaterial.minValueMod, _hardMaterial.maxValueMod);
                    break;
                }
            }

            if (_hardMaterial == null)
            {
                MessageBox.Show("Hard Material is null!");
                return;
            }

            tbMaterial.Text = _hardMaterial.name;

            tbName.Text = String.Format("{0} {1} {2}", tbQuality.Text, tbMaterial.Text, tbBaseItem.Text);
            lblValue.Text = String.Format("Total Value: {0}", value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _parentPage.Dispose();
        }
    }
}
