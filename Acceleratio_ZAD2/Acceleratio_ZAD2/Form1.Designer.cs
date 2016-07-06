namespace Acceleratio_ZAD2
{
    partial class Form1
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.ltbToDo = new System.Windows.Forms.ListBox();
            this.txtZadatak = new System.Windows.Forms.TextBox();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.ltbInProg = new System.Windows.Forms.ListBox();
            this.ltbDone = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 69);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // ltbToDo
            // 
            this.ltbToDo.FormattingEnabled = true;
            this.ltbToDo.Location = new System.Drawing.Point(294, 34);
            this.ltbToDo.Name = "ltbToDo";
            this.ltbToDo.Size = new System.Drawing.Size(120, 95);
            this.ltbToDo.TabIndex = 1;
            // 
            // txtZadatak
            // 
            this.txtZadatak.Location = new System.Drawing.Point(12, 34);
            this.txtZadatak.Name = "txtZadatak";
            this.txtZadatak.Size = new System.Drawing.Size(100, 20);
            this.txtZadatak.TabIndex = 2;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Items.AddRange(new object[] {
            "In progress",
            "Done"});
            this.cmbKategorije.Location = new System.Drawing.Point(138, 33);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorije.TabIndex = 3;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(138, 69);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 4;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // ltbInProg
            // 
            this.ltbInProg.FormattingEnabled = true;
            this.ltbInProg.Location = new System.Drawing.Point(420, 34);
            this.ltbInProg.Name = "ltbInProg";
            this.ltbInProg.Size = new System.Drawing.Size(120, 95);
            this.ltbInProg.TabIndex = 5;
            // 
            // ltbDone
            // 
            this.ltbDone.FormattingEnabled = true;
            this.ltbDone.Location = new System.Drawing.Point(546, 33);
            this.ltbDone.Name = "ltbDone";
            this.ltbDone.Size = new System.Drawing.Size(120, 95);
            this.ltbDone.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zadatak: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "To Do: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "In progress: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Done: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 151);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbDone);
            this.Controls.Add(this.ltbInProg);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.txtZadatak);
            this.Controls.Add(this.ltbToDo);
            this.Controls.Add(this.btnSpremi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ListBox ltbToDo;
        private System.Windows.Forms.TextBox txtZadatak;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.ListBox ltbInProg;
        private System.Windows.Forms.ListBox ltbDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

