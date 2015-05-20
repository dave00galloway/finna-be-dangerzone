namespace APRESS.TimeTracker.Services
{
    public interface INavigationService
    {
        bool ConfirmClose();
        object ShowMainWindow();
    }
}