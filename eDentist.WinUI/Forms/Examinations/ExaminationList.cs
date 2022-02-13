using eDentist.Model;
using eDentist.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentist.WinUI.Forms.Examinations
{
    public partial class ExaminationList : UserControl
    {
        private readonly APIService service = new APIService("Examinations");
        public ExaminationList()
        {
            InitializeComponent();
        }

        private async void ExaminationsList_Load(object sender, EventArgs e)
        {
            await LoadList();
        }
        private async Task LoadList()
        {
            var result = await service.Get<List<MExaminations>>(null);

            dgvExaminations.AutoGenerateColumns = false;
            dgvExaminations.ReadOnly = true;
            dgvExaminations.DataSource = result;
        }
        private async Task LoadList(ExaminationsSearchRequest request)
        {
            var result = await service.Get<List<ExaminationsSearchRequest>>(request);

            dgvExaminations.AutoGenerateColumns = false;
            dgvExaminations.ReadOnly = true;
            dgvExaminations.DataSource = result;
        }
    }
}
