using FinalSample.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinalSample.DataAccess.Configuration
{
	public class RecipeSourceConfiguration : EntityTypeConfiguration<RecipeSource>
	{
		public RecipeSourceConfiguration()
		{
			HasKey(_ => _.SourceId);
			//HasMany(_ => _.Recipes);
		}
	}
}