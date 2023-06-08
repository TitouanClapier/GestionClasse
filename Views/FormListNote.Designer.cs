namespace GestionClasse.Views
{
    partial class FormListNote
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
            DgvNote = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColMatiere = new DataGridViewTextBoxColumn();
            ColValeur = new DataGridViewTextBoxColumn();
            label1 = new Label();
            BtnRetour = new Button();
            TxtNom = new TextBox();
            TxtPrenom = new TextBox();
            TxtSexe = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtClasse = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvNote).BeginInit();
            SuspendLayout();
            // 
            // DgvNote
            // 
            DgvNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNote.Columns.AddRange(new DataGridViewColumn[] { ColId, ColMatiere, ColValeur });
            DgvNote.Location = new Point(375, 130);
            DgvNote.Name = "DgvNote";
            DgvNote.RowHeadersWidth = 51;
            DgvNote.RowTemplate.Height = 29;
            DgvNote.Size = new Size(439, 188);
            DgvNote.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 125;
            // 
            // ColMatiere
            // 
            ColMatiere.HeaderText = "Matiere";
            ColMatiere.MinimumWidth = 6;
            ColMatiere.Name = "ColMatiere";
            ColMatiere.ReadOnly = true;
            ColMatiere.Width = 125;
            // 
            // ColValeur
            // 
            ColValeur.HeaderText = "Valeur";
            ColValeur.MinimumWidth = 6;
            ColValeur.Name = "ColValeur";
            ColValeur.ReadOnly = true;
            ColValeur.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(508, 46);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 3;
            label1.Text = "Liste des notes";
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(553, 376);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 4;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // TxtNom
            // 
            TxtNom.Location = new Point(149, 96);
            TxtNom.Name = "TxtNom";
            TxtNom.ReadOnly = true;
            TxtNom.Size = new Size(125, 27);
            TxtNom.TabIndex = 5;
            // 
            // TxtPrenom
            // 
            TxtPrenom.Location = new Point(149, 155);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.ReadOnly = true;
            TxtPrenom.Size = new Size(125, 27);
            TxtPrenom.TabIndex = 6;
            // 
            // TxtSexe
            // 
            TxtSexe.Location = new Point(149, 210);
            TxtSexe.Name = "TxtSexe";
            TxtSexe.ReadOnly = true;
            TxtSexe.Size = new Size(125, 27);
            TxtSexe.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 96);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 8;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 158);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 210);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 10;
            label4.Text = "Sexe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 279);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Classe";
            // 
            // TxtClasse
            // 
            TxtClasse.Location = new Point(149, 276);
            TxtClasse.Name = "TxtClasse";
            TxtClasse.ReadOnly = true;
            TxtClasse.Size = new Size(125, 27);
            TxtClasse.TabIndex = 12;
            // 
            // FormListNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 513);
            Controls.Add(TxtClasse);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtSexe);
            Controls.Add(TxtPrenom);
            Controls.Add(TxtNom);
            Controls.Add(BtnRetour);
            Controls.Add(label1);
            Controls.Add(DgvNote);
            Name = "FormListNote";
            Text = "FormListNote";
            Load += FormListNote_Load;
            ((System.ComponentModel.ISupportInitialize)DgvNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvNote;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColMatiere;
        private DataGridViewTextBoxColumn ColValeur;
        private Label label1;
        private Button BtnRetour;
        private TextBox TxtNom;
        private TextBox TxtPrenom;
        private TextBox TxtSexe;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtClasse;
    }
}