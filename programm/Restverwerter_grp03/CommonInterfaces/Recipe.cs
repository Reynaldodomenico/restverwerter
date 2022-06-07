using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mime;
using System.Text;

namespace CommonInterfaces
{
    public class Recipe: IRecipe
    {
        public string Name { get; set; }
        public int Idenity { get; set; }

        public enum LikeValue : byte
        {
            notliked = 0,
            liked = 1,
            disliked = 2
        }

        public enum DietValue: int
        {
            omnivor = 1,
            vegetarisch = 2,
            vegan = 3
        }

        /// <summary>
        /// Später kann noch die Funktion eingefügt werden, nach Speisearten zu filtern (wegen zeitlicher Gründe nicht intergiert.)
        /// </summary>
        public enum FoodType : byte
        {
            Frühstück = 1,
            Hauptgericht = 2,
            Snack = 3,
            Dessert = 4
        }

        public int CookDuration { get; set; }

        public string[] Instruction { get; set; }

        public List<Ingredient> IngredientList { get; set; }

        public LikeValue Like { get; set; }

        public DietValue Diet { get; set; }

        // public FoodType Type { get; set; }

        // Da das GUI-Projekt einen Verweis auf die CommonInterfaces hat, werden in den Rezepten nur die Namen der Bilddatei gespeichert und dann im ListRecipe und InstructionForm auf die Bilder im Resources zugegriffen.
        public string Imagestring { get; set; }

        // Rezepte bekommen je nach dem wie viele vorhandene Zutaten in den Rezpeten drin sind einen Score-Wert nach dem gefiltert wird.
        public int Score { get; set; }

        public Recipe(string name, int idenity, byte dietValue,/* byte type,*/ int coookDuration, string[] instruction, string imagestring, List<Ingredient> ingredientList)
        {
            Name = name;
            Idenity = idenity;
            CookDuration = coookDuration;
            Diet = (DietValue)dietValue;
            // Type = (FoodType) type;
            Imagestring = imagestring;
            Instruction = instruction;
            IngredientList = ingredientList;
        }

        // String Wiedergabe der Rezepte und deren Inhalt
        public static string IngredientOutput(List<Ingredient> ingredientList)
        {
            string a = "";
            int x = 0;
            {
                foreach (Ingredient ingredient in ingredientList)
                {
                    string normaltext = ingredient.Name[0].ToString().ToUpper() + ingredient.Name[1..];
                    a += $"{ingredient.Amount}{ingredient.Unity} {normaltext}";
                    x++;
                    if (x == ingredientList.Count - 1)
                    {
                        a += " und ";
                    }

                    if (x < ingredientList.Count - 1)
                    {
                        a += ", ";
                    }
                }
            }
            return a;
        }

        /// <summary>
        /// Auskommentierter Code kann bei fehlerhaften Verhalten wie doppelt hinzugefügter Zutaten eingefügt werden und verhindert erfolgreich,
        /// dass Zutaten nicht doppelt gezählt werden. Auskommentiert, da wir es geschafft haben, dass Zutaten nicht doppelt gezählt werden.
        /// </summary>
        /// <param name="ingredientAvailable"></param>
        /// <returns></returns>
        public int AmountOfFittingIngredients(List<Ingredient> ingredientAvailable)
        {
            // Liste wird erstellt, um festzustellen, ob eine Zutat schon berücksichtigt wurde im Zähler, wird jedoch nicht ausgegeben.
            //List<string> checkforDouble = new();
            int result = 0;
            foreach (Ingredient ingredient in this.IngredientList)
            {
                foreach (Ingredient ingredientAv in ingredientAvailable)
                {
                    if (ingredientAv.Name == ingredient.Name/* && !checkforDouble.Contains(ingredientAv.Name)*/)
                    {
                        result++;
                        //checkforDouble.Add(ingredientAv.Name);
                    }
                }
            }
            //checkforDouble.Clear();
            return result;
        }


        public static string CookDurationOutput(int cookDuration)
        {
            return $"{cookDuration} min";
        }

        public override string ToString() // Zum Testen der Ineinandergreifung der Rezepte und Zutaten. NUn nicht mehr verwendet
        {
            return $"Dieses Rezept heißt {this.Name} hat die Idenität: {this.Idenity} ist {this.Diet} und enthält {IngredientOutput(this.IngredientList)}";
        }
    }
}
