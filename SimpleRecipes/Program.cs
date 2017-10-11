namespace SimpleRecipes
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new RecipesContext())
			{
				var parentRecipe = new Recipe { RecipeName = "another parent recipe" };
				var parentIngredient = new RecipeIngredient { Preparation = "parent's ingredient" };
				parentRecipe.RecipeIngredients.Add(parentIngredient);

				var childRecipe = new Recipe { RecipeName = "child recipe" };
				var childIngredient = new RecipeIngredient { Preparation = "child's ingredient" };
				childRecipe.RecipeIngredients.Add(childIngredient);


				context.Recipes.Add(parentRecipe);
				context.RecipeIngredients.Add(childIngredient);
				context.SaveChanges();
			}

		}
	}
}
