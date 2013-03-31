using MediComponents.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediComponents.Data.Mappers
{
	public static class CSCMapper
	{
		public static IEnumerable<CorticosteroidConversionChart> ParseList(XDocument doc)
		{
			return from chart in doc.Elements("Chart")
				   select ParseChart(chart);
		}
		public static IEnumerable<CorticosteroidConversionChart> ParseList(string doc)
		{
			return ParseList(XDocument.Parse(doc));
		}

		public static CorticosteroidConversionChart ParseChart(XElement element)
		{
			CorticosteroidConversionChart chart = new CorticosteroidConversionChart()
			{
				Compound = element.Attribute("Compound").GetValue(),
				Chart = new ObservableCollection<CorticoSteroidConversion>()
			};
			foreach (XElement el in element.Elements("Compound"))
				chart.Chart.Add(Parse(el));
			return chart;
		}
		public static CorticosteroidConversionChart ParseChart(string element)
		{
			return ParseChart(XElement.Parse(element));
		}

		public static CorticoSteroidConversion Parse(XElement element)
		{
			return new CorticoSteroidConversion()
			{
				Compound = element.Attribute("Compound").GetValue(),
				EquivalentDose = element.Attribute("EquivalentDose").GetValueAsDouble(),
				AntiInflammatoryPotency = element.Attribute("AntiInflammatoryPotency").GetValueAsDouble() ?? -1,
				MineralocorticoidPotency = element.Attribute("MineralocorticoidPotency").GetValueAsDouble() ?? -1,
				BiologicalHalfLife = element.Attribute("BiologicalHalfLife").GetValue()
			};
		}
		public static CorticoSteroidConversion Parse(string element)
		{
			return Parse(XElement.Parse(element));
		}
	}
}
