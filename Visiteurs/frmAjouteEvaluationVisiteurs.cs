using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmAjouteEvaluationVisiteurs : Form
    {
        BindingSource bsEvaluations = new BindingSource();
        public frmAjouteEvaluationVisiteurs()
        {
            InitializeComponent();
        }

        private void frmAjouteEvaluationVisiteurs_Load(object sender, EventArgs e)
        {
           
            bsEvaluations.DataSource = Passerelle.getLesEvaluations();
            cbbEvaluationAjoutEvalV.DataSource = bsEvaluations;
            cbbEvaluationAjoutEvalV.DisplayMember = "LibelleEvaluation";

            BindingSource bsVisiteurs = new BindingSource();
            bsVisiteurs.DataSource = Passerelle.getLesVisiteurs();
            cbbVisiteurAjoutEvalV.DataSource = bsVisiteurs;
            cbbVisiteurAjoutEvalV.DisplayMember = "Nom";
        }

        private void btnAjouterEvaluationV_Click(object sender, EventArgs e)
        {
            Visiteurs unV = (Visiteurs)cbbVisiteurAjoutEvalV.SelectedItem;
            Evaluation uneEvaluation = (Evaluation)cbbEvaluationAjoutEvalV.SelectedItem;
            
            try
            {

                if (MessageBox.Show("Confirmez-vous votre action ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Ajout d'une évaluation à ce visiteur", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    unV.ajouterEvaluation(uneEvaluation);
                }
                else
                {
                    MessageBox.Show("L'évaluation n'a pas été ajoutée au visiteur", "Action annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void cbbEvaluationAjoutEvalV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteurs unV = (Visiteurs)cbbVisiteurAjoutEvalV.SelectedItem;
            txtNoteAjouterEvalV.Text = ((Evaluation)cbbEvaluationAjoutEvalV.SelectedItem).getNbPointEvaluation().ToString();
        }

        private void cbbVisiteurAjoutEvalV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
