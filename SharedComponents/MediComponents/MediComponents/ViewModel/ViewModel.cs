
namespace MediComponents.ViewModel
{
	public abstract class ViewModel : ObservableObject
	{
		public ViewModel()
		{
			Initialize();
		}

		protected virtual void Initialize() { }
	}
}
