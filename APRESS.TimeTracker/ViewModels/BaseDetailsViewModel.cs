namespace APRESS.TimeTracker.ViewModels
{
    public abstract class BaseDetailsViewModel<TEntity> : BaseViewModel<TEntity>
    {
        protected BaseDetailsViewModel(TEntity currentEntity)
        {
            CurrentEntity = currentEntity;
        }

        public TEntity CurrentEntity { get; private set; }

        public abstract void FromModelToView();

        public abstract void FromViewToModel();
    }
}