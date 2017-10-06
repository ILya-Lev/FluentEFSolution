using System.Data.Entity;

namespace CodeFirstMultipleRelationships
{
	class Program
	{
		static void Main(string[] args)
		{
			Database.SetInitializer(new DropCreateDatabaseAlways<MultipleRelationshipsContext>());

			using (var context = new MultipleRelationshipsContext())
			{
				var recipe = new Recipe
				{
					Headnote = "malabar",
					RecipeName = "the recipe"
				};

				context.Recipes.Add(recipe);
				context.SaveChanges();
			}
		}
	}
}
