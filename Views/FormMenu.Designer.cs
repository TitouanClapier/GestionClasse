namespace GestionClasse.Views
{
    partial class FormMenu
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
            BtnClasse = new Button();
            BtnEleve = new Button();
            BtnProf = new Button();
            label1 = new Label();
            BtnMatiere = new Button();
            SuspendLayout();
            // 
            // BtnClasse
            // 
            BtnClasse.Location = new Point(180, 75);
            BtnClasse.Name = "BtnClasse";
            BtnClasse.Size = new Size(180, 55);
            BtnClasse.TabIndex = 0;
            BtnClasse.Text = "Gestion des classes";
            BtnClasse.UseVisualStyleBackColor = true;
            BtnClasse.Click += BtnClasse_Click;
            // 
            // BtnEleve
            // 
            BtnEleve.Location = new Point(761, 75);
            BtnEleve.Name = "BtnEleve";
            BtnEleve.Size = new Size(180, 55);
            BtnEleve.TabIndex = 1;
            BtnEleve.Text = "Gestion des éleves";
            BtnEleve.UseVisualStyleBackColor = true;
            BtnEleve.Click += BtnEleve_Click;
            // 
            // BtnProf
            // 
            BtnProf.Location = new Point(761, 174);
            BtnProf.Name = "BtnProf";
            BtnProf.Size = new Size(180, 57);
            BtnProf.TabIndex = 2;
            BtnProf.Text = "Gestion des professeurs";
            BtnProf.UseVisualStyleBackColor = true;
            BtnProf.Click += BtnProf_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(497, 36);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "GestionClasse";
            // 
            // BtnMatiere
            // 
            BtnMatiere.Location = new Point(180, 176);
            BtnMatiere.Name = "BtnMatiere";
            BtnMatiere.Size = new Size(180, 55);
            BtnMatiere.TabIndex = 4;
            BtnMatiere.Text = "Gestion des matieres";
            BtnMatiere.UseVisualStyleBackColor = true;
            BtnMatiere.Click += BtnMatiere_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 520);
            Controls.Add(BtnMatiere);
            Controls.Add(label1);
            Controls.Add(BtnProf);
            Controls.Add(BtnEleve);
            Controls.Add(BtnClasse);
            Name = "FormMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClasse;
        private Button BtnEleve;
        private Button BtnProf;
        private Label label1;
        private Button BtnMatiere;
    }
}