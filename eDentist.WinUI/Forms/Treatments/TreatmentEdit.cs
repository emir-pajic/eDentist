using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Treatments
{
    public partial class TreatmentEdit : UserControl
    {
        private readonly APIService service = new APIService("Treatments");
        private List<MTreatments> _existingTreatments { get; set; }
        private MTreatments _selectedTreatment { get; set; }

        public TreatmentEdit()
        {
            InitializeComponent();
        }
        private async void TreatmentsEdit_LoadData(object sender, EventArgs e)
        {
            await TreatmentsEditLoad();
        }
        private async Task TreatmentsEditLoad()
        {
            _existingTreatments = await service.Get<List<MTreatments>>(null);
            menuTreatments.Items.AddRange(_existingTreatments.Select(x => x.Description).ToArray());
        }

        private void menuTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTreatment = _existingTreatments.FirstOrDefault(x => x.Description.Equals(menuTreatments.SelectedItem));
            txtTreatment.Text = _selectedTreatment.Description;
        }

        private async void btnUpdateTreatment_Click(object sender, EventArgs e)
        {
            if (ValidateInput(_selectedTreatment, txtTreatment.Text))
            {
                var request = new TreatmentsUpsertRequest()
                {
                    TreatmentId = _selectedTreatment.TreatmentId,
                    Description = txtTreatment.Text
                };
                await service.Update<MTreatments>(_selectedTreatment.TreatmentId, request);
                MessageBox.Show("Treatment updated!");
                PanelHelper.SwapPanels(this.Parent, this, new TreatmentList());
            }
        }

        private bool ValidateInput(MTreatments selected, string description)
        {
            if (selected == null)
            {
                MessageBox.Show("Please select a treatment to edit!");
                return false;
            }
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Treatment description can not be empty!");
                return false;
            }
            return true;
        }
    }
}
