
namespace GestionForceDeVenteGSB
{
    partial class frmCreerEvaluation
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
            this.lblCreerLibelleE = new System.Windows.Forms.Label();
            this.lblCreerNoteE = new System.Windows.Forms.Label();
            this.btnCreerEvaluation = new System.Windows.Forms.Button();
            this.txtCreerNoteE = new System.Windows.Forms.TextBox();
            this.txtCreerLibelleE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreerLibelleE
            // 
            this.lblCreerLibelleE.AutoSize = true;
            this.lblCreerLibelleE.Location = new System.Drawing.Point(137, 131);
            this.lblCreerLibelleE.Name = "lblCreerLibelleE";
            this.lblCreerLibelleE.Size = new System.Drawing.Size(189, 25);
            this.lblCreerLibelleE.TabIndex = 0;
            this.lblCreerLibelleE.Text = "Libelle de l\'évaluation :";
            // 
            // lblCreerNoteE
            // 
            this.lblCreerNoteE.AutoSize = true;
            this.lblCreerNoteE.Location = new System.Drawing.Point(137, 217);
            this.lblCreerNoteE.Name = "lblCreerNoteE";
            this.lblCreerNoteE.Size = new System.Drawing.Size(179, 25);
            this.lblCreerNoteE.TabIndex = 1;
            this.lblCreerNoteE.Text = "Note de l\'évaluation :";
            // 
            // btnCreerEvaluation
            // 
            this.btnCreerEvaluation.Location = new System.Drawing.Point(390, 322);
            this.btnCreerEvaluation.Name = "btnCreerEvaluation";
            this.btnCreerEvaluation.Size = new System.Drawing.Size(112, 34);
            this.btnCreerEvaluation.TabIndex = 2;
            this.btnCreerEvaluation.Text = "Créer";
            this.btnCreerEvaluation.UseVisualStyleBackColor = true;
            // 
            // txtCreerNoteE
            // 
            this.txtCreerNoteE.Location = new System.Drawing.Point(345, 211);
            this.txtCreerNoteE.Name = "txtCreerNoteE";
            this.txtCreerNoteE.Size = new System.Drawing.Size(81, 31);
            this.txtCreerNoteE.TabIndex = 3;
            // 
            // txtCreerLibelleE
            // 
            this.txtCreerLibelleE.Location = new System.Drawing.Point(345, 128);
            this.txtCreerLibelleE.Name = "txtCreerLibelleE";
            this.txtCreerLibelleE.Size = new System.Drawing.Size(266, 31);
            this.txtCreerLibelleE.TabIndex = 4;
            // 
            // frmCreerEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCreerLibelleE);
            this.Controls.Add(this.txtCreerNoteE);
            this.Controls.Add(this.btnCreerEvaluation);
            this.Controls.Add(this.lblCreerNoteE);
            this.Controls.Add(this.lblCreerLibelleE);
            this.Name = "frmCreerEvaluation";
            this.Text = "frmCreerEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreerLibelleE;
        private System.Windows.Forms.Label lblCreerNoteE;
        private System.Windows.Forms.Button btnCreerEvaluation;
        private System.Windows.Forms.TextBox txtCreerNoteE;
        private System.Windows.Forms.TextBox txtCreerLibelleE;
    }
}