namespace SMS
{
    partial class FrmListContact
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
            this.DgvContact = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoContact = new System.Windows.Forms.GroupBox();
            this.SegDgv = new System.Windows.Forms.DataGridView();
            this.Segement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblFonctionC = new System.Windows.Forms.Label();
            this.LblPayeC = new System.Windows.Forms.Label();
            this.LblVilleC = new System.Windows.Forms.Label();
            this.LblTelec = new System.Windows.Forms.Label();
            this.LblPrenomC = new System.Windows.Forms.Label();
            this.LblNonC = new System.Windows.Forms.Label();
            this.LblFonction = new System.Windows.Forms.Label();
            this.LblPaye = new System.Windows.Forms.Label();
            this.LblVille = new System.Windows.Forms.Label();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.ButtonMod = new System.Windows.Forms.Button();
            this.ButtonSup = new System.Windows.Forms.Button();
            this.ButtonEnv = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SegmentListCom = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContact)).BeginInit();
            this.InfoContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvContact
            // 
            this.DgvContact.AllowUserToAddRows = false;
            this.DgvContact.AllowUserToDeleteRows = false;
            this.DgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Num,
            this.Nom,
            this.Prenom,
            this.Tel,
            this.Ville,
            this.Paye,
            this.Fonction});
            this.DgvContact.Location = new System.Drawing.Point(18, 47);
            this.DgvContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvContact.Name = "DgvContact";
            this.DgvContact.RowHeadersVisible = false;
            this.DgvContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContact.Size = new System.Drawing.Size(890, 268);
            this.DgvContact.TabIndex = 0;
            this.DgvContact.SelectionChanged += new System.EventHandler(this.DgvContact_SelectionChanged);
            // 
            // Select
            // 
            this.Select.FillWeight = 35.53299F;
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
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
            this.Tel.HeaderText = "Téléphone";
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
            this.InfoContact.Location = new System.Drawing.Point(18, 343);
            this.InfoContact.Name = "InfoContact";
            this.InfoContact.Size = new System.Drawing.Size(696, 176);
            this.InfoContact.TabIndex = 4;
            this.InfoContact.TabStop = false;
            this.InfoContact.Text = "Les information de Contact";
            // 
            // SegDgv
            // 
            this.SegDgv.AllowUserToAddRows = false;
            this.SegDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SegDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Segement});
            this.SegDgv.Location = new System.Drawing.Point(456, 14);
            this.SegDgv.Name = "SegDgv";
            this.SegDgv.RowHeadersVisible = false;
            this.SegDgv.Size = new System.Drawing.Size(234, 150);
            this.SegDgv.TabIndex = 12;
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
            this.LblFonctionC.Size = new System.Drawing.Size(45, 20);
            this.LblFonctionC.TabIndex = 11;
            this.LblFonctionC.Text = "none";
            // 
            // LblPayeC
            // 
            this.LblPayeC.AutoSize = true;
            this.LblPayeC.Location = new System.Drawing.Point(106, 120);
            this.LblPayeC.Name = "LblPayeC";
            this.LblPayeC.Size = new System.Drawing.Size(45, 20);
            this.LblPayeC.TabIndex = 10;
            this.LblPayeC.Text = "none";
            // 
            // LblVilleC
            // 
            this.LblVilleC.AutoSize = true;
            this.LblVilleC.Location = new System.Drawing.Point(106, 96);
            this.LblVilleC.Name = "LblVilleC";
            this.LblVilleC.Size = new System.Drawing.Size(45, 20);
            this.LblVilleC.TabIndex = 9;
            this.LblVilleC.Text = "none";
            // 
            // LblTelec
            // 
            this.LblTelec.AutoSize = true;
            this.LblTelec.Location = new System.Drawing.Point(106, 72);
            this.LblTelec.Name = "LblTelec";
            this.LblTelec.Size = new System.Drawing.Size(45, 20);
            this.LblTelec.TabIndex = 8;
            this.LblTelec.Text = "none";
            // 
            // LblPrenomC
            // 
            this.LblPrenomC.AutoSize = true;
            this.LblPrenomC.Location = new System.Drawing.Point(106, 48);
            this.LblPrenomC.Name = "LblPrenomC";
            this.LblPrenomC.Size = new System.Drawing.Size(45, 20);
            this.LblPrenomC.TabIndex = 7;
            this.LblPrenomC.Text = "none";
            // 
            // LblNonC
            // 
            this.LblNonC.AutoSize = true;
            this.LblNonC.Location = new System.Drawing.Point(106, 24);
            this.LblNonC.Name = "LblNonC";
            this.LblNonC.Size = new System.Drawing.Size(45, 20);
            this.LblNonC.TabIndex = 6;
            this.LblNonC.Text = "none";
            // 
            // LblFonction
            // 
            this.LblFonction.AutoSize = true;
            this.LblFonction.Location = new System.Drawing.Point(6, 144);
            this.LblFonction.Name = "LblFonction";
            this.LblFonction.Size = new System.Drawing.Size(71, 20);
            this.LblFonction.TabIndex = 5;
            this.LblFonction.Text = "Fonction";
            // 
            // LblPaye
            // 
            this.LblPaye.AutoSize = true;
            this.LblPaye.Location = new System.Drawing.Point(6, 120);
            this.LblPaye.Name = "LblPaye";
            this.LblPaye.Size = new System.Drawing.Size(44, 20);
            this.LblPaye.TabIndex = 4;
            this.LblPaye.Text = "Payé";
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(6, 96);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(38, 20);
            this.LblVille.TabIndex = 3;
            this.LblVille.Text = "Ville";
            // 
            // LblTelephone
            // 
            this.LblTelephone.AutoSize = true;
            this.LblTelephone.Location = new System.Drawing.Point(6, 72);
            this.LblTelephone.Name = "LblTelephone";
            this.LblTelephone.Size = new System.Drawing.Size(84, 20);
            this.LblTelephone.TabIndex = 2;
            this.LblTelephone.Text = "Téléphone";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(6, 48);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(64, 20);
            this.LblPrenom.TabIndex = 1;
            this.LblPrenom.Text = "Prenom";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(6, 24);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom";
            // 
            // ButtonMod
            // 
            this.ButtonMod.Location = new System.Drawing.Point(721, 423);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.Size = new System.Drawing.Size(188, 28);
            this.ButtonMod.TabIndex = 5;
            this.ButtonMod.Text = "Modifier ";
            this.ButtonMod.UseVisualStyleBackColor = true;
            this.ButtonMod.Click += new System.EventHandler(this.ButtonMod_Click);
            // 
            // ButtonSup
            // 
            this.ButtonSup.Location = new System.Drawing.Point(720, 457);
            this.ButtonSup.Name = "ButtonSup";
            this.ButtonSup.Size = new System.Drawing.Size(188, 28);
            this.ButtonSup.TabIndex = 6;
            this.ButtonSup.Text = "Supprimer";
            this.ButtonSup.UseVisualStyleBackColor = true;
            this.ButtonSup.Click += new System.EventHandler(this.ButtonSup_Click);
            // 
            // ButtonEnv
            // 
            this.ButtonEnv.Location = new System.Drawing.Point(720, 490);
            this.ButtonEnv.Name = "ButtonEnv";
            this.ButtonEnv.Size = new System.Drawing.Size(188, 37);
            this.ButtonEnv.TabIndex = 7;
            this.ButtonEnv.Text = "Envoyer Sms";
            this.ButtonEnv.UseVisualStyleBackColor = true;
            this.ButtonEnv.Click += new System.EventHandler(this.ButtonEnv_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(720, 389);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(188, 28);
            this.ButtonAdd.TabIndex = 8;
            this.ButtonAdd.Text = "Ajouter";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Recherche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SegmentListCom
            // 
            this.SegmentListCom.FormattingEnabled = true;
            this.SegmentListCom.Location = new System.Drawing.Point(721, 323);
            this.SegmentListCom.Name = "SegmentListCom";
            this.SegmentListCom.Size = new System.Drawing.Size(188, 28);
            this.SegmentListCom.TabIndex = 10;
            this.SegmentListCom.SelectedIndexChanged += new System.EventHandler(this.SegmentListCom_SelectedIndexChanged);
            this.SegmentListCom.SelectedValueChanged += new System.EventHandler(this.SegmentListCom_SelectedValueChanged);
            this.SegmentListCom.TextChanged += new System.EventHandler(this.SegmentListCom_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(552, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(576, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Les contacts selectionner :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmListContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 539);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SegmentListCom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonEnv);
            this.Controls.Add(this.ButtonSup);
            this.Controls.Add(this.ButtonMod);
            this.Controls.Add(this.InfoContact);
            this.Controls.Add(this.DgvContact);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(937, 577);
            this.MinimumSize = new System.Drawing.Size(937, 577);
            this.Name = "FrmListContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des Contact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListContact_FormClosing);
            this.Load += new System.EventHandler(this.FrmListContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContact)).EndInit();
            this.InfoContact.ResumeLayout(false);
            this.InfoContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SegDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvContact;
        private System.Windows.Forms.GroupBox InfoContact;
        private System.Windows.Forms.Label LblFonction;
        private System.Windows.Forms.Label LblPaye;
        private System.Windows.Forms.Label LblVille;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Button ButtonMod;
        private System.Windows.Forms.Button ButtonSup;
        private System.Windows.Forms.Button ButtonEnv;
        private System.Windows.Forms.Label LblFonctionC;
        private System.Windows.Forms.Label LblPayeC;
        private System.Windows.Forms.Label LblVilleC;
        private System.Windows.Forms.Label LblTelec;
        private System.Windows.Forms.Label LblPrenomC;
        private System.Windows.Forms.Label LblNonC;
        private System.Windows.Forms.DataGridView SegDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segement;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SegmentListCom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}