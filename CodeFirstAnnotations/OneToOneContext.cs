using CodeFirstAnnotations.Model;
using System.Data.Entity;

namespace CodeFirstAnnotations
{
	public class OneToOneContext : DbContext
	{
		public DbSet<IngredientAmount> IngredientAmounts { get; set; }
	}
}