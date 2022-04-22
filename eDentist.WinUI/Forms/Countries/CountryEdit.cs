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

namespace eDentist.WinUI.Forms.Countries
{
    public partial class CountryEdit : UserControl
    {
        private readonly APIService _countryService = new APIService("Countries");
        private List<MCountries> _existingcountries { get; set; }

        private MCountries _selectedCountry { get; set; }
        private MCountries _newCountry { get; set; }



        public CountryEdit()
        {
            InitializeComponent();
        }
        private async void CountriesEdit_LoadCountries(object sender, EventArgs e)
        {
            await CountriesEdit_Load();
        }
        private async Task CountriesEdit_Load()
        {
            await FillExistingCountries();
        }

        private async Task FillExistingCountries()
        {
            _existingcountries = await _countryService.Get<List<MCountries>>(null);
            menuCountries.Items.AddRange(_existingcountries.Select(x => x.CountryName).ToArray());
        }

        private void menuCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCountryName.Text = _existingcountries[menuCountries.SelectedIndex].CountryName;
            _selectedCountry = _existingcountries.FirstOrDefault(x => x.CountryName.Equals(menuCountries.SelectedItem));
        }

        private async void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            _newCountry = _existingcountries.FirstOrDefault(x => x.CountryName.Equals(_selectedCountry.CountryName));

            var request = new CountriesUpsertRequest()
            {
                CountryId = _newCountry.CountryId,
                CountryName = txtCountryName.Text,
            };

            await _countryService.Update<MCountries>(request.CountryId, request);
            MessageBox.Show("Country updated!");
            PanelHelper.SwapPanels(this.Parent, this, new CountryList());
        }
    }
}
