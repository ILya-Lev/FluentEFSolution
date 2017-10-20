using FinalSample.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FinalSample.DataAccess.Configuration
{
	public class RecipeStepConfiguration : EntityTypeConfiguration<RecipeStep>
	{
		public RecipeStepConfiguration()
		{
			HasKey(_ => new { _.RecipeId, _.StepNumber });
			Property(_ => _.RecipeId).HasColumnOrder(1);
			Property(_ => _.StepNumber).HasColumnOrder(2)
										.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
		}
	}
}