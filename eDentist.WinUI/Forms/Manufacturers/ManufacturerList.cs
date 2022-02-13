using eDentist.Model;
using eDentist.Model.Request;
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

                var resultObj = new ManufacturersCountries()
                {
                    ManufacturerName = item.Name,
                    FoundationYear = item.FoundationYear,
                    Country = country.CountryName
                };
                result.Add(resultObj);
            }

            dvgManufacturers.AutoGenerateColumns = false;
            dvgManufacturers.ReadOnly = true;
            dvgManufacturers.DataSource = result;
        }
        private async Task LoadList(ManufacturersSearchRequest request)
        {
            var result = await service.Get<List<ManufacturersSearchRequest>>(request);

            dvgManufacturers.AutoGenerateColumns = false;
            dvgManufacturers.ReadOnly = true;
            dvgManufacturers.DataSource = result;
        }
    }
}
