using eDentist.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Examinations
{
    public partial class ExaminationListPatient : UserControl
    {
        private readonly APIService service = new APIService("Examinations");
        private readonly APIService userService = new APIService("User");
        private readonly APIService appointmentService = new APIService("Appointments");
        private readonly APIService treatmentService = new APIService("Treatments");

        public List<Examination> result = new List<Examination>();
        List<UsersAppointments> listAppointments = new List<UsersAppointments>();


        private MUsers _user;
        public ExaminationListPatient(MUsers user)
        {
            InitializeComponent();
            _user = user;
        }

        private async void ExaminationListPatient_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearchPatient.Focus();

        }
        private async Task LoadList()
        {
            var appointments = await appointmentService.Get<List<MAppointments>>(null);

            var examinations = await service.Get<List<MExaminations>>(null);
            foreach (var item in appointments)
            {
                if (item.UserId == _user.UserId)
                {

                    var resultObj = new UsersAppointments()
                    {
                        AppointmentId = item.AppointmentId,
                        Date = item.Date,
                        FirstName = _user.FirstName,
                        LastName = _user.LastName,
                        Status = item.Status
                    };
                    listAppointments.Add(resultObj);
                }
            }

            foreach (var item in examinations)
            {

                foreach (var app in listAppointments)
                {
                    if (app.AppointmentId.Equals(item.AppointmentId))
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
                }


            }

            dgvExaminationsPatient.AutoGenerateColumns = false;
            dgvExaminationsPatient.ReadOnly = true;
            dgvExaminationsPatient.DataSource = result;
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<Examination>();
            foreach (var item in result)
            {
                if (item.Description.ToLower().Contains(txtSearchPatient.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvExaminationsPatient.DataSource = filtered;
        }
    }
}
