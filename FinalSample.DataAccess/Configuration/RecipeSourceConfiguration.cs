using System.Data.Entity.ModelConfiguration;
using FinalSample.Model;

namespace FinalSample.DataAccess.Configuration {
	public class RecipeSourceConfiguration : EntityTypeConfiguration<RecipeSource>
	{
		public RecipeSourceConfiguration()
		{
			HasKey(_ => _.SourceId);
			HasMany(_ => _.Recipes);
		}
	}
}