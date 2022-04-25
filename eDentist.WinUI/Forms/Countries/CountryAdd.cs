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
    public partial class CountryAdd : UserControl
    {
        private readonly APIService service = new APIService("Countries");

        public CountryAdd()
        {
            InitializeComponent();
        }

        private async void btnAddCountry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountryAdd.Text))
            {
                MessageBox.Show("Country name can not be empty!");
            }
            else
            {

                var request = new CountriesUpsertRequest()
                {
                    CountryName = txtCountryAdd.Text
                };
                var countries = await service.Get<List<MCountries>>(null);

                foreach (var country in countries)
                {
                    if (country.CountryName.Equals(request.CountryName))
                    {
                        MessageBox.Show("Country already exists!");
                        return;
                    }
                }

                await service.Insert<MCountries>(request);
                MessageBox.Show("Country added!");
                PanelHelper.SwapPanels(this.Parent, this, new CountryList());
            }
        }
    }
}
