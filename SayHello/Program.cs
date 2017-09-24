using System;
using System.Linq;

namespace SayHello
{
	class Program
	{
		static void Main(string[] args)
		{
			TestModel();
		}

		private static void TestModel()
		{
			using (var context = new FluentEFChapter01Entities())
			{
				var dataToPrint = context.Recipes.Select(r => new { r.Title, r.RecipeType.Description }).ToList();
				foreach (var item in dataToPrint)
				{
					Console.WriteLine($"{item.Title} {item.Description}");
				}
			}
		}
	}
}
