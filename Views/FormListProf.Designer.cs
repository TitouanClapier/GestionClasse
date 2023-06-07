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
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColPrenom = new DataGridViewTextBoxColumn();
            ColNom = new DataGridViewTextBoxColumn();
            ColSexe = new DataGridViewTextBoxColumn();
            BtnRetour = new Button();
            ColMatiere = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColPrenom, ColNom, ColSexe, ColMatiere });
            dataGridView1.Location = new Point(228, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(658, 188);
            dataGridView1.TabIndex = 0;
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
            // ColMatiere
            // 
            ColMatiere.HeaderText = "Matiere";
            ColMatiere.MinimumWidth = 6;
            ColMatiere.Name = "ColMatiere";
            ColMatiere.ReadOnly = true;
            ColMatiere.Width = 125;
            // 
            // FormListProf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 510);
            Controls.Add(BtnRetour);
            Controls.Add(dataGridView1);
            Name = "FormListProf";
            Text = "FormListProf";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColPrenom;
        private DataGridViewTextBoxColumn ColNom;
        private DataGridViewTextBoxColumn ColSexe;
        private DataGridViewTextBoxColumn ColMatiere;
        private Button BtnRetour;
    }
}