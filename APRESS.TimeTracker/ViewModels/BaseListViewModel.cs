using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace APRESS.TimeTracker.ViewModels
{
    public abstract class BaseListViewModel<TEntity> : BaseViewModel<TEntity>
    {
        protected BaseListViewModel(List<BaseDetailsViewModel<TEntity>> collection)
        {
            Collection = new ObservableCollection<BaseDetailsViewModel<TEntity>>(collection);
        }

        public ObservableCollection<BaseDetailsViewModel<TEntity>> Collection { get; private set; }

        public BaseDetailsViewModel<TEntity> Selected { get; set; }
    }
}