using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmSupprimerDirecteur : Form
    {
        public frmSupprimerDirecteur()
        {
            InitializeComponent();
        }

        private void frmSupprimerDirecteur_Load(object sender, EventArgs e)
        {
            BindingSource bsDirecteurs = new BindingSource();
            bsDirecteurs.DataSource = Passerelle.getLesDirecteurs();
            cbbSupprimerDirecteurs.DataSource = bsDirecteurs;
            cbbSupprimerDirecteurs.DisplayMember = "nom";
        }

        private void btnSupprimerDirecteur_Click(object sender, EventArgs e)
        {
            Directeurs unD = (Directeurs)cbbSupprimerDirecteurs.SelectedItem;
            try
            {

                if (MessageBox.Show("Confirmez-vous votre action ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Directeur supprimé", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Passerelle.deleteDirecteur(unD);
                }
                else
                {
                    MessageBox.Show("Directeur n'est pas supprimé", "Action annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }        
}
