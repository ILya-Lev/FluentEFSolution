using System.Collections.Generic;

namespace FinalSample.Model
{
	public class Recipe
	{
		public int RecipeId { get; set; }
		public string RecipeName { get; set; }
		public int RecipeSourceId { get; set; }
		public string Headnote { get; set; }
		public RecipeSource RecipeSource { get; set; }
		public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
		public ICollection<RecipeStep> RecipeSteps { get; set; }
	}
}