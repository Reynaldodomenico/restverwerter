using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfaces
{
    public interface IRecipe
    {
        public string Name { get; set; }
        public int Idenity { get; set; }
        public enum Diet { ominvor = 1, vegetarisch = 2, vegan = 3 }
        public string [] Instruction { get; set; }
        public List<Ingredient> IngredientList { get; set; }
    }
}
