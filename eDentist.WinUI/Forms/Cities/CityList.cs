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

namespace eDentist.WinUI.Forms.Cities
{
    public partial class CityList : UserControl
    {
        private readonly APIService service = new APIService("Cities");
        private readonly APIService countryService = new APIService("Countries");

        public CityList()
        {
            InitializeComponent();
        }
        private async void CitiesList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            List<CitiesCountries> result = new List<CitiesCountries>();

            var cities = await service.Get<List<MCities>>(null);

            foreach (var item in cities)
            {
                var country = await countryService.GetById<MCountries>(item.CountryId);

                var resultObj = new CitiesCountries()
                {
                    CityName = item.CityName,
                    CountryName = country.CountryName
                };
                result.Add(resultObj);
            }


            dgvCities.AutoGenerateColumns = false;
            dgvCities.ReadOnly = true;
            dgvCities.DataSource = result;
        }
        private async Task LoadList(CitiesSearchRequest request)
        {
            var result = await service.Get<List<CitiesSearchRequest>>(request);

            dgvCities.AutoGenerateColumns = false;
            dgvCities.ReadOnly = true;
            dgvCities.DataSource = result;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new CityAdd());
        }
    }
}