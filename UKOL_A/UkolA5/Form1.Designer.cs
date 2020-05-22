namespace UkolA5
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
            this.groupBox_NabizenePredmety = new System.Windows.Forms.GroupBox();
            this.button_ZvolitPredmety = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Vystup = new System.Windows.Forms.Label();
            this.groupBox_NabizenePredmety.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_NabizenePredmety
            // 
            this.groupBox_NabizenePredmety.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox_NabizenePredmety.Controls.Add(this.button_ZvolitPredmety);
            this.groupBox_NabizenePredmety.Controls.Add(this.checkBox6);
            this.groupBox_NabizenePredmety.Controls.Add(this.checkBox5);
            this.groupBox_NabizenePredmety.Controls.Add(this.checkBox4);
            this.groupBox_NabizenePredmety.Controls.Add(this.checkBox3);
            this.groupBox_NabizenePredmety.Controls.Add(this.checkBox2);
            this.groupBox_NabizenePredmety.Controls.Add(this.checkBox1);
            this.groupBox_NabizenePredmety.Location = new System.Drawing.Point(19, 19);
            this.groupBox_NabizenePredmety.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox_NabizenePredmety.Name = "groupBox_NabizenePredmety";
            this.groupBox_NabizenePredmety.Size = new System.Drawing.Size(163, 283);
            this.groupBox_NabizenePredmety.TabIndex = 0;
            this.groupBox_NabizenePredmety.TabStop = false;
            this.groupBox_NabizenePredmety.Text = "Nabízené předměty";
            // 
            // button_ZvolitPredmety
            // 
            this.button_ZvolitPredmety.Location = new System.Drawing.Point(29, 238);
            this.button_ZvolitPredmety.Name = "button_ZvolitPredmety";
            this.button_ZvolitPredmety.Size = new System.Drawing.Size(107, 23);
            this.button_ZvolitPredmety.TabIndex = 6;
            this.button_ZvolitPredmety.Text = "Zvolit předměty";
            this.button_ZvolitPredmety.UseVisualStyleBackColor = true;
            this.button_ZvolitPredmety.Click += new System.EventHandler(this.button_ZvolitPredmety_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(13, 189);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Tag = "STA";
            this.checkBox6.Text = "Statistika";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(13, 158);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(103, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Tag = "LIN";
            this.checkBox5.Text = "Lineární algebra";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(13, 127);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Tag = "ANJ";
            this.checkBox4.Text = "Angličtina";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 96);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Tag = "FY";
            this.checkBox3.Text = "Fyzika";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 65);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Tag = "PRG";
            this.checkBox2.Text = "Programování";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 34);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "MAT";
            this.checkBox1.Text = "Matematika";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Vystup);
            this.groupBox2.Location = new System.Drawing.Point(195, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Výstup";
            // 
            // label_Vystup
            // 
            this.label_Vystup.AutoSize = true;
            this.label_Vystup.Location = new System.Drawing.Point(17, 31);
            this.label_Vystup.Name = "label_Vystup";
            this.label_Vystup.Size = new System.Drawing.Size(0, 13);
            this.label_Vystup.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_NabizenePredmety);
            this.Name = "Form1";
            this.Text = "CV 5.  Volba předmětů";
            this.groupBox_NabizenePredmety.ResumeLayout(false);
            this.groupBox_NabizenePredmety.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NabizenePredmety;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button_ZvolitPredmety;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Vystup;
    }
}

