using System;
using System.Collections.Generic;
using System.Text;

namespace GestionForceDeVenteGSB
{
    class Directeurs
    {
        private String nom;
        private String prenom;
        private int age;
        private Region uneRegion;
        

        public Directeurs(String nom, String prenom, int age, Region uneRegion)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.uneRegion = uneRegion;
        }
    }
}
