using System.Windows;
using APRESS.TimeTracker.Services;
using Microsoft.Practices.Unity;

namespace APRESS.TimeTracker
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer _container;
        private INavigationService _navigationService;

        public App()
        {
            ConFigureContainer();
        }

        private void ConFigureContainer()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDialogService, DialogService>();
            _container.RegisterType<INavigationService, NavigationService>();
            _container.RegisterType<MainWindow>();
            _navigationService = _container.Resolve<INavigationService>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //var mainView = new MainWindow();
            //mainView.Show();
            var mainWindow = _navigationService.ShowMainWindow();

        }

        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
            e.Cancel = _navigationService.ConfirmClose();
        }
    }
}