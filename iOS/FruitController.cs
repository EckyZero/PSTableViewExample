using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Linq;

namespace PSTableViewExample.iOS
{
	partial class FruitController : UIViewController
	{
		public  FruitViewModel ViewModel;

		public FruitController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			TableView.Source = new PSTableViewSource (ViewModel.ViewModels.Cast<IListItemViewModel>());
		}
	}
}
