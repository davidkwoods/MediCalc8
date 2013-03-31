
namespace MediComponents.ViewModel
{
	public class ApgarViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ApgarTitle); }
		}

		private int _appearance;
		public int Appearance
		{
			get { return _appearance; }
			set
			{
				if (SetProperty(ref _appearance, value))
					OnPropertyChanged(() => Score);
			}
		}

		private int _pulse;
		public int Pulse
		{
			get { return _pulse; }
			set
			{
				if (SetProperty(ref _pulse, value))
					OnPropertyChanged(() => Score);
			}
		}

		private int _grimace;
		public int Grimace
		{
			get { return _grimace; }
			set
			{
				if (SetProperty(ref _grimace, value))
					OnPropertyChanged(() => Score);
			}
		}

		private int _activity;
		public int Activity
		{
			get { return _activity; }
			set
			{
				if (SetProperty(ref _activity, value))
					OnPropertyChanged(() => Score);
			}
		}

		private int _respiration;
		public int Respiration
		{
			get { return _respiration; }
			set
			{
				if (SetProperty(ref _respiration, value))
					OnPropertyChanged(() => Score);
			}
		}

		public int Score
		{
			get { return Appearance + Pulse + Grimace + Activity + Respiration; }
		}

		protected override void Initialize()
		{
			Activity = 1;
			Appearance = 1;
			Pulse = 1;
			Grimace = 1;
			Respiration = 1;
		}
	}
}
