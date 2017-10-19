using FinalSample.Model;
using System.Data.Entity;
using FinalSample.DataAccess.Configuration;

namespace FinalSample.DataAccess
{
	public class RecipeContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Configurations.Add(new RecipeSourceConfiguration());
		}
	}
}