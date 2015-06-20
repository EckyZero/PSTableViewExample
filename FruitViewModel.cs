using System;
using System.Collections.ObjectModel;
using PSTableViewExample.iOS;

namespace PSTableViewExample
{
	public class FruitViewModel
	{
		public ObservableCollection<IListItemViewModel> Items;

		public FruitViewModel (CountryItemViewModel countryViewModel)
		{
			Items = new ObservableCollection<IListItemViewModel> ();

			foreach (Fruit fruit in countryViewModel.Country.Fruits) {
				var viewModel = new FruitItemViewModel(fruit);
				Items.Add(viewModel);
			}
		}
	}
}

