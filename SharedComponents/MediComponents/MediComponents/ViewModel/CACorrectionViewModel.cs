using System.Runtime.Serialization;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class CACorrectionViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.CACorrectionTitle); }
		}

		private double _albumin;
		[DataMember]
		public double Albumin
		{
			get { return _albumin; }
			set
			{
				if (SetProperty(ref _albumin, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _ca;
		[DataMember]
		public double Ca
		{
			get { return _ca; }
			set
			{
				if (SetProperty(ref _ca, value))
					OnPropertyChanged(() => Result);
			}
		}

		public double Result
		{
			get { return 0.8 * (4 - Albumin) + Ca; }
		}

		public CACorrectionViewModel() : base() { }
		public CACorrectionViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeDesignTime()
		{
			InitializeRunTime();
		}

		protected override void InitializeRunTime()
		{
			Albumin = 4;
			Ca = 9.5;
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as CACorrectionViewModel;
			if (other == null)
				return false;
			Albumin = other.Albumin;
			Ca = other.Ca;
			return base.Rehydrate(vm);
		}
	}
}
