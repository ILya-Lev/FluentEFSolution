using SampleCodeFirst.Model;
using System.Data.Entity.ModelConfiguration;

namespace SampleCodeFirst.DataAccess
{
	public class RecipeConfiguration : EntityTypeConfiguration<Recipe>
	{
		public RecipeConfiguration()
		{
			Property(r => r.RecipeName).HasColumnName("Name").HasMaxLength(50).IsRequired();
		}
	}
}