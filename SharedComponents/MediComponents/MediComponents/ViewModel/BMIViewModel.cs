using System;

namespace MediComponents.ViewModel
{
	class BMIViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.BmiTitle); }
		}

		private double _height;
		public double Height
		{
			get { return _height; }
			set
			{
				if (SetProperty(ref _height, value))
				{
					OnPropertyChanged(() => Result);
					OnPropertyChanged(() => Category);
				}
			}
		}

		private double _weight;
		public double Weight
		{
			get { return _weight; }
			set
			{
				if (SetProperty(ref _weight, value))
				{
					OnPropertyChanged(() => Result);
					OnPropertyChanged(() => Category);
				}
			}
		}

		public double Result
		{
			get { return _weight * 703 / Math.Pow(_height, 2); }
		}

		public string Category
		{
			get
			{
				double res = Result;
				if (res < 18.5)
					return Strings.BmiUnderweight;
				if (res >= 18.5 && res < 25)
					return Strings.BmiNormal;
				if (res >= 25 && res < 30)
					return Strings.BmiOverweight;
				else
					return Strings.BmiObese;
			}
		}

		protected override void Initialize()
		{
			_weight = 150;
			_height = 72;
		}
	}
}
