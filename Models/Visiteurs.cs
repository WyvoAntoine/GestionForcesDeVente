using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{
    public class Visiteurs : GestionForceDeVente
    {
        private Directeurs unDirecteur;
        private Evaluation uneEvaluation;
        private Dictionary<int,Evaluation> lesEvaluations;
        private Secteur unSecteur;
        

        public Directeurs UnDirecteur { get => unDirecteur; set => unDirecteur = value; }
        public Evaluation UneEvaluation { get => uneEvaluation; set => uneEvaluation = value; }
        public Dictionary<int, Evaluation> LesEvaluations { get => lesEvaluations; set => lesEvaluations = value; }

        public Visiteurs(int id, String nom, String prenom, int nbEnfant, string situationFamiliale, string dateNaissance, string dateEmbauche, Directeurs unDirecteur, Evaluation uneEvaluation, Dictionary<int, Evaluation> lesEvaluations, int grade, Secteur unSecteur) : base(id,nom, prenom, nbEnfant, situationFamiliale, dateNaissance, dateEmbauche, grade)
        {
            this.unSecteur = unSecteur;
            this.unDirecteur = unDirecteur;
            this.uneEvaluation = uneEvaluation;
            this.lesEvaluations = lesEvaluations;
        }

        public Visiteurs(int id, String nom, String prenom, int nbEnfant, string situationFamiliale, string dateNaissance, string dateEmbauche, Directeurs unDirecteur, int grade) : base(id, nom, prenom, nbEnfant, situationFamiliale, dateNaissance, dateEmbauche, grade)
        {
            this.unDirecteur = unDirecteur;
        }

        public Visiteurs(String nom, String prenom, int nbEnfant, string situationFamiliale, string dateNaissance, string dateEmbauche, Directeurs unDirecteur, int grade) : base(nom, prenom, nbEnfant, situationFamiliale, dateNaissance, dateEmbauche, grade)
        {
            this.unDirecteur = unDirecteur;
        }

        public Secteur getSecteur()
        {
            return this.unSecteur;
        }

        public Directeurs getLeDirecteur()
        {
            return this.unDirecteur;
        }

        public Evaluation getUneEvaluation()
        {
            return this.uneEvaluation;
        }

        public Dictionary<int, Evaluation> getLesEvaluations()
        {
            return this.lesEvaluations;
        }

        public void setSecteur(Secteur unSecteur)
        {
            this.unSecteur = unSecteur;
        }

        public void setLeDirecteur(Directeurs unDirecteur)
        {
            this.unDirecteur = unDirecteur;
        }

        public void setEvalutaionVisiteurs(Evaluation uneEvaluation)
        {
            this.uneEvaluation = uneEvaluation;
        }

        public void setLesEvaluations(Dictionary<int, Evaluation> lesEvaluations)
        {
            this.lesEvaluations = lesEvaluations;
        }

        public void ajouterEvaluation(Evaluation uneEvaluation)
        {
            this.lesEvaluations[DateTime.Now.Year] = uneEvaluation;
        }
    }
}
