using System.Data.Entity;

namespace CodeFirstMultipleRelationships
{
	public class MultipleRelationshipsContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}