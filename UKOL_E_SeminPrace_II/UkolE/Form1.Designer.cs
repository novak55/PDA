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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nástrojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seřaditSestupněToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sřaditVzestupněToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spravaKouleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstranitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
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
            this.groupBox2.Location = new System.Drawing.Point(247, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seznam koulí";
            // 
            // listBox_SeznamKouli
            // 
            this.listBox_SeznamKouli.FormattingEnabled = true;
            this.listBox_SeznamKouli.Location = new System.Drawing.Point(7, 19);
            this.listBox_SeznamKouli.Name = "listBox_SeznamKouli";
            this.listBox_SeznamKouli.Size = new System.Drawing.Size(423, 186);
            this.listBox_SeznamKouli.TabIndex = 6;
            this.listBox_SeznamKouli.SelectedIndexChanged += new System.EventHandler(this.listBox_SeznamKouli_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.nástrojeToolStripMenuItem,
            this.spravaKouleToolStripMenuItem,
            this.konecToolStripMenuItem,
            this.konecToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítToolStripMenuItem,
            this.uložitJakoToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.souborToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otevřítToolStripMenuItem.Text = "Otevřít";
            this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.otevřítToolStripMenuItem_Click);
            // 
            // uložitJakoToolStripMenuItem
            // 
            this.uložitJakoToolStripMenuItem.Name = "uložitJakoToolStripMenuItem";
            this.uložitJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.uložitJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uložitJakoToolStripMenuItem.Text = "Uložit jako";
            this.uložitJakoToolStripMenuItem.Click += new System.EventHandler(this.uložitJakoToolStripMenuItem_Click);
            // 
            // nástrojeToolStripMenuItem
            // 
            this.nástrojeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seřaditSestupněToolStripMenuItem,
            this.sřaditVzestupněToolStripMenuItem});
            this.nástrojeToolStripMenuItem.Name = "nástrojeToolStripMenuItem";
            this.nástrojeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.nástrojeToolStripMenuItem.Text = "Nástroje";
            // 
            // seřaditSestupněToolStripMenuItem
            // 
            this.seřaditSestupněToolStripMenuItem.Name = "seřaditSestupněToolStripMenuItem";
            this.seřaditSestupněToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D9)));
            this.seřaditSestupněToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.seřaditSestupněToolStripMenuItem.Text = "Seřadit sestupně";
            this.seřaditSestupněToolStripMenuItem.Click += new System.EventHandler(this.seřaditSestupněToolStripMenuItem_Click);
            // 
            // sřaditVzestupněToolStripMenuItem
            // 
            this.sřaditVzestupněToolStripMenuItem.Name = "sřaditVzestupněToolStripMenuItem";
            this.sřaditVzestupněToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.sřaditVzestupněToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sřaditVzestupněToolStripMenuItem.Text = "Sřadit vzestupně";
            this.sřaditVzestupněToolStripMenuItem.Click += new System.EventHandler(this.sřaditVzestupněToolStripMenuItem_Click);
            // 
            // spravaKouleToolStripMenuItem
            // 
            this.spravaKouleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravitToolStripMenuItem,
            this.odstranitToolStripMenuItem});
            this.spravaKouleToolStripMenuItem.Name = "spravaKouleToolStripMenuItem";
            this.spravaKouleToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.spravaKouleToolStripMenuItem.Text = "Správa koule";
            this.spravaKouleToolStripMenuItem.Visible = false;
            // 
            // upravitToolStripMenuItem
            // 
            this.upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            this.upravitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.upravitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upravitToolStripMenuItem.Text = "Upravit";
            this.upravitToolStripMenuItem.Click += new System.EventHandler(this.upravitToolStripMenuItem_Click);
            // 
            // odstranitToolStripMenuItem
            // 
            this.odstranitToolStripMenuItem.Name = "odstranitToolStripMenuItem";
            this.odstranitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.odstranitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odstranitToolStripMenuItem.Text = "Odstranit";
            this.odstranitToolStripMenuItem.Click += new System.EventHandler(this.odstranitToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.konecToolStripMenuItem.Text = "Nápověda";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem1
            // 
            this.konecToolStripMenuItem1.Name = "konecToolStripMenuItem1";
            this.konecToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.konecToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.konecToolStripMenuItem1.Text = "Konec";
            this.konecToolStripMenuItem1.Click += new System.EventHandler(this.konecToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PDA - úkol E semestrální práce 2. část";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nástrojeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seřaditSestupněToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sřaditVzestupněToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spravaKouleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstranitToolStripMenuItem;
    }
}

