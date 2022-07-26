using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Materials
{
    public partial class MaterialList : UserControl
    {
        private readonly APIService service = new APIService("Materials");
        private readonly APIService manufacturerService = new APIService("Manufacturers");
        public List<MaterialsManufacturers> result = new List<MaterialsManufacturers>();


        public MaterialList()
        {
            InitializeComponent();
        }

        private async void MaterialsList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearch.Focus();

        }
        private async Task LoadList()
        {
            var materials = await service.Get<List<MMaterials>>(null);


            foreach (var item in materials)
            {

                var manufacturer = await manufacturerService.GetById<MManufacturers>(item.ManufacturerId);
                MaterialsManufacturers resultObj = HandleData(item, manufacturer);
                result.Add(resultObj);
            }

            dvgMaterials.AutoGenerateColumns = false;
            dvgMaterials.ReadOnly = true;
            dvgMaterials.DataSource = result;
        }

        private static MaterialsManufacturers HandleData(MMaterials item, MManufacturers manufacturer)
        {
            var resultObj = new MaterialsManufacturers()
            {
                MaterialName = item.Name
            };
            if (manufacturer == null)
            {
                resultObj.ManufacturerName = "N/A";
            }
            else
            {
                resultObj.ManufacturerName = manufacturer.Name;
            }

            return resultObj;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new MaterialsAdd());
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new MaterialsEdit());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new MaterialsDelete());

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<MaterialsManufacturers>();
            foreach (var item in result)
            {
                if (item.MaterialName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }
            dvgMaterials.DataSource = filtered;
        }
    }
}
