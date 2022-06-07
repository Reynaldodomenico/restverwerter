using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;

namespace GUI
{
    public partial class Profile : Form
    {
        // Jedes erstellte Profil wird im ActiveProfile gespeichert
        public static Profile ActiveProfile;

        private string Password { get; }

        // Zutaten aus StockForm werden in dieser List<string> eingespeichert
        public List<string> SaveIngredientsinListbox= new List<string>();

        /// <summary>
        /// Methode die dem jeweiligen Profil die Werte aus der Access Tabelle speichert und einliest
        /// </summary>
        public void SetasCurrentProfile()
        {
            // Zurücksetzen der Listen
            RecipeFilterForm.recipeFilterForm.listBox1.Items.Clear();
            RecipeFilterForm.recipeFilterForm.listBox2.Items.Clear();
            BaseIngredient.baseIngredient.BIngredient.Clear();
            SelfInputForm.selfInputForm.listBox1.Items.Clear();
            if (ActiveProfile != null)
            {
                // Login & Registrieren werden zu Profil, und Abmelden Knöpfe
                StartPage.startPage.Btn_Login.Text = "Profil";
                StartPage.startPage.Btn_Regitrate.Text = "Abmelden";
                StartPage.startPage.OpenChildForm(ActiveProfile);
                
                con.Open();
                string login = "SELECT * FROM tbl_users WHERE username= '" + Name + "' and password= '" + Password + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();
                // falls Feld lesbar ist praktisch
                if (dr.Read() == true)
                {
                    // speichert alle Werte
                    SaveDietValueToProfile(dr);
                    string value2 = (dr["allergy"]).ToString();
                    string value3 = (dr["ingredients"]).ToString();
                    string value4 = (dr["selfinput"]).ToString();
                    RecipeFilterForm.recipeFilterForm.listBox1.Items.Clear();
                    RecipeFilterForm.recipeFilterForm.listBox2.Items.Clear();
                    SelfInputForm.selfInputForm.DeleteAllSelfInputForm();
                    StockForm.stockForm.UncheckAllCheckBoxes(StockForm.stockForm);
                    GiveValueToIngredientList(StringToStringList(value3),
                        RecipeFilter.recipeFilter.IngredientAvaliable);
                    PreferencesForm.preferencesForm.listBox2.Items.Clear();
                    Preferences.preferences.Allergy.Clear();
                    if (!string.IsNullOrEmpty(value3))
                    {
                        richTextBox1.Text = value3;
                    }
                    if(value2 != "")
                    {
                        GiveValueToListBox(StringToStringList(value2), PreferencesForm.preferencesForm.listBox2);
                        GiveValueToIngredientList(StringToStringList(value2), Preferences.preferences.Allergy);
                    }

                    if (value4 != "")
                    {
                        GiveValueToListBox(StringToStringList(value4), SelfInputForm.selfInputForm.listBox1);
                    }
                    Allergy_Label.Text = $"Allergien: {value2}";
                    StockForm.stockForm.CheckAllCheckBoxes(StringToStringList(value3));
                    
                }

                con.Close();
            }
        }

        /// <summary>
        /// Speichert und setzt den in der Access Tabelle gespeicherten Diät Wert
        /// </summary>
        /// <param name="dr"></param>
        private void SaveDietValueToProfile(OleDbDataReader dr)
        {
            if (dr["diet"] != DBNull.Value)
            {
                int value = Convert.ToInt32(dr["diet"]);
                if (value == 1)
                {
                    Diet_Label.Text = "Diät: Omnivor";
                    PreferencesForm.preferencesForm.RadioButton_Omnivor.Checked = true;
                }
                else if (value == 2)
                {
                    Diet_Label.Text = "Diät: Vegetarisch";
                    PreferencesForm.preferencesForm.RadioButton_Vegetarisch.Checked = true;
                }
                else if (value == 3)
                {
                    Diet_Label.Text = "Diät: Vegan";
                    PreferencesForm.preferencesForm.RadioButton_Vegan.Checked = true;
                }
                else
                {
                    Diet_Label.Text = "Diät:";
                }
            }
        }

        // benötigt für Zugriff auf Access Tabelle
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;

        /// <summary>
        /// Profile Konstruktor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public Profile(string name, string password)
        {
            InitializeComponent();
            string a = Path.GetFullPath("db_users.mdb");
            con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;;Data Source={a}");
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();
            Name = name;
            Password = password;
        }

        public Profile(string name)
        {
            InitializeComponent();
            label1.Text = $"Herzlichen willkommen {name}";
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            label1.Text = $"Herzlich Willkommen {Name}, du hast dich erfolgreich eingeloggt.";
        }

        /// <summary>
        /// Methode zur Änderung des Benutzernamens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string x = "UPDATE [tbl_users] SET [username] = '" + textBox1.Text + "' WHERE username= '" + Name + "'";
                da.UpdateCommand = con.CreateCommand();
                da.UpdateCommand.CommandText = x;
                da.UpdateCommand.ExecuteNonQuery();
                textBox1.Text = "";

