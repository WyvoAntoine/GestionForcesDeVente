using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{

    public class Directeurs : GestionForceDeVente
    {
        private Region uneRegion;
        
        public Directeurs(int id, String nom, String prenom, int nbEnfant, String situationFamiliale, string dateNaissance, string dateEmbauche, int grade) : base(id, nom, prenom, nbEnfant, situationFamiliale, dateNaissance, dateEmbauche, grade)
        {

        }

        public Directeurs(int id, String nom, String prenom, int nbEnfant, String situationFamiliale, string dateNaissance, string dateEmbauche, int grade, Region uneRegion) :base(id, nom, prenom, nbEnfant, situationFamiliale, dateNaissance, dateEmbauche, grade)
        {
            this.uneRegion = uneRegion;
        }

        public Directeurs(String nom, String prenom, int nbEnfant, String situationFamiliale, string dateNaissance, string dateEmbauche, int grade, Region uneRegion) : base(nom, prenom, nbEnfant, situationFamiliale, dateNaissance, dateEmbauche, grade)
        {
            this.uneRegion = uneRegion;
        }

        public Directeurs()
        {

        }

        public Region getRegion()
        {
            return this.uneRegion;
        }

        public void setRegion(Region uneRegion)
        {
            this.uneRegion = uneRegion;
        }

        public int getAge()
        {
            return DateTime.Today.Year - DateTime.Parse(this.getDateNaissance()).Year;
        }

        public override String toString()
        {
            String message = String.Empty;
            message += "ID : " + this.getId() + "\n";
            message += "Nom : " + this.getNom() + "\n";
            message += "Prénom : " + this.getPrenom() + "\n";
            message += "Nombre d'enfant(s) : " + this.getNbEnfant() + "\n";
            message += "Situation familiale : " + this.getSituationFamiliale() + "\n";
            message += "Année naissance : " + this.getDateNaissance() + "\n";
            message += "Année embauche : " + this.getDateEmbauche() + "\n";
            message += "Grade : " + this.getGrade() + "\n";
            try
            {
                message += "Région : \n" + this.getRegion().getLibelleRegion() + "\n";
            }
            catch
            {
                message += "Région : Ce directeur ne supervise aucune région.";
            }
            
            return message;
        }

    }
}
