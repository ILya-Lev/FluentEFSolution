using System.Collections.Generic;

namespace SampleCodeFirst.Model
{
	public class Recipe
	{
		public int RecipeId { set; get; }
		public string RecipeName { get; set; }
		public string Source { get; set; }
		public string Headnote { get; set; }
		public List<RecipeStep> Steps { get; set; }
		public List<RecipeIngredient> Ingredients { get; set; }
	}
}
