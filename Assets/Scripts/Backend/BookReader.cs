using System.Collections.Generic;

using Newtonsoft.Json;

using UnityEngine;

namespace BDChef
{
	public static class BookReader
	{
		public static Book ReadBook(string itemFile, string recipeFile)
		{
			TextAsset itemText = (TextAsset)Resources.Load(itemFile, typeof(TextAsset));
			Utils.NullAsset(itemText, "Couldn't load resource: " + itemFile);

			TextAsset recipeText = (TextAsset)Resources.Load(recipeFile, typeof(TextAsset));
			Utils.NullAsset(recipeText, "Couldn't load resource: " + recipeFile);

			return new Book(
				Parse<Item>(itemText.text),
				Parse<Recipe>(recipeText.text));
		}

		private static List<T> Parse<T>(string stringData)
		{
			var data = JsonConvert.DeserializeObject<List<T>>(stringData);
			return data;
		}
	}
}