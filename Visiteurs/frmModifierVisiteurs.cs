using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmModifierVisiteurs : Form
    {
        public frmModifierVisiteurs()
        {
            InitializeComponent();
        }
        
        private void frmModifierVisiteurs_Load(object sender, EventArgs e)
        {
            BindingSource bsVisiteurs = new BindingSource();
            bsVisiteurs.DataSource = Passerelle.getLesVisiteurs();
            cbbModifierListeV.DataSource = bsVisiteurs;
            cbbModifierListeV.DisplayMember = "Nom";

            BindingSource bsDirecteurs = new BindingSource();
            bsDirecteurs.DataSource = Passerelle.getLesDirecteurs();
            cbbModifierDirecteurV.DataSource = bsDirecteurs;
            cbbModifierDirecteurV.DisplayMember = "Nom";

        }

        private void cbbModifierListeV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteurs unV = (Visiteurs)cbbModifierListeV.SelectedItem;
            txtModifierNomV.Text = unV.getNom();
            txtModifierPrenomV.Text = unV.getPrenom();
            txtModifierNbEnfants.Text = unV.getNbEnfant().ToString();
            txtModifierSituationFamiliale.Text = unV.getSituationFamiliale();
            dtpModifierAnneeNaissV.Text = unV.getDateNaissance();
            dtpModifierEmbaucheV.Text = unV.getDateEmbauche();
            try
            {
                cbbModifierDirecteurV.Text = unV.getLeDirecteur().getNom();
            }
            catch
            {
                cbbModifierDirecteurV.Text = "Ce visiteur n'a pas de directeur";
            }
        }

        private void btnModifierVisiteur_Click(object sender, EventArgs e)
        {
            Visiteurs unV = (Visiteurs)cbbModifierListeV.SelectedItem;
            unV.setId(unV.getId());
            unV.setNom(txtModifierNomV.Text);
            unV.setPrenom(txtModifierPrenomV.Text);
            unV.setDateEmbauche(dtpModifierEmbaucheV.Text);
            unV.setDateNaissance(dtpModifierAnneeNaissV.Text);
            unV.setSituationFamiliale(txtModifierSituationFamiliale.Text);
            unV.setNbEnfant(int.Parse(txtModifierNbEnfants.Text));

            try
            {

                if (MessageBox.Show("Confirmez-vous votre action ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Visiteur modifié", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Passerelle.modifierDesVisiteurs(unV, txtModifierNomV.Text, txtModifierPrenomV.Text, dtpModifierAnneeNaissV.Value, (GestionForceDeVenteGSB.Directeurs)cbbModifierDirecteurV.SelectedItem, (GestionForceDeVenteGSB.Evaluation)cbbModifierEvaluationV.SelectedItem);
                    Passerelle.updateVisiteur(unV);
                }
                else
                {
                    MessageBox.Show("Visiteur n'a pas été modifié", "Action annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
