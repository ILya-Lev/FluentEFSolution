using SampleCodeFirst.Model;
using System;
using System.Data.Entity;

namespace SampleCodeFirst.DataAccess
{
	public class RecipeContext : DbContext
	{
		public RecipeContext() : base("CodeFirstRecipes")
		{
			Database.Log = Console.WriteLine;
		}

		public DbSet<Recipe> Recipes { get; set; }
		//public DbSet<RecipeIngredient> Ingredients { get; set; }
		//public DbSet<RecipeStep> Steps { get; set; }
	}
}
