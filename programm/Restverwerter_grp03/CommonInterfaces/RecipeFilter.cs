using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace CommonInterfaces
{
    public class RecipeFilter
    {
        public static RecipeFilter recipeFilter = new();

        public List<Ingredient> IngredientAvaliable = new();

        /// <summary>
        /// Methode, die alle Rezepte nach den passenden Zutaten sortiert.
        /// </summary>
        /// <param name="baseIngredient"></param>
        /// <param name="allergy"></param>
        /// <param name="diet"></param>
        /// <returns>nach Score sortierte Rezeptliste</returns>
        public List<Recipe> FittingRecipes(List<Ingredient> baseIngredient = null, List<Ingredient> allergy = null, Recipe.DietValue diet = Recipe.DietValue.omnivor)
        {
            List<Recipe> yourRecipeSearch = MatchRecipes(IngredientAvaliable);

            // wenn keine Diät angegebn wurde ist der Standardwert 1 also omnivor.
            if (diet != Recipe.DietValue.omnivor)
            {
                if (diet == Recipe.DietValue.vegetarisch)
                {
                    foreach (Recipe recipe in yourRecipeSearch)
                    {
                        if (recipe.Diet == Recipe.DietValue.omnivor)
                        {
                            recipe.Score *= -1;
                        }
                    }
                }
                else if (diet == Recipe.DietValue.vegan)
                {
                    foreach (Recipe recipe in yourRecipeSearch)
                    {
                        if (recipe.Diet == Recipe.DietValue.omnivor || recipe.Diet == Recipe.DietValue.vegetarisch)
                        {
                            recipe.Score *= -1;
                        }
                    }
                }
            }

            // wenn eine Basiszutat angegeben wurde.
            if (baseIngredient != null)
            {
                foreach (Ingredient bingredient in baseIngredient)
                {
                    foreach (Recipe recipe in yourRecipeSearch)
                    {
                        foreach (Ingredient ingredientiInRecipe in recipe.IngredientList)
                        {
                            if (ingredientiInRecipe.Name == bingredient.Name)
                            {
                                recipe.Score *= 6;
                            }
                        }
                    }
                }
            }
            // Wenn Allergie angegeben wurde.
            if (allergy != null)
            {
                foreach (Ingredient ingredient in allergy)
                {
                    foreach (Recipe recipe in yourRecipeSearch)
                    {
                        foreach (Ingredient ingredientiInRecipe in recipe.IngredientList)
                        {
                            if (ingredientiInRecipe.Name == ingredient.Name)
                            {
                                recipe.Score *= -1;
                            }
                        }
                        
                    }
                }
            }
            for (int i = 0; i < yourRecipeSearch.Count; i++)
            {
                if (yourRecipeSearch[i].Score < 0)
                {
                    yourRecipeSearch.Remove(yourRecipeSearch[i]);
                    i--;
                }
            }
            // Rezepte mit einem guten Verhältnis von vorhandenen zu den gesamten Zutaten werden um einen bestimmten Faktor bevorzugt.
            AddPointsTooGoodRatios(yourRecipeSearch, IngredientAvaliable);

            //Gelikede Rezepte werden um Faktor 2 bevorzugt und Rezepte die, gedisliked werden, bekommen nur noch 1/5 tel ihres ursprünglichen Scores
            foreach (Recipe recipe in yourRecipeSearch)
            {
                if (recipe.Like == Recipe.LikeValue.liked)
                {
                    recipe.Score *= 2;
                }
                else if (recipe.Like == Recipe.LikeValue.disliked)
                {
                    recipe.Score /= 5;
                }
            }
            return ScoreSortRecipes(yourRecipeSearch);
        }

        // Sortiert die Rezepte mit dem höchsten Score auf den 1. Platz und die mit dem schlechtesten auf den letzten Platz.
        public static List<Recipe> ScoreSortRecipes(List<Recipe> scoreRecipes)
        {
            List<Recipe> newList = scoreRecipes.OrderByDescending(o => o.Score).ToList();
            return newList;
        }

        // Jedes Rezepte kriegt Score-Punkte für jede vorhandene Zutat im Rezept
        public List<Recipe> MatchRecipes(List<Ingredient> ingredientAvailable)
        {
            List<Recipe> matchRecipes = new();
            foreach (Recipe recipe in DataManager.dataManager.AllRecipes)
            {
                recipe.Score = 0;
                foreach (Ingredient ingredient in recipe.IngredientList)
                {
                    foreach (Ingredient ingredientAv in ingredientAvailable)
                    {
                        if (ingredientAv.Name == ingredient.Name && !matchRecipes.Contains(recipe))
                        {
                            recipe.Score++;
                            matchRecipes.Add(recipe);
                        }
                        else if (ingredientAv.Name == ingredient.Name)
                        {
                            recipe.Score++;
                        }
                    }
                }
            }
            return matchRecipes;
        }
        // Gibt Rezepten mit guten Verhältnissen mit einem Faktor ein besseres Ranking
        public static List<Recipe> AddPointsTooGoodRatios(List<Recipe> recipeSearch ,List<Ingredient> ingredientAvailable)
        {
            foreach (Recipe recipe in recipeSearch)
            {
                // Rezepte die alle vorhandenen Zutaten beinhalten werden um den Faktor 4 bevorzugt!
                if (recipe.AmountOfFittingIngredients(ingredientAvailable) ==
                    recipe.IngredientList.Count)
                {
                    recipe.Score *= 4;
                }
                // Rezepte, denen 1 oder 2 Rezepte, werden um den Faktor 3 bevorzugt!
                else if (recipe.IngredientList.Count - recipe.AmountOfFittingIngredients(ingredientAvailable) == 1 || recipe.IngredientList.Count - recipe.AmountOfFittingIngredients(ingredientAvailable) == 2)
                {
                    recipe.Score *= 3;
                }
                // Rezepte, die 66 oder mehr der Zutaten haben werden um den Faktor 2 bevorzugt!
                else if (
                    Convert.ToDouble(recipe.AmountOfFittingIngredients(ingredientAvailable)) /
                    Convert.ToDouble(recipe.IngredientList.Count) > 0.66)
                {
                    recipe.Score *= 2;
                }
            }
            return recipeSearch;
        }
    }
}
