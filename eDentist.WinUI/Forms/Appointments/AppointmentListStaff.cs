using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentListStaff : UserControl
    {
        private readonly APIService service = new APIService("Appointments");
        private readonly APIService userService = new APIService("User");
        List<UsersAppointments> result = new List<UsersAppointments>();
        private MUsers _user;


        public AppointmentListStaff(MUsers user)
        {
            InitializeComponent();
            _user = user;
        }
        private async void AppointmentsList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearchApp.Focus();

        }
        private async Task LoadList()
        {
            var appointments = await service.Get<List<MAppointments>>(null);

            foreach (var item in appointments)
            {
                if (item.UserId != null)
                {

                    var user = await userService.GetById<MUsers>(item.UserId);

                    if (item.AppointmentStatus.Equals("Requested") && item.PreferedDoctorId == _user.UserId)
                    {

                        var resultObj = new UsersAppointments()
                        {
                            AppointmentId = item.AppointmentId,
                            Date = item.Date,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            AppointmentStatus = item.AppointmentStatus,
                        };
                        result.Add(resultObj);
                    }

                }
            }

            dgvAppointmentsStaff.AutoGenerateColumns = false;
            dgvAppointmentsStaff.ReadOnly = true;
            dgvAppointmentsStaff.DataSource = result;
        }




        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<UsersAppointments>();
            foreach (var item in result)
            {
                if (item.Date.ToString().Contains(txtSearchApp.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvAppointmentsStaff.DataSource = filtered;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new AppointmentStaffAccept(_user));

        }
    }
}

