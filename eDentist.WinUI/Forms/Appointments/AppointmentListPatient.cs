using eDentist.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentListPatient : UserControl
    {
        private readonly APIService service = new APIService("Appointments");
        List<UsersAppointments> result = new List<UsersAppointments>();
        private MUsers _user;

        public AppointmentListPatient(MUsers user)
        {
            InitializeComponent();
            _user = user;
        }
        private async void AppointmentListPatient_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearchApp.Focus();

        }
        private async Task LoadList()
        {
            var appointments = await service.Get<List<MAppointments>>(null);

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
                    result.Add(resultObj);
                }
            }

            dgvAppointmentsPatient.AutoGenerateColumns = false;
            dgvAppointmentsPatient.ReadOnly = true;
            dgvAppointmentsPatient.DataSource = result;
        }

        private void txtSearchApp_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<UsersAppointments>();
            foreach (var item in result)
            {
                if (item.Date.ToString().Contains(txtSearchApp.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvAppointmentsPatient.DataSource = filtered;
        }
    }
}
