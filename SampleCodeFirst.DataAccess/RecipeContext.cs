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

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			var recipeConfiguration = modelBuilder.Entity<Recipe>();

			recipeConfiguration.Property(r => r.RecipeName).HasColumnName("Name").HasMaxLength(50).IsRequired();
		}
	}
}
