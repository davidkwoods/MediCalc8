
namespace MediComponents.ViewModel
{
	public class ViewModelLocator
	{
		private MainViewModel _mainViewModel;
		public MainViewModel MainViewModel
		{
			get
			{
				if (_mainViewModel == null)
					_mainViewModel = new MainViewModel();
				return _mainViewModel;
			}
		}
	}
}
