using FinalSample.DataAccess;
using FinalSample.Model;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace FinalSample.Application
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			Debug.WriteLine("main window invocation");

			InitializeComponent();

			LookupRecipe();
		}

		private void LookupRecipe()
		{
			using (var context = new RecipeContext())
			{
				var recipe = context.Recipes.Include(nameof(Recipe.RecipeSteps))
											.Include(nameof(Recipe.RecipeIngredients))
											.Include(nameof(Recipe.RecipeSource))
											.FirstOrDefault();
				if (recipe == null) return;

				txtRecipeName.Text = recipe.RecipeName;
				txtSource.Text = recipe.RecipeSource?.SourceName;
				txtDescription.Text = recipe.Headnote;

				foreach (var step in recipe.RecipeSteps)
				{
					listSteps.Items.Add(step.Description);
				}
			}
		}
	}
}
