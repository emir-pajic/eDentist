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
    public partial class CityAdd : UserControl
    {
        private readonly APIService _countryService = new APIService("Countries");
        private readonly APIService _cityService = new APIService("Cities");
        private List<MCountries> _countries { get; set; }
        private MCountries _selectedCountry { get; set; }

        public CityAdd()
        {
            InitializeComponent();
            
        }
        private async void CitiesAdd_LoadCountries(object sender, EventArgs e)
        {
            await CitiesAdd_Load();
        }

        private async Task CitiesAdd_Load()
        {
            _countries = await _countryService.Get<List<MCountries>>(null);
            menuCountries.Items.AddRange(_countries.Select(x => x.CountryName).ToArray());
        }

        private async void menuCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

            _selectedCountry = _countries.FirstOrDefault(x => x.CountryName.Equals(menuCountries.SelectedItem));            
        }

        private async void btnaddCity_Click(object sender, EventArgs e)
        {
            var request = new CitiesUpsertRequest()
            {
                CityName = txtCityName.Text,
                CountryId = _selectedCountry.CountryId
            };

            await _cityService.Insert<MCities>(request);
            MessageBox.Show("City added!");
            PanelHelper.SwapPanels(this.Parent, this, new CityList());
        }
    }
}
