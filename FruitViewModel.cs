using System;
using System.Collections.ObjectModel;
using PSTableViewExample.iOS;

namespace PSTableViewExample
{
	public class FruitViewModel
	{
		public ObservableCollection<FruitItemViewModel> ViewModels;

		public FruitViewModel (CountryItemViewModel countryViewModel)
		{
			ViewModels = new ObservableCollection<FruitItemViewModel> ();

			foreach (Fruit fruit in countryViewModel.Country.Fruits) {
				var viewModel = new FruitItemViewModel(fruit);
				ViewModels.Add(viewModel);
			}
		}
	}
}

