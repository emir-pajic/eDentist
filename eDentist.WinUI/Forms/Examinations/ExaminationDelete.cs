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

namespace eDentist.WinUI.Forms.Examinations
{
    public partial class ExaminationDelete : UserControl
    {
        private readonly APIService _examinationService = new APIService("Examinations");
        private readonly APIService _appointmentService = new APIService("Appointments");
        private readonly APIService _userService = new APIService("User");



        private List<MExaminations> _existingExaminations { get; set; }
        private List<MAppointments> _appointments { get; set; }
        private List<MUsers> _users { get; set; }



        private MExaminations _selectedExamination { get; set; }

        public ExaminationDelete()
        {
            InitializeComponent();
        }
        private async void ExaminationsDelete_LoadData(object sender, EventArgs e)
        {
            await ExaminationsDelete_Load();
        }

        private async Task ExaminationsDelete_Load()
        {
            _existingExaminations = await _examinationService.Get<List<MExaminations>>(null);
            _appointments = await _appointmentService.Get<List<MAppointments>>(null);
            _users = await _userService.Get<List<MUsers>>(null);
            FillExaminationData();

        }
        private void FillExaminationData()
        {
            foreach (var examination in _existingExaminations)
            {

                foreach (var appointment in _appointments)
                {
                    if (examination.AppointmentId == appointment.AppointmentId)
                    {
                        var doctor = _users.FirstOrDefault(x => x.UserId.Equals(examination.UserId));
                        var patient = _users.FirstOrDefault(x => x.UserId.Equals(appointment.UserId));

                        menuExaminations.Items.Add(appointment.Date + "-" + patient.FirstName + " " + patient.LastName + "-" + doctor.FirstName + " " + doctor.LastName + "-" + examination.AdditionalInfo);

                    }
                }
            }
        }

        private void menuExaminations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var examinationData = menuExaminations.SelectedItem.ToString().Split('-');
            var examinationAppointmentDate = examinationData[0];

            var patientData = examinationData[1].ToString().Split(' ');
            var doctorData = examinationData[2].ToString().Split(' ');

            var examinationDescription = examinationData[3];

            MUsers doctor = _users.FirstOrDefault(x => x.FirstName.Equals(doctorData[0]) && x.LastName.Equals(doctorData[1]));
            MUsers patient = _users.FirstOrDefault(x => x.FirstName.Equals(patientData[0]) && x.LastName.Equals(patientData[1]));
            MAppointments appointment = _appointments.FirstOrDefault(x => x.Date.ToString().Equals(examinationAppointmentDate));

            _selectedExamination = _existingExaminations.FirstOrDefault(x => x.AppointmentId == appointment.AppointmentId && x.UserId == doctor.UserId);
        }

        private async void btnRemoveExamination_Click(object sender, EventArgs e)
        {
            if (_selectedExamination == null)
            {
                MessageBox.Show("Please select an examination to remove!");
            }
            else
            {
                await _examinationService.Delete<MExaminations>(_selectedExamination.ExaminationId);
                MessageBox.Show("Examination removed!");
                PanelHelper.SwapPanels(this.Parent, this, new ExaminationListStaff());

            }
        }
    }
}
