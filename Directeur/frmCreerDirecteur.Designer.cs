
namespace GestionForceDeVenteGSB
{
    partial class frmCreerDirecteur
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
            this.lblNomDirecteur = new System.Windows.Forms.Label();
            this.txtNomDirecteur = new System.Windows.Forms.TextBox();
            this.lblPrenomDirecteur = new System.Windows.Forms.Label();
            this.txtPrenomDirecteur = new System.Windows.Forms.TextBox();
            this.lblRegionDirecteur = new System.Windows.Forms.Label();
            this.cbbRegionDirecteur = new System.Windows.Forms.ComboBox();
            this.btnCréerDirecteur = new System.Windows.Forms.Button();
            this.lblAgeDirecteur = new System.Windows.Forms.Label();
            this.txtAgeDirecteur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomDirecteur
            // 
            this.lblNomDirecteur.AutoSize = true;
            this.lblNomDirecteur.Location = new System.Drawing.Point(94, 69);
            this.lblNomDirecteur.Name = "lblNomDirecteur";
            this.lblNomDirecteur.Size = new System.Drawing.Size(61, 25);
            this.lblNomDirecteur.TabIndex = 0;
            this.lblNomDirecteur.Text = "Nom :";
            // 
            // txtNomDirecteur
            // 
            this.txtNomDirecteur.Location = new System.Drawing.Point(181, 66);
            this.txtNomDirecteur.Name = "txtNomDirecteur";
            this.txtNomDirecteur.Size = new System.Drawing.Size(150, 31);
            this.txtNomDirecteur.TabIndex = 1;
            // 
            // lblPrenomDirecteur
            // 
            this.lblPrenomDirecteur.AutoSize = true;
            this.lblPrenomDirecteur.Location = new System.Drawing.Point(94, 131);
            this.lblPrenomDirecteur.Name = "lblPrenomDirecteur";
            this.lblPrenomDirecteur.Size = new System.Drawing.Size(76, 25);
            this.lblPrenomDirecteur.TabIndex = 2;
            this.lblPrenomDirecteur.Text = "Pénom :";
            // 
            // txtPrenomDirecteur
            // 
            this.txtPrenomDirecteur.Location = new System.Drawing.Point(181, 128);
            this.txtPrenomDirecteur.Name = "txtPrenomDirecteur";
            this.txtPrenomDirecteur.Size = new System.Drawing.Size(150, 31);
            this.txtPrenomDirecteur.TabIndex = 3;
            // 
            // lblRegionDirecteur
            // 
            this.lblRegionDirecteur.AutoSize = true;
            this.lblRegionDirecteur.Location = new System.Drawing.Point(94, 258);
            this.lblRegionDirecteur.Name = "lblRegionDirecteur";
            this.lblRegionDirecteur.Size = new System.Drawing.Size(76, 25);
            this.lblRegionDirecteur.TabIndex = 4;
            this.lblRegionDirecteur.Text = "Région :";
            // 
            // cbbRegionDirecteur
            // 
            this.cbbRegionDirecteur.FormattingEnabled = true;
            this.cbbRegionDirecteur.Location = new System.Drawing.Point(181, 255);
            this.cbbRegionDirecteur.Name = "cbbRegionDirecteur";
            this.cbbRegionDirecteur.Size = new System.Drawing.Size(251, 33);
            this.cbbRegionDirecteur.TabIndex = 5;
            // 
            // btnCréerDirecteur
            // 
            this.btnCréerDirecteur.Location = new System.Drawing.Point(381, 353);
            this.btnCréerDirecteur.Name = "btnCréerDirecteur";
            this.btnCréerDirecteur.Size = new System.Drawing.Size(112, 34);
            this.btnCréerDirecteur.TabIndex = 6;
            this.btnCréerDirecteur.Text = "Créer";
            this.btnCréerDirecteur.UseVisualStyleBackColor = true;
            this.btnCréerDirecteur.Click += new System.EventHandler(this.btnCréerDirecteur_Click);
            // 
            // lblAgeDirecteur
            // 
            this.lblAgeDirecteur.AutoSize = true;
            this.lblAgeDirecteur.Location = new System.Drawing.Point(94, 197);
            this.lblAgeDirecteur.Name = "lblAgeDirecteur";
            this.lblAgeDirecteur.Size = new System.Drawing.Size(53, 25);
            this.lblAgeDirecteur.TabIndex = 7;
            this.lblAgeDirecteur.Text = "Age :";
            // 
            // txtAgeDirecteur
            // 
            this.txtAgeDirecteur.Location = new System.Drawing.Point(181, 191);
            this.txtAgeDirecteur.Name = "txtAgeDirecteur";
            this.txtAgeDirecteur.Size = new System.Drawing.Size(150, 31);
            this.txtAgeDirecteur.TabIndex = 8;
            // 
            // frmCreerDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAgeDirecteur);
            this.Controls.Add(this.lblAgeDirecteur);
            this.Controls.Add(this.cbbRegionDirecteur);
            this.Controls.Add(this.btnCréerDirecteur);
            this.Controls.Add(this.lblNomDirecteur);
            this.Controls.Add(this.lblPrenomDirecteur);
            this.Controls.Add(this.txtPrenomDirecteur);
            this.Controls.Add(this.txtNomDirecteur);
            this.Controls.Add(this.lblRegionDirecteur);
            this.Name = "frmCreerDirecteur";
            this.Text = "Créer le directeur";
            this.Load += new System.EventHandler(this.frmDirecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomDirecteur;
        private System.Windows.Forms.TextBox txtNomDirecteur;
        private System.Windows.Forms.Label lblPrenomDirecteur;
        private System.Windows.Forms.TextBox txtPrenomDirecteur;
        private System.Windows.Forms.Label lblRegionDirecteur;
        private System.Windows.Forms.ComboBox cbbRegionDirecteur;
        private System.Windows.Forms.Button btnCréerDirecteur;
        private System.Windows.Forms.Label lblAgeDirecteur;
        private System.Windows.Forms.TextBox txtAgeDirecteur;
    }
}