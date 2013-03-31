using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace MediComponents
{
	public abstract class ObservableObject : INotifyPropertyChanged
	{
		protected virtual void OnPropertyChangedImplicit([CallerMemberName] string propertyName = null)
		{
			OnPropertyChanged(propertyName);
		}

		protected virtual void OnPropertyChanged(string propertyName = null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected bool SetProperty<T>(ref T propertyBacker, T value, [CallerMemberName] string propertyName = null)
		{
			if (Equals(propertyBacker, value))
			{
				return false;
			}

			propertyBacker = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		protected virtual void OnPropertyChanged<T>(Expression<Func<T>> property)
		{
			var lambda = (LambdaExpression)property;
			MemberExpression memberExpression;
			if (lambda.Body is UnaryExpression)
			{
				var unaryExpression = (UnaryExpression)lambda.Body;
				memberExpression = (MemberExpression)unaryExpression.Operand;
			}
			else
			{
				memberExpression = (MemberExpression)lambda.Body;
			}
			OnPropertyChanged(memberExpression.Member.Name);
		}
	}
}
