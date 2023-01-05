using System;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (valor1 != 0)
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                switch (operacao)
                {
                    default:
                    case "SOMA":
                        txtResultado.Text = Convert.ToString(valor1 + valor2);
                        break;
                    case "SUB":
                        txtResultado.Text = Convert.ToString(valor1 - valor2);
                        break;
                    case "MULTI":
                        txtResultado.Text = Convert.ToString(valor1 * valor2);
                        break;
                    case "DIV":
                        txtResultado.Text = Convert.ToString(valor1 / valor2);
                        break;
                    case "":
                        MessageBox.Show("Faça uma operação primeiro");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Insira um valor primeiro");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "SUB";
            txtResultado.Text = "";
            lblOperecao.Text = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "MULTI";
            txtResultado.Text = "";
            lblOperecao.Text = "x";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "DIV";
            txtResultado.Text = "";
            lblOperecao.Text = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            lblOperecao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "SOMA";
            txtResultado.Text = "";
            lblOperecao.Text = "+";
        }
    }
}
