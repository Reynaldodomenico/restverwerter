using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace GUI
{
    public partial class Login : Form
    {
        /// <summary>
        /// für den Login wird Olebd verwendet.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            Error_Label.Text = "";
            string a = Path.GetFullPath("db_users.mdb");
            con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;;Data Source={a}");
            cmd = new OleDbCommand();
            _da = new OleDbDataAdapter();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter _da;

        /// <summary>
        /// Login Knopf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                // korrekter Login
                this.Hide();
                Profile.ActiveProfile = new Profile(txtUsername.Text, txtpassword.Text);
                Profile.ActiveProfile.SetasCurrentProfile();
                if(dr["diet"] != DBNull.Value)
                {
                    string a = dr["diet"].ToString();
                    int Value = Int32.Parse(a);
                    Preferences.preferences.Diet = (Recipe.DietValue) Value;
                }
                this.Close();
            }
            else
            {
                // fehlerhafter Login
                Error_Label.Text = "Ungültiger Benutzername oder Passwort. Bitte versuchen Sie es nochmal";
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
                con.Close();
            }
        }

        /// <summary>
        /// Clear Knopf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        // Checkbox für das Einblenden oder ausblenden des tatsächlich geschriebenen Passwortes
        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        //Label auf dem man klicken kann falls man doch noch nicht registriert ist.
        private void label6_Click(object sender, EventArgs e)
        {
            StartPage.startPage.OpenChildForm(new Registration());
        }
    }
}