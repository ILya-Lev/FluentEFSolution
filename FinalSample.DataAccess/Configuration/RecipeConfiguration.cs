using FinalSample.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinalSample.DataAccess.Configuration
{
	public class RecipeConfiguration : EntityTypeConfiguration<Recipe>
	{
		public RecipeConfiguration()
		{
			HasOptional(_ => _.RecipeSource);
		}
	}
}