namespace GestionClasse.Views
{
    partial class FormListClasse
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
            DgvClasse = new DataGridView();
            BtnId = new DataGridViewTextBoxColumn();
            BtnLabel = new DataGridViewTextBoxColumn();
            ColProf = new DataGridViewTextBoxColumn();
            ColBtnEleve = new DataGridViewButtonColumn();
            BtnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvClasse).BeginInit();
            SuspendLayout();
            // 
            // DgvClasse
            // 
            DgvClasse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClasse.Columns.AddRange(new DataGridViewColumn[] { BtnId, BtnLabel, ColProf, ColBtnEleve });
            DgvClasse.Location = new Point(287, 101);
            DgvClasse.Name = "DgvClasse";
            DgvClasse.RowHeadersWidth = 51;
            DgvClasse.RowTemplate.Height = 29;
            DgvClasse.Size = new Size(599, 257);
            DgvClasse.TabIndex = 0;
            DgvClasse.CellContentClick += DgvClasse_CellContentClick;
            // 
            // BtnId
            // 
            BtnId.HeaderText = "IdClasse";
            BtnId.MinimumWidth = 6;
            BtnId.Name = "BtnId";
            BtnId.ReadOnly = true;
            BtnId.Width = 75;
            // 
            // BtnLabel
            // 
            BtnLabel.HeaderText = "Nom du niveau";
            BtnLabel.MinimumWidth = 6;
            BtnLabel.Name = "BtnLabel";
            BtnLabel.ReadOnly = true;
            BtnLabel.Width = 150;
            // 
            // ColProf
            // 
            ColProf.HeaderText = "Professeur principale";
            ColProf.MinimumWidth = 6;
            ColProf.Name = "ColProf";
            ColProf.ReadOnly = true;
            ColProf.Width = 175;
            // 
            // ColBtnEleve
            // 
            ColBtnEleve.HeaderText = "Liste des éleves";
            ColBtnEleve.MinimumWidth = 6;
            ColBtnEleve.Name = "ColBtnEleve";
            ColBtnEleve.Width = 125;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(544, 438);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 1;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // FormListClasse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 517);
            Controls.Add(BtnRetour);
            Controls.Add(DgvClasse);
            Name = "FormListClasse";
            Text = "FormListClasse";
            ((System.ComponentModel.ISupportInitialize)DgvClasse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvClasse;
        private DataGridViewTextBoxColumn BtnId;
        private DataGridViewTextBoxColumn BtnLabel;
        private DataGridViewTextBoxColumn ColProf;
        private DataGridViewButtonColumn ColBtnEleve;
        private Button BtnRetour;
    }
}