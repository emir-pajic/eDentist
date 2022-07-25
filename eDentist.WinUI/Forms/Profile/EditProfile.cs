using eDentist.Model;
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
            user = SignedInUser.User;
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

            btnAddUser.Visible = false;

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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Byte[] imgBytes = null;
            ImageConverter imgConverter = new ImageConverter();
            imgBytes = (System.Byte[])imgConverter.ConvertTo(profileImage.Image, Type.GetType("System.Byte[]"));
        }
    }
}
