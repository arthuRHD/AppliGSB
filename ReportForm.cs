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
    public partial class ReportForm : Form
    {
        private string chaineConnexion = "";
        private string type = "";
        private string username = "";
        public ReportForm(string ch, string dbtype, string user)
        {
            InitializeComponent();
            this.chaineConnexion = ch;
            this.type = dbtype;
            this.username = user;
            txtNumRapport.Enabled = false;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string infoPra = cbxPraticien.SelectedIndex.ToString();
            SearchForm searchPraticien = new SearchForm(chaineConnexion, "Praticien", infoPra);
            searchPraticien.Show();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            load_Praticiens();
            load_Report();
            reset_Echantillon();
            load_Echantillon();
        }

        private void load_Praticiens()
        {
            Cursor db = new Cursor(this.chaineConnexion, this.type);
            db.reqSelect("SELECT PRA_NOM, PRA_PRENOM FROM praticien;");
            bool fin = db.fin();
            while (!db.fin())
            {
                string value = db.champ("PRA_NOM").ToString() + " " + db.champ("PRA_PRENOM").ToString();
                cbxPraticien.Items.Add(value);
                db.suivant();
            }
            db.fermer();
        }

        private void load_Report()
        {
            Cursor db = new Cursor(this.chaineConnexion, this.type);
            string cbxValue = cbxPraticien.Text;
            string[] infoPra = cbxValue.Split(' ');
            string requete = $"SELECT VIS_MATRICULE, RAP_NUM, PRA_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF FROM rapport_visite WHERE PRA_NUM = {this.getNumPra(infoPra[0], infoPra[1])};";
            db.reqSelect(requete);
            txtNumRapport.Text = db.champ("RAP_NUM").ToString();
            txtBilan.Text = db.champ("RAP_BILAN").ToString();
            txtMotif.Text = db.champ("RAP_MOTIF").ToString();
            txtDate.Text = db.champ("RAP_DATE").ToString();
            db.fermer();
        }

        private void load_Echantillon()
        {
            Cursor db = new Cursor(this.chaineConnexion, this.type);
            string numRapport = txtNumRapport.Text;
            string requete = $"SELECT MED_DEPOTLEGAL, OFF_QTE FROM offrir WHERE RAP_NUM = {numRapport}";
            DataSet ds = new DataSet();
            db.remplir(requete, ds, "offrir");
            dgEchantillon.DataSource = ds;
            dgEchantillon.DataMember = "offrir";
            var cbox = new DataGridViewComboBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DataPropertyName = dgEchantillon.Columns["MED_DEPOTLEGAL"].Name,
                HeaderText = "Médicament"
            };
            dgEchantillon.Columns.Add(cbox);
            var r = dgEchantillon.Columns.OfType<DataGridViewTextBoxColumn>().Where(x => x.Name == "MED_DEPOTLEGAL").FirstOrDefault();
            dgEchantillon.Columns.Remove(r);
            db.fermer();
            dgEchantillon.Show();
        }

        private void reset_Echantillon()
        {
            dgEchantillon.Hide();
            dgEchantillon.DataSource = null;
            dgEchantillon.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbxPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ReportForm_Load(this, EventArgs.Empty);
        }

        private int getNumPra(string nom, string prenom)
        {
            Cursor db = new Cursor(this.chaineConnexion, this.type);
            string req = $"SELECT PRA_NUM FROM praticien WHERE PRA_NOM = '{nom}' AND PRA_PRENOM = '{prenom}';";
            db.reqSelect(req);
            string result = db.champ("PRA_NUM").ToString();
            return Int32.Parse(result);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Etes vous sur ?", "GSB Comptes rendus", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dresult == DialogResult.OK)
            {
                Cursor db = new Cursor(this.chaineConnexion, this.type);
                string req1 = "UPDATE FROM rapport_visite SET ";
                req1 += $"RAP_DATE='{txtDate.Text}', ";
                req1 += $"RAP_BILAN='{txtBilan.Text}', ";
                req1 += $"RAP_MOTIF='{txtMotif.Text}', ";
                req1 += $"RAP_DATE='{txtDate.Text}', ";
                req1 += $"WHERE RAP_NUM = {txtNumRapport.Text}";
                db.reqAdmin(req1);
                db.fermer();
                Cursor cs = new Cursor(this.chaineConnexion, this.type);
                string req2 = "UPDATE FROM offrir SET ";
                req2 += $"OFF_QTE={dgEchantillon.Columns["OFF_QTE"]} ";
                req2 += $"WHERE MED_DEPOTLEGAL='{dgEchantillon.Columns["OFF_QTE"]}' AND ";
                req2 += $"RAP_NUM={txtNumRapport.Text} AND ";
                req2 += $"VIS_MATRICULE='{this.getMatricule()}'";
                cs.reqAdmin(req2);
                cs.fermer();
                MessageBox.Show("Rapport modifié");
            }
        }

        private string getMatricule()
        {
            Cursor db = new Cursor(chaineConnexion, type);
            string[] infoVis = username.Split(' ');
            string requete = $"SELECT VIS_MATRICULE FROM visiteur WHERE VIS_NOM = '{infoVis[0]}' AND VIS_PRENOM = '{infoVis[1]}';";
            db.reqSelect(requete);
            return db.champ("VIS_MATRICULE").ToString();
        }
    }
}
