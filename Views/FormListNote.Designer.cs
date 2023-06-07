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
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColMatiere = new DataGridViewTextBoxColumn();
            ColValeur = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColMatiere, ColValeur });
            dataGridView1.Location = new Point(384, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(439, 188);
            dataGridView1.TabIndex = 0;
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
            // FormListNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 513);
            Controls.Add(dataGridView1);
            Name = "FormListNote";
            Text = "FormListNote";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColMatiere;
        private DataGridViewTextBoxColumn ColValeur;
    }
}