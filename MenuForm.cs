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
    public partial class MenuForm : Form
    {
        private string chaineConnexion = "";
        private string type = "";
        private string username;
        public MenuForm(string ch, string dbtype, string user)
        {
            this.chaineConnexion = ch;
            this.username = user;
            this.type = dbtype;
            InitializeComponent();
            lbl_user.Text = username;
            toolTip_btnMenuCR.SetToolTip(btnMenuCR, "Comptes rendus");
            toolTip_btnMenuVisiteur.SetToolTip(btnMenuVisiteur, "Visiteurs");
            toolTip_btnMenuPraticien.SetToolTip(btnMenuPracticien, "Praticiens");
            toolTip_btnMenuMedicament.SetToolTip(btnMenuMedicament, "Médicaments");
            toolTip_btnMenuQuitter.SetToolTip(btnMenuQuit, "Fermer le menu");
        }

        private void btnMenuQuit_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(this.chaineConnexion, this.type);
            home.Show();
            this.Close();
        }

        private void btnMenuCR_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm(this.chaineConnexion, this.type, this.username);
            report.Show();
        }

        private void btnMenuVisiteur_Click(object sender, EventArgs e)
        {
            SearchForm searchVisiteur = new SearchForm(this.chaineConnexion, this.type, "Visiteur");
            searchVisiteur.Show();
        }

        private void btnMenuPracticien_Click(object sender, EventArgs e)
        {
            SearchForm searchPraticien = new SearchForm(this.chaineConnexion, this.type, "Praticien");
            searchPraticien.Show();
        }

        private void btnMenuMedicament_Click(object sender, EventArgs e)
        {
            SearchForm searchMedicament = new SearchForm(this.chaineConnexion, this.type, "Médicament");
            searchMedicament.Show();
        }
    }
}
