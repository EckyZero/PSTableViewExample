using System;
using System.Collections.ObjectModel;

namespace PSTableViewExample
{
	public interface IListItemViewModel
	{
		Action<IListItemViewModel> OnSelected { get; set; }
		CellType CellType { get; }
		void Selected ();
	}
}

