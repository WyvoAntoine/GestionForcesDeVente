using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmCreerDirecteur : Form
    {
        public frmCreerDirecteur()
        {
            InitializeComponent();
        }

        
        private void frmDirecteur_Load(object sender, EventArgs e)
        {
            cbbRegionDirecteur.Items.Add("Paris-Centre");
            cbbRegionDirecteur.Items.Add("Nord");
            cbbRegionDirecteur.Items.Add("Sud");
            cbbRegionDirecteur.Items.Add("Est");
            cbbRegionDirecteur.Items.Add("Ouest");
            cbbRegionDirecteur.Items.Add("DTOM Caraïbes-Ameriques");
            cbbRegionDirecteur.Items.Add("DTOM Asie-Afrique");
        }

        private void btnCréerDirecteur_Click(object sender, EventArgs e)
        {
            String nom = txtNomDirecteur.Text;
            String prenom = txtPrenomDirecteur.Text;
            int age = int.Parse(txtAgeDirecteur.Text);
            String region = cbbRegionDirecteur.SelectedItem.ToString();
            Region uneRegion = new Region(region);
            Directeurs unDirecteur = new Directeurs(nom, prenom, age, uneRegion);
        }
    }
}
