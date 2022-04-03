using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{
    public class Evaluation
    {
        private String libelleEvaluation;
        private int nbPointEvaluation;

        public string LibelleEvaluation { get => libelleEvaluation; set => libelleEvaluation = value; }

        public Evaluation(String libelleEvaluation, int nbPointEvaluation)
        {
            this.libelleEvaluation = libelleEvaluation;
            this.nbPointEvaluation = nbPointEvaluation;
        }

        public String getLibelleEvaluation()
        {
            return this.libelleEvaluation;
        }

        public void setLibelleEvaluation(String libelleEvaluation)
        {
            this.libelleEvaluation = libelleEvaluation;
        }

        public int getNbPointEvaluation()
        {
            return this.nbPointEvaluation;
        }

        public void setNbPointEvaluation(int nbPointEvaluation)
        {
            this.nbPointEvaluation = nbPointEvaluation;
        }
        public String toString()
        {
            String message = string.Empty;
            message += "Evaluation :" + libelleEvaluation;
            message += "Nombre de points :" + nbPointEvaluation;
            return message;
        }
    }
}
