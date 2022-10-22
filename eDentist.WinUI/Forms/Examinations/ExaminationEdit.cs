using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Examinations
{
    public partial class ExaminationEdit : UserControl
    {
        private readonly APIService _appointmentService = new APIService("Appointments");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _examinationService = new APIService("Examinations");
        private readonly APIService _treatmentsService = new APIService("Treatments");


        private List<MAppointments> _appointments { get; set; }
        private List<MExaminations> _existingExamination { get; set; }

        private List<MTreatments> _treatments { get; set; }
        private MTreatments _selectedTreatment { get; set; }


        private List<MUsers> _users { get; set; }

        private MExaminations _selectedExamination { get; set; }

        private MUsers _newDoctor { get; set; }
        public ExaminationEdit()
        {
            InitializeComponent();
        }
        private async void ExaminationsEdit_LoadData(object sender, EventArgs e)
        {
            await ExaminationsEdit_Load();
        }

        private async Task ExaminationsEdit_Load()
        {

            _existingExamination = await _examinationService.Get<List<MExaminations>>(null);
            _appointments = await _appointmentService.Get<List<MAppointments>>(null);
            _users = await _userService.Get<List<MUsers>>(null);

            _treatments = await _treatmentsService.Get<List<MTreatments>>(null);
            treatmentsMenu.Items.AddRange(_treatments.Select(x => x.Description).ToArray());

            FillExaminationData();
            FillDoctorsData();
        }

        private void FillDoctorsData()
        {
            foreach (var user in _users)
            {
                var userRoles = user.UserRoles.ToArray();

                if (userRoles[0].RoleId.Equals(3))
                {
                    var showName = user.FirstName + " " + user.LastName;
                    menuDoctors.Items.Add(showName);
                }
            }
        }



        private void FillExaminationData()
        {
            foreach (var examination in _existingExamination)
            {

                foreach (var appointment in _appointments)
                {
                    if (examination.AppointmentId == appointment.AppointmentId)
                    {
                        var doctor = _users.FirstOrDefault(x => x.UserId.Equals(examination.UserId));
                        var patient = _users.FirstOrDefault(x => x.UserId.Equals(appointment.UserId));

                        if (doctor == null || patient == null) continue;
                        existingExaminations.Items.Add(appointment.Date + "-" + patient.FirstName + " " + patient.LastName + "-" + doctor.FirstName + " " + doctor.LastName + "-" + examination.AdditionalInfo);

                    }
                }
            }
        }

        private void existingExaminations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var examinationData = existingExaminations.SelectedItem.ToString().Split('-');
            var examinationAppointmentDate = examinationData[0];

            var patientData = examinationData[1].ToString().Split(' ');
            var doctorData = examinationData[2].ToString().Split(' ');

            var examinationDescription = examinationData[3];

            MUsers doctor = _users.FirstOrDefault(x => x.FirstName.Equals(doctorData[0]) && x.LastName.Equals(doctorData[1]));
            MUsers patient = _users.FirstOrDefault(x => x.FirstName.Equals(patientData[0]) && x.LastName.Equals(patientData[1]));
            MAppointments appointment = _appointments.FirstOrDefault(x => x.Date.ToString().Equals(examinationAppointmentDate));

            _selectedExamination = _existingExamination.FirstOrDefault(x => x.AppointmentId == appointment.AppointmentId && x.UserId == doctor.UserId);




        }

        private void menuDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doctorData = menuDoctors.SelectedItem.ToString().Split(' ');
            _newDoctor = _users.FirstOrDefault(x => x.FirstName.Equals(doctorData[0]) && x.LastName.Equals(doctorData[1]));

        }

        private async void btnUpdateExamination_Click(object sender, EventArgs e)
        {

            if (ValidateInput(_selectedExamination, _newDoctor, txtDescription.Text))
            {
                var request = new ExaminationUpsertRequest()
                {
                    ExaminationId = _selectedExamination.ExaminationId,
                    AppointmentId = _selectedExamination.AppointmentId,
                    AdditionalInfo = txtDescription.Text,
                    UserId = _newDoctor.UserId,
                    Status = txtStatus.Text,
                    TreatmentId = _selectedTreatment.TreatmentId
                };

                await _examinationService.Update<MExaminations>(_selectedExamination.ExaminationId, request);
                MessageBox.Show("Examination updated!");
                PanelHelper.SwapPanels(this.Parent, this, new ExaminationListStaff());
            }


        }

        private bool ValidateInput(MExaminations selected, MUsers doctor, string description)
        {
            if (selected == null)
            {
                MessageBox.Show("You must select an examination to update!");
                return false;
            }
            if (doctor == null)
            {
                MessageBox.Show("You must assign a doctor to a examination!");
                return false;
            }
            if (_selectedTreatment == null)
            {
                MessageBox.Show("You must select a treatment");
                return false;
            }
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Examination description can not be emptry!");
                return false;
            }


            return true;
        }

        private void treatmentsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTreatment = _treatments.FirstOrDefault(x => x.Description.Equals(treatmentsMenu.SelectedItem));
        }
    }
}
