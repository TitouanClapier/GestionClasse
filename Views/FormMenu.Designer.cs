namespace AutoFact2
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientList = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnInvoiceList = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientList
            // 
            this.btnClientList.Location = new System.Drawing.Point(125, 107);
            this.btnClientList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(208, 37);
            this.btnClientList.TabIndex = 0;
            this.btnClientList.Text = "Gestion des clients";
            this.btnClientList.UseVisualStyleBackColor = true;
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(125, 172);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(208, 37);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "Gestion des produits";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnInvoiceList
            // 
            this.btnInvoiceList.Location = new System.Drawing.Point(125, 238);
            this.btnInvoiceList.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvoiceList.Name = "btnInvoiceList";
            this.btnInvoiceList.Size = new System.Drawing.Size(208, 37);
            this.btnInvoiceList.TabIndex = 6;
            this.btnInvoiceList.Text = "Gestion des factures";
            this.btnInvoiceList.UseVisualStyleBackColor = true;
            this.btnInvoiceList.Click += new System.EventHandler(this.btnInvoiceList_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(905, 107);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(208, 37);
            this.btnProfil.TabIndex = 9;
            this.btnProfil.Text = "A propos de";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(452, 19);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTitle.Size = new System.Drawing.Size(300, 50);
            this.LabelTitle.TabIndex = 14;
            this.LabelTitle.Text = "AutoFact2";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnInvoiceList);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnClientList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientList;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnInvoiceList;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelTitle;
    }
}

