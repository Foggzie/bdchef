using System.Collections.Generic;

using Newtonsoft.Json;

using UnityEngine;

namespace BDChef
{
	public static class DataReader
	{
		public static Book ReadBook(string itemFile, string recipeFile)
		{
			var itemText = Resources.Load(itemFile) as TextAsset;
			Utils.NullAsset(itemText, "Couldn't load resource: " + itemFile);

			var recipeText = Resources.Load(recipeFile) as TextAsset;
			Utils.NullAsset(recipeText, "Couldn't load resource: " + recipeFile);

			return new Book(Parse<Item>(itemText), Parse<Recipe>(recipeText));
		}

		private static List<T> Parse<T>(string stringData)
		{
			var data = JsonConvert.DeserializeObject<List<T>>(stringData);
			return data;
		}
	}
}