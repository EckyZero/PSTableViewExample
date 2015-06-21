using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PSTableViewExample.iOS
{
	partial class CountryCell : BaseCell
	{
		public const string Key = "CountryCell";

		public CountryCell (IntPtr handle) : base (handle)
		{
		}

		public override void ConfigureSubviews (IListItemViewModel baseViewModel)
		{
			var viewModel = baseViewModel as CountryItemViewModel;

			NameLabel.Text = viewModel.Title;
			CapitalLabel.Text = viewModel.Subtitle;
		}
	}
}
