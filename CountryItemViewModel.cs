using System;
using System.Collections.ObjectModel;
using PSTableViewExample.iOS;

namespace PSTableViewExample
{
	public class CountryItemViewModel : IListItemViewModel
	{
		#region Actions

		public Action<IListItemViewModel> OnSelected { get; set; }

		#endregion

		#region Private Variables

		internal Country Country;

		#endregion

		#region Member Properties

		public CellType CellType {
			get { return CellType.Country; }
		}

		public string Title {
			get { return Country.Name; }
		}

		public string Subtitle {
			get { return Country.Capital; }
		}

		#endregion

		#region Methods

		public CountryItemViewModel (Country country)
		{
			Country = country;
		}

		public void Selected ()
		{
			if(OnSelected != null) {
				OnSelected (this);
			}
		}

		#endregion
	}
}

