using eDentist.WinUI.Forms;
using eDentist.WinUI.Forms.Appointments;
using eDentist.WinUI.Forms.Cities;
using eDentist.WinUI.Forms.Countries;
using eDentist.WinUI.Forms.Examinations;
using eDentist.WinUI.Forms.Manufacturers;
using eDentist.WinUI.Forms.Materials;
using eDentist.WinUI.Forms.Treatments;
using eDentist.WinUI.Forms.Users;
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

namespace eDentist.WinUI.Main
{
    public partial class frmAdminIndex : Form
    {
        public frmAdminIndex()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mngUsers_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new UserList());
        }

        private void btn_mngAppo_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new AppointmentList());
        }

        private void btn_mngExam_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new ExaminationList());
        }

        private void btn_mngTreatments_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new TreatmentList());
        }

        private void btn_mngMaterials_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new MaterialList());
        }

        private void btn_mngManufacturers_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new ManufacturerList());
        }

        private void btn_mngCountries_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new CountryList());
        }

        private void btn_mngCities_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new CityList());
        }

    }
}
