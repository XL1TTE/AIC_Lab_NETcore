using AIC_NetCore.Application.IStores;
using AIC_NetCore.WinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIC_NetCore.WinForms.Controls
{
    public partial class StudentGraphicView : UserControl
    {
        private IStudentService _studentStore;
        private INavigationService _navigationService;
        public StudentGraphicView(IStudentService studentStore, INavigationService navigationService)
        {
            _studentStore = studentStore;
            _navigationService = navigationService;
            InitializeComponent();
            MakeStudentHistogram();
        }

        private void ToStudentTableButton_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<StudentTableView>();
        }


        private void MakeStudentHistogram()
        {
            StudentHisto.Series.Clear();
            var s = _studentStore.GetStudentSpecialitiesData();
            foreach(var spec in s.Item1)
            {
                StudentHisto.Series.Add(spec);
            }

            int index = 0;
            foreach(var count in s.Item2)
            {
                StudentHisto.Series[index].Points.Add(count);
                index++;
            }

        }


        private void UpdateGraphButton_Click(object sender, EventArgs e)
        {
            MakeStudentHistogram();
        }
    }
}
