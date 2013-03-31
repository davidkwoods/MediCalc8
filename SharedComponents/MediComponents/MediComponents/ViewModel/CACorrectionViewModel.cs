
namespace MediComponents.ViewModel
{
	public class CACorrectionViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.CACorrectionTitle); }
		}

		private double _albumin;
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
	}
}
