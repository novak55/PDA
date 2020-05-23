namespace UkolD2
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
            this.button_Kpoie2 = new System.Windows.Forms.Button();
            this.button_Kopie1 = new System.Windows.Forms.Button();
            this.button_VyberSoubor2 = new System.Windows.Forms.Button();
            this.button_VyberSoubor = new System.Windows.Forms.Button();
            this.textBox_CestaNazevSouboru2 = new System.Windows.Forms.TextBox();
            this.textBox_CestaNazevSouboru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Kpoie2
            // 
            this.button_Kpoie2.Location = new System.Drawing.Point(123, 164);
            this.button_Kpoie2.Name = "button_Kpoie2";
            this.button_Kpoie2.Size = new System.Drawing.Size(86, 23);
            this.button_Kpoie2.TabIndex = 11;
            this.button_Kpoie2.Text = "Kopiruj typ 2";
            this.button_Kpoie2.UseVisualStyleBackColor = true;
            this.button_Kpoie2.Click += new System.EventHandler(this.button_Kpoie2_Click_1);
            // 
            // button_Kopie1
            // 
            this.button_Kopie1.Location = new System.Drawing.Point(31, 164);
            this.button_Kopie1.Name = "button_Kopie1";
            this.button_Kopie1.Size = new System.Drawing.Size(86, 23);
            this.button_Kopie1.TabIndex = 10;
            this.button_Kopie1.Text = "Kopiruj typ 1";
            this.button_Kopie1.UseVisualStyleBackColor = true;
            this.button_Kopie1.Click += new System.EventHandler(this.button_Kopie1_Click_1);
            // 
            // button_VyberSoubor2
            // 
            this.button_VyberSoubor2.Enabled = false;
            this.button_VyberSoubor2.Location = new System.Drawing.Point(31, 87);
            this.button_VyberSoubor2.Name = "button_VyberSoubor2";
            this.button_VyberSoubor2.Size = new System.Drawing.Size(86, 23);
            this.button_VyberSoubor2.TabIndex = 9;
            this.button_VyberSoubor2.Text = "Vyber soubor 2";
            this.button_VyberSoubor2.UseVisualStyleBackColor = true;
            // 
            // button_VyberSoubor
            // 
            this.button_VyberSoubor.Location = new System.Drawing.Point(31, 31);
            this.button_VyberSoubor.Name = "button_VyberSoubor";
            this.button_VyberSoubor.Size = new System.Drawing.Size(86, 23);
            this.button_VyberSoubor.TabIndex = 8;
            this.button_VyberSoubor.Text = "Vyber soubor 1";
            this.button_VyberSoubor.UseVisualStyleBackColor = true;
            this.button_VyberSoubor.Click += new System.EventHandler(this.button_VyberSoubor_Click);
            // 
            // textBox_CestaNazevSouboru2
            // 
            this.textBox_CestaNazevSouboru2.Enabled = false;
            this.textBox_CestaNazevSouboru2.Location = new System.Drawing.Point(31, 116);
            this.textBox_CestaNazevSouboru2.Name = "textBox_CestaNazevSouboru2";
            this.textBox_CestaNazevSouboru2.Size = new System.Drawing.Size(474, 20);
            this.textBox_CestaNazevSouboru2.TabIndex = 7;
            // 
            // textBox_CestaNazevSouboru
            // 
            this.textBox_CestaNazevSouboru.Enabled = false;
            this.textBox_CestaNazevSouboru.Location = new System.Drawing.Point(31, 60);
            this.textBox_CestaNazevSouboru.Name = "textBox_CestaNazevSouboru";
            this.textBox_CestaNazevSouboru.Size = new System.Drawing.Size(474, 20);
            this.textBox_CestaNazevSouboru.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 218);
            this.Controls.Add(this.button_Kpoie2);
            this.Controls.Add(this.button_Kopie1);
            this.Controls.Add(this.button_VyberSoubor2);
            this.Controls.Add(this.button_VyberSoubor);
            this.Controls.Add(this.textBox_CestaNazevSouboru2);
            this.Controls.Add(this.textBox_CestaNazevSouboru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Kpoie2;
        private System.Windows.Forms.Button button_Kopie1;
        private System.Windows.Forms.Button button_VyberSoubor2;
        private System.Windows.Forms.Button button_VyberSoubor;
        private System.Windows.Forms.TextBox textBox_CestaNazevSouboru2;
        private System.Windows.Forms.TextBox textBox_CestaNazevSouboru;
    }
}

