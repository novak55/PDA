using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "\nJméno a příjmení: " + textBox_Jmeno.Text + " " + textBox_Prijmeni.Text + "\n\nAdresa: " + textBox_Ulice.Text + ", " + textBox_PSC.Text + " " + textBox_Mesto.Text + "\n\nE-mail: " + textBox_Email.Text + "\n\nTelefon: " + textBox_Telefon.Text;
            richTextBox_Vystup.Text = text;
        }
    }
}
