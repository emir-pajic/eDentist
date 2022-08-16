using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentEdit : UserControl
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _appointmentService = new APIService("Appointments");

        private List<MAppointments> _appointments { get; set; }
        private MAppointments _selectedAppointment { get; set; }

        private List<MUsers> _users { get; set; }
        private MUsers _selectedUser { get; set; }



        public AppointmentEdit()
        {
            InitializeComponent();
        }
        private async void AppointmentEdit_LoadData(object sender, EventArgs e)
        {
            await AppointmentEdit_Load();
        }
        private async Task AppointmentEdit_Load()
        {
            _appointments = await _appointmentService.Get<List<MAppointments>>(null);
            editAppointmentUserMenu.Items.AddRange(_appointments.Where(x => x.Date.DayOfYear >= DateTime.Now.DayOfYear).Select(x => x.Date.ToString()).ToArray());



            _users = await _userService.Get<List<MUsers>>(null);
            foreach (var user in _users)
            {
                var userRoles = user.UserRoles.ToArray();

                if (userRoles[0].RoleId.Equals(2))
                {
                    var showName = user.FirstName + " " + user.LastName;
                    menuPatients.Items.Add(showName);
                }
            }
        }

        private void editAppointmentUserMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAppointment = _appointments.FirstOrDefault(x => x.Date.ToString().Equals(editAppointmentUserMenu.SelectedItem));
        }

        private void menuPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var splitted = menuPatients.SelectedItem.ToString().Split(' ');

            var firstName = splitted[0];
            var lastName = splitted[1];
            _selectedUser = _users.FirstOrDefault(x => x.FirstName.Equals(firstName) && x.LastName.Equals(lastName));
        }

        private async void btnAddAppointment_Click(object sender, EventArgs e)
        {

            if (ValidateInput(_selectedAppointment, _selectedUser, txtAppStatus.Text))
            {

                var request = new AppointmentsUpsertRequest()
                {
                    AppointmentId = _selectedAppointment.AppointmentId,
                    Date = dtpAppointment.Value,
                    UserId = _selectedUser.UserId,
                    DayId = _selectedAppointment.DayId,
                    Status = _selectedAppointment.Status,
                    AppointmentStatus = txtAppStatus.Text
                };

                await _appointmentService.Update<MAppointments>(request.AppointmentId, request);
                MessageBox.Show("Appointment updated!");
                PanelHelper.SwapPanels(this.Parent, this, new AppointmentList());
            }
        }

        private bool ValidateInput(MAppointments selected, MUsers patient, string appStatus)
        {
            if (selected == null)
            {
                MessageBox.Show("You must select an appointment to update!");
                return false;
            }
            if (patient == null)
            {
                MessageBox.Show("Patient must be selected!");
                return false;
            }
            if (string.IsNullOrEmpty(appStatus))
            {
                MessageBox.Show("Status can not be empty");
                return false;
            }
            return true;
        }
    }
}
