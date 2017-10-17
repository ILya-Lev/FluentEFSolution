
using System.ComponentModel.DataAnnotations;

namespace SimpleRecipes
{
	using System;
	using System.Collections.Generic;
	
  //  public partial class RecipeIngredient : IValidationObject
  //  {
  //      public IEnumerable<ValidationResult> Validate(ValidationContext context)
		//{
		//	RecipeIngredient ri = context.ObjectInstance as RecipeIngredient;	//is it really required?
		//	if (ri.Amount <= 0)
		//		yield return new ValidationResult($"{nameof(Amount)} should be positive, while it's {ri.Amount}.", new [] {nameof(Amount)});

		//	if (!string.IsNullOrWhiteSpace(ri.IngredientName) && ri.SourceId != 0)
		//		yield return new ValidationResult($"{nameof(IngredientName)} and {nameof(SourceId)} cannot have values simultaneously.", new [] {nameof(IngredientName), nameof(SourceId)});
		//}
  //  }
}
