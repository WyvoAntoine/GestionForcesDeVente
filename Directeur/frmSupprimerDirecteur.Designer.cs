
namespace GestionForceDeVenteGSB
{
    partial class frmSupprimerDirecteur
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
            this.cbbSupprimerDirecteurs = new System.Windows.Forms.ComboBox();
            this.lblSupprimerDirecteur = new System.Windows.Forms.Label();
            this.btnSupprimerDirecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbSupprimerDirecteurs
            // 
            this.cbbSupprimerDirecteurs.FormattingEnabled = true;
            this.cbbSupprimerDirecteurs.Location = new System.Drawing.Point(366, 160);
            this.cbbSupprimerDirecteurs.Name = "cbbSupprimerDirecteurs";
            this.cbbSupprimerDirecteurs.Size = new System.Drawing.Size(182, 33);
            this.cbbSupprimerDirecteurs.TabIndex = 0;
            // 
            // lblSupprimerDirecteur
            // 
            this.lblSupprimerDirecteur.AutoSize = true;
            this.lblSupprimerDirecteur.Location = new System.Drawing.Point(232, 163);
            this.lblSupprimerDirecteur.Name = "lblSupprimerDirecteur";
            this.lblSupprimerDirecteur.Size = new System.Drawing.Size(100, 25);
            this.lblSupprimerDirecteur.TabIndex = 1;
            this.lblSupprimerDirecteur.Text = "Directeurs :";
            // 
            // btnSupprimerDirecteur
            // 
            this.btnSupprimerDirecteur.Location = new System.Drawing.Point(334, 253);
            this.btnSupprimerDirecteur.Name = "btnSupprimerDirecteur";
            this.btnSupprimerDirecteur.Size = new System.Drawing.Size(112, 34);
            this.btnSupprimerDirecteur.TabIndex = 2;
            this.btnSupprimerDirecteur.Text = "Supprimer ";
            this.btnSupprimerDirecteur.UseVisualStyleBackColor = true;
            this.btnSupprimerDirecteur.Click += new System.EventHandler(this.btnSupprimerDirecteur_Click);
            // 
            // frmSupprimerDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimerDirecteur);
            this.Controls.Add(this.lblSupprimerDirecteur);
            this.Controls.Add(this.cbbSupprimerDirecteurs);
            this.Name = "frmSupprimerDirecteur";
            this.Text = "frmSupprimerDirecteur";
            this.Load += new System.EventHandler(this.frmSupprimerDirecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSupprimerDirecteurs;
        private System.Windows.Forms.Label lblSupprimerDirecteur;
        private System.Windows.Forms.Button btnSupprimerDirecteur;
    }
}