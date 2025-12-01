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
        decimal valor1, valor2, resultado;
        string operacao = "Adicao";
        decimal convertePorcentagem;

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado = 0 ;
            valor1 = 0;
            valor2 = 0;
        }

        //variaveis



        //Operações
        private void button1_Click(object sender, EventArgs e)
        {
            operacao = "Adicao";

            if (operacao == "Adicao")
            {
                txtResultado.Text = valor1.ToString();
            }

            txtDisplay.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            operacao = "Subtracao";
            if (operacao == "Subtracao")
            {
                txtResultado.Text = valor1.ToString();
            }
            txtDisplay.Clear();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operacao = "Multiplicacao";


            if(operacao == "Multiplicacao")
            {
                txtResultado.Text = valor1.ToString();
            }
            txtDisplay.Clear();
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            operacao = "Porcentagem";
            convertePorcentagem =Decimal.Parse(txtDisplay.Text) /100;
            
        }

        private void maismenos_Click(object sender, EventArgs e)
        {
            decimal converteNegativo = Decimal.Parse(txtDisplay.Text);
            valor1 = (converteNegativo * (-1));
            txtDisplay.Text = valor1.ToString();
        }
        

        private void div_Click(object sender, EventArgs e)
        {
            operacao = "Divisao";

            if (operacao == "Divisao")
            {
                txtResultado.Text = valor1.ToString();
            }
            txtDisplay.Clear();
        }


        //numeros
        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += button1.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button2.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button3.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button4.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button5.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button6.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button7.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button8.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button9.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            txtDisplay.Text += button10.Text;
            valor1 = decimal.Parse(txtDisplay.Text);
        }

        

        private void virgula_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += virgula.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtResultado.Clear();
            txtDisplay.Focus();
        }

     

        private void igual_Click(object sender, EventArgs e)
        {
            if (operacao == "Adicao")
            {
                valor2 = decimal.Parse(txtResultado.Text);
                resultado = valor1 + valor2;
                txtResultado.Text = valor2.ToString() + " + " + valor1.ToString();
                txtDisplay.Text = resultado.ToString();

            }
            if (operacao == "Subtracao")
            {
                valor2 = decimal.Parse(txtResultado.Text);
                resultado = valor2 - valor1;
                txtResultado.Text = valor2.ToString() + " - " + valor1.ToString();
                txtDisplay.Text = resultado.ToString();
            }
            if(operacao == "Multiplicacao")
            {
                valor2 = decimal.Parse(txtResultado.Text);
                resultado = valor2 * valor1;
                txtResultado.Text = valor2.ToString() + " x " + valor1.ToString();
                txtDisplay.Text = resultado.ToString();
            }
            if (operacao == "Porcentagem")
            {
                resultado = convertePorcentagem * valor1;
                txtResultado.Text = valor1.ToString() + " * " + convertePorcentagem.ToString();
                txtDisplay.Text = resultado.ToString();
            }
            if (operacao == "Divisao")
            {
                valor2 = decimal.Parse(txtResultado.Text);
                resultado = valor2 / valor1;
                txtResultado.Text = valor2.ToString() + " / " + valor1.ToString();
                txtDisplay.Text = resultado.ToString();
            }
        }


      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
