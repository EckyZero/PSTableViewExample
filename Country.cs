using System;
using PSTableViewExample.iOS;
using System.Collections.Generic;

namespace PSTableViewExample
{
	public class Country
	{
		public string Name { get; set; }
		public string Capital { get; set; }
		public List<Fruit> Fruits { get; set; }

		public Country (string name, string capital, List<Fruit> fruits)
		{
			Name = name;
			Capital = capital;
			Fruits = fruits;
		}
	}
}

