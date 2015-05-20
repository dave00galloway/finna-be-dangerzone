using System;
using Microsoft.Practices.Unity;

namespace APRESS.TimeTracker.Services
{
    public sealed class NavigationService : INavigationService
    {
        [Dependency]
        public IDialogService DialogService { get; set; }

        public bool ConfirmClose()
        {
            return DialogService.AskConfirmation("Close TimeTracker.", "Do You Want to close Time Tracker?");
        }

        public object ShowMainWindow()
        {
            Console.WriteLine("ShowingMainWindow");
            return this;
        }
    }
}