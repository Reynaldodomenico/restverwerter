using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;
using GUI.Properties;

namespace GUI
{
    public partial class InstructionForm : Form
    {
        // eine einzige Instanz des Forms auf dem jeweils die Eigenschaften für edes Rezept angepasst werden
        public static InstructionForm instructionForm = new InstructionForm();

        public InstructionForm()
        {
            InitializeComponent();
            Like_Clicked.Hide();
            Dislike_Clicked.Hide();
        }

        /// <summary>
        /// Methode die, die benötigten Daten für jedes Rezept anzeigt
        /// </summary>
        /// <param name="recipeOffer"></param>
        /// <returns></returns>
        public InstructionForm OpenRecipeData(RecipeOffer recipeOffer)
        {
            Recipe recipe = FindRecipe(recipeOffer.Title);
            if (recipe.Like == Recipe.LikeValue.liked)
            {
                Like_Clicked.Show();
                Dislike_Clicked.Hide();
                ovalPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (recipe.Like == Recipe.LikeValue.disliked)
            {
                Like_Clicked.Hide();
                Dislike_Clicked.Show();
                ovalPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                Like_Clicked.Hide();
                Dislike_Clicked.Hide();
            }
            this.Text = recipeOffer.Title;
            this.RecipeImage.Image = recipeOffer.Bild;
            this.Instruction.Lines = recipeOffer.Instruction.Lines;
            if (recipeOffer.Diet == Recipe.DietValue.omnivor)
            {
                this.DietLabel.Text = "";
            }
            else if (recipeOffer.Diet == Recipe.DietValue.vegetarisch)
            {
                this.DietLabel.ForeColor = Color.ForestGreen;
                string rightLetters = $"{recipeOffer.Diet}"[0].ToString().ToUpper() + $"{recipeOffer.Diet}"[1..];
                this.DietLabel.Text = rightLetters;
            }
            else
            {
                this.DietLabel.ForeColor = Color.DarkGreen;
                string rightLetters = $"{recipeOffer.Diet}"[0].ToString().ToUpper() + $"{recipeOffer.Diet}"[1..];
                this.DietLabel.Text = rightLetters;
            }
            string replacement = recipeOffer.IngredientListOffer.Replace(" und ", ", ");
            string[] words = replacement.Split(", ");

            foreach (string word in words)
            {
                this.RecipeListbox.Items.Add(word);
            }
            RecipeListbox.DrawItem += RecipeListbox_DrawItem;
            return this;
        }

        // Like Button
        private void Like_Click(object sender, EventArgs e)
        {
            if (ovalPictureBox2.BorderStyle == BorderStyle.FixedSingle)
            {
                Dislike_Clicked.Hide();
                ovalPictureBox2.BorderStyle = BorderStyle.None;
            }
            ovalPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            Like_Clicked.Show();
            FindRecipe(this.Text).Like = Recipe.LikeValue.liked;
        }

        // LikeButton Clicked
        private void Like_Clicked_Click(object sender, EventArgs e)
        {
            ovalPictureBox1.BorderStyle = BorderStyle.None;
            Like_Clicked.Hide();
            FindRecipe(this.Text).Like = Recipe.LikeValue.notliked;
        }

        //Dislike Button
        private void DisLike_Click(object sender, EventArgs e)
        {
            if (ovalPictureBox1.BorderStyle == BorderStyle.FixedSingle)
            {
                Like_Clicked.Hide();
                ovalPictureBox1.BorderStyle = BorderStyle.None;
            }
            ovalPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            Dislike_Clicked.Show();
            FindRecipe(this.Text).Like = Recipe.LikeValue.disliked;
        }

        //Dislike Clicked
        private void Dislike_Clicked_Click(object sender, EventArgs e)
        {
            ovalPictureBox2.BorderStyle = BorderStyle.None;
            Dislike_Clicked.Hide();
            FindRecipe(this.Text).Like = Recipe.LikeValue.notliked;
        }

        private void InstructionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RecipeListbox.BackColor = Color.White;
            this.RecipeListbox.Items.Clear();
        }

        /// <summary>
        /// Methode, die manuell die Zuataten des jeweiligen Rezeptess in der Listbox anmalt, welche vorhanden sind. Zur Hilfe wurde von StackExchange Aspekte des unteren Programmierschnipzels genommen genommen
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DrawItemEventArgs"/> instance containing the event data.</param>
        private void RecipeListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Graphics g = e.Graphics;

                ListBox lb = (ListBox)sender;
                List<string> ingredientListAv = CompareIngredients(FindRecipe(this.Text));
                foreach (string ingredientstring in ingredientListAv)
                {
                    if(lb.Items[e.Index].ToString() == ingredientstring)
                    {
                        // malt den Hintergrund bei den vorhandenen Zutaten grün an
                        g.FillRectangle(new SolidBrush(Color.LawnGreen), e.Bounds);
                    }
                }
                g.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor),
                    new PointF(e.Bounds.X, e.Bounds.Y));
            }
        }

        // Sucht das jeweilige aufgerufte Rezept in AllRecipes also der Datenbank
        public Recipe FindRecipe(string name)
        {
            foreach (Recipe recipe in DataManager.dataManager.AllRecipes)
            {
                if (recipe.Name == name)
                {
                    return recipe;
                }
            }
            return null;
        }

        //  Stellt fest ob Zutat in der Listbox in der Liste der vorhandenen Zutaten enthalten ist. Wenn ja, wird der Hintergrund dieser Zutaten in der RecipeListbox_DrawItem Methode grün angemalt.
        public List<string> CompareIngredients(Recipe recipe)
        {
            string normaltext;
            string a;
            List<string> stringList = new List<string>();
            foreach (Ingredient ingredient in recipe.IngredientList)
            {
                foreach (Ingredient ingredient2 in RecipeFilter.recipeFilter.IngredientAvaliable)
                {
                    if (ingredient2.Name == ingredient.Name)
                    {
                        normaltext = ingredient.Name[0].ToString().ToUpper() + ingredient.Name[1..];
                        a = $"{ingredient.Amount}{ingredient.Unity} {normaltext}";
                        stringList.Add(a);
                    }
                }
            }
            return stringList;
        }

        private void InstructionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instructionForm.Close();
        }
    }
}