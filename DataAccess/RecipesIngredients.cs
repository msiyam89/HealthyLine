//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecipesIngredients
    {
        public int Id { get; set; }
        public Nullable<int> RecipeId { get; set; }
        public string Ingredient { get; set; }
    
        public virtual Recipes Recipes { get; set; }
    }
}
