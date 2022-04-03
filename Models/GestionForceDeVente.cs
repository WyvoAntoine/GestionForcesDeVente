using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tutorial.SqlConn;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{
    public class GestionForceDeVente
    {
        private int id;
        private String nom;
        private String prenom;
        private int nbEnfant;
        private String situationFamiliale;
        private String dateNaissance;
        private String dateEmbauche;
        private int grade;

        public int Id { get => id; set => id = value; }
        public String Nom { get => nom; set => nom = value; }
        public String Prenom { get => prenom; set => prenom = value; }

        public GestionForceDeVente(int id, String nom, String prenom, int nbEnfant, String situationFamiliale, String dateNaissance, String dateEmbauche, int grade)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.nbEnfant = nbEnfant;
            this.situationFamiliale = situationFamiliale;
            this.dateNaissance = dateNaissance;
            this.dateEmbauche = dateEmbauche;
            this.grade = grade;
        }

        public GestionForceDeVente(String nom, String prenom, int nbEnfant, String situationFamiliale, String dateNaissance, String dateEmbauche, int grade)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.nbEnfant = nbEnfant;
            this.situationFamiliale = situationFamiliale;
            this.dateNaissance = dateNaissance;
            this.dateEmbauche = dateEmbauche;
            this.grade = grade;
        }

        public GestionForceDeVente()
        {
           
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getNom()
        {
            return this.nom;
        }

        public String getPrenom()
        {
            return this.prenom;
        }

        public int getNbEnfant()
        {
            return this.nbEnfant;
        }

        public String getSituationFamiliale()
        {
            return this.situationFamiliale;
        }

        public String getDateNaissance()
        {
            return this.dateNaissance;
        }

        public String getDateEmbauche()
        {
            return this.dateEmbauche;
        }

        public int getGrade()
        {
            return this.grade;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }

        public void setNbEnfant(int nbEnfant)
        {
            this.nbEnfant = nbEnfant;
        }

        public void setSituationFamiliale(String situationFamiliale)
        {
            this.situationFamiliale = situationFamiliale;
        }

        public void setDateNaissance(String dateNaissance)
        {
             this.dateNaissance = dateNaissance;
        }

        public void setDateEmbauche(String dateEmbauche)
        {
            this.dateEmbauche = dateEmbauche;
        }

        public void setGrade(int grade)
        {
            this.grade = grade;
        }

        public virtual String toString()
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
            return message;
        }

    }
}
