using System.Collections.Generic;

namespace BDChef
{
	/// <summary>
	/// A collection of items and recipes.
	/// </summary>
	public class Book
	{
		HashSet<Item> m_items;
		HashSet<Recipe> m_recipes;
	}
}