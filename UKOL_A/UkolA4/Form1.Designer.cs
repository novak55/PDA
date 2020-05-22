namespace UkolA4
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Heslo = new System.Windows.Forms.TextBox();
            this.checkBox_ZobrazitHeslo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox_ZobrazitHeslo);
            this.groupBox1.Controls.Add(this.textBox_Heslo);
            this.groupBox1.Controls.Add(this.textBox_Login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zadejte Vaše přihlašovací údaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heslo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login: ";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(66, 39);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 20);
            this.textBox_Login.TabIndex = 2;
            // 
            // textBox_Heslo
            // 
            this.textBox_Heslo.Location = new System.Drawing.Point(66, 72);
            this.textBox_Heslo.Name = "textBox_Heslo";
            this.textBox_Heslo.PasswordChar = '*';
            this.textBox_Heslo.Size = new System.Drawing.Size(100, 20);
            this.textBox_Heslo.TabIndex = 3;
            // 
            // checkBox_ZobrazitHeslo
            // 
            this.checkBox_ZobrazitHeslo.AutoSize = true;
            this.checkBox_ZobrazitHeslo.Location = new System.Drawing.Point(185, 74);
            this.checkBox_ZobrazitHeslo.Name = "checkBox_ZobrazitHeslo";
            this.checkBox_ZobrazitHeslo.Size = new System.Drawing.Size(90, 17);
            this.checkBox_ZobrazitHeslo.TabIndex = 4;
            this.checkBox_ZobrazitHeslo.Text = "zobrazit heslo";
            this.checkBox_ZobrazitHeslo.UseVisualStyleBackColor = true;
            this.checkBox_ZobrazitHeslo.CheckedChanged += new System.EventHandler(this.checkBox_ZobrazitHeslo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Přihlásit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Výchozí heslo je:  FredFred";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Přihlášení do systému";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_ZobrazitHeslo;
        private System.Windows.Forms.TextBox textBox_Heslo;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

