namespace UkolD1
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
            this.textBox_CestaNazevSouboru = new System.Windows.Forms.TextBox();
            this.textBox_CestaNazevSouboru2 = new System.Windows.Forms.TextBox();
            this.button_VyberSoubor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Kopie1 = new System.Windows.Forms.Button();
            this.button_Kpoie2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_CestaNazevSouboru
            // 
            this.textBox_CestaNazevSouboru.Enabled = false;
            this.textBox_CestaNazevSouboru.Location = new System.Drawing.Point(30, 36);
            this.textBox_CestaNazevSouboru.Name = "textBox_CestaNazevSouboru";
            this.textBox_CestaNazevSouboru.Size = new System.Drawing.Size(474, 20);
            this.textBox_CestaNazevSouboru.TabIndex = 0;
            // 
            // textBox_CestaNazevSouboru2
            // 
            this.textBox_CestaNazevSouboru2.Enabled = false;
            this.textBox_CestaNazevSouboru2.Location = new System.Drawing.Point(30, 92);
            this.textBox_CestaNazevSouboru2.Name = "textBox_CestaNazevSouboru2";
            this.textBox_CestaNazevSouboru2.Size = new System.Drawing.Size(474, 20);
            this.textBox_CestaNazevSouboru2.TabIndex = 1;
            // 
            // button_VyberSoubor
            // 
            this.button_VyberSoubor.Location = new System.Drawing.Point(30, 7);
            this.button_VyberSoubor.Name = "button_VyberSoubor";
            this.button_VyberSoubor.Size = new System.Drawing.Size(86, 23);
            this.button_VyberSoubor.TabIndex = 2;
            this.button_VyberSoubor.Text = "Vyber soubor 1";
            this.button_VyberSoubor.UseVisualStyleBackColor = true;
            this.button_VyberSoubor.Click += new System.EventHandler(this.button_VyberSoubor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Vyber soubor 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Kopie1
            // 
            this.button_Kopie1.Location = new System.Drawing.Point(30, 140);
            this.button_Kopie1.Name = "button_Kopie1";
            this.button_Kopie1.Size = new System.Drawing.Size(86, 23);
            this.button_Kopie1.TabIndex = 4;
            this.button_Kopie1.Text = "Kopiruj typ 1";
            this.button_Kopie1.UseVisualStyleBackColor = true;
            this.button_Kopie1.Click += new System.EventHandler(this.button_Kopie1_Click);
            // 
            // button_Kpoie2
            // 
            this.button_Kpoie2.Location = new System.Drawing.Point(122, 140);
            this.button_Kpoie2.Name = "button_Kpoie2";
            this.button_Kpoie2.Size = new System.Drawing.Size(86, 23);
            this.button_Kpoie2.TabIndex = 5;
            this.button_Kpoie2.Text = "Kopiruj typ 2";
            this.button_Kpoie2.UseVisualStyleBackColor = true;
            this.button_Kpoie2.Click += new System.EventHandler(this.button_Kpoie2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 199);
            this.Controls.Add(this.button_Kpoie2);
            this.Controls.Add(this.button_Kopie1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_VyberSoubor);
            this.Controls.Add(this.textBox_CestaNazevSouboru2);
            this.Controls.Add(this.textBox_CestaNazevSouboru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CestaNazevSouboru;
        private System.Windows.Forms.TextBox textBox_CestaNazevSouboru2;
        private System.Windows.Forms.Button button_VyberSoubor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Kopie1;
        private System.Windows.Forms.Button button_Kpoie2;
    }
}

