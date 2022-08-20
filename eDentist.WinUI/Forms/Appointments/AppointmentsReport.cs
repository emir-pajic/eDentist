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
        List<UsersAppointments> filtered = new List<UsersAppointments>();
        List<MAppointments> appointments = new List<MAppointments>();



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
            appointments = await service.Get<List<MAppointments>>(null);



        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            result.Clear();

            TimeSpan fromBeginningOfTheDay = new TimeSpan(00, 00, 0);
            dtpFrom.Value = dtpFrom.Value.Date + fromBeginningOfTheDay;

            TimeSpan UntilEndOfTheDay = new TimeSpan(23, 59, 59);
            dtpTo.Value = dtpTo.Value.Date + UntilEndOfTheDay;
            foreach (var item in appointments)
            {
                if (item.UserId != null)
                {

                    var user = await userService.GetById<MUsers>(item.UserId);

                    {
                        if (item.AcceptedById != null && item.AcceptedById == _user.UserId && item.Date >= dtpFrom.Value && item.Date <= dtpTo.Value)
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
