using MediComponents.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class CSCViewModel : ViewModel
	{
		private static string _chartUri = "/Assets/CSCCharts.xml";
		[DataMember]
		public ObservableCollection<CorticosteroidConversionChart> Charts;

		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.CSCTitle); }
		}

		public ObservableCollection<CorticoSteroidConversion> Conversions
		{
			get { return SelectedChart.Chart; }
		}

		private CorticosteroidConversionChart _selectedChart;
		[DataMember]
		public CorticosteroidConversionChart SelectedChart
		{
			get { return _selectedChart; }
			set
			{
				int conversionIndex = SelectedConversion == null ? 0 : Conversions.IndexOf(SelectedConversion);
				if (SetProperty(ref _selectedChart, value))
				{
					OnPropertyChanged(() => Conversions);
					SelectedConversion = Conversions.Count > conversionIndex ? Conversions[conversionIndex] : Conversions.First();
				}
			}
		}

		private CorticoSteroidConversion _selectedConversion;
		[DataMember]
		public CorticoSteroidConversion SelectedConversion
		{
			get { return _selectedConversion; }
			set
			{
				if (SetProperty(ref _selectedConversion, value))
					OnPropertyChanged(() => Result);
			}
		}

		private double _currentDose;
		[DataMember]
		public double CurrentDose
		{
			get { return _currentDose; }
			set
			{
				if (SetProperty(ref _currentDose, value))
					OnPropertyChanged(() => Result);
			}
		}

		public double Result
		{
			get { return CurrentDose * SelectedConversion.EquivalentDose ?? 0; }
		}

		public CSCViewModel() : base() { }
		public CSCViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeDesignTime()
		{
			Charts = new ObservableCollection<CorticosteroidConversionChart>();
			var chart = new CorticosteroidConversionChart() { Compound = "Cortisone" };
			chart.Chart = new ObservableCollection<CorticoSteroidConversion>();
			chart.Chart.Add(new CorticoSteroidConversion()
				{
					Compound = "Hydrocortisone",
					EquivalentDose = 0.8
				});
			Charts.Add(chart);
			_currentDose = 1.5;
			SelectedChart = Charts.First();
		}

		protected override void InitializeRunTime()
		{
			Charts = new ObservableCollection<CorticosteroidConversionChart>();
			foreach (var chart in Data.Mappers.CSCMapper.ParseList(XDocument.Load(_chartUri)))
			{
				Charts.Add(chart);
			}

			_currentDose = 0;
			SelectedChart = Charts.First(); // Cascades to set up selections
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as CSCViewModel;
			if (other == null)
				return false;
			Charts = other.Charts;
			SelectedChart = other.SelectedChart;
			SelectedConversion = other.SelectedConversion;
			CurrentDose = other.CurrentDose;
			return base.Rehydrate(vm);
		}
	}
}
