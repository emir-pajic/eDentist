using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Users
{
    public partial class UserAdd : UserControl
    {
        private readonly APIService _cityService = new APIService("Cities");
        private readonly APIService _rolesService = new APIService("Role");
        private readonly APIService _userService = new APIService("User");
        string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";




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
            Byte[] imgBytes = null;
            ImageConverter imgConverter = new ImageConverter();
            imgBytes = (System.Byte[])imgConverter.ConvertTo(profileImage.Image, Type.GetType("System.Byte[]"));

            if (imgBytes.Length == 0)
            {
                MessageBox.Show("Please add a profile image!");

                return;
            }
            if (!Email_Validating(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email!");

                return;
            }
            if (!Phone_Validating(txtTelephone.Text))
            {
                MessageBox.Show("Please enter a valid phone number!");

                return;
            }
            if (!PassValidation(txtPassword.Text, txtPasswordConfirmation.Text))
            {
                MessageBox.Show("Invalid password or passwords don't match!");
                return;
            }

            if (_selectedRole == null)
            {
                MessageBox.Show("Please select a role");

                return;
            }

            var request = new UsersUpsertRequest()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUserName.Text,
                CityId = cityId,
                Email = txtEmail.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Image = imgBytes,
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

        private void profileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                profileImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private bool Email_Validating(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                bool isEmailValid = Regex.IsMatch(txtEmail.Text, emailPattern);
                if (isEmailValid == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return false;

        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private bool Phone_Validating(string telephone)
        {
            string phone = telephone.ToString();
            if (string.IsNullOrWhiteSpace(phone) || phone.Length < 9 || phone.Length > 9)
            {
                return false;
            }
            else
            {

                if (IsDigitsOnly(phone) == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private bool PassValidation(string password, string confirmPass)
        {
            if (String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPass))
            {
                return false;
            }
            else
            {
                if (!password.Equals(confirmPass))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
