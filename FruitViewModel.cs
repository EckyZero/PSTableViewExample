using System;
using System.Collections.ObjectModel;
using PSTableViewExample.iOS;

namespace PSTableViewExample
{
	public class FruitViewModel
	{
		public ObservableCollection<FruitItemViewModel> Items;

		public FruitViewModel (CountryItemViewModel countryViewModel)
		{
			Items = new ObservableCollection<FruitItemViewModel> ();

			foreach (Fruit fruit in countryViewModel.Country.Fruits) {
				var viewModel = new FruitItemViewModel(fruit);
				Items.Add(viewModel);
			}
		}
	}
}

