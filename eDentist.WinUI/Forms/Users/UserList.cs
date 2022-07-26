using eDentist.Model;
using eDentist.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Users
{
    public partial class UserList : UserControl
    {
        private readonly APIService userService = new APIService("User");
        private readonly APIService _cityService = new APIService("Cities");
        private List<MCities> _cities { get; set; }
        public MCities _selectedCity { get; set; }
        public List<MUsers> result = new List<MUsers>();
        public UserList()
        {
            InitializeComponent();
        }
        private async void UserList_Load(object sender, EventArgs e)
        {
            await LoadList();
            txtSearch.Focus();

        }
        private async Task LoadList()
        {
            _cities = await _cityService.Get<List<MCities>>(null);
            result = await userService.Get<List<MUsers>>(null);

            foreach (var item in result)
            {
                if (item.CityId == null)
                {
                    item.City = "N/A";
                }
                else
                {
                    item.City = _cities.FirstOrDefault(x => x.CityId.Equals(item.CityId)).CityName;
                }

                foreach (var role in item.UserRoles)
                {
                    item.Role += role.Role.Name;
                    item.Role += " ";
                }

            }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new UserDelete());

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filtered = new List<MUsers>();
            foreach (var item in result)
            {
                if (item.Username.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            dgvUsers.DataSource = filtered;
        }
    }
}
