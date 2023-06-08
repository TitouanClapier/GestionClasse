namespace GestionClasse.Views
{
    partial class FormListProf
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
            DgvProf = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColPrenom = new DataGridViewTextBoxColumn();
            ColNom = new DataGridViewTextBoxColumn();
            ColSexe = new DataGridViewTextBoxColumn();
            ColMatiere = new DataGridViewTextBoxColumn();
            BtnRetour = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvProf).BeginInit();
            SuspendLayout();
            // 
            // DgvProf
            // 
            DgvProf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProf.Columns.AddRange(new DataGridViewColumn[] { ColId, ColPrenom, ColNom, ColSexe, ColMatiere });
            DgvProf.Location = new Point(228, 140);
            DgvProf.Name = "DgvProf";
            DgvProf.RowHeadersWidth = 51;
            DgvProf.RowTemplate.Height = 29;
            DgvProf.Size = new Size(658, 188);
            DgvProf.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
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
            // ColMatiere
            // 
            ColMatiere.HeaderText = "Matiere";
            ColMatiere.MinimumWidth = 6;
            ColMatiere.Name = "ColMatiere";
            ColMatiere.ReadOnly = true;
            ColMatiere.Width = 125;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(499, 395);
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
            label1.Location = new Point(453, 53);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 2;
            label1.Text = "Liste des professeurs";
            // 
            // FormListProf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 510);
            Controls.Add(label1);
            Controls.Add(BtnRetour);
            Controls.Add(DgvProf);
            Name = "FormListProf";
            Text = "FormListProf";
            Load += FormListProf_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProf;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColPrenom;
        private DataGridViewTextBoxColumn ColNom;
        private DataGridViewTextBoxColumn ColSexe;
        private DataGridViewTextBoxColumn ColMatiere;
        private Button BtnRetour;
        private Label label1;
    }
}