using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace PSTableViewExample.iOS
{
	public class CountriesViewModel
	{
		public Action<CountryItemViewModel> RequestNextPage;

		public ObservableCollection<IListItemViewModel> Items;

		public CountriesViewModel ()
		{
			Items = new ObservableCollection<IListItemViewModel> ();

			var apple = new Fruit ("Apple", "The apple tree is a deciduous tree in the rose family best known for its sweet, pomaceous fruit, the apple.");
			var orange = new Fruit ("Orange", "The orange is the fruit of the citrus species Citrus × sinensis in the family Rutaceae.");
			var mango = new Fruit ("Mango", "The mango is a juicy stone fruit belonging to the genus Mangifera, consisting of numerous tropical fruiting trees, cultivated mostly for edible fruit.");
			var cheeseburger = new Fruit ("Cheeseburger", "A cheeseburger is a hamburger topped with cheese. Traditionally, the slice of cheese is placed on top of the meat patty, but the burger can include many variations in structure, ingredients, and composition.");
			var pizza = new Fruit ("Pizza", "Pizza is an oven-baked flat bread generally topped with tomato sauce and cheese. It is commonly supplemented with a selection of meats, vegetables and condiments.");
			var bacon = new Fruit ("Bacon", "Bacon is a meat product prepared from a pig and usually cured. It is first cured using large quantities of salt, either in a brine or in a dry packing; the result is fresh bacon.");
			var banana = new Fruit ("Banana", "A banana is an edible fruit, botanically a berry, produced by several kinds of large herbaceous flowering plants in the genus Musa.");
			var kiwi = new Fruit ("Kiwi", "The kiwifruit or Chinese gooseberry is the edible berry of a woody vine in the genus Actinidia.");

			AddNorthAmerica (new List<Fruit> { cheeseburger, pizza, bacon });
			AddAsia (new List<Fruit> { apple, orange, mango });
			AddEurope (new List<Fruit> { kiwi, banana });

			foreach (IListItemViewModel viewModel in Items) {
				viewModel.OnSelected = OnSelected;
			}
		}

		private void AddNorthAmerica (List<Fruit> fruits)
		{
			var northAmerica = new HeaderViewModel ("North America");
			var usa = new CountryItemViewModel(new Country ("United States of America", "Washington D.C.", fruits));
			var canada = new CountryItemViewModel(new Country ("Canada", "Otawa", fruits));

			Items.Add (northAmerica);
			Items.Add (usa);
			Items.Add (canada);
		}

		private void AddAsia (List<Fruit> fruits) 
		{
			var asia = new HeaderViewModel ("Asia");
			var korea = new CountryItemViewModel(new Country ("South Korea", "Seoul", fruits));
			var japan = new CountryItemViewModel( new Country ("Japan", "Tokyo", fruits));

			Items.Add (asia);
			Items.Add (korea);
			Items.Add (japan);
		}

		private void AddEurope (List<Fruit> fruits)
		{
			var europe = new HeaderViewModel ("Europe");
			var germany = new CountryItemViewModel(new Country ("Germany", "Berlin", fruits));
			var france = new CountryItemViewModel(new Country ("France", "Paris", fruits));
			var england = new CountryItemViewModel(new Country ("England", "London", fruits));
			var spain = new CountryItemViewModel (new Country ("Spain", "Madrid", fruits));

			Items.Add (europe);
			Items.Add (germany);
			Items.Add (france);
			Items.Add (england);
			Items.Add (spain);
		}

		public void OnSelected (IListItemViewModel item) 
		{
			if(RequestNextPage != null) {
				RequestNextPage (item as CountryItemViewModel);
			}
		}
	}
}

