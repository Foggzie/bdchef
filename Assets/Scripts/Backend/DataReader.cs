using UnityEngine;
using Newtonsoft.Json;

namespace BDChef
{
	public static class DataReader
	{
		public static Book ReadBook(string itemFile, string recipeFile)
		{
			// READ IN DATA
			Book ofTheKing = new Book(null, null);

			var itemText = Resources.Load(itemFile) as TextAsset;
			Utils.NullAsset(itemText, "Couldn't load resource: " + itemFile);

			var recipeText = Resources.Load(recipeFile) as TextAsset;
			Utils.NullAsset(recipeText, "Couldn't load resource: " + recipeFile);

			return ofTheKing;
		}
	}
}