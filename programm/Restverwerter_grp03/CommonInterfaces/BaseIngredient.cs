using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfaces
{
    public class BaseIngredient
    {
        public static BaseIngredient baseIngredient = new();
        public List<Ingredient> BIngredient = new();
    }
}