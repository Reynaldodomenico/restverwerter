using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;
using System.Data.OleDb;
using System.IO;
using GUI.Properties;

namespace GUI
{
    public partial class PreferencesForm : Form
    {
        public static PreferencesForm preferencesForm = new PreferencesForm();

        public PreferencesForm()
        {
            InitializeComponent();
            string a = Path.GetFullPath("db_users.mdb");
            con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;;Data Source={a}");
            _cmd = new OleDbCommand();
            _da = new OleDbDataAdapter();
        }

        // benötigt für den Zugriff auf die Microsoft Access Datei
        OleDbConnection con;
        OleDbCommand _cmd;
        readonly OleDbDataAdapter _da;

        /// <summary>
        /// Methode zur Speicherung des Diät-Wertes
        /// </summary>
        public void SaveDiet()
        {
            if (RadioButton_Omnivor.Checked)
            {
                Preferences.preferences.Diet = (Recipe.DietValue)1;
                if(Profile.ActiveProfile != null)
                {
                    SaveValueToProfile("Diet","1");
                    Profile.ActiveProfile.Diet_Label.Text = "Diät: Omnivor";
                }
            }
            else if (RadioButton_Vegetarisch.Checked)
            {
                Preferences.preferences.Diet = (Recipe.DietValue)2;
                if (Profile.ActiveProfile != null)
                {
                    SaveValueToProfile("Diet", "2");
                    Profile.ActiveProfile.Diet_Label.Text = "Diät: Vegetarisch";
                }
            }
            else if (RadioButton_Vegan.Checked)
            {
                Preferences.preferences.Diet = (Recipe.DietValue)3;
                if (Profile.ActiveProfile != null)
                {
                    SaveValueToProfile("Diet", "3");
                    Profile.ActiveProfile.Diet_Label.Text = "Diät: Vegan";
                }
            }
            else
            {
                Preferences.preferences.Diet = (Recipe.DietValue)1;
            }
        }

        /// <summary>
        /// Speichert den Wert für den/die aktuellen User/Userin bei dem wählbaren Bereich (attribute) und den jeweiligen Wert (value)
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
        public void SaveValueToProfile(string attribute ,string value)
        {
            con.Open();
            string x = $"UPDATE [tbl_users] SET [{attribute}] = '{value}' WHERE username = '" + Profile.ActiveProfile.Name + "'";
            _da.UpdateCommand = con.CreateCommand();
            _da.UpdateCommand.CommandText = x;
            _da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Enter Klickevent für die Allergien Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RecipeFilterForm.recipeFilterForm.ListboxAdd(listBox2, textBox2, label2, Preferences.preferences.Allergy,
                    "allergische Lebensmittel?", "Perfekt, welche Lebensmittel noch?", e, Color.DarkGreen);
            }
        }

        // Sobald der Form geladen wird, bekommen die jeweiligen Textboxen eine "AutoComplete" Funktion. Dafür werden alle Zutaten verwendet.
        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            // Create the list to use as the custom source. 
            var source = new AutoCompleteStringCollection();
            source.AddRange(DataManager.dataManager.AllIngredientNames());

            textBox2.AutoCompleteCustomSource = source;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Visible = true;
        }

        /// <summary>
        /// SpeciherKnopf für die Allergien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            RecipeFilterForm.recipeFilterForm.ListboxAdd(listBox2, textBox2, label2, Preferences.preferences.Allergy, "allergische Lebensmittel?", "Perfekt, welche Lebensmittel noch?", null, Color.DarkGreen);
        }

        /// <summary>
        /// Entfernen Knopf für die Allergien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Entfernen_Click_1(object sender, EventArgs e)
        {
            if (Preferences.preferences.Allergy.Count >= 1)
            {
                Preferences.preferences.Allergy.RemoveAt(Preferences.preferences.Allergy.Count - 1);
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
            }
        }

        /// <summary>
        /// Alle Einträge entfernen aus der AllergienListbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAll_Allergies_Btn_Click(object sender, EventArgs e)
        {
            Preferences.preferences.Allergy.Clear();
            listBox2.Items.Clear();
        }

        // Methoden zum Speichern eines Bildes je Diät Wert
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = (Image)Resources.pexels_jonathan_borba_2983101;
            RecipeFilterForm.recipeFilterForm.pictureBox1.Image = (Image)Resources.pexels_horizon_content_3915857;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = (Image)Resources.pexels_ponyo_sakana_4193872;
            RecipeFilterForm.recipeFilterForm.pictureBox1.Image = (Image)Resources.pexels_valeria_boltneva_842571;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = (Image)Resources.pexels_ella_olsson_1640777__1_;
            RecipeFilterForm.recipeFilterForm.pictureBox1.Image = (Image)Resources.pexels_jane_d_1092730;
        }

        /// <summary>
        /// Umwandeln einer Listbox zum List<string></string>
        /// </summary>
        /// <param name="listBox"></param>
        /// <returns>list</returns>
        public static List<string> ListboxToStringList(ListBox listBox)
        {
            List<string> list = new List<string>();
            foreach (string item in listBox.Items)
            {
                list.Add(item);
            }

            return list;
        }


        public static List<string> ListToStringList(List<Ingredient> ingredientlist)
        {
            List<string> stringList = new List<string>();
            foreach (Ingredient ingredient in ingredientlist)
            {
                stringList.Add(ingredient.Name);
            }

            return stringList;
        }

        /// <summary>
        /// Richtiges Setzen von Kommas und dem und bei Rezepteingabe
        /// </summary>
        /// <param name="stringList"></param>
        /// <returns></returns>
        public static string StringListOutput(List<string> stringList)
        {
            string a = "";
            int x = 0;
            {
                foreach (string ingredientstring in stringList)
                {
                    string replacement = ingredientstring.Replace("1 ", "");
                    a += $"{replacement}";
                    x++;
                    if (x == stringList.Count - 1)
                    {
                        a += " und ";
                    }

                    if (x < stringList.Count - 1)
                    {
                        a += ", ";
                    }
                }
            }
            return a;
        }
    }
}
