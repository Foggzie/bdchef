using System.Collections.Generic;

namespace BDChef
{
	public class Recipe : Item
	{
		public SkillLevel Level { get; private set; }

		public Recipe()
		{
			Source = ItemSource.Prepared;
		}

		private Dictionary<Item, int> m_items = new Dictionary<Item, int>();
	}
}