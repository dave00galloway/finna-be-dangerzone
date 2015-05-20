using System.Windows;

namespace APRESS.TimeTracker.Services
{
    public sealed class DialogService : IDialogService
    {
        public void ShowInfo(string title, string message)
        {
            MessageBox.Show(title, message, MessageBoxButton.OK);
        }

        public void ShowError(string title, string message)
        {
            MessageBox.Show(title, message, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void ShowAlert(string title, string message)
        {
            MessageBox.Show(title, message, MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        public bool AskConfirmation(string title, string message)
        {
            return MessageBox.Show(title, message, MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                   MessageBoxResult.Yes;
        }
    }
}