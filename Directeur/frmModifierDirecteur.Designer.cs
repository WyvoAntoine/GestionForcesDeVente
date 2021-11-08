
namespace GestionForceDeVenteGSB
{
    partial class frmModifierDirecteur
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
            this.txtAgeDirecteur = new System.Windows.Forms.TextBox();
            this.lblAgeDirecteur = new System.Windows.Forms.Label();
            this.cbbRegionDirecteur = new System.Windows.Forms.ComboBox();
            this.btnCréerDirecteur = new System.Windows.Forms.Button();
            this.lblNomDirecteur = new System.Windows.Forms.Label();
            this.lblPrenomDirecteur = new System.Windows.Forms.Label();
            this.txtPrenomDirecteur = new System.Windows.Forms.TextBox();
            this.txtNomDirecteur = new System.Windows.Forms.TextBox();
            this.lblRegionDirecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAgeDirecteur
            // 
            this.txtAgeDirecteur.Location = new System.Drawing.Point(288, 190);
            this.txtAgeDirecteur.Name = "txtAgeDirecteur";
            this.txtAgeDirecteur.Size = new System.Drawing.Size(150, 31);
            this.txtAgeDirecteur.TabIndex = 17;
            // 
            // lblAgeDirecteur
            // 
            this.lblAgeDirecteur.AutoSize = true;
            this.lblAgeDirecteur.Location = new System.Drawing.Point(201, 196);
            this.lblAgeDirecteur.Name = "lblAgeDirecteur";
            this.lblAgeDirecteur.Size = new System.Drawing.Size(53, 25);
            this.lblAgeDirecteur.TabIndex = 16;
            this.lblAgeDirecteur.Text = "Age :";
            // 
            // cbbRegionDirecteur
            // 
            this.cbbRegionDirecteur.FormattingEnabled = true;
            this.cbbRegionDirecteur.Location = new System.Drawing.Point(288, 254);
            this.cbbRegionDirecteur.Name = "cbbRegionDirecteur";
            this.cbbRegionDirecteur.Size = new System.Drawing.Size(251, 33);
            this.cbbRegionDirecteur.TabIndex = 14;
            // 
            // btnCréerDirecteur
            // 
            this.btnCréerDirecteur.Location = new System.Drawing.Point(488, 352);
            this.btnCréerDirecteur.Name = "btnCréerDirecteur";
            this.btnCréerDirecteur.Size = new System.Drawing.Size(112, 34);
            this.btnCréerDirecteur.TabIndex = 15;
            this.btnCréerDirecteur.Text = "Modifier";
            this.btnCréerDirecteur.UseVisualStyleBackColor = true;
            // 
            // lblNomDirecteur
            // 
            this.lblNomDirecteur.AutoSize = true;
            this.lblNomDirecteur.Location = new System.Drawing.Point(201, 68);
            this.lblNomDirecteur.Name = "lblNomDirecteur";
            this.lblNomDirecteur.Size = new System.Drawing.Size(61, 25);
            this.lblNomDirecteur.TabIndex = 9;
            this.lblNomDirecteur.Text = "Nom :";
            // 
            // lblPrenomDirecteur
            // 
            this.lblPrenomDirecteur.AutoSize = true;
            this.lblPrenomDirecteur.Location = new System.Drawing.Point(201, 130);
            this.lblPrenomDirecteur.Name = "lblPrenomDirecteur";
            this.lblPrenomDirecteur.Size = new System.Drawing.Size(76, 25);
            this.lblPrenomDirecteur.TabIndex = 11;
            this.lblPrenomDirecteur.Text = "Pénom :";
            // 
            // txtPrenomDirecteur
            // 
            this.txtPrenomDirecteur.Location = new System.Drawing.Point(288, 127);
            this.txtPrenomDirecteur.Name = "txtPrenomDirecteur";
            this.txtPrenomDirecteur.Size = new System.Drawing.Size(150, 31);
            this.txtPrenomDirecteur.TabIndex = 12;
            // 
            // txtNomDirecteur
            // 
            this.txtNomDirecteur.Location = new System.Drawing.Point(288, 65);
            this.txtNomDirecteur.Name = "txtNomDirecteur";
            this.txtNomDirecteur.Size = new System.Drawing.Size(150, 31);
            this.txtNomDirecteur.TabIndex = 10;
            // 
            // lblRegionDirecteur
            // 
            this.lblRegionDirecteur.AutoSize = true;
            this.lblRegionDirecteur.Location = new System.Drawing.Point(201, 257);
            this.lblRegionDirecteur.Name = "lblRegionDirecteur";
            this.lblRegionDirecteur.Size = new System.Drawing.Size(76, 25);
            this.lblRegionDirecteur.TabIndex = 13;
            this.lblRegionDirecteur.Text = "Région :";
            // 
            // frmModifierDirecteur
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
            this.Name = "frmModifierDirecteur";
            this.Text = "Modifier le directeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgeDirecteur;
        private System.Windows.Forms.Label lblAgeDirecteur;
        private System.Windows.Forms.ComboBox cbbRegionDirecteur;
        private System.Windows.Forms.Button btnCréerDirecteur;
        private System.Windows.Forms.Label lblNomDirecteur;
        private System.Windows.Forms.Label lblPrenomDirecteur;
        private System.Windows.Forms.TextBox txtPrenomDirecteur;
        private System.Windows.Forms.TextBox txtNomDirecteur;
        private System.Windows.Forms.Label lblRegionDirecteur;
    }
}