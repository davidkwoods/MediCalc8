using System.Runtime.Serialization;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class CGEViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.CGETitle); }
		}

		private int _age;
		[DataMember]
		public int Age
		{
			get { return _age; }
			set
			{
				if (SetProperty(ref _age, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _mass;
		[DataMember]
		public double Mass
		{
			get { return _mass; }
			set
			{
				if (SetProperty(ref _mass, value))
					OnPropertyChanged(() => Result);
			}
		}

		private bool _isFemale;
		[DataMember]
		public bool IsFemale
		{
			get { return _isFemale; }
			set
			{
				if (SetProperty(ref _isFemale, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _creat;
		[DataMember]
		public double Creat
		{
			get { return _creat; }
			set
			{
				if (SetProperty(ref _creat, value))
					OnPropertyChanged(() => Result);
			}
		}

		public double Result
		{
			get { return ((140 - Age) * Mass * (IsFemale ? 0.85 : 1)) / (72 * Creat); }
		}

		public CGEViewModel() : base() { }
		public CGEViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeDesignTime()
		{
			InitializeRunTime();
		}

		protected override void InitializeRunTime()
		{
			Age = 28;
			Mass = 80;
			IsFemale = false;
			Creat = 12;
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as CGEViewModel;
			if (other == null)
				return false;
			Age = other.Age;
			Mass = other.Mass;
			IsFemale = other.IsFemale;
			Creat = other.Creat;
			return base.Rehydrate(vm);
		}
	}
}
