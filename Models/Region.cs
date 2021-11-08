using System;
using System.Collections.Generic;
using System.Text;

namespace GestionForceDeVenteGSB
{
    class Region
    {
        private String libelleRegion;
        

        public Region(String libelleRegion)
        {
            this.libelleRegion = libelleRegion;
        }

        
        public String getLibelleRegion()
        {
            return this.libelleRegion;
        }


        public void setLibelleRegion(String libelleRegion)
        {
            this.libelleRegion = libelleRegion;
        }

        
        public String toString()
        {
            String message = string.Empty;
            message += "Nom de région :" + libelleRegion + "/n";
            return message;
        }

    }
}
