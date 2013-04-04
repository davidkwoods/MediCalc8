using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;

namespace MediComponents
{
	public static class Helpers
	{
		public static T GetExistingOrNew<T>(ref T backer) where T : new()
		{
			if (backer == null)
				backer = new T();
			return backer;
		}
		
		public static string GetValue(this XAttribute attribute)
		{
			return attribute != null ? attribute.Value : null;
		}

		public static bool? GetValueAsBoolean(this XAttribute attribute)
		{
			if (attribute != null)
			{
				bool result;
				if (Boolean.TryParse(attribute.Value, out result))
					return result;
			}
			return null;
		}

		public static int? GetValueAsInt(this XAttribute attribute)
		{
			if (attribute != null)
			{
				int result;
				if (Int32.TryParse(attribute.Value, out result))
					return result;
			}
			return null;
		}

		public static double? GetValueAsDouble(this XAttribute attribute)
		{
			if (attribute != null)
			{
				double result;
				if (double.TryParse(attribute.Value, out result))
					return result;
			}
			return null;
		}

		public static Uri GetValueAsUri(this XAttribute attribute)
		{
			if (attribute != null)
			{
				Uri result;
				if (Uri.TryCreate(attribute.Value, UriKind.Absolute, out result))
					return result;
			}
			return null;
		}

		public static Uri GetValueAsRelativeUri(this XAttribute attribute)
		{
			if (attribute != null)
			{
				Uri result;
				if (Uri.TryCreate(attribute.Value, UriKind.Relative, out result))
					return result;
			}
			return null;
		}

		public static void AddAll<T>(this ObservableCollection<T> collection, IEnumerable<T> newList)
		{
			foreach (var item in newList)
			{
				collection.Add(item);
			}
		}

		public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> newList, int skip, int take)
		{
			collection.AddAll(newList.Skip(skip).Take(take));
		}
	}
}
