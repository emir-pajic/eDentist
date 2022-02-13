using eDentist.Model;
using eDentist.Model.Request;
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
    public partial class TreatmentList : UserControl
    {
        private readonly APIService service = new APIService("Treatments");
        public TreatmentList()
        {
            InitializeComponent();
        }

        private async void TreatmentsList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var result = await service.Get<List<MTreatments>>(null);

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
    }
}
