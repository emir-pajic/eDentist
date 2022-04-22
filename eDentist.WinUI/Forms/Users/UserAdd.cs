using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Users
{
    public partial class UserAdd : UserControl
    {
        private readonly APIService _cityService = new APIService("Cities");
        private readonly APIService _rolesService = new APIService("Role");
        private readonly APIService _userService = new APIService("User");


        private List<MCities> _cities { get; set; }

        private MCities _selectedCity { get; set; }

        private List<MRoles> _roles { get; set; }

        public MRoles _selectedRole { get; set; }


        public UserAdd()
        {
            InitializeComponent();
        }
        private async void UsersAdd_LoadData(object sender, EventArgs e)
        {
            await UsersAdd_Load();
        }
        private async Task UsersAdd_Load()
        {
            _cities = await _cityService.Get<List<MCities>>(null);
            addUserCitiesMenu.Items.AddRange(_cities.Select(x => x.CityName).ToArray());

            _roles = await _rolesService.Get<List<MRoles>>(null);
            addUserRoleMenu.Items.AddRange(_roles.Select(x => x.Name).ToArray());

        }

        private void addUserCitiesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCity = _cities.FirstOrDefault(x => x.CityName.Equals(addUserCitiesMenu.SelectedItem));

        }

        private void addUserRoleMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRole = _roles.FirstOrDefault(x => x.Name.Equals(addUserRoleMenu.SelectedItem));
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            int? cityId = ValidateCity();

            var request = new UsersUpsertRequest()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUserName.Text,
                CityId = cityId,
                Email = txtEmail.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Telephone = txtTelephone.Text,
                Password = txtPassword.Text,
                PasswordConfirmation = txtPasswordConfirmation.Text,
                Roles = new List<int>() { _selectedRole.RoleId },

            };

            await _userService.Insert<MUsers>(request);
            MessageBox.Show("User added!");
            PanelHelper.SwapPanels(this.Parent, this, new UserList());
        }

        private int? ValidateCity()
        {
            int? cityId = 0;
            if (_selectedCity == null)
            {
                cityId = null;
            }
            else
            {
                cityId = _selectedCity.CityId;
            }

            return cityId;
        }
    }
}
