using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_visites
{
    public partial class SearchForm : Form
    {
        private string categorie = "";
        private string type = "";
        private string chaineConnexion;
        private IDictionary<string, string> dict = new Dictionary<string, string>();

        public SearchForm(string ch, string dbtype, string cat, string nom=null)
        {
            InitializeComponent();
            this.categorie = cat;
            this.type = dbtype;
            this.chaineConnexion = ch;
            lbl_cat.Text = categorie;
            this.Text += $" {categorie}";
            this.dict.Add("Médicament", "medicament");
            this.dict.Add("Visiteur", "visiteur");
            this.dict.Add("Praticien", "praticien");
            if (nom != null)
            {
                txtSearch.Text = nom;
                this.btnSearch_Click(btnSearch, EventArgs.Empty);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {            
            try
            {
                dgSearch.Hide();
                dgSearch.DataSource = null;
                dgSearch.Refresh();
                
                string table = this.dict[this.categorie];                
                string searchInput = txtSearch.Text ?? null;
                string requete = "";
                if (searchInput == null) 
                {
                    requete = $"SELECT * FROM {table}";
                }                
                switch (this.categorie)
                {
                    case "Visiteur":
                        requete = $"SELECT * FROM visiteur WHERE VIS_NOM LIKE '%{searchInput}%' OR VIS_PRENOM LIKE '%{searchInput}%' OR VIS_MATRICULE LIKE '%{searchInput}%' OR VIS_CP LIKE '%{searchInput}%';";
                        break;
                    case "Praticien":
                        requete = $"SELECT * FROM praticien WHERE PRA_NOM LIKE '%{searchInput}%' OR PRA_PRENOM LIKE '%{searchInput}%' OR PRA_CP LIKE '%{searchInput}%' OR PRA_COEFNOTORIETE LIKE '%{searchInput}%';";
                        break;
                    case "Médicament":
                        requete = $"SELECT * FROM medicament WHERE MED_NOMCOMMERCIAL LIKE '%{searchInput}%' OR MED_DEPOTLEGAL LIKE '%{searchInput}%';";
                        break;
                }
                Cursor db = new Cursor(this.chaineConnexion, this.type);
                DataSet ds = new DataSet();                
                db.remplir(requete, ds, table);
                dgSearch.DataSource = ds;
                dgSearch.DataMember = table;
                db.fermer();
                dgSearch.Show();
            }
            catch (Exception err)
            {
                string header = $"GSB Recherche par {this.categorie}";
                MessageBox.Show(err.Message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
