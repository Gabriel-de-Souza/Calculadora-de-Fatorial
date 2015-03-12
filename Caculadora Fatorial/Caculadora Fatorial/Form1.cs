using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculadora_Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string result;

        private void bIterativa_Click(object sender, EventArgs e)
        {
            result = factorialIterativa(Double.Parse(enterValue.Text)).ToString();
            viewValue.Text = result;
        }

        private void bRecursiva_Click(object sender, EventArgs e)
        {
            result = factorialRecursiva(Double.Parse(enterValue.Text)).ToString();
            viewValue.Text = result;
        }

        private double factorialIterativa(double value)
        {
            double num = value;
            double factorial = num;
            for (double i = num - 1; i > 1; i--)
            {
                factorial *= i;
            }
            if (factorial <= 1) return factorial = 1;
            else return factorial;
        }

        private double factorialRecursiva(double value)
        {
            double num = value;
            if (num <= 1) return num = 1;
            else return num = num * factorialRecursiva(num - 1);
        }
    }
}
