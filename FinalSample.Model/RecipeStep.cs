﻿namespace FinalSample.Model
{
	public class RecipeStep
	{
		public int RecipeId { get; set; }
		public int StepNumber { get; set; }
		public string Description { get; set; }
		public Recipe Recipe { get; set; }
	}
}