using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Zdroj_TextChanged(object sender, EventArgs e)
        {
            textBox_Cil.Text = textBox_Zdroj.Text.ToUpper();
        }
    }
}