                MessageBox.Show("Ihr Username wurde geändert", "Benutzername ändern erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                StartPage.startPage.LogOff();
                con.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Username schon existiert", "Benutzername ändern fehlgeschlagen", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox1.Focus();
                con.Close();
            }
        }

        /// <summary>
        /// Methode zur Änderung des Passwortes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string passwordchange = "SELECT * FROM tbl_users WHERE username= '" + Name + "' and password= '" +
                                    Password + "'";
            cmd = new OleDbCommand(passwordchange, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (txtPassword.Text == Password)
                {
                    if (txtNewPassword.Text == TxtComNewPassword.Text)
                    {
                        if (txtPassword.Text == txtNewPassword.Text)
                        {
                            MessageBox.Show("Neu Passwort kann nicht gleich wie Alt Passwort sein",
                                "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                            txtNewPassword.Text = "";
                            TxtComNewPassword.Text = "";
                            txtPassword.Focus();
                            con.Close();
                        }
                        else
                        {
                            string x = "UPDATE [tbl_users] SET [password] = '" + txtNewPassword.Text +
                                       "' WHERE username= '" + Name + "'";
                            da.UpdateCommand = con.CreateCommand();
                            da.UpdateCommand.CommandText = x;
                            da.UpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Ihr Passwort wurde geändert, bitte nochmals einloggen",
                                "Password ändern erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StartPage.startPage.LogOff();
                            txtPassword.Text = "";
                            txtNewPassword.Text = "";
                            TxtComNewPassword.Text = "";
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwörter stimmen nicht überein, bitte erneut eingeben",
                            "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                        txtNewPassword.Text = "";
                        TxtComNewPassword.Text = "";
                        txtPassword.Focus();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Das Passwort ist falsch. Bitte versuchen Sie es nochmal",
                        "Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtNewPassword.Text = "";
                    TxtComNewPassword.Text = "";
                    txtPassword.Focus();
                    con.Close();
                }
            }
        }

        public void GiveValueToListBox(List<string> stringList, ListBox listBox)
        {
            foreach (string value in stringList)
            {
                listBox.Items.Add(value);
            }
        }

        public void GiveValueToIngredientList(List<string> stringList, List<Ingredient> ingredientList)
        {
            foreach (string value in stringList)
            {
                ingredientList.Add(new Ingredient(value));
            }
        }

        public List<string> StringToStringList(string ingredientsasString)
        {
            List<string> stringList = new List<string>();
            string replacement = ingredientsasString.Replace(" und ", ", ");
            string[] words = replacement.Split(", ");

            foreach (string word in words)
            {
                stringList.Add(word);
            }

            return stringList;
        }

        public List<string> ListboxItemsToStringList(ListBox listbox, List<string> stringList)
        {
            foreach (string Item in listbox.Items)
            {
                stringList.Add(Item);
            }

            return stringList;
        }

        // Knopf zum Konto löschen
        private void button3_Click(object sender, EventArgs e)
        {
            string a1 = "Provider=Microsoft.ACE.OLEDB.12.0;;Data Source=db_users.mdb";
            using (OleDbConnection conn = new OleDbConnection(a1))
            {
                if (MessageBox.Show("Sind Sie sicher das Konto zu löschen?", "Magischrank", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        this.Hide();
                        conn.Open();
                        String delQuery = "DELETE FROM [tbl_users] WHERE username = '" + Name + "'";
                        OleDbCommand delcmd = new OleDbCommand();
                        delcmd.CommandText = delQuery;
                        delcmd.Connection = conn;
                        delcmd.Parameters.AddWithValue("@username", 2);
                        delcmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Konto wurde erfolgreich entfernt !");
                        ActiveProfile = null;
                        PreferencesForm.preferencesForm.listBox2.Items.Clear();
                        Preferences.preferences.Allergy.Clear();
                        StartPage.startPage.Btn_Login.Text = "Login";
                        StartPage.startPage.Btn_Regitrate.Text = "Registrieren";
                        PreferencesForm.preferencesForm.RadioButton_Omnivor.Checked = false;
                        PreferencesForm.preferencesForm.RadioButton_Vegetarisch.Checked = false;
                        PreferencesForm.preferencesForm.RadioButton_Vegan.Checked = false;
                        StartPage.startPage.OpenChildForm(new Registration());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error !");
                    }
                }
            }
        }

        //Knopf zum Vorräte löschen
        private void button4_Click(object sender, EventArgs e)
        {
            RecipeFilter.recipeFilter.IngredientAvaliable.Clear();
            StockForm.stockForm.UncheckAllCheckBoxes(StockForm.stockForm);
            richTextBox1.Clear();
            PreferencesForm.preferencesForm.SaveValueToProfile("ingredients", "");
        }
    }
}
