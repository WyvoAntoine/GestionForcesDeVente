
namespace GestionForceDeVenteGSB
{
    partial class frmSupprimerVisiteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbSupprimerVisiteurs = new System.Windows.Forms.ComboBox();
            this.lblSupprimerVisiteurs = new System.Windows.Forms.Label();
            this.btnSupprimerVisiteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbSupprimerVisiteurs
            // 
            this.cbbSupprimerVisiteurs.FormattingEnabled = true;
            this.cbbSupprimerVisiteurs.Location = new System.Drawing.Point(308, 147);
            this.cbbSupprimerVisiteurs.Name = "cbbSupprimerVisiteurs";
            this.cbbSupprimerVisiteurs.Size = new System.Drawing.Size(251, 33);
            this.cbbSupprimerVisiteurs.TabIndex = 19;
            this.cbbSupprimerVisiteurs.SelectedIndexChanged += new System.EventHandler(this.cbbSupprimerVisiteurs_SelectedIndexChanged);
            // 
            // lblSupprimerVisiteurs
            // 
            this.lblSupprimerVisiteurs.AutoSize = true;
            this.lblSupprimerVisiteurs.Location = new System.Drawing.Point(210, 150);
            this.lblSupprimerVisiteurs.Name = "lblSupprimerVisiteurs";
            this.lblSupprimerVisiteurs.Size = new System.Drawing.Size(79, 25);
            this.lblSupprimerVisiteurs.TabIndex = 18;
            this.lblSupprimerVisiteurs.Text = "Visiteur :";
            // 
            // btnSupprimerVisiteur
            // 
            this.btnSupprimerVisiteur.Location = new System.Drawing.Point(372, 271);
            this.btnSupprimerVisiteur.Name = "btnSupprimerVisiteur";
            this.btnSupprimerVisiteur.Size = new System.Drawing.Size(112, 34);
            this.btnSupprimerVisiteur.TabIndex = 20;
            this.btnSupprimerVisiteur.Text = "Supprimer";
            this.btnSupprimerVisiteur.UseVisualStyleBackColor = true;
            this.btnSupprimerVisiteur.Click += new System.EventHandler(this.btnSupprimerVisiteur_Click);
            // 
            // frmSupprimerVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimerVisiteur);
            this.Controls.Add(this.cbbSupprimerVisiteurs);
            this.Controls.Add(this.lblSupprimerVisiteurs);
            this.Name = "frmSupprimerVisiteurs";
            this.Text = "frmSupprimerVisiteurs";
            this.Load += new System.EventHandler(this.frmSupprimerVisiteurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSupprimerVisiteurs;
        private System.Windows.Forms.Label lblSupprimerVisiteurs;
        private System.Windows.Forms.Button btnSupprimerVisiteur;
    }
}