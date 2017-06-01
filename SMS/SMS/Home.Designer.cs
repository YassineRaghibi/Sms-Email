namespace SMS
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.laListeDesSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesSmsPlanifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEmailsPlanifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compagneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.laListeDesCompagneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smsParametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailParamétreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.DgvSegement = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSegement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NbrMessage = new System.Windows.Forms.Label();
            this.NbrCompagne = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NbrSegment = new System.Windows.Forms.Label();
            this.RnvMessage = new System.Windows.Forms.Button();
            this.SegmentEnvoi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSegement)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem,
            this.segementToolStripMenuItem,
            this.sMSToolStripMenuItem,
            this.compagneToolStripMenuItem,
            this.parametreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(679, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.listeDesContactsToolStripMenuItem});
            this.contactToolStripMenuItem.Image = global::SMS.Properties.Resources.Contacts_200;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Image = global::SMS.Properties.Resources.AddBtn;
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // listeDesContactsToolStripMenuItem
            // 
            this.listeDesContactsToolStripMenuItem.Image = global::SMS.Properties.Resources.User_Menu_Male_48;
            this.listeDesContactsToolStripMenuItem.Name = "listeDesContactsToolStripMenuItem";
            this.listeDesContactsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.listeDesContactsToolStripMenuItem.Text = "Liste des Contacts";
            this.listeDesContactsToolStripMenuItem.Click += new System.EventHandler(this.listeDesContactsToolStripMenuItem_Click);
            // 
            // segementToolStripMenuItem
            // 
            this.segementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1});
            this.segementToolStripMenuItem.Name = "segementToolStripMenuItem";
            this.segementToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.segementToolStripMenuItem.Text = "Segment";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Image = global::SMS.Properties.Resources.AddBtn;
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(131, 26);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.laListeDesSMSToolStripMenuItem,
            this.listeDesEmailToolStripMenuItem,
            this.listeDesSmsPlanifierToolStripMenuItem,
            this.listeDesEmailsPlanifierToolStripMenuItem});
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.sMSToolStripMenuItem.Text = "SMS && Email";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(322, 26);
            this.ajouterToolStripMenuItem2.Text = "Envoyer un nouveau SMS ou Email";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.ajouterToolStripMenuItem2_Click);
            // 
            // laListeDesSMSToolStripMenuItem
            // 
            this.laListeDesSMSToolStripMenuItem.Name = "laListeDesSMSToolStripMenuItem";
            this.laListeDesSMSToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.laListeDesSMSToolStripMenuItem.Text = "La liste des SMS";
            this.laListeDesSMSToolStripMenuItem.Click += new System.EventHandler(this.laListeDesSMSToolStripMenuItem_Click);
            // 
            // listeDesEmailToolStripMenuItem
            // 
            this.listeDesEmailToolStripMenuItem.Name = "listeDesEmailToolStripMenuItem";
            this.listeDesEmailToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.listeDesEmailToolStripMenuItem.Text = "Liste Des Emails";
            this.listeDesEmailToolStripMenuItem.Click += new System.EventHandler(this.listeDesEmailToolStripMenuItem_Click);
            // 
            // listeDesSmsPlanifierToolStripMenuItem
            // 
            this.listeDesSmsPlanifierToolStripMenuItem.Name = "listeDesSmsPlanifierToolStripMenuItem";
            this.listeDesSmsPlanifierToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.listeDesSmsPlanifierToolStripMenuItem.Text = "Liste des Sms planifier";
            this.listeDesSmsPlanifierToolStripMenuItem.Click += new System.EventHandler(this.listeDesSmsPlanifierToolStripMenuItem_Click);
            // 
            // listeDesEmailsPlanifierToolStripMenuItem
            // 
            this.listeDesEmailsPlanifierToolStripMenuItem.Name = "listeDesEmailsPlanifierToolStripMenuItem";
            this.listeDesEmailsPlanifierToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.listeDesEmailsPlanifierToolStripMenuItem.Text = "Liste des Emails planifier";
            this.listeDesEmailsPlanifierToolStripMenuItem.Click += new System.EventHandler(this.listeDesEmailsPlanifierToolStripMenuItem_Click);
            // 
            // compagneToolStripMenuItem
            // 
            this.compagneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.laListeDesCompagneToolStripMenuItem});
            this.compagneToolStripMenuItem.Name = "compagneToolStripMenuItem";
            this.compagneToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.compagneToolStripMenuItem.Text = "Compagne";
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.Image = global::SMS.Properties.Resources.AddBtn;
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(233, 26);
            this.ajouterToolStripMenuItem3.Text = "Ajouter";
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click);
            // 
            // laListeDesCompagneToolStripMenuItem
            // 
            this.laListeDesCompagneToolStripMenuItem.Name = "laListeDesCompagneToolStripMenuItem";
            this.laListeDesCompagneToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.laListeDesCompagneToolStripMenuItem.Text = "La liste des compagne";
            this.laListeDesCompagneToolStripMenuItem.Click += new System.EventHandler(this.laListeDesCompagneToolStripMenuItem_Click);
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierColorToolStripMenuItem,
            this.modifierBackgroundToolStripMenuItem,
            this.smsParametreToolStripMenuItem,
            this.emailParamétreToolStripMenuItem});
            this.parametreToolStripMenuItem.Image = global::SMS.Properties.Resources._1488253498_configuration_edit;
            this.parametreToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.parametreToolStripMenuItem.Text = "Paramètre";
            // 
            // modifierColorToolStripMenuItem
            // 
            this.modifierColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierColorToolStripMenuItem.Image")));
            this.modifierColorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.modifierColorToolStripMenuItem.Name = "modifierColorToolStripMenuItem";
            this.modifierColorToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.modifierColorToolStripMenuItem.Text = "Modifier color";
            this.modifierColorToolStripMenuItem.Click += new System.EventHandler(this.modifierColorToolStripMenuItem_Click);
            // 
            // modifierBackgroundToolStripMenuItem
            // 
            this.modifierBackgroundToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierBackgroundToolStripMenuItem.Image")));
            this.modifierBackgroundToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.modifierBackgroundToolStripMenuItem.Name = "modifierBackgroundToolStripMenuItem";
            this.modifierBackgroundToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.modifierBackgroundToolStripMenuItem.Text = "Modifier Background";
            this.modifierBackgroundToolStripMenuItem.Click += new System.EventHandler(this.modifierBackgroundToolStripMenuItem_Click);
            // 
            // smsParametreToolStripMenuItem
            // 
            this.smsParametreToolStripMenuItem.Image = global::SMS.Properties.Resources._1488253498_configuration_edit;
            this.smsParametreToolStripMenuItem.Name = "smsParametreToolStripMenuItem";
            this.smsParametreToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.smsParametreToolStripMenuItem.Text = "Sms Paramètre";
            this.smsParametreToolStripMenuItem.Click += new System.EventHandler(this.smsParametreToolStripMenuItem_Click);
            // 
            // emailParamétreToolStripMenuItem
            // 
            this.emailParamétreToolStripMenuItem.Image = global::SMS.Properties.Resources._1488253498_configuration_edit;
            this.emailParamétreToolStripMenuItem.Name = "emailParamétreToolStripMenuItem";
            this.emailParamétreToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.emailParamétreToolStripMenuItem.Text = "Email Paramétre";
            this.emailParamétreToolStripMenuItem.Click += new System.EventHandler(this.emailParamétreToolStripMenuItem_Click);
            // 
            // DgvSegement
            // 
            this.DgvSegement.AllowUserToAddRows = false;
            this.DgvSegement.AllowUserToDeleteRows = false;
            this.DgvSegement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSegement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSegement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom,
            this.DateSegement});
            this.DgvSegement.Location = new System.Drawing.Point(6, 25);
            this.DgvSegement.Name = "DgvSegement";
            this.DgvSegement.ReadOnly = true;
            this.DgvSegement.RowHeadersVisible = false;
            this.DgvSegement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSegement.Size = new System.Drawing.Size(414, 213);
            this.DgvSegement.TabIndex = 1;
            // 
            // Num
            // 
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom ";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // DateSegement
            // 
            this.DateSegement.HeaderText = "Date d\'ajout";
            this.DateSegement.Name = "DateSegement";
            this.DateSegement.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvSegement);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envoyer vers tous le segment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher les contacts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre des messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre des compagnes";
            // 
            // NbrMessage
            // 
            this.NbrMessage.AutoSize = true;
            this.NbrMessage.Location = new System.Drawing.Point(203, 297);
            this.NbrMessage.Name = "NbrMessage";
            this.NbrMessage.Size = new System.Drawing.Size(18, 20);
            this.NbrMessage.TabIndex = 5;
            this.NbrMessage.Text = "0";
            // 
            // NbrCompagne
            // 
            this.NbrCompagne.AutoSize = true;
            this.NbrCompagne.Location = new System.Drawing.Point(203, 337);
            this.NbrCompagne.Name = "NbrCompagne";
            this.NbrCompagne.Size = new System.Drawing.Size(18, 20);
            this.NbrCompagne.TabIndex = 6;
            this.NbrCompagne.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre des  Segment";
            // 
            // NbrSegment
            // 
            this.NbrSegment.AutoSize = true;
            this.NbrSegment.Location = new System.Drawing.Point(203, 377);
            this.NbrSegment.Name = "NbrSegment";
            this.NbrSegment.Size = new System.Drawing.Size(18, 20);
            this.NbrSegment.TabIndex = 8;
            this.NbrSegment.Text = "0";
            // 
            // RnvMessage
            // 
            this.RnvMessage.BackColor = System.Drawing.Color.Red;
            this.RnvMessage.Location = new System.Drawing.Point(454, 337);
            this.RnvMessage.Name = "RnvMessage";
            this.RnvMessage.Size = new System.Drawing.Size(213, 60);
            this.RnvMessage.TabIndex = 10;
            this.RnvMessage.Text = "Renvoyer tous les messages";
            this.RnvMessage.UseVisualStyleBackColor = false;
            this.RnvMessage.Click += new System.EventHandler(this.RnvMessage_Click);
            // 
            // SegmentEnvoi
            // 
            this.SegmentEnvoi.Location = new System.Drawing.Point(454, 278);
            this.SegmentEnvoi.Name = "SegmentEnvoi";
            this.SegmentEnvoi.Size = new System.Drawing.Size(213, 53);
            this.SegmentEnvoi.TabIndex = 11;
            this.SegmentEnvoi.Text = "Envoyer vers un segment";
            this.SegmentEnvoi.UseVisualStyleBackColor = true;
            this.SegmentEnvoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "Les Messages Planifier Envoyer";
            this.notifyIcon2.Visible = true;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMS.Properties.Resources.Mobile_Sms_icon;
            this.pictureBox1.Location = new System.Drawing.Point(454, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(679, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SegmentEnvoi);
            this.Controls.Add(this.RnvMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NbrSegment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NbrCompagne);
            this.Controls.Add(this.NbrMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 445);
            this.MinimumSize = new System.Drawing.Size(695, 445);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La page d\'accueil ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSegement)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compagneToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem listeDesContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem laListeDesSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem laListeDesCompagneToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvSegement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSegement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NbrMessage;
        private System.Windows.Forms.Label NbrCompagne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NbrSegment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem smsParametreToolStripMenuItem;
        private System.Windows.Forms.Button RnvMessage;
        private System.Windows.Forms.Button SegmentEnvoi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailParamétreToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripMenuItem listeDesSmsPlanifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesEmailsPlanifierToolStripMenuItem;
    }
}