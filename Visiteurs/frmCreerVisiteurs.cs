using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tutorial.SqlConn;
using MySql.Data.MySqlClient;

namespace GestionForceDeVenteGSB
{
    public partial class frmCreerVisiteurs : Form
    {
        public frmCreerVisiteurs()
        {
            InitializeComponent();
        }        

        private void frmCreerVisiteurs_Load(object sender, EventArgs e)
        {
            BindingSource bsDirecteurs = new BindingSource();
            bsDirecteurs.DataSource = Passerelle.getLesDirecteurs();
            cbbCreerDirecteurV.DataSource = bsDirecteurs;
            cbbCreerDirecteurV.DisplayMember = "Nom";
            
        }

        private void btnCréerVisiteur_Click(object sender, EventArgs e)
        {
            Visiteurs unV = new Visiteurs(txtCreerNomV.Text, txtCreerPrenomV.Text, int.Parse(txtCreerNbEnfants.Text),
                txtCreerSituationFamiliale.Text, dtpCreerAnneeNaissV.Text,
                dtpCreerAnneeEmbauche.Text, (GestionForceDeVenteGSB.Directeurs)cbbCreerDirecteurV.SelectedItem, int.Parse(txtCreerGrade.Text));

            try
            {
                if (MessageBox.Show("Confirmez-vous votre action ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Visiteur créé", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Passerelle.createVisiteur(unV);
                }
                else
                {
                    MessageBox.Show("Visiteurs n'a pas été créé", "Action annulée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
