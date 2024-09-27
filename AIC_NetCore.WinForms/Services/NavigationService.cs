using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AIC_NetCore.WinForms.Services.NavigationService;

namespace AIC_NetCore.WinForms.Services
{
    public interface INavigationService
    {
        UserControl CurrentView { get; }

        event NavigatedHandler Navigated;
        void NavigateTo<ViewType>() where ViewType : UserControl;
    }
    public class NavigationService : INavigationService
    {
        public NavigationService(Func<Type, UserControl> viewFactory)
        {
            _viewFactory = viewFactory;
        }
        private readonly Func<Type, UserControl> _viewFactory;

        public UserControl CurrentView { get; set; }

        public delegate void NavigatedHandler(object sender, EventArgs e);
        public event NavigatedHandler Navigated;

        public void NavigateTo<ViewType>() where ViewType : UserControl
        {
            CurrentView = _viewFactory.Invoke(typeof(ViewType));
            Navigated?.Invoke(this, new EventArgs());
        }
    }
}
