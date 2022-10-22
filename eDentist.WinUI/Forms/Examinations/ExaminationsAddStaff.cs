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
    public partial class ExaminationsAddStaff : UserControl
    {
        private readonly APIService _appointmentService = new APIService("Appointments");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _examinationService = new APIService("Examinations");
        private readonly APIService _treatmentsService = new APIService("Treatments");



        private List<MAppointments> _appointments { get; set; }
        private List<MTreatments> _treatments { get; set; }


        private MAppointments _selectedAppointment { get; set; }
        private MTreatments _selectedTreatment { get; set; }


        public MUsers _user { get; set; }
        public ExaminationsAddStaff(MUsers user)
        {
            _user = user;
            InitializeComponent();
        }

        private async void ExaminationsAddStaff_LoadData(object sender, EventArgs e)
        {
            await ExaminationsAdd_Load();
        }
        private async Task ExaminationsAdd_Load()
        {
            _appointments = await _appointmentService.Get<List<MAppointments>>(null);
            _treatments = await _treatmentsService.Get<List<MTreatments>>(null);
            treatmentsMenuStaff.Items.AddRange(_treatments.Select(x => x.Description).ToArray());

            foreach (var appointment in _appointments)
            {
                if (appointment.AcceptedById != null)
                {

                    if (appointment.AcceptedById == _user.UserId && appointment.Date <= DateTime.Now)

                    {

                        menuAppointmentsStaff.Items.Add(appointment.Date);
                    }
                }
            }

        }

        private void menuAppointmentsStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAppointment = _appointments.FirstOrDefault(x => x.Date.Equals(menuAppointmentsStaff.SelectedItem));

        }

        private void treatmentsMenuStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTreatment = _treatments.FirstOrDefault(x => x.Description.Equals(treatmentsMenuStaff.SelectedItem));
        }

        private async void btnaddExamination_Click(object sender, EventArgs e)
        {
            if (_selectedAppointment == null)
            {
                MessageBox.Show("Please select an appointment!");
                return;
            }
            if (_selectedTreatment == null)
            {
                MessageBox.Show("Please select a treatment!");
                return;
            }


            var request = new ExaminationUpsertRequest()
            {
                AppointmentId = _selectedAppointment.AppointmentId,
                AdditionalInfo = txtDescriptionStaff.Text,
                UserId = _user.UserId,
                Status = txtStatusStaff.Text,
                TreatmentId = _selectedTreatment.TreatmentId,
            };

            //TODO check if already exist the same

            await _examinationService.Insert<MExaminations>(request);
            MessageBox.Show("Examination added!");
            PanelHelper.SwapPanels(this.Parent, this, new ExaminationListStaff());
        }
    }
}