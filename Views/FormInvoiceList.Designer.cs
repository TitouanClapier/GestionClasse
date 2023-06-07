namespace AutoFact2
{
    partial class FormInvoiceList
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
            this.DgvInvoice = new System.Windows.Forms.DataGridView();
            this.ColIdInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnPDF = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBtnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCreateInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvInvoice
            // 
            this.DgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdInvoice,
            this.ColName,
            this.ColSurname,
            this.ColCompany,
            this.ColDate,
            this.ColBtnPDF,
            this.ColBtnDetail});
            this.DgvInvoice.Location = new System.Drawing.Point(56, 151);
            this.DgvInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.DgvInvoice.Name = "DgvInvoice";
            this.DgvInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvInvoice.RowHeadersWidth = 51;
            this.DgvInvoice.Size = new System.Drawing.Size(1288, 291);
            this.DgvInvoice.TabIndex = 0;
            this.DgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColIdInvoice
            // 
            this.ColIdInvoice.HeaderText = "Numéro de facture";
            this.ColIdInvoice.MinimumWidth = 6;
            this.ColIdInvoice.Name = "ColIdInvoice";
            this.ColIdInvoice.ReadOnly = true;
            this.ColIdInvoice.Width = 150;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Prenom";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.Width = 125;
            // 
            // ColSurname
            // 
            this.ColSurname.HeaderText = "Nom";
            this.ColSurname.MinimumWidth = 6;
            this.ColSurname.Name = "ColSurname";
            this.ColSurname.Width = 125;
            // 
            // ColCompany
            // 
            this.ColCompany.HeaderText = "Compagnie";
            this.ColCompany.MinimumWidth = 6;
            this.ColCompany.Name = "ColCompany";
            this.ColCompany.Width = 125;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.MinimumWidth = 6;
            this.ColDate.Name = "ColDate";
            this.ColDate.Width = 75;
            // 
            // ColBtnPDF
            // 
            this.ColBtnPDF.HeaderText = "Génerer PDF";
            this.ColBtnPDF.MinimumWidth = 6;
            this.ColBtnPDF.Name = "ColBtnPDF";
            this.ColBtnPDF.Width = 125;
            // 
            // ColBtnDetail
            // 
            this.ColBtnDetail.HeaderText = "Detail";
            this.ColBtnDetail.MinimumWidth = 6;
            this.ColBtnDetail.Name = "ColBtnDetail";
            this.ColBtnDetail.Width = 125;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(501, 465);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(104, 28);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCreateInvoice
            // 
            this.BtnCreateInvoice.Location = new System.Drawing.Point(753, 465);
            this.BtnCreateInvoice.Name = "BtnCreateInvoice";
            this.BtnCreateInvoice.Size = new System.Drawing.Size(193, 28);
            this.BtnCreateInvoice.TabIndex = 4;
            this.BtnCreateInvoice.Text = "Créer une nouvelle facture";
            this.BtnCreateInvoice.UseVisualStyleBackColor = true;
            this.BtnCreateInvoice.Click += new System.EventHandler(this.BtnCreateInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des factures";
            // 
            // FormInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCreateInvoice);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvInvoice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInvoiceList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceList";
            this.Load += new System.EventHandler(this.FormInvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvInvoice;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCreateInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnPDF;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDetail;
    }
}