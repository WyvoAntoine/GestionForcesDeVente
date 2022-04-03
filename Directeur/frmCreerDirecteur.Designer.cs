
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
            this.lblCreerNomD = new System.Windows.Forms.Label();
            this.txtCreerNomD = new System.Windows.Forms.TextBox();
            this.lblCreerPrenomD = new System.Windows.Forms.Label();
            this.txtCreerPrenomD = new System.Windows.Forms.TextBox();
            this.lblCreerRegionD = new System.Windows.Forms.Label();
            this.cbbCreerRegionD = new System.Windows.Forms.ComboBox();
            this.btnCréerDirecteur = new System.Windows.Forms.Button();
            this.lblCreerAnneeNaissD = new System.Windows.Forms.Label();
            this.dtpCreerAnneeNaissD = new System.Windows.Forms.DateTimePicker();
            this.dtpCreerAnneeEmbauche = new System.Windows.Forms.DateTimePicker();
            this.lblCreerAnneeEmbauche = new System.Windows.Forms.Label();
            this.lblCreerGrade = new System.Windows.Forms.Label();
            this.lblCreerNbEnfants = new System.Windows.Forms.Label();
            this.txtCreerNbEnfants = new System.Windows.Forms.TextBox();
            this.lblCreerSituationFamiliale = new System.Windows.Forms.Label();
            this.txtCreerGrade = new System.Windows.Forms.TextBox();
            this.txtCreerSituationFamiliale = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreerNomD
            // 
            this.lblCreerNomD.AutoSize = true;
            this.lblCreerNomD.Location = new System.Drawing.Point(36, 55);
            this.lblCreerNomD.Name = "lblCreerNomD";
            this.lblCreerNomD.Size = new System.Drawing.Size(61, 25);
            this.lblCreerNomD.TabIndex = 0;
            this.lblCreerNomD.Text = "Nom :";
            // 
            // txtCreerNomD
            // 
            this.txtCreerNomD.Location = new System.Drawing.Point(123, 52);
            this.txtCreerNomD.Name = "txtCreerNomD";
            this.txtCreerNomD.Size = new System.Drawing.Size(150, 31);
            this.txtCreerNomD.TabIndex = 1;
            // 
            // lblCreerPrenomD
            // 
            this.lblCreerPrenomD.AutoSize = true;
            this.lblCreerPrenomD.Location = new System.Drawing.Point(36, 117);
            this.lblCreerPrenomD.Name = "lblCreerPrenomD";
            this.lblCreerPrenomD.Size = new System.Drawing.Size(76, 25);
            this.lblCreerPrenomD.TabIndex = 2;
            this.lblCreerPrenomD.Text = "Pénom :";
            // 
            // txtCreerPrenomD
            // 
            this.txtCreerPrenomD.Location = new System.Drawing.Point(123, 114);
            this.txtCreerPrenomD.Name = "txtCreerPrenomD";
            this.txtCreerPrenomD.Size = new System.Drawing.Size(150, 31);
            this.txtCreerPrenomD.TabIndex = 3;
            // 
            // lblCreerRegionD
            // 
            this.lblCreerRegionD.AutoSize = true;
            this.lblCreerRegionD.Location = new System.Drawing.Point(36, 244);
            this.lblCreerRegionD.Name = "lblCreerRegionD";
            this.lblCreerRegionD.Size = new System.Drawing.Size(76, 25);
            this.lblCreerRegionD.TabIndex = 4;
            this.lblCreerRegionD.Text = "Région :";
            // 
            // cbbCreerRegionD
            // 
            this.cbbCreerRegionD.FormattingEnabled = true;
            this.cbbCreerRegionD.Location = new System.Drawing.Point(123, 241);
            this.cbbCreerRegionD.MaxLength = 4;
            this.cbbCreerRegionD.Name = "cbbCreerRegionD";
            this.cbbCreerRegionD.Size = new System.Drawing.Size(251, 33);
            this.cbbCreerRegionD.TabIndex = 5;
            // 
            // btnCréerDirecteur
            // 
            this.btnCréerDirecteur.Location = new System.Drawing.Point(509, 370);
            this.btnCréerDirecteur.Name = "btnCréerDirecteur";
            this.btnCréerDirecteur.Size = new System.Drawing.Size(112, 34);
            this.btnCréerDirecteur.TabIndex = 6;
            this.btnCréerDirecteur.Text = "Créer";
            this.btnCréerDirecteur.UseVisualStyleBackColor = true;
            this.btnCréerDirecteur.Click += new System.EventHandler(this.btnCréerDirecteur_Click);
            // 
            // lblCreerAnneeNaissD
            // 
            this.lblCreerAnneeNaissD.AutoSize = true;
            this.lblCreerAnneeNaissD.Location = new System.Drawing.Point(36, 183);
            this.lblCreerAnneeNaissD.Name = "lblCreerAnneeNaissD";
            this.lblCreerAnneeNaissD.Size = new System.Drawing.Size(154, 25);
            this.lblCreerAnneeNaissD.TabIndex = 7;
            this.lblCreerAnneeNaissD.Text = "Année Naissance :";
            // 
            // dtpCreerAnneeNaissD
            // 
            this.dtpCreerAnneeNaissD.CustomFormat = "yyyy-MM-dd";
            this.dtpCreerAnneeNaissD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreerAnneeNaissD.Location = new System.Drawing.Point(209, 178);
            this.dtpCreerAnneeNaissD.Name = "dtpCreerAnneeNaissD";
            this.dtpCreerAnneeNaissD.Size = new System.Drawing.Size(165, 31);
            this.dtpCreerAnneeNaissD.TabIndex = 9;
            this.dtpCreerAnneeNaissD.Value = new System.DateTime(2022, 3, 23, 0, 0, 0, 0);
            // 
            // dtpCreerAnneeEmbauche
            // 
            this.dtpCreerAnneeEmbauche.CustomFormat = "yyyy-MM-dd";
            this.dtpCreerAnneeEmbauche.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreerAnneeEmbauche.Location = new System.Drawing.Point(776, 49);
            this.dtpCreerAnneeEmbauche.Name = "dtpCreerAnneeEmbauche";
            this.dtpCreerAnneeEmbauche.Size = new System.Drawing.Size(161, 31);
            this.dtpCreerAnneeEmbauche.TabIndex = 11;
            this.dtpCreerAnneeEmbauche.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblCreerAnneeEmbauche
            // 
            this.lblCreerAnneeEmbauche.AutoSize = true;
            this.lblCreerAnneeEmbauche.Location = new System.Drawing.Point(603, 54);
            this.lblCreerAnneeEmbauche.Name = "lblCreerAnneeEmbauche";
            this.lblCreerAnneeEmbauche.Size = new System.Drawing.Size(163, 25);
            this.lblCreerAnneeEmbauche.TabIndex = 10;
            this.lblCreerAnneeEmbauche.Text = "Année Embauche  :";
            // 
            // lblCreerGrade
            // 
            this.lblCreerGrade.AutoSize = true;
            this.lblCreerGrade.Location = new System.Drawing.Point(605, 115);
            this.lblCreerGrade.Name = "lblCreerGrade";
            this.lblCreerGrade.Size = new System.Drawing.Size(68, 25);
            this.lblCreerGrade.TabIndex = 12;
            this.lblCreerGrade.Text = "Grade :";
            // 
            // lblCreerNbEnfants
            // 
            this.lblCreerNbEnfants.AutoSize = true;
            this.lblCreerNbEnfants.Location = new System.Drawing.Point(606, 180);
            this.lblCreerNbEnfants.Name = "lblCreerNbEnfants";
            this.lblCreerNbEnfants.Size = new System.Drawing.Size(175, 25);
            this.lblCreerNbEnfants.TabIndex = 14;
            this.lblCreerNbEnfants.Text = "Nombre d\'enfant(s) :";
            // 
            // txtCreerNbEnfants
            // 
            this.txtCreerNbEnfants.Location = new System.Drawing.Point(787, 177);
            this.txtCreerNbEnfants.Name = "txtCreerNbEnfants";
            this.txtCreerNbEnfants.Size = new System.Drawing.Size(150, 31);
            this.txtCreerNbEnfants.TabIndex = 15;
            // 
            // lblCreerSituationFamiliale
            // 
            this.lblCreerSituationFamiliale.AutoSize = true;
            this.lblCreerSituationFamiliale.Location = new System.Drawing.Point(606, 241);
            this.lblCreerSituationFamiliale.Name = "lblCreerSituationFamiliale";
            this.lblCreerSituationFamiliale.Size = new System.Drawing.Size(161, 25);
            this.lblCreerSituationFamiliale.TabIndex = 16;
            this.lblCreerSituationFamiliale.Text = "Situation familiale :";
            // 
            // txtCreerGrade
            // 
            this.txtCreerGrade.Enabled = false;
            this.txtCreerGrade.Location = new System.Drawing.Point(691, 117);
            this.txtCreerGrade.Name = "txtCreerGrade";
            this.txtCreerGrade.Size = new System.Drawing.Size(150, 31);
            this.txtCreerGrade.TabIndex = 18;
            this.txtCreerGrade.Text = "2";
            // 
            // txtCreerSituationFamiliale
            // 
            this.txtCreerSituationFamiliale.Location = new System.Drawing.Point(773, 238);
            this.txtCreerSituationFamiliale.Name = "txtCreerSituationFamiliale";
            this.txtCreerSituationFamiliale.Size = new System.Drawing.Size(212, 31);
            this.txtCreerSituationFamiliale.TabIndex = 19;
            // 
            // frmCreerDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.txtCreerSituationFamiliale);
            this.Controls.Add(this.txtCreerGrade);
            this.Controls.Add(this.lblCreerSituationFamiliale);
            this.Controls.Add(this.lblCreerNbEnfants);
            this.Controls.Add(this.txtCreerNbEnfants);
            this.Controls.Add(this.lblCreerGrade);
            this.Controls.Add(this.dtpCreerAnneeEmbauche);
            this.Controls.Add(this.lblCreerAnneeEmbauche);
            this.Controls.Add(this.dtpCreerAnneeNaissD);
            this.Controls.Add(this.lblCreerAnneeNaissD);
            this.Controls.Add(this.cbbCreerRegionD);
            this.Controls.Add(this.btnCréerDirecteur);
            this.Controls.Add(this.lblCreerNomD);
            this.Controls.Add(this.lblCreerPrenomD);
            this.Controls.Add(this.txtCreerPrenomD);
            this.Controls.Add(this.txtCreerNomD);
            this.Controls.Add(this.lblCreerRegionD);
            this.Name = "frmCreerDirecteur";
            this.Text = "Créer le directeur";
            this.Load += new System.EventHandler(this.frmDirecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreerNomD;
        private System.Windows.Forms.TextBox txtCreerNomD;
        private System.Windows.Forms.Label lblCreerPrenomD;
        private System.Windows.Forms.TextBox txtCreerPrenomD;
        private System.Windows.Forms.Label lblCreerRegionD;
        private System.Windows.Forms.ComboBox cbbCreerRegionD;
        private System.Windows.Forms.Button btnCréerDirecteur;
        private System.Windows.Forms.Label lblCreerAnneeNaissD;
        private System.Windows.Forms.DateTimePicker dtpCreerAnneeNaissD;
        private System.Windows.Forms.DateTimePicker dtpCreerAnneeEmbauche;
        private System.Windows.Forms.Label lblCreerAnneeEmbauche;
        private System.Windows.Forms.Label lblCreerGrade;
        private System.Windows.Forms.Label lblCreerNbEnfants;
        private System.Windows.Forms.TextBox txtCreerNbEnfants;
        private System.Windows.Forms.Label lblCreerSituationFamiliale;
        private System.Windows.Forms.TextBox txtCreerGrade;
        private System.Windows.Forms.TextBox txtCreerSituationFamiliale;
    }
}