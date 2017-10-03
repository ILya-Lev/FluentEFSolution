using System;
using System.Linq;

namespace ContextPreview
{
	public partial class Amount
	{
		public void OnMaximumAmountChanged()
		{
			Console.WriteLine("maximum changed");
		}

		public string DisplayAmount =>
			$"{MinimumAmount} to {MaximumAmount} {Unit}, "
			+ $"{Recipe.RecipeIngredients.FirstOrDefault(i => i.RecipeID == RecipeID)?.Preparation}";

	}
}