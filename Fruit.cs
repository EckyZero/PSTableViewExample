using System;
using System.Collections.Generic;

namespace PSTableViewExample.iOS
{
	public class Fruit
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public Fruit (string name, string description)
		{
			Name = name;
			Description = description;
		}
	}
}

