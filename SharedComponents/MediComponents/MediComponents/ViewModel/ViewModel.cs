using System.Runtime.Serialization;

namespace MediComponents.ViewModel
{
	[DataContract]
	public abstract class ViewModel : ObservableObject
	{
		public ViewModel()
		{
			InitializeRunTime();
		}

		public ViewModel(bool isDesign)
		{
			if (isDesign)
				InitializeDesignTime();
			else
				InitializeRunTime();
		}

		protected virtual void InitializeDesignTime() { }

		protected virtual void InitializeRunTime() { }

		public virtual bool Rehydrate(object vm) { return true; }
	}
}
