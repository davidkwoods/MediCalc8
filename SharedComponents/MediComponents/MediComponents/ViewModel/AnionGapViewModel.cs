using System.Runtime.Serialization;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class AnionGapViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.AnionGapTitle); }
		}

		private double _na;
		[DataMember]
		public double Na
		{
			get { return _na; }
			set
			{
				if (SetProperty(ref _na, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _k;
		[DataMember]
		public double K
		{
			get { return _k; }
			set
			{
				if (SetProperty(ref _k, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _cl;
		[DataMember]
		public double Cl
		{
			get { return _cl; }
			set
			{
				if (SetProperty(ref _cl, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _hCO2;
		[DataMember]
		public double HCO2
		{
			get { return _hCO2; }
			set
			{
				if (SetProperty(ref _hCO2, value))
					OnPropertyChanged(() => Result);
			}
		}

		public double Result
		{
			get { return (Na + K) - (Cl + HCO2); }
		}

		public AnionGapViewModel() : base() { }
		public AnionGapViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeDesignTime()
		{
			InitializeRunTime();
		}

		protected override void InitializeRunTime()
		{
			_k = 0;
			_na = 0;
			_cl = 0;
			_hCO2 = 0;
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as AnionGapViewModel;
			if (other == null)
				return false;
			K = other.K;
			Na = other.Na;
			Cl = other.Cl;
			HCO2 = other.HCO2;
			return base.Rehydrate(vm);
		}
	}
}
