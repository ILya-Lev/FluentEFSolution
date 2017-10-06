using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstAnnotations.Model
{
	public class IngredientAmount
	{
		public int Amount { get; set; }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AmountId { get; set; }

		public string Name { get; set; }

		public string Unit { get; set; }

		public BakersPercentage Percentage { get; set; }
	}
}