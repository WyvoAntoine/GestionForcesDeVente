using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace GestionForceDeVenteGSB
{
    public partial class frmModifierListeDirecteur : Form
    {
        public frmModifierListeDirecteur()
        {
            InitializeComponent();
        }

        private void frmModifierDirecteur_Load(object sender, EventArgs e)
        {
            BindingSource bsDirecteurs = new BindingSource();
            bsDirecteurs.DataSource = Passerelle.getLesDirecteurs();
            cbbModifierListeD.DataSource = bsDirecteurs;
            cbbModifierListeD.DisplayMember = "Nom";

            BindingSource bsRegion = new BindingSource();
            bsRegion.DataSource = Passerelle.getLesRegions();
            cbbModifierRegionD.DataSource = bsRegion;
            cbbModifierRegionD.DisplayMember = "LibelleRegion";
        }

        private void cbbModifierListeDirecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Directeurs unD = (Directeurs)cbbModifierListeD.SelectedItem;
            txtModifierNomD.Text = unD.getNom();
            txtModifierPrenomD.Text = unD.getPrenom();
            txtModifierGrade.Text = unD.getGrade().ToString();
            txtModifierNbEnfants.Text = unD.getNbEnfant().ToString();
            txtModifierSituationFamiliale.Text = unD.getSituationFamiliale();
            dtpModifierAnneeNaissD.Text = unD.getDateNaissance();
            dtpModifierEmbaucheD.Text = unD.getDateEmbauche();
            try
            {
                cbbModifierRegionD.Text = unD.getRegion().getLibelleRegion();
            }
            catch
            {
                cbbModifierRegionD.Text = "Ce directeur ne supervise aucune région.";
            }              
        }

        private void btnModifierDirecteur_Click(object sender, EventArgs e)
        {
            Directeurs unD = (Directeurs)cbbModifierListeD.SelectedItem;
            unD.setId(unD.getId());
            unD.setNom(txtModifierNomD.Text);
            unD.setPrenom(txtModifierPrenomD.Text);
            unD.setDateEmbauche(dtpModifierEmbaucheD.Text);
            unD.setDateNaissance(dtpModifierAnneeNaissD.Text);
            unD.setSituationFamiliale(txtModifierSituationFamiliale.Text);
            unD.setNbEnfant(int.Parse(txtModifierNbEnfants.Text));
            

            try
            {
                if (MessageBox.Show("Confirmez-vous votre action ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Passerelle.updateDirecteur(unD);
                    MessageBox.Show("Directeur modifié", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Directeur n'a pas été modifié", "Action annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }           
        }
    }
}
