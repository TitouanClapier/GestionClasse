namespace AutoFact2.Views
{
    partial class FormInvoiceLineCreate
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
            this.TxtPromotion = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.BtnAddInvoiceLine = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPromotion
            // 
            this.TxtPromotion.Location = new System.Drawing.Point(309, 229);
            this.TxtPromotion.Name = "TxtPromotion";
            this.TxtPromotion.Size = new System.Drawing.Size(100, 22);
            this.TxtPromotion.TabIndex = 0;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(709, 137);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(100, 22);
            this.TxtQuantity.TabIndex = 2;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(709, 234);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 3;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(208, 229);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(68, 16);
            this.label60.TabIndex = 5;
            this.label60.Text = "Promotion";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(606, 140);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 16);
            this.label40.TabIndex = 6;
            this.label40.Text = "Quantité";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(606, 234);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(29, 16);
            this.label50.TabIndex = 7;
            this.label50.Text = "Prix";
            // 
            // BtnAddInvoiceLine
            // 
            this.BtnAddInvoiceLine.Location = new System.Drawing.Point(648, 392);
            this.BtnAddInvoiceLine.Name = "BtnAddInvoiceLine";
            this.BtnAddInvoiceLine.Size = new System.Drawing.Size(75, 23);
            this.BtnAddInvoiceLine.TabIndex = 8;
            this.BtnAddInvoiceLine.Text = "Ajouter";
            this.BtnAddInvoiceLine.UseVisualStyleBackColor = true;
            this.BtnAddInvoiceLine.Click += new System.EventHandler(this.BtnAddInvoiceLine_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(436, 392);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Annuler";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produit";
            // 
            // CBProduct
            // 
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.Location = new System.Drawing.Point(309, 140);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.Size = new System.Drawing.Size(264, 24);
            this.CBProduct.TabIndex = 10;
            this.CBProduct.SelectedIndexChanged += new System.EventHandler(this.CBProduct_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Creation d\'une ligne de facture";
            // 
            // FormInvoiceLineCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBProduct);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddInvoiceLine);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtPromotion);
            this.Name = "FormInvoiceLineCreate";
            this.Text = "FormInvoiceLineCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPromotion;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button BtnAddInvoiceLine;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBProduct;
        private System.Windows.Forms.Label label2;
    }
}