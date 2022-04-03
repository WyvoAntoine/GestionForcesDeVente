
namespace GestionForceDeVenteGSB
{
    partial class frmAjouteEvaluationVisiteurs
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
            this.cbbVisiteurAjoutEvalV = new System.Windows.Forms.ComboBox();
            this.lblVisiteurAjoutEvalV = new System.Windows.Forms.Label();
            this.cbbEvaluationAjoutEvalV = new System.Windows.Forms.ComboBox();
            this.lblEvaluationAjoutEvalV = new System.Windows.Forms.Label();
            this.btnAjouterEvaluationV = new System.Windows.Forms.Button();
            this.lblNoteAjouterEvalV = new System.Windows.Forms.Label();
            this.txtNoteAjouterEvalV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbVisiteurAjoutEvalV
            // 
            this.cbbVisiteurAjoutEvalV.FormattingEnabled = true;
            this.cbbVisiteurAjoutEvalV.Location = new System.Drawing.Point(286, 102);
            this.cbbVisiteurAjoutEvalV.Name = "cbbVisiteurAjoutEvalV";
            this.cbbVisiteurAjoutEvalV.Size = new System.Drawing.Size(251, 33);
            this.cbbVisiteurAjoutEvalV.TabIndex = 17;
            this.cbbVisiteurAjoutEvalV.SelectedIndexChanged += new System.EventHandler(this.cbbVisiteurAjoutEvalV_SelectedIndexChanged);
            // 
            // lblVisiteurAjoutEvalV
            // 
            this.lblVisiteurAjoutEvalV.AutoSize = true;
            this.lblVisiteurAjoutEvalV.Location = new System.Drawing.Point(188, 105);
            this.lblVisiteurAjoutEvalV.Name = "lblVisiteurAjoutEvalV";
            this.lblVisiteurAjoutEvalV.Size = new System.Drawing.Size(79, 25);
            this.lblVisiteurAjoutEvalV.TabIndex = 16;
            this.lblVisiteurAjoutEvalV.Text = "Visiteur :";
            // 
            // cbbEvaluationAjoutEvalV
            // 
            this.cbbEvaluationAjoutEvalV.FormattingEnabled = true;
            this.cbbEvaluationAjoutEvalV.Location = new System.Drawing.Point(154, 217);
            this.cbbEvaluationAjoutEvalV.Name = "cbbEvaluationAjoutEvalV";
            this.cbbEvaluationAjoutEvalV.Size = new System.Drawing.Size(285, 33);
            this.cbbEvaluationAjoutEvalV.TabIndex = 33;
            this.cbbEvaluationAjoutEvalV.SelectedIndexChanged += new System.EventHandler(this.cbbEvaluationAjoutEvalV_SelectedIndexChanged);
            // 
            // lblEvaluationAjoutEvalV
            // 
            this.lblEvaluationAjoutEvalV.AutoSize = true;
            this.lblEvaluationAjoutEvalV.Location = new System.Drawing.Point(34, 220);
            this.lblEvaluationAjoutEvalV.Name = "lblEvaluationAjoutEvalV";
            this.lblEvaluationAjoutEvalV.Size = new System.Drawing.Size(102, 25);
            this.lblEvaluationAjoutEvalV.TabIndex = 32;
            this.lblEvaluationAjoutEvalV.Text = "Evaluation :";
            // 
            // btnAjouterEvaluationV
            // 
            this.btnAjouterEvaluationV.Location = new System.Drawing.Point(448, 347);
            this.btnAjouterEvaluationV.Name = "btnAjouterEvaluationV";
            this.btnAjouterEvaluationV.Size = new System.Drawing.Size(112, 34);
            this.btnAjouterEvaluationV.TabIndex = 34;
            this.btnAjouterEvaluationV.Text = "Ajouter";
            this.btnAjouterEvaluationV.UseVisualStyleBackColor = true;
            this.btnAjouterEvaluationV.Click += new System.EventHandler(this.btnAjouterEvaluationV_Click);
            // 
            // lblNoteAjouterEvalV
            // 
            this.lblNoteAjouterEvalV.AutoSize = true;
            this.lblNoteAjouterEvalV.Location = new System.Drawing.Point(516, 223);
            this.lblNoteAjouterEvalV.Name = "lblNoteAjouterEvalV";
            this.lblNoteAjouterEvalV.Size = new System.Drawing.Size(60, 25);
            this.lblNoteAjouterEvalV.TabIndex = 35;
            this.lblNoteAjouterEvalV.Text = "Note :";
            // 
            // txtNoteAjouterEvalV
            // 
            this.txtNoteAjouterEvalV.Location = new System.Drawing.Point(598, 220);
            this.txtNoteAjouterEvalV.Name = "txtNoteAjouterEvalV";
            this.txtNoteAjouterEvalV.Size = new System.Drawing.Size(95, 31);
            this.txtNoteAjouterEvalV.TabIndex = 36;
            // 
            // frmAjouteEvaluationVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNoteAjouterEvalV);
            this.Controls.Add(this.lblNoteAjouterEvalV);
            this.Controls.Add(this.btnAjouterEvaluationV);
            this.Controls.Add(this.cbbEvaluationAjoutEvalV);
            this.Controls.Add(this.lblEvaluationAjoutEvalV);
            this.Controls.Add(this.cbbVisiteurAjoutEvalV);
            this.Controls.Add(this.lblVisiteurAjoutEvalV);
            this.Name = "frmAjouteEvaluationVisiteurs";
            this.Text = "frmAjouteEvaluationVisiteurs";
            this.Load += new System.EventHandler(this.frmAjouteEvaluationVisiteurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbVisiteurAjoutEvalV;
        private System.Windows.Forms.Label lblVisiteurAjoutEvalV;
        private System.Windows.Forms.ComboBox cbbEvaluationAjoutEvalV;
        private System.Windows.Forms.Label lblEvaluationAjoutEvalV;
        private System.Windows.Forms.Button btnAjouterEvaluationV;
        private System.Windows.Forms.Label lblNoteAjouterEvalV;
        private System.Windows.Forms.TextBox txtNoteAjouterEvalV;
    }
}