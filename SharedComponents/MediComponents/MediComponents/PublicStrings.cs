using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediComponents
{
	public class PublicStrings
	{
		private static Strings _strings = new Strings();
		public Strings Strings { get { return _strings; } }
	}
}
