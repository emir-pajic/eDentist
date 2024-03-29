﻿using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Appointments
{
    public partial class AppointmentStaffAccept : UserControl
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _appointmentService = new APIService("Appointments");
        private MUsers _user;

        private List<MAppointments> _appointments { get; set; }
        private MAppointments _selectedAppointment { get; set; }




        public AppointmentStaffAccept(MUsers user)
        {
            InitializeComponent();
            _user = user;
        }
        private async void AppointmentStaffAccept_LoadData(object sender, EventArgs e)
        {
            await AppointmentStaffAccept_Load();
        }
        private async Task AppointmentStaffAccept_Load()
        {
            _appointments = await _appointmentService.Get<List<MAppointments>>(null);
            acceptAppointmentUserMenu.Items.AddRange(_appointments.Where(x => x.Date >= DateTime.Now && x.AppointmentStatus.Equals("Requested") && x.PreferedDoctorId == _user.UserId).Select(x => x.Date.ToString()).ToArray());
        }







        private bool ValidateInput(MAppointments selected)
        {
            if (selected == null)
            {
                MessageBox.Show("You must select an appointment to update!");
                return false;
            }

            return true;
        }

        private async void btnAcceptAppointment_Click(object sender, EventArgs e)
        {
            if (ValidateInput(_selectedAppointment))
            {

                var request = new AppointmentsUpsertRequest()
                {
                    AppointmentId = _selectedAppointment.AppointmentId,
                    Date = _selectedAppointment.Date,
                    UserId = _selectedAppointment.UserId,
                    DayId = _selectedAppointment.DayId,
                    Status = _selectedAppointment.Status,
                    AppointmentStatus = "Accepted",
                    AcceptedById = SignedInUser.User.UserId,
                    PreferedDoctorId = _selectedAppointment.PreferedDoctorId,
                };

                await _appointmentService.Update<MAppointments>(request.AppointmentId, request);
                MessageBox.Show("Appointment accepted!");
                PanelHelper.SwapPanels(this.Parent, this, new AppointmentListStaff(_user));
            }
        }

        private async void acceptAppointmentUserMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _selectedAppointment = _appointments.FirstOrDefault(x => x.Date.ToString().Equals(acceptAppointmentUserMenu.SelectedItem));
            var user = await _userService.GetById<MUsers>(_selectedAppointment.UserId);
            txtPatient.Text = user.FirstName + " " + user.LastName;
        }
    }
}

