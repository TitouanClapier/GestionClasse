namespace GestionClasse.Views
{
    partial class FormListMatiere
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
            DgvMatiere = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNom = new DataGridViewTextBoxColumn();
            ColProf = new DataGridViewTextBoxColumn();
            BtnRetour = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvMatiere).BeginInit();
            SuspendLayout();
            // 
            // DgvMatiere
            // 
            DgvMatiere.AllowUserToAddRows = false;
            DgvMatiere.AllowUserToDeleteRows = false;
            DgvMatiere.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMatiere.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNom, ColProf });
            DgvMatiere.Location = new Point(299, 115);
            DgvMatiere.Name = "DgvMatiere";
            DgvMatiere.RowHeadersWidth = 51;
            DgvMatiere.RowTemplate.Height = 29;
            DgvMatiere.Size = new Size(430, 188);
            DgvMatiere.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 125;
            // 
            // ColNom
            // 
            ColNom.HeaderText = "Nom";
            ColNom.MinimumWidth = 6;
            ColNom.Name = "ColNom";
            ColNom.ReadOnly = true;
            ColNom.Width = 125;
            // 
            // ColProf
            // 
            ColProf.HeaderText = "Professeur";
            ColProf.MinimumWidth = 6;
            ColProf.Name = "ColProf";
            ColProf.ReadOnly = true;
            ColProf.Width = 125;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(464, 355);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 2;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(427, 37);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 3;
            label1.Text = "Liste des matieres";
            // 
            // FormListMatiere
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 450);
            Controls.Add(label1);
            Controls.Add(BtnRetour);
            Controls.Add(DgvMatiere);
            Name = "FormListMatiere";
            Text = "FormMatiere";
            Load += FormListMatiere_Load;
            ((System.ComponentModel.ISupportInitialize)DgvMatiere).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvMatiere;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNom;
        private DataGridViewTextBoxColumn ColProf;
        private Button BtnRetour;
        private Label label1;
    }
}