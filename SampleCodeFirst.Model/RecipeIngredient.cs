namespace SampleCodeFirst.Model
{
	public class RecipeIngredient
	{
		public int RecipeIngredientId { get; set; }
		public decimal Amount { get; set; }
		public string Unit { get; set; }
		public string Preparation { get; set; }
	}
}