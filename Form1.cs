using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resulttxt.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Resulttxt.Text != "")
            {
                valor1 = decimal.Parse(Resulttxt.Text, CultureInfo.InvariantCulture);
                Resulttxt.Text = "";
                operation = "SOMA";
                Resultlbl.Text = "+";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Resulttxt.Text != "")
            {
                valor1 = decimal.Parse(Resulttxt.Text, CultureInfo.InvariantCulture);
                Resulttxt.Text = "";
                operation = "SUB";
                Resultlbl.Text = "-";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Resulttxt.Text != "")
            {
                valor1 = decimal.Parse(Resulttxt.Text, CultureInfo.InvariantCulture);
                Resulttxt.Text = "";
                operation = "MULT";
                Resultlbl.Text = "*";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Resulttxt.Text != "")
            {
                valor1 = decimal.Parse(Resulttxt.Text, CultureInfo.InvariantCulture);
                Resulttxt.Text = "";
                operation = "DIV";
                Resultlbl.Text = "/";
            }        }

        private void Resulttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Resulttxt.Text != "")
            {
                valor2 = decimal.Parse(Resulttxt.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                Resulttxt.Text = "É burro ou se faz de burro";
            }

            switch (operation)
            {
                case "SOMA":
                    Resulttxt.Text = Convert.ToString(valor1 + valor2);
                    break;

                case "SUB":
                    Resulttxt.Text = Convert.ToString(valor1 - valor2);
                    break;

                case "MULT":
                    Resulttxt.Text = Convert.ToString(valor1 * valor2);
                    break;

                case "DIV":
                    Resulttxt.Text = Convert.ToString(valor1 / valor2);
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Resulttxt.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Resulttxt.Text = "";
            valor1 = 0;
            valor2 = 0;
            Resultlbl.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Resulttxt.Text = Resulttxt.Text + ".";
        }
    }
}
