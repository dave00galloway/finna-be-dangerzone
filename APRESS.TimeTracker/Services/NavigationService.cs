using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows;
using APRESS.TimeTracker.Views;
using Microsoft.Practices.Unity;

namespace APRESS.TimeTracker.Services
{
    public sealed class NavigationService : INavigationService
    {
        [Dependency]
        public IDialogService DialogService { get; set; }

        [Dependency]
        public IUnityContainer Container { get; set; }

        public bool ConfirmClose()
        {
            return DialogService.AskConfirmation("Close TimeTracker.", "Do You Want to close Time Tracker?");
        }

        public Window ShowMainWindow()
        {
            Console.WriteLine("ShowingMainWindow");
            return Container.Resolve<MainWindow>();
       
        }

        public Window ShowLoginWindow()
        {
            Console.WriteLine("ShowingLoginView");
            var showLoginWindow = Container.Resolve<LoginView>();
            showLoginWindow.ShowDialog();
            return showLoginWindow;
        }
    }
}