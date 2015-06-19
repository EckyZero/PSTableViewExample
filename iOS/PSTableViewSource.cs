using System;
using UIKit;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Foundation;
using System.Linq;

namespace PSTableViewExample.iOS
{
	public class PSTableViewSource : UITableViewSource
	{
		IEnumerable<IListItemViewModel> _viewModels; 
		float _estimatedHeight;

		public PSTableViewSource (IEnumerable<IListItemViewModel> viewModels, float estimatedHeight = 75f)
		{
			_viewModels = viewModels;
			_estimatedHeight = estimatedHeight;
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _viewModels.Count();
		}

		public override nfloat EstimatedHeight (UITableView tableView, NSIndexPath indexPath)
		{
			return _estimatedHeight;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var viewModel = _viewModels.ElementAt (indexPath.Row);
			var identifier = BaseCell.GetIdentifier (viewModel);
			var cell = tableView.DequeueReusableCell (identifier) as BaseCell;

			cell.Configure (viewModel);

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var viewModel = _viewModels.ElementAt (indexPath.Row);

			viewModel.Selected ();
		}
	}
}

