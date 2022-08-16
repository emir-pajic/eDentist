using eDentist.Model;
using eDentist.Model.Request;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentAddPatient : UserControl
    {
        private readonly APIService _appointmentService = new APIService("Appointments");

        private MUsers _user { get; set; }

        public AppointmentAddPatient(MUsers user)
        {
            _user = user;
            InitializeComponent();
        }

        private async void btnAddAppointmentPatient_Click(object sender, System.EventArgs e)
        {
            var request = new AppointmentsUpsertRequest()
            {
                Date = dtpAppointmentPatient.Value,
                UserId = _user.UserId,
                AppointmentStatus = "Requested"
            };

            await _appointmentService.Insert<MAppointments>(request);
            MessageBox.Show("Appointment requested!");
            //PanelHelper.SwapPanels(this.Parent, this, new AppointmentList());
        }
    }
}
