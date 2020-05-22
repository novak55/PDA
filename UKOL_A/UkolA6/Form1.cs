using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolA6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetSelectedRadioButtonText(GroupBox predmet)
        {
            return predmet.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        private void button_ZvolitPredmet_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(GetSelectedRadioButtonText(groupBox1), "Zvolený předmět", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label_Vystup.Text = GetSelectedRadioButtonText(groupBox_DostupnePredmety);
        }

    }
}
