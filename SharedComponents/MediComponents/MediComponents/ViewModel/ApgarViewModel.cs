using System.Runtime.Serialization;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class ApgarViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ApgarTitle); }
		}

		private int _appearance;
		[DataMember]
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
		[DataMember]
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
		[DataMember]
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
		[DataMember]
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
		[DataMember]
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

		public ApgarViewModel() : base() { }
		public ApgarViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeDesignTime()
		{
			InitializeRunTime();
		}

		protected override void InitializeRunTime()
		{
			Activity = 1;
			Appearance = 1;
			Pulse = 1;
			Grimace = 1;
			Respiration = 1;
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as ApgarViewModel;
			if (other == null)
				return false;
			Activity = other.Activity;
			Appearance = other.Appearance;
			Pulse = other.Pulse;
			Grimace = other.Grimace;
			Respiration = other.Respiration;
			return base.Rehydrate(vm);
		}
	}
}
