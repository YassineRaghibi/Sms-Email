namespace SMS
{
    partial class AddSegment
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
            this.NomSegement = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomSegement
            // 
            this.NomSegement.Depth = 0;
            this.NomSegement.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomSegement.Hint = "";
            this.NomSegement.Location = new System.Drawing.Point(9, 84);
            this.NomSegement.MouseState = MaterialSkin.MouseState.HOVER;
            this.NomSegement.Name = "NomSegement";
            this.NomSegement.Padding = new System.Windows.Forms.Padding(4);
            this.NomSegement.PasswordChar = '\0';
            this.NomSegement.SelectedText = "";
            this.NomSegement.SelectionLength = 0;
            this.NomSegement.SelectionStart = 0;
            this.NomSegement.Size = new System.Drawing.Size(262, 23);
            this.NomSegement.TabIndex = 1;
            this.NomSegement.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(119, 116);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Ajouter";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMS.Properties.Resources.e09409ed14053f673f4030acaea8a160;
            this.pictureBox1.Location = new System.Drawing.Point(277, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddSegment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 184);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.NomSegement);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(386, 184);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(386, 184);
            this.Name = "AddSegment";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter Segment";
            this.Load += new System.EventHandler(this.AddSegment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField NomSegement;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}