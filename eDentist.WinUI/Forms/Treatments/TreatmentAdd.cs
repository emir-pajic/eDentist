using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
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
            var price = 0;
            if (String.IsNullOrEmpty(txtTreatment.Text))
            {
                MessageBox.Show("Treatment can't be empty!");
                return;
            }
            if (int.TryParse(txtPrice.Text, out price))
            {
                price = Convert.ToInt32(txtPrice.Text);
            }

            else
            {
                MessageBox.Show("Price must be numeric value!");
                return;
            }


            var request = new TreatmentsUpsertRequest()
            {
                Description = txtTreatment.Text,
                Price = price
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
