
namespace MediComponents.ViewModel
{
	public class ABCD2ViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ABCD2Title); }
		}

		private int _age;
		public int Age
		{
			get { return _age; }
			set
			{
				if (SetProperty(ref _age, value))
				{
					OnPropertyChanged(() => Score);
					OnPropertyChanged(() => Risk);
				}
			}
		}

		private int _bloodPressure;
		public int BloodPressure
		{
			get { return _bloodPressure; }
			set
			{
				if (SetProperty(ref _bloodPressure, value))
				{
					OnPropertyChanged(() => Score);
					OnPropertyChanged(() => Risk);
				}
			}
		}

		private int _clinicalFeatures;
		public int ClinicalFeatures
		{
			get { return _clinicalFeatures; }
			set
			{
				if (SetProperty(ref _clinicalFeatures, value))
				{
					OnPropertyChanged(() => Score);
					OnPropertyChanged(() => Risk);
				}
			}
		}

		private int _duration;
		public int Duration
		{
			get { return _duration; }
			set
			{
				if (SetProperty(ref _duration, value))
				{
					OnPropertyChanged(() => Score);
					OnPropertyChanged(() => Risk);
				}
			}
		}

		private int _diabetes;
		public int Diabetes
		{
			get { return _diabetes; }
			set
			{
				if (SetProperty(ref _diabetes, value))
				{
					OnPropertyChanged(() => Score);
					OnPropertyChanged(() => Risk);
				}
			}
		}

		public int Score
		{
			get { return Age + BloodPressure + ClinicalFeatures + Duration + Diabetes; }
		}

		public string Risk
		{
			get
			{
				int score = Score;
				if (score < 4)
					return Strings.ABCD2Low;
				if (score < 6)
					return Strings.ABCD2Mod;
				else
					return Strings.ABCD2High;
			}
		}

		protected override void Initialize()
		{
			Age = 0;
			BloodPressure = 0;
			ClinicalFeatures = 0;
			Duration = 0;
			Diabetes = 0;
		}
	}
}

