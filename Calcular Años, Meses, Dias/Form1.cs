using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Años__Meses__Dias
{
    public partial class Form1 : Form
    {
        int FN, FA, R1, R2, R3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FN = Convert.ToInt32(textBox1.Text);
            FA = Convert.ToInt32(textBox2.Text);
            R1 = FA - FN;
            textBox3.Text = R1.ToString();
            ///////
            R2 = R1 * 12;
            textBox4.Text = R2.ToString();
            /////////
            R3 = R1 * 365;
            textBox5.Text = R3.ToString();


        
        }
    }
}
