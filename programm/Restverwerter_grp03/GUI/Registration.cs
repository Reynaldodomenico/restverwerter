using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace GUI
{
    public partial class Registration : Form
    {
        public static Registration registration = new Registration();
        public Registration()
        {
            InitializeComponent();
            string a = Path.GetFullPath("db_users.mdb");           
            con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;;Data Source={a}");
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();
        }
      
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
 
        /// <summary>
        /// Knopf zum Registrieren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Felder für Benutzername und Passwort sind leer", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                try
                {
                    cmd = new OleDbCommand("INSERT INTO tbl_users ([username], [password]) VALUES (?,?)", con);
                    cmd.Parameters.AddWithValue(@"username", OleDbType.VarChar).Value = txtUsername.Text;
                    cmd.Parameters.AddWithValue(@"password", OleDbType.VarChar).Value = txtPassword.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";


                    MessageBox.Show("Ihr Konto wurde erfolgreich erstellt", "Registrierung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StartPage.startPage.OpenChildForm(new Login());
                    Close();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Username schon existiert", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtComPassword.Text = "";
                    txtPassword.Focus();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein, bitte erneut eingeben", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        // Checkbox zum Zeigen der Buchstaben des Passwortes
        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtComPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtComPassword.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Clear Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        // Knopf zum gelangen  des Logins
        private void label6_Click(object sender, EventArgs e)
        {
            StartPage.startPage.OpenChildForm(new Login());
            Close();
        }
    }
}
