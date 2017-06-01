namespace SMS
{
    partial class EmailFrm
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
            this.LblTelec = new System.Windows.Forms.Label();
            this.LblPrenomC = new System.Windows.Forms.Label();
            this.LblNonC = new System.Windows.Forms.Label();
            this.LblFonction = new System.Windows.Forms.Label();
            this.LblPaye = new System.Windows.Forms.Label();
            this.LblVille = new System.Windows.Forms.Label();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.InfoContact = new System.Windows.Forms.GroupBox();
            this.SegDgv = new System.Windows.Forms.DataGridView();
            this.Segement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblFonctionC = new System.Windows.Forms.Label();
            this.LblPayeC = new System.Windows.Forms.Label();
            this.LblVilleC = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.BtnRenvoi = new System.Windows.Forms.Button();
            this.DgvContact = new System.Windows.Forms.DataGridView();
            this.ColorSms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailInfo = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compagne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMessageText = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomDeFichier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obj = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.TextBox();
            this.InfoContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTelec
            // 
            this.LblTelec.AutoSize = true;
            this.LblTelec.Location = new System.Drawing.Point(106, 72);
            this.LblTelec.Name = "LblTelec";
            this.LblTelec.Size = new System.Drawing.Size(31, 13);
            this.LblTelec.TabIndex = 8;
            this.LblTelec.Text = "none";
            // 
            // LblPrenomC
            // 
            this.LblPrenomC.AutoSize = true;
            this.LblPrenomC.Location = new System.Drawing.Point(106, 48);
            this.LblPrenomC.Name = "LblPrenomC";
            this.LblPrenomC.Size = new System.Drawing.Size(31, 13);
            this.LblPrenomC.TabIndex = 7;
            this.LblPrenomC.Text = "none";
            // 
            // LblNonC
            // 
            this.LblNonC.AutoSize = true;
            this.LblNonC.Location = new System.Drawing.Point(106, 24);
            this.LblNonC.Name = "LblNonC";
            this.LblNonC.Size = new System.Drawing.Size(31, 13);
            this.LblNonC.TabIndex = 6;
            this.LblNonC.Text = "none";
            // 
            // LblFonction
            // 
            this.LblFonction.AutoSize = true;
            this.LblFonction.Location = new System.Drawing.Point(6, 144);
            this.LblFonction.Name = "LblFonction";
            this.LblFonction.Size = new System.Drawing.Size(48, 13);
            this.LblFonction.TabIndex = 5;
            this.LblFonction.Text = "Fonction";
            // 
            // LblPaye
            // 
            this.LblPaye.AutoSize = true;
            this.LblPaye.Location = new System.Drawing.Point(6, 120);
            this.LblPaye.Name = "LblPaye";
            this.LblPaye.Size = new System.Drawing.Size(31, 13);
            this.LblPaye.TabIndex = 4;
            this.LblPaye.Text = "Payé";
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(6, 96);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(26, 13);
            this.LblVille.TabIndex = 3;
            this.LblVille.Text = "Ville";
            // 
            // LblTelephone
            // 
            this.LblTelephone.AutoSize = true;
            this.LblTelephone.Location = new System.Drawing.Point(6, 72);
            this.LblTelephone.Name = "LblTelephone";
            this.LblTelephone.Size = new System.Drawing.Size(58, 13);
            this.LblTelephone.TabIndex = 2;
            this.LblTelephone.Text = "Téléphone";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(6, 48);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(43, 13);
            this.LblPrenom.TabIndex = 1;
            this.LblPrenom.Text = "Prenom";
            // 
            // InfoContact
            // 
            this.InfoContact.Controls.Add(this.SegDgv);
            this.InfoContact.Controls.Add(this.LblFonctionC);
            this.InfoContact.Controls.Add(this.LblPayeC);
            this.InfoContact.Controls.Add(this.LblVilleC);
            this.InfoContact.Controls.Add(this.LblTelec);
            this.InfoContact.Controls.Add(this.LblPrenomC);
            this.InfoContact.Controls.Add(this.LblNonC);
            this.InfoContact.Controls.Add(this.LblFonction);
            this.InfoContact.Controls.Add(this.LblPaye);
            this.InfoContact.Controls.Add(this.LblVille);
            this.InfoContact.Controls.Add(this.LblTelephone);
            this.InfoContact.Controls.Add(this.LblPrenom);
            this.InfoContact.Controls.Add(this.LblNom);
            this.InfoContact.Location = new System.Drawing.Point(429, 331);
            this.InfoContact.Name = "InfoContact";
            this.InfoContact.Size = new System.Drawing.Size(468, 176);
            this.InfoContact.TabIndex = 11;
            this.InfoContact.TabStop = false;
            this.InfoContact.Text = "Les information de Contact";
            // 
            // SegDgv
            // 
            this.SegDgv.AllowUserToAddRows = false;
            this.SegDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SegDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Segement});
            this.SegDgv.Location = new System.Drawing.Point(234, 19);
            this.SegDgv.Name = "SegDgv";
            this.SegDgv.RowHeadersVisible = false;
            this.SegDgv.Size = new System.Drawing.Size(234, 150);
            this.SegDgv.TabIndex = 12;
            this.SegDgv.Visible = false;
            // 
            // Segement
            // 
            this.Segement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Segement.HeaderText = "Segment";
            this.Segement.Name = "Segement";
            // 
            // LblFonctionC
            // 
            this.LblFonctionC.AutoSize = true;
            this.LblFonctionC.Location = new System.Drawing.Point(106, 144);
            this.LblFonctionC.Name = "LblFonctionC";
            this.LblFonctionC.Size = new System.Drawing.Size(31, 13);
            this.LblFonctionC.TabIndex = 11;
            this.LblFonctionC.Text = "none";
            // 
            // LblPayeC
            // 
            this.LblPayeC.AutoSize = true;
            this.LblPayeC.Location = new System.Drawing.Point(106, 120);
            this.LblPayeC.Name = "LblPayeC";
            this.LblPayeC.Size = new System.Drawing.Size(31, 13);
            this.LblPayeC.TabIndex = 10;
            this.LblPayeC.Text = "none";
            // 
            // LblVilleC
            // 
            this.LblVilleC.AutoSize = true;
            this.LblVilleC.Location = new System.Drawing.Point(106, 96);
            this.LblVilleC.Name = "LblVilleC";
            this.LblVilleC.Size = new System.Drawing.Size(31, 13);
            this.LblVilleC.TabIndex = 9;
            this.LblVilleC.Text = "none";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(6, 24);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom";
            // 
            // BtnRenvoi
            // 
            this.BtnRenvoi.Location = new System.Drawing.Point(589, 513);
            this.BtnRenvoi.Name = "BtnRenvoi";
            this.BtnRenvoi.Size = new System.Drawing.Size(151, 28);
            this.BtnRenvoi.TabIndex = 12;
            this.BtnRenvoi.Text = " Renvoyer les messages";
            this.BtnRenvoi.UseVisualStyleBackColor = true;
            // 
            // DgvContact
            // 
            this.DgvContact.AllowUserToAddRows = false;
            this.DgvContact.AllowUserToDeleteRows = false;
            this.DgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorSms,
            this.Num,
            this.Nom,
            this.Prenom,
            this.Tel,
            this.Ville,
            this.Paye,
            this.Fonction});
            this.DgvContact.Location = new System.Drawing.Point(12, 178);
            this.DgvContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvContact.MultiSelect = false;
            this.DgvContact.Name = "DgvContact";
            this.DgvContact.ReadOnly = true;
            this.DgvContact.RowHeadersVisible = false;
            this.DgvContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContact.Size = new System.Drawing.Size(587, 145);
            this.DgvContact.TabIndex = 10;
            this.DgvContact.SelectionChanged += new System.EventHandler(this.DgvContact_SelectionChanged);
            // 
            // ColorSms
            // 
            this.ColorSms.FillWeight = 25F;
            this.ColorSms.HeaderText = "";
            this.ColorSms.Name = "ColorSms";
            this.ColorSms.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.FillWeight = 110.7445F;
            this.Nom.HeaderText = "Prénom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.FillWeight = 110.7445F;
            this.Prenom.HeaderText = "Nom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.FillWeight = 110.7445F;
            this.Tel.HeaderText = "Email";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.FillWeight = 110.7445F;
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // Paye
            // 
            this.Paye.FillWeight = 110.7445F;
            this.Paye.HeaderText = "Paye";
            this.Paye.Name = "Paye";
            this.Paye.ReadOnly = true;
            // 
            // Fonction
            // 
            this.Fonction.FillWeight = 110.7445F;
            this.Fonction.HeaderText = "Fonction";
            this.Fonction.Name = "Fonction";
            this.Fonction.ReadOnly = true;
            // 
            // EmailInfo
            // 
            this.EmailInfo.AllowUserToAddRows = false;
            this.EmailInfo.AllowUserToDeleteRows = false;
            this.EmailInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmailInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Message,
            this.Date,
            this.Number_of_contact,
            this.Compagne});
            this.EmailInfo.Location = new System.Drawing.Point(12, 12);
            this.EmailInfo.MultiSelect = false;
            this.EmailInfo.Name = "EmailInfo";
            this.EmailInfo.ReadOnly = true;
            this.EmailInfo.RowHeadersVisible = false;
            this.EmailInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmailInfo.Size = new System.Drawing.Size(885, 158);
            this.EmailInfo.TabIndex = 7;
            this.EmailInfo.SelectionChanged += new System.EventHandler(this.EmailInfo_SelectionChanged);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "numéro";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Number_of_contact
            // 
            this.Number_of_contact.HeaderText = "Numéro des contact";
            this.Number_of_contact.Name = "Number_of_contact";
            this.Number_of_contact.ReadOnly = true;
            // 
            // Compagne
            // 
            this.Compagne.HeaderText = "Compagne";
            this.Compagne.Name = "Compagne";
            this.Compagne.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Definire comme model";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtMessageText
            // 
            this.TxtMessageText.Location = new System.Drawing.Point(12, 379);
            this.TxtMessageText.Name = "TxtMessageText";
            this.TxtMessageText.ReadOnly = true;
            this.TxtMessageText.Size = new System.Drawing.Size(411, 155);
            this.TxtMessageText.TabIndex = 8;
            this.TxtMessageText.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomDeFichier});
            this.dataGridView1.Location = new System.Drawing.Point(607, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(290, 145);
            this.dataGridView1.TabIndex = 13;
            // 
            // NomDeFichier
            // 
            this.NomDeFichier.HeaderText = "Attachement";
            this.NomDeFichier.Name = "NomDeFichier";
            this.NomDeFichier.ReadOnly = true;
            // 
            // Obj
            // 
            this.Obj.Location = new System.Drawing.Point(13, 353);
            this.Obj.Name = "Obj";
            this.Obj.ReadOnly = true;
            this.Obj.Size = new System.Drawing.Size(410, 20);
            this.Obj.TabIndex = 14;
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(13, 327);
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Size = new System.Drawing.Size(410, 20);
            this.From.TabIndex = 15;
            // 
            // EmailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 548);
            this.Controls.Add(this.From);
            this.Controls.Add(this.Obj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InfoContact);
            this.Controls.Add(this.BtnRenvoi);
            this.Controls.Add(this.DgvContact);
            this.Controls.Add(this.EmailInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtMessageText);
            this.Name = "EmailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmailFrm";
            this.Load += new System.EventHandler(this.EmailFrm_Load);
            this.InfoContact.ResumeLayout(false);
            this.InfoContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTelec;
        private System.Windows.Forms.Label LblPrenomC;
        private System.Windows.Forms.Label LblNonC;
        private System.Windows.Forms.Label LblFonction;
        private System.Windows.Forms.Label LblPaye;
        private System.Windows.Forms.Label LblVille;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.GroupBox InfoContact;
        private System.Windows.Forms.DataGridView SegDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segement;
        private System.Windows.Forms.Label LblFonctionC;
        private System.Windows.Forms.Label LblPayeC;
        private System.Windows.Forms.Label LblVilleC;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Button BtnRenvoi;
        private System.Windows.Forms.DataGridView DgvContact;
        private System.Windows.Forms.DataGridView EmailInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TxtMessageText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compagne;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomDeFichier;
        private System.Windows.Forms.TextBox Obj;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorSms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
    }
}