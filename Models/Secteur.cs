using System;
using System.Collections.Generic;
using System.Text;

namespace GestionForceDeVenteGSB
{
    class Secteur
    {
        private int numSecteur;
        private String libelleSecteur;

        public Secteur(int numSecteur, String libelleSecteur)
        {
            this.numSecteur = numSecteur;
            this.libelleSecteur = libelleSecteur.ToUpper();
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
        

        public String toString()
        {
            String message = string.Empty;
            message += "Numéro de secteur :" + numSecteur + "/n";
            message += "Libelle du secteur :" + libelleSecteur;
            return message;
        }
    }    
}
