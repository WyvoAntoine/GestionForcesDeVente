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
            BindingSource bsRegion = new BindingSource();
            bsRegion.DataSource = Passerelle.getLesRegionSansDirecteur();
            cbbCreerRegionD.DataSource = bsRegion;
            cbbCreerRegionD.DisplayMember = "LibelleRegion";
        }

        private void btnCréerDirecteur_Click(object sender, EventArgs e)
        {
            Directeurs unD = new Directeurs(txtCreerNomD.Text, txtCreerPrenomD.Text, int.Parse(txtCreerNbEnfants.Text), 
                txtCreerSituationFamiliale.Text, dtpCreerAnneeNaissD.Text,
                dtpCreerAnneeEmbauche.Text, int.Parse(txtCreerGrade.Text), 
                (GestionForceDeVenteGSB.Region) cbbCreerRegionD.SelectedItem);
            try
            {
                if (MessageBox.Show("Confirmez-vous votre action ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Passerelle.createDirecteur(unD);
                    MessageBox.Show("Directeur créé", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Directeur n'a pas été créé", "Action annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
