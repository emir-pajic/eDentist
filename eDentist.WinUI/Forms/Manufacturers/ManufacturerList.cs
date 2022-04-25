using eDentist.Model;
using eDentist.Model.Request;
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

namespace eDentist.WinUI.Forms.Manufacturers
{
    public partial class ManufacturerList : UserControl
    {
        private readonly APIService service = new APIService("Manufacturers");
        private readonly APIService countryService = new APIService("Countries");

        public ManufacturerList()
        {
            InitializeComponent();
        }
        private async void ManufacturersList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var manufacturers = await service.Get<List<MManufacturers>>(null);
            List<ManufacturersCountries> result = new List<ManufacturersCountries>();

            foreach (var item in manufacturers)
            {
                var country = await countryService.GetById<MCountries>(item.CountryId);
                ManufacturersCountries resultObj = HandleCountries(item, country);
                result.Add(resultObj);
            }

            dvgManufacturers.AutoGenerateColumns = false;
            dvgManufacturers.ReadOnly = true;
            dvgManufacturers.DataSource = result;
        }

        private static ManufacturersCountries HandleCountries(MManufacturers item, MCountries country)
        {
            var resultObj = new ManufacturersCountries();
            if (country == null)
            {
                resultObj.ManufacturerName = item.Name;
                resultObj.FoundationYear = item.FoundationYear;
                resultObj.Country = "N/A";
            }
            else
            {
                resultObj.ManufacturerName = item.Name;
                resultObj.FoundationYear = item.FoundationYear;
                resultObj.Country = country.CountryName;
            }

            return resultObj;
        }

        private async Task LoadList(ManufacturersSearchRequest request)
        {
            var result = await service.Get<List<ManufacturersSearchRequest>>(request);

            dvgManufacturers.AutoGenerateColumns = false;
            dvgManufacturers.ReadOnly = true;
            dvgManufacturers.DataSource = result;
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ManufacturersAdd());
        }
    }
}
