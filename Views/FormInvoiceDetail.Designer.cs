namespace AutoFact2.Views
{
    partial class FormInvoiceDetail
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.DgvInvoiceline = new System.Windows.Forms.DataGridView();
            this.ColIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnColUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelIdClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCompagnyName = new System.Windows.Forms.TextBox();
            this.BtnCreateInvoiceLine = new System.Windows.Forms.Button();
            this.CBCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoiceline)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(394, 471);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(96, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(627, 471);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(96, 24);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Enregistrer";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // DgvInvoiceline
            // 
            this.DgvInvoiceline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInvoiceline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdProduct,
            this.ColQuantity,
            this.ColPromotion,
            this.ColPrix,
            this.ColAmount,
            this.BtnColDelete,
            this.BtnColUpdate});
            this.DgvInvoiceline.Location = new System.Drawing.Point(12, 218);
            this.DgvInvoiceline.Name = "DgvInvoiceline";
            this.DgvInvoiceline.RowHeadersWidth = 51;
            this.DgvInvoiceline.RowTemplate.Height = 24;
            this.DgvInvoiceline.Size = new System.Drawing.Size(924, 171);
            this.DgvInvoiceline.TabIndex = 2;
            this.DgvInvoiceline.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoiceline_CellContentClick);
            // 
            // ColIdProduct
            // 
            this.ColIdProduct.HeaderText = "IdProduct";
            this.ColIdProduct.MinimumWidth = 6;
            this.ColIdProduct.Name = "ColIdProduct";
            this.ColIdProduct.Width = 75;
            // 
            // ColQuantity
            // 
            this.ColQuantity.HeaderText = "Quantity";
            this.ColQuantity.MinimumWidth = 6;
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.Width = 75;
            // 
            // ColPromotion
            // 
            this.ColPromotion.HeaderText = "Promotion";
            this.ColPromotion.MinimumWidth = 6;
            this.ColPromotion.Name = "ColPromotion";
            this.ColPromotion.Width = 75;
            // 
            // ColPrix
            // 
            this.ColPrix.HeaderText = "Prix";
            this.ColPrix.MinimumWidth = 6;
            this.ColPrix.Name = "ColPrix";
            this.ColPrix.Width = 75;
            // 
            // ColAmount
            // 
            this.ColAmount.HeaderText = "Montant";
            this.ColAmount.MinimumWidth = 6;
            this.ColAmount.Name = "ColAmount";
            this.ColAmount.Width = 75;
            // 
            // BtnColDelete
            // 
            this.BtnColDelete.HeaderText = "Supprimer";
            this.BtnColDelete.MinimumWidth = 6;
            this.BtnColDelete.Name = "BtnColDelete";
            this.BtnColDelete.Width = 125;
            // 
            // BtnColUpdate
            // 
            this.BtnColUpdate.HeaderText = "Modifier";
            this.BtnColUpdate.MinimumWidth = 6;
            this.BtnColUpdate.Name = "BtnColUpdate";
            this.BtnColUpdate.Width = 125;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(259, 72);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 3;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(118, 78);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(117, 16);
            this.LabelId.TabIndex = 5;
            this.LabelId.Text = "Numero de facture";
            // 
            // LabelIdClient
            // 
            this.LabelIdClient.AutoSize = true;
            this.LabelIdClient.Location = new System.Drawing.Point(184, 141);
            this.LabelIdClient.Name = "LabelIdClient";
            this.LabelIdClient.Size = new System.Drawing.Size(40, 16);
            this.LabelIdClient.TabIndex = 7;
            this.LabelIdClient.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(575, 72);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(100, 22);
            this.TxtDate.TabIndex = 9;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(882, 410);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Compagnie";
            // 
            // TxtCompagnyName
            // 
            this.TxtCompagnyName.Location = new System.Drawing.Point(575, 138);
            this.TxtCompagnyName.Name = "TxtCompagnyName";
            this.TxtCompagnyName.ReadOnly = true;
            this.TxtCompagnyName.Size = new System.Drawing.Size(100, 22);
            this.TxtCompagnyName.TabIndex = 17;
            // 
            // BtnCreateInvoiceLine
            // 
            this.BtnCreateInvoiceLine.Location = new System.Drawing.Point(996, 218);
            this.BtnCreateInvoiceLine.Name = "BtnCreateInvoiceLine";
            this.BtnCreateInvoiceLine.Size = new System.Drawing.Size(160, 65);
            this.BtnCreateInvoiceLine.TabIndex = 18;
            this.BtnCreateInvoiceLine.Text = "Ajouter Ligne de Facture";
            this.BtnCreateInvoiceLine.UseVisualStyleBackColor = true;
            this.BtnCreateInvoiceLine.Click += new System.EventHandler(this.BtnCreateInvoiceLine_Click);
            // 
            // CBCustomer
            // 
            this.CBCustomer.FormattingEnabled = true;
            this.CBCustomer.Location = new System.Drawing.Point(259, 138);
            this.CBCustomer.Name = "CBCustomer";
            this.CBCustomer.Size = new System.Drawing.Size(158, 24);
            this.CBCustomer.TabIndex = 19;
            this.CBCustomer.SelectedIndexChanged += new System.EventHandler(this.CBCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Détail Facture";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(796, 138);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 42;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(996, 137);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.ReadOnly = true;
            this.TxtSurname.Size = new System.Drawing.Size(100, 22);
            this.TxtSurname.TabIndex = 43;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(732, 140);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(54, 16);
            this.Prenom.TabIndex = 44;
            this.Prenom.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nom";
            // 
            // FormInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBCustomer);
            this.Controls.Add(this.BtnCreateInvoiceLine);
            this.Controls.Add(this.TxtCompagnyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelIdClient);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DgvInvoiceline);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBack);
            this.Name = "FormInvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoiceline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView DgvInvoiceline;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelIdClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCompagnyName;
        private System.Windows.Forms.Button BtnCreateInvoiceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPromotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewButtonColumn BtnColDelete;
        private System.Windows.Forms.DataGridViewButtonColumn BtnColUpdate;
        private System.Windows.Forms.ComboBox CBCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label label3;
    }
}