using CodeFirstAnnotations.Model;
using System.Data.Entity;

namespace CodeFirstAnnotations
{
	class Program
	{
		static void Main(string[] args)
		{
			Database.SetInitializer(new DropCreateDatabaseAlways<OneToOneContext>());

			using (var context = new OneToOneContext())
			{
				var ingredientAmount = new IngredientAmount
				{
					Amount = 10,
					AmountId = 20,
					Name = "the first one"
				};

				context.IngredientAmounts.Add(ingredientAmount);
				context.SaveChanges();
			}
		}
	}
}
