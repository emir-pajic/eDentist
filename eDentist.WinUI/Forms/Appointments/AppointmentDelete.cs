using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentDelete : UserControl
    {
        private readonly APIService _appointmentService = new APIService("Appointments");
        private List<MAppointments> _appointments { get; set; }
        private MAppointments _selectedAppointment { get; set; }


        public AppointmentDelete()
        {
            InitializeComponent();
        }

        private async void AppointmentsDelete_LoadData(object sender, EventArgs e)
        {
            await AppointmentsDelete_Load();
        }

        private async Task AppointmentsDelete_Load()
        {
            _appointments = await _appointmentService.Get<List<MAppointments>>(null);

            foreach (var appointment in _appointments)
            {
                if (appointment.Date > DateTime.Now)
                {
                    menuAppointments.Items.Add(appointment.Date);
                }
            }
        }

        private void menuAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAppointment = _appointments.FirstOrDefault(x => x.Date.ToString().Equals(menuAppointments.SelectedItem.ToString()));
        }

        private async void btnRemoveAppointment_Click(object sender, EventArgs e)
        {
            if (_selectedAppointment == null)
            {
                MessageBox.Show("Please select an appointment to remove!");
            }
            else
            {
                await _appointmentService.Delete<MAppointments>(_selectedAppointment.AppointmentId);
                MessageBox.Show("Appointment removed!");
                PanelHelper.SwapPanels(this.Parent, this, new AppointmentList());

            }
        }
    }
}
