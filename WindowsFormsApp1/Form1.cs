using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal resultado;
        decimal valor1;
        decimal valor2;
        string operacao = "Adicao";

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado = 0;
            valor1 = 0;
            valor2 = 0;
        }

        //variaveis



        //Operações
        private void button1_Click(object sender, EventArgs e)
        {
            operacao == "Adicao";

            if (operacao == "Adicao")
            {
                textBox3.Text = valor1.ToString() + " + ";
            }

            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            
        }

        private void multi_Click(object sender, EventArgs e)
        {
            
        }

        private void div_Click(object sender, EventArgs e)
        {
           
        }


        //numeros
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal resultado = 0;
            decimal valor1 = 0;
            decimal valor2 = 0;
        }
    }
}
