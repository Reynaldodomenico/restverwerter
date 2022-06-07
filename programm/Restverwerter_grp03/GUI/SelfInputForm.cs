using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;

namespace GUI
{
    public partial class SelfInputForm : Form
    {
        public static SelfInputForm selfInputForm = new SelfInputForm();

        public SelfInputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bereich wichtig für die TextAutoComplete Funktion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelfInputForm_Load(object sender, EventArgs e)
        {
            // Create the list to use as the custom source. 
            var source = new AutoCompleteStringCollection();
            source.AddRange(DataManager.dataManager.AllIngredientNames());

            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Visible = true;
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                foreach (Ingredient ingredient in RecipeFilter.recipeFilter.IngredientAvaliable.ToList())
                {
                    if (ingredient.Name.ToLower() == Convert.ToString(listBox1.Items[^1])?.ToLower())
                    {
                        RecipeFilter.recipeFilter.IngredientAvaliable.Remove(ingredient);
                        listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                        break;
                    }
                }
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            RecipeFilterForm.recipeFilterForm.ListboxAdd(listBox1, textBox1, label1, RecipeFilter.recipeFilter.IngredientAvaliable, "Dauerhaft vorhandene Zutaten angeben", "Perfekt, welche Lebensmittel noch ?", null, Color.Black);
        }

        /// <summary>
        /// Wie Add_Btn nur für den Enter Knopf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelfInputTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RecipeFilterForm.recipeFilterForm.ListboxAdd(listBox1, textBox1, label1, RecipeFilter.recipeFilter.IngredientAvaliable, "Dauerhaft vorhandene Zutaten angeben", "Perfekt, welche Lebensmittel noch ?", e, Color.Black);
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAllSelfInputForm();
        }

        public void DeleteAllSelfInputForm()
        {
            List<string> CheckForDoubles = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                foreach (Ingredient ingredient in RecipeFilter.recipeFilter.IngredientAvaliable.ToList())
                {
                    if (ingredient.Name.ToLower() == Convert.ToString(listBox1.Items[i])?.ToLower() && !CheckForDoubles.Contains(ingredient.Name))
                    {
                        RecipeFilter.recipeFilter.IngredientAvaliable.Remove(ingredient);
                        CheckForDoubles.Add(ingredient.Name);
                        if (i > 0)
                        {
                            i--;
                        }
                    }
                }
            }
            CheckForDoubles.Clear();
            listBox1.Items.Clear();
        }
    }
}
