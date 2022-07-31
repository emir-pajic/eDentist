using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Examinations
{
    public partial class ExaminationList : UserControl
    {
        private readonly APIService service = new APIService("Examinations");
        private readonly APIService userService = new APIService("User");
        private readonly APIService appointmentService = new APIService("Appointments");
        private readonly APIService treatmentService = new APIService("Treatments");

        public List<Examination> result = new List<Examination>();

        public ExaminationList()
        {
            InitializeComponent();
        }

        private async void ExaminationsList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearch.Focus();

        }
        private async Task LoadList()
        {
            var examinations = await service.Get<List<MExaminations>>(null);


            foreach (var item in examinations)
            {
                var appointment = await appointmentService.GetById<MAppointments>(item.AppointmentId);
                var doctor = await userService.GetById<MUsers>(item.UserId);
                var patient = await userService.GetById<MUsers>(appointment.UserId);



                var resultObj = new Examination()
                {
                    Description = item.AdditionalInfo,
                    AppointmentDate = appointment.Date,
                    Patient = patient.FirstName + " " + patient.LastName,
                    Doctor = doctor.FirstName + " " + doctor.LastName,
                    Status = item.Status
                };

                if (item.TreatmentId == null)
                {
                    resultObj.Treatment = "N/A";
                }
                else
                {
                    var treatment = await treatmentService.GetById<MTreatments>(item.TreatmentId);
                    resultObj.Treatment = treatment.Description;
                }

                result.Add(resultObj);
            }

            dgvExaminations.AutoGenerateColumns = false;
            dgvExaminations.ReadOnly = true;
            dgvExaminations.DataSource = result;
        }
        private async Task LoadList(ExaminationsSearchRequest request)
        {
            var result = await service.Get<List<ExaminationsSearchRequest>>(request);

            dgvExaminations.AutoGenerateColumns = false;
            dgvExaminations.ReadOnly = true;
            dgvExaminations.DataSource = result;
        }

        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ExaminationsAdd());
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ExaminationEdit());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ExaminationDelete());

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<Examination>();
            foreach (var item in result)
            {
                if (item.Description.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvExaminations.DataSource = filtered;
        }
    }
}
