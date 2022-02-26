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

namespace eDentist.WinUI.Forms.Treatments
{
    public partial class TreatmentAdd : UserControl
    {
        private readonly APIService service = new APIService("Treatments");
        public TreatmentAdd()
        {
            InitializeComponent();
        }

        private async void btnAddTreatment_Click(object sender, EventArgs e)
        {

            var request = new TreatmentsUpsertRequest()
            {
                Description = txtTreatment.Text
            };

            var treatments = await service.Get<List<MTreatments>>(null);

            foreach (var treatment in treatments)
            {
                if (treatment.Description.ToLower().Equals(request.Description.ToLower()))
                {
                    MessageBox.Show("Treatment already exists!");
                    return;
                }
            }
            await service.Insert<MTreatments>(request);
            MessageBox.Show("Treatment added!");
            PanelHelper.SwapPanels(this.Parent, this, new TreatmentList());
        }
    }
}
