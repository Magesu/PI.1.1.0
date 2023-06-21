using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI._1._1._0
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float eixo = float.Parse(textBox4.Text);
            float peso = float.Parse(textBox1.Text);
            float dist = float.Parse(textBox2.Text);
            float bit = float.Parse(textBox3.Text);
            float F = (peso * dist) / 2;
            float D = bit / 2;
            float d = D - eixo;
            float Mola = (F * D) / d;
            float Mola1 = Mola * 10000;


            float eixo1 = float.Parse(textBox8.Text);
            float peso1 = float.Parse(textBox5.Text);
            float dist1 = float.Parse(textBox6.Text);
            float bit1 = float.Parse(textBox7.Text);
            float F1 = (peso1 * dist1) / 2;
            float D1 = bit1 / 2;
            float d1 = D1 - eixo1;
            float Mola12 = (F1 * D1) / d1;
            float Mola13 = Mola12 * 10000;


            MessageBox.Show("ola!" + " A Mola Dianteira é: " + Mola1 + "e" + " A mola traseira é: " + Mola13 + ".");
            
        }
    }
}
