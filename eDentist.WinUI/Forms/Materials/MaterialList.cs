﻿using eDentist.Model;
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

namespace eDentist.WinUI.Forms.Materials
{
    public partial class MaterialList : UserControl
    {
        private readonly APIService service = new APIService("Materials");
        private readonly APIService manufacturerService = new APIService("Manufacturers");

        public MaterialList()
        {
            InitializeComponent();
        }

        private async void MaterialsList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var materials = await service.Get<List<MMaterials>>(null);

            List<MaterialsManufacturers> result = new List<MaterialsManufacturers>();

            foreach (var item in materials)
            {
                var manufacturer =await manufacturerService.GetById<MManufacturers>(item.ManufacturerId);

                var resultObj = new MaterialsManufacturers()
                {
                    ManufacturerName = manufacturer.Name,
                    MaterialName = item.Name
                };
                result.Add(resultObj);
            }

            dvgMaterials.AutoGenerateColumns = false;
            dvgMaterials.ReadOnly = true;
            dvgMaterials.DataSource = result;
        }
        private async Task LoadList(MaterialsSearchRequest request)
        {
            var materials = await service.Get<List<MMaterials>>(null);

            List<MaterialsManufacturers> result = new List<MaterialsManufacturers>();

            foreach (var item in materials)
            {
                var manufacturer = await manufacturerService.GetById<MManufacturers>(item.ManufacturerId);

                var resultObj = new MaterialsManufacturers()
                {
                    ManufacturerName = manufacturer.Name,
                    MaterialName = item.Name
                };
                result.Add(resultObj);
            }

            dvgMaterials.AutoGenerateColumns = false;
            dvgMaterials.ReadOnly = true;
            dvgMaterials.DataSource = result;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new MaterialsAdd());
        }
    }
}