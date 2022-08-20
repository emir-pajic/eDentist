using eDentist.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentsReport : UserControl
    {
        private readonly APIService service = new APIService("Appointments");
        private readonly APIService userService = new APIService("User");
        List<UsersAppointments> result = new List<UsersAppointments>();

        private MUsers _user { get; set; }

        public AppointmentsReport(MUsers user)
        {
            InitializeComponent();
            _user = user;
        }
        private async void AppointmentsReport_Load(object sender, EventArgs e)
        {
            await LoadList();

        }
        private async Task LoadList()
        {
            var appointments = await service.Get<List<MAppointments>>(null);

            foreach (var item in appointments)
            {
                if (item.UserId != null)
                {

                    var user = await userService.GetById<MUsers>(item.UserId);

                    {
                        if (item.AcceptedById != null && item.AcceptedById == _user.UserId)
                        {

                            var resultObj = new UsersAppointments()
                            {
                                Date = item.Date,
                                Doctor = _user.FirstName + " " + _user.LastName,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                AppointmentStatus = item.AppointmentStatus,
                            };
                            result.Add(resultObj);
                        }
                    }

                }
            }

            ReportDataSource ds = new ReportDataSource("AppDataSet", result);
            reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.RefreshReport();
        }


    }
}
