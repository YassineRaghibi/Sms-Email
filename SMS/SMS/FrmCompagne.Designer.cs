namespace SMS
{
    partial class FrmCompagne
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
            this.CompagneDgv = new System.Windows.Forms.DataGridView();
            this.NumCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompagneDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CompagneDgv
            // 
            this.CompagneDgv.AllowUserToAddRows = false;
            this.CompagneDgv.AllowUserToDeleteRows = false;
            this.CompagneDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompagneDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompagneDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCom,
            this.NomCom,
            this.DateDCom,
            this.DateFCom});
            this.CompagneDgv.Location = new System.Drawing.Point(12, 12);
            this.CompagneDgv.Name = "CompagneDgv";
            this.CompagneDgv.ReadOnly = true;
            this.CompagneDgv.RowHeadersVisible = false;
            this.CompagneDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompagneDgv.Size = new System.Drawing.Size(618, 225);
            this.CompagneDgv.TabIndex = 0;
            // 
            // NumCom
            // 
            this.NumCom.HeaderText = "Numéro";
            this.NumCom.Name = "NumCom";
            this.NumCom.ReadOnly = true;
            // 
            // NomCom
            // 
            this.NomCom.HeaderText = "Nom";
            this.NomCom.Name = "NomCom";
            this.NomCom.ReadOnly = true;
            // 
            // DateDCom
            // 
            this.DateDCom.HeaderText = "Date debut";
            this.DateDCom.Name = "DateDCom";
            this.DateDCom.ReadOnly = true;
            // 
            // DateFCom
            // 
            this.DateFCom.HeaderText = "Date fin";
            this.DateFCom.Name = "DateFCom";
            this.DateFCom.ReadOnly = true;
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(12, 256);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(189, 39);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(227, 256);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(189, 39);
            this.Modifier.TabIndex = 2;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(441, 256);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(189, 39);
            this.Supprimer.TabIndex = 3;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // FrmCompagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 318);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.CompagneDgv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 357);
            this.MinimumSize = new System.Drawing.Size(658, 357);
            this.Name = "FrmCompagne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compagne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompagne_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompagne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompagneDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CompagneDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFCom;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
    }
}