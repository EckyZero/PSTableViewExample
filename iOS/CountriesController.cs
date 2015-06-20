using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Linq;

namespace PSTableViewExample.iOS
{
	partial class CountriesController : UIViewController
	{
		public CountriesViewModel ViewModel = new CountriesViewModel ();

		public CountriesController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			TableView.Source = new PSTableViewSource (ViewModel.Items);

			ViewModel.RequestNextPage = OnRequestNextPage;
		}

		private void OnRequestNextPage (CountryItemViewModel viewModel) 
		{
			var storyboard = UIStoryboard.FromName ("Main", null);
			var controller = storyboard.InstantiateViewController ("FruitController") as FruitController;

			controller.ViewModel = new FruitViewModel (viewModel);

			NavigationController.PushViewController (controller, true);
		}
	}
}
