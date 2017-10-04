using SampleCodeFirst.Model;
using System.Data.Entity;

namespace SampleCodeFirst.DataAccess
{
	public class RecipeContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
		//public DbSet<RecipeIngredient> Ingredients { get; set; }
		//public DbSet<RecipeStep> Steps { get; set; }
	}
}
