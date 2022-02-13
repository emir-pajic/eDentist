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

namespace eDentist.WinUI.Forms.Countries
{
    public partial class CountryList : UserControl
    {
        private readonly APIService service = new APIService("Countries");
        public CountryList()
        {
            InitializeComponent();
        }

        private async void CountriesList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var result = await service.Get<List<MCountries>>(null);

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
    }
}
