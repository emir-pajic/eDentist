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

namespace eDentist.WinUI.Forms.Examinations
{
    public partial class ExaminationList : UserControl
    {
        private readonly APIService service = new APIService("Examinations");
        private readonly APIService userService = new APIService("User");
        private readonly APIService appointmentService = new APIService("Appointments");

        public ExaminationList()
        {
            InitializeComponent();
        }

        private async void ExaminationsList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var examinations = await service.Get<List<MExaminations>>(null);
            List<Examination> result = new List<Examination>();

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
    }
}
