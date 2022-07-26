using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Cities
{
    public partial class CityList : UserControl
    {
        private readonly APIService service = new APIService("Cities");
        private readonly APIService countryService = new APIService("Countries");
        List<CitiesCountries> result = new List<CitiesCountries>();

        public CityList()
        {
            InitializeComponent();
        }
        private async void CitiesList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearch.Focus();

        }
        private async Task LoadList()
        {

            var cities = await service.Get<List<MCities>>(null);

            foreach (var item in cities)
            {
                var country = await countryService.GetById<MCountries>(item.CountryId);
                CitiesCountries resultObj = HandleCountries(item, country);
                result.Add(resultObj);
            }

            dgvCities.AutoGenerateColumns = false;
            dgvCities.ReadOnly = true;
            dgvCities.DataSource = result;
        }

        private static CitiesCountries HandleCountries(MCities item, MCountries country)
        {
            var resultObj = new CitiesCountries();

            if (country == null)
            {
                resultObj.CityName = item.CityName;
                resultObj.CountryName = "N/A";
            }
            else
            {
                resultObj.CityName = item.CityName;
                resultObj.CountryName = country.CountryName;
            }

            return resultObj;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new CityAdd());
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new CityEdit());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new CityDelete());
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<CitiesCountries>();
            foreach (var item in result)
            {
                if (item.CityName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvCities.DataSource = filtered;
        }
    }
}
