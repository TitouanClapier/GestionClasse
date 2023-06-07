namespace AutoFact2
{
    partial class FormProductList
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
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLibel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProduct
            // 
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColLibel,
            this.ColPrice,
            this.ColIdCateg,
            this.ColBtnUpdate,
            this.ColBtnDelete});
            this.DgvProduct.Location = new System.Drawing.Point(13, 141);
            this.DgvProduct.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvProduct.RowHeadersWidth = 51;
            this.DgvProduct.Size = new System.Drawing.Size(1156, 185);
            this.DgvProduct.TabIndex = 0;
            this.DgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 125;
            // 
            // ColLibel
            // 
            this.ColLibel.HeaderText = "Libel";
            this.ColLibel.MinimumWidth = 6;
            this.ColLibel.Name = "ColLibel";
            this.ColLibel.Width = 125;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Prix unitaire";
            this.ColPrice.MinimumWidth = 6;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 125;
            // 
            // ColIdCateg
            // 
            this.ColIdCateg.HeaderText = "IdCategorie";
            this.ColIdCateg.MinimumWidth = 6;
            this.ColIdCateg.Name = "ColIdCateg";
            this.ColIdCateg.ReadOnly = true;
            this.ColIdCateg.Width = 125;
            // 
            // ColBtnUpdate
            // 
            this.ColBtnUpdate.HeaderText = "Update";
            this.ColBtnUpdate.MinimumWidth = 6;
            this.ColBtnUpdate.Name = "ColBtnUpdate";
            this.ColBtnUpdate.Width = 125;
            // 
            // ColBtnDelete
            // 
            this.ColBtnDelete.HeaderText = "Delete";
            this.ColBtnDelete.MinimumWidth = 6;
            this.ColBtnDelete.Name = "ColBtnDelete";
            this.ColBtnDelete.Width = 125;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(395, 419);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 28);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(661, 419);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(100, 28);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Créer";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Liste des produits";
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLibel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCateg;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDelete;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label1;
    }
}