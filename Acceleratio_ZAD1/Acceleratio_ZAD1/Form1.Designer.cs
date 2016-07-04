namespace Acceleratio_ZAD1
{
    partial class Zadatak1
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
            this.btnOtvori = new System.Windows.Forms.Button();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.lblPrikazHijerarhije = new System.Windows.Forms.Label();
            this.lblOdabirFavorita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(12, 226);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(75, 23);
            this.btnOtvori.TabIndex = 0;
            this.btnOtvori.Text = "Otvori";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(12, 40);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrikaz.Size = new System.Drawing.Size(381, 180);
            this.txtPrikaz.TabIndex = 7;
            // 
            // cmbFiles
            // 
            this.cmbFiles.FormattingEnabled = true;
            this.cmbFiles.Location = new System.Drawing.Point(399, 40);
            this.cmbFiles.Name = "cmbFiles";
            this.cmbFiles.Size = new System.Drawing.Size(121, 21);
            this.cmbFiles.TabIndex = 8;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(93, 226);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(174, 226);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 10;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // lblPrikazHijerarhije
            // 
            this.lblPrikazHijerarhije.AutoSize = true;
            this.lblPrikazHijerarhije.Location = new System.Drawing.Point(13, 21);
            this.lblPrikazHijerarhije.Name = "lblPrikazHijerarhije";
            this.lblPrikazHijerarhije.Size = new System.Drawing.Size(89, 13);
            this.lblPrikazHijerarhije.TabIndex = 11;
            this.lblPrikazHijerarhije.Text = "Prikaz hijerarhije: ";
            // 
            // lblOdabirFavorita
            // 
            this.lblOdabirFavorita.AutoSize = true;
            this.lblOdabirFavorita.Location = new System.Drawing.Point(399, 20);
            this.lblOdabirFavorita.Name = "lblOdabirFavorita";
            this.lblOdabirFavorita.Size = new System.Drawing.Size(82, 13);
            this.lblOdabirFavorita.TabIndex = 12;
            this.lblOdabirFavorita.Text = "Odabir favorita: ";
            // 
            // Zadatak1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.lblOdabirFavorita);
            this.Controls.Add(this.lblPrikazHijerarhije);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbFiles);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.btnOtvori);
            this.Name = "Zadatak1";
            this.Text = "Zadatak 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.ComboBox cmbFiles;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Label lblPrikazHijerarhije;
        private System.Windows.Forms.Label lblOdabirFavorita;
    }
}

