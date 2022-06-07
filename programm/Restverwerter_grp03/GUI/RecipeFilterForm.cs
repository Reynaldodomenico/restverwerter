using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class RecipeFilterForm : Form
    {
        public static RecipeFilterForm recipeFilterForm = new RecipeFilterForm();

        public RecipeFilterForm()
        {
            InitializeComponent();
        }

        // Enter Taste drücken in der Textbox setzt die genannte Zutat in der Textbox1 in die Listbox1
        private void Btn_BaseIngredients_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enter
            {
                ListboxAdd(listBox1, textBox1, label1, BaseIngredient.baseIngredient.BIngredient, "Lebensmittel, die du dir im Rezept wünschst", "Perfekt, welche Lebensmittel noch?",e, Color.DarkOrange);
            }
        }

        // Hinzufügen Taste für die Basiszutaten
        private void Btn_Hinzufügen_Basiszutaten_Click(object sender, EventArgs e)
        {
            ListboxAdd(listBox1, textBox1, label1, BaseIngredient.baseIngredient.BIngredient, "Lebensmittel, die du dir im Rezept wünschst", "Perfekt, welche Lebensmittel noch?", null, Color.DarkOrange);
        }

        // Entfernen von Lebensmittel aus der Listbox2 (von unten nach oben)
        private void Btn_Entfernen2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count >= 1)
            {
                foreach (Ingredient ingredient in RecipeFilter.recipeFilter.IngredientAvaliable.ToList())
                {
                    if (ingredient.Name.ToLower() == Convert.ToString(listBox2.Items[^1])?.ToLower())
                    {
                        RecipeFilter.recipeFilter.IngredientAvaliable.Remove(ingredient);
                        listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
                        break;
                    }
                }
            }
        }

        // Entfernen von Lebensmittel aus der Listbox1 (von unten nach oben)
        private void Btn_Entfernen_Click(object sender, EventArgs e)
        {
            if (BaseIngredient.baseIngredient.BIngredient.Count >= 1)
            {
                BaseIngredient.baseIngredient.BIngredient.RemoveAt(BaseIngredient.baseIngredient.BIngredient.Count - 1);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }

        // Enter Taste drücken in der Textbox setzt die genannte Zutat in der Textbox2 in die Listbox2 für Vorräte
        private void Btn_Vorräte_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListboxAdd(listBox2, textBox2, label2, RecipeFilter.recipeFilter.IngredientAvaliable, "Lebensmittel angeben, die du jetzt nutzen möchtest", "Perfekt, welche Lebensmittel noch?", e, Color.Teal);
            }
        }

        // Hinzufügen Taste für die Vorräte
        private void Btn_Hinzufügen_Vorräte_Click(object sender, EventArgs e)
        {
            ListboxAdd(listBox2, textBox2, label2, RecipeFilter.recipeFilter.IngredientAvaliable, "Lebensmittel angeben, die du jetzt nutzen möchtest", "Perfekt, welche Lebensmittel noch?", null, Color.Teal);
        }

        /// <summary>
        /// Methode zum Hinzufügen von Zutaten in eine Listbox
        /// </summary>
        /// <param name="listbox"></param>
        /// <param name="textbox"></param>
        /// <param name="label"></param>
        /// <param name="ingredients"></param>
        /// <param name="noInput"></param>
        /// <param name="inputHelp"></param>
        /// <param name="e"></param>
        /// <param name="color"></param>
        public void ListboxAdd(ListBox listbox, TextBox textbox, Label label, List<Ingredient> ingredients, string noInput, string inputHelp ,KeyEventArgs e, Color color)
        {
            string lowertext = textbox.Text.ToLower();
            Ingredient thisIngredient = DataManager.dataManager.FindIngredient(lowertext);
            if (lowertext == "")
            {
                label.ForeColor = color;
                label.Text = noInput;
            }
            else if (thisIngredient != null && !CheckWhetherIngredientIsInsideIngredientList(thisIngredient, ingredients))
            {
                listbox.Items.Add(thisIngredient.Name);
                ingredients.Add(thisIngredient);
                label.Text = null;
                textbox.Clear();
                label.ForeColor = color;
                label.Text = inputHelp;
                if(e != null)
                {
                    e.SuppressKeyPress = true;
                }
            }
            else if (thisIngredient != null && CheckWhetherIngredientIsInsideIngredientList(thisIngredient, ingredients))
            {
                label.ForeColor = Color.Red;
                label.Text = "Diese Zutat hast du bereits genannt.";
            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = "Zutat nicht verfügbar. Rechtschreibung?";
            }
        }

        private void RecipeSearchBtn_Click(object sender, EventArgs e)
        {
            ListRecipe.listRecipe.ShowDialog();
        }



        // Sobald der Form geladen wird, bekommen die jeweiligen Textboxen eine "AutoComplete" Funktion. Dafür werden alle Zutaten verwendet.
        private void RecipeFilterForm_Load(object sender, EventArgs e)
        {
            // Create the list to use as the custom source. 
            var source = new AutoCompleteStringCollection();
            source.AddRange(DataManager.dataManager.AllIngredientNames());

            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Visible = true;

            textBox2.AutoCompleteCustomSource = source;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Visible = true;
        }


        private void DeleteAll_IngredientsAvailable_Btn_Click(object sender, EventArgs e)
        {
            DeleteAll_IngredientsAvailableinListbox();
        }

        public void DeleteAll_IngredientsAvailableinListbox()
        {
            List<string> CheckForDoubles = new List<string>();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                foreach (Ingredient ingredient in RecipeFilter.recipeFilter.IngredientAvaliable.ToList())
                {
                    if (ingredient.Name.ToLower() == Convert.ToString(listBox2.Items[i])?.ToLower() && !CheckForDoubles.Contains(ingredient.Name))
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
            listBox2.Items.Clear();
        }

        public bool CheckWhetherIngredientIsInsideIngredientList(Ingredient thisIngredient, List<Ingredient> ingredients)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                if (thisIngredient.Name == ingredient.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private void DeleteAll_BaseIngredients_Btn_Click(object sender, EventArgs e)
        {
            BaseIngredient.baseIngredient.BIngredient.Clear();
            listBox1.Items.Clear();
        }
    }
}
