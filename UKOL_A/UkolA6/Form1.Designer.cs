namespace UkolA6
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
            this.groupBox_DostupnePredmety = new System.Windows.Forms.GroupBox();
            this.button_ZvolitPredmet = new System.Windows.Forms.Button();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Vystup = new System.Windows.Forms.Label();
            this.groupBox_DostupnePredmety.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DostupnePredmety
            // 
            this.groupBox_DostupnePredmety.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox_DostupnePredmety.Controls.Add(this.button_ZvolitPredmet);
            this.groupBox_DostupnePredmety.Controls.Add(this.radioButton6);
            this.groupBox_DostupnePredmety.Controls.Add(this.radioButton5);
            this.groupBox_DostupnePredmety.Controls.Add(this.radioButton4);
            this.groupBox_DostupnePredmety.Controls.Add(this.radioButton3);
            this.groupBox_DostupnePredmety.Controls.Add(this.radioButton2);
            this.groupBox_DostupnePredmety.Controls.Add(this.radioButton1);
            this.groupBox_DostupnePredmety.Location = new System.Drawing.Point(25, 27);
            this.groupBox_DostupnePredmety.Name = "groupBox_DostupnePredmety";
            this.groupBox_DostupnePredmety.Size = new System.Drawing.Size(140, 246);
            this.groupBox_DostupnePredmety.TabIndex = 0;
            this.groupBox_DostupnePredmety.TabStop = false;
            this.groupBox_DostupnePredmety.Text = "Dostupné předměty";
            // 
            // button_ZvolitPredmet
            // 
            this.button_ZvolitPredmet.Location = new System.Drawing.Point(26, 199);
            this.button_ZvolitPredmet.Name = "button_ZvolitPredmet";
            this.button_ZvolitPredmet.Size = new System.Drawing.Size(85, 23);
            this.button_ZvolitPredmet.TabIndex = 6;
            this.button_ZvolitPredmet.Text = "Zvolit předmět";
            this.button_ZvolitPredmet.UseVisualStyleBackColor = true;
            this.button_ZvolitPredmet.Click += new System.EventHandler(this.button_ZvolitPredmet_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(19, 150);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(68, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "Statistika";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(19, 126);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(102, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Lineární algebra";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(19, 102);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Angličtina";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Fyzika";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Programování";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Matematika";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Vystup);
            this.groupBox2.Location = new System.Drawing.Point(190, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Výstup";
            // 
            // label_Vystup
            // 
            this.label_Vystup.AutoSize = true;
            this.label_Vystup.BackColor = System.Drawing.SystemColors.Control;
            this.label_Vystup.Location = new System.Drawing.Point(18, 24);
            this.label_Vystup.Name = "label_Vystup";
            this.label_Vystup.Size = new System.Drawing.Size(0, 13);
            this.label_Vystup.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_DostupnePredmety);
            this.Name = "Form1";
            this.Text = "CV 6. Volba předmětu";
            this.groupBox_DostupnePredmety.ResumeLayout(false);
            this.groupBox_DostupnePredmety.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DostupnePredmety;
        private System.Windows.Forms.Button button_ZvolitPredmet;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Vystup;
    }
}

