using FinalSample.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FinalSample.DataAccess.Configuration
{
	public class RecipeIngredientConfiguration : EntityTypeConfiguration<RecipeIngredient>
	{
		public RecipeIngredientConfiguration()
		{
			HasKey(_ => new { _.RecipeId, _.IngredientId });
			Property(_ => _.RecipeId).HasColumnOrder(1);
			Property(_ => _.IngredientId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
										.HasColumnOrder(2);
		}
	}
}