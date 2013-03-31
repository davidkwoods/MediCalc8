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
	public class MainViewModel : ViewModel
	{
		public ObservableCollection<PageInfo> Pages { get; private set; }

		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		private string _subtitle;
		public string Subtitle
		{
			get { return _subtitle; }
			set { SetProperty(ref _subtitle, value); }
		}

		protected override void Initialize()
		{
			LoadPages();
		}

		private void LoadPages()
		{
			Pages = new ObservableCollection<PageInfo>();
			Pages.AddAll(Data.Mappers.PageInfoMapper.ParseList(XDocument.Load("/Assets/Pages.xml")));
		}
	}
}
