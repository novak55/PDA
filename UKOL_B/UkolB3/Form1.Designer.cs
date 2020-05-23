namespace UkolB3
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
            this.richTextBox_ZdrojovyText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Vyhodnotit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_VsechnyZnaky = new System.Windows.Forms.TextBox();
            this.textBox_VelkeZnaky = new System.Windows.Forms.TextBox();
            this.textBox_MaleZnaky = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_ZdrojovyText
            // 
            this.richTextBox_ZdrojovyText.Location = new System.Drawing.Point(24, 60);
            this.richTextBox_ZdrojovyText.Name = "richTextBox_ZdrojovyText";
            this.richTextBox_ZdrojovyText.Size = new System.Drawing.Size(418, 117);
            this.richTextBox_ZdrojovyText.TabIndex = 0;
            this.richTextBox_ZdrojovyText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadejte text k vyhodnocení";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.button_Vyhodnotit);
            this.groupBox1.Controls.Add(this.richTextBox_ZdrojovyText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zádávání";
            // 
            // button_Vyhodnotit
            // 
            this.button_Vyhodnotit.Location = new System.Drawing.Point(200, 203);
            this.button_Vyhodnotit.Name = "button_Vyhodnotit";
            this.button_Vyhodnotit.Size = new System.Drawing.Size(75, 23);
            this.button_Vyhodnotit.TabIndex = 2;
            this.button_Vyhodnotit.Text = "Vyhodnotit";
            this.button_Vyhodnotit.UseVisualStyleBackColor = true;
            this.button_Vyhodnotit.Click += new System.EventHandler(this.button_Vyhodnotit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_VsechnyZnaky);
            this.groupBox2.Controls.Add(this.textBox_VelkeZnaky);
            this.groupBox2.Controls.Add(this.textBox_MaleZnaky);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(490, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vyhodnocení";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Počty znaků:";
            // 
            // textBox_VsechnyZnaky
            // 
            this.textBox_VsechnyZnaky.Enabled = false;
            this.textBox_VsechnyZnaky.Location = new System.Drawing.Point(66, 135);
            this.textBox_VsechnyZnaky.Name = "textBox_VsechnyZnaky";
            this.textBox_VsechnyZnaky.Size = new System.Drawing.Size(89, 20);
            this.textBox_VsechnyZnaky.TabIndex = 5;
            // 
            // textBox_VelkeZnaky
            // 
            this.textBox_VelkeZnaky.Enabled = false;
            this.textBox_VelkeZnaky.Location = new System.Drawing.Point(66, 105);
            this.textBox_VelkeZnaky.Name = "textBox_VelkeZnaky";
            this.textBox_VelkeZnaky.Size = new System.Drawing.Size(89, 20);
            this.textBox_VelkeZnaky.TabIndex = 4;
            // 
            // textBox_MaleZnaky
            // 
            this.textBox_MaleZnaky.Enabled = false;
            this.textBox_MaleZnaky.Location = new System.Drawing.Point(66, 75);
            this.textBox_MaleZnaky.Name = "textBox_MaleZnaky";
            this.textBox_MaleZnaky.Size = new System.Drawing.Size(89, 20);
            this.textBox_MaleZnaky.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "všechny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "velké";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "malé";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ukol B3 - Vyhodnocení textu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_ZdrojovyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Vyhodnotit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_VsechnyZnaky;
        private System.Windows.Forms.TextBox textBox_VelkeZnaky;
        private System.Windows.Forms.TextBox textBox_MaleZnaky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

