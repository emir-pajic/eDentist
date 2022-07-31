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
    public partial class ExaminationsAdd : UserControl
    {
        private readonly APIService _appointmentService = new APIService("Appointments");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _examinationService = new APIService("Examinations");
        private readonly APIService _treatmentsService = new APIService("Treatments");



        private List<MAppointments> _appointments { get; set; }
        private List<MUsers> _users { get; set; }
        private List<MTreatments> _treatments { get; set; }


        private MAppointments _selectedAppointment { get; set; }
        private MUsers _selectedUser { get; set; }
        private MTreatments _selectedTreatment { get; set; }




        public ExaminationsAdd()
        {
            InitializeComponent();
        }

        private async void ExaminationsAdd_LoadData(object sender, EventArgs e)
        {
            await ExaminationsAdd_Load();
        }

        private async Task ExaminationsAdd_Load()
        {
            _appointments = await _appointmentService.Get<List<MAppointments>>(null);
            _treatments = await _treatmentsService.Get<List<MTreatments>>(null);
            treatmentsMenu.Items.AddRange(_treatments.Select(x => x.Description).ToArray());

            foreach (var appointment in _appointments)
            {
                if (appointment.Date < DateTime.Now)
                {

                    menuAppointments.Items.Add(appointment.Date);
                }
            }

            _users = await _userService.Get<List<MUsers>>(null);

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

        private void menuAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAppointment = _appointments.FirstOrDefault(x => x.Date.Equals(menuAppointments.SelectedItem));
        }

        private void menuDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var splitted = menuDoctors.SelectedItem.ToString().Split(' ');

            var firstName = splitted[0];
            var lastName = splitted[1];
            _selectedUser = _users.FirstOrDefault(x => x.FirstName.Equals(firstName) && x.LastName.Equals(lastName));
        }

        private async void btnaddCity_Click(object sender, EventArgs e)
        {
            if (_selectedTreatment == null)
            {
                MessageBox.Show("Please select a treatment!");
                return;
            }
            var request = new ExaminationUpsertRequest()
            {
                AppointmentId = _selectedAppointment.AppointmentId,
                AdditionalInfo = txtDescription.Text,
                UserId = _selectedUser.UserId,
                Status = txtStatus.Text,
                TreatmentId = _selectedTreatment.TreatmentId,
            };

            //TODO check if already exist the same

            await _examinationService.Insert<MExaminations>(request);
            MessageBox.Show("Examination added!");
            PanelHelper.SwapPanels(this.Parent, this, new ExaminationList());
        }

        private void treatmentsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTreatment = _treatments.FirstOrDefault(x => x.Description.Equals(treatmentsMenu.SelectedItem));
        }
    }
}
