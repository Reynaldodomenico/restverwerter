using System;
using Newtonsoft.Json;

namespace CommonInterfaces
{
    public class Ingredient: IIngredient
    {
        public string Name { get; set; }
        public float Amount { get; set; }
        public string Unity { get; set; }
        public Ingredient(string name, float amount = 1, string unity = null)
        {
            Name = name;
            Amount = amount;
            if(unity != null)
            {
                Unity = " " + unity;
            }
            else
            {
                Unity = unity;
            }
         
        }
    }
}
