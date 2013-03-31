using MediComponents.Model;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MediComponents.Data.Mappers
{
	public static class PageInfoMapper
	{
		public static IEnumerable<PageInfo> ParseList(XDocument doc)
		{
			return from PageInfo page in (from XElement el in doc.Ancestors("Page")
										  select Parse(el))
					   where page.IsValid()
					   select page;
		}

		public static IEnumerable<PageInfo> ParseList(string doc)
		{
			return ParseList(XDocument.Parse(doc));
		}

		public static PageInfo Parse(XElement element)
		{
			try
			{
				return new PageInfo()
				{
					Summary = element.Attribute("Summary").GetValue(),
					Target = element.Attribute("Target").GetValueAsRelativeUri(),
					Title = element.Attribute("Title").GetValue()
				};
			}
			catch
			{
				return null;
			}
		}
		
		public static PageInfo Parse(string element)
		{
			return Parse(XElement.Parse(element));
		}
	}
}
