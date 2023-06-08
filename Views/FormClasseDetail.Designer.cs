namespace GestionClasse.Views
{
    partial class FormClasseDetail
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
            TxtLabel = new TextBox();
            TxtProf = new TextBox();
            DgvEleve = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColPrenom = new DataGridViewTextBoxColumn();
            ColNom = new DataGridViewTextBoxColumn();
            ColSexe = new DataGridViewTextBoxColumn();
            BtnRetour = new Button();
            BtnAdd = new Button();
            CbEleve = new ComboBox();
            TxtPrenom = new TextBox();
            TxtNom = new TextBox();
            TxtSexe = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvEleve).BeginInit();
            SuspendLayout();
            // 
            // TxtLabel
            // 
            TxtLabel.Location = new Point(443, 25);
            TxtLabel.Name = "TxtLabel";
            TxtLabel.ReadOnly = true;
            TxtLabel.Size = new Size(125, 27);
            TxtLabel.TabIndex = 0;
            // 
            // TxtProf
            // 
            TxtProf.Location = new Point(186, 25);
            TxtProf.Name = "TxtProf";
            TxtProf.ReadOnly = true;
            TxtProf.Size = new Size(125, 27);
            TxtProf.TabIndex = 1;
            TxtProf.TextChanged += textBox2_TextChanged;
            // 
            // DgvEleve
            // 
            DgvEleve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEleve.Columns.AddRange(new DataGridViewColumn[] { ColId, ColPrenom, ColNom, ColSexe });
            DgvEleve.Location = new Point(94, 72);
            DgvEleve.Name = "DgvEleve";
            DgvEleve.RowHeadersWidth = 51;
            DgvEleve.RowTemplate.Height = 29;
            DgvEleve.Size = new Size(545, 339);
            DgvEleve.TabIndex = 2;
            // 
            // ColId
            // 
            ColId.HeaderText = "IdEleve";
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
            // BtnRetour
            // 
            BtnRetour.Location = new Point(545, 451);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 3;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(948, 338);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(181, 29);
            BtnAdd.TabIndex = 4;
            BtnAdd.Text = "Ajouter un nouvel éleve";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // CbEleve
            // 
            CbEleve.FormattingEnabled = true;
            CbEleve.Location = new Point(948, 98);
            CbEleve.Name = "CbEleve";
            CbEleve.Size = new Size(181, 28);
            CbEleve.TabIndex = 5;
            CbEleve.SelectedIndexChanged += CbEleve_SelectedIndexChanged;
            // 
            // TxtPrenom
            // 
            TxtPrenom.Location = new Point(948, 146);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.ReadOnly = true;
            TxtPrenom.Size = new Size(181, 27);
            TxtPrenom.TabIndex = 6;
            // 
            // TxtNom
            // 
            TxtNom.Location = new Point(948, 193);
            TxtNom.Name = "TxtNom";
            TxtNom.ReadOnly = true;
            TxtNom.Size = new Size(181, 27);
            TxtNom.TabIndex = 7;
            // 
            // TxtSexe
            // 
            TxtSexe.Location = new Point(948, 250);
            TxtSexe.Name = "TxtSexe";
            TxtSexe.ReadOnly = true;
            TxtSexe.Size = new Size(181, 27);
            TxtSexe.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(865, 147);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "Prenom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(863, 193);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 10;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(865, 253);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 11;
            label3.Text = "Sexe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 25);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 12;
            label4.Text = "Niveau :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 25);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 13;
            label5.Text = "Professeur principale :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(865, 101);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 14;
            label6.Text = "Choix :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(607, 21);
            label7.Name = "label7";
            label7.Size = new Size(173, 28);
            label7.TabIndex = 15;
            label7.Text = "Details de la classe";
            // 
            // FormClasseDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 513);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtSexe);
            Controls.Add(TxtNom);
            Controls.Add(TxtPrenom);
            Controls.Add(CbEleve);
            Controls.Add(BtnAdd);
            Controls.Add(BtnRetour);
            Controls.Add(DgvEleve);
            Controls.Add(TxtProf);
            Controls.Add(TxtLabel);
            Name = "FormClasseDetail";
            Text = "FormClassDetail";
            Load += FormClassDetail_Load;
            ((System.ComponentModel.ISupportInitialize)DgvEleve).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtLabel;
        private TextBox TxtProf;
        private DataGridView DgvEleve;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColPrenom;
        private DataGridViewTextBoxColumn ColNom;
        private DataGridViewTextBoxColumn ColSexe;
        private Button BtnRetour;
        private Button BtnAdd;
        private ComboBox CbEleve;
        private TextBox TxtPrenom;
        private TextBox TxtNom;
        private TextBox TxtSexe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
    }
}