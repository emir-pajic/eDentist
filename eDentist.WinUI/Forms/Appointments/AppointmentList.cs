using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentList : UserControl
    {
        private readonly APIService service = new APIService("Appointments");
        private readonly APIService userService = new APIService("User");
        List<UsersAppointments> result = new List<UsersAppointments>();


        public AppointmentList()
        {
            InitializeComponent();
        }
        private async void AppointmentsList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearch.Focus();

        }
        private async Task LoadList()
        {
            var appointments = await service.Get<List<MAppointments>>(null);

            foreach (var item in appointments)
            {
                if (item.UserId != null)
                {

                    var user = await userService.GetById<MUsers>(item.UserId);

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

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.DataSource = result;
        }


        private void btnDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new AppointmentEdit());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new AppointmentDelete());

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<UsersAppointments>();
            foreach (var item in result)
            {
                if (item.Date.ToString().Contains(txtSearch.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvAppointments.DataSource = filtered;
        }
    }
}
