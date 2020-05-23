using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            try { p.SetX(Convert.ToDouble(textBox_X.Text)); }
            catch (System.FormatException)
            {
                MessageBox.Show("Nebyla zadána číselná hodnota pro souřadnici X!", "Chybný vstupní formát dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try { p.SetY(Convert.ToDouble(textBox_Y.Text)); }
            catch (System.FormatException)
            {
                MessageBox.Show("Nebyla zadána číselná hodnota pro souřadnici Y!", "Chybný vstupní formát dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ZpracujBod zb = new ZpracujBod(p);

            label_Kvadrant.Text = zb.GetKvadrant();
            textBox_Vzdalenost.Text = zb.GetVzdalenost().ToString();
            textBox_Stupen.Text = zb.GetStupen().ToString();
            textBox_Rad.Text = zb.GetRadian().ToString();

        }
    }
}
