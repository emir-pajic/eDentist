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

namespace eDentist.WinUI.Forms.Manufacturers
{
    public partial class ManufacturersAdd : UserControl
    {
        private readonly APIService _countryService = new APIService("Countries");
        private readonly APIService _manufacturerService = new APIService("Manufacturers");

        private List<MCountries> _countries { get; set; }
        private MCountries _selectedCountry { get; set; }
        public ManufacturersAdd()
        {
            InitializeComponent();
        }

        private async void ManufcaturerAdd_LoadCountries(object sender, EventArgs e)
        {
            await ManufcaturerAdd_Load();
        }

        private async Task ManufcaturerAdd_Load()
        {
            _countries = await _countryService.Get<List<MCountries>>(null);
            menuCountries.Items.AddRange(_countries.Select(x => x.CountryName).ToArray());
        }

        private void menuCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCountry = _countries.FirstOrDefault(x => x.CountryName.Equals(menuCountries.SelectedItem));
        }

        private async void btnaddCity_Click(object sender, EventArgs e)
        {
            if (ValidateFieldInput(txtManufacturerName.Text, txtFoundationYear.Text))
            {

                var request = new ManufacturersUpsertRequest()
                {
                    Name = txtManufacturerName.Text,
                    FoundationYear = Convert.ToInt32(txtFoundationYear.Text),
                };

                if (_selectedCountry == null)
                {
                    request.CountryId = null;
                }
                else
                {
                    request.CountryId = _selectedCountry.CountryId;
                }

                await _manufacturerService.Insert<MManufacturers>(request);
                MessageBox.Show("Manufacturer added!");
                PanelHelper.SwapPanels(this.Parent, this, new ManufacturerList());
            }
        }

        private bool ValidateFieldInput(string ManufacturerName, string foundationYear)
        {
            if (string.IsNullOrEmpty(ManufacturerName))
            {
                MessageBox.Show("Manufacturer name can not be empty!");
                return false;
            }
            if (string.IsNullOrEmpty(foundationYear))
            {
                MessageBox.Show("Foundation year can not be empty!");
                return false;
            }
            return true;
        }
    }
}
