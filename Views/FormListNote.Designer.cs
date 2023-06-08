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
            CbEleve = new ComboBox();
            TxtValeur = new TextBox();
            CbMatiere = new ComboBox();
            BtnAddNote = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            ColId = new DataGridViewTextBoxColumn();
            ColMatiere = new DataGridViewTextBoxColumn();
            ColValeur = new DataGridViewTextBoxColumn();
            ColBtnUpdate = new DataGridViewButtonColumn();
            ColBtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DgvNote).BeginInit();
            SuspendLayout();
            // 
            // DgvNote
            // 
            DgvNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNote.Columns.AddRange(new DataGridViewColumn[] { ColId, ColMatiere, ColValeur, ColBtnUpdate, ColBtnDelete });
            DgvNote.Location = new Point(351, 96);
            DgvNote.Name = "DgvNote";
            DgvNote.RowHeadersWidth = 51;
            DgvNote.RowTemplate.Height = 29;
            DgvNote.Size = new Size(499, 241);
            DgvNote.TabIndex = 0;
            DgvNote.CellContentClick += DgvNote_CellContentClick;
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
            TxtNom.Location = new Point(148, 110);
            TxtNom.Name = "TxtNom";
            TxtNom.ReadOnly = true;
            TxtNom.Size = new Size(172, 27);
            TxtNom.TabIndex = 5;
            // 
            // TxtPrenom
            // 
            TxtPrenom.Location = new Point(148, 169);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.ReadOnly = true;
            TxtPrenom.Size = new Size(172, 27);
            TxtPrenom.TabIndex = 6;
            // 
            // TxtSexe
            // 
            TxtSexe.Location = new Point(148, 224);
            TxtSexe.Name = "TxtSexe";
            TxtSexe.ReadOnly = true;
            TxtSexe.Size = new Size(172, 27);
            TxtSexe.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 110);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 8;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 172);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 224);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 10;
            label4.Text = "Sexe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 293);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Classe";
            // 
            // TxtClasse
            // 
            TxtClasse.Location = new Point(148, 290);
            TxtClasse.Name = "TxtClasse";
            TxtClasse.ReadOnly = true;
            TxtClasse.Size = new Size(172, 27);
            TxtClasse.TabIndex = 12;
            // 
            // CbEleve
            // 
            CbEleve.FormattingEnabled = true;
            CbEleve.Location = new Point(148, 50);
            CbEleve.Name = "CbEleve";
            CbEleve.Size = new Size(172, 28);
            CbEleve.TabIndex = 13;
            CbEleve.Visible = false;
            // 
            // TxtValeur
            // 
            TxtValeur.Location = new Point(1017, 178);
            TxtValeur.Name = "TxtValeur";
            TxtValeur.Size = new Size(151, 27);
            TxtValeur.TabIndex = 14;
            // 
            // CbMatiere
            // 
            CbMatiere.FormattingEnabled = true;
            CbMatiere.Location = new Point(1017, 130);
            CbMatiere.Name = "CbMatiere";
            CbMatiere.Size = new Size(151, 28);
            CbMatiere.TabIndex = 15;
            // 
            // BtnAddNote
            // 
            BtnAddNote.Location = new Point(1017, 237);
            BtnAddNote.Name = "BtnAddNote";
            BtnAddNote.Size = new Size(151, 29);
            BtnAddNote.TabIndex = 16;
            BtnAddNote.Text = "Ajouter une note";
            BtnAddNote.UseVisualStyleBackColor = true;
            BtnAddNote.Click += BtnAddNote_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(856, 133);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 17;
            label6.Text = "Choisir une matière";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(951, 181);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 18;
            label7.Text = "Note";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 53);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 19;
            label8.Text = "Choisir un éleve";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(951, 46);
            label9.Name = "label9";
            label9.Size = new Size(140, 28);
            label9.TabIndex = 20;
            label9.Text = "Ajout de notes";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 50;
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
            ColValeur.Width = 75;
            // 
            // ColBtnUpdate
            // 
            ColBtnUpdate.HeaderText = "Modifier";
            ColBtnUpdate.MinimumWidth = 6;
            ColBtnUpdate.Name = "ColBtnUpdate";
            // 
            // ColBtnDelete
            // 
            ColBtnDelete.HeaderText = "Supprimer";
            ColBtnDelete.MinimumWidth = 6;
            ColBtnDelete.Name = "ColBtnDelete";
            // 
            // FormListNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 513);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BtnAddNote);
            Controls.Add(CbMatiere);
            Controls.Add(TxtValeur);
            Controls.Add(CbEleve);
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
        private ComboBox CbEleve;
        private TextBox TxtValeur;
        private ComboBox CbMatiere;
        private Button BtnAddNote;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColMatiere;
        private DataGridViewTextBoxColumn ColValeur;
        private DataGridViewButtonColumn ColBtnUpdate;
        private DataGridViewButtonColumn ColBtnDelete;
    }
}