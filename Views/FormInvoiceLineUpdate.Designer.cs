namespace AutoFact2.Views
{
    partial class FormInvoiceLineUpdate
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
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtPromotion = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CBProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(670, 136);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(100, 22);
            this.TxtQuantity.TabIndex = 1;
            // 
            // TxtPromotion
            // 
            this.TxtPromotion.Location = new System.Drawing.Point(421, 238);
            this.TxtPromotion.Name = "TxtPromotion";
            this.TxtPromotion.Size = new System.Drawing.Size(100, 22);
            this.TxtPromotion.TabIndex = 2;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(670, 237);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Promotion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prix";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(683, 347);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Modifier";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(433, 347);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Annuler";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CBProduct
            // 
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.Location = new System.Drawing.Point(421, 130);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.Size = new System.Drawing.Size(121, 24);
            this.CBProduct.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Modification d\'une ligne de facture";
            // 
            // FormInvoiceLineUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBProduct);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtPromotion);
            this.Controls.Add(this.TxtQuantity);
            this.Name = "FormInvoiceLineUpdate";
            this.Text = "FormInvoiceLineUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtPromotion;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CBProduct;
        private System.Windows.Forms.Label label5;
    }
}