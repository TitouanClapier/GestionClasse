namespace GestionClasse.Views
{
    partial class FormNoteUpdate
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
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            BtnUpdateNote = new Button();
            CbMatiere = new ComboBox();
            TxtValeur = new TextBox();
            BtnRetour = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(518, 63);
            label9.Name = "label9";
            label9.Size = new Size(140, 28);
            label9.TabIndex = 39;
            label9.Text = "Ajout de notes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 187);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 37;
            label7.Text = "Note";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 139);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 36;
            label6.Text = "Choisir une matière";
            // 
            // BtnUpdateNote
            // 
            BtnUpdateNote.Location = new Point(507, 260);
            BtnUpdateNote.Name = "BtnUpdateNote";
            BtnUpdateNote.Size = new Size(151, 29);
            BtnUpdateNote.TabIndex = 35;
            BtnUpdateNote.Text = "Modifier";
            BtnUpdateNote.UseVisualStyleBackColor = true;
            BtnUpdateNote.Click += BtnUpdateNote_Click;
            // 
            // CbMatiere
            // 
            CbMatiere.FormattingEnabled = true;
            CbMatiere.Location = new Point(508, 136);
            CbMatiere.Name = "CbMatiere";
            CbMatiere.Size = new Size(151, 28);
            CbMatiere.TabIndex = 34;
            CbMatiere.SelectedIndexChanged += CbMatiere_SelectedIndexChanged;
            // 
            // TxtValeur
            // 
            TxtValeur.Location = new Point(508, 184);
            TxtValeur.Name = "TxtValeur";
            TxtValeur.Size = new Size(151, 27);
            TxtValeur.TabIndex = 33;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(543, 429);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(94, 29);
            BtnRetour.TabIndex = 23;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // FormNoteUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 535);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BtnUpdateNote);
            Controls.Add(CbMatiere);
            Controls.Add(TxtValeur);
            Controls.Add(BtnRetour);
            Name = "FormNoteUpdate";
            Text = "FormNoteUpdate";
            Load += FormNoteUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label7;
        private Label label6;
        private Button BtnUpdateNote;
        private ComboBox CbMatiere;
        private TextBox TxtValeur;
        private Button BtnRetour;
    }
}