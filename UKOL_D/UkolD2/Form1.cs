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


namespace UkolD2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button_VyberSoubor_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string filePath = "";// Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = filePath;
            o.Filter = "Textový soubor|*.txt|csv-soubor|*.csv|xml-soubor|*.xml";
            if (o.ShowDialog() == DialogResult.OK)
            {
                fileName = o.FileName;
                textBox_CestaNazevSouboru.Text = fileName;
                var fi = new FileInfo(fileName);
                textBox_CestaNazevSouboru2.Text = Path.Combine(fi.DirectoryName, fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length) + "_copy" + fi.Extension);
                MessageBox.Show(String.Format("Zvolený soubor:\n{0}", fileName), "Informace o souboru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool MuzuKopirovat()
        {
            if (textBox_CestaNazevSouboru.Text.Length == 0)
            {
                MessageBox.Show("Nebyl zvolen vstupní soubor pro vytvoření kopie.", "Kopie souboru není možná", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CestaNazevSouboru2.Text.Length == 0)
            {
                MessageBox.Show("Nebyl zvolen výstupní soubor do kterého má být zkopírovaný vstupní soubor.", "Kopie souboru není možná", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CestaNazevSouboru.Text == textBox_CestaNazevSouboru2.Text)
            {
                MessageBox.Show("Vstupní a výstupní soubor je identický.", "Kopie souboru není možná", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button_Kopie1_Click_1(object sender, EventArgs e)
        {
            if (MuzuKopirovat())
            {
                try
                {
                    File.Copy(textBox_CestaNazevSouboru.Text, textBox_CestaNazevSouboru2.Text);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(String.Format("{0}\n{1}", "Původní soubro byl přepsán", ex.Message), "Kopie souboru", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    MessageBox.Show("Soubor byl úspěšně zkopírován metodou 1.", "Kopie souboru ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button_Kpoie2_Click_1(object sender, EventArgs e)
        {
            if (MuzuKopirovat())
            {
                StreamReader sr = null;
                StreamWriter sw = null;
                string ln;
                try
                {
                    sw = new StreamWriter(textBox_CestaNazevSouboru2.Text, false, Encoding.Default);
                    sr = new StreamReader(textBox_CestaNazevSouboru.Text, Encoding.Default);
                    while ((ln = sr.ReadLine()) != null)
                        sw.WriteLine(ln);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (sw != null)
                        sw.Close();
                    MessageBox.Show("Soubor byl úspěšně zkopírován metodou 2.", "Kopie souboru ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
