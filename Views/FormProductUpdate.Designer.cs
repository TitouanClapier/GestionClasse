namespace AutoFact2.Views
{
    partial class FormProductUpdate
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
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LabelIdType = new System.Windows.Forms.Label();
            this.LabelPrix = new System.Windows.Forms.Label();
            this.LabelLibelle = new System.Windows.Forms.Label();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboCategory
            // 
            this.ComboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Items.AddRange(new object[] {
            "1. Service",
            "2. Produit"});
            this.ComboCategory.Location = new System.Drawing.Point(599, 310);
            this.ComboCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboCategory.Size = new System.Drawing.Size(160, 24);
            this.ComboCategory.TabIndex = 16;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(437, 414);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 28);
            this.BtnBack.TabIndex = 15;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(734, 414);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 28);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Enregistrer";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LabelIdType
            // 
            this.LabelIdType.AutoSize = true;
            this.LabelIdType.Location = new System.Drawing.Point(480, 314);
            this.LabelIdType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIdType.Name = "LabelIdType";
            this.LabelIdType.Size = new System.Drawing.Size(39, 16);
            this.LabelIdType.TabIndex = 13;
            this.LabelIdType.Text = "Type";
            // 
            // LabelPrix
            // 
            this.LabelPrix.AutoSize = true;
            this.LabelPrix.Location = new System.Drawing.Point(480, 250);
            this.LabelPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrix.Name = "LabelPrix";
            this.LabelPrix.Size = new System.Drawing.Size(75, 16);
            this.LabelPrix.TabIndex = 12;
            this.LabelPrix.Text = "Prix unitaire";
            // 
            // LabelLibelle
            // 
            this.LabelLibelle.AutoSize = true;
            this.LabelLibelle.Location = new System.Drawing.Point(480, 194);
            this.LabelLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLibelle.Name = "LabelLibelle";
            this.LabelLibelle.Size = new System.Drawing.Size(47, 16);
            this.LabelLibelle.TabIndex = 11;
            this.LabelLibelle.Text = "Libellé";
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(599, 242);
            this.TxtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUnitPrice.Size = new System.Drawing.Size(132, 22);
            this.TxtUnitPrice.TabIndex = 10;
            // 
            // TxtLabel
            // 
            this.TxtLabel.Location = new System.Drawing.Point(599, 187);
            this.TxtLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtLabel.Size = new System.Drawing.Size(132, 22);
            this.TxtLabel.TabIndex = 9;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(599, 134);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtId.Size = new System.Drawing.Size(132, 22);
            this.TxtId.TabIndex = 17;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(480, 138);
            this.LabelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(18, 16);
            this.LabelId.TabIndex = 18;
            this.LabelId.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modification d\'un produit";
            // 
            // FormProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.ComboCategory);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LabelIdType);
            this.Controls.Add(this.LabelPrix);
            this.Controls.Add(this.LabelLibelle);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.TxtLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProductUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboCategory;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LabelIdType;
        private System.Windows.Forms.Label LabelPrix;
        private System.Windows.Forms.Label LabelLibelle;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.TextBox TxtLabel;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label label1;
    }
}