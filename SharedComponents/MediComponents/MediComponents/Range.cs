using System;

namespace MediComponents
{
	public class Range : IComparable<double>, IEquatable<double>
	{
		public double Min { get; private set; }
		public double Max { get; private set; }
		public string Unit { get; private set; }

		public Range() { }
		public Range(double min, double max, string unit = null)
		{
			Min = min;
			Max = max;
			Unit = unit;
		}

		public int CompareTo(double other)
		{
			if (other > Max)
				return 1;
			if (other < Min)
				return -1;
			return 0;
		}

		public bool Equals(double other)
		{
			return CompareTo(other) == 0;
		}

		public static bool operator >(double x, Range range)
		{
			return range.CompareTo(x) > 0;
		}

		public static bool operator <(Range range, double x)
		{
			return range.CompareTo(x) > 0;
		}

		public static bool operator >(Range range, double x)
		{
			return range.CompareTo(x) < 0;
		}

		public static bool operator <(double x, Range range)
		{
			return range.CompareTo(x) < 0;
		}

		public static bool operator ==(double x, Range range)
		{
			return range.Equals(x);
		}

		public static bool operator ==(Range range, double x)
		{
			return range.Equals(x);
		}

		public static bool operator !=(double x, Range range)
		{
			return !range.Equals(x);
		}

		public static bool operator !=(Range range, double x)
		{
			return !range.Equals(x);
		}

		public static bool operator <=(double x, Range range)
		{
			return range.CompareTo(x) <= 0;
		}

		public static bool operator >=(double x, Range range)
		{
			return range.CompareTo(x) <= 0;
		}

		public static bool operator <=(Range range, double x)
		{
			return range.CompareTo(x) >= 0;
		}

		public static bool operator >=(Range range, double x)
		{
			return range.CompareTo(x) >= 0;
		}
	}
}
