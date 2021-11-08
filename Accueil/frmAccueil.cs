using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionForceDeVenteGSB
{
    public partial class frmAccueil : Form
    {
        Form creerDirecteur = new frmCreerDirecteur();
        Form modifierDirecteur = new frmModifierDirecteur();
        


        public frmAccueil()
        {
            InitializeComponent();
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creerDirecteur.ShowDialog();
            this.Hide();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierDirecteur.ShowDialog();
            this.Hide();
        }

        private void lireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
