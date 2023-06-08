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
            BtnRetour = new Button();
            label1 = new Label();
            ColId = new DataGridViewTextBoxColumn();
            BtnLabel = new DataGridViewTextBoxColumn();
            ColProf = new DataGridViewTextBoxColumn();
            ColBtnEleve = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DgvClasse).BeginInit();
            SuspendLayout();
            // 
            // DgvClasse
            // 
            DgvClasse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClasse.Columns.AddRange(new DataGridViewColumn[] { ColId, BtnLabel, ColProf, ColBtnEleve });
            DgvClasse.Location = new Point(287, 101);
            DgvClasse.Name = "DgvClasse";
            DgvClasse.RowHeadersWidth = 51;
            DgvClasse.RowTemplate.Height = 29;
            DgvClasse.Size = new Size(599, 257);
            DgvClasse.TabIndex = 0;
            DgvClasse.CellContentClick += DgvClasse_CellContentClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(489, 38);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 3;
            label1.Text = "Liste des classes";
            // 
            // ColId
            // 
            ColId.HeaderText = "IdClasse";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 75;
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
            // FormListClasse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 517);
            Controls.Add(label1);
            Controls.Add(BtnRetour);
            Controls.Add(DgvClasse);
            Name = "FormListClasse";
            Text = "FormListClasse";
            ((System.ComponentModel.ISupportInitialize)DgvClasse).EndInit();
            Load += FormListClasse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvClasse;
        private Button BtnRetour;
        private Label label1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn BtnLabel;
        private DataGridViewTextBoxColumn ColProf;
        private DataGridViewButtonColumn ColBtnEleve;
    }
}