using FinalSample.DataAccess;
using FinalSample.Model;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace FinalSample.Application
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : System.Windows.Application
	{
		private void App_Startup(object sender, StartupEventArgs e)
		{
			Debug.WriteLine("app invocation");

			Database.SetInitializer(new CreateDatabaseIfNotExists<RecipeContext>());
			using (var context = new RecipeContext())
			{
				var recipe = new Recipe
				{
					Headnote = "This is a good way to deal with tasteless commercial tomatoes. "
							   + "This the basic formula, but I never really make it the same way twice.",
					RecipeName = "Roasted Tomato Soup",
					RecipeSource = new RecipeSource { SourceName = "Rebecca Riordan" },
					RecipeSteps = new[]
					{
						new RecipeStep {Description = "Slice plum tomatoes in half, toss with olive oil and season with salt & pepper. Roast at 200 degrees Celsius for 45 minutes."},
						new RecipeStep {Description = "Softer onions and garlic in butter. Add the herbs, stock, canned tomatoes and roasted tomatoes (including juice)."},
						new RecipeStep {Description = "Simmer for 40 minutes."},
						new RecipeStep {Description = "Puree in a food processor or blender."}
					}
				};

				if (!context.Recipes.Any(r => r.RecipeName == recipe.RecipeName
										   && r.RecipeSource.SourceName == recipe.RecipeSource.SourceName))
				{
					context.Recipes.Add(recipe);
					context.SaveChanges();
				}
			}
		}
	}
}
