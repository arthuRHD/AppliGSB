using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Odbc;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data.SqlClient;

namespace GSB_visites
{
    public partial class HomeForm : Form
    {
        private string chaineConnexion = "";
        private string type = "";
        public HomeForm(string ch, string dbtype)
        {
            InitializeComponent();
            this.chaineConnexion = ch;
            this.type = dbtype;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {             
            try
            {
                Cursor db = new Cursor(this.chaineConnexion, this.type);
                string name = loginTxt.Text;
                string year = passwordTxt.Text.Substring(7, 4);
                string day = passwordTxt.Text.Substring(0, 2);
                string month = passwordTxt.Text.Substring(3, 3);
                string date = dateParser(year, month, day);
                string request_login = $"SELECT visiteur.VIS_NOM, visiteur.VIS_PRENOM, visiteur.VIS_DATEEMBAUCHE FROM visiteur WHERE visiteur.VIS_DATEEMBAUCHE = '{date}' AND visiteur.VIS_NOM = '{name}';";
                if (db.reqSelect(request_login))
                {
                    string user = db.champ("VIS_NOM") + " " + db.champ("VIS_PRENOM");
                    MessageBox.Show($"Bienvenue {user}", "GSB Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuForm menu = new MenuForm(this.chaineConnexion, this.type, user);
                    menu.Show();
                    this.Hide();                    
                }
                else
                {
                    MessageBox.Show("Connexion échouée", "GSB Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginTxt.Text = "";
                    passwordTxt.Text = "";
                }
                db.fermer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GSB Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginTxt.Text = "";
                passwordTxt.Text = "";
                throw;
            }
        }

        public string dateParser(string year, string month, string day)
        {
            int parsedMonth = DateTime.Parse("1." + month + " 2000").Month;
            DateTime parsedDate = new DateTime(Int32.Parse(year), parsedMonth, Int32.Parse(day));
            string date = parsedDate.ToString("yyyy-MM-dd");
            return date;
        }
    }    
}
