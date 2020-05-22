using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_Heslo.Text == "FredFred")
            {
                MessageBox.Show("Přihlášení proběhlo úspěšně!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Přihlášení nebylo úspěšné!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_ZobrazitHeslo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ZobrazitHeslo.Checked == true)
            {
                textBox_Heslo.PasswordChar = default;
            }
            else
            {
                textBox_Heslo.PasswordChar = '*';
            }
        }
    }
}
