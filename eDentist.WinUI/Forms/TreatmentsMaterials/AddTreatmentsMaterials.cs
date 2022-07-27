using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Forms.Treatments;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.TreatmentsMaterials
{
    public partial class AddTreatmentsMaterials : UserControl
    {
        private readonly APIService service = new APIService("Treatments");
        private readonly APIService _materialsService = new APIService("Materials");
        private readonly APIService trmtService = new APIService("TreatmentsMaterials");



        private List<MTreatments> _existingTreatments { get; set; }
        private MTreatments _selectedTreatment { get; set; }

        private List<MMaterials> _existingMaterials { get; set; }
        private MMaterials _selectedMaterial { get; set; }


        public AddTreatmentsMaterials()
        {
            InitializeComponent();
        }
        private async void AddTreatmentsMaterials_LoadData(object sender, EventArgs e)
        {
            await AddTreatmentsMaterialsLoad();
        }
        private async Task AddTreatmentsMaterialsLoad()
        {
            _existingTreatments = await service.Get<List<MTreatments>>(null);
            menuTreatments.Items.AddRange(_existingTreatments.Select(x => x.Description).ToArray());

            _existingMaterials = await _materialsService.Get<List<MMaterials>>(null);
            menuMaterials.Items.AddRange(_existingMaterials.Select(x => x.Name).ToArray());
        }

        private void menuTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTreatment = _existingTreatments.FirstOrDefault(x => x.Description.Equals(menuTreatments.SelectedItem));
        }

        private void menuMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMaterial = _existingMaterials.FirstOrDefault(x => x.Name.Equals(menuMaterials.SelectedItem));

        }

        private async void btnAddMaterialForTreatment_Click(object sender, EventArgs e)
        {

            if (_selectedMaterial == null)
            {
                MessageBox.Show("Please select material to update!");
                return;
            }
            if (_selectedTreatment == null)
            {
                MessageBox.Show("Please select treatment to update!");
                return;
            }

            var request = new TreatmentsMaterialsUpsertRequest()
            {
                MaterialId = _selectedMaterial.MaterialId,
                TreatmentId = _selectedTreatment.TreatmentId
            };

            await trmtService.Insert<MTreatmentsMaterials>(request);
            MessageBox.Show("Added material required for a treatment!");
            PanelHelper.SwapPanels(this.Parent, this, new TreatmentList());
        }
    }
}
