using eDentist.Model;
using eDentist.Model.Request;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace eDentist.WinUI.Main
{
    public partial class frmLogin : Form
    {

        private readonly APIService userService = new APIService("User");

        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUsrName;
            this.AcceptButton = button3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadPanel(MUsers user)
        {
            var loggedInUser = user.UserRoles.Select(i => i.Role.Name).FirstOrDefault();
            if (loggedInUser == "Admin")
            {
                var form = new frmAdminIndex(user);
                form.Show();
            }
            else if (loggedInUser == "Patient")
            {
                var form = new frmPatientIndex(user);
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsrName.Text;
            APIService.Password = txtPass.Text;

            var request = new UserAuthenticationRequest()
            {
                Username = APIService.Username,
                Password = APIService.Password
            };

            var user = await userService.Authenticate(request);

            if (user != null)
            {
                LoadPanel(user);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password!");
            }
        }


    }
}
