﻿using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Materials
{
    public partial class MaterialsAdd : UserControl
    {
        private readonly APIService _manufacturerService = new APIService("Manufacturers");
        private readonly APIService _materialsService = new APIService("Materials");

        private List<MManufacturers> _manufacturers { get; set; }
        private MManufacturers _selectedManufacturer { get; set; }
        public MaterialsAdd()
        {
            InitializeComponent();
        }

        private async void MaterialsAdd_LoadManufacturers(object sender, EventArgs e)
        {
            await ManufcaturerAdd_Load();
        }

        private async Task ManufcaturerAdd_Load()
        {
            _manufacturers = await _manufacturerService.Get<List<MManufacturers>>(null);
            menuManufacturers.Items.AddRange(_manufacturers.Select(x => x.Name).ToArray());
        }

        private void menuManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedManufacturer = _manufacturers.FirstOrDefault(x => x.Name.Equals(menuManufacturers.SelectedItem));
        }

        private async void btnAddMaterial_Click(object sender, EventArgs e)
        {
            Byte[] imgBytes = null;
            ImageConverter imgConverter = new ImageConverter();
            imgBytes = (System.Byte[])imgConverter.ConvertTo(materialImage.Image, Type.GetType("System.Byte[]"));


            if (imgBytes.Length == 0)
            {
                MessageBox.Show("Please add a material image!");
                return;
            }

            var request = new MaterialsUpsertRequest()
            {
                Name = txtMaterial.Text,
                ManufacturerId = _selectedManufacturer.ManufacturerId,
                Image = imgBytes
            };

            var materials = await _materialsService.Get<List<MMaterials>>(null);

            foreach (var material in materials)
            {
                if (material.Name.ToLower().Equals(request.Name.ToLower()) && material.ManufacturerId.Equals(_selectedManufacturer.ManufacturerId))
                {
                    MessageBox.Show("Material already exists from the same manufacturer!");
                    return;
                }
            }

            await _materialsService.Insert<MMaterials>(request);
            MessageBox.Show("Material added!");
            PanelHelper.SwapPanels(this.Parent, this, new MaterialList());
        }

        private void materialImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                materialImage.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
