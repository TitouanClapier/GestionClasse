namespace AutoFact2
{
    partial class FormClientList
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
            this.DgvClient = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCreateClient = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClient
            // 
            this.DgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColSurname,
            this.ColCompany,
            this.ColAdresse,
            this.ColPostalCode,
            this.ColCity,
            this.ColMail,
            this.ColTel,
            this.ColBtnUpdate,
            this.ColBtnDelete});
            this.DgvClient.Location = new System.Drawing.Point(16, 133);
            this.DgvClient.Margin = new System.Windows.Forms.Padding(4);
            this.DgvClient.Name = "DgvClient";
            this.DgvClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvClient.RowHeadersWidth = 51;
            this.DgvClient.Size = new System.Drawing.Size(1516, 289);
            this.DgvClient.TabIndex = 0;
            this.DgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 25;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Prénom";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.Width = 125;
            // 
            // ColSurname
            // 
            this.ColSurname.HeaderText = "Nom";
            this.ColSurname.MinimumWidth = 6;
            this.ColSurname.Name = "ColSurname";
            this.ColSurname.ReadOnly = true;
            this.ColSurname.Width = 125;
            // 
            // ColCompany
            // 
            this.ColCompany.HeaderText = "Nom compagnie";
            this.ColCompany.MinimumWidth = 6;
            this.ColCompany.Name = "ColCompany";
            this.ColCompany.ReadOnly = true;
            this.ColCompany.Width = 125;
            // 
            // ColAdresse
            // 
            this.ColAdresse.HeaderText = "Adresse";
            this.ColAdresse.MinimumWidth = 6;
            this.ColAdresse.Name = "ColAdresse";
            this.ColAdresse.ReadOnly = true;
            this.ColAdresse.Width = 125;
            // 
            // ColPostalCode
            // 
            this.ColPostalCode.HeaderText = "Code postal";
            this.ColPostalCode.MinimumWidth = 6;
            this.ColPostalCode.Name = "ColPostalCode";
            this.ColPostalCode.ReadOnly = true;
            this.ColPostalCode.Width = 50;
            // 
            // ColCity
            // 
            this.ColCity.HeaderText = "Ville";
            this.ColCity.MinimumWidth = 6;
            this.ColCity.Name = "ColCity";
            this.ColCity.ReadOnly = true;
            this.ColCity.Width = 125;
            // 
            // ColMail
            // 
            this.ColMail.HeaderText = "Mail";
            this.ColMail.MinimumWidth = 6;
            this.ColMail.Name = "ColMail";
            this.ColMail.ReadOnly = true;
            this.ColMail.Width = 125;
            // 
            // ColTel
            // 
            this.ColTel.HeaderText = "Téléphone";
            this.ColTel.MinimumWidth = 6;
            this.ColTel.Name = "ColTel";
            this.ColTel.ReadOnly = true;
            this.ColTel.Width = 75;
            // 
            // ColBtnUpdate
            // 
            this.ColBtnUpdate.HeaderText = "Update";
            this.ColBtnUpdate.MinimumWidth = 6;
            this.ColBtnUpdate.Name = "ColBtnUpdate";
            this.ColBtnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBtnUpdate.Text = "Update";
            this.ColBtnUpdate.Width = 75;
            // 
            // ColBtnDelete
            // 
            this.ColBtnDelete.HeaderText = "Delete";
            this.ColBtnDelete.MinimumWidth = 6;
            this.ColBtnDelete.Name = "ColBtnDelete";
            this.ColBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColBtnDelete.Text = "Delete";
            this.ColBtnDelete.Width = 75;
            // 
            // BtnCreateClient
            // 
            this.BtnCreateClient.Location = new System.Drawing.Point(660, 502);
            this.BtnCreateClient.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCreateClient.Name = "BtnCreateClient";
            this.BtnCreateClient.Size = new System.Drawing.Size(100, 28);
            this.BtnCreateClient.TabIndex = 1;
            this.BtnCreateClient.Text = "Créer";
            this.BtnCreateClient.UseVisualStyleBackColor = true;
            this.BtnCreateClient.Click += new System.EventHandler(this.BtnCreateClient_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(427, 502);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 28);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des clients";
            // 
            // FormClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCreateClient);
            this.Controls.Add(this.DgvClient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientList";
            this.Load += new System.EventHandler(this.FormClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClient;
        private System.Windows.Forms.Button BtnCreateClient;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDelete;
        private System.Windows.Forms.Label label1;
    }
}