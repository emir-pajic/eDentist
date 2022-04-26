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

namespace eDentist.WinUI.Forms.Manufacturers
{
    public partial class ManufacturerDelete : UserControl
    {
        private readonly APIService _manufacturerService = new APIService("Manufacturers");
        private List<MManufacturers> _existingManufacturers { get; set; }
        private MManufacturers _selectedManufacturer { get; set; }


        public ManufacturerDelete()
        {
            InitializeComponent();
        }
        private async void ManufacturersDelete_LoadData(object sender, EventArgs e)
        {
            await ManufacturerDeleteLoad();
        }
        private async Task ManufacturerDeleteLoad()
        {
           

            _existingManufacturers = await _manufacturerService.Get<List<MManufacturers>>(null);
            menuManufacturers.Items.AddRange(_existingManufacturers.Select(x => x.Name).ToArray());
        }

        private void menuManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedManufacturer = _existingManufacturers.FirstOrDefault(x => x.Name.Equals(menuManufacturers.SelectedItem));
        }

        private async void btnRemoveManufacturer_Click(object sender, EventArgs e)
        {
            if (_selectedManufacturer == null)
            {
                MessageBox.Show("Please select a manufacturer to remove!");
            }
            else
            {
                await _manufacturerService.Delete<MCities>(_selectedManufacturer.ManufacturerId);
                MessageBox.Show("Manufacturer removed!");
                PanelHelper.SwapPanels(this.Parent, this, new ManufacturerList());

            }
        }
    }
}
