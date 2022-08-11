using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentAdd : UserControl
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _appointmentService = new APIService("Appointments");

        private List<MUsers> _users { get; set; }
        private MUsers _selectedUser { get; set; }




        public AppointmentAdd()
        {
            InitializeComponent();
        }
        private async void AppointmentAdd_LoadData(object sender, EventArgs e)
        {
            await AppointmentAdd_Load();
        }

        private async Task AppointmentAdd_Load()
        {
            _users = await _userService.Get<List<MUsers>>(null);
            foreach (var user in _users)
            {
                var userRoles = user.UserRoles.ToArray();

                if (userRoles[0].RoleId.Equals(2))
                {
                    var showName = user.FirstName + " " + user.LastName;
                    addAppointmentUserMenu.Items.Add(showName);
                }
            }


        }

        private void addAppointmentUserMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var splitted = addAppointmentUserMenu.SelectedItem.ToString().Split(' ');

            var firstName = splitted[0];
            var lastName = splitted[1];
            _selectedUser = _users.FirstOrDefault(x => x.FirstName.Equals(firstName) && x.LastName.Equals(lastName));
        }

        private async void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var request = new AppointmentsUpsertRequest()
            {
                Date = dtpAppointment.Value,
                UserId = _selectedUser.UserId
            };

            await _appointmentService.Insert<MAppointments>(request);
            MessageBox.Show("Appointment added!");
            PanelHelper.SwapPanels(this.Parent, this, new AppointmentList());
        }
    }
}
