using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Forms.TreatmentsMaterials;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Treatments
{
    public partial class TreatmentList : UserControl
    {
        private readonly APIService service = new APIService("Treatments");

        public List<MTreatments> result = new List<MTreatments>();

        public TreatmentList()
        {
            InitializeComponent();
        }

        private async void TreatmentsList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearch.Focus();

        }
        private async Task LoadList()
        {
            result = await service.Get<List<MTreatments>>(null);

            dgvTreatments.AutoGenerateColumns = false;
            dgvTreatments.ReadOnly = true;
            dgvTreatments.DataSource = result;
        }
        private async Task LoadList(TreatmentSearchRequest request)
        {
            var result = await service.Get<List<TreatmentSearchRequest>>(request);

            dgvTreatments.AutoGenerateColumns = false;
            dgvTreatments.ReadOnly = true;
            dgvTreatments.DataSource = result;
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new TreatmentAdd());
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new TreatmentEdit());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new TreatmentDelete());

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<MTreatments>();
            foreach (var item in result)
            {
                if (item.Description.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvTreatments.DataSource = filtered;
        }

        private void btnAddTreatmentMaterials_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new AddTreatmentsMaterials());
        }
    }
}
