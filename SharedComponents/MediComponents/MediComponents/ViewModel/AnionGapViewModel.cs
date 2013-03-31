using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediComponents.ViewModel
{
	class AnionGapViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.AnionGapTitle); }
		}

		private double _na;
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

		protected override void Initialize()
		{
			_k = 0;
			_na = 0;
			_cl = 0;
			_hCO2 = 0;
		}
	}
}
