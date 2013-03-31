
namespace MediComponents.ViewModel
{
	public class AaGradientViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.AaGradientTitle); }
		}

		private double _fiO2;
		public double FiO2
		{
			get { return _fiO2; }
			set
			{
				if (SetProperty(ref _fiO2, value))
					OnPropertyChanged(() => Result);
			}
		}
		/*
		public string FiO2
		{
			get { return _fiO2.ToString(); }
			set
			{
				double temp;
				if (double.TryParse(value, out temp))
				{
					if(SetProperty(ref _fiO2, temp))
					{
						OnPropertyChanged(() => Result);
					}
				}
			}
		}
		*/

		private double _paO2;
		public double PaO2
		{
			get { return _paO2; }
			set
			{
				if (SetProperty(ref _paO2, value))
					OnPropertyChanged(() => Result);
			}
		}
		/*
		public string PaO2
		{
			get { return _paO2.ToString(); }
			set
			{
				double temp;
				if (double.TryParse(value, out temp))
				{
					if (SetProperty(ref _paO2, temp))
					{
						OnPropertyChanged(() => Result);
					}
				}
			}
		}
		*/

		private double _paCO2;
		public double PaCO2
		{
			get { return _paCO2; }
			set
			{
				if (SetProperty(ref _paCO2, value))
					OnPropertyChanged(() => Result);
			}
		}
		/*
		public string PaCO2
		{
			get { return _paCO2.ToString(); }
			set
			{
				double temp;
				if (double.TryParse(value, out temp))
				{
					if (SetProperty(ref _paCO2, temp))
					{
						OnPropertyChanged(() => Result);
					}
				}
			}
		}
		*/

		public double Result
		{
			get  { return ((713 * FiO2) - (PaCO2 / 0.8)) - PaO2; }
		}

		protected override void Initialize()
		{
			_paO2 = 90;
			_paCO2 = 40;
			_fiO2 = 2;
		}
	}
}

