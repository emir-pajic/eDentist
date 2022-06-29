using eDentist.Model;
using eDentist.Model.Request;
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

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentList : UserControl
    {
        private readonly APIService service = new APIService("Appointments");
        private readonly APIService userService = new APIService("User");

        public AppointmentList()
        {
            InitializeComponent();
        }
        private async void AppointmentsList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var appointments = await service.Get<List<MAppointments>>(null);
            List<UsersAppointments> result = new List<UsersAppointments>();

            foreach (var item in appointments)
            {
                var user = await userService.GetById<MUsers>(item.UserId);

                var resultObj = new UsersAppointments()
                {
                    Date = item.Date,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Status = item.Status
                };

                result.Add(resultObj);

                
            }

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.DataSource = result;
        }
        private async Task LoadList(AppointmentsSearchRequest request)
        {
            var result = await service.Get<List<AppointmentsSearchRequest>>(request);

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.DataSource = result;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new AppointmentAdd());

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new AppointmentEdit());

        }
    }
}
