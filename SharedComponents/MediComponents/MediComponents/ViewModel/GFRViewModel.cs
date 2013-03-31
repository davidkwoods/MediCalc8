using System;

namespace MediComponents.ViewModel
{
	class GFRViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.GfrTitle); }
		}

		private bool _isFemale;
		public bool IsFemale
		{
			get { return _isFemale; }
			set
			{
				if (SetProperty(ref _isFemale, value))
					OnPropertyChanged(() => GFR);
			}
		}

		private bool _isAM;
		public bool IsAM
		{
			get { return _isAM; }
			set
			{
				if (SetProperty(ref _isAM, value))
					OnPropertyChanged(() => GFR);
			}
		}

		private double _creatinine;
		public double Creatinine
		{
			get { return _creatinine; }
			set
			{
				if (SetProperty(ref _creatinine, value))
					OnPropertyChanged(() => GFR);
			}
		}

		private int _age;
		public int Age
		{
			get { return _age; }
			set
			{
				if (SetProperty(ref _age, value))
					OnPropertyChanged(() => GFR);
			}
		}

		public double GFR
		{
			get { return Math.Pow(186 * Creatinine, -1.154) * Math.Pow(Age, -0.203) * (IsFemale ? 0.742 : 1) * (IsAM ? 1.210 : 1); }
		}

		protected override void Initialize()
		{
			IsFemale = false;
			IsAM = false;
			Creatinine = 1;
			Age = 24;
		}
	}
}
