using MediComponents.Model;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace MediComponents.ViewModel
{
	[DataContract]
	public class MainViewModel : ViewModel
	{
		[DataMember]
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

		public MainViewModel() : base() { }
		public MainViewModel(bool isDesign) : base(isDesign) { }

		protected override void InitializeRunTime()
		{
			LoadPages();
		}

		protected override void InitializeDesignTime()
		{
			Pages = new ObservableCollection<PageInfo>();
			Pages.Add(new PageInfo() { Title = "Apgar", Summary = "Newborn Evaluation" });
		}

		public override bool Rehydrate(object vm)
		{
			var other = vm as MainViewModel;
			if (other == null)
				return false;
			Pages = other.Pages;
			return base.Rehydrate(vm);
		}

		private void LoadPages()
		{
			Pages = new ObservableCollection<PageInfo>();
			Pages.AddAll(Data.Mappers.PageInfoMapper.ParseList(XDocument.Load("/Assets/Pages.xml")));
		}
	}
}
