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

namespace eDentist.WinUI.Forms.Treatments
{
    public partial class TreatmentDelete : UserControl
    {
        private readonly APIService service = new APIService("Treatments");
        private List<MTreatments> _existingTreatments { get; set; }
        private MTreatments _selectedTreatment { get; set; }
        public TreatmentDelete()
        {
            InitializeComponent();
        }
        private async void TreatmentsDelete_LoadData(object sender, EventArgs e)
        {
            await TreatmentsDeleteLoad();
        }
        private async Task TreatmentsDeleteLoad()
        {
            _existingTreatments = await service.Get<List<MTreatments>>(null);
            menuTreatments.Items.AddRange(_existingTreatments.Select(x => x.Description).ToArray());
        }

        private void menuTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTreatment = _existingTreatments.FirstOrDefault(x => x.Description.Equals(menuTreatments.SelectedItem));
        }

        private async void btnRemoveTreatment_Click(object sender, EventArgs e)
        {
            {
                if (_selectedTreatment == null)
                {
                    MessageBox.Show("Please select a treatment to remove!");
                }
                else
                {
                    await service.Delete<MTreatments>(_selectedTreatment.TreatmentId);
                    MessageBox.Show("Material removed!");
                    PanelHelper.SwapPanels(this.Parent, this, new TreatmentList());

                }
            }
        }
    }
}
