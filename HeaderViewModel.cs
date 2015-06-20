using System;

namespace PSTableViewExample
{
	public class HeaderViewModel : IListItemViewModel
	{
		#region Actions

		public Action<IListItemViewModel> OnSelected { get; set; }

		#endregion

		#region Private Variables

		private string _text;

		#endregion

		#region Member Properties

		public CellType CellType {
			get { return CellType.Header; }
		}

		public string Text { 
			get { return _text; }
		}

		#endregion

		#region Methods

		public HeaderViewModel (string text)
		{
			_text = text;
		}
			
		public void Selected () { /* Ignore */ }

		#endregion
	}
}

