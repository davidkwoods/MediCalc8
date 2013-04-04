using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediComponents.ViewModel
{
	public static class NormalValues
	{
		// Hematologic Values
		public static GenderSplitRange Hemoglobin = new GenderSplitRange()
		{
			Male = new Range(14, 18, " gm/dl"),
			Female = new Range(12, 16, " gm/dl")
		};
		public static GenderSplitRange Hematocrit = new GenderSplitRange()
		{
			Male = new Range(41, 50, "%"),
			Female = new Range(36, 45, "%")
		};
		public static GenderSplitRange Erythrocytes = new GenderSplitRange()
		{
			Male = new Range(4.7, 6.1, " M/μL"),
			Female = new Range(4.2, 5.4, " M/μL")
		};
		public static GenderSplitRange RBC { get { return Erythrocytes;}}
		public static Range WhiteBloodCells = new Range(4.8, 10.8, " K/μL");
		public static Range WBC { get { return WhiteBloodCells;}}
		public static GenderSplitRange Neutrophils = new GenderSplitRange()
		{
			Male = new Range(50, 75, "%"),
			Female = new Range(45, 70, "%")
		};
		public static Range Lymphocytes = new Range(20, 45, "%");
		public static Range Monocytes = new Range(0, 10, "%");
		public static Range Eosinophils = new Range(0, 5, "%");
		public static Range Basophils = new Range(0, 5, "%");
		public static Range Platelets = new Range(140, 440, " K/μL");
		public static GenderSplitRange SedimentationRateUnder50 = new GenderSplitRange()
		{
			Male = new Range(0, 15, " mm/hr"),
			Female = new Range(0, 20, " mm/hr")
		};
		public static GenderSplitRange SedimentationRate50OrOver = new GenderSplitRange()
		{
			Male = new Range(0, 20, " mm/hr"),
			Female = new Range(0, 30, " mm/hr")
		};
		public static Range MCH = new Range(25, 35, " pg/cell");
		public static Range MCV = new Range(78, 100, " μm³");
		public static Range MCHC = new Range(31, 37, " g/dl");
		public static Range RDW = new Range(11.5, 14.5, "%");

		// Iron/Transport Proteins
		public static Range Iron = new Range(60, 150, " μg/dL");
		public static Range TIBC = new Range(250, 400, " μg/dL");
		public static Range SerumFerritin = new Range(12, 300, " μg/ml");
		public static Range TransferrinSaturation = new Range(20, 45, "%");

		// Clotting Studies
		public static Range PT = new Range(12.2, 14.2, " sec");
		public static Range PTInfant = new Range(10.9, 13.9, " sec");
		public static Range aPTT = new Range(23, 36, " sec");
		public static Range aPTTInfant = new Range(34, 51, " sec");

		// Lymphocytes in peripheral blood
		public static Range CD19 = new Range(96, 421, " cells/μL");
		public static Range CD19Percent = new Range(4, 20, "%");
		public static Range CD3 = new Range(700, 2500, " cells/μL");
		public static Range CD3Percent = new Range(62, 85, "%");
		public static Range CD2 = new Range(840, 2800, " cells/μL");
		public static Range CD2Percent = new Range(70, 88, "%");
		public static Range CD4 = new Range(430, 1600, " cells/μL");
		public static Range CD4Percent = new Range(34, 59, "%");
		public static Range CD8 = new Range(280, 1100, " cells/μL");
		public static Range CD8Percent = new Range(16, 38, "%");

		// Blood Gasses
		public static Range pH = new Range(7.38, 7.44);
		public static Range pO2 = new Range(80, 100, " mmHg");
		public static Range pCO2 = new Range(35, 45, " mmHg");
		public static Range HCO3 = new Range(21, 28, " mmol/L");

		// Enzymes
		public static GenderSplitRange AST = new GenderSplitRange()
		{
			Male = new Range(10, 40, " U/L"),
			Female = new Range(9, 25, " U/L")
		};
		public static GenderSplitRange AspartateAminotransferase { get { return AST; } }
		public static GenderSplitRange ALP = new GenderSplitRange()
		{
			Male = new Range(45, 155, " U/L"),
			Female = new Range(30, 100, " U/L")
		};
		public static GenderSplitRange AlkalinePhosphatase { get { return ALP; } }
		public static GenderSplitRange ALT = new GenderSplitRange()
		{
			Male = new Range(10, 55, " U/L"),
			Female = new Range(7, 30, " U/L")
		};
		public static GenderSplitRange AlanineAminotransferase { get { return ALT; } }
		public static GenderSplitRange GGT = new GenderSplitRange()
		{
			Male = new Range(1, 94, " U/L"),
			Female = new Range(1, 70, " U/L")
		};
		public static GenderSplitRange GammaGlutamylTransferase { get { return GGT; } }
		public static Range LDH = new Range(90, 250, " U/L");
		public static Range LactateDehydrogenase { get { return LDH; } }
		public static Range Lipase = new Range(3, 19, " U/dL");
		public static Range SerumAmylase = new Range(53, 123, " U/L");
		public static Range PlasmaAmylase = new Range(43, 115, " U/L");

		// Blood Chemistries
		public static Range Na = new Range(135, 144, " mmol/L");
		public static Range Sodium { get { return Na; } }
		public static Range K = new Range(3.5, 5, " mmol/L");
		public static Range Potassium { get { return K; } }
		public static Range KUnder12mo = new Range(3.5, 6, " mmol/L");
		public static Range PotassiumUnder12mo { get { return KUnder12mo; } }
		public static Range Cl = new Range(98, 107, " mmol/L");
		public static Range Chloride { get { return Cl; } }
		public static Range CO2 = new Range(22, 32, " mmol/L");
		public static Range BUN = new Range(8, 20, " mmol/L");
		public static Range BUN0to7days = new Range(3, 12, " mmol/L");
		public static GenderSplitRange Cr = new GenderSplitRange()
		{
			Male = new Range(0.7, 1.3, " mg/dL"),
			Female = new Range(0.6, 1.1, " mg/dL")
		};
		public static GenderSplitRange Creatinine { get { return Cr; } }
		public static Range GlucoseFasting = new Range(65, 110, " mg/dL");
		public static Range GlucoseFasting0to1mo = new Range(45, 90, " mg/dL");
		public static Range Ammonia = new Range(20, 120, " μg/dL");
		public static Range Phosphorus = new Range(2.3, 4.7, " mg/dL");
		public static Range CalciumTotal = new Range(9.2, 11, " mg/dL");
		public static Range CalciumIonized = new Range(4, 4.8, " mg/dL");
		public static Range Magnesium = new Range(1.8, 3, " mg/dL");
		public static Range SerumBilirubinTotal = new Range(0.2, 1.3, " mg/dL");
		public static Range SerumBilirubinDirect = new Range(0, 0.3, " mg/dL");
		public static Range TotalSerumProtein = new Range(6, 8, " g/dL");
		public static Range PreAlbumin = new Range(18, 38, " mg/dL");
		public static Range Albumin = new Range(3.9, 5, " g/dL");
		public static Range Globulin = new Range(2.3, 3.5, " g/dL");
		public static Range AlphaFetoprotein = new Range(0, 12.8, " U/dL");
		public static Range CEANonSmoker = new Range(0, 4.9, " ng/ml");
		public static Range CEASmoker = new Range(0, 9.9, " ng/ml");
		public static Range CarcinoembryonicAntigenNonSmoker { get { return CEANonSmoker; } }
		public static Range CarcinoembryonicAntigenSmoker { get { return CEASmoker; } }

		// Others
		public static Range TotalUrinaryProtein = new Range(0.05, 0.1, " gm/24hrs");
		public static Range CSFProtein = new Range(15, 45, " mg/dL");
		public static Range CSFGlucose = new Range(50, 75, " mg/dL");

	}

	public class GenderSplitRange
	{
		public Range Male;
		public Range Female;
	}
}
