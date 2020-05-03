using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_visites
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dbtype = "mysql";
            //string chaineConnexion = "Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Pooling=False;Encrypt=False;";
            string chaineConnexion = "Server=localhost;Database=bdd_gsb_csharp;Uid=root;Pwd=;SslMode=none;";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm(chaineConnexion, dbtype));
        }
    }
}
