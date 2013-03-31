using System;

namespace MediComponents.Model
{
	public class PageInfo : ObservableObject, ISelfValidating
	{
		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		private string _summary;
		public string Summary
		{
			get { return _summary; }
			set { SetProperty(ref _summary, value); }
		}

		private Uri _target;
		public Uri Target
		{
			get { return _target; }
			set { SetProperty(ref _target, value); }
		}

		public bool IsValid()
		{
			return
				Target != null &&
				Title != null &&
				Summary != null;
		}
	}
}
