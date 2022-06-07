using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfaces
{
    public interface IDataManager
    {
        public List<Recipe> UpdateRecipes(List<Recipe> alleRezepte)
        {
            return new List<Recipe>();
        }
        public List<Ingredient> UpdateIngredients(List<Ingredient> alleZutaten)
        {
            return new List<Ingredient>();
        }
    }

}
