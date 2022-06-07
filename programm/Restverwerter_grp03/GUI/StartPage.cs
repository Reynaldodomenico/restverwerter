using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;
using System.IO;
using GUI.Properties;

namespace GUI
{
    public partial class StartPage : Form
    {
        //eine einzige Instanz von Startpage Form
        public static StartPage startPage = new StartPage();
        public StartPage()
        {
            InitializeComponent();
            this.PictureBox_Startpage.Show();
        }
        private int imageNumber = 3;

        /// <summary>
        /// Methode zuständig für das automatische Laden von Bildern auf der STartseite, die alle 5 Sekunden wechseln
        /// </summary>
        private void LoadNextImage()
        {
            if (imageNumber == 7)
            {
                imageNumber = 1;
                GC.Collect();
            }
            string imagestring = $"_{imageNumber}";
            PictureBox_Startpage.Image = (Image)Resources.ResourceManager.GetObject(imagestring);
            imageNumber++;
        }

        private Form _activeForm;

        /// <summary>
        /// Idee von Youtube-Video (https://www.youtube.com/watch?v=JP5rgXO_5Sk&amp;ab_channel=RJCodeAdvanceEN)
        /// Öffnet Forms quasi auf dem Panel welches im startPage aufgesetzt ist.
        /// </summary>
        /// <param name="childForm"></param>
        public void OpenChildForm(Form childForm)
        {
            if(_activeForm != null)
            {
                if (_activeForm == StockForm.stockForm)
                {
                    StockForm.stockForm.SaveValues();
                    if (Profile.ActiveProfile != null)
                    {
                        SaveStockIngredients();
                        SaveValuesFromListBoxToProfile();
                    }
                }
                else if (_activeForm == PreferencesForm.preferencesForm)
                {
                    PreferencesForm.preferencesForm.SaveDiet();
                    if (Profile.ActiveProfile != null)
                    {
                        SaveValuesFromListBox("Allergien: ", PreferencesForm.preferencesForm.listBox2, "allergy",
                            Profile.ActiveProfile.Allergy_Label);
                    }
                }
                else if (_activeForm.Text == new Login().Text || _activeForm.Text == new Registration().Text)
                {
                    _activeForm.Close();
                }
                else
                {
                    _activeForm.Hide();
                }
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_StartPage.Controls.Add(childForm);
            Panel_StartPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Speichert die Werte vom StockForm ins Profil
        /// </summary>
        private static void SaveStockIngredients()
        {
            if(RecipeFilterForm.recipeFilterForm.listBox2.Items.Count > 0)
            {
                Profile.ActiveProfile.ListboxItemsToStringList(RecipeFilterForm.recipeFilterForm.listBox2,
                    Profile.ActiveProfile.SaveIngredientsinListbox);
                RecipeFilterForm.recipeFilterForm.DeleteAll_IngredientsAvailableinListbox();
                SaveValuesFromList();
                Profile.ActiveProfile.GiveValueToListBox(Profile.ActiveProfile.SaveIngredientsinListbox,
                    RecipeFilterForm.recipeFilterForm.listBox2);
                Profile.ActiveProfile.GiveValueToIngredientList(Profile.ActiveProfile.SaveIngredientsinListbox,
                    RecipeFilter.recipeFilter.IngredientAvaliable);
                Profile.ActiveProfile.SaveIngredientsinListbox.Clear();
            }
            else
            {
                SaveValuesFromList();
            }
        }

        /// <summary>
        /// Speichert String in Access Tabelle
        /// </summary>
        private static void SaveValuesFromList()
        {
            string ingredientString = PreferencesForm.StringListOutput(PreferencesForm.ListToStringList(RecipeFilter.recipeFilter.IngredientAvaliable));
            Profile.ActiveProfile.richTextBox1.Text = ingredientString;
            PreferencesForm.preferencesForm.SaveValueToProfile("ingredients",
                ingredientString);
        }

        private static void SaveValuesFromListBoxToProfile()
        {
            string temp =
                $"{PreferencesForm.StringListOutput(PreferencesForm.ListboxToStringList(SelfInputForm.selfInputForm.listBox1))}";
            PreferencesForm.preferencesForm.SaveValueToProfile("selfinput", temp);
        }

        private static void SaveValuesFromListBox(string name, ListBox listBox, string attribute, Control control)
        {
            control.Text =
                $"{name}{PreferencesForm.StringListOutput(PreferencesForm.ListboxToStringList(listBox))}";
            PreferencesForm.preferencesForm.SaveValueToProfile(attribute,
                PreferencesForm.StringListOutput(
                    PreferencesForm.ListboxToStringList(listBox)));
        }

        private void StartPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(Profile.ActiveProfile == null)
            {
                if(_activeForm != null)
                {
                    if(_activeForm.Text != new Login().Text)
                    {
                        CheckWhetherItsCurrentForm(new Login());
                        GC.Collect();
                    }
                }
                else
                {
                    CheckWhetherItsCurrentForm(new Login());
                }
            }
            else
            {
                OpenChildForm(Profile.ActiveProfile);
                PictureBox_Startpage.Show();
                timer1.Enabled = false;
            }
        }

        private void Btn_Regitrate_Click(object sender, EventArgs e)
        {
            if (Profile.ActiveProfile == null)
            {
                if (_activeForm != null)
                {
                    if (_activeForm.Text != new Registration().Text)
                    {
                        CheckWhetherItsCurrentForm(new Registration());
                        GC.Collect();
                    }
                }
                else
                {
                    CheckWhetherItsCurrentForm(new Registration());
                }
            }
            // Abmelden Knopf
            else
            {
                LogOff();
            }
        }

        // Abmelden Knopf
        public void LogOff()
        {
            PreferencesForm.preferencesForm.SaveDiet();
            StockForm.stockForm.UncheckAllCheckBoxes(StockForm.stockForm);
            SaveStockIngredients();
            RecipeFilter.recipeFilter.IngredientAvaliable.Clear();
            SaveValuesFromListBox("Allergien", PreferencesForm.preferencesForm.listBox2, "allergy",Profile.ActiveProfile.Allergy_Label);
            SaveValuesFromListBoxToProfile();
            Profile.ActiveProfile = null;
            PreferencesForm.preferencesForm.listBox2.Items.Clear();
            Preferences.preferences.Allergy.Clear();
            RecipeFilterForm.recipeFilterForm.listBox1.Items.Clear();
            RecipeFilterForm.recipeFilterForm.listBox2.Items.Clear();
            SelfInputForm.selfInputForm.listBox1.Items.Clear();
            BaseIngredient.baseIngredient.BIngredient.Clear();
            startPage.Btn_Login.Text = "Login";
            startPage.Btn_Regitrate.Text = "Registrieren";
            PreferencesForm.preferencesForm.RadioButton_Omnivor.Checked = false;
            PreferencesForm.preferencesForm.RadioButton_Vegetarisch.Checked = false;
            PreferencesForm.preferencesForm.RadioButton_Vegan.Checked = false;
            OpenChildForm(new Login());
        }

        private void Btn_Preferences_Click(object sender, EventArgs e)
        {
            CheckWhetherItsCurrentForm(PreferencesForm.preferencesForm);
        }

        private void Btn_Recipes_Click(object sender, EventArgs e)
        {
            CheckWhetherItsCurrentForm(RecipeFilterForm.recipeFilterForm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            PictureBox_Startpage.Show();
            PictureBox_Startpage.BringToFront();
            timer1.Enabled = true;
        }

        private void Stock_Btn_Click(object sender, EventArgs e)
        {
            CheckWhetherItsCurrentForm(StockForm.stockForm);
        }

        /// <summary>
        /// Prüft, ob Form bereits geöffnet ist.
        /// </summary>
        /// <param name="form"></param>
        private void CheckWhetherItsCurrentForm(Form form)
        {
            if (_activeForm == form)
            {
                
            }
            else
            {
                PictureBox_Startpage.Hide();
                OpenChildForm(form);
                timer1.Enabled = false;
                GC.Collect();
            }
        }
    }
}
