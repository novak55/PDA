namespace UkolB4
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
            this.button_ProvestVypocty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Vzdalenost = new System.Windows.Forms.TextBox();
            this.textBox_Stupen = new System.Windows.Forms.TextBox();
            this.textBox_Rad = new System.Windows.Forms.TextBox();
            this.label_Kvadrant = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.button_ProvestVypocty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Y);
            this.groupBox1.Controls.Add(this.textBox_X);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vstupní parametry";
            // 
            // button_ProvestVypocty
            // 
            this.button_ProvestVypocty.Location = new System.Drawing.Point(83, 73);
            this.button_ProvestVypocty.Name = "button_ProvestVypocty";
            this.button_ProvestVypocty.Size = new System.Drawing.Size(75, 23);
            this.button_ProvestVypocty.TabIndex = 5;
            this.button_ProvestVypocty.Text = "Spočti!";
            this.button_ProvestVypocty.UseVisualStyleBackColor = true;
            this.button_ProvestVypocty.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "hodn. Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "hodn. X";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(195, 38);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(44, 20);
            this.textBox_Y.TabIndex = 2;
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(145, 38);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(44, 20);
            this.textBox_X.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadejte souřadnice bodu: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label_Kvadrant);
            this.groupBox2.Controls.Add(this.textBox_Rad);
            this.groupBox2.Controls.Add(this.textBox_Stupen);
            this.groupBox2.Controls.Add(this.textBox_Vzdalenost);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spočtené hodnoty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kvadrant:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vzdálenost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Úhel °:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Úhel rad:";
            // 
            // textBox_Vzdalenost
            // 
            this.textBox_Vzdalenost.Enabled = false;
            this.textBox_Vzdalenost.Location = new System.Drawing.Point(82, 44);
            this.textBox_Vzdalenost.Name = "textBox_Vzdalenost";
            this.textBox_Vzdalenost.Size = new System.Drawing.Size(100, 20);
            this.textBox_Vzdalenost.TabIndex = 5;
            // 
            // textBox_Stupen
            // 
            this.textBox_Stupen.Enabled = false;
            this.textBox_Stupen.Location = new System.Drawing.Point(82, 67);
            this.textBox_Stupen.Name = "textBox_Stupen";
            this.textBox_Stupen.Size = new System.Drawing.Size(100, 20);
            this.textBox_Stupen.TabIndex = 6;
            // 
            // textBox_Rad
            // 
            this.textBox_Rad.Enabled = false;
            this.textBox_Rad.Location = new System.Drawing.Point(82, 90);
            this.textBox_Rad.Name = "textBox_Rad";
            this.textBox_Rad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Rad.TabIndex = 7;
            // 
            // label_Kvadrant
            // 
            this.label_Kvadrant.AutoSize = true;
            this.label_Kvadrant.Location = new System.Drawing.Point(79, 21);
            this.label_Kvadrant.Name = "label_Kvadrant";
            this.label_Kvadrant.Size = new System.Drawing.Size(37, 13);
            this.label_Kvadrant.TabIndex = 8;
            this.label_Kvadrant.Text = "nedef.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 141);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PDA úkol B4 - výpočet úhlu a vzdálenosti";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ProvestVypocty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Kvadrant;
        private System.Windows.Forms.TextBox textBox_Rad;
        private System.Windows.Forms.TextBox textBox_Stupen;
        private System.Windows.Forms.TextBox textBox_Vzdalenost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

