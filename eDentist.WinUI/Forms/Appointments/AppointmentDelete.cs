using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentDelete : UserControl
    {
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


        }
    }
}
