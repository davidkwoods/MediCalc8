using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediComponents.ViewModel
{
	public class CGEViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.CGETitle); }
		}

		private int _age;
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
	}
}
