using ContextPreview;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SimpleRecipes
{
	public class Samples
	{
		private void GetEntry(Recipe recipe)
		{
			//via object context - legacy approach
			/*
			 * context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified)
			 *					.Where(entity => entity.Entity is Recipe)
			 *					.Select(entity => entity.Entity);
			 * context.ObjectStateManager.GetObjectStateEntry(mySupplier);
			 */
			//via db context
			using (var context = new RecipesContext())
			{
				var modifiedEntries = context.ChangeTracker.Entries<Recipe>().Where(e => e.State == EntityState.Modified);
				var specificEntry = context.Entry(recipe);
			}
		}

		//class which complies with change-tracking proxy mechanism of Entity Framework
		// 1. class should be public, non-abstract, non-sealed
		// 2. class should contain public or protected default ctor (i.e. parameter-less)
		// 3. all properties should be virtual
		// 4. all navigation properties should be represented as ICollection<T>
		// 5. to turn the mechanism on - create new entity instance with DbSet<T>.Create() and Add() into the collection afterward
		public class Recipe
		{
			public virtual Int32 RecipeID { get; set; }
			public virtual String RecipeName { get; set; }
			public virtual String Headnote { get; set; }

			public virtual ICollection<RecipeIngredient> Ingredients { get; set; }
			public virtual ICollection<RecipeStep> Steps { get; set; }
		}
	}
}