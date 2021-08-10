using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_original
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool divisao = false;
        bool multiplicacao = false;
        bool resto = false;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "0";
            txtResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResultado.Text);
            txtOperacao.Text += "+";
            txtResultado.Clear();
            adicao = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResultado.Text); 
            txtOperacao.Text += "-";
            txtResultado.Clear();
            subtracao = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResultado.Text);
            txtOperacao.Text += "/";
            txtResultado.Clear();
            divisao = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResultado.Text);
            txtOperacao.Text += "*";
            txtResultado.Clear();
            multiplicacao = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(txtResultado.Text);
            txtOperacao.Text += "%";
            txtResultado.Clear();
            resto = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
            txtResultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
            txtResultado.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "3";
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "4";
            txtResultado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "5";
            txtResultado.Text += "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "6";
            txtResultado.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "7";
            txtResultado.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "8";
            txtResultado.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "9";
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += ",";
            txtResultado.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtOperacao.Clear();
            txtResultado.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            if (adicao == true)
            {
                txtResultado.Text = Convert.ToString(decimal.Parse(txtResultado.Text) + calculo);             
            }

            else if (subtracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo - decimal.Parse(txtResultado.Text));
            }

            else if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo / decimal.Parse(txtResultado.Text));
            }

            else if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(decimal.Parse(txtResultado.Text) * calculo);
            }  

            else if (resto  == true)
            {
                txtResultado.Text = Convert.ToString(calculo % decimal.Parse(txtResultado.Text));
            }
        }
    }
}
