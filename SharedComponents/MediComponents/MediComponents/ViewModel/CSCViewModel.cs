using MediComponents.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediComponents.ViewModel
{
	public class CSCViewModel : ViewModel
	{
		private string _chartUri = "/Assets/CSCCharts.xml";
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

		protected override void Initialize()
		{
			Charts = new ObservableCollection<CorticosteroidConversionChart>();
			foreach (var chart in Data.Mappers.CSCMapper.ParseList(XDocument.Load(_chartUri)))
			{
				Charts.Add(chart);
			}

			_currentDose = 0;
			SelectedChart = Charts.First(); // Cascades to set up selections
		}
	}
}
