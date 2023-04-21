using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsApp
{
    public partial class Form1 : Form
    {

        double num1 = 0;
        double num2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            
            var boton = ((Button)sender);
            if (boton.Text == "CE")
            {
                textBox.Text = "0";
            }
            else
            {
                if (textBox.Text == "0")
                    textBox.Text = "";
                textBox.Text += boton.Text;
            }
            
        }
        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = double.Parse(textBox.Text);
            operador = char.Parse(boton.Text);

            textBox.Text = "0";
        }

        private double CalcularPotencia()
        {
            double resultado = 1;
            for (int i = 0; i < Convert.ToInt32(num2); i++)
            {
                resultado *= num1;
            }
            return resultado;
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox.Text);
            switch (operador)
            {
                case '+':
                    textBox.Text = (num1 + num2).ToString();
                    num1 = double.Parse(textBox.Text);
                    break;
                case '-':
                    textBox.Text = (num1 - num2).ToString();
                    num1 = double.Parse(textBox.Text);
                    break;
                case 'x':
                    textBox.Text = (num1 * num2).ToString();
                    num1 = double.Parse(textBox.Text);
                    break;
                case '/':
                    textBox.Text = (num1 / num2).ToString();
                    num1 = double.Parse(textBox.Text);
                    break;
                case '^':
                    textBox.Text = CalcularPotencia().ToString();
                    break;
            }
        }
    }
}
