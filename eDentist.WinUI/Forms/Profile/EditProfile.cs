using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Profile
{
    public partial class EditProfile : UserControl
    {
        private MUsers user;
        private readonly APIService _cityService = new APIService("Cities");
        private readonly APIService _userService = new APIService("User");

        private List<MCities> _cities { get; set; }

        private MCities _selectedCity { get; set; }
        public EditProfile()
        {
            InitializeComponent();
        }
        private async void EditProfile_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            user = await _userService.GetById<MUsers>(SignedInUser.User.UserId);
            _cities = await _cityService.Get<List<MCities>>(null);
            UserCityMenu.Items.AddRange(_cities.Select(x => x.CityName).ToArray());
            uploadImage.Visible = false;
            loadUserInformation();

        }
        private void loadUserInformation()
        {
            UserCityMenu.Visible = false;

            txtFirstName.Text = user.FirstName;
            txtFirstName.ReadOnly = true;

            txtLastName.Text = user.LastName;
            txtLastName.ReadOnly = true;

            txtUserName.Text = user.Username;
            txtUserName.ReadOnly = true;

            txtCity.Text = _cities.FirstOrDefault(x => x.CityId.Equals(user.CityId)).CityName;
            txtCity.ReadOnly = true;

            dtpDateOfBirth.Text = user.DateOfBirth.ToString();
            dtpDateOfBirth.Enabled = false;

            txtEmail.Text = user.Email;
            txtEmail.ReadOnly = true;

            txtTelephone.Text = user.Telephone;
            txtTelephone.ReadOnly = true;

            ImageConverter converter = new ImageConverter();
            profileImage.Image = (Image)converter.ConvertFrom(user.Image);

            saveInfo.Visible = false;

        }

        private void UserCityMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCity = _cities.FirstOrDefault(x => x.CityName.Equals(UserCityMenu.SelectedItem));
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                profileImage.Image = new Bitmap(opnfd.FileName);
            }

        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            Byte[] imgBytes = null;
            ImageConverter imgConverter = new ImageConverter();
            imgBytes = (System.Byte[])imgConverter.ConvertTo(profileImage.Image, Type.GetType("System.Byte[]"));

            int? cityId = ValidateCity();

            if (ValidateInput())
            {

                var request = new UsersUpsertRequest()
                {
                    UserId = user.UserId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Username = txtUserName.Text,
                    CityId = cityId,
                    Email = txtEmail.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    Telephone = txtTelephone.Text,
                    Image = imgBytes,
                };

                await _userService.Update<MUsers>(request.UserId, request);
                MessageBox.Show("User updated!");
                PanelHelper.SwapPanels(this.Parent, this, new EditProfile());
            }


        }

        private void editProfileInfo_Click(object sender, EventArgs e)
        {
            UserCityMenu.Visible = true;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtUserName.ReadOnly = false;
            txtCity.Visible = false;
            dtpDateOfBirth.Enabled = true;
            txtEmail.ReadOnly = false;
            txtTelephone.ReadOnly = false;
            saveInfo.Visible = true;
            uploadImage.Visible = true;
            editProfileInfo.Visible = false;
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

        private bool ValidateInput()
        {


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
            return true;
        }
    }
}
