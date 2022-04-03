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
        public frmAccueil()
        {
            InitializeComponent();
        }
        
        private void accueilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Owner.Show();
                this.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreerDirecteur uneF = new frmCreerDirecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }
        
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifierListeDirecteur uneF = new frmModifierListeDirecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void lireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAfficherDirecteur uneF = new frmAfficherDirecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupprimerDirecteur uneF = new frmSupprimerDirecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void créerToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmCreerVisiteurs uneF = new frmCreerVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void modifierToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmModifierVisiteurs uneF = new frmModifierVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void lireToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmAfficherVisiteurs uneF = new frmAfficherVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void supprimerToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmSupprimerVisiteurs uneF = new frmSupprimerVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void ajouterUneÉvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouteEvaluationVisiteurs uneF = new frmAjouteEvaluationVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }
    }
}
