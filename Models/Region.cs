using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{
    public class Region
    {
        private int id;
        private String libelleRegion;
        private int idDirecteur;
        private Directeurs leDirecteur;


        public Region(int id, String libelleRegion, int idDirecteur)
        {
            this.id = id;
            this.libelleRegion = libelleRegion;
            this.idDirecteur = idDirecteur;
        }

        public Region(int id, String libelleRegion, Directeurs leDirecteur)
        {
            this.id = id;
            this.libelleRegion = libelleRegion;
            this.leDirecteur = leDirecteur;
        }

        public Region(int id, String libelleRegion)
        {
            this.id = id;
            this.libelleRegion = libelleRegion;
        }

        public Region(String libelleRegion)
        {
            this.libelleRegion = libelleRegion;
        }

        public string LibelleRegion { get => libelleRegion; set => libelleRegion = value; }

        public int getId()
        {
            return this.id;
        }

        public String getLibelleRegion()
        {
            return this.libelleRegion;
        }

        public void setLibelleRegion(String libelleRegion)
        {
            this.libelleRegion = libelleRegion;
        }

        public int getIdDirecteur()
        {
            return this.idDirecteur;
        }

        public void setIdDirecteur(int idDirecteur)
        {
            this.idDirecteur = idDirecteur;
        }

        public Directeurs getDirecteur()
        {
            return this.leDirecteur;
        }

        public void setDirecteur(Directeurs leDirecteur)
        {
            this.leDirecteur = leDirecteur;
        }

        public String toString()
        {
            String message = string.Empty;
            message += "ID région :" + this.id + "\n";
            message += "Nom de région :" + this.libelleRegion + "\n";
            return message;
        }

    }
}
