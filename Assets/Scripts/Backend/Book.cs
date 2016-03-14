using System.Collections.Generic;

namespace BDChef
{
	/// <summary>
	/// A collection of items and recipes.
	/// </summary>
	public class Book
	{
		public Book(IEnumerable<Item> items, IEnumerable<Recipe> recipes)
		{
			m_items = new HashSet<Item>(items);
			m_recipes = new HashSet<Recipe>(recipes);
		}

		HashSet<Item> m_items;
		HashSet<Recipe> m_recipes;
	}
}