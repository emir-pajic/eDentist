using eDentist.Model;
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


        public CityAdd()
        {
            InitializeComponent();
        }

        private async void menuCountries_Click(object sender, EventArgs e)
        {
           var countries = await _countryService.Get<List<MCountries>>(null);
           menuCountries.DataSource = countries;           
           
        }
    }
}
