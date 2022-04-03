using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MessageBox.Show("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                MessageBox.Show("Openning Connection ...");

                conn.Open();

                MessageBox.Show("Connection successful!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            Console.Read();
            
            Passerelle.initListeDirecteur();
            Passerelle.initListeRegion();
            Passerelle.initListeRegionSansDirecteur();
            //Passerelle.initListeDirecteurSansRegion();
            Passerelle.initListeVisiteurs();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAccueil());

        }
    }
}
