using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Users
{
    public partial class UserEdit : UserControl
    {
        private readonly APIService _cityService = new APIService("Cities");
        private readonly APIService _rolesService = new APIService("Role");
        private readonly APIService _userService = new APIService("User");

        private List<MUsers> _users { get; set; }
        private MUsers _selectedUser { get; set; }


        private List<MCities> _cities { get; set; }
        public MCities _selectedCity { get; set; }

        private List<MRoles> _roles { get; set; }
        public MRoles _selectedRole { get; set; }


        public UserEdit()
        {
            InitializeComponent();
        }
        private async void UsersEdit_LoadData(object sender, EventArgs e)
        {
            await UsersEdit_Load();
        }
        private async Task UsersEdit_Load()
        {
            await FillUsers();

            _cities = await _cityService.Get<List<MCities>>(null);
            editUserCitiesMenu.Items.AddRange(_cities.Select(x => x.CityName).ToArray());

            _roles = await _rolesService.Get<List<MRoles>>(null);
            editUserRoleMenu.Items.AddRange(_roles.Select(x => x.Name).ToArray());

        }

        private async Task FillUsers()
        {
            _users = await _userService.Get<List<MUsers>>(null);

            foreach (var user in _users)
            {
                UsersMenu.Items.Add(user.FirstName + ' ' + user.LastName);
            }
        }

        private void UsersMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUserData();
        }

        private void FillUserData()
        {
            var splitted = UsersMenu.SelectedItem.ToString().Split(' ');

            var firstName = splitted[0];
            var lastName = splitted[1];
            _selectedUser = _users.FirstOrDefault(x => x.FirstName.Equals(firstName) && x.LastName.Equals(lastName));

            txtFirstName.Text = _selectedUser.FirstName;
            txtLastName.Text = _selectedUser.LastName;
            txtUserName.Text = _selectedUser.Username;
            txtEmail.Text = _selectedUser.Email;
            dtpDateOfBirth.Text = _selectedUser.DateOfBirth.ToString();
            txtTelephone.Text = _selectedUser.Telephone;

            ImageConverter converter = new ImageConverter();
            profileImage.Image = (Image)converter.ConvertFrom(_selectedUser.Image);
        }



        private async void btnEditUser_Click(object sender, EventArgs e)
        {
            int? cityId = ValidateCity();
            Byte[] imgBytes = null;
            ImageConverter imgConverter = new ImageConverter();
            imgBytes = (System.Byte[])imgConverter.ConvertTo(profileImage.Image, Type.GetType("System.Byte[]"));

            if (imgBytes.Length == 0)
            {
                MessageBox.Show("Please add a profile image!");

                return;
            }
            if (ValidateInput(_selectedUser, _selectedRole))
            {

                var request = new UsersUpsertRequest()
                {
                    UserId = _selectedUser.UserId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Username = txtUserName.Text,
                    CityId = cityId,
                    Email = txtEmail.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    Telephone = txtTelephone.Text,
                    Image = imgBytes,
                    Roles = new List<int>() { _selectedRole.RoleId },
                    RolesToDelete = new List<int>() { _selectedUser.UserRoles.First().RoleId },
                };

                await _userService.Update<MUsers>(request.UserId, request);
                MessageBox.Show("User updated!");
                PanelHelper.SwapPanels(this.Parent, this, new UserList());
            }
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

        private void editUserCitiesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCity = _cities.FirstOrDefault(x => x.CityName.Equals(editUserCitiesMenu.SelectedItem.ToString()));

        }

        private void editUserRoleMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRole = _roles.FirstOrDefault(x => x.Name.Equals(editUserRoleMenu.SelectedItem.ToString()));

        }

        private bool ValidateInput(MUsers selectedUser, MRoles role)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to edit!");
                return false;
            }

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("First name can not be empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Last name can not be empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username can not be empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email can not be empty!");
                return false;
            }

            if (role == null)
            {
                MessageBox.Show("User role can not be empty");
                return false;
            }
            return true;
        }

        private void profileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                profileImage.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
