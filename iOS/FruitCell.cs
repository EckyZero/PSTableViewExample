using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PSTableViewExample.iOS
{
	partial class FruitCell : BaseCell
	{
		public const string Key = "FruitCell";

		public FruitCell (IntPtr handle) : base (handle)
		{
		}

		public override void Configure (IListItemViewModel baseViewModel)
		{
			base.Configure (baseViewModel);

			var viewModel = baseViewModel as FruitItemViewModel;

			NameLabel.Text = viewModel.Title;
			DescriptionLabel.Text = viewModel.Subtitle;

			ContentView.LayoutIfNeeded ();
		}
	}
}
