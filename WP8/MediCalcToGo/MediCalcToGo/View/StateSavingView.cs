using MediComponents.ViewModel;
using Microsoft.Phone.Controls;

namespace MediCalcToGo.View
{
	public class StateSavingView : PhoneApplicationPage
	{
		protected bool _isNewInstance = false;

		public StateSavingView()
		{
			_isNewInstance = true;
		}

		protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
		{
			if (e.NavigationMode != System.Windows.Navigation.NavigationMode.Back)
				State["ViewModel"] = this.DataContext;
		}

		protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
		{
			// If _isNewPageInstance is true, the page constuctor has been called, so
			// state may need to be restored.
			if (_isNewInstance)
			{
					if (State.Count > 0)
					{
						var dc = this.DataContext as ViewModel;
						if (dc != null)
							dc.Rehydrate(State["ViewModel"]);
					}
			}
			// Set _isNewPageInstance to false. If the user navigates back to this page
			// and it has remained in memory, this value will continue to be false.
			_isNewInstance = false;

		}
	}
}
