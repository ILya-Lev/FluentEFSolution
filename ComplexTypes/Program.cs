using Newtonsoft.Json;
using System;
using System.Linq;

namespace ComplexTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			//TestSplitModel();
			TestTablePerType();
		}

		private static void TestTablePerType()
		{
			using (var context = new TablePerTypeEntities())
			{
				var recipies = context.TPTRecipes.Where(r => r.TPTIngredients.Any(i => i is TPTBakedGood)).ToList();
				Console.WriteLine(recipies.Count);
			}
		}

		private static void TestSplitModel()
		{
			using (var context = new SplitModelContext())
			{
				var customer = context.SplitCustomers.FirstOrDefault();
				var serializedCustomer = JsonConvert.SerializeObject(customer, typeof(SplitCustomer),
											new JsonSerializerSettings { Formatting = Formatting.Indented });
				Console.WriteLine(serializedCustomer);
			}
		}
	}
}
