using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmAfficherDirecteur : Form
    {
        public frmAfficherDirecteur()
        {
            InitializeComponent();
        }

        private void frmAfficherDirecteur_Load(object sender, EventArgs e)
        {
            BindingSource bsDirecteurs = new BindingSource();
            bsDirecteurs.DataSource = Passerelle.getLesDirecteurs();
            cbbAfficheDirecteur.DataSource = bsDirecteurs;
            cbbAfficheDirecteur.DisplayMember = "Nom";
        }

        private void cbbAfficheDirecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Directeurs unD = (Directeurs)cbbAfficheDirecteur.SelectedItem;
            txtAfficheNomD.Text = unD.getNom();
            txtAffichePrenomD.Text = unD.getPrenom();
            txtAfficherAgeD.Text = unD.getAge().ToString();
            //txtAfficheRegionD.Text = unD.getRegion().getLibelleRegion();
        }
    }
}
