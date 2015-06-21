using System;
using UIKit;

namespace PSTableViewExample.iOS
{
	public abstract class BaseCell : UITableViewCell
	{
		protected BaseCell (IntPtr handle) : base (handle)
		{
		}

		public abstract void ConfigureSubviews (IListItemViewModel viewModel);

		public void Configure (IListItemViewModel viewModel)
		{
			ConfigureSubviews (viewModel);

			ContentView.LayoutIfNeeded ();
		}

		public static string GetIdentifier (IListItemViewModel viewModel)
		{
			var identifier = "";

			if (viewModel != null)
			{
				switch (viewModel.CellType) {
					case CellType.Country:
						identifier = CountryCell.Key;
						break;
					case CellType.Fruit:
						identifier = FruitCell.Key;
						break;
					case CellType.Header:
						identifier = HeaderCell.Key;
						break;
				}
			}
			return identifier;
		}
	}
}

