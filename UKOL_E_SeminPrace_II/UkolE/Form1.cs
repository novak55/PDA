using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UkolC
{
    public partial class Form1 : Form
    {
        SeznamKouli seznamKouli;
        int selectedInxedKoule = -1;
        string fileName = "koule";
        string filePath = "";// Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        public Form1()
        {
            InitializeComponent();
            seznamKouli = new SeznamKouli();
            
        }

        private void button_PridatKouli_Click(object sender, EventArgs e)
        {
            string popis;
            double polomer;
            uint cislo;

            if (selectedInxedKoule > -1)
            {
                seznamKouli.OdstranitKouli(selectedInxedKoule);
                ZpristupnitPolozkyKoule(true);
                selectedInxedKoule = -1;
            }
            try
            {
                polomer = Convert.ToDouble(textBox_Polomer.Text);
                cislo = Convert.ToUInt32(textBox_Cislo.Text);
                popis = textBox_Popis.Text.Trim();

                if (popis == string.Empty)
                    throw new FormatException("Nebyl zadán žádný popis!");

                Koule k = new Koule(polomer, popis, cislo);
                seznamKouli.VlozitKouli(k);
                refresh_SeznamKouli();
                MessageBox.Show("Koule byla úspěšně vložena", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFormulareKoule();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(String.Format("{0}\n{1}", "Chybně zadaná data", ex.Message), "Neúspěšné zadání", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyException_KouleExistujiciCislo ex)
            {
                MessageBox.Show(String.Format("{0}\n{1}", "Duplicitně zadaná data", ex.Message), "Neúspěšné zadání", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZpristupnitPolozkyKoule(bool v, string popisTlacitka = "Přidat kouli")
        {
            textBox_Cislo.Enabled = v;
            listBox_SeznamKouli.Enabled = v;
            button_PridatKouli.Text = popisTlacitka;

        }

        private void ResetFormulareKoule()
        {
            textBox_Cislo.Text = "";
            textBox_Polomer.Text = "";
            textBox_Popis.Text = "";

        }

        private void refresh_SeznamKouli()
        {
            listBox_SeznamKouli.DataSource = null;
            listBox_SeznamKouli.DataSource = seznamKouli.list_SeznamKouli;
            spravaKouleToolStripMenuItem.Visible = false;
        }

        private void listBox_SeznamKouli_SelectedIndexChanged(object sender, EventArgs e)
        {
            spravaKouleToolStripMenuItem.Visible = true;
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = filePath;
            o.Filter = "csv-soubor|*.csv|xml-soubor|*.xml";
            if (o.ShowDialog() == DialogResult.OK)
            {
                fileName = o.FileName;
                var fi = new FileInfo(fileName);
                string info = "";
                if (fi.Extension == ".csv")
                    info = new CsvFile().ImortujZCsv(seznamKouli, fi.DirectoryName, fi.Name);
                else
                    info = new XmlFile().ImortujZXml(seznamKouli, fi.DirectoryName, fi.Name);
                
                MessageBox.Show(info, "Informace o impurtu souboru", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh_SeznamKouli();
            }
        }

        private void uložitJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog o = new SaveFileDialog();
            o.InitialDirectory = filePath;
            o.Filter = "csv-soubor|*.csv|xml-soubor|*.xml";
            if (o.ShowDialog() == DialogResult.OK)
            {
                fileName = o.FileName;
                var fi = new FileInfo(fileName);
                string info = "";

                if (fi.Extension == ".csv")
                    info = new CsvFile().UlozDoCsv(seznamKouli, fi.DirectoryName, fi.Name);
                else
                    info = new XmlFile().UlozDoXml(fi.DirectoryName, fi.Name, seznamKouli);

                MessageBox.Show(info, "Informace o uložení souboru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seřaditSestupněToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seznamKouli.SeraditDlePolomeru("desc");
            refresh_SeznamKouli();
        }

        private void sřaditVzestupněToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seznamKouli.SeraditDlePolomeru();
            refresh_SeznamKouli();

        }

        private void upravitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_SeznamKouli.SelectedIndex == -1)
            {
                MessageBox.Show("Nebyla zvolena žádná koule pro úpravy!", "Chybové hlášení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectedInxedKoule = listBox_SeznamKouli.SelectedIndex;
            Koule k = seznamKouli.GetKouleByIndex(selectedInxedKoule);
            textBox_Popis.Text = k.popis;
            textBox_Cislo.Text = k.cislo.ToString();
            textBox_Polomer.Text = k.polomer.ToString();
            ZpristupnitPolozkyKoule(false, "Upravit kouli");

        }

        private void odstranitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_SeznamKouli.SelectedIndex == -1)
            {
                MessageBox.Show("Nebyla zvolena žádná koule k odstranění!", "Chybové hlášení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            seznamKouli.OdstranitKouli(listBox_SeznamKouli.SelectedIndex);
            refresh_SeznamKouli();
        }

        private void konecToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Skutečně si přejete ukončit aplikaci?", "Ukončení aplikce", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NapovedaOProgramu op = new NapovedaOProgramu();
            op.ShowDialog();
        }
    }
}
