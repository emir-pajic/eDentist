using eDentist.Model;
using eDentist.Model.Request;
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
            var result = await service.Get<List<MAppointments>>(null);

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

    }
}
