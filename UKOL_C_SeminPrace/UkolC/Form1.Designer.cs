namespace UkolC
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
            this.textBox_Cislo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Popis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_PridatKouli = new System.Windows.Forms.Button();
            this.textBox_Polomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_SeznamKouli = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel_Exporty = new System.Windows.Forms.Panel();
            this.button_DoXml = new System.Windows.Forms.Button();
            this.button_UlozitDoSouboru = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ZXml = new System.Windows.Forms.Button();
            this.button_ZCsv = new System.Windows.Forms.Button();
            this.button_OdstranitKouli = new System.Windows.Forms.Button();
            this.button_UpravitKouli = new System.Windows.Forms.Button();
            this.button_SeraditSestupne = new System.Windows.Forms.Button();
            this.button_SeraditVzestupne = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_Exporty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.textBox_Cislo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Popis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_PridatKouli);
            this.groupBox1.Controls.Add(this.textBox_Polomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zadání koule";
            // 
            // textBox_Cislo
            // 
            this.textBox_Cislo.Location = new System.Drawing.Point(102, 93);
            this.textBox_Cislo.Name = "textBox_Cislo";
            this.textBox_Cislo.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cislo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pořadové číslo:";
            // 
            // textBox_Popis
            // 
            this.textBox_Popis.Location = new System.Drawing.Point(102, 62);
            this.textBox_Popis.Name = "textBox_Popis";
            this.textBox_Popis.Size = new System.Drawing.Size(100, 20);
            this.textBox_Popis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zadejte popis: ";
            // 
            // button_PridatKouli
            // 
            this.button_PridatKouli.Location = new System.Drawing.Point(63, 153);
            this.button_PridatKouli.Name = "button_PridatKouli";
            this.button_PridatKouli.Size = new System.Drawing.Size(75, 23);
            this.button_PridatKouli.TabIndex = 4;
            this.button_PridatKouli.Text = "Přidat kouli";
            this.button_PridatKouli.UseVisualStyleBackColor = true;
            this.button_PridatKouli.Click += new System.EventHandler(this.button_PridatKouli_Click);
            // 
            // textBox_Polomer
            // 
            this.textBox_Polomer.Location = new System.Drawing.Point(102, 32);
            this.textBox_Polomer.Name = "textBox_Polomer";
            this.textBox_Polomer.Size = new System.Drawing.Size(100, 20);
            this.textBox_Polomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadejte poloměr: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_SeznamKouli);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seznam koulí";
            // 
            // listBox_SeznamKouli
            // 
            this.listBox_SeznamKouli.FormattingEnabled = true;
            this.listBox_SeznamKouli.Location = new System.Drawing.Point(7, 19);
            this.listBox_SeznamKouli.Name = "listBox_SeznamKouli";
            this.listBox_SeznamKouli.Size = new System.Drawing.Size(203, 186);
            this.listBox_SeznamKouli.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Controls.Add(this.panel_Exporty);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button_ZXml);
            this.groupBox3.Controls.Add(this.button_ZCsv);
            this.groupBox3.Controls.Add(this.button_OdstranitKouli);
            this.groupBox3.Controls.Add(this.button_UpravitKouli);
            this.groupBox3.Controls.Add(this.button_SeraditSestupne);
            this.groupBox3.Controls.Add(this.button_SeraditVzestupne);
            this.groupBox3.Location = new System.Drawing.Point(482, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 205);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Správa koule";
            // 
            // panel_Exporty
            // 
            this.panel_Exporty.Controls.Add(this.button_DoXml);
            this.panel_Exporty.Controls.Add(this.button_UlozitDoSouboru);
            this.panel_Exporty.Enabled = false;
            this.panel_Exporty.Location = new System.Drawing.Point(55, 102);
            this.panel_Exporty.Name = "panel_Exporty";
            this.panel_Exporty.Size = new System.Drawing.Size(131, 45);
            this.panel_Exporty.TabIndex = 7;
            // 
            // button_DoXml
            // 
            this.button_DoXml.Location = new System.Drawing.Point(70, 11);
            this.button_DoXml.Name = "button_DoXml";
            this.button_DoXml.Size = new System.Drawing.Size(61, 23);
            this.button_DoXml.TabIndex = 6;
            this.button_DoXml.Text = "do XML";
            this.button_DoXml.UseVisualStyleBackColor = true;
            this.button_DoXml.Click += new System.EventHandler(this.button_DoXml_Click);
            // 
            // button_UlozitDoSouboru
            // 
            this.button_UlozitDoSouboru.Location = new System.Drawing.Point(3, 11);
            this.button_UlozitDoSouboru.Name = "button_UlozitDoSouboru";
            this.button_UlozitDoSouboru.Size = new System.Drawing.Size(61, 23);
            this.button_UlozitDoSouboru.TabIndex = 4;
            this.button_UlozitDoSouboru.Text = "do CSV";
            this.button_UlozitDoSouboru.UseVisualStyleBackColor = true;
            this.button_UlozitDoSouboru.Click += new System.EventHandler(this.button_UlozitDoSouboru_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Import:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Export: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Úpravy: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Řazení: ";
            // 
            // button_ZXml
            // 
            this.button_ZXml.Location = new System.Drawing.Point(125, 153);
            this.button_ZXml.Name = "button_ZXml";
            this.button_ZXml.Size = new System.Drawing.Size(61, 23);
            this.button_ZXml.TabIndex = 7;
            this.button_ZXml.Text = "z XML";
            this.button_ZXml.UseVisualStyleBackColor = true;
            this.button_ZXml.Click += new System.EventHandler(this.button_ZXml_Click);
            // 
            // button_ZCsv
            // 
            this.button_ZCsv.Location = new System.Drawing.Point(58, 153);
            this.button_ZCsv.Name = "button_ZCsv";
            this.button_ZCsv.Size = new System.Drawing.Size(61, 23);
            this.button_ZCsv.TabIndex = 5;
            this.button_ZCsv.Text = "z CSV";
            this.button_ZCsv.UseVisualStyleBackColor = true;
            this.button_ZCsv.Click += new System.EventHandler(this.button_ZCsv_Click);
            // 
            // button_OdstranitKouli
            // 
            this.button_OdstranitKouli.Location = new System.Drawing.Point(125, 73);
            this.button_OdstranitKouli.Name = "button_OdstranitKouli";
            this.button_OdstranitKouli.Size = new System.Drawing.Size(61, 23);
            this.button_OdstranitKouli.TabIndex = 3;
            this.button_OdstranitKouli.Text = "odstranit";
            this.button_OdstranitKouli.UseVisualStyleBackColor = true;
            this.button_OdstranitKouli.Click += new System.EventHandler(this.button_OdstranitKouli_Click);
            // 
            // button_UpravitKouli
            // 
            this.button_UpravitKouli.Location = new System.Drawing.Point(58, 73);
            this.button_UpravitKouli.Name = "button_UpravitKouli";
            this.button_UpravitKouli.Size = new System.Drawing.Size(61, 23);
            this.button_UpravitKouli.TabIndex = 2;
            this.button_UpravitKouli.Text = "upravit";
            this.button_UpravitKouli.UseVisualStyleBackColor = true;
            this.button_UpravitKouli.Click += new System.EventHandler(this.button_UpravitKouli_Click);
            // 
            // button_SeraditSestupne
            // 
            this.button_SeraditSestupne.Location = new System.Drawing.Point(125, 32);
            this.button_SeraditSestupne.Name = "button_SeraditSestupne";
            this.button_SeraditSestupne.Size = new System.Drawing.Size(61, 23);
            this.button_SeraditSestupne.TabIndex = 1;
            this.button_SeraditSestupne.Text = "sestupně";
            this.button_SeraditSestupne.UseVisualStyleBackColor = true;
            this.button_SeraditSestupne.Click += new System.EventHandler(this.button_SeraditSestupne_Click);
            // 
            // button_SeraditVzestupne
            // 
            this.button_SeraditVzestupne.Location = new System.Drawing.Point(58, 32);
            this.button_SeraditVzestupne.Name = "button_SeraditVzestupne";
            this.button_SeraditVzestupne.Size = new System.Drawing.Size(61, 23);
            this.button_SeraditVzestupne.TabIndex = 0;
            this.button_SeraditVzestupne.Text = "vzestupně";
            this.button_SeraditVzestupne.UseVisualStyleBackColor = true;
            this.button_SeraditVzestupne.Click += new System.EventHandler(this.button_SeraditVzestupne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 233);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PDA - úkol C semestrální práce 1. část";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_Exporty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Popis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_PridatKouli;
        private System.Windows.Forms.TextBox textBox_Polomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Cislo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_SeznamKouli;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_OdstranitKouli;
        private System.Windows.Forms.Button button_UpravitKouli;
        private System.Windows.Forms.Button button_SeraditSestupne;
        private System.Windows.Forms.Button button_SeraditVzestupne;
        private System.Windows.Forms.Button button_ZCsv;
        private System.Windows.Forms.Button button_UlozitDoSouboru;
        private System.Windows.Forms.Button button_DoXml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ZXml;
        private System.Windows.Forms.Panel panel_Exporty;
    }
}

