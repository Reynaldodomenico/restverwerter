using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CommonInterfaces;
using GUI.Properties;

namespace GUI
{
    public partial class ListRecipe : Form
    {
        //eine einzige Instanz des Forms
        public static ListRecipe listRecipe = new ListRecipe();

        // Event zum Wechseln auf die nächste oder vorherige Seite in der Rezepteauflistung
        private event EventHandler<int> ShowOtherSideOfListEvent;

        // IndexAddition, Page und AllRecipeAmount sind Eigenschaften, die Werte speichern die in den Methoden für das Wechseln der Seiten benötigt werden.
        private int _indexAddition;
        private int _page;
        private int _allRecipesAmount;

        public ListRecipe()
        {
            InitializeComponent();
        }

        // Setzt beim Öffnen der ListRecipe die Werte zurück auf Standard
        private void ListRecipe_Load(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                flowLayoutPanel.Controls.Clear();
            }
            _indexAddition = 0;
            _page = 1;
            Page_Label.Text = $"Seite {_page}";
            PopulateRecipeOffer();
        }

        /// <summary>
        /// GEneriert alle passenden und gefilterten Rezepte über ein selbsterstelltes UserControl, welches auf einem FlowlayoutPanel generiert wird.
        /// Zur Hilfe wurde ein Youtube Video verwendet: Link (https://www.youtube.com/watch?v=cL3aO1QkgvM&ab_channel=Chieng)
        /// </summary>
        private void PopulateRecipeOffer()
        {
            // Methode, die nach den Rezepten filtert aus RecipeFilter
            List<Recipe> recipeinList = RecipeFilter.recipeFilter.FittingRecipes(
                BaseIngredient.baseIngredient.BIngredient, Preferences.preferences.Allergy,
                Preferences.preferences.Diet);

            if (recipeinList.Count == 0)
            {
                // Keine Rezepte gefunden
                listRecipe.No_Recipe_Found_Label.Text = "Keine Rezepte gefunden";
                HidePageControls();
            }
            else
            {
                // Rezepte wurden gefunden
                ShowPageControls();

                _allRecipesAmount = recipeinList.Count;
                // Prüft, ob auf der nächsten Seite mehr als 10 Rezepte oder wenige enthalten sind.
                if (_allRecipesAmount < 11 && _indexAddition == 0)
                {
                    HidePageControls();
                }
                // Meldet Event einmalig für das Klicken auf die nächste Seite an
                if (this.ShowOtherSideOfListEvent == null)
                {
                    this.ShowOtherSideOfListEvent += ListRecipe_ShowOtherSideOfListEvent;
                }

                if (_indexAddition == 0)
                {
                    ovalPictureBox1.Hide();
                    PreviousSide_Label.Hide();
                }

                int recipeamount = CheckWhetherIndexIsTooHigh();
                GiveDataToRecipeOffer(recipeamount, recipeinList);
            }
        }

        // Zeigt Label und Picturebox Elemente für das Klicken auf die nächste/vorherige Seite
        private void ShowPageControls()
        {
            ovalPictureBox1.Show();
            ovalPictureBox2.Show();
            ovalPictureBox3.Show();
            ovalPictureBox4.Show();
            Page_Label.Show();
            NextSide_Label.Show();
            PreviousSide_Label.Show();
        }

        // VErsteckt Label und Picturebox Elemente für das Klicken auf die nächste Seite
        private void HidePageControls()
        {
            ovalPictureBox1.Hide();
            ovalPictureBox2.Hide();
            Page_Label.Hide();
            NextSide_Label.Hide();
            PreviousSide_Label.Hide();
            ovalPictureBox3.Hide();
            ovalPictureBox4.Hide();
        }

        /// <summary>
        /// Gibt Daten an das RecipeOffer Usercontrol
        /// </summary>
        /// <param name="recipeamount"></param>
        /// <param name="recipeinList"></param>
        private void GiveDataToRecipeOffer(int recipeamount, List<Recipe> recipeinList)
        {
            for (int i = 0 + _indexAddition; i < recipeamount; i++)
            {
                {
                    listRecipe.No_Recipe_Found_Label.Text = "";
                    RecipeOffer recipeOffer = new RecipeOffer
                    {
                        Title = recipeinList[i].Name,
                        IngredientListOffer = Recipe.IngredientOutput(recipeinList[i].IngredientList),
                        Duration = Recipe.CookDurationOutput(recipeinList[i].CookDuration),
                        Bild = (Bitmap) Resources.ResourceManager.GetObject(recipeinList[i].Imagestring),
                        Instruction = new TextBox {Lines = recipeinList[i].Instruction},
                        Diet = recipeinList[i].Diet
                    };
                    GiveColourToLabel(recipeinList, i, recipeOffer);
                    recipeOffer.WasClicked += RecipeOffer_WasClicked;
                    flowLayoutPanel.Controls.Add(recipeOffer);
                }
            }
        }

