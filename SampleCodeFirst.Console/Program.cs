using SampleCodeFirst.DataAccess;
using SampleCodeFirst.Model;
using System.Data.Entity;
using System.Linq;

namespace SampleCodeFirst.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			CreateDatabase();
		}

		private static void CreateDatabase()
		{
			//Database.SetInitializer(new DropCreateDatabaseAlways<RecipeContext>());
			Database.SetInitializer(new AlwaysCreateSeededDatabase());

			var recipe = new Recipe
			{
				RecipeName = "Kentucky Chicken",
				Headnote = "the tastiest chicken in the entire universe"
			};

			using (var context = new RecipeContext())
			{
				if (!context.Recipes.Any(r => r.RecipeName == recipe.RecipeName && r.Headnote == recipe.Headnote))
					context.Recipes.Add(recipe);
				context.SaveChanges();
			}
		}
	}
}
