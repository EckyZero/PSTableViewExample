using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace PSTableViewExample.iOS
{
	public class CountriesViewModel
	{
		public Action<CountryItemViewModel> RequestNextPage;

		public ObservableCollection<CountryItemViewModel> Items;

		public CountriesViewModel ()
		{
			Items = new ObservableCollection<CountryItemViewModel> ();

			var apple = new Fruit ("Apple", "The apple tree is a deciduous tree in the rose family best known for its sweet, pomaceous fruit, the apple.");
			var orange = new Fruit ("Orange", "The orange is the fruit of the citrus species Citrus × sinensis in the family Rutaceae.");
			var mango = new Fruit ("Mango", "The mango is a juicy stone fruit belonging to the genus Mangifera, consisting of numerous tropical fruiting trees, cultivated mostly for edible fruit.");
			var cheeseburger = new Fruit ("Cheeseburger", "A cheeseburger is a hamburger topped with cheese. Traditionally, the slice of cheese is placed on top of the meat patty, but the burger can include many variations in structure, ingredients, and composition.");
			var pizza = new Fruit ("Pizza", "Pizza is an oven-baked flat bread generally topped with tomato sauce and cheese. It is commonly supplemented with a selection of meats, vegetables and condiments.");
			var bacon = new Fruit ("Bacon", "Bacon is a meat product prepared from a pig and usually cured. It is first cured using large quantities of salt, either in a brine or in a dry packing; the result is fresh bacon.");

			var america = new Country ("United States of America", "Washington D.C.", new List<Fruit> { cheeseburger, pizza, bacon });
			var mexico = new Country ("Mexico", "Mexico City", new List<Fruit> { orange });
			var korea = new Country ("South Korea", "Seoul", new List<Fruit> { mango, apple, orange });
			var germany = new Country ("Germany", "Berlin", new List<Fruit> { apple, orange });

			var countries = new List<Country> () { america, mexico, korea, germany };

			foreach (Country country in countries) {
				var viewModel = new CountryItemViewModel (country);
				viewModel.OnSelected = OnSelected;
				Items.Add (viewModel);
			}
		}

		public void OnSelected (IListItemViewModel item) 
		{
			if(RequestNextPage != null) {
				RequestNextPage (item as CountryItemViewModel);
			}
		}
	}
}

