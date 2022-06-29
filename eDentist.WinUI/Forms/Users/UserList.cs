using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Users
{
    public partial class UserList : UserControl
    {
        private readonly APIService userService = new APIService("User");
        public UserList()
        {
            InitializeComponent();
        }
        private async void UserList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var result = await userService.Get<List<MUsers>>(null);

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.DataSource = result;
        }
        private async Task LoadList(UsersSearchRequest request)
        {
            var result = await userService.Get<List<MUsers>>(request);

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.DataSource = result;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new UserAdd());

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new UserEdit());

        }
    }
}
