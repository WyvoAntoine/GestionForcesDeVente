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
    public static class Passerelle
    {
        private static List<Directeurs> desDirecteurs = new List<Directeurs>();
        private static List<Visiteurs> desVisiteurs = new List<Visiteurs>();
        private static List<Region> lesRegions = new List<Region>();
        //private static List<Directeurs> lesDirecteursSansRegion = new List<Directeurs>();
        private static List<Region> lesRegionsSansDirecteurs = new List<Region>();        
        private static List<Evaluation> lesEvaluations = new List<Evaluation>();
        private static Dictionary<int, Evaluation> unD = new Dictionary<int, Evaluation>();

        /*public static void initLesListes()
        {
            desDirecteurs.Add(new Directeurs("WYBO", "Antoine", 1, "célibataire", "2002/07/31", "2002/07/31", 1, new Region("test")));
            desDirecteurs.Add(new Directeurs("dqze", "ezqdz", 2, "célibataire", "2002/07/31", "2002/07/31", 0, new Region("test")));
            desDirecteurs.Add(new Directeurs("qsdfdsds", "ssqsddss", 2, "célibataire", "2002/07/31", "2002/07/31", 0, new Region("test")));

            unD.Add(2020, new Evaluation("Bon (+)", 6));
            unD.Add(2019, new Evaluation("Très Mauvais (-)", 0));

            
            desVisiteurs.Add(new Visiteurs("ratata", "ratata", new DateTime(2002,07,31), new Directeurs("qsdfdsds", "ssqsddss", 2, "célibataire", new DateTime(2006, 06, 28), new DateTime(2022, 07, 31), 0, new Region("Sud")), new Evaluation("Bon (+)", 6), new Dictionary<int, Evaluation>(5, new Evaluation("Bon (-)"))));
            desVisiteurs.Add(new Visiteurs("yolo", "yolo", new DateTime(2001,03,28), new Directeurs("dqze", "ezqdz", 2, "célibataire", new DateTime(2001, 03, 28), new DateTime(2022, 07, 31), 0, new Region("Paris"), new Evaluation("Bon (+)", 6))));
            desVisiteurs.Add(new Visiteurs("zvent", "zvent", new DateTime(2006, 06, 28), new Directeurs("qsdfdsds", "ssqsddss", 2, "célibataire", new DateTime(2006, 06, 28), new DateTime(2022, 07, 31), 0, new Region("Sud"), new Evaluation("Bon (+)", 6))));
            desVisiteurs.Add(new Visiteurs("test", "test", new DateTime(2006, 06, 28), new Directeurs("qsdfdsds", "ssqsddss", 2, "célibataire", new DateTime(2006, 06, 28), new DateTime(2022, 07, 31), 0, new Region("Sud"), new Evaluation("Bon (+)", 6))));
            
            
            lesEvaluations.Add(new Evaluation("Aucune Evaluation", 0));
            lesEvaluations.Add(new Evaluation("Très Mauvais (-)", 0));
            lesEvaluations.Add(new Evaluation("Très Mauvais (+)", 1));
            lesEvaluations.Add(new Evaluation("Mauvais (-)", 2));
            lesEvaluations.Add(new Evaluation("Mauvais (+)", 3));
            lesEvaluations.Add(new Evaluation("Passable", 4));
            lesEvaluations.Add(new Evaluation("Bon (-)", 5));
            lesEvaluations.Add(new Evaluation("Bon (+)", 6));
            lesEvaluations.Add(new Evaluation("Très bon (-)", 7));
            lesEvaluations.Add(new Evaluation("Très bon (+)", 8));
            lesEvaluations.Add(new Evaluation("Excellent (-)", 9));
            lesEvaluations.Add(new Evaluation("Excellent (+)", 10));           
        }*/

        public static void initListeDirecteur()

        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            var requeteDirecteur = "SELECT * FROM directeur D INNER JOIN forcesdevente F ON D.idForcesDeVente = F.idForcesDeVente;";
            MySqlDataReader rdrDirecteur = new MySqlCommand(requeteDirecteur, conn).ExecuteReader();
            while (rdrDirecteur.Read())
            {
                try
                {
                    desDirecteurs.Add(new Directeurs(int.Parse(rdrDirecteur["idForcesDeVente"].ToString()),
                        rdrDirecteur["nomForcesDeVente"].ToString(), rdrDirecteur["prenomForcesDeVente"].ToString(),
                        int.Parse(rdrDirecteur["nbEnfants"].ToString()), rdrDirecteur["situationFamiliale"].ToString(),
                        rdrDirecteur["dateNaiss"].ToString(), rdrDirecteur["dateEmbauche"].ToString(),
                        int.Parse(rdrDirecteur["idGrade"].ToString())));                
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            rdrDirecteur.Close();
            conn.Close();
        }

        public static void initListeRegion() 
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var requeteRegion = "SELECT * FROM region;";
            MySqlDataReader rdrRegion = new MySqlCommand(requeteRegion, conn).ExecuteReader();
            while (rdrRegion.Read())
            {
                String idDirecteur = rdrRegion["directeurRegion"].ToString();

                if (idDirecteur == "")
                {
                    idDirecteur = "null";
                    lesRegions.Add(new Region(int.Parse(rdrRegion["idRegion"].ToString()), rdrRegion["nomRegion"].ToString()));
                }
                else
                {
                    Directeurs leDirecteurDeRegion = new Directeurs();
                    foreach (Directeurs leDirecteur in desDirecteurs)
                    {
                        if (leDirecteur.getId().ToString() == idDirecteur)
                        {
                            leDirecteurDeRegion = leDirecteur;
                        }
                    }

                    lesRegions.Add(new Region(int.Parse(rdrRegion["idRegion"].ToString()), rdrRegion["nomRegion"].ToString(), leDirecteurDeRegion));
                }

                foreach (Region uneRegion in lesRegions)
                {
                    foreach (Directeurs unD in desDirecteurs)
                    {
                        if (unD.getId() == uneRegion.getIdDirecteur())
                            unD.setRegion(uneRegion);
                    }
                }
            }
            rdrRegion.Close();
            conn.Close();
        }

        /*public static void initListeDirecteurSansRegion()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var requeteDirecteurSansRegion = "SELECT * FROM directeur D INNER JOIN forcesdevente F ON D.idForcesDeVente = F.idForcesDeVente INNER JOIN region R ON D.idDirecteur = R.directeurRegion WHERE R.directeurRegion IS NULL;";
            MySqlDataReader rdrDirecteurSansRegion = new MySqlCommand(requeteDirecteurSansRegion, conn).ExecuteReader();

            while (rdrDirecteurSansRegion.Read())
            {
                desDirecteurs.Add(new Directeurs(int.Parse(rdrDirecteurSansRegion["idForcesDeVente"].ToString()), rdrDirecteurSansRegion["nomForcesDeVente"].ToString(), rdrDirecteurSansRegion["prenomForcesDeVente"].ToString(), int.Parse(rdrDirecteurSansRegion["nbEnfants"].ToString()), rdrDirecteurSansRegion["situationFamiliale"].ToString(), rdrDirecteurSansRegion["dateNaiss"].ToString(), rdrDirecteurSansRegion["dateEmbauche"].ToString(), int.Parse(rdrDirecteurSansRegion["idGrade"].ToString()), null));
            }
            rdrDirecteurSansRegion.Close();
            conn.Close();
        }*/

        public static void initListeRegionSansDirecteur()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var requeteRegionSansDirecteur = "SELECT * FROM region WHERE directeurRegion IS NULL;";
            MySqlDataReader rdrRegionSansDirecteur = new MySqlCommand(requeteRegionSansDirecteur, conn).ExecuteReader();

            while (rdrRegionSansDirecteur.Read())
            { 
                lesRegionsSansDirecteurs.Add(new Region(int.Parse(rdrRegionSansDirecteur["idRegion"].ToString()), rdrRegionSansDirecteur["nomRegion"].ToString()));
            }
            rdrRegionSansDirecteur.Close();
            conn.Close();
        }

        public static void initListeVisiteurs()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var requeteVisiteur = "SELECT * FROM visiteur V INNER JOIN forcesdevente F ON V.idForcesDeVente = F.idForcesDeVente;";
            MySqlDataReader rdrVisiteur = new MySqlCommand(requeteVisiteur, conn).ExecuteReader();

            while (rdrVisiteur.Read())
            {
                Directeurs unD = new Directeurs();

                desVisiteurs.Add(new Visiteurs(int.Parse(rdrVisiteur["idForcesDeVente"].ToString()),
                            rdrVisiteur["nomForcesDeVente"].ToString(), rdrVisiteur["prenomForcesDeVente"].ToString(),
                            int.Parse(rdrVisiteur["nbEnfants"].ToString()), rdrVisiteur["situationFamiliale"].ToString(),
                            rdrVisiteur["dateNaiss"].ToString(), rdrVisiteur["dateEmbauche"].ToString(), unD, 
                            int.Parse(rdrVisiteur["idGrade"].ToString())));
            }
            rdrVisiteur.Close();
            conn.Close();
        }

        public static void ajouterDesVisiteurs(Visiteurs unV)
        {
            desVisiteurs.Add(unV);
        }

        public static List<Region> getLesRegions()
        {
            return lesRegions;
        }

        public static List<Region> getLesRegionSansDirecteur()
        {
            return lesRegionsSansDirecteurs;
        }

        public static List<Directeurs> getLesDirecteurs()
        {
            return desDirecteurs;
        }

        public static List<Visiteurs> getLesVisiteurs()
        {
            return desVisiteurs;
        }

        public static List<Evaluation> getLesEvaluations()
        {
            return lesEvaluations;
        }

        public static void createDirecteur(Directeurs unD)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var sql = "INSERT INTO forcesdevente VALUES(null, '" + 
                unD.getPrenom() + "', '" + unD.getNom() + "', '" + 
                unD.getNbEnfant().ToString() + "', '" + 
                unD.getSituationFamiliale() + "', '" + 
                unD.getDateNaissance() + "', '" + unD.getDateEmbauche()
                + "'," + unD.getGrade() + ");";

            var sql2 = "UPDATE region SET directeurRegion = " + unD.getId() + " WHERE nomRegion = '"+ unD.getRegion().getLibelleRegion() + "';";
            MySqlDataReader rdr = new MySqlCommand(sql2, conn).ExecuteReader();
            rdr.Close();
            MySqlDataReader requete = new MySqlCommand(sql, conn).ExecuteReader();
            requete.Close();
        }      

        public static void updateDirecteur(Directeurs unD)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var sqlUpdateDirecteur = "UPDATE forcesdevente SET nomForcesDeVente = '" + unD.getNom() 
                + "', nbEnfants = " + unD.getNbEnfant() 
                + ", situationFamiliale = '" + unD.getSituationFamiliale() + "', dateNaiss = '" +
                unD.getDateNaissance() + "', dateEmbauche = '" + unD.getDateEmbauche() + "', idGrade = " +
                unD.getGrade() + " WHERE idForcesDeVente = " + unD.getId() + ";";
            MySqlDataReader rdr = new MySqlCommand(sqlUpdateDirecteur, conn).ExecuteReader();
            conn.Close();
        }

        public static void deleteDirecteur(Directeurs unD)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var sqlDeleteDirecteur = "DELETE FROM forcesdevente WHERE idForcesDeVente = " + unD.getId() +";";
            MySqlDataReader rdr = new MySqlCommand(sqlDeleteDirecteur, conn).ExecuteReader();
            rdr.Close();
            conn.Close();
        }

        public static void createVisiteur(Visiteurs unV)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var sql = "INSERT INTO forcesdevente VALUES(null, '" +
                unV.getPrenom() + "', '" + unV.getNom() + "', '" +
                unV.getNbEnfant().ToString() + "', '" +
                unV.getSituationFamiliale() + "', '" +
                unV.getDateNaissance() + "', '" + unV.getDateEmbauche()
                + "'," + unV.getGrade() + ");";
            MySqlDataReader requete = new MySqlCommand(sql, conn).ExecuteReader();
            requete.Close();

            var sql2 = "UPDATE visiteur SET idDirecteur = "+ unV.getLeDirecteur().getId() + ";";
            MySqlDataReader rdr = new MySqlCommand(sql2, conn).ExecuteReader();
            rdr.Close();

        }

        public static void updateVisiteur(Visiteurs unV)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            var sqlUpdateVisiteur = "UPDATE forcesdevente SET nomForcesDeVente = '" + unV.getNom()
                + "', nbEnfants = " + unV.getNbEnfant()
                + ", situationFamiliale = '" + unV.getSituationFamiliale() + "', dateNaiss = '" +
                unV.getDateNaissance() + "', dateEmbauche = '" + unV.getDateEmbauche() + "', idGrade = " +
                unV.getGrade() + " WHERE idForcesDeVente = " + unV.getId() + ";";
            MySqlDataReader rdr = new MySqlCommand(sqlUpdateVisiteur, conn).ExecuteReader();
            rdr.Close();

            /*var sql2 = "UPDATE visiteur SET idDirecteur = " + unV.getLeDirecteur().getId() + ";";
            MySqlDataReader requete2 = new MySqlCommand(sql2, conn).ExecuteReader();
            rdr.Close();*/
            conn.Close();
        }
    }    
}
