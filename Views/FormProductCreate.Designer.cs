namespace AutoFact2.Views
{
    partial class FormProductCreate
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
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.LabelLibelle = new System.Windows.Forms.Label();
            this.LabelPrix = new System.Windows.Forms.Label();
            this.LabelIdType = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtLabel
            // 
            this.TxtLabel.Location = new System.Drawing.Point(582, 125);
            this.TxtLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtLabel.Size = new System.Drawing.Size(132, 22);
            this.TxtLabel.TabIndex = 0;
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(582, 181);
            this.TxtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUnitPrice.Size = new System.Drawing.Size(132, 22);
            this.TxtUnitPrice.TabIndex = 1;
            // 
            // LabelLibelle
            // 
            this.LabelLibelle.AutoSize = true;
            this.LabelLibelle.Location = new System.Drawing.Point(463, 133);
            this.LabelLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLibelle.Name = "LabelLibelle";
            this.LabelLibelle.Size = new System.Drawing.Size(47, 16);
            this.LabelLibelle.TabIndex = 3;
            this.LabelLibelle.Text = "Libellé";
            // 
            // LabelPrix
            // 
            this.LabelPrix.AutoSize = true;
            this.LabelPrix.Location = new System.Drawing.Point(463, 188);
            this.LabelPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrix.Name = "LabelPrix";
            this.LabelPrix.Size = new System.Drawing.Size(75, 16);
            this.LabelPrix.TabIndex = 4;
            this.LabelPrix.Text = "Prix unitaire";
            // 
            // LabelIdType
            // 
            this.LabelIdType.AutoSize = true;
            this.LabelIdType.Location = new System.Drawing.Point(463, 252);
            this.LabelIdType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIdType.Name = "LabelIdType";
            this.LabelIdType.Size = new System.Drawing.Size(39, 16);
            this.LabelIdType.TabIndex = 5;
            this.LabelIdType.Text = "Type";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(640, 357);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(100, 28);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "Enregistrer";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(429, 357);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 28);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ComboCategory
            // 
            this.ComboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Items.AddRange(new object[] {
            "1. Service",
            "2. Produit"});
            this.ComboCategory.Location = new System.Drawing.Point(582, 248);
            this.ComboCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboCategory.Size = new System.Drawing.Size(160, 24);
            this.ComboCategory.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Creation de produit";
            // 
            // FormProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboCategory);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LabelIdType);
            this.Controls.Add(this.LabelPrix);
            this.Controls.Add(this.LabelLibelle);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.TxtLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProductCreate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLabel;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.Label LabelLibelle;
        private System.Windows.Forms.Label LabelPrix;
        private System.Windows.Forms.Label LabelIdType;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox ComboCategory;
        private System.Windows.Forms.Label label2;
    }
}