using eDentist.Model;
using eDentist.WinUI.Forms.Profile;
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
    }
}
