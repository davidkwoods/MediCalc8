using System.Runtime.Serialization;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class AaGradientViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.AaGradientTitle); }
		}

		private double _fiO2;
		[DataMember]
		public double FiO2
		{
			get { return _fiO2; }
			set
			{
				if (SetProperty(ref _fiO2, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _paO2;
		[DataMember]
		public double PaO2
		{
			get { return _paO2; }
			set
			{
				if (SetProperty(ref _paO2, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _paCO2;
		[DataMember]
		public double PaCO2
		{
			get { return _paCO2; }
			set
			{
				if (SetProperty(ref _paCO2, value))
					OnPropertyChanged(() => Result);
			}
		}

		public string Result
		{
			get  { return string.Format(Strings.AaGradientResultFormat, ((713 * FiO2) - (PaCO2 / 0.8)) - PaO2); }
		}

		public AaGradientViewModel() : base() { }
		public AaGradientViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeDesignTime()
		{
			InitializeRunTime();
		}

		protected override void InitializeRunTime()
		{
			_paO2 = 90;
			_paCO2 = 40;
			_fiO2 = 2;
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as AaGradientViewModel;
			if (other == null)
				return false;
			PaCO2 = other.PaCO2;
			PaO2 = other.PaO2;
			FiO2 = other.FiO2;
			return base.Rehydrate(vm);
		}
	}
}

