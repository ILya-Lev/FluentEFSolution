using SampleCodeFirst.DataAccess;
using SampleCodeFirst.Model;
using System.Data.Entity;

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
			Database.SetInitializer(new DropCreateDatabaseAlways<RecipeContext>());

			var recipe = new Recipe
			{
				RecipeName = "Kentucky Chicken",
				Headnote = "the tastiest chicken in the entire universe"
			};

			using (var context = new RecipeContext())
			{
				context.Recipes.Add(recipe);
				context.SaveChanges();
			}
		}
	}
}
