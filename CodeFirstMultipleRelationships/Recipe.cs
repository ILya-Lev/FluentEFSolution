using System.Collections.Generic;

namespace CodeFirstMultipleRelationships
{
	public class Recipe
	{
		public int RecipeId { get; set; }

		public string RecipeName { get; set; }

		public string Headnote { get; set; }

		public ICollection<Ingredient> Ingredients { get; set; }
	}
}