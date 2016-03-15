using System.Collections.Generic;

namespace BDChef
{
	public class Recipe
	{
		public List<string> Input { get; private set; }

		public string OutPut { get; private set; }

		public SkillLevel Level { get; private set; }

		public Recipe()
		{
			
		}
	}
}