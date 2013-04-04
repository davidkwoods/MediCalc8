using System.Runtime.Serialization;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class ABCD2ViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ABCD2Title); }
		}

		private int _age;
		[DataMember]
		public int Age
		{
			get { return _age; }
			set
			{
				if (SetProperty(ref _age, value))
				{
					OnPropertyChanged(() => Result);
				}
			}
		}

		private int _bloodPressure;
		[DataMember]
		public int BloodPressure
		{
			get { return _bloodPressure; }
			set
			{
				if (SetProperty(ref _bloodPressure, value))
				{
					OnPropertyChanged(() => Result);
				}
			}
		}

		private int _clinicalFeatures;
		[DataMember]
		public int ClinicalFeatures
		{
			get { return _clinicalFeatures; }
			set
			{
				if (SetProperty(ref _clinicalFeatures, value))
				{
					OnPropertyChanged(() => Result);
				}
			}
		}

		private int _duration;
		[DataMember]
		public int Duration
		{
			get { return _duration; }
			set
			{
				if (SetProperty(ref _duration, value))
				{
					OnPropertyChanged(() => Result);
				}
			}
		}

		private int _diabetes;
		[DataMember]
		public int Diabetes
		{
			get { return _diabetes; }
			set
			{
				if (SetProperty(ref _diabetes, value))
				{
					OnPropertyChanged(() => Result);
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

		public string Result
		{
			get { return string.Format(Strings.ABCD2ResultFormat, Strings.ScoreEquals, Score, Risk); }
		}

		public ABCD2ViewModel() : base() { }
		public ABCD2ViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeDesignTime()
		{
			InitializeRunTime();
		}

		protected override void InitializeRunTime()
		{
			Age = 0;
			BloodPressure = 0;
			ClinicalFeatures = 0;
			Duration = 0;
			Diabetes = 0;
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as ABCD2ViewModel;
			if (other == null)
				return false;
			Age = other.Age;
			BloodPressure = other.BloodPressure;
			ClinicalFeatures = other.ClinicalFeatures;
			Duration = other.Duration;
			Diabetes = other.Diabetes;
			return base.Rehydrate(vm);
		}
	}
}

