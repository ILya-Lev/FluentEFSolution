using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstAnnotations.Model
{
	public class BakersPercentage
	{
		[ForeignKey("IngredientAmount")]
		public int Id { get; set; }

		public decimal Percentage { get; set; }

		public IngredientAmount IngredientAmount { get; set; }
	}
}