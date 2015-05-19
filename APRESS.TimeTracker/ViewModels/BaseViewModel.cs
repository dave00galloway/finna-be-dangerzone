namespace APRESS.TimeTracker.ViewModels
{
    public abstract class BaseViewModel<T> : ObservableObject<T>
    {
        private string _viewTitle;

        public string ViewTitle
        {
            get { return _viewTitle; }
            set
            {
                if (_viewTitle == value) return;
                _viewTitle = value;
                OnPropertyChanged(vm => ViewTitle);
            }
        }
    }
}