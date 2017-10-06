using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstMultipleRelationships
{
	public class Ingredient
	{
		[Key]
		[Column(Order = 0)]
		public int IngredientId { get; set; }

		[Key]
		[Column(Order = 1)]
		public int RecipeId { get; set; }

		[InverseProperty("Ingredients")]
		public Recipe MadeFrom { get; set; }

		public string IngredientName { get; set; }
	}
}