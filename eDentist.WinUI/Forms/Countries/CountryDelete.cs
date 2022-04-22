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

namespace eDentist.WinUI.Forms.Countries
{
    public partial class CountryDelete : UserControl
    {
        private readonly APIService _countrySservice = new APIService("Countries");
        private List<MCountries> _existingcountries { get; set; }
        private MCountries _selectedCountry { get; set; }


        public CountryDelete()
        {
            InitializeComponent();
        }
        private async void CountriesDelete_LoadCountries(object sender, EventArgs e)
        {
            await CountriesDelete_Load();
        }
        private async Task CountriesDelete_Load()
        {
            await FillExistingCountries();
        }
        private async Task FillExistingCountries()
        {
            _existingcountries = await _countrySservice.Get<List<MCountries>>(null);
            menuCountries.Items.AddRange(_existingcountries.Select(x => x.CountryName).ToArray());
        }

        private void menuCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCountry = _existingcountries.FirstOrDefault(x => x.CountryName.Equals(menuCountries.SelectedItem));
        }

        private async void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            await _countrySservice.Delete<MCountries>(_selectedCountry.CountryId);
            MessageBox.Show("Country removed!");
            PanelHelper.SwapPanels(this.Parent, this, new CountryList());
        }
    }
}
