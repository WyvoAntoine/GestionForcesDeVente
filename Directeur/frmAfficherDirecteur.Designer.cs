
namespace GestionForceDeVenteGSB
{
    partial class frmAfficherDirecteur
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
            this.txtAffichePrenomD = new System.Windows.Forms.TextBox();
            this.txtAfficheNomD = new System.Windows.Forms.TextBox();
            this.lblAfficheAgeD = new System.Windows.Forms.Label();
            this.lblAfficheRegionD = new System.Windows.Forms.Label();
            this.lblAffichePrenomD = new System.Windows.Forms.Label();
            this.lblAfficheNomD = new System.Windows.Forms.Label();
            this.lblAfficheDirecteur = new System.Windows.Forms.Label();
            this.cbbAfficheDirecteur = new System.Windows.Forms.ComboBox();
            this.txtAfficheRegionD = new System.Windows.Forms.TextBox();
            this.txtAfficherAgeD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAffichePrenomD
            // 
            this.txtAffichePrenomD.Enabled = false;
            this.txtAffichePrenomD.Location = new System.Drawing.Point(157, 188);
            this.txtAffichePrenomD.Name = "txtAffichePrenomD";
            this.txtAffichePrenomD.Size = new System.Drawing.Size(196, 31);
            this.txtAffichePrenomD.TabIndex = 18;
            // 
            // txtAfficheNomD
            // 
            this.txtAfficheNomD.Enabled = false;
            this.txtAfficheNomD.Location = new System.Drawing.Point(121, 126);
            this.txtAfficheNomD.Name = "txtAfficheNomD";
            this.txtAfficheNomD.Size = new System.Drawing.Size(196, 31);
            this.txtAfficheNomD.TabIndex = 17;
            // 
            // lblAfficheAgeD
            // 
            this.lblAfficheAgeD.AutoSize = true;
            this.lblAfficheAgeD.Location = new System.Drawing.Point(54, 254);
            this.lblAfficheAgeD.Name = "lblAfficheAgeD";
            this.lblAfficheAgeD.Size = new System.Drawing.Size(53, 25);
            this.lblAfficheAgeD.TabIndex = 15;
            this.lblAfficheAgeD.Text = "Age :";
            // 
            // lblAfficheRegionD
            // 
            this.lblAfficheRegionD.AutoSize = true;
            this.lblAfficheRegionD.Location = new System.Drawing.Point(54, 312);
            this.lblAfficheRegionD.Name = "lblAfficheRegionD";
            this.lblAfficheRegionD.Size = new System.Drawing.Size(76, 25);
            this.lblAfficheRegionD.TabIndex = 14;
            this.lblAfficheRegionD.Text = "Région :";
            // 
            // lblAffichePrenomD
            // 
            this.lblAffichePrenomD.AutoSize = true;
            this.lblAffichePrenomD.Location = new System.Drawing.Point(54, 194);
            this.lblAffichePrenomD.Name = "lblAffichePrenomD";
            this.lblAffichePrenomD.Size = new System.Drawing.Size(83, 25);
            this.lblAffichePrenomD.TabIndex = 13;
            this.lblAffichePrenomD.Text = "Prénom :";
            // 
            // lblAfficheNomD
            // 
            this.lblAfficheNomD.AutoSize = true;
            this.lblAfficheNomD.Location = new System.Drawing.Point(54, 132);
            this.lblAfficheNomD.Name = "lblAfficheNomD";
            this.lblAfficheNomD.Size = new System.Drawing.Size(61, 25);
            this.lblAfficheNomD.TabIndex = 12;
            this.lblAfficheNomD.Text = "Nom :";
            // 
            // lblAfficheDirecteur
            // 
            this.lblAfficheDirecteur.AutoSize = true;
            this.lblAfficheDirecteur.Location = new System.Drawing.Point(241, 46);
            this.lblAfficheDirecteur.Name = "lblAfficheDirecteur";
            this.lblAfficheDirecteur.Size = new System.Drawing.Size(92, 25);
            this.lblAfficheDirecteur.TabIndex = 11;
            this.lblAfficheDirecteur.Text = "Directeur :";
            // 
            // cbbAfficheDirecteur
            // 
            this.cbbAfficheDirecteur.FormattingEnabled = true;
            this.cbbAfficheDirecteur.Location = new System.Drawing.Point(348, 43);
            this.cbbAfficheDirecteur.Name = "cbbAfficheDirecteur";
            this.cbbAfficheDirecteur.Size = new System.Drawing.Size(182, 33);
            this.cbbAfficheDirecteur.TabIndex = 10;
            this.cbbAfficheDirecteur.SelectedIndexChanged += new System.EventHandler(this.cbbAfficheDirecteur_SelectedIndexChanged);
            // 
            // txtAfficheRegionD
            // 
            this.txtAfficheRegionD.Enabled = false;
            this.txtAfficheRegionD.Location = new System.Drawing.Point(167, 312);
            this.txtAfficheRegionD.Name = "txtAfficheRegionD";
            this.txtAfficheRegionD.Size = new System.Drawing.Size(230, 31);
            this.txtAfficheRegionD.TabIndex = 21;
            // 
            // txtAfficherAgeD
            // 
            this.txtAfficherAgeD.Enabled = false;
            this.txtAfficherAgeD.Location = new System.Drawing.Point(121, 251);
            this.txtAfficherAgeD.Name = "txtAfficherAgeD";
            this.txtAfficherAgeD.Size = new System.Drawing.Size(150, 31);
            this.txtAfficherAgeD.TabIndex = 22;
            // 
            // frmAfficherDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAfficherAgeD);
            this.Controls.Add(this.txtAfficheRegionD);
            this.Controls.Add(this.txtAffichePrenomD);
            this.Controls.Add(this.txtAfficheNomD);
            this.Controls.Add(this.lblAfficheAgeD);
            this.Controls.Add(this.lblAfficheRegionD);
            this.Controls.Add(this.lblAffichePrenomD);
            this.Controls.Add(this.lblAfficheNomD);
            this.Controls.Add(this.lblAfficheDirecteur);
            this.Controls.Add(this.cbbAfficheDirecteur);
            this.Name = "frmAfficherDirecteur";
            this.Text = "frmAfficherDirecteur";
            this.Load += new System.EventHandler(this.frmAfficherDirecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAffichePrenomD;
        private System.Windows.Forms.TextBox txtAfficheNomD;
        private System.Windows.Forms.Label lblAfficheAgeD;
        private System.Windows.Forms.Label lblAfficheRegionD;
        private System.Windows.Forms.Label lblAffichePrenomD;
        private System.Windows.Forms.Label lblAfficheNomD;
        private System.Windows.Forms.Label lblAfficheDirecteur;
        private System.Windows.Forms.ComboBox cbbAfficheDirecteur;
        private System.Windows.Forms.TextBox txtAfficheRegionD;
        private System.Windows.Forms.TextBox txtAfficherAgeD;
    }
}