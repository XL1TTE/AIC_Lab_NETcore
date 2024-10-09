using AIC_NetCore.WinForms.Controls;
using AIC_NetCore.WinForms.Services;

namespace AIC_NetCore.WinForms
{
    public partial class MainForm : Form
    {
        private readonly INavigationService _navigationService;
        public MainForm(INavigationService navigationService)
        {
            _navigationService = navigationService;

            InitializeComponent();

            _navigationService.Navigated += UpdateView;

            _navigationService.NavigateTo<StudentTableView>();
        }

        private void UpdateView(object sender, EventArgs e)
        {
            ViewChangePanel.Controls.Clear();

            var view = _navigationService.CurrentView;

            ViewChangePanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;

        }
    }
}
