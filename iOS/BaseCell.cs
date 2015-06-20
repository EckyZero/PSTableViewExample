using System;
using UIKit;

namespace PSTableViewExample.iOS
{
	public abstract class BaseCell : UITableViewCell
	{
		protected BaseCell (IntPtr handle) : base (handle)
		{
		}

		public virtual nfloat CalculateHeight (IListItemViewModel viewModel)
		{
			var device = UIDevice.CurrentDevice;
			var osVersion =  nint.Parse(device.SystemVersion.Substring(0,1)); 
			var height = UITableView.AutomaticDimension;

			if(osVersion < 8)
			{
				Configure (viewModel);
				height = ContentView.SystemLayoutSizeFittingSize (UILayoutFittingCompressedSize).Height;
			}
			return height;
		}

		public virtual void Configure (IListItemViewModel baseViewModel)
		{
			
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

