using eDentist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.TreatmentsMaterials
{
    public partial class TreatmentsMaterialsList : UserControl
    {
        private readonly APIService materialsService = new APIService("Materials");
        private readonly APIService manufacturerService = new APIService("Manufacturers");
        private readonly APIService treatmentsMaterialsService = new APIService("TreatmentsMaterials");
        private readonly APIService treatmentsService = new APIService("Treatments");

        public List<MMaterials> materials = new List<MMaterials>();
        public List<MTreatments> treatments = new List<MTreatments>();
        public List<MTreatmentsMaterials> trmntMat = new List<MTreatmentsMaterials>();


        public List<MaterialsManufacturers> result = new List<MaterialsManufacturers>();

        private MTreatments _selectedTreatment { get; set; }

        public TreatmentsMaterialsList()
        {
            InitializeComponent();
        }
        private async void TreatmentsMaterialsList_Load(object sender, EventArgs e)
        {
            await LoadList();

        }
        private async Task LoadList()
        {
            materials = await materialsService.Get<List<MMaterials>>(null);
            treatments = await treatmentsService.Get<List<MTreatments>>(null);
            trmntMat = await treatmentsMaterialsService.Get<List<MTreatmentsMaterials>>(null);

            menuTreatments.Items.AddRange(treatments.Select(x => x.Description).ToArray());

            //foreach (var item in materials)
            //{

            //    var manufacturer = await manufacturerService.GetById<MManufacturers>(item.ManufacturerId);
            //    MaterialsManufacturers resultObj = HandleData(item, manufacturer);
            //    result.Add(resultObj);
            //}

            //dvgMaterialsForTreatment.AutoGenerateColumns = false;
            //dvgMaterialsForTreatment.ReadOnly = true;
            //dvgMaterialsForTreatment.DataSource = result;
        }
        private static MaterialsManufacturers HandleData(MMaterials item, MManufacturers manufacturer)
        {
            var resultObj = new MaterialsManufacturers()
            {
                MaterialName = item.Name,
                Image = item.Image
            };

            if (manufacturer == null)
            {
                resultObj.ManufacturerName = "N/A";
            }
            else
            {
                resultObj.ManufacturerName = manufacturer.Name;
            }

            return resultObj;
        }



        private async void menuTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTreatment = treatments.FirstOrDefault(x => x.Description.Equals(menuTreatments.SelectedItem));
            var filtered = new List<MaterialsManufacturers>();
            foreach (var treatment in treatments)
            {
                if (treatment.Description.ToLower().Equals(_selectedTreatment.Description.ToLower()))
                {
                    foreach (var trmat in trmntMat)
                    {
                        if (trmat.TreatmentId.Equals(treatment.TreatmentId))
                        {
                            //var mat = await materialsService.GetById<MMaterials>(trmat.MaterialId);
                            var mat = materials.FirstOrDefault(x => x.MaterialId.Equals(trmat.MaterialId));
                            if (mat != null)
                            {

                                var man = await manufacturerService.GetById<MManufacturers>(mat.ManufacturerId);
                                var data = HandleData(mat, man);
                                filtered.Add(data);
                            }

                        }
                    }
                }
            }
            dvgMaterialsForTreatment.DataSource = filtered;
        }
    }
}
