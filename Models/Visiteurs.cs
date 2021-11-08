using System;
using System.Collections.Generic;
using System.Text;

namespace GestionForceDeVenteGSB
{
    class Visiteurs
    {
        private int numVisiteur;
        private String nomVisiteur;
        private String prenomVisiteur;
        private Secteur unSecteur;
        private Evaluation uneEvaluation;

        public Visiteurs(int numVisiteur, String nomVisiteur, String prenomVisiteur, Secteur unSecteur, Evaluation uneEvaluation)
        {
            this.numVisiteur = numVisiteur;
            this.nomVisiteur = nomVisiteur;
            this.prenomVisiteur = prenomVisiteur;
            this.unSecteur = unSecteur;
            this.uneEvaluation = uneEvaluation;
        }

        public int getNumVisiteurs()
        {
            return this.numVisiteur;
        }

        public String getNomVisiteurs()
        {
            return this.nomVisiteur;
        }

        public Secteur getLeSecteur()
        {
            return this.unSecteur;
        }

        public Evaluation getUneEvaluation()
        {
            return this.uneEvaluation;
        }

        public void setNumVisiteurs(int numVisiteur)
        {
            this.numVisiteur = numVisiteur;
        }

        public void setNomVisiteurs(String nomVisiteur)
        {
            this.nomVisiteur = nomVisiteur;
        }

        public void setPrenomVisiteurs(String prenomVisiteur)
        {
            this.prenomVisiteur = prenomVisiteur;
        }

        public void setLeSecteur(Secteur unSecteur)
        {
            this.unSecteur = unSecteur;
        }

    }
}
