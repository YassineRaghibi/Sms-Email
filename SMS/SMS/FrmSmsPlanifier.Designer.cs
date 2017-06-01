namespace SMS
{
    partial class FrmSmsPlanifier
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
            this.DgvSmsP = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSmsP)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSmsP
            // 
            this.DgvSmsP.AllowUserToAddRows = false;
            this.DgvSmsP.AllowUserToDeleteRows = false;
            this.DgvSmsP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSmsP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSmsP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Date,
            this.Message});
            this.DgvSmsP.Location = new System.Drawing.Point(13, 13);
            this.DgvSmsP.Name = "DgvSmsP";
            this.DgvSmsP.ReadOnly = true;
            this.DgvSmsP.RowHeadersVisible = false;
            this.DgvSmsP.Size = new System.Drawing.Size(520, 175);
            this.DgvSmsP.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date d\'envoi";
            this.Date.Name = "Date";
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSmsPlanifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvSmsP);
            this.Name = "FrmSmsPlanifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSmsPlanifier";
            this.Load += new System.EventHandler(this.FrmSmsPlanifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSmsP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSmsP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.Button button1;
    }
}