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

namespace eDentist.WinUI.Forms.Cities
{
    public partial class CityEdit : UserControl
    {
        private readonly APIService _countryService = new APIService("Countries");
        private readonly APIService _cityService = new APIService("Cities");
        private List<MCities> _existingCities { get; set; }
        private List<MCountries> _existingcountries { get; set; }

        private MCities _selectedCity { get; set; }

        private MCities _cityToEdit { get; set; }

        private MCountries _newCountry { get; set; }

        public CityEdit()
        {
            InitializeComponent();
        }
        private async void CitiesEdit_LoadCities(object sender, EventArgs e)
        {
            await CitiesEdit_Load();
        }
        private async Task CitiesEdit_Load()
        {
            await FillExistingCities();
            await FillExistingCountries();
        }

        private async Task FillExistingCountries()
        {
            _existingcountries = await _countryService.Get<List<MCountries>>(null);
            newCountryMenu.Items.AddRange(_existingcountries.Select(x => x.CountryName).ToArray());
        }

        private async Task FillExistingCities()
        {
            _existingCities = await _cityService.Get<List<MCities>>(null);
            menuCities.Items.AddRange(_existingCities.Select(x => x.CityName).ToArray());
        }

        private void menuCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCityName.Text = _existingCities[menuCities.SelectedIndex].CityName;
            _selectedCity = _existingCities.FirstOrDefault(x => x.CityName.Equals(menuCities.SelectedItem));

        }
        private void newCountryMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _newCountry = _existingcountries.FirstOrDefault(x => x.CountryName.Equals(newCountryMenu.SelectedItem));
        }

        private async void btnUpdateCity_Click(object sender, EventArgs e)
        {
            _cityToEdit = _existingCities.FirstOrDefault(x => x.CityName.Equals(_selectedCity.CityName));

            var request = new CitiesUpsertRequest()
            {
                CityId = _cityToEdit.CityId,
                CityName = txtCityName.Text,
                CountryId = _newCountry.CountryId
            };

            await _cityService.Update<MCities>(request.CityId,request);
            MessageBox.Show("City updated!");
            PanelHelper.SwapPanels(this.Parent, this, new CityList());
        }

        
    }
}
