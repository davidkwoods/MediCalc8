using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediComponents.Model
{
	public class CorticosteroidConversionChart : ObservableObject
	{
		public string Compound;
		public ObservableCollection<CorticoSteroidConversion> Chart;
	}

	public class CorticoSteroidConversion : ObservableObject, ISelfValidating
	{
		public string Compound;
		public double? EquivalentDose;
		public double AntiInflammatoryPotency;
		public double MineralocorticoidPotency;
		public string BiologicalHalfLife;

		public bool IsValid()
		{
			return
				AntiInflammatoryPotency >= 0 &&
				MineralocorticoidPotency >= 0;
		}
	}
}
