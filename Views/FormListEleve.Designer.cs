namespace GestionClasse.Views
{
    partial class FormListEleve
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
            DgvEleve = new DataGridView();
            BtnRetour = new Button();
            label1 = new Label();
            ColId = new DataGridViewTextBoxColumn();
            ColPrenom = new DataGridViewTextBoxColumn();
            ColNom = new DataGridViewTextBoxColumn();
            ColSexe = new DataGridViewTextBoxColumn();
            ColClasse = new DataGridViewTextBoxColumn();
            ColBtnNote = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DgvEleve).BeginInit();
            SuspendLayout();
            // 
            // DgvEleve
            // 
            DgvEleve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEleve.Columns.AddRange(new DataGridViewColumn[] { ColId, ColPrenom, ColNom, ColSexe, ColClasse, ColBtnNote });
            DgvEleve.Location = new Point(164, 130);
            DgvEleve.Name = "DgvEleve";
            DgvEleve.RowHeadersWidth = 51;
            DgvEleve.RowTemplate.Height = 29;
            DgvEleve.Size = new Size(794, 188);
            DgvEleve.TabIndex = 0;
            DgvEleve.CellContentClick += DgvEleve_CellContentClick;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(510, 399);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 1;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(484, 49);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 3;
            label1.Text = "Liste des éleves";
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 75;
            // 
            // ColPrenom
            // 
            ColPrenom.HeaderText = "Prenom";
            ColPrenom.MinimumWidth = 6;
            ColPrenom.Name = "ColPrenom";
            ColPrenom.ReadOnly = true;
            ColPrenom.Width = 125;
            // 
            // ColNom
            // 
            ColNom.HeaderText = "Nom";
            ColNom.MinimumWidth = 6;
            ColNom.Name = "ColNom";
            ColNom.ReadOnly = true;
            ColNom.Width = 125;
            // 
            // ColSexe
            // 
            ColSexe.HeaderText = "Sexe";
            ColSexe.MinimumWidth = 6;
            ColSexe.Name = "ColSexe";
            ColSexe.ReadOnly = true;
            ColSexe.Width = 125;
            // 
            // ColClasse
            // 
            ColClasse.HeaderText = "Classe";
            ColClasse.MinimumWidth = 6;
            ColClasse.Name = "ColClasse";
            ColClasse.ReadOnly = true;
            ColClasse.Width = 125;
            // 
            // ColBtnNote
            // 
            ColBtnNote.HeaderText = "Notes";
            ColBtnNote.MinimumWidth = 6;
            ColBtnNote.Name = "ColBtnNote";
            ColBtnNote.ReadOnly = true;
            ColBtnNote.Width = 125;
            // 
            // FormListEleve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 517);
            Controls.Add(label1);
            Controls.Add(BtnRetour);
            Controls.Add(DgvEleve);
            Name = "FormListEleve";
            Text = "FormListEleve";
            Load += FormListEleve_Load;
            ((System.ComponentModel.ISupportInitialize)DgvEleve).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvEleve;
        private Button BtnRetour;
        private Label label1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColPrenom;
        private DataGridViewTextBoxColumn ColNom;
        private DataGridViewTextBoxColumn ColSexe;
        private DataGridViewTextBoxColumn ColClasse;
        private DataGridViewButtonColumn ColBtnNote;
    }
}