//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirstSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecipeStep
    {
        public int StepNumber { get; set; }
        public string Text { get; set; }
        public int RecipeID { get; set; }
        public int RecipeRecipeId { get; set; }
    
        public virtual Recipe Recipe { get; set; }
    }
}
