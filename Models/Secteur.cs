using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{
    public class Secteur
    {
        private int numSecteur;
        private String libelleSecteur;
        private Region uneRegion;

        public Secteur(int numSecteur, String libelleSecteur, Region uneRegion)
        {
            this.numSecteur = numSecteur;
            this.libelleSecteur = libelleSecteur.ToUpper();
            this.uneRegion = uneRegion;
        }

        public int getNumSecteur()
        {
            return this.numSecteur;
        }

        public void setNumSecteur(int numSecteur)
        {
            this.numSecteur = numSecteur;

        }

        public string getLibelleSecteur()
        {
            return this.libelleSecteur;
        }

        public void setLibelleSecteur(String libelleSecteur)
        {
            this.libelleSecteur = libelleSecteur;
        }
        
        public Region getLaRegion()
        {
            return this.uneRegion;
        }

        public void setLaRegion(Region nouvelleRegion)
        {
            this.uneRegion = nouvelleRegion;
        }

        public String toString()
        {
            String message = string.Empty;
            message += "Numéro de secteur :" + numSecteur + "/n";
            message += "Libelle du secteur :" + libelleSecteur;
            return message;
        }
    }    
}
