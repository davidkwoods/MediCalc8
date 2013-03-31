
namespace MediComponents.ViewModel
{
	public class ABCompViewModel : ViewModel
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ABCompTitle); }
		}

		private int _ph;
		public int Ph
		{
			get { return _ph; }
			set
			{
				if (SetProperty(ref _ph, value))
					State = 0;
			}
		}

		private int _hco3;
		public int Hco3
		{
			get { return _hco3; }
			set
			{
				if (SetProperty(ref _hco3, value))
					State = 0;
			}
		}

		private int _pco2;
		public int Pco2
		{
			get { return _pco2; }
			set
			{
				if (SetProperty(ref _pco2, value))
					State = 0;
			}
		}

		private AbState _state;
		public AbState State
		{
			get { return _state; }
			set
			{
				if (Ph == 0 && Pco2 == 0 && Hco3 == 0)
					_state = AbState.MetaAcid;
				else if (Ph == 1 && Pco2 == 1 && Hco3 == 1)
					_state = AbState.MetaAlka;
				else if (Ph == 0 && Pco2 == 1 && Hco3 == 1)
					_state = AbState.RespAcid;
				else if (Ph == 1 && Pco2 == 0 && Hco3 == 0)
					_state = AbState.RespAlka;
				else
					_state = AbState.Unknown;
				OnPropertyChanged(() => IndicationString);
			}
		}

		public string IndicationString
		{
			get
			{
				switch (_state)
				{
					case AbState.MetaAcid:
						return string.Format(Strings.IndicativeOfFormat, Strings.MetaAcid);
					case AbState.MetaAlka:
						return string.Format(Strings.IndicativeOfFormat, Strings.MetaAlka);
					case AbState.RespAcid:
						return string.Format(Strings.IndicativeOfFormat, Strings.RespAcid);
					case AbState.RespAlka:
						return string.Format(Strings.IndicativeOfFormat, Strings.RespAlka);
					default:
						return string.Format(Strings.IndicativeOfFormat, Strings.AnionGapExplanation);
				}
			}
		}


		protected override void Initialize()
		{
			Ph = 0;
			Pco2 = 0;
			Hco3 = 0;
		}
	}

	public enum AbState
	{
		Unknown = 0,
		MetaAcid = 1,
		MetaAlka = 2,
		RespAcid = 3,
		RespAlka = 4
	}
}

