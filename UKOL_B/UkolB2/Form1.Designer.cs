namespace UkolB2
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
            this.textBox_Zdroj = new System.Windows.Forms.TextBox();
            this.textBox_Cil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_PropisTextu = new System.Windows.Forms.GroupBox();
            this.groupBox_PropisTextu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Zdroj
            // 
            this.textBox_Zdroj.Location = new System.Drawing.Point(116, 46);
            this.textBox_Zdroj.Name = "textBox_Zdroj";
            this.textBox_Zdroj.Size = new System.Drawing.Size(100, 20);
            this.textBox_Zdroj.TabIndex = 0;
            this.textBox_Zdroj.TextChanged += new System.EventHandler(this.textBox_Zdroj_TextChanged);
            // 
            // textBox_Cil
            // 
            this.textBox_Cil.Enabled = false;
            this.textBox_Cil.Location = new System.Drawing.Point(116, 85);
            this.textBox_Cil.Name = "textBox_Cil";
            this.textBox_Cil.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadejte text: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Propsaný text";
            // 
            // groupBox_PropisTextu
            // 
            this.groupBox_PropisTextu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_PropisTextu.Controls.Add(this.textBox_Cil);
            this.groupBox_PropisTextu.Controls.Add(this.label2);
            this.groupBox_PropisTextu.Controls.Add(this.textBox_Zdroj);
            this.groupBox_PropisTextu.Controls.Add(this.label1);
            this.groupBox_PropisTextu.Location = new System.Drawing.Point(23, 25);
            this.groupBox_PropisTextu.Name = "groupBox_PropisTextu";
            this.groupBox_PropisTextu.Size = new System.Drawing.Size(251, 149);
            this.groupBox_PropisTextu.TabIndex = 4;
            this.groupBox_PropisTextu.TabStop = false;
            this.groupBox_PropisTextu.Text = "Propisování textu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 203);
            this.Controls.Add(this.groupBox_PropisTextu);
            this.Name = "Form1";
            this.Text = "Úkol B2.  - Propisování textu";
            this.groupBox_PropisTextu.ResumeLayout(false);
            this.groupBox_PropisTextu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Zdroj;
        private System.Windows.Forms.TextBox textBox_Cil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_PropisTextu;
    }
}

