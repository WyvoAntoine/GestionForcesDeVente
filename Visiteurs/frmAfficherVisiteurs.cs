using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmAfficherVisiteurs : Form
    {
        public frmAfficherVisiteurs()
        {
            InitializeComponent();
        }

        private void frmAfficherVisiteurs_Load(object sender, EventArgs e)
        {
            BindingSource bsVisiteurs = new BindingSource();
            bsVisiteurs.DataSource = Passerelle.getLesVisiteurs();
            cbbAfficherListeV.DataSource = bsVisiteurs;
            cbbAfficherListeV.DisplayMember = "Nom";
        }

        private void cbbAfficherListeV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteurs unV = (Visiteurs)cbbAfficherListeV.SelectedItem;
            txtAfficherNomV.Text = unV.getNom();
            txtAfficherPrenomV.Text = unV.getPrenom();
            txtAfficherDirecteurV.Text = unV.getLeDirecteur().getNom();
            txtAfficherEvaluationV.Text = unV.getUneEvaluation().getLibelleEvaluation();
        }
    }
}
