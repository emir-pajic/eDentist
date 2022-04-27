using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Materials
{
    public partial class MaterialsDelete : UserControl
    {
        private readonly APIService _materialsService = new APIService("Materials");
        private List<MMaterials> _existingMaterials { get; set; }
        private MMaterials _selectedMaterial { get; set; }
        public MaterialsDelete()
        {
            InitializeComponent();
        }
        private async void MaterialsDelete_LoadData(object sender, EventArgs e)
        {
            await MaterialsDeleteLoad();
        }
        private async Task MaterialsDeleteLoad()
        {
            _existingMaterials = await _materialsService.Get<List<MMaterials>>(null);
            menuMaterials.Items.AddRange(_existingMaterials.Select(x => x.Name).ToArray());
        }

        private void menuMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMaterial = _existingMaterials.FirstOrDefault(x => x.Name.Equals(menuMaterials.SelectedItem));
        }

        private async void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            if (_selectedMaterial == null)
            {
                MessageBox.Show("Please select a material to remove!");
            }
            else
            {
                await _materialsService.Delete<MCities>(_selectedMaterial.MaterialId);
                MessageBox.Show("Material removed!");
                PanelHelper.SwapPanels(this.Parent, this, new MaterialList());

            }
        }
    }
}
