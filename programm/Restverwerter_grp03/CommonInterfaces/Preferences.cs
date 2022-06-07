using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfaces
{
    public class Preferences
    {
        public static Preferences preferences = new();

        public List<Ingredient> Allergy = new();
        public Recipe.DietValue Diet { get; set; }
    }
}
