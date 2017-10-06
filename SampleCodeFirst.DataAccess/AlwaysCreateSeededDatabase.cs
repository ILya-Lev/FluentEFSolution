using SampleCodeFirst.Model;
using System.Data.Entity;

namespace SampleCodeFirst.DataAccess
{
	public class AlwaysCreateSeededDatabase : DropCreateDatabaseAlways<RecipeContext>
	{
		protected override void Seed(RecipeContext context)
		{
			var recipe = new Recipe
			{
				Headnote = "seeded recipe",
				RecipeName = "Big Mack",
			};
			context.Recipes.Add(recipe);
			base.Seed(context);
		}
	}
}