namespace UkolA3
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Prijmeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Jmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ulice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Mesto = new System.Windows.Forms.TextBox();
            this.textBox_PSC = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_Vystup = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_Telefon);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.textBox_PSC);
            this.groupBox1.Controls.Add(this.textBox_Mesto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Ulice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Prijmeni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Jmeno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nový zákazník";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ulice a číslo domu";
            // 
            // textBox_Prijmeni
            // 
            this.textBox_Prijmeni.Location = new System.Drawing.Point(125, 66);
            this.textBox_Prijmeni.Name = "textBox_Prijmeni";
            this.textBox_Prijmeni.Size = new System.Drawing.Size(191, 20);
            this.textBox_Prijmeni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Příjmení";
            // 
            // textBox_Jmeno
            // 
            this.textBox_Jmeno.Location = new System.Drawing.Point(125, 40);
            this.textBox_Jmeno.Name = "textBox_Jmeno";
            this.textBox_Jmeno.Size = new System.Drawing.Size(191, 20);
            this.textBox_Jmeno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // textBox_Ulice
            // 
            this.textBox_Ulice.Location = new System.Drawing.Point(125, 92);
            this.textBox_Ulice.Name = "textBox_Ulice";
            this.textBox_Ulice.Size = new System.Drawing.Size(232, 20);
            this.textBox_Ulice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Město";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PSČ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Telefon";
            // 
            // textBox_Mesto
            // 
            this.textBox_Mesto.Location = new System.Drawing.Point(125, 118);
            this.textBox_Mesto.Name = "textBox_Mesto";
            this.textBox_Mesto.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mesto.TabIndex = 10;
            // 
            // textBox_PSC
            // 
            this.textBox_PSC.Location = new System.Drawing.Point(125, 144);
            this.textBox_PSC.Name = "textBox_PSC";
            this.textBox_PSC.Size = new System.Drawing.Size(100, 20);
            this.textBox_PSC.TabIndex = 11;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(125, 170);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(232, 20);
            this.textBox_Email.TabIndex = 12;
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Location = new System.Drawing.Point(125, 196);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(100, 20);
            this.textBox_Telefon.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Uložit zákazníka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_Vystup
            // 
            this.richTextBox_Vystup.Location = new System.Drawing.Point(427, 40);
            this.richTextBox_Vystup.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBox_Vystup.Name = "richTextBox_Vystup";
            this.richTextBox_Vystup.Size = new System.Drawing.Size(343, 263);
            this.richTextBox_Vystup.TabIndex = 1;
            this.richTextBox_Vystup.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Údaje o zákazníkovi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 331);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox_Vystup);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Adresář";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Jmeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Prijmeni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_PSC;
        private System.Windows.Forms.TextBox textBox_Mesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Ulice;
        private System.Windows.Forms.RichTextBox richTextBox_Vystup;
        private System.Windows.Forms.Label label8;
    }
}

