namespace AutoFact2.Views
{
    partial class FormInvoiceCreate
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
            this.BtnCreateInvoice = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CBCustomer = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLibelProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreateInvoice
            // 
            this.BtnCreateInvoice.Location = new System.Drawing.Point(423, 569);
            this.BtnCreateInvoice.Name = "BtnCreateInvoice";
            this.BtnCreateInvoice.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateInvoice.TabIndex = 0;
            this.BtnCreateInvoice.Text = "Créer";
            this.BtnCreateInvoice.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(618, 568);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // CBCustomer
            // 
            this.CBCustomer.FormattingEnabled = true;
            this.CBCustomer.Location = new System.Drawing.Point(690, 163);
            this.CBCustomer.Name = "CBCustomer";
            this.CBCustomer.Size = new System.Drawing.Size(121, 24);
            this.CBCustomer.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdProduct,
            this.ColLibelProduct,
            this.ColQuantity,
            this.ColPrixUnitaire,
            this.ColAmount,
            this.ColDelete});
            this.dataGridView1.Location = new System.Drawing.Point(126, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColIdProduct
            // 
            this.ColIdProduct.HeaderText = "IdProduct";
            this.ColIdProduct.MinimumWidth = 6;
            this.ColIdProduct.Name = "ColIdProduct";
            this.ColIdProduct.ReadOnly = true;
            this.ColIdProduct.Width = 125;
            // 
            // ColLibelProduct
            // 
            this.ColLibelProduct.HeaderText = "LibelProduct";
            this.ColLibelProduct.MinimumWidth = 6;
            this.ColLibelProduct.Name = "ColLibelProduct";
            this.ColLibelProduct.ReadOnly = true;
            this.ColLibelProduct.Width = 125;
            // 
            // ColQuantity
            // 
            this.ColQuantity.HeaderText = "Quantity";
            this.ColQuantity.MinimumWidth = 6;
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.Width = 125;
            // 
            // ColPrixUnitaire
            // 
            this.ColPrixUnitaire.HeaderText = "PrixUnitaire";
            this.ColPrixUnitaire.MinimumWidth = 6;
            this.ColPrixUnitaire.Name = "ColPrixUnitaire";
            this.ColPrixUnitaire.ReadOnly = true;
            this.ColPrixUnitaire.Width = 125;
            // 
            // ColAmount
            // 
            this.ColAmount.HeaderText = "Amount";
            this.ColAmount.MinimumWidth = 6;
            this.ColAmount.Name = "ColAmount";
            this.ColAmount.ReadOnly = true;
            this.ColAmount.Width = 125;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.MinimumWidth = 6;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Width = 125;
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(1007, 264);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(137, 23);
            this.BtnAddProduct.TabIndex = 5;
            this.BtnAddProduct.Text = "Ajouter Produit";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(123, 161);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(36, 16);
            this.LabelDate.TabIndex = 6;
            this.LabelDate.Text = "Date";
            // 
            // LabelCustomer
            // 
            this.LabelCustomer.AutoSize = true;
            this.LabelCustomer.Location = new System.Drawing.Point(615, 166);
            this.LabelCustomer.Name = "LabelCustomer";
            this.LabelCustomer.Size = new System.Drawing.Size(40, 16);
            this.LabelCustomer.TabIndex = 7;
            this.LabelCustomer.Text = "Client";
            // 
            // FormInvoiceCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 653);
            this.Controls.Add(this.LabelCustomer);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CBCustomer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCreateInvoice);
            this.Name = "FormInvoiceCreate";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateInvoice;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CBCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLibelProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelCustomer;
    }
}