using eDentist.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentListStaffMy : UserControl
    {
        public MUsers _user { get; set; }
        private readonly APIService service = new APIService("Appointments");
        private readonly APIService userService = new APIService("User");
        List<UsersAppointments> result = new List<UsersAppointments>();

        public AppointmentListStaffMy(MUsers user)
        {
            _user = user;
            InitializeComponent();
        }
        private async void AppointmentsListStaffMy_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearchMyApp.Focus();

        }
        private async Task LoadList()
        {
            var appointments = await service.Get<List<MAppointments>>(null);

            foreach (var item in appointments)
            {
                if (item.UserId != null)
                {

                    var user = await userService.GetById<MUsers>(item.UserId);

                    if (item.AppointmentStatus.Equals("Accepted") && item.Date.DayOfYear >= DateTime.Now.DayOfYear)
                    {
                        if (item.AcceptedById != null && item.AcceptedById == _user.UserId)
                        {

                            var resultObj = new UsersAppointments()
                            {
                                AppointmentId = item.AppointmentId,
                                Date = item.Date,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                            };
                            result.Add(resultObj);
                        }
                    }

                }
            }

            dgvAppointmentsStaffMy.AutoGenerateColumns = false;
            dgvAppointmentsStaffMy.ReadOnly = true;
            dgvAppointmentsStaffMy.DataSource = result;
        }

        private void txtSearchMyApp_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<UsersAppointments>();
            foreach (var item in result)
            {
                if (item.Date.ToString().Contains(txtSearchMyApp.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvAppointmentsStaffMy.DataSource = filtered;
        }
    }
}
