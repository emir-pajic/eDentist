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
        private readonly APIService _userService = new APIService("User");

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
                var resultObj = new UsersAppointments();
                if (item.UserId == _user.UserId)
                {

                    resultObj.AppointmentId = item.AppointmentId;
                    resultObj.Date = item.Date;
                    resultObj.FirstName = _user.FirstName;
                    resultObj.LastName = _user.LastName;
                    resultObj.AppointmentStatus = item.AppointmentStatus;
                    resultObj.Doctor = "N/A";
                };

                if (item.AcceptedById != null)
                {
                    var doc = await _userService.GetById<MUsers>(item.AcceptedById);

                    if (doc != null)
                    {
                        resultObj.Doctor = doc.FirstName + " " + doc.LastName;
                    }
                }

                result.Add(resultObj);
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
