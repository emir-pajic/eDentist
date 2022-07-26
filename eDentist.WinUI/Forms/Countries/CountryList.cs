using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Countries
{
    public partial class CountryList : UserControl
    {
        private readonly APIService service = new APIService("Countries");
        List<MCountries> result = new List<MCountries>();
        public CountryList()
        {
            InitializeComponent();
        }

        private async void CountriesList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearch.Focus();

        }
        private async Task LoadList()
        {
            result = await service.Get<List<MCountries>>(null);

            dvgCountries.AutoGenerateColumns = false;
            dvgCountries.ReadOnly = true;
            dvgCountries.DataSource = result;
        }
        private async Task LoadList(CountriesSearchRequest request)
        {
            var result = await service.Get<List<CountriesSearchRequest>>(request);

            dvgCountries.AutoGenerateColumns = false;
            dvgCountries.ReadOnly = true;
            dvgCountries.DataSource = result;
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new CountryAdd());
        }

        private void btnCountryDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new CountryEdit());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new CountryDelete());

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<MCountries>();
            foreach (var item in result)
            {
                if (item.CountryName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }
            dvgCountries.DataSource = filtered;

        }


    }
}
