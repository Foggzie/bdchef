using UnityEngine;

namespace BDChef
{
	public static class Utils
	{
		public static void NullAsset(System.Object obj, string message = null)
		{
			Assert(obj != null, message);
		}

		public static void Assert(bool condition, string message = null)
		{
			if (!condition)
			{
				if (message == null)
				{
					message = "Assert Failed";
				}

				Debug.LogError(message);
			}
		}
	}
}