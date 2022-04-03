using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmSupprimerVisiteurs : Form
    {
        public frmSupprimerVisiteurs()
        {
            InitializeComponent();
        }

        private void frmSupprimerVisiteurs_Load(object sender, EventArgs e)
        {
            BindingSource bsVisiteurs = new BindingSource();
            bsVisiteurs.DataSource = Passerelle.getLesVisiteurs();
            cbbSupprimerVisiteurs.DataSource = bsVisiteurs;
            cbbSupprimerVisiteurs.DisplayMember = "Nom";
        }

        private void btnSupprimerVisiteur_Click(object sender, EventArgs e)
        {
            Visiteurs unV = (Visiteurs)cbbSupprimerVisiteurs.SelectedItem;
            try
            {

                if (MessageBox.Show("Confirmez-vous votre action ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Visiteur supprimé", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Passerelle.supprimerDesVisiteurs(unV);
                }
                else
                {
                    MessageBox.Show("Visiteur n'est pas supprimé", "Action annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void cbbSupprimerVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
