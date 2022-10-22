using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Materials
{
    public partial class MaterialsEdit : UserControl
    {
        private readonly APIService _manufacturerService = new APIService("Manufacturers");
        private readonly APIService _materialsService = new APIService("Materials");
        private List<MMaterials> _existingMaterials { get; set; }
        private List<MManufacturers> _existingManufacturers { get; set; }


        private MMaterials _selectedMaterial { get; set; }
        private MManufacturers _selectedManufacturer { get; set; }


        public MaterialsEdit()
        {
            InitializeComponent();
        }
        private async void MaterialsEdit_LoadData(object sender, EventArgs e)
        {
            await MaterialsEdit_Load();
        }
        private async Task MaterialsEdit_Load()
        {
            await LoadMaterials();
            await LoadManufacturers();
        }

        private async Task LoadManufacturers()
        {
            _existingManufacturers = await _manufacturerService.Get<List<MManufacturers>>(null);
            menuManufacturers.Items.AddRange(_existingManufacturers.Select(x => x.Name).ToArray());
        }

        private async Task LoadMaterials()
        {
            _existingMaterials = await _materialsService.Get<List<MMaterials>>(null);
            menuMaterials.Items.AddRange(_existingMaterials.Select(x => x.Name).ToArray());
        }

        private void menuMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMaterial = _existingMaterials.FirstOrDefault(x => x.Name.Equals(menuMaterials.SelectedItem));
            txtMaterial.Text = _selectedMaterial.Name;
        }

        private void menuManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedManufacturer = _existingManufacturers.FirstOrDefault(x => x.Name.Equals(menuManufacturers.SelectedItem));

        }

        private async void btnUpdateMaterial_Click(object sender, EventArgs e)
        {
            if (ValidateInput(_selectedMaterial, txtMaterial.Text))
            {

                var request = new MaterialsUpsertRequest()
                {
                    MaterialId = _selectedMaterial.MaterialId,
                    Name = txtMaterial.Text,
                    Image = _selectedMaterial.Image,
                    //ManufacturerId = _selectedManufacturer.ManufacturerId
                };
                if (_selectedManufacturer == null)
                {
                    request.ManufacturerId = null;
                }
                else
                {
                    request.ManufacturerId = _selectedManufacturer.ManufacturerId;
                }

                await _materialsService.Update<MMaterials>(request.MaterialId, request);
                MessageBox.Show("Material updated!");
                PanelHelper.SwapPanels(this.Parent, this, new MaterialList());
            }
        }
        private bool ValidateInput(MMaterials selected, string materialName)
        {
            if (selected == null)
            {
                MessageBox.Show("Please select material to update!");
                return false;
            }
            if (string.IsNullOrEmpty(materialName))
            {
                MessageBox.Show("Material name can not be empty!");
                return false;
            }
            return true;
        }
    }
}
