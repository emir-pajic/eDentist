using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Users
{
    public partial class UserDelete : UserControl
    {
        private readonly APIService _userService = new APIService("User");
        private List<MUsers> _users { get; set; }
        private MUsers _selectedUser { get; set; }
        public UserDelete()
        {
            InitializeComponent();
        }
        private async void UserDelete_LoadData(object sender, EventArgs e)
        {
            await UserDelete_Load();
        }

        private async Task UserDelete_Load()
        {
            _users = await _userService.Get<List<MUsers>>(null);

            foreach (var user in _users)
            {
                menuUsers.Items.Add(user.Username);
            }
        }

        private void menuUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedUser = _users.FirstOrDefault(x => x.Username.Equals(menuUsers.SelectedItem.ToString()));
        }

        private async void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Please select an user to remove!");
            }
            else
            {
                await _userService.Delete<MUsers>(_selectedUser.UserId);
                MessageBox.Show("User removed!");
                PanelHelper.SwapPanels(this.Parent, this, new UserList());

            }
        }
    }
}
