using System.Windows;

namespace APRESS.TimeTracker.Services
{
    public interface INavigationService
    {
        bool ConfirmClose();
        Window ShowMainWindow();
        Window ShowLoginWindow();
    }
}