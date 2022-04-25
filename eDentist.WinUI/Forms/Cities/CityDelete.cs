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

namespace eDentist.WinUI.Forms.Cities
{
    public partial class CityDelete : UserControl
    {
        private readonly APIService _cityService = new APIService("Cities");
        private List<MCities> _existingCities { get; set; }
        private MCities _selectedCity { get; set; }

        public CityDelete()
        {
            InitializeComponent();
        }

        private async void CitiesDelete_LoadCities(object sender, EventArgs e)
        {
            await CitiesDelete_Load();
        }
        private async Task CitiesDelete_Load()
        {
            await FillExistingCities();
        }
        private async Task FillExistingCities()
        {
            _existingCities = await _cityService.Get<List<MCities>>(null);
            menuCities.Items.AddRange(_existingCities.Select(x => x.CityName).ToArray());
        }

        private void menuCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCity = _existingCities.FirstOrDefault(x => x.CityName.Equals(menuCities.SelectedItem));
        }

        private async void btnRemoveCity_Click(object sender, EventArgs e)
        {
            if (_selectedCity == null)
            {
                MessageBox.Show("Please select a city to remove!");
            }
            else
            {
                await _cityService.Delete<MCities>(_selectedCity.CityId);
                MessageBox.Show("City removed!");
                PanelHelper.SwapPanels(this.Parent, this, new CityList());

            }
        }
    }
}
