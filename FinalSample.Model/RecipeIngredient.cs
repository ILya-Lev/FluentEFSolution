using System.Collections.Generic;

namespace FinalSample.Model
{
	public class RecipeIngredient
	{
		public int RecipeId { get; set; }
		public int IngredientId { get; set; }
		public string Name { get; set; }
		public decimal Amount { get; set; }
		public int UnitId { get; set; }
		public ICollection<Recipe> Recipes { get; set; }
		public ICollection<Unit> Units { get; set; }
	}
}