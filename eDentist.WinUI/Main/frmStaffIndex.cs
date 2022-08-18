using eDentist.Model;
using eDentist.WinUI.Forms.Appointments;
using eDentist.WinUI.Forms.Examinations;
using eDentist.WinUI.Forms.Materials;
using eDentist.WinUI.Forms.Profile;
using eDentist.WinUI.Forms.Treatments;
using eDentist.WinUI.Helper;
using System.Drawing;
using System.Windows.Forms;

namespace eDentist.WinUI.Main
{
    public partial class frmStaffIndex : Form
    {
        private static MUsers _user;

        public frmStaffIndex(MUsers user)
        {
            _user = user;
            SignedInUser.User = _user;
            InitializeComponent();

            ImageConverter converter = new ImageConverter();
            userImage.Image = (Image)converter.ConvertFrom(_user.Image);
        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            SignedInUser.User = null;
            frm.Show();
        }

        private void editProfile_Click(object sender, System.EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new EditProfile());
        }

        private void btnAllAppointments_Click(object sender, System.EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new AppointmentListStaff());
        }

        private void btnMaterials_Click(object sender, System.EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new MaterialList());
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new TreatmentList());
        }

        private void btnMyApps_Click(object sender, System.EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new AppointmentListStaffMy(SignedInUser.User));
        }

        private void btnMyExaminations_Click(object sender, System.EventArgs e)
        {
            PanelHelper.RemovePanels(ContentPanel);
            PanelHelper.AddPanel(ContentPanel, new ExaminationsListStaff(SignedInUser.User));
        }
    }
}
