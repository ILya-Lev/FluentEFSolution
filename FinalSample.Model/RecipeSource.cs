using System.Collections.Generic;

namespace FinalSample.Model
{
	public class RecipeSource
	{
		public int SourceId { get; set; }
		public string SourceName { get; set; }
		public ICollection<Recipe> Recipes { get; set; }
	}
}