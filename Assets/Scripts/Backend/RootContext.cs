using UnityEngine;

namespace BDChef
{
	public class RootContext : MonoBehaviour {

		void Start ()
		{
			m_book = BookReader.ReadBook(
				"Cooking/Data/items",
				"Cooking/Data/recipes");
		}

		private Book m_book;
	}
}