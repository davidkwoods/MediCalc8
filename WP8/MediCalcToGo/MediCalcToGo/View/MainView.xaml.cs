using System.Windows.Navigation;

namespace MediCalcToGo.View
{
	public partial class MainView : StateSavingView
	{
		// Constructor
		public MainView() : base()
		{
			InitializeComponent();

			// Set the data context of the listbox control to the sample data
			//DataContext = App.ViewModel;
		}

		// Load data for the ViewModel Items
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			/*
			if (!App.ViewModel.IsDataLoaded)
			{
				App.ViewModel.LoadData();
			}
			 */
		}
	}
}