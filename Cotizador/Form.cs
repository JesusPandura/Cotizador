using calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizador
{
    public partial class Form : System.Windows.Forms.Form
    {
        double dolar= 0.0;
        double peso = 0.0;
        public Form()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dolar = 0.047 * double.Parse(textBox1.Text);

                textBox2.Text = dolar.ToString() ;
                textBox1.Clear();
                textBox1.Text = "0.0";


            }



            if (radioButton2.Checked)
            {
                peso = dolar / 0.047;

                textBox1.Text = peso.ToString();
                textBox2.Clear();
                textBox2.Text = "0.0";
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

