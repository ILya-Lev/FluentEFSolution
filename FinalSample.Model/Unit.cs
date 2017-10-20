using System.Collections.Generic;

namespace FinalSample.Model
{
	public class Unit
	{
		public int UnitId { get; set; }
		public string ShortName { get; set; }
		public string LongName { get; set; }
		public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
	}
}
