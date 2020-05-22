using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ZvolitPredmety_Click(object sender, EventArgs e)
        {
            string vystup = "";
            bool strednik = false;

            if (checkBox1.Checked == true) { 
                vystup = checkBox1.Text;
                strednik = true;
            }
            if (checkBox2.Checked == true) { 
                vystup = strednik ? vystup + ";" + checkBox2.Text : checkBox2.Text;
                strednik = true;
            }
            if (checkBox3.Checked == true)
            {
                vystup = strednik ? vystup + ";" + checkBox3.Text : checkBox3.Text;
                strednik = true;
            }
            if (checkBox4.Checked == true)
            {
                vystup = strednik ? vystup + ";" + checkBox4.Text : checkBox4.Text;
                strednik = true;
            }
            if (checkBox5.Checked == true)
            {
                vystup = strednik ? vystup + ";" + checkBox5.Text : checkBox5.Text;
                strednik = true;
            }
            if (checkBox6.Checked == true)
            {
                vystup = strednik ? vystup + ";" + checkBox6.Text : checkBox6.Text;
            }

            //MessageBox.Show(vystup, "Zvolené předměty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label_Vystup.Text = vystup;
        }
    }

}
