using System;
using PSTableViewExample.iOS;

namespace PSTableViewExample
{
	public class FruitItemViewModel : IListItemViewModel
	{
		#region Actions

		public Action<IListItemViewModel> OnSelected { get; set; }

		#endregion

		#region Private Variables

		private Fruit _fruit;

		#endregion

		#region Member Properties

		public CellType CellType {
			get { return CellType.Fruit; }
		}

		public string Title {
			get { return _fruit.Name; }
		}

		public string Subtitle {
			get { return _fruit.Description; }
		}

		#endregion

		#region Methods

		public FruitItemViewModel (Fruit fruit)
		{
			_fruit = fruit; 
		}

		public void Selected ()
		{
			if(OnSelected != null) {
				OnSelected (this);
			}
		}

		#endregion
	}
}