        /// <summary>
        /// Vergibt Farben an ein Label im RecipeOffer, falls das Rezept besonders viele vorhandene Zutaten hat.
        /// </summary>
        /// <param name="recipeinList"></param>
        /// <param name="i"></param>
        /// <param name="recipeOffer"></param>
        private static void GiveColourToLabel(List<Recipe> recipeinList, int i, RecipeOffer recipeOffer)
        {
            // Alle vorhandenen Zutaten im Rezept enthalten 
            if (recipeinList[i].AmountOfFittingIngredients(RecipeFilter.recipeFilter.IngredientAvaliable) ==
                recipeinList[i].IngredientList.Count)
            {
                recipeOffer.Fitting_Recipes_Label.ForeColor = Color.LimeGreen;
                recipeOffer.FittingRecipes = "Alle Zutaten vorhanden!";
            }
            // mehr al 66% der Zutaten im Rezept enthalten 
            else if (
                Convert.ToDouble(recipeinList[i].AmountOfFittingIngredients(RecipeFilter.recipeFilter.IngredientAvaliable)) /
                Convert.ToDouble(recipeinList[i].IngredientList.Count) > 0.66)
            {
                recipeOffer.Fitting_Recipes_Label.ForeColor = Color.DarkGreen;
                recipeOffer.FittingRecipes =
                    $"{recipeinList[i].AmountOfFittingIngredients(RecipeFilter.recipeFilter.IngredientAvaliable)} von {recipeinList[i].IngredientList.Count} Zutaten vorhanden";
            }
            // weniger ala 33% der Zutaten im Rezept enthalten 
            else if (
                Convert.ToDouble(recipeinList[i].AmountOfFittingIngredients(RecipeFilter.recipeFilter.IngredientAvaliable)) /
                Convert.ToDouble(recipeinList[i].IngredientList.Count) < 0.33)
            {
                recipeOffer.Fitting_Recipes_Label.ForeColor = Color.DarkRed;
                recipeOffer.FittingRecipes =
                    $"{recipeinList[i].AmountOfFittingIngredients(RecipeFilter.recipeFilter.IngredientAvaliable)} von {recipeinList[i].IngredientList.Count} Zutaten vorhanden";
            }
            // zwischen 33% bis 66% der Zutaten im Rezept enthalten 
            else
            {
                recipeOffer.Fitting_Recipes_Label.ForeColor = Color.Orange;
                recipeOffer.FittingRecipes =
                    $"{recipeinList[i].AmountOfFittingIngredients(RecipeFilter.recipeFilter.IngredientAvaliable)} von {recipeinList[i].IngredientList.Count} Zutaten vorhanden";
            }
        }

        /// <summary>
        /// Wechsel zur nächsten Seite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListRecipe_ShowOtherSideOfListEvent(object sender, int e)
        {
            _indexAddition += e;
            flowLayoutPanel.Controls.Clear();
        }

        // Event handler for when MouseClick is raised in a UserControl.
        void RecipeOffer_WasClicked(object sender, EventArgs e)
        {
            // Set IsSelected for all UCs in the FlowLayoutPanel to false.
            foreach (Control c in flowLayoutPanel.Controls)
            {
                if (c is RecipeOffer offer)
                {
                    offer.IsSelected = false;
                }
            }
        }

        /// <summary>
        /// 2. Schließ Knopf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_ListRecipe_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
        }

        /// <summary>
        /// Knopf fürs Öffnen der nächsten Seite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Side_Click(object sender, EventArgs e)
        {
            int higher = 10;
            if(_allRecipesAmount-_indexAddition > 10)
            {
                _page++;
                Page_Label.Text = $"Seite {_page}";
                ShowOtherSideOfListEvent?.Invoke(this, higher);
                if (ovalPictureBox1.BorderStyle == BorderStyle.Fixed3D)
                {
                    ovalPictureBox1.BorderStyle = BorderStyle.None;
                }

                ovalPictureBox2.BorderStyle = BorderStyle.Fixed3D;
                PopulateRecipeOffer();
            }
        }

        /// <summary>
        /// Knopf fürs Öffnen der nächsten Seite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previous_Side_Click(object sender, EventArgs e)
        {
            int lower = -10;
            if(_page > 1)
            {
                _page--;
                Page_Label.Text = $"Seite {_page}";
                ShowOtherSideOfListEvent?.Invoke(this, lower);
                if (ovalPictureBox2.BorderStyle == BorderStyle.Fixed3D)
                {
                    ovalPictureBox2.BorderStyle = BorderStyle.None;
                }
                PopulateRecipeOffer();
                ovalPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        /// <summary>
        /// Methode, die benötigt wird zum korrekten Erfassen wie viele Rezepte auf der nächsten/ vorherigen Seite angezeigt werden. Danach wird
        /// entschieden, ob noch zur nächsten oder vorherigen Seite gewechselt werden kann.
        /// </summary>
        /// <returns></returns>
        private int CheckWhetherIndexIsTooHigh()
        {
            int output;
            int result;
            if (_allRecipesAmount < 10)
            {
                output = _allRecipesAmount;
            }
            else
            {
                output = 10;
            }
            if (_allRecipesAmount > output + _indexAddition)
            {
                result = output + _indexAddition;
            }
            else
            {
                result = _allRecipesAmount;
                NextSide_Label.Hide();
                ovalPictureBox2.Hide();
            }
            return result;
        }

        private void ListRecipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            listRecipe.Close();
        }
    }
}
