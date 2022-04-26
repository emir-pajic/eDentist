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
    public partial class ManufacturerEdit : UserControl
    {
        private readonly APIService _countryService = new APIService("Countries");
        private readonly APIService _manufacturerService = new APIService("Manufacturers");

        private List<MManufacturers> _existingManufacturers { get; set; }
        private List<MCountries> _existingCountries { get; set; }

        private MManufacturers _selectedManufacturer { get; set; }
        private MCountries _countryEdit { get; set; }


        public ManufacturerEdit()
        {
            InitializeComponent();
        }
        private async void ManufacturersEdit_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            await FillManufacturers();
            await FillCountries();
        }

        private async Task FillCountries()
        {
            _existingCountries = await _countryService.Get<List<MCountries>>(null);
            menuCountries.Items.AddRange(_existingCountries.Select(x => x.CountryName).ToArray());
        }

        private async Task FillManufacturers()
        {
            _existingManufacturers = await _manufacturerService.Get<List<MManufacturers>>(null);
            manufacturersMenu.Items.AddRange(_existingManufacturers.Select(x => x.Name).ToArray());
        }

        private void manufacturersMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtManufacturerName.Text = _existingManufacturers[manufacturersMenu.SelectedIndex].Name;
            txtFoundationYear.Text = _existingManufacturers[manufacturersMenu.SelectedIndex].FoundationYear.ToString();
            _selectedManufacturer = _existingManufacturers.FirstOrDefault(x => x.Name.Equals(manufacturersMenu.SelectedItem));
        }

        private void menuCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            _countryEdit = _existingCountries.FirstOrDefault(x => x.CountryName.Equals(menuCountries.SelectedItem));
        }

        private async void btnEditManufacturer_Click(object sender, EventArgs e)
        {
            if (ValidateFieldInput(_selectedManufacturer, txtManufacturerName.Text, txtFoundationYear.Text))
            {
                var request = new ManufacturersUpsertRequest()
                {
                    ManufacturerId = _selectedManufacturer.ManufacturerId,
                    Name = txtManufacturerName.Text,
                    FoundationYear = Convert.ToInt32(txtFoundationYear.Text),
                };
                if (_countryEdit == null)
                {
                    request.CountryId = null;
                }
                else
                {
                    request.CountryId = _countryEdit.CountryId;
                }
                await _manufacturerService.Update<MManufacturers>(_selectedManufacturer.ManufacturerId, request);
                MessageBox.Show("Manufacturer updated!");
                PanelHelper.SwapPanels(this.Parent, this, new ManufacturerList());
            }
        }
        private bool ValidateFieldInput(MManufacturers existing, string ManufacturerName, string foundationYear)
        {
            if(existing == null)
            {
                MessageBox.Show("Please select a manufacturer to edit!");
                return false;
            }
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
