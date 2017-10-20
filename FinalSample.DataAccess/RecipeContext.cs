using FinalSample.DataAccess.Configuration;
using FinalSample.Model;
using NLog;
using System.Data.Entity;

namespace FinalSample.DataAccess
{
	public class RecipeContext : DbContext
	{
		public RecipeContext() : base("FinalProjectData")
		{
			Database.Log = message => LogManager.GetCurrentClassLogger().Trace(message);
		}

		public DbSet<Recipe> Recipes { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Configurations.Add(new RecipeSourceConfiguration());
			modelBuilder.Configurations.Add(new RecipeStepConfiguration());
			modelBuilder.Configurations.Add(new RecipeIngredientConfiguration());
		}
	}
}