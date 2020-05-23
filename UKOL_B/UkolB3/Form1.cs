using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void Kontroluj(string text, ref int pocetMala, ref int pocetVelka, ref int pocetCelkem)
        {
            pocetCelkem = text.Length;
            for (int i = 0; i < pocetCelkem; i++)
            {
                if(Char.IsLower(text[i])) pocetMala++;
                if(Char.IsUpper(text[i])) pocetVelka++;
            }
        }

        private void button_Vyhodnotit_Click(object sender, EventArgs e)
        {
            int pocetCelkem = 0;
            int pocetMala = 0;
            int pocetVelka = 0;

            Kontroluj(richTextBox_ZdrojovyText.Text, ref pocetMala, ref pocetVelka, ref pocetCelkem);

            textBox_MaleZnaky.Text = pocetMala.ToString();
            textBox_VelkeZnaky.Text = pocetVelka.ToString();
            textBox_VsechnyZnaky.Text = pocetCelkem.ToString();
            
        }

    }
}
