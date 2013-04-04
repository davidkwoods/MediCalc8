
namespace MediComponents.ViewModel
{
	public class ViewModelLocator
	{

		private MainViewModel _mainViewModel;
		public MainViewModel MainViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _mainViewModel); }
		}
		public MainViewModel MainDesignVM { get { return new MainViewModel(true); } }

		private AaGradientViewModel _aaGradientViewModel;
		public AaGradientViewModel AaGradientViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _aaGradientViewModel); }
		}
		public AaGradientViewModel AaGradientDesignVM { get { return new AaGradientViewModel(true); } }

		private ABCD2ViewModel _abcd2ViewModel;
		public ABCD2ViewModel ABCD2ViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _abcd2ViewModel); }
		}
		public ABCD2ViewModel ABCD2DesignVM { get { return new ABCD2ViewModel(true); } }

		private ABCompViewModel _abCompViewModel;
		public ABCompViewModel ABCompViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _abCompViewModel); }
		}
		public ABCompViewModel ABCompDesignVM { get { return new ABCompViewModel(true); } }

		private AnionGapViewModel _anionGapViewModel;
		public AnionGapViewModel AnionGapViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _anionGapViewModel); }
		}
		public AnionGapViewModel AnionGapDesignVM { get { return new AnionGapViewModel(true); } }

		private ApgarViewModel _apgarViewModel;
		public ApgarViewModel ApgarViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _apgarViewModel); }
		}
		public ApgarViewModel ApgarDesignVM { get { return new ApgarViewModel(true); } }

		private BMIViewModel _bmiViewModel;
		public BMIViewModel BMIViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _bmiViewModel); }
		}
		public BMIViewModel BMIDesignVM { get { return new BMIViewModel(true); } }

		private CACorrectionViewModel _caCorrectionViewModel;
		public CACorrectionViewModel CACorrectionViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _caCorrectionViewModel); }
		}
		public CACorrectionViewModel CACorrectionDesignVM { get { return new CACorrectionViewModel(true); } }

		private CGEViewModel _cgeViewModel;
		public CGEViewModel CGEViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _cgeViewModel); }
		}
		public CGEViewModel CGEDesignVM { get { return new CGEViewModel(true); } }

		private CSCViewModel _cscViewModel;
		public CSCViewModel CSCViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _cscViewModel); }
		}
		public CSCViewModel CSCDesignVM { get { return new CSCViewModel(true); } }

		private GFRViewModel _gfrViewModel;
		public GFRViewModel GFRViewModel
		{
			get { return Helpers.GetExistingOrNew(ref _gfrViewModel); }
		}
		public GFRViewModel GFRDesignVM { get { return new GFRViewModel(true); } }
	}
}
