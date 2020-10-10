using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0.0;
        double numero2 = 0.0;
        string operador;

        calcula.Class.Sumar obj = new calcula.Class.Sumar();
        calcula.Class.Div obj2 = new calcula.Class.Div();
        calcula.Class.Resta obj3 = new calcula.Class.Resta();
        calcula.Class.mult obj4 = new calcula.Class.mult();

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
       
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
     
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
         
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text =  pantalla.Text + "6";
        

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text =  pantalla.Text + "7";
        
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text =  pantalla.Text + "8";
       
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text =  pantalla.Text +"9";
        
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            
            numero2 = double.Parse(pantalla.Text);
            
            double sum;
            double res;
            double div;
            double mult;

            switch (operador)
            {
                case "+":
                    sum = obj.sumar((numero1), (numero2));
                    pantalla.Text = sum.ToString();
                    break;
                case "-":
                    res = obj3.resta((numero1), (numero2));
                    pantalla.Text = res.ToString();
                    break;
                case "/":
                    div = obj2.div((numero1), (numero2));
                    pantalla.Text = div.ToString();
                    break;
                case "*":
                    mult= obj4.Mult((numero1), (numero2));
                    pantalla.Text = mult.ToString();
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
            limpiar();
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
           
            
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void limpiar() {
           
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
