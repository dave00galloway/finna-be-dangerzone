using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using APRESS.TimeTracker.Annotations;

namespace APRESS.TimeTracker.ViewModels
{
    public abstract class ObservableObject<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(Expression<Func<T, object>> property)
        {
            var handler = PropertyChanged;
            if (handler == null) return;
            var propertyName = GetPropertyName(property);
            handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private static string GetPropertyName(Expression<Func<T, object>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new ArgumentException("The expression is not a member accessexpression.", "expression");
            }
            var property = memberExpression.Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException("The member access expression does not access a property.", "expression");
            }
            var getMethod = property.GetGetMethod(true);
            if (getMethod.IsStatic)
            {
                throw new ArgumentException("The referenced property is a static property.", "expression");
            }
            return memberExpression.Member.Name;
        }
    }
}